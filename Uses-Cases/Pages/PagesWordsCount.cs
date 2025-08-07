using Aspose.Pdf.Cloud.Sdk.Model;

namespace Pages
{
    public class PagesWordsCount
    {
        public static async Task Get(PagesHelper helper, string documentName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            WordCountResponse response = await helper.pdfApi.GetWordsPerPageAsync(documentName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("PagesWordsCount(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("PagesWordsCount(): Failed to get words per pages from the document.");
            else
            {
                Console.WriteLine("PagesWordsCount(): words count successfully received from the document '{0}'.", documentName);
                foreach (var p in response.WordsPerPage.List)
                {
                    Console.WriteLine("PagesWordsCount(): page '{0}' contains '{1}' words in the document '{2}'.", p.PageNumber, p.Count, documentName);
                }
            }
        }
    }
}
