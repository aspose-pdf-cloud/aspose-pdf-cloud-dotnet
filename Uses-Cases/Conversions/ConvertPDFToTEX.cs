using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToTEX
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputTexName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputTexName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToTeXAsync(pdfFile, outPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToTEX(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToTEX(): Failed to convert PDF To TEX.");
            else
            {
                Console.WriteLine("ConvertPDFToTEX(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputTexName);
                await helper.DownloadFile(outputTexName);
            }
        }
    }
}
