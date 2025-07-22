using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToMobiXML
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputMobixName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputMobixName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToMobiXmlAsync(pdfFile, outPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToMobiXML(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToMobiXML(): Failed to convert PDF To XSLX.");
            else
            {
                Console.WriteLine("ConvertPDFToMobiXML(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputMobixName);
                await helper.DownloadFile(outputMobixName);
            }
        }
    }
}
