using Aspose.Pdf.Cloud.Sdk.Model;
using System.IO;

namespace HeadersFooters
{
    public class HeadersFootersAddImageHeader
    {
        public static async Task Append(HeadersFootersHelper helper, string documentName, string outputName, string imageFileName, int startPage, int endPage, string remoteFolder)
        {
            await helper.UploadFile(documentName);
            await helper.UploadFile(imageFileName);

            ImageHeader header = new ImageHeader(
                Background: true,
                LeftMargin: 1,
                RightMargin: 2,
                HorizontalAlignment: HorizontalAlignment.Center,
                Opacity: 1,
                Rotate: Rotation.None,
                RotateAngle: 0,
                XIndent: 0,
                YIndent: 0,
                Zoom: 1,
                Width: 24,
                Height: 24,
                FileName: Path.Combine(remoteFolder, imageFileName)
            );

            var response = await helper.pdfApi.PostDocumentImageHeaderAsync(documentName, header, startPage, endPage, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("HeadersFootersAddImageHeader(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("HeadersFootersAddImageHeader(): Failed to append image header to the page of document.");
            else
            {
                Console.WriteLine("HeadersFootersAddImageHeader(): image '{0}' appended as header to the document '{1}.", imageFileName, documentName);
                await helper.DownloadFile(documentName, outputName, "add_image_header_");
            }
        }
    }
}
