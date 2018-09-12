// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextReplaceTests.cs">
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
    ///  Class for testing TextReplace Api
    /// </summary>
    [TestFixture]
    public class TextReplaceTests : TestsBase
    {
        private const string Name = "marketing.pdf";

        //private static readonly TextReplaceRequest ReplaceRequest = new TextReplaceRequest("Page", "p_a_g_e", false);
        private static readonly TextReplaceListRequest ReplaceListRequest = new TextReplaceListRequest(new List<TextReplace>
        {
            new TextReplace("First", "1", false),
            new TextReplace("Page", "p_a_g_e", false)
        });

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }
        
        /// <summary>
        /// Test PostDocumentTextReplace
        /// </summary>
        [Test]
        public void PostDocumentTextReplaceTest()
        {
            var rect = new RectanglePdf(100, 700, 300, 300);
            var textReplace = new TextReplace("Page", "p_a_g_e", false, Rect: rect);
            var textReplaceList = new TextReplaceListRequest(new List<TextReplace> { textReplace },
                StartIndex: 0, CountReplace: 0);

            var response = PdfApi.PostDocumentTextReplace(Name, textReplaceList, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageTextReplace
        /// </summary>
        [Test]
        public void PostPageTextReplaceTest()
        {
            var rect = new RectanglePdf(100, 100, 300, 300);
            var textReplace = new TextReplace("market", "m_a_r_k_e_t", false, Rect: rect);
            var textReplaceList = new TextReplaceListRequest(new List<TextReplace> { textReplace },
                StartIndex: 0, CountReplace: 0);

            var response = PdfApi.PostPageTextReplace(Name, 1, textReplaceList, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
