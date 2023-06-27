// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PagesTests.cs">
//   Copyright (c) 2023 Aspose.PDF Cloud
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
using System.IO;
using System.Net;
using System.Text;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Convert Api
    /// </summary>
    [TestFixture]
    public class ConvertTests : TestsBase
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
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToDoc
        /// </summary>
        [Test]
        public void PutPdfInRequestToDocTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.doc";

                var response = PdfApi.PutPdfInRequestToDoc(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
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
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToPdfA
        /// </summary>
        [Test]
        public void PutPdfInRequestToPdfATest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.doc";

                var response = PdfApi.PutPdfInRequestToPdfA(Path.Combine(TempFolder, resFileName),
                    type: PdfAType.PDFA1A.ToString(), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test GetPdfInStorageToTiff
        /// </summary>
        [Test]
        public void GetPdfInStorageToTiffTest()
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
        public void PutPdfInStorageToTiffTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.tiff";

            var response = PdfApi.PutPdfInStorageToTiff(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToTiff
        /// </summary>
        [Test]
        public void PutPdfInRequestToTiffTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.tiff";

                var response = PdfApi.PutPdfInRequestToTiff(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }


        /// <summary>
        /// Test GetPdfInStorageToSvg
        /// </summary>
        [Test]
        public void GetPdfInStorageToSvgTest()
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
        public void PutPdfInStorageToSvgTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.svg";

            var response = PdfApi.PutPdfInStorageToSvg(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToSvg
        /// </summary>
        [Test]
        public void PutPdfInRequestToSvgTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.svg";

                var response = PdfApi.PutPdfInRequestToSvg(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test GetPdfInStorageToXps
        /// </summary>
        [Test]
        public void GetPdfInStorageToXpsTest()
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
        public void PutPdfInStorageToXpsTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xps";

            var response = PdfApi.PutPdfInStorageToXps(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToXps
        /// </summary>
        [Test]
        public void PutPdfInRequestToXpsTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.xps";

                var response = PdfApi.PutPdfInRequestToXps(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test GetPdfInStorageToXls
        /// </summary>
        [Test]
        public void GetPdfInStorageToXlsTest()
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
        public void PutPdfInStorageToXlsTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xls";

            var response = PdfApi.PutPdfInStorageToXls(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToXls
        /// </summary>
        [Test]
        public void PutPdfInRequestToXlsTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.xls";

                var response = PdfApi.PutPdfInRequestToXls(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }


        /// <summary>
        /// Test GetPdfInStorageToHtml
        /// </summary>
        [Test]
        public void GetPdfInStorageToHtmlTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToHtml(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToHtml
        /// </summary>
        [Test]
        public void PutPdfInStorageToHtmlTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result_4pages.html";

            var response = PdfApi.PutPdfInStorageToHtml(name, Path.Combine(TempFolder, resFileName), folder: TempFolder, outputFormat: OutputFormat.Folder.ToString());
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToHtml
        /// </summary>
        [Test]
        public void PutPdfInRequestToHtmlTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result_html.zip";

                var response = PdfApi.PutPdfInRequestToHtml(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test GetPdfInStorageToEpub
        /// </summary>
        [Test]
        public void GetPdfInStorageToEpubTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToEpub(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToEpub
        /// </summary>
        [Test]
        public void PutPdfInStorageToEpubTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.epub";

            var response = PdfApi.PutPdfInStorageToEpub(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToEpub
        /// </summary>
        [Test]
        public void PutPdfInRequestToEpubTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.epub";

                var response = PdfApi.PutPdfInRequestToEpub(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }


        /// <summary>
        /// Test GetPdfInStorageToPptx
        /// </summary>
        [Test]
        public void GetPdfInStorageToPptxTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToPptx(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test GetPdfInStorageToPptxWithPassword
        /// </summary>
        [Test]
        public void GetPdfInStorageToPptxTestWithPassword()
        {
            string name = "4pagesEncrypted.pdf";
            UploadFile(name, name);
            Stream response = PdfApi.GetPdfInStorageToPptx(name, folder: TempFolder, 
                password: Convert.ToBase64String(Encoding.UTF8.GetBytes(@"user $^Password!&")));
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToPptx
        /// </summary>
        [Test]
        public void PutPdfInStorageToPptxTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.pptx";

            var response = PdfApi.PutPdfInStorageToPptx(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInStorageToPptxWithPassword
        /// </summary>
        [Test]
        public void PutPdfInStorageToPptxTestWithPassword()
        {
            string name = "4pagesEncrypted.pdf";
            UploadFile(name, name);
            string resFileName = "result.pptx";
            var response = PdfApi.PutPdfInStorageToPptx(name, Path.Combine(TempFolder, resFileName), folder: TempFolder,
                password: Convert.ToBase64String(Encoding.UTF8.GetBytes(@"user $^Password!&")));
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToPptx
        /// </summary>
        [Test]
        public void PutPdfInRequestToPptxTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.pptx";

                var response = PdfApi.PutPdfInRequestToPptx(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test PutPdfInRequestToPptxWithPassword
        /// </summary>
        [Test]
        public void PutPdfInRequestToPptxTestWithPassword()
        {
            string name = "4pagesEncrypted.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.pptx";
                var response = PdfApi.PutPdfInRequestToPptx(Path.Combine(TempFolder, resFileName), file: stream,
                    password: Convert.ToBase64String(Encoding.UTF8.GetBytes(@"user $^Password!&")));
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test GetPdfInStorageToTeX
        /// </summary>
        [Test]
        public void GetPdfInStorageToTeXTest()
        {
            string name = "Hello world.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToTeX(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToTeX
        /// </summary>
        [Test]
        public void PutPdfInStorageToTeXTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.tex";

            var response = PdfApi.PutPdfInStorageToTeX(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToTeX
        /// </summary>
        [Test]
        public void PutPdfInRequestToTeXTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.tex";

                var response = PdfApi.PutPdfInRequestToTeX(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }


        /// <summary>
        /// Test GetPdfInStorageToMobiXml
        /// </summary>
        [Test]
        public void GetPdfInStorageToMobiXmlTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToMobiXml(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToMobiXml
        /// </summary>
        [Test]
        public void PutPdfInStorageToMobiXmlTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.mobi";

            var response = PdfApi.PutPdfInStorageToMobiXml(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToMobiXml
        /// </summary>
        [Test]
        public void PutPdfInRequestToMobiXmlTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.mobi";

                var response = PdfApi.PutPdfInRequestToMobiXml(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }


        /// <summary>
        /// Test GetXfaPdfInStorageToAcroForm
        /// </summary>
        [Test]
        public void GetXfaPdfInStorageToAcroFormTest()
        {
            string name = "PdfWithXfaForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetXfaPdfInStorageToAcroForm(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutXfaPdfInStorageToAcroForm
        /// </summary>
        [Test]
        public void PutXfaPdfInStorageToAcroFormTest()
        {
            string name = "PdfWithXfaForm.pdf";
            UploadFile(name, name);
            string resFileName = "result.pdf";

            var response = PdfApi.PutXfaPdfInStorageToAcroForm(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutXfaPdfInRequestToAcroForm
        /// </summary>
        [Test]
        public void PutXfaPdfInRequestToAcroFormTest()
        {
            string name = "PdfWithXfaForm.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.pdf";

                var response = PdfApi.PutXfaPdfInRequestToAcroForm(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }


        /// <summary>
        /// Test GetPdfInStorageToXml
        /// </summary>
        [Test]
        public void GetPdfInStorageToXmlTest()
        {
            string name = "Hello world.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToXml(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToXml
        /// </summary>
        [Test]
        public void PutPdfInStorageToXmlTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xml";

            var response = PdfApi.PutPdfInStorageToXml(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToXml
        /// </summary>
        [Test]
        public void PutPdfInRequestToXmlTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.xml";

                var response = PdfApi.PutPdfInRequestToXml(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test GetPdfInStorageToXlsx
        /// </summary>
        [Test]
        public void GetPdfInStorageToXlsxTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPdfInStorageToXlsx(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutPdfInStorageToXlsx
        /// </summary>
        [Test]
        public void PutPdfInStorageToXlsxTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xlsx";

            var response = PdfApi.PutPdfInStorageToXlsx(name, Path.Combine(TempFolder, resFileName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutPdfInRequestToXls
        /// </summary>
        [Test]
        public void PutPdfInRequestToXlsxTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string resFileName = "result.xlsx";

                var response = PdfApi.PutPdfInRequestToXlsx(Path.Combine(TempFolder, resFileName), file: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

    }
}
