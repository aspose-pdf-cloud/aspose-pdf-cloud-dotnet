using Aspose.Pdf.Cloud.Sdk.Model;


namespace Tables
{
    public class DeleteTable
    {
        public static async Task Remove(TablesHelper helper, string documentName, string tableId, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            AsposeResponse response = await helper.pdfApi.DeleteTableAsync(documentName, tableId, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("DeleteTable(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("DeleteTable(): Failed to remove Table '{0}' from the document.", tableId);
            else
            {
                Console.WriteLine("DeleteTable(): Table '{0}' successfully deleted from the document '{1}.", tableId, documentName);
                await helper.DownloadFile(documentName, outputName, "del_table_");
            }
        }
    }
}
