// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ParagraphsTests.cs">
//   Copyright (c) 2018 Aspose.PDF Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Paragraphs Api
    /// </summary>
    [TestFixture]
    public class ParagraphsTests : TestsBase
    {
        /// <summary>
        /// Test PutAddText
        /// </summary>
        [Test]
        public void PutAddTextTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

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
                    new TextLine
                    {
                        HorizontalAlignment = TextHorizontalAlignment.Right,
                        Segments = new List<Segment>
                        {
                            new Segment
                            {
                                Value = "segment 1",
                                TextState = new TextState(
                                    Font: "Arial",
                                    FontSize: 10,
                                    ForegroundColor: new Color(0x00, 0x00, 0xFF, 0x00),
                                    BackgroundColor: new Color(0x00, 0xFF, 0x00, 0x00),
                                    FontStyle: FontStyles.Bold
                                )
                            }
                        }
                    }
                }
            );

            var response = PdfApi.PutAddText(name, 1, paragraph, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
