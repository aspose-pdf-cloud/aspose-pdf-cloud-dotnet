using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToEPUB
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputEpubName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputEpubName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToEpubAsync(pdfFile, outPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToEPUB(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToEPUB(): Failed to convert PDF To Epub.");
            else
            {
                Console.WriteLine("ConvertPDFToEPUB(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputEpubName);
                await helper.DownloadFile(outputEpubName);
            }
        }
    }
}
