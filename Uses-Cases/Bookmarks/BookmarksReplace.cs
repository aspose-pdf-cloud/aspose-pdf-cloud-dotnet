using Aspose.Pdf.Cloud.Sdk.Model;

namespace Bookmarks
{
    public class BookmarksReplace
    {
        public static async Task Modify(BookmarksHelper helper, string documentName, string outputName, string bookmarkPath, string title, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            Bookmark bookmark = new Bookmark(
                Action: "GoTo",
                Bold: true,
                Italic: false,
                Title: title,
                PageDisplay: "XYZ",
                PageDisplayBottom: 10,
                PageDisplayLeft: 10,
                PageDisplayRight: 10,
                PageDisplayTop: 10,
                PageDisplayZoom: 2,
                PageNumber: 1,
                Color: new Color(A: 0x00, R: 0x00, G: 0xFF, B: 0x00)
            );

            BookmarkResponse response = await helper.pdfApi.PutBookmarkAsync(documentName, bookmarkPath, bookmark, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("BookmarksReplace(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("BookmarksReplace(): Failed to modify bookmark in the document.");
            else
            {
                Console.WriteLine("BookmarksReplace(): bookmark '{0}' successfully modified in the document '{1}.", title, documentName);
                await helper.DownloadFile(documentName, outputName, "replace_bookmark_");
            }
        }
    }
}
