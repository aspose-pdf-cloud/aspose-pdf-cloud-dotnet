using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToPowerpoint
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputPptxName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputPptxName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToPptxAsync(pdfFile, outPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToPowerpoint(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToPowerpoint(): Failed to convert PDF To PPTX.");
            else
            {
                Console.WriteLine("ConvertPDFToPowerpoint(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputPptxName);
                await helper.DownloadFile(outputPptxName);
            }
        }
    }
}
