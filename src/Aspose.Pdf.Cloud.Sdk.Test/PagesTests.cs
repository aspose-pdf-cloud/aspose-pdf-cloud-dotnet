// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PagesTests.cs">
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

using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Pages Api
    /// </summary>
    [TestFixture]
    public class PagesTests : TestsBase
    {
        private const string Name = "4pages.pdf";

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test DeletePage
        /// </summary>
        [Test]
        public void DeletePageTest()
        {
            var response = PdfApi.DeletePage(Name, 3, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
        /// <summary>
        /// Test GetPage
        /// </summary>
        [Test]
        public void GetPageTest()
        {
            var response = PdfApi.GetPage(Name, pageNumber: 1, folder: TempFolder);
            
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
        /// <summary>
        /// Test GetPages
        /// </summary>
        [Test]
        public void GetPagesTest()
        {
            var response = PdfApi.GetPages(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetWordsPerPage
        /// </summary>
        [Test]
        public void GetWordsPerPageTest()
        {
            var response = PdfApi.GetWordsPerPage(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostMovePage
        /// </summary>
        [Test]
        public void PostMovePageTest()
        {
            var response = PdfApi.PostMovePage(Name, 3, 2, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutAddNewPage
        /// </summary>
        [Test]
        public void PutAddNewPageTest()
        {
            var response = PdfApi.PutAddNewPage(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPageAddStamp
        /// </summary>
        [Test]
        public void PutPageAddStampTest()
        {
            const string stampFile = "Penguins.jpg";
            UploadFile(stampFile, stampFile);

            var stamp = new Stamp(
                Type: StampType.Image,
                FileName: Path.Combine(TempFolder, stampFile),
                Background: true,
                Width: 200,
                Height: 200,
                XIndent: 100,
                YIndent: 100);

            var response = PdfApi.PutPageAddStamp(Name, 1, stamp, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
