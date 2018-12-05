using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.XlsIO;
using System.ComponentModel;
using Syncfusion.Windows.Shared;

namespace Treemap
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : ChromelessWindow
    {

        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion
        ExcelEngine excelEngine;

        public Window1()
        {
            InitializeComponent();
            ImageSourceConverter img = new ImageSourceConverter();
            string file = @"..\..\..\..\..\..\..\Common\Images\XlsIO\xlsio_header.png";
            this.image1.Source = (ImageSource)img.ConvertFromString(file);           
            excelEngine = new ExcelEngine();
            excelEngine.Excel.DefaultVersion = ExcelVersion.Excel2016;
        }
        #region HelperMethods

        #region Get File Path
        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }
        #endregion       

        #endregion

        #region Creating 2016 Charts

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            #region Workbook Initialize
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("TreemapTemplate.xlsx");
            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic);
            #endregion

            IWorksheet sheet = workbook.Worksheets[0];
            IChart chart = null;
            if (this.rdbChartSheet.IsChecked != null && this.rdbChartSheet.IsChecked.Value)
                chart = workbook.Charts.Add();
            else
                chart = workbook.Worksheets[0].Charts.Add();

            #region Treemap Chart Settings
            chart.ChartType = ExcelChartType.TreeMap;
            chart.DataRange = sheet["A1:F13"];
            chart.ChartTitle = "Daily Food Sales";
            foreach (IChartSerie serie in chart.Series)
            {
                serie.SerieFormat.TreeMapLabelOption = ExcelTreeMapLabelOption.Banner;
            }
            #endregion
           
            chart.Legend.Position = ExcelLegendPosition.Top;


            if (this.rdbChartSheet.IsChecked != null && this.rdbChartSheet.IsChecked.Value)
                chart.Activate();
            else
            {
                workbook.Worksheets[0].Activate();
                IChartShape chartShape = chart as IChartShape;
                chartShape.TopRow = 1;
                chartShape.BottomRow = 22;
                chartShape.LeftColumn = 8;
                chartShape.RightColumn = 15;
            }

            #region Workbook Save and Close
            string outFileName = "Treemap_Chart.xlsx";
            workbook.SaveAs(outFileName);
            workbook.Close();
            #endregion

            OpenOutput(outFileName);
        }

        #region Open the Output File
        private void OpenOutput(string fileName)
        {
            try
            {
                //Message box confirmation to view the created spreadsheet.
                if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                    MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    try
                    {
                        //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                        System.Diagnostics.Process.Start(fileName);
                        this.Close();
                    }
                    catch (Win32Exception ex)
                    {
                        MessageBox.Show("Excel 2007 is not installed in this system");
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sorry, Excel can't open two workbooks with the same name at the same time.\nPlease close the workbook and try again.", "File is already open", MessageBoxButton.OK);
            }
        }
        #endregion

        #endregion

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            excelEngine.Dispose();
        }

        #region View the Input file
        private void btnInputTemplate_Click(object sender, RoutedEventArgs e)
        {
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("TreemapTemplate.xlsx");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion
     
    }
}
