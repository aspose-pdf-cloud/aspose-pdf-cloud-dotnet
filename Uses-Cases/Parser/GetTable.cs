using Aspose.Pdf.Cloud.Sdk.Model;

namespace Parser
{
    public class GetTable
    {
        public static async Task Extract(ParserHelper helper, string documentName, string tableId, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            TableRecognizedResponse response = await helper.pdfApi.GetTableAsync(documentName, tableId, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("GetTable(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("GetTable(): Failed to receive Table from the document.");
            else if (response.Table == null)
                Console.WriteLine("GetTable(): Table '{0}' not found in the document '{1]'.", tableId, documentName);
            else
            {
                Console.WriteLine("GetTable(): Table '{0}' successfully received from the document '{1}.", tableId, documentName);
                Console.WriteLine(response.Table.ToString());
            }
        }
    }
}
