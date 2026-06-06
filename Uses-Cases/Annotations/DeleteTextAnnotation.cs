using Aspose.Pdf.Cloud.Sdk.Model;

namespace Annotations
{
    public class DeleteTextAnnotation
    {
        public async static Task MakeDeleteAsync(AnnotationsHelper helper, string documentName, string annotationId, string outputName, string remoteFolder)
        {
            // Delete annotation from the PDF document.
            await helper.UploadFile(documentName);
            AsposeResponse response = await helper.pdfApi.DeleteAnnotationAsync(documentName, annotationId, folder: remoteFolder);
            if (response == null)
                Console.WriteLine("DeleteTextAnnotation(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("DeleteTextAnnotation(): Failed to delete annotation from the document.");
            else
            {
                await helper.DeletePopupAnnotationsAsync(documentName, annotationId, remoteFolder);
                Console.WriteLine("DeleteTextAnnotation(): annotations '{0}' deleted from the document '{1}.", annotationId,  documentName);
                await helper.DownloadFile(documentName, outputName, "del_text_annotations_");
            }
        }
    }
}
