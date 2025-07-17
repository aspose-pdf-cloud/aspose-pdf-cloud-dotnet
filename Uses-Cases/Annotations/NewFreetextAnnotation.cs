using Aspose.Pdf.Cloud.Sdk.Model;

namespace Annotations
{
    public class NewFreetextAnnotation
    {
        public static async Task Append(AnnotationsHelper helper, string documentName, int pageNumber, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            List<FreeTextAnnotation> annotations = new List<FreeTextAnnotation>
            {
                new FreeTextAnnotation(
                    Name: "Freetext_NEW_Annotation",
                    Rect: new Rectangle(100,350, 450,400),
                    Flags: new List<AnnotationFlags>() { AnnotationFlags.Default },
                    HorizontalAlignment: HorizontalAlignment.Left,
                    Intent: FreeTextIntent.FreeTextTypeWriter,
                    Justification: Justification.Center,
                    RichText: helper.config.NEW_FT_ANNOTATION_TEXT,
                    Subject: helper.config.NEW_FT_ANNOTATION_SUBJECT,
                    Contents: helper.config.NEW_FT_ANNOTATION_CONTENTS,
                    Title: helper.config.NEW_FT_ANNOTATION_DESCRIPTION,
                    ZIndex: 1,
                    TextStyle: new TextStyle(
                        FontSize:        20,
		                Font: "Arial",
		                ForegroundColor: new Color( A: 0xFF, R: 0x00, G: 0xFF, B: 0x00),
		                BackgroundColor: new Color( A: 0xFF, R: 0xFF, G: 0x00, B: 0x00)
	                ),
                    Modified: "03/27/2025 00:00:00.000 AM"
                )
            };
            AsposeResponse response = await helper.pdfApi.PostPageFreeTextAnnotationsAsync(documentName, pageNumber, annotations, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("NewFreetextAnnotation(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("NewFreetextAnnotation(): Failed to append text annotation to the document.");
            else
            {
                Console.WriteLine("NewFreetextAnnotation(): annotations '{0}' added to the document '{1}.", helper.config.NEW_FT_ANNOTATION_TEXT, documentName);
                await helper.DownloadFile(documentName, outputName, "add_text_annotation_");
            }
        }
    }
}
