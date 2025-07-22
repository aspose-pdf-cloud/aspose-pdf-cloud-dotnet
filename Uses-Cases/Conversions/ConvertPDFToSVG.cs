using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPDFToSVG
    {
        public static async Task Convert(ConversionsHelper helper, string pdfFile, string outputSvgName, string remoteFolder)
        {
            await helper.UploadFile(pdfFile);

            string outPath = Path.Combine(remoteFolder, outputSvgName);

            AsposeResponse response = await helper.pdfApi.PutPdfInStorageToSvgAsync(pdfFile, outPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPDFToSVG(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPDFToSVG(): Failed to convert PDF To SVG.");
            else
            {
                Console.WriteLine("ConvertPDFToSVG(): file '{0}' successfully converted to '{1}' file.", pdfFile, outputSvgName);
                await helper.DownloadFile(outputSvgName);
            }
        }
    }
}
