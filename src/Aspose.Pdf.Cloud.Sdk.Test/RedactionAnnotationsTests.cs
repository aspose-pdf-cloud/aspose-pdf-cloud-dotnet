// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AnnotationsTests.cs">
//   Copyright (c) 2021 Aspose.PDF Cloud
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
    ///  Class for testing Redaction Annotations Api
    /// </summary>
    [TestFixture]
    public class RedactionAnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetDocumentRedactionAnnotations
        /// </summary>
        [Test]
        public void GetDocumentRedactionAnnotationsTest()
        {
            var response = PdfApi.GetDocumentRedactionAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageRedactionAnnotations
        /// </summary>
        [Test]
        public void GetPageRedactionAnnotationsTest()
        {
            var response = PdfApi.GetPageRedactionAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageRedactionAnnotations
        /// </summary>
        [Test]
        public void PostPageRedactionAnnotationsTest()
        {
            List<RedactionAnnotation> annotations = new List<RedactionAnnotation>
            {
                new RedactionAnnotation(Rect: new Rectangle(100, 100, 200, 200))
                {
                    Name = "Test Redaction Annotation",
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    ZIndex = 1,
                    QuadPoint = new List<Point>
                    {
                        new Point(10, 40),
                        new Point(30, 40)
                    },
                    Modified = "01/01/2018 00:00:00.000 AM"
                }
            };

            var response = PdfApi.PostPageRedactionAnnotations(Name, 1, annotations, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetRedactionAnnotation
        /// </summary>
        [Test]
        public void GetRedactionAnnotationTest()
        {
            var Redactionresponse = PdfApi.GetDocumentRedactionAnnotations(Name, folder: TempFolder);
            string annotationId = Redactionresponse.Annotations.List[0].Id;

            var response = PdfApi.GetRedactionAnnotation(Name, annotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutRedactionAnnotation
        /// </summary>
        [Test]
        public void PutRedactionAnnotationTest()
        {
            RedactionAnnotation annotation = new RedactionAnnotation(Rect: new Rectangle(100, 100, 200, 200))
            {
                Name = "Updated Test",
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                ZIndex = 1,
                QuadPoint = new List<Point>
                {
                    new Point(10, 20)
                },
                Modified = "01/01/2018 00:00:00.000 AM"
            };

            var lineResponse = PdfApi.GetDocumentRedactionAnnotations(Name, folder: TempFolder);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = PdfApi.PutRedactionAnnotation(Name, annotationId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}

