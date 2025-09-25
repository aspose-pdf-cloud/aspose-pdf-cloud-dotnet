using Aspose.Pdf.Cloud.Sdk.Model;

namespace Signatures
{
    public class GetSignatures
    {
        public static async Task Extract(SignaturesHelper helper, string documentName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            var response = await helper.pdfApi.GetDocumentSignatureFieldsAsync(documentName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("GetSignatures(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("GetSignatures(): Failed to receive Pdf document signatures.");
            else
            {
                Console.WriteLine("GetSignatures(): Signatures extracted successfully from the Pdf document '{0}'.", documentName);

                foreach (var field in response.Fields.List) {
                    Console.WriteLine(field);
                }
            }

        }
    }
}
