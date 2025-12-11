using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;

namespace Signatures
{
    public class ConfigParams
    {
        public string CrdentialPath { get; } = "settings/credentials.json";
        public string LOCAL_FOLDER { get; } = "testData";
        public string REMOTE_TEMP_FOLDER { get; } = "TempPdfCloud";
        
        public string PDF_DOCUMENT { get; } = "sample.pdf";
        public string PDF_SIGNED_DOCUMENT { get; } = "adbe.x509.rsa_sha1.valid.pdf";

        public string PDF_OUTPUT { get; } = "output_sample.pdf";

        public string LOCAL_SIGNATURE_PATH { get; } = "testData";
        public string SIGNATURE_PFX { get; } = "33226.p12";
        public string SIGNATURE_FORM_FIELD { get; } = "Signature1";
        public string SIGNATURE_PASSWORD { get; } = "sIikZSmz";
        public string SIGNATURE_CONTACT { get; } = "Contact";
        public string SIGNATURE_LOCATION { get; } = "Location";
        public string SIGNATURE_AUTHORITY { get; } = "Sergey Smal";
        public string SIGNATURE_DATE { get; } = "04/19/2025 12:15:00.000 PM";
        public Rectangle SIGNATURE_RECT { get; } = new Rectangle(100, 100, 500, 500);

    }

    public class Credentials
    {
        [JsonProperty("client_id")]
        public string Id { get; set; }
        [JsonProperty("client_secret")]
        public string Key { get; set; }
    }

    public class SignaturesHelper
    {
        public PdfApi pdfApi { get; private set; }
        public ConfigParams config { get; private set; }

        public SignaturesHelper()
        {
            config = new ConfigParams();
            string jsCredText = File.ReadAllText(config.CrdentialPath);
            Credentials cred = JsonConvert.DeserializeObject<Credentials>(jsCredText);
            pdfApi = new PdfApi(cred.Key, cred.Id);
        }

        public async Task UploadFile(string fileName)
        {
            using (var file = File.OpenRead(Path.Combine(config.LOCAL_FOLDER, fileName)))
            {
                FilesUploadResult response = await pdfApi.UploadFileAsync(Path.Combine(config.REMOTE_TEMP_FOLDER, fileName), file);
                if (response == null)
                    Console.WriteLine("UploadFile(): Unexpected error - no response!");
                else if (response.Errors != null && response.Errors.Count > 0)
                    foreach (var error in response.Errors)
                        Console.WriteLine("UploadFile(): {0} -> {1}", [error.Code, error.Message]);
                else
                    Console.WriteLine("UploadFile(): File '{0}' successfully uploaded.", fileName);
            }
        }

        public async Task DownloadFile(string fileName, string outputName, string outputPrefix)
        {
            Stream stream = pdfApi.DownloadFile(Path.Combine(config.REMOTE_TEMP_FOLDER, fileName));
            using var fileStream = File.Create(Path.Combine(config.LOCAL_FOLDER, outputPrefix + outputName));
            stream.Position = 0;
            await stream.CopyToAsync(fileStream);
            Console.WriteLine("DownloadFile(): File '{0}' successfully downloaded.", outputPrefix + outputName);
        }
    }
}