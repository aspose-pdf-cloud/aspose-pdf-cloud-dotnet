using Aspose.Pdf.Cloud.Sdk.Model;

namespace Pages
{
    public class PagesDelete
    {
        public static async Task Delete(PagesHelper helper, string documentName, string outputName, int pageNumber, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            AsposeResponse response = await helper.pdfApi.DeletePageAsync(documentName, pageNumber, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("PagesDelete(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("PagesDelete(): Failed to delete page from the document.");
            else
            {
                Console.WriteLine("PagesDelete(): page '{0}' successfully deleted from the document '{1}'.", pageNumber, documentName);
                await helper.DownloadFile(documentName, outputName, "delete_pages_");
            }
        }
    }
}
