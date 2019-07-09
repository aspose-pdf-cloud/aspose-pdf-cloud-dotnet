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
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Sound Annotations Api
    /// </summary>
    [TestFixture]
    public class SoundAnnotationsTests : TestsBase
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
        /// Test GetDocumentSoundAnnotations
        /// </summary>
        [Test]
        public void GetDocumentSoundAnnotationsTest()
        {
            var response = PdfApi.GetDocumentSoundAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageSoundAnnotations
        /// </summary>
        [Test]
        public void GetPageSoundAnnotationsTest()
        {
            var response = PdfApi.GetPageSoundAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageSoundAnnotations
        /// </summary>
        [Test]
        public void PostPageSoundAnnotationsTest()
        {
            UploadFile(AttachmentFile, AttachmentFile);
            List<SoundAnnotation> annotations = new List<SoundAnnotation>
            {
                new SoundAnnotation(Rect: new Rectangle(100, 100, 200, 200), FilePath: Path.Combine(TempFolder, AttachmentFile))
                {
                    Name = "Test Sound Annotation",
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    Modified = "01/01/2018 00:00:00.000 AM",
                }
            };

            var response = PdfApi.PostPageSoundAnnotations(Name, 1, annotations, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetSoundAnnotation
        /// </summary>
        [Test]
        public void GetSoundAnnotationTest()
        {
            var annotationresponse = PdfApi.GetDocumentSoundAnnotations(Name, folder: TempFolder);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = PdfApi.GetSoundAnnotation(Name, annotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutSoundAnnotation
        /// </summary>
        [Test]
        public void PutSoundAnnotationTest()
        {
            SoundAnnotation annotation = new SoundAnnotation(Rect: new Rectangle(100, 100, 200, 200), FilePath: Path.Combine(TempFolder, AttachmentFile))
            {
                Name = "Updated Test",
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated",
                Modified = "01/01/2018 00:00:00.000 AM",
            };

            var lineResponse = PdfApi.GetDocumentSoundAnnotations(Name, folder: TempFolder);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = PdfApi.PutSoundAnnotation(Name, annotationId, annotation, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetSoundAnnotationData
        /// </summary>
        [Test]
        public void GetSoundAnnotationDataTest()
        {
            var annotationresponse = PdfApi.GetDocumentSoundAnnotations(Name, folder: TempFolder);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = PdfApi.GetSoundAnnotationData(Name, annotationId, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutSoundAnnotationDataExtract
        /// </summary>
        [Test]
        public void PutSoundAnnotationDataExtractTest()
        {
            var annotationresponse = PdfApi.GetDocumentSoundAnnotations(Name, folder: TempFolder);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = PdfApi.PutSoundAnnotationDataExtract(Name, annotationId, outFilePath: "outFile.dat", folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}

