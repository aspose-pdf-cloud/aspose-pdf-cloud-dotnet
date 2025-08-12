using Aspose.Pdf.Cloud.Sdk.Model;

namespace Bookmarks
{
    public class BookmarksExtract
    {
        public static async Task ShowInfo(BookmarksHelper helper, string documentName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            BookmarksResponse response = await helper.pdfApi.GetDocumentBookmarksAsync(documentName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("BookmarksExtract(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("BookmarksExtract(): Failed to receive bookmarks from the document.");
            else if (response.Bookmarks == null || response.Bookmarks.List == null || response.Bookmarks.List.Count == 0)
                Console.WriteLine("BookmarksExtract(): bookmarks not found in the document.");
            else
            {
                Console.WriteLine("BookmarksExtract(): all bookmarks successfully received from the document '{0}.", documentName);
                foreach (Bookmark bookmark in response.Bookmarks.List) {
                    Console.WriteLine("BookmarksExtract(): ID = {0}", bookmark.Links[0].Href);
                    Console.WriteLine(bookmark.ToString());
                }
            }
        }
    }
}
