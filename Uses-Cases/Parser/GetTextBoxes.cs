using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;

namespace Parser
{
    public class GetTextBoxes
    {
        public static async Task Extract(ParserHelper helper, string documentName, string localFolder, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            TextBoxFieldsResponse response = await helper.pdfApi.GetDocumentTextBoxFieldsAsync(documentName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("GetTextBoxes(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("GetTextBoxes(): Failed to receive TextBox fields from the document.");
            else if (response.Fields == null || response.Fields.List == null || response.Fields.List.Count == 0)
                Console.WriteLine("GetTextBoxes(): TextBox fields not found in the document '{0]'.", documentName);
            else
            {
                Console.WriteLine("GetTextBoxes(): TextBox fields successfully received from the document '{0}.", documentName);
                string jsonResult = "[\n";
                foreach (var textBox in response.Fields.List)
                {
                    var respTextBox = await helper.pdfApi.GetTextBoxFieldAsync(documentName, textBox.FullName, folder: remoteFolder);

                    Console.WriteLine(respTextBox.Field);

                    jsonResult += JsonConvert.SerializeObject(respTextBox.Field) + ",\n\n";
                }
                jsonResult += "]";
                string fileName = Path.Combine(localFolder, "parsed_text_boxes_output.json");
                File.WriteAllText(fileName, jsonResult);
                Console.WriteLine("GetTextBoxes(): File '{0}' successfully downloaded.", fileName);
            }
        }
    }
}
