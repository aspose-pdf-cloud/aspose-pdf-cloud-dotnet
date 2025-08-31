using Aspose.Pdf.Cloud.Sdk.Model;

namespace Parser
{
    public class GetTextBox
    {
        public static async Task Extract(ParserHelper helper, string documentName, string fieldName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            //helper.pdfApi.PostTextBoxFieldsAsync
            TextBoxFieldResponse response = await helper.pdfApi.GetTextBoxFieldAsync(documentName, fieldName, folder: remoteFolder);
            
            if (response == null)
                Console.WriteLine("GetTextBox(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("GetTextBox(): Failed to receive TextBox field from the document.");
            else if (response.Field == null)
                Console.WriteLine("GetTextBox(): TextBox field '{0}' not found in the document '{1]'.", fieldName, documentName);
            else
            {
                Console.WriteLine("GetTextBox(): TextBox field '{0}' successfully received from the document '{1}.", fieldName, documentName);
                Console.WriteLine(response.Field.ToString());
            }
        }
    }
}
