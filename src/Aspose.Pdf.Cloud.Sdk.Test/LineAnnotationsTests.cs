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
    ///  Class for testing Line Annotations Api
    /// </summary>
    [TestFixture]
    public class LineAnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }
        
        /// <summary>
        /// Test GetDocumentLineAnnotations
        /// </summary>
        [Test]
        public void GetDocumentLineAnnotationsTest()
        {
            var response = PdfApi.GetDocumentLineAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageLineAnnotations
        /// </summary>
        [Test]
        public void GetPageLineAnnotationsTest()
        {
            var response = PdfApi.GetPageLineAnnotations(Name, 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageLineAnnotations
        /// </summary>
        [Test]
        public void PostPageLineAnnotationsTest()
        {
            List<LineAnnotation> annotations = new List<LineAnnotation>
            {
                new LineAnnotation(Rect: new Rectangle(100, 100, 200, 200),
                    Starting: new Point(10, 10),
                    Ending: new Point(100, 100))
                {
                    Name = "Test Line Annotation",
                    Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    ShowCaption = true,
                    Title = "Title",
                    Color = new Color(0x99, 0xFF, 0, 0)
                }
            };

            var response = PdfApi.PostPageLineAnnotations(Name, 1, annotations, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
        /// <summary>
        /// Test GetLineAnnotation
        /// </summary>
        [Test]
        public void GetLineAnnotationTest()
        {
            var lineresponse = PdfApi.GetDocumentLineAnnotations(Name, folder: TempFolder);
            string annotationId = lineresponse.Annotations.List[0].Id;

            var response = PdfApi.GetLineAnnotation(Name, annotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutLineAnnotation
        /// </summary>
        [Test]
        public void PutLineAnnotationTest()
        {
            LineAnnotation annotation = new LineAnnotation(Rect: new Rectangle(100, 100, 200, 200),
                Starting: new Point(10, 10),
                Ending: new Point(100, 100))
            {
                Name = "Test Line Annotation",
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Updated Rich Text",
                Subject = "Subj",
                ZIndex = 1,
                ShowCaption = true,
                Title = "Title Updated"
            };

            var lineResponse = PdfApi.GetDocumentLineAnnotations(Name, folder: TempFolder);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = PdfApi.PutLineAnnotation(Name, annotationId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
