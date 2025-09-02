using Aspose.Pdf.Cloud.Sdk.Model;

namespace Parser
{
    public class GetImage
    {
        public static async Task Extract(ParserHelper helper, string documentName, string imageId, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            ImageResponse response = await helper.pdfApi.GetImageAsync(documentName, imageId, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("GetImage(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("GetImage(): Failed to receive Image from the document.");
            else if (response.Image == null)
                Console.WriteLine("GetImage(): Image '{0}' not found in the document '{1]'.", imageId, documentName);
            else
            {
                Console.WriteLine("GetImage(): Image '{0}' successfully received from the document '{1}.", imageId, documentName);
                Console.WriteLine(response.Image.ToString());
            }
        }
    }
}
