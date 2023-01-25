// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ScreenAnnotationsTests.cs">
//   Copyright (c) 2023 Aspose.PDF Cloud
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
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Stamp Api
    /// </summary>
    [TestFixture]
    class StampsTests : TestsBase
    {
        private const string Name = "PageNumberStamp.pdf";
        private const int PageNumber = 1;
        
        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test DeleteDocumentStamps
        /// </summary>
        [Test]
        public void DeleteDocumentStampsTest()
        {
            var response = PdfApi.DeleteDocumentStamps(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetDocumentStamps
        /// </summary>
        [Test]
        public void GetDocumentStampsTest()
        {
            var response = PdfApi.GetDocumentStamps(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageStamps
        /// </summary>
        [Test]
        public void GetPageStampsTest()
        {
            var response = PdfApi.GetPageStamps(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeletePageStamps
        /// </summary>
        [Test]
        public void DeletePageStampsTest()
        {
            var response = PdfApi.DeletePageStamps(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageTextStamps
        /// </summary>
        [Test]
        public void PostPageTextStampsTest()
        {
            List<TextStamp> stamps = new List<TextStamp>
            {
                new TextStamp()
                {
                    Background = true,
                    LeftMargin = 1,
                    RightMargin = 2,
                    TopMargin = 3,
                    BottomMargin = 4,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    Opacity = 1,
                    Rotate = Rotation.None,
                    RotateAngle = 0,
                    XIndent = 0,
                    YIndent = 0,
                    Zoom = 1,
                    TextAlignment = HorizontalAlignment.Center,
                    Value = "Text Stamp",
                    TextState = new TextState(FontSize: 14D, Font: "Arial")
                }
            };

            var response = PdfApi.PostPageTextStamps(Name, 1, stamps, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageImageStamps
        /// </summary>
        [Test]
        public void PostPageImageStampsTest()
        {
            string imageFileName = "Koala.jpg";
            UploadFile(imageFileName, imageFileName);
            List<ImageStamp> stamps = new List<ImageStamp>
            {
                new ImageStamp()
                {
                    Background = true,
                    LeftMargin = 1,
                    RightMargin = 2,
                    TopMargin = 3,
                    BottomMargin = 4,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    Opacity = 1,
                    Rotate = Rotation.None,
                    RotateAngle = 0,
                    XIndent = 0,
                    YIndent = 0,
                    Zoom = 1,
                    FileName = Path.Combine(TempFolder, imageFileName)
                }
            };

            var response = PdfApi.PostPageImageStamps(Name, 1, stamps, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test PostPagePdfPageStamps
        /// </summary>
        [Test]
        public void PostPagePdfPageStampsTest()
        {
            string fileName = "4pages.pdf";

            UploadFile(fileName, fileName);
            List<PdfPageStamp> stamps = new List<PdfPageStamp>
            {
                new PdfPageStamp()
                {
                    Background = true,
                    LeftMargin = 1,
                    RightMargin = 2,
                    TopMargin = 3,
                    BottomMargin = 4,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    Opacity = 1,
                    Rotate = Rotation.None,
                    RotateAngle = 0,
                    XIndent = 0,
                    YIndent = 0,
                    Zoom = 1,
                    FileName = Path.Combine(TempFolder, Name),
                    PageIndex = 2
                }
            };

            var response = PdfApi.PostPagePdfPageStamps(fileName, 1, stamps, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeleteStamp
        /// </summary>
        [Test]
        public void DeleteStampTest()
        {
            var stampresponse = PdfApi.GetDocumentStamps(Name, folder: TempFolder);
            string stampId = stampresponse.Stamps.List[0].Id;

            var response = PdfApi.DeleteStamp(Name, stampId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostDocumentPageNumberStamps
        /// </summary>
        [Test]
        public void PostDocumentPageNumberStampsTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            PageNumberStamp stamp = new PageNumberStamp
            {
                Background = true,
                LeftMargin = 1,
                RightMargin = 2,
                TopMargin = 3,
                BottomMargin = 4,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Bottom,
                Opacity = 1,
                Rotate = Rotation.None,
                RotateAngle = 0,
                XIndent = 0,
                YIndent = 0,
                Zoom = 1,
                StartingNumber = 3,
                Value = "Page #"
            };

            var response = PdfApi.PostDocumentPageNumberStamps(name, stamp, startPageNumber: 2, endPageNumber: 3, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostDocumentPageNumberStampsWithoutValueTest
        /// </summary>
        [Test]
        public void PostDocumentPageNumberStampsWithoutValueTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            PageNumberStamp stamp = new PageNumberStamp
            {
                Background = true,
                LeftMargin = 1,
                RightMargin = 2,
                TopMargin = 3,
                BottomMargin = 4,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Opacity = 1,
                Rotate = Rotation.None,
                RotateAngle = 0,
                XIndent = 0,
                YIndent = 0,
                Zoom = 1,
                StartingNumber = 3
            };

            var response = PdfApi.PostDocumentPageNumberStamps(name, stamp, startPageNumber: 2, endPageNumber: 3, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
