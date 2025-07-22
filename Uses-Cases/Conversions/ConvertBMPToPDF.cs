using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertBMPToPDF
    {
        public static async Task Convert(ConversionsHelper helper, string bmpFile, string pdfOutput, string remoteFolder)
        {
            await helper.UploadFile(bmpFile);

            List<ImageTemplate> imageTemplateList = new List<ImageTemplate> {
                new ImageTemplate(ImagePath: Path.Combine(remoteFolder, bmpFile), ImageSrcType: ImageSrcType.Common)
            };

            ImageTemplatesRequest imageTemplatesRequest = new ImageTemplatesRequest(
                IsOCR: true,
                OCRLangs: "eng",
                ImagesList: imageTemplateList
            );

            AsposeResponse response = await helper.pdfApi.PutImageInStorageToPdfAsync(pdfOutput, imageTemplatesRequest, dstFolder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertBMPToPDF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertBMPToPDF(): Failed to convert BMP to PDF.");
            else
            {
                Console.WriteLine("ConvertBMPToPDF(): image file '{0}' successfully converted to '{1}' file.", bmpFile, pdfOutput);
                await helper.DownloadFile(pdfOutput);
            }
        }
    }
}