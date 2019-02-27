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
    ///  Class for testing Annotations Api
    /// </summary>
    [TestFixture]
    public class AnnotationsTests : TestsBase
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        private string _annotationId;

        private string AnnotationId
        {
            get
            {
                if (null == _annotationId)
                {
                    var response = PdfApi.GetDocumentAnnotations(Name, folder: TempFolder);
                    _annotationId = response.Annotations.List[0].Id;
                }

                return _annotationId;
            }
        }

        /// <summary>
        /// Test GetDocumentAnnotations
        /// </summary>
        [Test]
        public void GetDocumentAnnotationsTest()
        {
            var response = PdfApi.GetDocumentAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeleteDocumentAnnotations
        /// </summary>
        [Test]
        public void DeleteDocumentAnnotationsTest()
        {
            var response = PdfApi.DeleteDocumentAnnotations(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetPageAnnotations
        /// </summary>
        [Test]
        public void GetPageAnnotationsTest()
        {
            var response = PdfApi.GetPageAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test DeletePageAnnotations
        /// </summary>
        [Test]
        public void DeletePageAnnotationsTest()
        {
            var response = PdfApi.DeletePageAnnotations(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test DeleteAnnotation
        /// </summary>
        [Test]
        public void DeleteAnnotationTest()
        {
            var response = PdfApi.DeleteAnnotation(Name, AnnotationId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutAnnotationsFlatten
        /// </summary>
        [Test]
        public void PutAnnotationsFlattenTest()
        {
            var response = PdfApi.PutAnnotationsFlatten(Name, endPage: 2, annotationTypes: new List<AnnotationType>{ AnnotationType .Stamp}, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
