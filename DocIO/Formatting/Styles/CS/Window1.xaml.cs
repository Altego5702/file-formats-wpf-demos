#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion
using System;
using System.Windows;
using System.Windows.Media;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
using System.ComponentModel;
using Syncfusion.Windows.Shared;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;
using System.IO;

namespace UsingBuiltInStyles
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : ChromelessWindow
    {
        # region Constructor
        /// <summary>
        /// Window constructor
        /// </summary>
        public Window1()
        {
            InitializeComponent();
            ImageSourceConverter img = new ImageSourceConverter();
#if NETCORE
            image1.Source = (ImageSource)img.ConvertFromString(@"..\..\..\..\..\..\..\Common\Images\DocIO\docio_header.png");
            this.Icon =(ImageSource)img.ConvertFromString(@"..\..\..\..\..\..\..\Common\Images\DocIO\sfLogo.ico");
#else
            image1.Source = (ImageSource)img.ConvertFromString(@"..\..\..\..\..\..\Common\Images\DocIO\docio_header.png");
            this.Icon = (ImageSource)img.ConvertFromString(@"..\..\..\..\..\..\Common\Images\DocIO\sfLogo.ico");
#endif 
        }
        # endregion

        #region Events
        /// <summary>
        /// Creates word document with built - in styles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WordDocument document = new WordDocument();
                WSection section = document.AddSection() as WSection;
                WParagraph para = section.AddParagraph() as WParagraph;

                section.AddColumn(100, 100);
                section.AddColumn(100, 100);
                section.MakeColumnsEqual();

                # region List Style

                //List
                //para = section.AddParagraph() as WParagraph;
                para.AppendText("This para is written with style List").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.List);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                //List5 style
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style List5").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.List5);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                # region ListNumber Style

                //List Number style
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListNumber").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListNumber);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                //List Number5 style
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListNumber5").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListNumber5);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                # region TOA Heading Style

                //TOA Heading
                para = section.AddParagraph() as WParagraph;
                para.ParagraphFormat.AfterSpacing = 10;
                para.AppendText("\nThis para is written with style TOA Heading").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ToaHeading);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                section.BreakCode = SectionBreakCode.NewColumn;

                # region ListBullet Style
                //ListBullet
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListBullet").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListBullet);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                //ListBullet5
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListBullet5").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListBullet5);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                # region List Continue Style

                //ListContinue
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListContinue").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListContinue);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                //ListContinue5
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style ListContinue5").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.ListContinue5);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                # region HTMLSample Style

                //HtmlSample
                para = section.AddParagraph() as WParagraph;
                para.AppendText("\nThis para is written with style HtmlSample").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.HtmlSample);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                section = document.AddSection() as WSection;
                section.BreakCode = SectionBreakCode.NoBreak;

                # region Document Map Style

                //Docuemnt Map
                para = section.AddParagraph() as WParagraph;
                para.AppendText("This para is written with style DocumentMap\n").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.DocumentMap);
                para.AppendText("Google Chrome\n").CharacterFormat.TextColor = System.Drawing.Color.White;
                para.AppendText("Mozilla Firefox\n").CharacterFormat.TextColor = System.Drawing.Color.White;
                para.AppendText("Internet Explorer").CharacterFormat.TextColor = System.Drawing.Color.White;

                #endregion

                # region Heading Styles
                //Heading Styles
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading1);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading2);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading3);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading4);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading5);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading6);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading7);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading8);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.Heading9);
                para.AppendText("Hello World. This para is written with style " + para.StyleName.ToString());

                # endregion

                # region MessageHeaderStyle

                //MessageHeader
                para = section.AddParagraph() as WParagraph;
                para = section.AddParagraph() as WParagraph;
                para.AppendText("This para is written with style MessageHeader\n").CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                para = section.AddParagraph() as WParagraph;
                para.ApplyStyle(BuiltinStyle.MessageHeader);
                para.AppendText("Google Chrome\n");
                para.AppendText("Mozilla Firefox\n");
                para.AppendText("Internet Explorer");

                # endregion

                # region Save Document

                //Save as doc format
                if (worddoc.IsChecked.Value)
                {
                    //Saving the document to disk.
                    document.Save("Sample.doc");

                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.doc") { UseShellExecute = true };
                        process.Start();
#else
                        System.Diagnostics.Process.Start("Sample.doc");
#endif
                        //Exit
                        this.Close();
                    }
                }

                //Save as docx format
                else if (worddocx.IsChecked.Value)
                {
                    //Saving the document as .docx
                    document.Save("Sample.docx", FormatType.Docx);
                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.docx") { UseShellExecute = true };
                            process.Start();
#else
                            System.Diagnostics.Process.Start("Sample.docx");
#endif
                            //Exit
                            this.Close();
                        }
                        catch (Win32Exception ex)
                        {
                            MessageBox.Show("Microsoft Word Viewer or Microsoft Word is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }

                //Save as pdf format
                else if (pdf.IsChecked.Value)
                {
                    DocToPDFConverter converter = new DocToPDFConverter();
                    //Convert word document into PDF document
                    PdfDocument pdfDoc = converter.ConvertToPDF(document);
                    //Save the pdf file
                    pdfDoc.Save("Sample.pdf");
                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the generated PDF?", " Document has been created", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        try
                        {
#if NETCORE
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.pdf") { UseShellExecute = true };
                            process.Start();
#else
                            System.Diagnostics.Process.Start("Sample.pdf");
#endif
                            //Exit
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("PDF Viewer is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                else
                {
                    // Exit
                    this.Close();
                }

                # endregion
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                #region Custom styles
                WordDocument document = new WordDocument();
                IWParagraphStyle style = null;
                // Adding a new section to the document.
                WSection section = document.AddSection() as WSection;
                //Set Margin of the section
                section.PageSetup.Margins.All = 72;
                IWParagraph par = document.LastSection.AddParagraph();
                WTextRange range = par.AppendText("Using CustomStyles") as WTextRange;
                range.CharacterFormat.TextBackgroundColor = System.Drawing.Color.Red;
                range.CharacterFormat.TextColor = System.Drawing.Color.White;
                range.CharacterFormat.FontSize = 18f;
                document.LastParagraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

                // Create Paragraph styles
                style = document.AddParagraphStyle("MyStyle_Normal");
                style.CharacterFormat.FontName = "Bitstream Vera Serif";
                style.CharacterFormat.FontSize = 10f;
                style.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify;
                style.CharacterFormat.TextColor = System.Drawing.Color.FromArgb(0, 21, 84);

                style = document.AddParagraphStyle("MyStyle_Low");
                style.CharacterFormat.FontName = "Times New Roman";
                style.CharacterFormat.FontSize = 16f;
                style.CharacterFormat.Bold = true;

                style = document.AddParagraphStyle("MyStyle_Medium");
                style.CharacterFormat.FontName = "Monotype Corsiva";
                style.CharacterFormat.FontSize = 18f;
                style.CharacterFormat.Bold = true;
                style.CharacterFormat.TextColor = System.Drawing.Color.FromArgb(51, 66, 125);

                style = document.AddParagraphStyle("Mystyle_High");
                style.CharacterFormat.FontName = "Bitstream Vera Serif";
                style.CharacterFormat.FontSize = 20f;
                style.CharacterFormat.Bold = true;
                style.CharacterFormat.TextColor = System.Drawing.Color.FromArgb(242, 151, 50);

                IWParagraph paragraph = null;
                for (int i = 0; i < document.Styles.Count; i++)
                {
                    //Skip to apply the document default styles and also paragraph style. 
                    if (document.Styles[i].Name == "Normal" || document.Styles[i].Name == "Default Paragraph Font"
                       || document.Styles[i].StyleType != StyleType.ParagraphStyle)
                        continue;
                    // Getting styles from Document.
                    style = (IWParagraphStyle)document.Styles[i];
                    // Adding a new paragraph
                    section.AddParagraph();
                    paragraph = section.AddParagraph();
                    // Applying styles to the current paragraph.
                    paragraph.ApplyStyle(style.Name);
                    // Writing Text with the current style and formatting.
                    paragraph.AppendText("Northwind Database with [" + style.Name + "] Style");
                    // Adding a new paragraph
                    section.AddParagraph();
                    paragraph = section.AddParagraph();
                    // Applying another style to the current paragraph.
                    paragraph.ApplyStyle("MyStyle_Normal");
                    // Writing text with current style.
                    paragraph.AppendText("The Northwind sample database (Northwind.mdb) is included with all versions of Access. It provides data you can experiment with and database objects that demonstrate features you might want to implement in your own databases. Using Northwind, you can become familiar with how a relational database is structured and how the database objects work together to help you enter, store, manipulate, and print your data.");
                }
                #endregion Custom styles

                # region Save Document

                //Save as doc format
                if (worddoc.IsChecked.Value)
                {
                    try
                    {
                        //Saving the document to disk.
                        document.Save("Sample.doc");

                        //Message box confirmation to view the created document.
                        if (MessageBox.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                        {
                            try
                            {
                                //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                                System.Diagnostics.Process process = new System.Diagnostics.Process();
                                process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.doc") { UseShellExecute = true };
                                process.Start();
#else
                                System.Diagnostics.Process.Start("Sample.doc");
#endif
                                //Exit
                                this.Close();
                            }
                            catch (Win32Exception ex)
                            {
                                MessageBox.Show("Microsoft Word Viewer or Microsoft Word is not installed in this system");
                                Console.WriteLine(ex.ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex is IOException)
                            MessageBox.Show("Please close the file (" + Directory.GetCurrentDirectory() + "\\Sample.doc" + ") then try generating the document.", "File is already open",
                                 MessageBoxButton.OK, MessageBoxImage.Error);
                        else
                            MessageBox.Show("Document could not be generated, Could you please email the error details to support@syncfusion.com for trouble shooting"+ "\r\n" + ex.ToString(), "Error",
                                    MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

                //Save as docx format
                else if (worddocx.IsChecked.Value)
                {
                    try
                    {
                        //Saving the document as .docx
                        document.Save("Sample.docx", FormatType.Docx);
                        //Message box confirmation to view the created document.
                        if (MessageBox.Show("Do you want to view the generated Word document?", "Document has been created", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                        {
                            try
                            {
                                //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
#if NETCORE
                                System.Diagnostics.Process process = new System.Diagnostics.Process();
                                process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.docx") { UseShellExecute = true };
                                process.Start();
#else
                                System.Diagnostics.Process.Start("Sample.docx");
#endif
                                //Exit
                                this.Close();
                            }
                            catch (Win32Exception ex)
                            {
                                MessageBox.Show("Microsoft Word Viewer or Microsoft Word is not installed in this system");
                                Console.WriteLine(ex.ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex is IOException)
                            MessageBox.Show("Please close the file (" + Directory.GetCurrentDirectory() + "\\Sample.doc" + ") then try generating the document.", "File is already open",
                                 MessageBoxButton.OK, MessageBoxImage.Error);
                        else
                            MessageBox.Show("Document could not be generated, Could you please email the error details to support@syncfusion.com for trouble shooting"+ "\r\n" + ex.ToString(), "Error",
                                    MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

                //Save as pdf format
                else if (pdf.IsChecked.Value)
                {
                    try
                    {
                        DocToPDFConverter converter = new DocToPDFConverter();
                        //Convert word document into PDF document
                        PdfDocument pdfDoc = converter.ConvertToPDF(document);
                        //Save the pdf file
                        pdfDoc.Save("Sample.pdf");
                        //Message box confirmation to view the created document.
                        if (MessageBox.Show("Do you want to view the generated PDF?", " Document has been created", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            try
                            {
#if NETCORE
                                System.Diagnostics.Process process = new System.Diagnostics.Process();
                                process.StartInfo = new System.Diagnostics.ProcessStartInfo("Sample.pdf") { UseShellExecute = true };
                                process.Start();
#else
                                System.Diagnostics.Process.Start("Sample.pdf");
#endif
                                //Exit
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("PDF Viewer is not installed in this system");
                                Console.WriteLine(ex.ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex is IOException)
                            MessageBox.Show("Please close the file (" + Directory.GetCurrentDirectory() + "\\Sample.doc" + ") then try generating the document.", "File is already open",
                                 MessageBoxButton.OK, MessageBoxImage.Error);
                        else
                            MessageBox.Show("Document could not be generated, Could you please email the error details to support@syncfusion.com for trouble shooting"+ "\r\n" + ex.ToString(), "Error",
                                    MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    // Exit
                    this.Close();
                }

                # endregion
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
