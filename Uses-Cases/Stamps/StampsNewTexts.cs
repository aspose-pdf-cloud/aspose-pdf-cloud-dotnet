using Aspose.Pdf.Cloud.Sdk.Model;

namespace Stamps
{
    public class StampsNewTexts
    {
        public static async Task Append(StampsHelper helper, string documentName, string outputName, string textValue, string remoteFolder)
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
                TextState: new TextState(FontSize: 14, FontStyle: FontStyles.BoldItalic, Font: "Arial", ForegroundColor: new Color( A: 0xFF, R: 0xFF, G: 0x00, B: 0x00))
            );

            AsposeResponse response = await helper.pdfApi.PostDocumentTextStampsAsync(documentName, new List<TextStamp> { stamp }, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("StampsNewImages(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("StampsNewImages(): Failed to append text stamp to the document.");
            else
            {
                Console.WriteLine("StampsNewImages(): text '{0}' added as stamp to the document '{1}.", textValue, documentName);
                await helper.DownloadFile(documentName, outputName, "add_text_stamp_");
            }
        }
    }
}
