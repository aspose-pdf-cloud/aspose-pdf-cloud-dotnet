using Aspose.Pdf.Cloud.Sdk.Model;
using System.Runtime.Intrinsics.X86;

namespace Annotations
{
    public class ReplaceAnnotation
    {
        public static async Task<TextAnnotation> GetAnnotationAsync(AnnotationsHelper helper, string documentName, string annotationId, string remoteFolder)
        {
            // Get annotation by Id in the PDF document.
            TextAnnotation annotationResult = null;
            TextAnnotationResponse response = await helper.pdfApi.GetTextAnnotationAsync(documentName, annotationId, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("GetAnnotationAsync(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("GetAnnotationAsync(): Failed to request text annotation from the document.");
            else
            {
                Console.WriteLine("GetAnnotationAsync(): annotation '{0}' with '{1}' contents successfully found in the document '{2}.", response.Annotation.Id, response.Annotation.Contents, documentName);
                annotationResult = response.Annotation;
            }
            return annotationResult;
        }

        public static async Task ModifyAsync(AnnotationsHelper helper, string documentName, string outputName, string annotationId, string remoteFolder)
        {
            // Change annotation on the page in the PDF document.
            await helper.UploadFile(documentName);
            TextAnnotation annotation = await ReplaceAnnotation.GetAnnotationAsync(helper, documentName, annotationId, remoteFolder);

            annotation.Contents = helper.config.REPLACED_CONTENT;
            annotation.Icon = TextIcon.Star;

            TextAnnotationResponse response = await helper.pdfApi.PutTextAnnotationAsync(documentName, annotationId, annotation, folder: remoteFolder);
            if (response == null)
                Console.WriteLine("ModifyAnnotation(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ModifyAnnotation(): Failed to request text annotation from the document.");
            else
            {
                Console.WriteLine("ModifyAnnotation(): annotation '{0}' successfully modified in the document '{1}.", annotationId, documentName);
                await helper.DownloadFile(documentName, outputName, "replaced_annotatiom_");
            }
        }
    }
}