using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToDOC
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputDocName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputDocName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToDocAsync(pdfFile, outPath, format: DocFormat.Doc.ToString(), folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToDOC(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToDOC(): Failed to convert PDF To Doc.");
            else
            {
                Console.WriteLine("ConvertPDFToDOC(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputDocName);
                await helper.DownloadFile(outputDocName);
            }
        }
    }
}