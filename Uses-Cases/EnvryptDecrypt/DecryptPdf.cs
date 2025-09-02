using Aspose.Pdf.Cloud.Sdk.Model;
using EncryptDecrypt;

namespace EnryptDecrypt
{
    public class DecryptPdf
    {
        public static async Task Decrypt(EncryptDecryptHelper helper, string documentName, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            string ownerPassword = "Owner-Password";

            AsposeResponse response = await helper.pdfApi.PostDecryptDocumentInStorageAsync(
                documentName,
                helper.ToBase64(ownerPassword),
                folder: remoteFolder);

            if (response == null)
                Console.WriteLine("DecryptPdf(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("DecryptPdf(): Failed to decrypt document.");
            else
            {
                Console.WriteLine("DecryptPdf(): document '{0} successfully decrypted.", documentName);
                await helper.DownloadFile(documentName, outputName, "decrypt_");
            }
        }
    }
}
