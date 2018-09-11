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

            var response = PdfApi.GetText(name, LLX: 0, LLY: 0, URX: 0, URY: 0, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
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
            var response = PdfApi.GetPageText(name, pageNumber: 1, LLX: 0, LLY: 0, URX: 0, URY: 0, folder: TempFolder, format: format);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}