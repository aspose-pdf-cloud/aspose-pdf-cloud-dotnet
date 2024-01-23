// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MergeTests.cs">
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
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Merge Api
    /// </summary>
    [TestFixture]
    public class MergeTests : TestsBase
    {
        /// <summary>
        /// Test PutMergeDocuments
        /// </summary>
        [Test]
        public void PutMergeDocumentsTest()
        {
            var names = new[] { "4pages.pdf", "PdfWithImages2.pdf", "marketing.pdf" };
            const string resultName = "MergingResult.pdf";

            var mergeDocuments = new MergeDocuments(new List<string>());
            foreach (var name in names)
            {
                UploadFile(name, name);
                mergeDocuments.List.Add(Path.Combine(TempFolder, name));
            }

            var response = PdfApi.PutMergeDocuments(resultName, mergeDocuments, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
