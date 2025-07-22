using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertHTMLToPDF
    {
        public static async Task Convert(ConversionsHelper helper, string htmlFile, string pdfOutput, double pdfWidth, double pdfHeight, string remoteFolder)
        {
            await helper.UploadFile(htmlFile);

            string srcPath = Path.Combine(remoteFolder, htmlFile);

            AsposeResponse response = await helper.pdfApi.PutHtmlInStorageToPdfAsync(
                pdfOutput, srcPath,
                htmlFileName: htmlFile,
                width: pdfWidth,
                height: pdfHeight,
                dstFolder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertHTMLToPDF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertHTMLToPDF(): Failed to convert HTML to PDF.");
            else
            {
                Console.WriteLine("ConvertHTMLToPDF(): file '{0}' successfully converted to '{1}' file.", htmlFile, pdfOutput);
                await helper.DownloadFile(pdfOutput);
            }
        }
    }
}