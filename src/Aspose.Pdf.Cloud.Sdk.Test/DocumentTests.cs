// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentTests.cs">
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
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Document Api
    /// </summary>
    [TestFixture]
    public class DocumentTests : TestsBase
    {
        /// <summary>
        /// Test GetDocument
        /// </summary>
        [Test]
        public void GetDocumentTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var result = PdfApi.GetDocument(name, folder: TempFolder);
            Assert.That(result.Length, Is.GreaterThan(0));
        }
        
        /// <summary>
        /// Test PostOptimizeDocument
        /// </summary>
        [Test]
        public void PostOptimizeDocumentTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var options = new OptimizeOptions(
                AllowReusePageContent: false,
                CompressImages: true,
                ImageQuality: 100,
                LinkDuplcateStreams: true,
                RemoveUnusedObjects: true,
                RemoveUnusedStreams: true,
                UnembedFonts: true);
            var response = PdfApi.PostOptimizeDocument(name, options, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }
        
        /// <summary>
        /// Test PostSplitDocument
        /// </summary>
        [Test]
        public void PostSplitDocumentTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.PostSplitDocument(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test PutConvertDocument
        /// </summary>
        [Test]
        public void PutConvertDocumentTest()
        {
            const string urlToFile = @"http://pdf995.com/samples/pdf.pdf";
            const string format = "tiff";

            var response = PdfApi.PutConvertDocument(format: format, url: urlToFile);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutCreateDocument
        /// </summary>
        [Test]
        public void PutCreateEmptyDocumentTest()
        {
            const string name = "empty.pdf";
            var response = PdfApi.PutCreateDocument(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test PutCreateDocument
        /// </summary>
        [Test]
        public void PutCreateDocumentTest()
        {
            const string name = "HtmlExample1.pdf";
            const string templateName = "HtmlExample1.html";
            UploadFile(templateName, templateName);

            var response = PdfApi.PutCreateDocument(
                name,
                folder: TempFolder,
                templateFile: Path.Combine(TempFolder, templateName),
                templateType: "html");
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test PutCreateDocumentFromImages
        /// </summary>
        [Test]
        public void PutCreateDocumentFromImagesTest()
        {
            const string image1 = "33539.jpg";
            UploadFile(image1, image1);

            const string image2 = "44781.jpg";
            UploadFile(image2, image2);

            const string name = "pdffromimagesinquery_net.pdf";

            var request = new ImagesListRequest(new List<string>
            {
                Path.Combine(TempFolder, image1),
                Path.Combine(TempFolder, image2)
            });

            var response = PdfApi.PutCreateDocumentFromImages(name, images: request, ocr: false, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
