// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImagesTests.cs">
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

using System.IO;
using System.Net;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Page Convert To Image
    /// </summary>
    [TestFixture]
    public class PageConvertToImageTests : TestsBase
    {
        const string Name = "4pages.pdf";
        const int pageNumber = 2;

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test GetPageConvertToTiff
        /// </summary>
        [Test]
        public void GetPageConvertToTiffTest()
        {
            var response = PdfApi.GetPageConvertToTiff(Name, pageNumber, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }
        

        /// <summary>
        /// Test PutPageConvertToTiff
        /// </summary>
        [Test]
        public void PutPageConvertToTiffTest()
        {
            string resultFile = "page.tiff";
            string outPath = Path.Combine(TempFolder, resultFile);
            var response = PdfApi.PutPageConvertToTiff(Name, pageNumber, outPath: outPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetPageConvertToJpeg
        /// </summary>
        [Test]
        public void GetPageConvertToJpegTest()
        {
            var response = PdfApi.GetPageConvertToJpeg(Name, pageNumber, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }


        /// <summary>
        /// Test PutPageConvertToJpeg
        /// </summary>
        [Test]
        public void PutPageConvertToJpegTest()
        {
            string resultFile = "page.jpeg";
            string outPath = Path.Combine(TempFolder, resultFile);
            var response = PdfApi.PutPageConvertToJpeg(Name, pageNumber, outPath: outPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetPageConvertToPng
        /// </summary>
        [Test]
        public void GetPageConvertToPngTest()
        {
            var response = PdfApi.GetPageConvertToPng(Name, pageNumber, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }


        /// <summary>
        /// Test PutPageConvertToPng
        /// </summary>
        [Test]
        public void PutPageConvertToPngTest()
        {
            string resultFile = "page.png";
            string outPath = Path.Combine(TempFolder, resultFile);
            var response = PdfApi.PutPageConvertToPng(Name, pageNumber, outPath: outPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetPageConvertToEmf
        /// </summary>
        [Test]
        public void GetPageConvertToEmfTest()
        {
            var response = PdfApi.GetPageConvertToEmf(Name, pageNumber, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }


        /// <summary>
        /// Test PutPageConvertToEmf
        /// </summary>
        [Test]
        public void PutPageConvertToEmfTest()
        {
            string resultFile = "page.emf";
            string outPath = Path.Combine(TempFolder, resultFile);
            var response = PdfApi.PutPageConvertToEmf(Name, pageNumber, outPath: outPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetPageConvertToBmp
        /// </summary>
        [Test]
        public void GetPageConvertToBmpTest()
        {
            var response = PdfApi.GetPageConvertToBmp(Name, pageNumber, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }


        /// <summary>
        /// Test PutPageConvertToBmp
        /// </summary>
        [Test]
        public void PutPageConvertToBmpTest()
        {
            string resultFile = "page.bmp";
            string outPath = Path.Combine(TempFolder, resultFile);
            var response = PdfApi.PutPageConvertToBmp(Name, pageNumber, outPath: outPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetPageConvertToGif
        /// </summary>
        [Test]
        public void GetPageConvertToGifTest()
        {
            var response = PdfApi.GetPageConvertToBmp(Name, pageNumber, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }


        /// <summary>
        /// Test PutPageConvertToGif
        /// </summary>
        [Test]
        public void PutPageConvertToGifTest()
        {
            string resultFile = "page.gif";
            string outPath = Path.Combine(TempFolder, resultFile);
            var response = PdfApi.PutPageConvertToGif(Name, pageNumber, outPath: outPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }

}
