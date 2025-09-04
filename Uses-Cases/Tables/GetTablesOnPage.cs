using Aspose.Pdf.Cloud.Sdk.Model;

namespace Tables
{
    public class GetTablesOnPage
    {
        public static async Task Extract(TablesHelper helper, string documentName, int pageNumber, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            TablesRecognizedResponse response = await helper.pdfApi.GetPageTablesAsync(documentName, pageNumber, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("GetTablesOnPage(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("GetTablesOnPage(): Failed to receive Tables from the document.");
            else if (response.Tables == null || response.Tables.List == null || response.Tables.List.Count == 0)
                Console.WriteLine("GetTablesOnPage(): Tables not found on '{0}' page of the document '{1}'.", pageNumber, documentName);
            else
            {
                Console.WriteLine("GetTablesOnPage(): Tables successfully received from '{0}' page of the document '{1}.", pageNumber, documentName);
                foreach (var table in response.Tables.List)
                {
                    Console.WriteLine(table.ToString());
                }
            }
        }
    }
}
