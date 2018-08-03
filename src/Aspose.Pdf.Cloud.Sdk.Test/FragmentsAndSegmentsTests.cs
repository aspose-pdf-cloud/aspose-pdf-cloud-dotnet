// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FragmentsAndSegmentsTests.cs">
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

using System.Net;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing FragmentsAndSegments Api
    /// </summary>
    [TestFixture]
    public class FragmentsAndSegmentsTests : TestsBase
    {
        private const string Name = "4pages.pdf";

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetFragment
        /// </summary>
        [Test]
        public void GetFragmentTest()
        {
            var response = PdfApi.GetFragment(Name, 1, 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test GetFragmentTextFormat
        /// </summary>
        [Test]
        public void GetFragmentTextFormatTest()
        {
            var response = PdfApi.GetFragmentTextFormat(Name, 1, 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test GetFragments
        /// </summary>
        [Test]
        public void GetFragmentsTest()
        {
            var response = PdfApi.GetFragments(Name, 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test GetSegment
        /// </summary>
        [Test]
        public void GetSegmentTest()
        {
            var response = PdfApi.GetSegment(Name, 1, 1, segmentNumber: 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test GetSegmentTextFormat
        /// </summary>
        [Test]
        public void GetSegmentTextFormatTest()
        {
            var response = PdfApi.GetSegmentTextFormat(Name, 1, 1, segmentNumber: 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test GetSegments
        /// </summary>
        [Test]
        public void GetSegmentsTest()
        {
            var response = PdfApi.GetSegments(Name, 1, 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
