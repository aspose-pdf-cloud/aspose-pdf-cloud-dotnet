using System.Collections.Generic;
using System.Net;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Text Api
    /// </summary>
    [TestFixture]
    public class TextTests : TestsBase
    {
        /// <summary>
        /// Test GetText
        /// </summary>
        [Test]
        public void GetTextTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetText(name, folder: TempFolder, X: 0, Y: 0, width: 0, height: 0);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test GetPageText
        /// </summary>
        [Test]
        public void GetPageTextTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var format = new List<string> { "First Page", "Second Page" };
            var response = PdfApi.GetPageText(name, folder: TempFolder, X: 0, Y: 0, width: 0, height: 0,
                pageNumber: 1, format: format);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}