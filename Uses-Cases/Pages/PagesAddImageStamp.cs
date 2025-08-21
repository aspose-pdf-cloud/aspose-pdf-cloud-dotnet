using Aspose.Pdf.Cloud.Sdk.Model;

namespace Pages
{
    public class PagesAddImageStamp
    {
        public static async Task Append(PagesHelper helper, string documentName, string outputName, int pageNumber, string imageFileName, float width, float height, string remoteFolder)
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

            AsposeResponse response = await helper.pdfApi.PostPageImageStampsAsync(documentName, pageNumber, new List<ImageStamp> { stamp }, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("PagesAddImageStamp(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("PagesAddImageStamp(): Failed to append image stamp to the page of document.");
            else
            {
                Console.WriteLine("PagesAddImageStamp(): image '{0}' appended as stamp to the page '{1}' of document '{2}.", imageFileName, pageNumber, documentName);
                await helper.DownloadFile(documentName, outputName, "add_page_image_stamp_");
            }
        }
    }
}
