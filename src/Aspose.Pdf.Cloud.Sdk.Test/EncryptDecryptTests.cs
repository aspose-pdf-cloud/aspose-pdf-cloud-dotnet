// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SignTests.cs">
//   Copyright (c) 2022 Aspose.PDF Cloud
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///     Class for testing EncryptDecrypt API
    /// </summary>
    [TestFixture]
    class EncryptDecryptTests : TestsBase
    {
        /// <summary>
        /// Test PutEncryptDocument
        /// </summary>
        [Test]
        public void PutEncryptDocumentTest()
        {
            const string name = "4pages.pdf";
            using (Stream file = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string outPath = Path.Combine(TempFolder, name);
                string userPassword = @"user $^Password!&";
                string ownerPassword = @"owner\//? $12^Password!&";

                var response = PdfApi.PutEncryptDocument(outPath,
                    ToBase64(userPassword), ToBase64(ownerPassword),
                    cryptoAlgorithm: CryptoAlgorithm.AESx128.ToString(), file: file);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test PostEncryptDocumentInStorage
        /// </summary>
        [Test]
        public void PostEncryptDocumentInStorageTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);
            
            string userPassword = @"user $^Password!&";
            string ownerPassword = @"owner\//? $12^Password!&";

            var response = PdfApi.PostEncryptDocumentInStorage(name,
                ToBase64(userPassword), ToBase64(ownerPassword),
                cryptoAlgorithm: CryptoAlgorithm.AESx128.ToString(), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
            
        }

        /// <summary>
        /// Test PutDecryptDocument
        /// </summary>
        [Test]
        public void PutDecryptDocumentTest()
        {
            const string name = "4pagesEncrypted.pdf";
            using (Stream file = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                string outPath = Path.Combine(TempFolder, name);
                string password = @"user $^Password!&";

                var response = PdfApi.PutDecryptDocument(outPath, ToBase64(password), file: file);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        /// <summary>
        /// Test PostDecryptDocumentInStorage
        /// </summary>
        [Test]
        public void PostDeryptDocumentInStorageTest()
        {
            const string name = "4pagesEncrypted.pdf";
            UploadFile(name, name);

            string password = @"user $^Password!&";
            
            var response = PdfApi.PostDecryptDocumentInStorage(name,
                ToBase64(password), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostChangePasswordDocumentInStorage
        /// </summary>
        [Test]
        public void PostChangePasswordDocumentInStorageTest()
        {
            const string name = "4pagesEncrypted.pdf";
            UploadFile(name, name);

            string ownerPassword = @"owner\//? $12^Password!&";
            string newUserPassword = @"user new\//? $12^Password!&";
            string newOwnerPassword = @"owner new\//? $12^Password!&";

            var response = PdfApi.PostChangePasswordDocumentInStorage(name,
                ToBase64(ownerPassword), ToBase64(newUserPassword), ToBase64(newOwnerPassword), 
                folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutChangePasswordDocument
        /// </summary>
        [Test]
        public void PutChangePasswordDocumentTest()
        {
            const string name = "4pagesEncrypted.pdf";
            UploadFile(name, name);

            string outPath = Path.Combine(TempFolder, name);
            string ownerPassword = @"owner\//? $12^Password!&";
            string newUserPassword = @"user new\//? $12^Password!&";
            string newOwnerPassword = @"owner new\//? $12^Password!&";
            using (Stream file = System.IO.File.OpenRead(Path.Combine(TestDataFolder, name)))
            {
                var response = PdfApi.PutChangePasswordDocument(outPath,
                    ToBase64(ownerPassword), ToBase64(newUserPassword), ToBase64(newOwnerPassword),
                    file: file);
                Assert.That(response.Code, Is.EqualTo(200));
            }
        }

        #region private methods

        private string ToBase64(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(bytes);
        }

        #endregion private methods
    }
}
