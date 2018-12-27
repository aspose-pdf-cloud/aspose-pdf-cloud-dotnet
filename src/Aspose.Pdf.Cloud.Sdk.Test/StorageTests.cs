// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MergeTests.cs">
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
    public class StorageTests : TestsBase
    {
        /// <summary>
        /// Test Upload file
        /// </summary>
        [Test]
        public void PutCreateTest()
        {
            string name = "4pages.pdf";

            using (var file = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                var response = PdfApi.PutCreate(Path.Combine(TempFolder, name), file);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test Download file
        /// </summary>
        [Test]
        public void GetDonloadFileTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetDownload(Path.Combine(TempFolder, name));
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PostMoveFile
        /// </summary>
        [Test]
        public void PostMoveFileTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string src = Path.Combine(TempFolder, name);
            string dest = Path.Combine(TempFolder, "4pages_renamed.pdf");

            var response = PdfApi.PostMoveFile(src, dest);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeleteFile
        /// </summary>
        [Test]
        public void DeleteFileTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string path = Path.Combine(TempFolder, name);

            var response = PdfApi.DeleteFile(path);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetListFiles
        /// </summary>
        [Test]
        public void GetListFilesTest()
        {
            var response = PdfApi.GetListFiles(TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutCreateFolder
        /// </summary>
        [Test]
        public void PutCreateFolderTest()
        {
            string path = Path.Combine(TempFolder, "testFolder");
            var response = PdfApi.PutCreateFolder(path);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostMoveFolder
        /// </summary>
        [Test]
        public void PostMoveFolderTest()
        {
            string src = Path.Combine(TempFolder, "testFolder");
            var createFolderresponse = PdfApi.PutCreateFolder(src);
            Assert.That(createFolderresponse.Code, Is.EqualTo(200));

            string dest = Path.Combine(TempFolder, "testFolderRenamed");

            var response = PdfApi.PostMoveFolder(src, dest);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeleteFolder
        /// </summary>
        [Test]
        public void DeleteFolderTest()
        {
            string path = Path.Combine(TempFolder, "testFolderRenamed");
            var createFolderresponse = PdfApi.PutCreateFolder(path);

            var response = PdfApi.DeleteFolder(path);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetIsStorageExist
        /// </summary>
        [Test]
        public void GetIsStorageExistTest()
        {
            string name = "PDF-CI";
            var response = PdfApi.GetIsStorageExist(name);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetIsExist
        /// </summary>
        [Test]
        public void GetIsExistTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetIsExist(Path.Combine(TempFolder, name));
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetDiscUsage
        /// </summary>
        [Test]
        public void GetDiscUsageTest()
        {
            var response = PdfApi.GetDiscUsage();
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetListFileVersions
        /// </summary>
        [Test]
        public void GetListFileVersionsTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetListFileVersions(Path.Combine(TempFolder, name));
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
