using Aspose.Pdf.Cloud.Sdk.Model;

namespace Signatures
{
    public class ReplaceSignature
    {
        public static async Task Update(SignaturesHelper helper, ConfigParams config, string documentName, string fieldName, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            Signature signature = new Signature(
                SignaturePath: Path.Combine(remoteFolder, config.SIGNATURE_PFX),
                SignatureType: SignatureType.PKCS7,
                Password: config.SIGNATURE_PASSWORD,
                Contact: config.SIGNATURE_CONTACT,
                Location: config.SIGNATURE_LOCATION,
                Visible: true,
                Rectangle: config.SIGNATURE_RECT,
                FormFieldName: config.SIGNATURE_FORM_FIELD,
                Authority: config.SIGNATURE_AUTHORITY,
                Date: config.SIGNATURE_DATE,
                ShowProperties: true);

            SignatureField field = new SignatureField(
                PageIndex: 1,
                Signature: signature,
                PartialName: fieldName,
                Rect: config.SIGNATURE_RECT);

            var response = await helper.pdfApi.PutSignatureFieldAsync(documentName, fieldName, field, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("ReplaceSignature(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("ReplaceSignature(): Failed to replace Pdf document signature.");
            else
            {
                Console.WriteLine("ReplaceSignature(): Signature replaced successfully in the Pdf document '{0}'.", documentName);
                await helper.DownloadFile(documentName, outputName, string.Empty);
            }
        }

    }
}
