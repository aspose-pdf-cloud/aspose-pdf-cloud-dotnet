﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AnnotationsTests.cs">
//   Copyright (c) 2024 Aspose.PDF Cloud
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
    ///  Class for testing Caret Annotations Api
    /// </summary>
    [TestFixture]
    public class CaretAnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetDocumentCaretAnnotations
        /// </summary>
        [Test]
        public void GetDocumentCaretAnnotationsTest()
        {
            var response = PdfApi.GetDocumentCaretAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageCaretAnnotations
        /// </summary>
        [Test]
        public void GetPageCaretAnnotationsTest()
        {
            var response = PdfApi.GetPageCaretAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageCaretAnnotations
        /// </summary>
        [Test]
        public void PostPageCaretAnnotationsTest()
        {
            List<CaretAnnotation> annotations = new List<CaretAnnotation>
            {
                new CaretAnnotation(Rect: new Rectangle(100, 100, 200, 200))
                {
                    Name = "Test Caret Annotation",
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    Frame = new Rectangle(100, 100, 200, 200),
                    Modified = "01/01/2018 00:00:00.000 AM"
                }
            };

            var response = PdfApi.PostPageCaretAnnotations(Name, 1, annotations, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetCaretAnnotation
        /// </summary>
        [Test]
        public void GetCaretAnnotationTest()
        {
            var Caretresponse = PdfApi.GetDocumentCaretAnnotations(Name, folder: TempFolder);
            string annotationId = Caretresponse.Annotations.List[0].Id;

            var response = PdfApi.GetCaretAnnotation(Name, annotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutCaretAnnotation
        /// </summary>
        [Test]
        public void PutCaretAnnotationTest()
        {
            CaretAnnotation annotation = new CaretAnnotation(Rect: new Rectangle(101, 101, 201, 201))
            {
                Name = "Test Caret Annotation Updated",
                
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated",
                Frame = new Rectangle(100, 100, 200, 200),
                Modified = "02/02/2018 00:00:00.000 AM"
            };

            var lineResponse = PdfApi.GetDocumentCaretAnnotations(Name, folder: TempFolder);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = PdfApi.PutCaretAnnotation(Name, annotationId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}



