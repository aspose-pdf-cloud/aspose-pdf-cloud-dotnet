using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPSToPDF
    {
        public static async Task Convert(ConversionsHelper helper, string psFile, string pdfOutput, string remoteFolder)
        {
            await helper.UploadFile(psFile);

            string srcPath = Path.Combine(remoteFolder, psFile);

            AsposeResponse response = await helper.pdfApi.PutPsInStorageToPdfAsync(pdfOutput, srcPath, dstFolder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPSToPDF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPSToPDF(): Failed to convert PS to PDF.");
            else
            {
                Console.WriteLine("ConvertPSToPDF(): file '{0}' successfully converted to '{1}' file.", psFile, pdfOutput);
                await helper.DownloadFile(pdfOutput);
            }
        }
    }
}
