using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToXPS
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputXpsName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputXpsName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToXpsAsync(pdfFile, outPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToXPS(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToXPS(): Failed to convert PDF To XPS.");
            else
            {
                Console.WriteLine("ConvertPDFToXPS(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputXpsName);
                await helper.DownloadFile(outputXpsName);
            }
        }
    }
}