// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StampAnnotationsTests.cs">
//   Copyright (c) 2019 Aspose.PDF Cloud
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
    ///  Class for testing Stamp Annotations Api
    /// </summary>
    [TestFixture]
    public class StampAnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;
        private const string AttachmentFile = "4pages.pdf";

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetDocumentStampAnnotations
        /// </summary>
        [Test]
        public void GetDocumentStampAnnotationsTest()
        {
            var response = PdfApi.GetDocumentStampAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageStampAnnotations
        /// </summary>
        [Test]
        public void GetPageStampAnnotationsTest()
        {
            var response = PdfApi.GetPageStampAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageStampAnnotations
        /// </summary>
        [Test]
        public void PostPageStampAnnotationsTest()
        {
            UploadFile(AttachmentFile, AttachmentFile);
            List<StampAnnotation> annotations = new List<StampAnnotation>
            {
                new StampAnnotation(Rect: new Rectangle(100, 100, 200, 200))
                {
                    Name = "Test Stamp Annotation",
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    Modified = "01/01/2018 00:00:00.000 AM",
                    FilePath = Path.Combine(TempFolder, AttachmentFile),
                }
            };

            var response = PdfApi.PostPageStampAnnotations(Name, 1, annotations, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetStampAnnotation
        /// </summary>
        [Test]
        public void GetStampAnnotationTest()
        {
            var annotationresponse = PdfApi.GetDocumentStampAnnotations(Name, folder: TempFolder);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = PdfApi.GetStampAnnotation(Name, annotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutStampAnnotation
        /// </summary>
        [Test]
        public void PutStampAnnotationTest()
        {
            UploadFile(AttachmentFile, AttachmentFile);
            StampAnnotation annotation = new StampAnnotation(Rect: new Rectangle(100, 100, 200, 200))
            {
                Name = "Updated Test",
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated",
                Modified = "01/01/2018 00:00:00.000 AM",
                FilePath = Path.Combine(TempFolder, AttachmentFile),
            };

            var lineResponse = PdfApi.GetDocumentStampAnnotations(Name, folder: TempFolder);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = PdfApi.PutStampAnnotation(Name, annotationId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetStampAnnotationData
        /// </summary>
        [Test]
        public void GetStampAnnotationDataTest()
        {
            var annotationresponse = PdfApi.GetDocumentStampAnnotations(Name, folder: TempFolder);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = PdfApi.GetStampAnnotationData(Name, annotationId, folder: TempFolder);
            Assert.That(response.Length, Is.EqualTo(0));
        }

        /// <summary>
        /// Test PutStampAnnotationDataExtract
        /// </summary>
        [Test]
        public void PutStampAnnotationDataExtractTest()
        {
            var annotationresponse = PdfApi.GetDocumentStampAnnotations(Name, folder: TempFolder);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = PdfApi.PutStampAnnotationDataExtract(Name, annotationId, outFilePath: "stamp.dat", folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}

