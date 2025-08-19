using Aspose.Pdf.Cloud.Sdk.Model;
using System.IO;

namespace HeadersFooters
{
    public class HeadersFootersAddImageFooter
    {
        public static async Task Append(HeadersFootersHelper helper, string documentName, string outputName, string imageFileName, int startPage, int endPage, string remoteFolder)
        {
            await helper.UploadFile(documentName);
            await helper.UploadFile(imageFileName);

            ImageFooter footer = new ImageFooter(
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

            var response = await helper.pdfApi.PostDocumentImageFooterAsync(documentName, footer, startPage, endPage, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("HeadersFootersAddImageFooter(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("HeadersFootersAddImageFooter(): Failed to append image footer to the page of document.");
            else
            {
                Console.WriteLine("HeadersFootersAddImageFooter(): image '{0}' appended as footer to the document '{1}.", imageFileName, documentName);
                await helper.DownloadFile(documentName, outputName, "add_image_footer_");
            }
        }
    }
}
