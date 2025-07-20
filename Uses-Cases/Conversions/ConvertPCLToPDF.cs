using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPCLToPDF
    {
        public static async Task Convert(ConversionsHelper helper, string pclFile, string pdfOutput, string remoteFolder)
        {
            await helper.UploadFile(pclFile);

            string srcPath = Path.Combine(remoteFolder, pclFile);

            AsposeResponse response = await helper.pdfApi.PutPclInStorageToPdfAsync(pdfOutput, srcPath, dstFolder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPCLToPDF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPCLToPDF(): Failed to convert PCL to PDF.");
            else
            {
                Console.WriteLine("ConvertPCLToPDF(): file '{0}' successfully converted to '{1}' file.", pclFile, pdfOutput);
                await helper.DownloadFile(pdfOutput);
            }
        }
    }
}
