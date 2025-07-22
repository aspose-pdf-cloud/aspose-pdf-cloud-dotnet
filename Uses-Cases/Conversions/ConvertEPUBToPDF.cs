using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertEPUBToPDF
    {
        public static async Task Convert(ConversionsHelper helper, string epubFile, string pdfOutput, string remoteFolder)
        {
            await helper.UploadFile(epubFile);

            string srcPath = Path.Combine(remoteFolder, epubFile);

            AsposeResponse response = await helper.pdfApi.PutEpubInStorageToPdfAsync(pdfOutput, srcPath, dstFolder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertEPUBToPDF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertEPUBToPDF(): Failed to convert EPUB to PDF.");
            else
            {
                Console.WriteLine("ConvertEPUBToPDF(): file '{0}' successfully converted to '{1}' file.", epubFile, pdfOutput);
                await helper.DownloadFile(pdfOutput);
            }
        }
    }
}
