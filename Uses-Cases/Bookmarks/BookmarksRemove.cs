using Aspose.Pdf.Cloud.Sdk.Model;

namespace Bookmarks
{
    public class BookmarksRemove
    {
        public static async Task Delete(BookmarksHelper helper, string documentName, string outputName, string bookmarkPath, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            AsposeResponse response = await helper.pdfApi.DeleteBookmarkAsync(documentName, bookmarkPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("BookmarksRemove(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("BookmarksRemove(): Failed to remove bookmark from the document.");
            else
            {
                Console.WriteLine("BookmarksRemove(): bookmark '{0}' successfully removed from the document '{1}.", bookmarkPath, documentName);
                await helper.DownloadFile(documentName, outputName, "del_bookmark_");
            }
        }
    }
}