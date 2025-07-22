using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToDOCX
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputDocxName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputDocxName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToDocAsync(pdfFile, outPath, format: DocFormat.DocX.ToString(), folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToDOCX(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToDOCX(): Failed to convert PDF To Docx.");
            else
            {
                Console.WriteLine("ConvertPDFToDOCX(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputDocxName);
                await helper.DownloadFile(outputDocxName);
            }
        }
    }
}