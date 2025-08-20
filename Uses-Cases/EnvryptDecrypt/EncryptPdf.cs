using Aspose.Pdf.Cloud.Sdk.Model;

namespace EncryptDecrypt
{
    public class EncryptPdf
    {
        public static async Task Encrypt(EncryptDecryptHelper helper, string documentName, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            string userPassword = "User-Password";
            string ownerPassword = "Owner-Password";

            AsposeResponse response = await helper.pdfApi.PostEncryptDocumentInStorageAsync(
                documentName,
                helper.ToBase64(userPassword),
                helper.ToBase64(ownerPassword),
                CryptoAlgorithm.AESx256.ToString(),
                folder: remoteFolder);

            if (response == null)
                Console.WriteLine("EncryptPdf(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("EncryptPdf(): Failed to encrypt document.");
            else
            {
                Console.WriteLine("EncryptPdf(): document '{0} successfully encrypted.", documentName);
                await helper.DownloadFile(documentName, outputName, "encrypt_");
            }
        }
    }
}
