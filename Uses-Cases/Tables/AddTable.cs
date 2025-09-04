using Aspose.Pdf.Cloud.Sdk.Model;

namespace Tables
{
    public class AddTable
    {
        public static async Task Append(TablesHelper helper, string documentName, int pageNaumber, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            Table table = TableCreate.New();

            AsposeResponse response = await helper.pdfApi.PostPageTablesAsync(documentName, pageNaumber, new List<Table>() { table }, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("AddTable(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("AddTable(): Failed to append Table in the document.");
            else
            {
                Console.WriteLine("AddTable(): New table successfully appended in the document '{0}.", documentName);
                await helper.DownloadFile(documentName, outputName, "add_table_");
            }
        }
    }
}
