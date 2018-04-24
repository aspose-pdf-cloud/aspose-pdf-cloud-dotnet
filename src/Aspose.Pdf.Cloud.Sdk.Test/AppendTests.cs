// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AppendTests.cs">
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

using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///     Class for testing Append Api
    /// </summary>
    [TestFixture]
    public class AppendTests : TestsBase
    {
        private const string Name = "PdfWithImages2.pdf";
        private const string AppendFile = "4pages.pdf";
        private const int StartPage = 2;
        private const int EndPage = 4;

        /// <summary>
        ///     Test PostAppendDocument using query parameters
        /// </summary>
        [Test]
        public void PostAppendDocumentUsingQueryParamsTest()
        {
            UploadFile(Name, Name);
            UploadFile(AppendFile, AppendFile);

            var responce =
                PdfApi.PostAppendDocument(Name, appendFile: Path.Combine(TempFolder, AppendFile), startPage: StartPage, endPage: EndPage, folder: TempFolder);
            Assert.That(responce.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        ///     Test PostAppendDocument using json
        /// </summary>
        [Test]
        public void PostAppendDocumentUsingBodyParamsTest()
        {
            UploadFile(Name, Name);
            UploadFile(AppendFile, AppendFile);

            var appendDocument = new AppendDocument(Path.Combine(TempFolder, AppendFile), StartPage, EndPage);
            var responce =
                PdfApi.PostAppendDocument(Name, appendDocument, folder: TempFolder);
            Assert.That(responce.Code, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}