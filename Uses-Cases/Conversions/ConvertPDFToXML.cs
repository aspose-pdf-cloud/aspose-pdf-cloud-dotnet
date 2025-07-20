using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToXML
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputXmlName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputXmlName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToXmlAsync(pdfFile, outPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToXML(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToXML(): Failed to convert PDF To XML.");
            else
            {
                Console.WriteLine("ConvertPDFToXML(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputXmlName);
                await helper.DownloadFile(outputXmlName);
            }
        }
    }
}