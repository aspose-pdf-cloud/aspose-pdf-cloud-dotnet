using Aspose.Pdf.Cloud.Sdk.Model;

namespace Pages
{
    public class PagesExtractInfo
    {
        public static async Task Extract(PagesHelper helper, string documentName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            DocumentPagesResponse response = await helper.pdfApi.GetPagesAsync(documentName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("PagesExtractInfo(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("PagesExtractInfo(): Failed to receive pages from the document.");
            else if (response.Pages == null || response.Pages.List == null || response.Pages.List.Count == 0)
                Console.WriteLine("PagesExtractInfo(): pages not found in the document.");
            else
            {
                Console.WriteLine("PagesExtractInfo(): all pages successfully received from the document '{0}.", documentName);
                foreach (Page page in response.Pages.List)
                {
                    Console.WriteLine("PagesExtractInfo(): ID = {0}", page.Id);
                    Console.WriteLine(page.ToString());
                }
            }
        }
    }
}
