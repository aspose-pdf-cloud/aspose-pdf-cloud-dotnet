using Aspose.Pdf.Cloud.Sdk.Model;
namespace Parser
{
    public class ExportFormToXML
    {
        public static async Task Extract(ParserHelper helper, string documentName, string outputXMLName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            string xmlPath = Path.Combine(remoteFolder, outputXMLName);

            AsposeResponse response = await helper.pdfApi.PutExportFieldsFromPdfToXmlInStorageAsync(documentName, xmlPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ExportFormToXML(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ExportFormToXML(): Failed to export Pdf document form fields.");
            else
            {
                Console.WriteLine("ExportFormToXML(): Pdf document '{0}' form fields successfully exported to '{1} file.", documentName, outputXMLName);
                await helper.DownloadFile(outputXMLName, outputXMLName, string.Empty);
            }
        }
    }
}
