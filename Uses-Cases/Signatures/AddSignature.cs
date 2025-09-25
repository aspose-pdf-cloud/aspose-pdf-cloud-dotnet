using Aspose.Pdf.Cloud.Sdk.Model;

namespace Signatures
{
    public class AddSignature
    {
        public static async Task Append(SignaturesHelper helper, ConfigParams config, string documentName, string fieldName, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            Signature signature = new Signature(
                SignaturePath: config.SIGNATURE_PFX,
                SignatureType: SignatureType.PKCS7,
                Password: config.SIGNATURE_PASSWORD,
                Contact: config.SIGNATURE_CONTACT,
                Location: config.SIGNATURE_LOCATION,
                Visible: true,
                Rectangle: config.SIGNATURE_RECT,
                FormFieldName: config.SIGNATURE_FORM_FIELD,
                Authority: config.SIGNATURE_AUTHORITY,
                Date: config.SIGNATURE_DATE,
                ShowProperties: false);

            SignatureField field = new SignatureField(
                PageIndex: 1,
                Signature: signature,
                PartialName: fieldName,
                Rect: config.SIGNATURE_RECT);

            var response = await helper.pdfApi.PostSignatureFieldAsync(documentName, field, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("AddSignature(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("AddSignature(): Failed to append Pdf document signature.");
            else
            {
                Console.WriteLine("AddSignature(): Signature appended successfully to the Pdf document '{0}'.", documentName);
                await helper.DownloadFile(documentName, outputName, string.Empty);
            }
        }
    }
}
