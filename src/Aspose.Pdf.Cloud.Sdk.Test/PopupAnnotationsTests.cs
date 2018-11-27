// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AnnotationsTests.cs">
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
    ///  Class for testing Popup Annotations Api
    /// </summary>
    [TestFixture]
    public class PopupAnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetDocumentPopupAnnotations
        /// </summary>
        [Test]
        public void GetDocumentPopupAnnotationsTest()
        {
            var response = PdfApi.GetDocumentPopupAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetDocumentPopupAnnotationsByParent
        /// </summary>
        [Test]
        public void GetDocumentPopupAnnotationsByParentTest()
        {
            const string parentId = "GI5TAOZRGU3CYNZSGEWDCNZWFQ3TGOI";
            var response = PdfApi.GetDocumentPopupAnnotationsByParent(Name, parentId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPagePopupAnnotations
        /// </summary>
        [Test]
        public void GetPagePopupAnnotationsTest()
        {
            var response = PdfApi.GetPagePopupAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPopupAnnotation
        /// </summary>
        [Test]
        public void PostPopupAnnotationTest()
        {

            const string parentId = "GI5TCMR3GE2TQLBSGM3CYMJYGUWDENRV";

            PopupAnnotation annotation = new PopupAnnotation()
            {
                Name = "Test Popup Annotation",
                Rect = new RectanglePdf(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                HorizontalAlignment = HorizontalAlignment.Center,
                ZIndex = 1,
                Modified = "01/01/2018 00:00:00.000 AM"
            };

            var response = PdfApi.PostPopupAnnotation(Name, parentId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(201));
        }

        /// <summary>
        /// Test GetPopupAnnotation
        /// </summary>
        [Test]
        public void GetPopupAnnotationTest()
        {
            var Popupresponse = PdfApi.GetDocumentPopupAnnotations(Name, folder: TempFolder);
            string annotationId = Popupresponse.Annotations.List[0].Id;

            var response = PdfApi.GetPopupAnnotation(Name, annotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPopupAnnotation
        /// </summary>
        [Test]
        public void PutPopupAnnotationTest()
        {
            PopupAnnotation annotation = new PopupAnnotation()
            {
                Name = "Test Popup Annotation Updated",
                Rect = new RectanglePdf(101, 101, 201, 201),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                ZIndex = 1,
                Modified = "02/02/2018 00:00:00.000 AM"
            };

            var lineResponse = PdfApi.GetDocumentPopupAnnotations(Name, folder: TempFolder);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = PdfApi.PutPopupAnnotation(Name, annotationId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(201));
        }
    }
}



