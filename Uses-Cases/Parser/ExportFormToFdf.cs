using Aspose.Pdf.Cloud.Sdk.Model;

namespace Parser
{
    public class ExportFormToFdf
    {
        public static async Task Extract(ParserHelper helper, string documentName, string outputFdfName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            string fdfPath = Path.Combine(remoteFolder, outputFdfName);

            AsposeResponse response = await helper.pdfApi.PutExportFieldsFromPdfToFdfInStorageAsync(documentName, fdfPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ExportFormToFdf(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ExportFormToFdf(): Failed to export Pdf document form fields.");
            else
            {
                Console.WriteLine("ExportFormToFdf(): Pdf document '{0}' form fields successfully exported to '{1} file.", documentName, outputFdfName);
                await helper.DownloadFile(outputFdfName, outputFdfName, string.Empty);
            }
        }
    }
}
