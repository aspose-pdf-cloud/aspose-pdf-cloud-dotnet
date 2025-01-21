// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AnnotationsTests.cs">
//   Copyright (c) 2025 Aspose.PDF Cloud
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
    ///  Class for testing Square Annotations Api
    /// </summary>
    [TestFixture]
    public class SquareAnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetDocumentSquareAnnotations
        /// </summary>
        [Test]
        public void GetDocumentSquareAnnotationsTest()
        {
            var response = PdfApi.GetDocumentSquareAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageSquareAnnotations
        /// </summary>
        [Test]
        public void GetPageSquareAnnotationsTest()
        {
            var response = PdfApi.GetPageSquareAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageSquareAnnotations
        /// </summary>
        [Test]
        public void PostPageSquareAnnotationsTest()
        {
            List<SquareAnnotation> annotations = new List<SquareAnnotation>
            {
                new SquareAnnotation(Rect: new Rectangle(100, 100, 200, 200))
                {
                    Name = "Test Square Annotation",
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title"
                }
            };

            var response = PdfApi.PostPageSquareAnnotations(Name, 1, annotations, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetSquareAnnotation
        /// </summary>
        [Test]
        public void GetSquareAnnotationTest()
        {
            var squareresponse = PdfApi.GetDocumentSquareAnnotations(Name, folder: TempFolder);
            string annotationId = squareresponse.Annotations.List[0].Id;

            var response = PdfApi.GetSquareAnnotation(Name, annotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutSquareAnnotation
        /// </summary>
        [Test]
        public void PutSquareAnnotationTest()
        {
            SquareAnnotation annotation = new SquareAnnotation(Rect: new Rectangle(100, 100, 200, 200))
            {
                Name = "Updated Test",
                Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated"
            };

            var lineResponse = PdfApi.GetDocumentSquareAnnotations(Name, folder: TempFolder);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = PdfApi.PutSquareAnnotation(Name, annotationId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
