// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PagesTests.cs">
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
    ///  Class for testing Convert Api
    /// </summary>
    [TestFixture]
    class ConvertTests : TestsBase
    {

        /// <summary>
        /// Test GetPdfInStorageToDoc
        /// </summary>
        [Test]
        public void GetPdfInStorageToDocTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
         
            var response = PdfApi.GetPdfInStorageToDoc(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }
        
        /// <summary>
        /// Test PutPdfInStorageToDoc
        /// </summary>
        [Test]
        public void PutPdfInStorageToDocTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.doc";

            var response = PdfApi.PutPdfInStorageToDoc(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test PutPdfInRequestToDoc
        /// </summary>
        [Test]
        public void PutPdfInRequestToDocTest()
        {
            string name = "4pages.pdf";
            Stream stream = File.OpenRead(Path.Combine(TestDataFolder, name));
            string resFileName = "result.doc";

            var response = PdfApi.PutPdfInRequestToDoc(Path.Combine(TempFolder, resFileName), file: stream);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test GetPdfInStorageToPdfA
        /// </summary>
        [Test]
        public void GetPdfInStorageToPdfATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToPdfA(name, type: PdfAType.PDFA1A.ToString(), folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToPdfA
        /// </summary>
        [Test]
        public void PutPdfInStorageToPdfATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.pdf";

            var response = PdfApi.PutPdfInStorageToPdfA(name, Path.Combine(TempFolder, resFileName), type: PdfAType.PDFA1A.ToString(), folder: TempFolder);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test PutPdfInRequestToPdfA
        /// </summary>
        [Test]
        public void PutPdfInRequestToPdfATest()
        {
            string name = "4pages.pdf";
            Stream stream = File.OpenRead(Path.Combine(TestDataFolder, name));
            string resFileName = "result.doc";

            var response = PdfApi.PutPdfInRequestToPdfA(Path.Combine(TempFolder, resFileName), type: PdfAType.PDFA1A.ToString(), file: stream);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test GetPdfInStorageToTiff
        /// </summary>
        [Test]
        public void GetPdfInStorageToTiffATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToTiff(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToTiff
        /// </summary>
        [Test]
        public void PutPdfInStorageToTiffATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.tiff";

            var response = PdfApi.PutPdfInStorageToTiff(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test PutPdfInRequestToTiff
        /// </summary>
        [Test]
        public void PutPdfInRequestToTiffATest()
        {
            string name = "4pages.pdf";
            Stream stream = File.OpenRead(Path.Combine(TestDataFolder, name));
            string resFileName = "result.tiff";

            var response = PdfApi.PutPdfInRequestToTiff(Path.Combine(TempFolder, resFileName), file: stream);
            Assert.IsNotNull(response);
        }


        /// <summary>
        /// Test GetPdfInStorageToSvg
        /// </summary>
        [Test]
        public void GetPdfInStorageToSvgATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToSvg(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToSvg
        /// </summary>
        [Test]
        public void PutPdfInStorageToSvgATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.svg";

            var response = PdfApi.PutPdfInStorageToSvg(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test PutPdfInRequestToSvg
        /// </summary>
        [Test]
        public void PutPdfInRequestToSvgATest()
        {
            string name = "4pages.pdf";
            Stream stream = File.OpenRead(Path.Combine(TestDataFolder, name));
            string resFileName = "result.svg";

            var response = PdfApi.PutPdfInRequestToSvg(Path.Combine(TempFolder, resFileName), file: stream);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test GetPdfInStorageToXps
        /// </summary>
        [Test]
        public void GetPdfInStorageToXpsATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToXps(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToXps
        /// </summary>
        [Test]
        public void PutPdfInStorageToXpsATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xps";

            var response = PdfApi.PutPdfInStorageToXps(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test PutPdfInRequestToXps
        /// </summary>
        [Test]
        public void PutPdfInRequestToXpsATest()
        {
            string name = "4pages.pdf";
            Stream stream = File.OpenRead(Path.Combine(TestDataFolder, name));
            string resFileName = "result.xps";

            var response = PdfApi.PutPdfInRequestToXps(Path.Combine(TempFolder, resFileName), file: stream);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test GetPdfInStorageToXls
        /// </summary>
        [Test]
        public void GetPdfInStorageToXlsATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToXls(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToXls
        /// </summary>
        [Test]
        public void PutPdfInStorageToXlsATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xls";

            var response = PdfApi.PutPdfInStorageToXls(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Test PutPdfInRequestToXls
        /// </summary>
        [Test]
        public void PutPdfInRequestToXlsATest()
        {
            string name = "4pages.pdf";
            Stream stream = File.OpenRead(Path.Combine(TestDataFolder, name));
            string resFileName = "result.xls";

            var response = PdfApi.PutPdfInRequestToXls(Path.Combine(TempFolder, resFileName), file: stream);
            Assert.IsNotNull(response);
        }
    }
}
