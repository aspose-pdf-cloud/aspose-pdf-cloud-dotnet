using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertMarkdownToPDF
    {
        public static async Task Convert(ConversionsHelper helper, string mdFile, string pdfOutput, string remoteFolder)
        {
            await helper.UploadFile(mdFile);

            string srcPath = Path.Combine(remoteFolder, mdFile);

            AsposeResponse response = await helper.pdfApi.PutMarkdownInStorageToPdfAsync(pdfOutput, srcPath, dstFolder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertMarkdownToPDF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertMarkdownToPDF(): Failed to convert Markdown to PDF.");
            else
            {
                Console.WriteLine("ConvertMarkdownToPDF(): file '{0}' successfully converted to '{1}' file.", mdFile, pdfOutput);
                await helper.DownloadFile(pdfOutput);
            }
        }
    }
}
