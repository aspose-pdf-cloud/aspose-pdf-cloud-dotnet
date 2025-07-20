using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToXLSX
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputXlsxName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputXlsxName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToXlsxAsync(pdfFile, outPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToXLSX(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToXLSX(): Failed to convert PDF To XSLX.");
            else
            {
                Console.WriteLine("ConvertPDFToXLSX(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputXlsxName);
                await helper.DownloadFile(outputXlsxName);
            }
        }
    }
}
