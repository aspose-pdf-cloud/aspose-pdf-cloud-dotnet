using Aspose.Pdf.Cloud.Sdk.Model;
using EncryptDecrypt;

namespace EnryptDecrypt
{
    public class PasswordModify
    {
        public static async Task Change(EncryptDecryptHelper helper, string documentName, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            string ownerPassword = "user $^Password!&";

            string newOwnerPassword = "NEW-Owner-Password";
            string newUserPassword = "NEW-User-Password";

            AsposeResponse response = await helper.pdfApi.PostChangePasswordDocumentInStorageAsync(
                documentName,
                helper.ToBase64(ownerPassword),
                helper.ToBase64(newUserPassword),
                helper.ToBase64(newOwnerPassword),
                folder: remoteFolder);

            if (response == null)
                Console.WriteLine("PasswordModify(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("PasswordModify(): Failed to change password in document.");
            else
            {
                Console.WriteLine("PasswordModify(): password in document '{0} successfully changed.", documentName);
                await helper.DownloadFile(documentName, outputName, "password_modify_");
            }
        }
    }
}
