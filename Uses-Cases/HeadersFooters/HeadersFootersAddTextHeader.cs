using Aspose.Pdf.Cloud.Sdk.Model;
using System.IO;

namespace HeadersFooters
{
    public class HeadersFootersAddTextHeader
    {
        public static async Task Append(HeadersFootersHelper helper, string documentName, string outputName, string footerText, int startPage, int endPage, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            TextHeader footer = new TextHeader(
                Background: true,
                LeftMargin: 1,
                RightMargin: 2,
                HorizontalAlignment: HorizontalAlignment.Center,
                Opacity: 1,
                Rotate: Rotation.None,
                RotateAngle: 15,
                XIndent: 0,
                YIndent: 0,
                Zoom: 1,
                Value: footerText
            );

            var response = await helper.pdfApi.PostDocumentTextHeaderAsync(documentName, footer, startPage, endPage, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("HeadersFootersAddTextHeader(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("HeadersFootersAddTextHeader(): Failed to append text header to the page of document.");
            else
            {
                Console.WriteLine("HeadersFootersAddTextFooter(): text '{0}' appended as header to the document '{1}.", footerText, documentName);
                await helper.DownloadFile(documentName, outputName, "add_text_header_");
            }
        }
    }
}
