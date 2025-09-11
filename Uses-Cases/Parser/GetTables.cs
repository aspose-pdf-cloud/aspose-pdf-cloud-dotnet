using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace Parser
{
    public class GetTables
    {
        public static async Task Extract(ParserHelper helper, string documentName, string localFolder, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            TablesRecognizedResponse response = await helper.pdfApi.GetDocumentTablesAsync(documentName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("GetTables(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("GetTables(): Failed to receive Tables from the document.");
            else if (response.Tables == null || response.Tables.List == null || response.Tables.List.Count == 0)
                Console.WriteLine("GetTables(): Tables not found in the document '{0]'.", documentName);
            else
            {
                Console.WriteLine("GetTables(): Tables successfully received from the document '{0}.", documentName);
                string jsonResult = "[\n";
                foreach (var table in response.Tables.List)
                {
                    var tabResp = await helper.pdfApi.GetTableAsync(documentName, table.Id, folder: remoteFolder);

                    Console.WriteLine(tabResp.Table);

                    jsonResult += JsonConvert.SerializeObject(tabResp.Table) + ",\n\n";
                }
                jsonResult += "]";
                string fileName = Path.Combine(localFolder, "parsed_tables_output.json");
                File.WriteAllText(fileName, jsonResult);
                Console.WriteLine("GetImages(): File '{0}' successfully downloaded.", fileName);
            }
        }
    }
}
