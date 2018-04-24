// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MergeTests.cs">
//   Copyright (c) 2018 Aspose.Pdf for Cloud
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
    ///  Class for testing Storage Access Api
    /// </summary>
    [TestFixture]
    class UploadDownloadTests : TestsBase
    {
        /// <summary>
        /// Test Upload file
        /// </summary>
        [Test]
        public void PutCreateTest()
        {
            string name = "4pages.pdf";

            using (var file = File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                var response = PdfApi.PutCreate(Path.Combine(TempFolder, name), file);
                Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
            }
        }

        /// <summary>
        /// Test Upload file
        /// </summary>
        [Test]
        public void GetDonloadFileTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetDownload(Path.Combine(TempFolder, name));
            Assert.That(response.Length, Is.GreaterThan(0));
        }
    }
}
