using Aspose.Pdf.Cloud.Sdk.Model;

namespace Pages
{
    public class PagesAdd
    {
        public static async Task Append(PagesHelper helper, string documentName, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            DocumentPagesResponse response = await helper.pdfApi.PutAddNewPageAsync(documentName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("PagesAdd(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("PagesAdd(): Failed to append page to the document.");
            else
            {
                Console.WriteLine("PagesAdd(): page successfully appended to the document '{0}.", documentName);
                await helper.DownloadFile(documentName, outputName, "append_pages_");
            }
        }
    }
}
