using Aspose.Pdf.Cloud.Sdk.Model;
using System.IO.Compression;

namespace Conversions
{
    public class ConvertImagesToPDF
    {
        public static async Task Convert(ConversionsHelper helper, List<string> images, string pdfOutput, string remoteFolder)
        {
            List<ImageTemplate> imageTemplateList = new List<ImageTemplate>();
            foreach (string image in images)
            {
                await helper.UploadFile(image);
                ImageTemplate template = new ImageTemplate(ImagePath: Path.Combine(remoteFolder, image), ImageSrcType: ImageSrcType.Common);
                imageTemplateList.Add(template);
            };

            ImageTemplatesRequest imageTemplatesRequest = new ImageTemplatesRequest(
                IsOCR: true,
                OCRLangs: "eng",
                ImagesList: imageTemplateList
            );

            AsposeResponse response = await helper.pdfApi.PutImageInStorageToPdfAsync(pdfOutput, imageTemplatesRequest, dstFolder: remoteFolder);

            if (response == null)
                Console.WriteLine("ConvertImagesToPDF(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ConvertImagesToPDF(): Failed to convert BMP to PDF.");
            else
            {
                Console.WriteLine("ConvertImagesToPDF(): image files successfully converted to '{0}' file.", pdfOutput);
                await helper.DownloadFile(pdfOutput);
            }
        }
    }
}
