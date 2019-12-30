// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BookmarksTests.cs">
//   Copyright (c) 2020 Aspose.PDF Cloud
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
    ///  Class for testing Bookmarks Api
    /// </summary>
    [TestFixture]
    public class ImportExportTests : TestsBase
    {

        /// <summary>
        /// Test GetExportFieldsFromPdfToXmlInStorage
        /// </summary>
        [Test]
        public void GetExportFieldsFromPdfToXmlInStorageTest()
        {
            const string name = "FormData.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetExportFieldsFromPdfToXmlInStorage(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test GetExportFieldsFromPdfToFdfInStorage
        /// </summary>
        [Test]
        public void GetExportFieldsFromPdfToFdfInStorageTest()
        {
            const string name = "FormData.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetExportFieldsFromPdfToFdfInStorage(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test GetExportFieldsFromPdfToXfdfInStorage
        /// </summary>
        [Test]
        public void GetExportFieldsFromPdfToXfdfInStorageTest()
        {
            const string name = "FormData.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetExportFieldsFromPdfToXfdfInStorage(name, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutExportFieldsFromPdfToXmlInStorage
        /// </summary>
        [Test]
        public void PutExportFieldsFromPdfToXmlInStorageTest()
        {
            const string name = "FormData.pdf";
            UploadFile(name, name);

            string outPath = Path.Combine(TempFolder, "exportData.xml");

            var response = PdfApi.PutExportFieldsFromPdfToXmlInStorage(name, outPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutExportFieldsFromPdfToFdfInStorage
        /// </summary>
        [Test]
        public void PutExportFieldsFromPdfToFdfInStorageTest()
        {
            const string name = "FormData.pdf";
            UploadFile(name, name);

            string outPath = Path.Combine(TempFolder, "exportData.fdf");

            var response = PdfApi.PutExportFieldsFromPdfToFdfInStorage(name, outPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutExportFieldsFromPdfToXfdfInStorage
        /// </summary>
        [Test]
        public void PutExportFieldsFromPdfToXfdfInStorageTest()
        {
            const string name = "FormData.pdf";
            UploadFile(name, name);

            string outPath = Path.Combine(TempFolder, "exportData.xfdf");

            var response = PdfApi.PutExportFieldsFromPdfToXfdfInStorage(name, outPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetImportFieldsFromFdfInStorage
        /// </summary>
        [Test]
        public void GetImportFieldsFromFdfInStorageTest()
        {
            const string name = "FormData.pdf";
            UploadFile(name, name);

            const string fdfFileName = "FormData.fdf";
            UploadFile(fdfFileName, fdfFileName);

            string fdfFilePath = Path.Combine(TempFolder, fdfFileName);
            
            var response = PdfApi.GetImportFieldsFromFdfInStorage(name, fdfFilePath, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test GetImportFieldsFromXfdfInStorage
        /// </summary>
        [Test]
        public void GetImportFieldsFromXfdfInStorageTest()
        {
            const string name = "FormDataXfdf_in.pdf";
            UploadFile(name, name);

            const string fdfxFileName = "FormDataXfdf_in.xfdf";
            UploadFile(fdfxFileName, fdfxFileName);

            string fdfxFilePath = Path.Combine(TempFolder, fdfxFileName);

            var response = PdfApi.GetImportFieldsFromXfdfInStorage(name, fdfxFilePath, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test GetImportFieldsFromXmlInStorage
        /// </summary>
        [Test]
        public void GetImportFieldsFromXmlInStorageTest()
        {
            const string name = "FormDataXfa_in.pdf";
            UploadFile(name, name);

            const string xmlFileName = "FormDataXfa_in.xml";
            UploadFile(xmlFileName, xmlFileName);

            string xmlFilePath = Path.Combine(TempFolder, xmlFileName);

            var response = PdfApi.GetImportFieldsFromXmlInStorage(name, xmlFilePath, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }


        /// <summary>
        /// Test PutImportFieldsFromFdfInStorage
        /// </summary>
        [Test]
        public void PutImportFieldsFromFdfInStorageTest()
        {
            const string name = "FormData.pdf";
            UploadFile(name, name);

            const string fdfFileName = "FormData.fdf";
            UploadFile(fdfFileName, fdfFileName);

            string fdfFilePath = Path.Combine(TempFolder, fdfFileName);

            var response = PdfApi.PutImportFieldsFromFdfInStorage(name, fdfFilePath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutImportFieldsFromXfdfInStorage
        /// </summary>
        [Test]
        public void PutImportFieldsFromXfdfInStorageTest()
        {
            const string name = "FormDataXfdf_in.pdf";
            UploadFile(name, name);

            const string fdfxFileName = "FormDataXfdf_in.xfdf";
            UploadFile(fdfxFileName, fdfxFileName);

            string fdfxFilePath = Path.Combine(TempFolder, fdfxFileName);

            var response = PdfApi.PutImportFieldsFromXfdfInStorage(name, fdfxFilePath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutImportFieldsFromXmlInStorage
        /// </summary>
        [Test]
        public void PutImportFieldsFromXmlInStorageTest()
        {
            const string name = "FormDataXfa_in.pdf";
            UploadFile(name, name);

            const string xmlFileName = "FormDataXfa_in.xml";
            UploadFile(xmlFileName, xmlFileName);

            string xmlFilePath = Path.Combine(TempFolder, xmlFileName);

            var response = PdfApi.PutImportFieldsFromXmlInStorage(name, xmlFilePath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test PostImportFieldsFromFdf
        /// </summary>
        [Test]
        public void PostImportFieldsFromFdfTest()
        {
            const string name = "FormData.pdf";
            UploadFile(name, name);

            const string fdfFileName = "FormData.fdf";
            
            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, fdfFileName)))
            {
                var response = PdfApi.PostImportFieldsFromFdf(name, folder: TempFolder, fdfData: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test PostImportFieldsFromXfdf
        /// </summary>
        [Test]
        public void PostImportFieldsFromXfdfTest()
        {
            const string name = "FormDataXfdf_in.pdf";
            UploadFile(name, name);

            const string fdfxFileName = "FormDataXfdf_in.xfdf";

            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, fdfxFileName)))
            {
                var response = PdfApi.PostImportFieldsFromXfdf(name, folder: TempFolder, xfdfData: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test PostImportFieldsFromXml
        /// </summary>
        [Test]
        public void PostImportFieldsFromXmlTest()
        {
            const string name = "FormDataXfa_in.pdf";
            UploadFile(name, name);

            const string xmlFileName = "FormDataXfa_in.xml";

            using (Stream stream = System.IO.File.OpenRead(Path.Combine(TestDataFolder, xmlFileName)))
            {
                var response = PdfApi.PostImportFieldsFromXml(name, folder: TempFolder, xmlData: stream);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }
    }
}

