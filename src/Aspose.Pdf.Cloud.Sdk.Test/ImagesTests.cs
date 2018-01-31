// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImagesTests.cs">
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
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Images Api
    /// </summary>
    [TestFixture]
    public class ImagesTests : TestsBase
    {
        private const string Name = "PdfWithImages2.pdf";

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetImage
        /// </summary>
        [Test]
        public void GetImageTest()
        {
            var response = PdfApi.GetImage(Name, 1, 1, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }
        
        /// <summary>
        /// Test GetImages
        /// </summary>
        [Test]
        public void GetImagesTest()
        {
            var response = PdfApi.GetImages(Name, 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test PostReplaceImage
        /// </summary>
        [Test]
        public void PostReplaceImageTest()
        {
            const string imageName = "Koala.jpg";
            UploadFile(imageName, imageName);

            var response = PdfApi.PostReplaceImage(Name, 1, 1, Path.Combine(TempFolder, imageName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
