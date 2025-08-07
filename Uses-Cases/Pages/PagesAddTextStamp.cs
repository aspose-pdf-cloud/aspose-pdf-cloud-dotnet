using Aspose.Pdf.Cloud.Sdk.Model;

namespace Pages
{
    public class PagesAddTextStamp
    {
        public static async Task Append(PagesHelper helper, string documentName, string outputName, int pageNumber, string textValue, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            TextStamp stamp = new TextStamp(
                Background: true,
                HorizontalAlignment: HorizontalAlignment.Left,
                VerticalAlignment: VerticalAlignment.Top,
                Opacity: .3,
                Rotate: Rotation.None,
                RotateAngle: 30,
                Zoom: 1,
                TextAlignment: HorizontalAlignment.Center,
                Value: textValue,
                TextState: new TextState(FontSize: 14, FontStyle: FontStyles.BoldItalic, Font: "Arial", ForegroundColor: new Color(A: 0xFF, R: 0xFF, G: 0x00, B: 0x00))
            );

            AsposeResponse response = await helper.pdfApi.PostPageTextStampsAsync(documentName, pageNumber, new List<TextStamp> { stamp }, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("PagesAddTextStamp(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("PagesAddTextStamp(): Failed to append text stamp to the page of document.");
            else
            {
                Console.WriteLine("PagesAddTextStamp(): text '{0}' appended as stamp to the page '{1}' of document '{2}.", textValue, pageNumber, documentName);
                await helper.DownloadFile(documentName, outputName, "add_page_text_stamp_");
            }
        }
    }
}
