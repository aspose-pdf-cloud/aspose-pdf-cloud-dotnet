using Aspose.Pdf.Cloud.Sdk.Model;

namespace Annotations
{
    public class NewStrikeoutAnnotation
    {
        public static async Task Append(AnnotationsHelper helper, string documentName, int pageNumber, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            List<StrikeOutAnnotation> annotations = new List<StrikeOutAnnotation>
            {
                new StrikeOutAnnotation(
                    Name: "Strikeout_NEW_Annotation",
                    Rect: new Rectangle(100,350, 450,400),
                    Flags: new List<AnnotationFlags>() { AnnotationFlags.Default },
                    HorizontalAlignment: HorizontalAlignment.Left,
                    VerticalAlignment: VerticalAlignment.Top,
                    RichText: helper.config.NEW_SO_ANNOTATION_TEXT,
                    Subject: helper.config.NEW_SO_ANNOTATION_SUBJECT,
                    Contents: helper.config.NEW_SO_ANNOTATION_CONTENTS,
                    Title: helper.config.NEW_SO_ANNOTATION_DESCRIPTION,
                    ZIndex: 1,
                    Color: new Color(A: 0xFF, R: 0x00, G: 0xFF, B: 0x00),
                    QuadPoints: new List<Point>() {
                        new Point(X: 10, Y: 10),
                        new Point(X: 20, Y: 10),
                        new Point(X: 10, Y: 20),
                        new Point(X: 10, Y: 10)
                    },
                    Modified: "03/27/2025 00:00:00.000 AM"
                )
            };
            AsposeResponse response = await helper.pdfApi.PostPageStrikeOutAnnotationsAsync(documentName, pageNumber, annotations, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("NewStrikeoutAnnotation(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("NewStrikeoutAnnotation(): Failed to append strikeout annotation to the document.");
            else
            {
                Console.WriteLine("NewStrikeoutAnnotation(): annotations '{0}' added to the document '{1}.", helper.config.NEW_SO_ANNOTATION_TEXT, documentName);
                await helper.DownloadFile(documentName, outputName, "add_strikeout_annotation_");
            }
        }
    }
}
