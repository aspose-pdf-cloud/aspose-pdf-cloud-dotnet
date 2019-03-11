using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.IO;
using System;

namespace Aspose.Pdf.Cloud.Sdk.TextAPI
{

    public class TextExamples
    {
        private const string Name = "4pages.pdf";
        
        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
        string FolderName = "";

        
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }

        public void GetTextTest()
        {
            var response = api.GetText(Name, LLX: 0, LLY: 0, URX: 0, URY: 0, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageTextTest()
        {
            var format = new List<string> { "First Page", "Second Page" };
            var response = api.GetPageText(Name, pageNumber: 1, LLX: 0, LLY: 0, URX: 0, URY: 0, folder: FolderName, format: format);
           
        }


        public void PutAddTextTest()
        {
            var paragraph = new Paragraph(
                Rectangle: new Rectangle(100, 100, 200, 200),
                LeftMargin: 10,
                RightMargin: 10,
                TopMargin: 20,
                BottomMargin: 20,
                HorizontalAlignment: TextHorizontalAlignment.FullJustify,
                LineSpacing: LineSpacing.FontSize,
                Rotation: 10,
                SubsequentLinesIndent: 20,
                VerticalAlignment: VerticalAlignment.Center,
                WrapMode: WrapMode.ByWords,

                Lines: new List<TextLine>
                {
                    new TextLine(
                        HorizontalAlignment: TextHorizontalAlignment.Right,
                        Segments: new List<Segment>
                        {
                            new Segment(
                                Value: "segment 1",
                                TextState: new TextState(
                                    Font: "Arial",
                                    FontSize: 10,
                                    ForegroundColor: new Color(0x00, 0x00, 0xFF, 0x00),
                                    BackgroundColor: new Color(0x00, 0xFF, 0x00, 0x00),
                                    FontStyle: FontStyles.Bold
                                )
                            )
                        }
                    )
                }
            );

            var response = api.PutAddText(Name, 1, paragraph, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}