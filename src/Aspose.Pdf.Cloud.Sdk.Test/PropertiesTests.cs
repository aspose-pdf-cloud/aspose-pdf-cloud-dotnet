// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PropertiesTests.cs">
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

using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Properties Api
    /// </summary>
    [TestFixture]
    public class PropertiesTests : TestsBase
    {
        private const string Name = "PdfWithAcroForm.pdf";

        private static readonly string[] PropertyNames = { "prop1", "prop2" };
        private static readonly string[] PropertyValues = { "val1", "val2" };


        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }
        
        /// <summary>
        /// Test DeleteProperties
        /// </summary>
        [Test]
        public void DeletePropertiesTest()
        {
            PdfApi.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: TempFolder);
            PdfApi.PutSetProperty(Name, PropertyNames[1], PropertyValues[1], folder: TempFolder);

            var response = PdfApi.DeleteProperties(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
        
        /// <summary>
        /// Test DeleteProperty
        /// </summary>
        [Test]
        public void DeletePropertyTest()
        {
            PdfApi.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: TempFolder);

            var response = PdfApi.DeleteProperty(Name, PropertyNames[0], folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
        
        /// <summary>
        /// Test GetDocumentProperties
        /// </summary>
        [Test]
        public void GetDocumentPropertiesTest()
        {
            PdfApi.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: TempFolder);
            PdfApi.PutSetProperty(Name, PropertyNames[1], PropertyValues[1], folder: TempFolder);

            var response = PdfApi.GetDocumentProperties(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
        
        /// <summary>
        /// Test GetDocumentProperty
        /// </summary>
        [Test]
        public void GetDocumentPropertyTest()
        {
            PdfApi.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: TempFolder);

            var response = PdfApi.GetDocumentProperty(Name, PropertyNames[0], folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
        
        /// <summary>
        /// Test PutSetProperty
        /// </summary>
        [Test]
        public void PutSetPropertyTest()
        {
            var response = PdfApi.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
    }
}
