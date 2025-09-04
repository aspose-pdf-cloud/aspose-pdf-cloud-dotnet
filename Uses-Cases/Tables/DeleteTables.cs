using Aspose.Pdf.Cloud.Sdk.Model;


namespace Tables
{
    public class DeleteTables
    {
        public static async Task Remove(TablesHelper helper, string documentName, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            AsposeResponse response = await helper.pdfApi.DeleteDocumentTablesAsync(documentName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("DeleteTables(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("DeleteTables(): Failed to remove Tables from the document.");
            else
            {
                Console.WriteLine("DeleteTables(): Tables successfully deleted from the document '{0}.", documentName);
                await helper.DownloadFile(documentName, outputName, "del_tables_");
            }
        }
    }
}
