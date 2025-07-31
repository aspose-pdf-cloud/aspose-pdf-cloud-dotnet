using Aspose.Pdf.Cloud.Sdk.Model;

namespace Bookmarks
{
    public class BookmarksExtractByPath
    {
        public static async Task ShowInfo(BookmarksHelper helper, string documentName, string bookmarkPath, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            BookmarkResponse response = await helper.pdfApi.GetBookmarkAsync(documentName,bookmarkPath, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("BookmarksExtractByPath(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("BookmarksExtractByPath(): Failed to receive bookmark from the document.");
            else if (response.Bookmark == null)
                Console.WriteLine("BookmarksExtractByPath(): bookmark '{0}' not found in the document '{1}'.", bookmarkPath, documentName);
            else
            {
                Console.WriteLine("BookmarksExtractByPath(): bookmark '{0}' successfully received from the document '{1}.", bookmarkPath, documentName);
                Console.WriteLine(response.Bookmark.ToString());
            }
        }
    }
}
