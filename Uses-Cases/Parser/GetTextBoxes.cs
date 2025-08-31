using Aspose.Pdf.Cloud.Sdk.Model;

namespace Parser
{
    public class GetTextBoxes
    {
        public static async Task Extract(ParserHelper helper, string documentName, string remoteFolder)
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
                foreach (TextBoxField textBox in response.Fields.List)
                {
                    Console.WriteLine(textBox.ToString());
                }
            }
        }
    }
}
