using Aspose.Pdf.Cloud.Sdk.Model;

namespace Bookmarks
{
    public class BookmarksAdd
    {
        public static async Task Append(BookmarksHelper helper, string documentName, string outputName, string parentBookmarkPath, string title, string remoteFolder)
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
            List<Bookmark> newBookmarks = new List<Bookmark>() { bookmark };
            
            BookmarksResponse response = await helper.pdfApi.PostBookmarkAsync(documentName, parentBookmarkPath, newBookmarks, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("BookmarksAdd(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("BookmarksAdd(): Failed to append bookmark to the document.");
            else
            {
                Console.WriteLine("BookmarksAdd(): bookmark '{0}' successfully appended to the document '{1}.", title, documentName);
                await helper.DownloadFile(documentName, outputName, "add_bookmark_");
            }
        }
    }
}
