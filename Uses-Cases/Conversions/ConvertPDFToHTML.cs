using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToHTML
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputHtmlZipName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputHtmlZipName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToHtmlAsync(pdfFile, outPath, outputFormat: OutputFormat.Zip.ToString(), folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToHTML(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToHTML(): Failed to convert PDF To HTML.");
            else
            {
                Console.WriteLine("ConvertPDFToHTML(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputHtmlZipName);
                await helper.DownloadFile(outputHtmlZipName);
            }
        }
    }
}
