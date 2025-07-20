using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertPNGToPDF
    {
        public static async Task Convert(ConversionsHelper helper, string pngFile, string pdfOutput, string remoteFolder)
        {
            await helper.UploadFile(pngFile);

            List<ImageTemplate> imageTemplateList = new List<ImageTemplate> {
                new ImageTemplate(ImagePath: Path.Combine(remoteFolder, pngFile), ImageSrcType: ImageSrcType.Common)
            };

            ImageTemplatesRequest imageTemplatesRequest = new ImageTemplatesRequest(
                IsOCR: true,
                OCRLangs: "eng",
                ImagesList: imageTemplateList
            );

            AsposeResponse response = await helper.pdfApi.PutImageInStorageToPdfAsync(pdfOutput, imageTemplatesRequest, dstFolder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertPNGToPDF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertPNGToPDF(): Failed to convert PNG to PDF.");
            else
            {
                Console.WriteLine("ConvertPNGToPDF(): image file '{0}' successfully converted to '{1}' file.", pngFile, pdfOutput);
                await helper.DownloadFile(pdfOutput);
            }
        }
    }
}