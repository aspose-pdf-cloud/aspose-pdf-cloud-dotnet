// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentTests.cs">
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Document Api
    /// </summary>
    [TestFixture]
    public class DocumentTests : TestsBase
    {
        
        /// <summary>
        /// Test GetDocument
        /// </summary>
        [Test]
        public void GetDocumentTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var result = PdfApi.GetDocument(name, folder: TempFolder);
            Assert.That(result.Code, Is.EqualTo(200));
        }
        

        /// <summary>
        /// Test PostOptimizeDocument
        /// </summary>
        [Test]
        public void PostOptimizeDocumentTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var options = new OptimizeOptions(
                AllowReusePageContent: false,
                CompressImages: true,
                ImageQuality: 100,
                LinkDuplcateStreams: true,
                RemoveUnusedObjects: true,
                RemoveUnusedStreams: true,
                UnembedFonts: true);
            var response = PdfApi.PostOptimizeDocument(name, options, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
        /// <summary>
        /// Test PostSplitDocument
        /// </summary>
        [Test]
        public void PostSplitDocumentTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.PostSplitDocument(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutCreateDocument
        /// </summary>
        [Test]
        public void PutCreateEmptyDocumentTest()
        {
            const string name = "empty.pdf";
            var response = PdfApi.PutCreateDocument(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PosttCreateDocument
        /// </summary>
        [Test]
        public void PostCreateEmptyDocumentTest()
        {
            const string name = "empty_post.pdf";
            DocumentConfig config = new DocumentConfig(PagesCount: 2)
            {
                DocumentProperties = new DocumentProperties()
                {
                    List = new List<DocumentProperty>
                    {
                        new DocumentProperty(BuiltIn: false)
                        {
                            Name = "prop1",
                            Value = "Val1"
                        }
                    }
                },
                DisplayProperties = new DisplayProperties()
                {
                    CenterWindow = true,
                    HideMenuBar = true,
                },
                DefaultPageConfig = new DefaultPageConfig()
                {
                    Height = 100,
                    Width = 100
                },
            };
            var response = PdfApi.PostCreateDocument(name, config, folder: TempFolder);

            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetDocumentDisplayProperties
        /// </summary>
        [Test]
        public void GetDocumentDisplayPropertiesTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var result = PdfApi.GetDocumentDisplayProperties(name, folder: TempFolder);
            Assert.That(result.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutDocumentDisplayProperties
        /// </summary>
        [Test]
        public void PutDocumentDisplayPropertiesTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            DisplayProperties displayProperties = new DisplayProperties()
            {
                CenterWindow = true,
                Direction = Direction.L2R,
                DisplayDocTitle = true,
                HideMenuBar = true,
                HideToolBar = true,
                HideWindowUI = true,
                NonFullScreenPageMode = PageMode.UseNone,
                PageLayout = PageLayout.TwoPageLeft,
                PageMode = PageMode.UseOC,
            };

            var result = PdfApi.PutDocumentDisplayProperties(name, displayProperties, folder: TempFolder);

            Assert.That(result.Code, Is.EqualTo(200));
        }
    }
}
