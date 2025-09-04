using Aspose.Pdf.Cloud.Sdk.Model;


namespace Tables
{
    public class DeleteTableOnPage
    {
        public static async Task Remove(TablesHelper helper, string documentName, int pageNumber, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            AsposeResponse response = await helper.pdfApi.DeletePageTablesAsync(documentName, pageNumber, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("DeleteTableOnPage(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("DeleteTableOnPage(): Failed to remove Tables from the document.");
            else
            {
                Console.WriteLine("DeleteTableOnPage(): Tables successfully deleted from '{0}' page of the document '{1}.", pageNumber, documentName);
                await helper.DownloadFile(documentName, outputName, "del_tables_page_");
            }
        }
    }
}
