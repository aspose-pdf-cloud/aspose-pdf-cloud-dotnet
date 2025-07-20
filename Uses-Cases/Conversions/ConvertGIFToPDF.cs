using Aspose.Pdf.Cloud.Sdk.Model;

namespace Conversions
{
    public class ConvertGIFToPDF
    {
        public static async Task Convert(ConversionsHelper helper, string gifFile, string pdfOutput, string remoteFolder)
        {
            await helper.UploadFile(gifFile);

            List<ImageTemplate> imageTemplateList = new List<ImageTemplate> {
                new ImageTemplate(ImagePath: Path.Combine(remoteFolder, gifFile), ImageSrcType: ImageSrcType.Common)
            };

            ImageTemplatesRequest imageTemplatesRequest = new ImageTemplatesRequest(
                IsOCR: true,
                OCRLangs: "eng",
                ImagesList: imageTemplateList
            );

            AsposeResponse response = await helper.pdfApi.PutImageInStorageToPdfAsync(pdfOutput, imageTemplatesRequest, dstFolder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertGIFToPDF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertGIFToPDF(): Failed to convert GIF to PDF.");
            else
            {
                Console.WriteLine("ConvertGIFToPDF(): image file '{0}' successfully converted to '{1}' file.", gifFile, pdfOutput);
                await helper.DownloadFile(pdfOutput);
            }
        }
    }
}
