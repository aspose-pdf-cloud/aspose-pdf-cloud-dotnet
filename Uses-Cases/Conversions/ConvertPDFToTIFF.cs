using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToTIFF
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputTiffName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputTiffName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToTiffAsync(pdfFile, outPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToTIFF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToTIFF(): Failed to convert PDF To TIFF.");
            else
            {
                Console.WriteLine("ConvertPDFToTIFF(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputTiffName);
                await helper.DownloadFile(outputTiffName);
            }
        }
    }
}
