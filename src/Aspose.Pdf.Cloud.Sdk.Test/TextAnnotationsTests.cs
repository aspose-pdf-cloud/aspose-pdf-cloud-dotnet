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
    ///  Class for testing Text Annotations Api
    /// </summary>
    [TestFixture]
    public class TextAnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }


        /// <summary>
        /// Test GetDocumentTextAnnotations
        /// </summary>
        [Test]
        public void GetDocumentTextAnnotationsTest()
        {
            var response = PdfApi.GetDocumentTextAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetDocumentTextAnnotations
        /// </summary>
        [Test]
        public void GetPageTextAnnotationsTest()
        {
            var response = PdfApi.GetPageTextAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test PostPageTextAnnotations
        /// </summary>
        [Test]
        public void PostPageTextAnnotationsTest()
        {
            List<TextAnnotation> annotations = new List<TextAnnotation>
            {
                new TextAnnotation()
                {
                    Name = "Test Free Text",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> { AnnotationFlags.Default},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Text Box Subj",
                    ZIndex = 1,
                    Title = "Title"
                }
            };

            var response = PdfApi.PostPageTextAnnotations(Name, 1, annotations, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(201));
        }


        /// <summary>
        /// Test GetTextAnnotation
        /// </summary>
        [Test]
        public void GetTextAnnotationTest()
        {
            var textresponse = PdfApi.GetDocumentTextAnnotations(Name, folder: TempFolder);
            string annotationId = textresponse.Annotations.List[0].Id;

            var response = PdfApi.GetTextAnnotation(Name, annotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test PutTextAnnotation
        /// </summary>
        [Test]
        public void PutTextAnnotationTest()
        {
            TextAnnotation annotation = new TextAnnotation()
            {
                Name = "Test Free Text",
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Default },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Updated Text",
                Subject = "Text Box Subj",
                ZIndex = 1,
                Title = "Title"
            };

            var textresponse = PdfApi.GetDocumentTextAnnotations(Name, folder: TempFolder);
            string annotationId = textresponse.Annotations.List[0].Id;

            var response = PdfApi.PutTextAnnotation(Name, annotationId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(201));
        }
    }
}
