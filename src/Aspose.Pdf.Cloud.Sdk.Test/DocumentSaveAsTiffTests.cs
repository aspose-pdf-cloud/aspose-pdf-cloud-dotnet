// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentSaveAsTests.cs">
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

using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing DocumentSaveAs Api
    /// </summary>
    [TestFixture]
    public class DocumentSaveAsTiffTests : TestsBase
    {
        private const string Name = "4pages.pdf";

        /// <summary>
        /// Test PutDocumentSaveAsTiff
        /// </summary>
        [Test]
        public void PutDocumentSaveAsTiffUsingQueryParamsTest()
        {
            UploadFile(Name, Name);

            var response = PdfApi.PutDocumentSaveAsTiff(Name,
                resultFile: "4pages.tiff",
                brightness: 0.6,
                compression: CompressionType.CCITT4.ToString(),
                colorDepth: ColorDepth.Format1bpp.ToString(),
                leftMargin: 0,
                rightMargin: 0,
                topMargin: 0,
                bottomMargin: 0,
                orientation: ShapeType.Portrait.ToString(),
                skipBlankPages: true,
                width: 1200,
                height: 1600,
                xResolution: 200,
                yResolution: 200,
                pageIndex: 2,
                pageCount: 2,
                folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test PutDocumentSaveAsTiff
        /// </summary>
        [Test]
        public void PutDocumentSaveAsTiffUsingBodyParamsTest()
        {
            UploadFile(Name, Name);

            var options = new TiffExportOptions(
                ResultFile: "4pages.tiff",
                Brightness: 0.6,
                Compression: CompressionType.CCITT4,
                ColorDepth: ColorDepth.Format1bpp,
                LeftMargin: 0,
                RightMargin: 0,
                TopMargin: 0,
                BottomMargin: 0,
                Orientation: ShapeType.Portrait,
                SkipBlankPages: true,
                Width: 1200,
                Height: 1600,
                XResolution: 200,
                YResolution: 200,
                PageIndex: 2,
                PageCount: 2);

            var response = PdfApi.PutDocumentSaveAsTiff(Name, options, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
