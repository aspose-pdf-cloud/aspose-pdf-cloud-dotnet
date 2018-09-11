using System.Net;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing OCR Api
    /// </summary>
    [TestFixture]
    public class OcrTests : TestsBase
    {
        /// <summary>
        /// Test PutSearchableDocument
        /// </summary>
        [Test]
        public void PutSearchableDocumentTest()
        {
            const string name = "rusdoc.pdf";
            UploadFile(name, name);

            var response = PdfApi.PutSearchableDocument(name, folder: TempFolder, lang: "rus,eng");
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutSearchableDocument with default lang
        /// </summary>
        [Test]
        public void PutSearchableDocumentWithDefaultLangTest()
        {
            const string name = "rusdoc.pdf";
            UploadFile(name, name);

            var response = PdfApi.PutSearchableDocument(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}