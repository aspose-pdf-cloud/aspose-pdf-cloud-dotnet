using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertMHTMLToPDF
    {
        public static async Task Convert(ConversionsHelper helper, string mhtFile, string pdfOutput, string remoteFolder)
        {
            await helper.UploadFile(mhtFile);

            string srcPath = Path.Combine(remoteFolder, mhtFile);

            AsposeResponse response = await helper.pdfApi.PutMhtInStorageToPdfAsync(pdfOutput, srcPath, dstFolder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertMHTMLToPDF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertMHTMLToPDF(): Failed to convert MHTML to PDF.");
            else
            {
                Console.WriteLine("ConvertMHTMLToPDF(): file '{0}' successfully converted to '{1}' file.", mhtFile, pdfOutput);
                await helper.DownloadFile(pdfOutput);
            }
        }
    }
}
