using Aspose.Pdf.Cloud.Sdk.Model;

namespace Annotations
{
    public class GetAnnotations
    {
        public static async Task<string> RequestAnnotationsOnPageAsync(AnnotationsHelper helper, string documentName, int pageNumber, string remoteFolder)
        {
            // Get annotations from the page in the PDF document.
            await helper.UploadFile(documentName);

            string annotationResult = string.Empty;
            AnnotationsInfoResponse response = await helper.pdfApi.GetPageAnnotationsAsync(documentName, pageNumber, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("RequestAnnotationsOnPageAsync(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("RequestAnnotationsOnPageAsync(): Failed to request annotations from the document.");
            else
            {
                foreach (AnnotationInfo annotation in response.Annotations.List)
                {
                    Console.WriteLine("RequestAnnotationsOnPageAsync(): annotation '{0}' with '{1}' contents get from the '{2}' page of the document '{3}.", [annotation.Id, annotation.Contents, pageNumber, documentName]);
                    if (string.IsNullOrEmpty(annotationResult) &&
                         annotation.AnnotationType == AnnotationType.Text)
                    {
                        annotationResult = annotation.Id;
                    }
                }
            }
            return annotationResult;
        }
    }
}