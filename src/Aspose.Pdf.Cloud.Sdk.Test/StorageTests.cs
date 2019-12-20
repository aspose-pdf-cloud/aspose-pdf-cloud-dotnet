// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MergeTests.cs">
//   Copyright (c) 2019 Aspose.PDF Cloud
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
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Aspose.Pdf.Cloud.Sdk.Client;
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
        /// Test PutCreate
        /// </summary>
        [Test]
        public void UploadFileTest()
        {
            string name = "4pages.pdf";

            using (var file = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                var response = PdfApi.UploadFile(Path.Combine(TempFolder, name), file);
                Assert.That(response.Uploaded.Count, Is.EqualTo(1));
            }
        }

        /// <summary>
        /// Test GetDownload
        /// </summary>
        [Test]
        public void DownloadFileTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.DownloadFile(Path.Combine(TempFolder, name));
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PostMoveFile
        /// </summary>
        [Test]
        public void MoveFileTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string src = Path.Combine(TempFolder, name);
            string dest = Path.Combine(TempFolder, "4pages_renamed.pdf");

            PdfApi.MoveFile(src, dest);
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

            PdfApi.DeleteFile(path);
        }

        /// <summary>
        /// Test GetListFiles
        /// </summary>
        [Test]
        public void GetFilesListTest()
        {
            var response = PdfApi.GetFilesList(TempFolder);
            Assert.That(response.Value.Count, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutCreateFolder
        /// </summary>
        [Test]
        public async Task CreateFolderTest()
        {
            string path = $"{TempFolder}/testFolder/test1";
            await PdfApi.CreateFolderAsync(path);
            Assert.IsTrue(true);
        }

        /// <summary>
        /// Test PostMoveFolder
        /// </summary>
        [Test]
        public void MoveFolderTest()
        {
            string src = Path.Combine(TempFolder, "testFolder");
            PdfApi.CreateFolder(src);
            
            string dest = Path.Combine(TempFolder, "testFolderRenamed");

            PdfApi.MoveFolder(src, dest);
        }

        /// <summary>
        /// Test DeleteFolder
        /// </summary>
        [Test]
        public void DeleteFolderTest()
        {
            string path = Path.Combine(TempFolder, "testFolderForDelete");
            PdfApi.CreateFolder(path);
            PdfApi.DeleteFolder(path);
        }

        /// <summary>
        /// Test GetIsStorageExist
        /// </summary>
        [Test]
        public void StorageExistTest()
        {
            string name = "First Storage";
            var response = PdfApi.StorageExists(name);
            Assert.That(response.Exists, Is.True);
        }

        /// <summary>
        /// Test GetIsExist
        /// </summary>
        [Test]
        public void ObjectExistsTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.ObjectExists(Path.Combine(TempFolder, name));
            Assert.That(response.Exists, Is.True);
        }

        /// <summary>
        /// Test GetDiscUsage
        /// </summary>
        [Test]
        public void GetDiscUsageTest()
        {
            var response = PdfApi.GetDiscUsage();
            Assert.That(response.TotalSize, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test GetListFileVersions
        /// </summary>
        [Test]
        public void GetFileVersionsTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetFileVersions(Path.Combine(TempFolder, name));
            Assert.That(response.Value.Count, Is.GreaterThan(0));
        }
    }
}
