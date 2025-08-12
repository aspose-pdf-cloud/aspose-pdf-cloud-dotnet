using Aspose.Pdf.Cloud.Sdk.Model;

namespace Stamps
{
    public class StampsNewImages
    {
        public static async Task Append(StampsHelper helper, string documentName, string outputName, string imageFileName, float width, float height, string remoteFolder)
        {
            await helper.UploadFile(documentName);
            await helper.UploadFile(imageFileName);

            ImageStamp stamp = new ImageStamp(
                Background: true, 
                HorizontalAlignment: HorizontalAlignment.Center,
                VerticalAlignment: VerticalAlignment.Top,
                Opacity: 0.3,
                Rotate: Rotation.None,
                RotateAngle: 45,
                Width: width,
                Height: height,
                Zoom: 1,
                FileName: Path.Combine(remoteFolder, imageFileName));

            AsposeResponse response = await helper.pdfApi.PostDocumentImageStampsAsync(documentName, new List<ImageStamp> { stamp }, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("StampsNewImages(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("StampsNewImages(): Failed to append image stamp to the document.");
            else
            {
                Console.WriteLine("StampsNewImages(): image '{0}' added as stamp to the document '{1}.", imageFileName, documentName);
                await helper.DownloadFile(documentName, outputName, "add_image_stamp_");
            }
        }
    }
}
