// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LinksTests.cs">
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
    ///  Class for testing Link Annotations Api
    /// </summary>
    [TestFixture]
    public class LinkAnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithLinks.pdf";

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetPageLinkAnnotation
        /// </summary>
        [Test]
        public void GetPageLinkAnnotationTest()
        {
            var getLinksResponse = PdfApi.GetPageLinkAnnotations(Name, 1, folder: TempFolder);
            Assert.That(getLinksResponse.Code, Is.EqualTo(200));

            string linkId = getLinksResponse.Links.List[0].Id;

            var response = PdfApi.GetPageLinkAnnotation(Name, pageNumber: 1, linkId: linkId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeleteLinkAnnotation
        /// </summary>
        [Test]
        public void DeleteLinkAnnotationTest()
        {
            var getLinksResponse = PdfApi.GetPageLinkAnnotations(Name, 1, folder: TempFolder);
            Assert.That(getLinksResponse.Code, Is.EqualTo(200));

            string linkId = getLinksResponse.Links.List[0].Id;

            var response = PdfApi.DeleteLinkAnnotation(Name, linkId: linkId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageLinkAnnotations
        /// </summary>
        [Test]
        public void GetPageLinkAnnotationsTest()
        {
            var response = PdfApi.GetPageLinkAnnotations(Name, 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageLinkAnnotations
        /// </summary>
        [Test]
        public void PostPageLinkAnnotationsTest()
        {
            LinkAnnotation linkAnnotation = new LinkAnnotation(null, LinkActionType.GoToURIAction, "https://products.aspose.cloud/pdf",
                LinkHighlightingMode.Invert, new Color(0xFF, 0xAA, 0xAA, 0xAA), new RectanglePdf(100, 100, 500, 500));

            var linkAnnotations = new List<LinkAnnotation>
            {
                linkAnnotation
            };

            var response = PdfApi.PostPageLinkAnnotations(Name, pageNumber: 1, links: linkAnnotations, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(201));
        }

        /// <summary>
        /// Test PutLinkAnnotation
        /// </summary>
        [Test]
        public void PutLinkAnnotationTest()
        {
            var getLinksResponse = PdfApi.GetPageLinkAnnotations(Name, 1, folder: TempFolder);
            Assert.That(getLinksResponse.Code, Is.EqualTo(200));

            string linkId = getLinksResponse.Links.List[0].Id;

            LinkAnnotation linkAnnotation = new LinkAnnotation(null, LinkActionType.GoToURIAction, "https://products.aspose.cloud/pdf",
                LinkHighlightingMode.Invert, new Color(0xFF, 0xAA, 0xAA, 0xAA), new RectanglePdf(100, 100, 500, 500));
            
            var response = PdfApi.PutLinkAnnotation(Name, linkId: linkId, link: linkAnnotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(201));
        }

        /// <summary>
        /// Test DeletePageLinkAnnotations
        /// </summary>
        [Test]
        public void DeletePageLinkAnnotationsTest()
        {
            var response = PdfApi.DeletePageLinkAnnotations(Name, pageNumber: 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeleteDocumentLinkAnnotations
        /// </summary>
        [Test]
        public void DeleteDocumentLinkAnnotationsTest()
        {
            var response = PdfApi.DeleteDocumentLinkAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetLinkAnnotation
        /// </summary>
        [Test]
        public void GetLinkAnnotationTest()
        {
            var getLinksResponse = PdfApi.GetPageLinkAnnotations(Name, 1, folder: TempFolder);
            Assert.That(getLinksResponse.Code, Is.EqualTo(200));

            string linkId = getLinksResponse.Links.List[0].Id;

            var response = PdfApi.GetLinkAnnotation(Name, linkId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
