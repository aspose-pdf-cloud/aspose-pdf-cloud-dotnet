using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Model;
using RestSharp;

namespace CreateDocument
{
    public class ClreatePdfDocumentSimple
    {
        public ClreatePdfDocumentSimple()
        {
            string LOCAL_FOLDER = "testData";
            string PDF_DOCUMENT = "output_created_simple.pdf";
            string REMOTE_FOLDER = "TempPdfCloud";

            string clientId = "*************";
            string clientSecret = "*************";

            PdfApi pdfApi = new PdfApi(clientSecret, clientId);
            pdfApi = new PdfApi(new Aspose.Pdf.Cloud.Sdk.Client.Configuration(true, "", "","http://localhost:5000/v3.0"));

            DocumentResponse response = pdfApi.PutCreateDocument(PDF_DOCUMENT, folder: REMOTE_FOLDER);
            if (response.Code != 200)
                Console.WriteLine("ClreatePdfDocumentSimple(): Unexpected error: {0}", response.Messages[0]);
            else
            {
                Console.WriteLine("ClreatePdfDocumentSimple():Document '{0}' successfully created.", PDF_DOCUMENT);
                Stream stream = pdfApi.DownloadFile(Path.Combine(REMOTE_FOLDER, PDF_DOCUMENT));
                using var fileStream = File.Create(Path.Combine(LOCAL_FOLDER, PDF_DOCUMENT));
                stream.Position = 0;
                stream.CopyTo(fileStream);
                Console.WriteLine("ClreatePdfDocumentSimple():Document '{0}' successfully downloaded.", PDF_DOCUMENT);
            }
        }
    }
}
