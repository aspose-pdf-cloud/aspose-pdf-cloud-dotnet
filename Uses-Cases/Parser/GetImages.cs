using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;

namespace Parser
{
    public class GetImages
    {
        public static async Task Extract(ParserHelper helper, string documentName, int pageNumber, string localFolder, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            ImagesResponse response = await helper.pdfApi.GetImagesAsync(documentName, pageNumber, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("GetImages(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("GetImages(): Failed to receive Images from '{0}' page of the document.", pageNumber);
            else if (response.Images == null || response.Images.List == null || response.Images.List.Count == 0)
                Console.WriteLine("GetImages(): Images not found in the document '{0]'.", documentName);
            else
            {
                Console.WriteLine("GetImages(): Images successfully received from the document '{0}.", documentName);
                foreach (var image in response.Images.List)
                {
                    using (var respImage = await helper.pdfApi.GetImageExtractAsPngAsync(documentName, image.Id, folder: remoteFolder))
                    {
                        Console.WriteLine(image.ToString());

                        string fileName = Path.Combine(localFolder, image.Id + ".png");
                        using (var file = File.Create(fileName)) {
                            respImage.Seek(0, SeekOrigin.Begin);
                            await respImage.CopyToAsync(file);
                            Console.WriteLine("GetImages(): File '{0}' successfully downloaded.", fileName);
                        }
                    }
                }
            }
        }
    }
}
