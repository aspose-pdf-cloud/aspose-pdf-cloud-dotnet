using Aspose.Pdf.Cloud.Sdk.Model;


namespace Signatures
{
    public class VerifySignature
    {
        public static async Task Check(SignaturesHelper helper, string documentName, string fieldName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            var response = await helper.pdfApi.GetVerifySignatureAsync(documentName, fieldName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("VerifySignature(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("VerifySignature(): Failed to verify Pdf document signature.");
            else
            {
                Console.WriteLine("VerifySignature(): Signature verified successfully in the Pdf document '{0}'. Status: '{1}'", 
                    documentName, response.Valid);
            }

        }
    }
}
