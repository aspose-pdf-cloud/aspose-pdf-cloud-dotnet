using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToExcel
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputExcelName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputExcelName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToXlsAsync(pdfFile, outPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToExcel(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToExcel(): Failed to convert PDF To Excel.");
            else
            {
                Console.WriteLine("ConvertPDFToExcel(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputExcelName);
                await helper.DownloadFile(outputExcelName);
            }
        }
    }
}
