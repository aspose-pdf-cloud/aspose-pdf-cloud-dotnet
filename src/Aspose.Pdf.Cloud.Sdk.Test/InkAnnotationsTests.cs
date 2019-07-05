// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AnnotationsTests.cs">
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
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Ink Annotations Api
    /// </summary>
    [TestFixture]
    public class InkAnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetDocumentInkAnnotations
        /// </summary>
        [Test]
        public void GetDocumentInkAnnotationsTest()
        {
            var response = PdfApi.GetDocumentInkAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageInkAnnotations
        /// </summary>
        [Test]
        public void GetPageInkAnnotationsTest()
        {
            var response = PdfApi.GetPageInkAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageInkAnnotations
        /// </summary>
        [Test]
        public void PostPageInkAnnotationsTest()
        {
            List<InkAnnotation> annotations = new List<InkAnnotation>
            {
                new InkAnnotation(Rect: new Rectangle(100, 100, 200, 200))
                {
                    Name = "Test Ink Annotation",
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    InkList = new List<List<Point>>
                    {
                        new List<Point>
                        {
                            new Point(10, 40),
                            new Point(30, 40)
                        },
                        new List<Point>
                        {
                            new Point(10, 20),
                            new Point(20, 20),
                            new Point(30, 20)
                        }
                    },
                    CapStyle = CapStyle.Rounded,
                    Modified = "01/01/2018 00:00:00.000 AM"
                }
            };

            var response = PdfApi.PostPageInkAnnotations(Name, 1, annotations, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetInkAnnotation
        /// </summary>
        [Test]
        public void GetInkAnnotationTest()
        {
            var Inkresponse = PdfApi.GetDocumentInkAnnotations(Name, folder: TempFolder);
            string annotationId = Inkresponse.Annotations.List[0].Id;

            var response = PdfApi.GetInkAnnotation(Name, annotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutInkAnnotation
        /// </summary>
        [Test]
        public void PutInkAnnotationTest()
        {
            InkAnnotation annotation = new InkAnnotation(Rect: new Rectangle(100, 100, 200, 200))
            {
                Name = "Test Ink Annotation Updated",
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated",
                InkList = new List<List<Point>>
                {
                    new List<Point>
                    {
                        new Point(10, 40),
                        new Point(30, 40)
                    },
                    new List<Point>
                    {
                        new Point(10, 20),
                        new Point(20, 20),
                        new Point(30, 20)
                    }
                },
                CapStyle = CapStyle.Rounded,
                Modified = "02/02/2018 00:00:00.000 AM"
            };

            var lineResponse = PdfApi.GetDocumentInkAnnotations(Name, folder: TempFolder);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = PdfApi.PutInkAnnotation(Name, annotationId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}




