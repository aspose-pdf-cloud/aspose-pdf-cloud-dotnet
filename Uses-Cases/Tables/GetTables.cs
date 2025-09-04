using Aspose.Pdf.Cloud.Sdk.Model;

namespace Tables
{
    public class GetTables
    {
        public static async Task Extract(TablesHelper helper, string documentName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            TablesRecognizedResponse response = await helper.pdfApi.GetDocumentTablesAsync(documentName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("GetTables(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("GetTables(): Failed to receive Tables from the document.");
            else if (response.Tables == null || response.Tables.List == null || response.Tables.List.Count == 0)
                Console.WriteLine("GetTables(): Tables not found in the document '{0}'.", documentName);
            else
            {
                Console.WriteLine("GetTables(): Tables successfully received from the document '{0}.", documentName);
                foreach (var table in response.Tables.List)
                {
                    Console.WriteLine(table.ToString());
                }
            }
        }
    }
}
