using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    [TestFixture]
    public class LayersTests : TestsBase
    {
        private const string Name = "PdfWithLayers.pdf";

        /// <summary>
        /// Test GetDocumentLayers
        /// </summary>
        [Test]
        public void GetDocumentLayersTest()
        {
            UploadFile(Name, Name);

            var response = PdfApi.GetDocumentLayers(Name, TempFolder);
            Assert.That(response.Layers.Count, Is.EqualTo(2));
        }

        /// <summary>
        /// Test DeleteDocumentLayers
        /// </summary>
        [Test]
        public void DeleteDocumentLayersTest()
        {
            UploadFile(Name, Name);

            var response = PdfApi.DeleteDocumentLayer(Name, 1, "oc1", TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));

            var layers = PdfApi.GetDocumentLayers(Name, TempFolder);
            Assert.That(layers.Layers.Count, Is.EqualTo(1));
        }

        /// <summary>
        /// Test PutCreatePdfFromLayer
        /// </summary>
        [Test]
        public void PutCreatePdfFromLayerTest()
        {
            UploadFile(Name, Name);

            const string OutputPdf = "Output.pdf";

            var response = PdfApi.PutCreatePdfFromLayer(Name, 1, OutputPdf, "oc1", TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
