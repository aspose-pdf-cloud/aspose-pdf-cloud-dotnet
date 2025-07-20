using Aspose.Pdf.Cloud.Sdk.Model;

namespace Annotations
{
	public class NewHighlightAnnotation
	{
		public static async Task Append(AnnotationsHelper helper, string documentName, int pageNumber, string outputName, string remoteFolder)
		{
			await helper.UploadFile(documentName);

			List<HighlightAnnotation> annotations = new List<HighlightAnnotation>
			{
				new HighlightAnnotation(
					Name: "Highlight_NEW_Annotation",
					Rect: new Rectangle(100,350, 450,400),
					Flags: new List<AnnotationFlags>() { AnnotationFlags.Default },
					HorizontalAlignment: HorizontalAlignment.Left,
					VerticalAlignment: VerticalAlignment.Top,
					RichText: helper.config.NEW_HL_ANNOTATION_TEXT,
					Subject: helper.config.NEW_HL_ANNOTATION_SUBJECT,
					Contents: helper.config.NEW_HL_ANNOTATION_CONTENTS,
					Title: helper.config.NEW_HL_ANNOTATION_DESCRIPTION,
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
			AsposeResponse response = await helper.pdfApi.PostPageHighlightAnnotationsAsync(documentName, pageNumber, annotations, folder: remoteFolder);

			if (response == null)
				Console.WriteLine("NewHighlightAnnotation(): Unexpected error!");
			else if (response.Code < 200 || response.Code > 299)
				Console.WriteLine("NewHighlightAnnotation(): Failed to append highlight annotation to the document.");
			else
			{
				Console.WriteLine("NewHighlightAnnotation(): annotations '{0}' added to the document '{1}.", helper.config.NEW_HL_ANNOTATION_TEXT, documentName);
				await helper.DownloadFile(documentName, outputName, "add_highlight_annotation_");
			}
		}
    }
}
