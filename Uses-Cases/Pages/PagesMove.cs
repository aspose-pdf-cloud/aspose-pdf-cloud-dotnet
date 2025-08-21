using Aspose.Pdf.Cloud.Sdk.Model;

namespace Pages
{
    public class PagesMove
    {
        public static async Task Move(PagesHelper helper, string documentName, string outputName, int pageNumber, int newPageNumber, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            AsposeResponse response = await helper.pdfApi.PostMovePageAsync(documentName, pageNumber, newPageNumber, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("PagesMove(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("PagesMove(): Failed to move page to new index in the document.");
            else
            {
                Console.WriteLine("PagesMove(): page '{0}'successfully moved to new index '{1}' of the document '{2}.", pageNumber, newPageNumber, documentName);
                await helper.DownloadFile(documentName, outputName, "move_pages_");
            }
        }
    }
}
