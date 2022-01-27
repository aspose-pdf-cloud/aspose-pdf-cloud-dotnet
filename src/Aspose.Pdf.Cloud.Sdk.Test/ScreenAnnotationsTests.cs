// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ScreenAnnotationsTests.cs">
//   Copyright (c) 2022 Aspose.PDF Cloud
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
    ///  Class for testing Screen Annotations Api
    /// </summary>
    [TestFixture]
    public class ScreenAnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithScreenAnnotations.pdf";
        private const int PageNumber = 1;
        private const string NameSwf = "ScreenMovie.swf";

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetDocumentScreenAnnotations
        /// </summary>
        [Test]
        public void GetDocumentScreenAnnotationsTest()
        {
            var response = PdfApi.GetDocumentScreenAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageScreenAnnotations
        /// </summary>
        [Test]
        public void GetPageScreenAnnotationsTest()
        {
            var response = PdfApi.GetPageScreenAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageScreenAnnotations
        /// </summary>
        [Test]
        public void PostPageScreenAnnotationsTest()
        {
            UploadFile(NameSwf, NameSwf);
            List<ScreenAnnotation> annotations = new List<ScreenAnnotation>
            {
                new ScreenAnnotation(Rect: new Rectangle(100, 100, 200, 200))
                {
                    Name = "Test Screen Annotation",
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    ZIndex = 1,
                    Title = "Title",
                    Modified = "01/01/2018 12:00:00.000 AM",
                    FilePath = Path.Combine(TempFolder, NameSwf),
                }
            };

            var response = PdfApi.PostPageScreenAnnotations(Name, 1, annotations, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetScreenAnnotation
        /// </summary>
        [Test]
        public void GetScreenAnnotationTest()
        {
            var annotationresponse = PdfApi.GetDocumentScreenAnnotations(Name, folder: TempFolder);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = PdfApi.GetScreenAnnotation(Name, annotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutScreenAnnotation
        /// </summary>
        [Test]
        public void PutScreenAnnotationTest()
        {
            UploadFile(NameSwf, NameSwf);
            ScreenAnnotation annotation = new ScreenAnnotation(Rect: new Rectangle(100, 100, 200, 200))
            {
                Name = "Updated Test",
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                ZIndex = 1,
                Title = "Title Updated",
                Modified = "01/01/2018 00:00:00.000 AM",
                FilePath = Path.Combine(TempFolder, NameSwf),
            };

            var lineResponse = PdfApi.GetDocumentScreenAnnotations(Name, folder: TempFolder);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = PdfApi.PutScreenAnnotation(Name, annotationId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        
        /// <summary>
        /// Test GetScreenAnnotationData
        /// </summary>
        [Test]
        public void GetScreenAnnotationDataTest()
        {
            var annotationresponse = PdfApi.GetDocumentScreenAnnotations(Name, folder: TempFolder);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = PdfApi.GetScreenAnnotationData(Name, annotationId, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutScreenAnnotationDataExtract
        /// </summary>
        [Test]
        public void PutScreenAnnotationDataExtractTest()
        {
            var annotationresponse = PdfApi.GetDocumentScreenAnnotations(Name, folder: TempFolder);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = PdfApi.PutScreenAnnotationDataExtract(Name, annotationId, outFilePath: Path.Combine(TempFolder, "screen.dat"), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
    }
}


