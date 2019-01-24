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
    ///  Class for testing Movie Annotations Api
    /// </summary>
    [TestFixture]
    public class MovieAnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithAnnotations1.pdf";
        private const int PageNumber = 2;
        private const string AttachmentFile = "4pages.pdf";

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetDocumentMovieAnnotations
        /// </summary>
        [Test]
        public void GetDocumentMovieAnnotationsTest()
        {
            var response = PdfApi.GetDocumentMovieAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageMovieAnnotations
        /// </summary>
        [Test]
        public void GetPageMovieAnnotationsTest()
        {
            var response = PdfApi.GetPageMovieAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageMovieAnnotations
        /// </summary>
        [Test]
        public void PostPageMovieAnnotationsTest()
        {
            UploadFile(AttachmentFile, AttachmentFile);
            List<MovieAnnotation> annotations = new List<MovieAnnotation>
            {
                new MovieAnnotation()
                {
                    Name = "Test Movie Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    ZIndex = 1,
                    FilePath = AttachmentFile,
                    Modified = "01/01/2018 00:00:00.000 AM"
                }
            };

            var response = PdfApi.PostPageMovieAnnotations(Name, 1, annotations, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(201));
        }

        /// <summary>
        /// Test GetMovieAnnotation
        /// </summary>
        [Test]
        public void GetMovieAnnotationTest()
        {
            var Movieresponse = PdfApi.GetDocumentMovieAnnotations(Name, folder: TempFolder);
            string annotationId = Movieresponse.Annotations.List[0].Id;

            var response = PdfApi.GetMovieAnnotation(Name, annotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutMovieAnnotation
        /// </summary>
        [Test]
        public void PutMovieAnnotationTest()
        {
            UploadFile(AttachmentFile, AttachmentFile);
            MovieAnnotation annotation = new MovieAnnotation()
            {
                Name = "Updated Test",
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                ZIndex = 1,
                FilePath = AttachmentFile,
                Modified = "01/01/2018 00:00:00.000 AM"
            };

            var lineResponse = PdfApi.GetDocumentMovieAnnotations(Name, folder: TempFolder);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = PdfApi.PutMovieAnnotation(Name, annotationId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(201));
        }
    }
}

