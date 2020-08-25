using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Text Api
    /// </summary>
    [TestFixture]
    public class TextTests : TestsBase
    {
        private const string Name = "4pages.pdf";

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetText
        /// </summary>
        [Test]
        public void GetTextTest()
        {
            var response = PdfApi.GetText(Name, LLX: 0, LLY: 0, URX: 0, URY: 0, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageText
        /// </summary>
        [Test]
        public void GetPageTextTest()
        {
            var format = new List<string> { "First Page", "Second Page" };
            var response = PdfApi.GetPageText(Name, pageNumber: 1, LLX: 0, LLY: 0, URX: 0, URY: 0, folder: TempFolder, format: format);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutAddText
        /// </summary>
        [Test]
        public void PutAddTextTest()
        {
            const string fontFile = "Righteous-Regular.ttf";
            UploadFile(fontFile, fontFile);
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
                                    Font: "Righteous",
                                    FontSize: 10,
                                    ForegroundColor: new Color(0x00, 0x00, 0xFF, 0x00),
                                    BackgroundColor: new Color(0x00, 0xFF, 0x00, 0x00),
                                    FontStyle: FontStyles.Regular,
                                    FontFile: Path.Combine(TempFolder, fontFile)
                                )
                            )
                        }
                    )
                }
            );

            var response = PdfApi.PutAddText(Name, 1, paragraph, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}