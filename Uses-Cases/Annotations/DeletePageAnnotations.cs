using Aspose.Pdf.Cloud.Sdk.Model;

namespace Annotations
{
    public class DeletePageAnnotations
    {
        public async static Task MakeDeleteAsync(AnnotationsHelper helper, string documentName, int pageNumber, string outputName, string remoteFolder)
        {
            // Delete annotation from the PDF document.
            await helper.UploadFile(documentName);
            AsposeResponse response = await helper.pdfApi.DeletePageAnnotationsAsync(documentName, pageNumber, folder: remoteFolder);
            if (response == null)
                Console.WriteLine("DeletePageAnnotations(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("DeletePageAnnotations(): Failed to delete annotation from the document.");
            else {
                Console.WriteLine("DeletePageAnnotations(): annotations on page '{0}' deleted from the document '{1}.", pageNumber, documentName);
                await helper.DownloadFile(documentName, outputName, "del_page_annotations_");
            }
        }
    }
}
