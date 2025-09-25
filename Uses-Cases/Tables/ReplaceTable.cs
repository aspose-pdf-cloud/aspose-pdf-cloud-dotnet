using Aspose.Pdf.Cloud.Sdk.Model;

namespace Tables
{
    public class ReplaceTable
    {
        public static async Task Modify(TablesHelper helper, string documentName, string tableId, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            Table table = TableCreate.New();

            AsposeResponse response = await helper.pdfApi.PutTableAsync(documentName, tableId, table, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ReplaceTable(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ReplaceTable(): Failed to replace Table in the document.");
            else
            {
                Console.WriteLine("ReplaceTable(): Table successfully replaced in the document '{0}.", documentName);
                await helper.DownloadFile(documentName, outputName, "replace_table_");
            }
        }
    }
}
