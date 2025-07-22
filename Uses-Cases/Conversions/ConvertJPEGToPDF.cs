using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertJPEGToPDF
    {
        public static async Task Convert(ConversionsHelper helper, string jpegFile, string pdfOutput, string remoteFolder)
        {
            await helper.UploadFile(jpegFile);

            List<ImageTemplate> imageTemplateList = new List<ImageTemplate> {
                new ImageTemplate(ImagePath: Path.Combine(remoteFolder, jpegFile), ImageSrcType: ImageSrcType.Common)
            };

            ImageTemplatesRequest imageTemplatesRequest = new ImageTemplatesRequest(
                IsOCR: true,
                OCRLangs: "eng",
                ImagesList: imageTemplateList
            );

            AsposeResponse response = await helper.pdfApi.PutImageInStorageToPdfAsync(pdfOutput, imageTemplatesRequest, dstFolder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertJPEGToPDF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertJPEGToPDF(): Failed to convert JPEG to PDF.");
            else
            {
                Console.WriteLine("ConvertJPEGToPDF(): image file '{0}' successfully converted to '{1}' file.", jpegFile, pdfOutput);
                await helper.DownloadFile(pdfOutput);
            }
        }
    }
}
