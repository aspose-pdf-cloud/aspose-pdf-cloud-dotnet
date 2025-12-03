using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;

namespace Pages
{
    public class ConfigParams
    {
        public string CrdentialPath { get; } = "settings/credentials.json";
        public string LOCAL_FOLDER { get; } = "testData";
        public string REMOTE_TEMP_FOLDER { get; } = "TempPdfCloud";
        public string PDF_DOCUMENT { get; } = "sample.pdf";
        public string PDF_OUTPUT { get; } = "output_sample.pdf";

        public string PNG_PAGE_OUTPUT { get; } = "output_sample_page.png";

        public string IMAGE_STAMP_FILE { get; } = "sample.png";

        public int PAGE_NUMBER { get; } = 2;
        public string STAMP_TEXT { get; } = "NEW TEXT STAMP";
        public int IMAGE_STAMP_LLY { get; } = 800;
        public int IMAGE_STAMP_WIDTH { get; } = 24;
        public int IMAGE_STAMP_HEIGHT { get; } = 24;
    }

    public class Credentials
    {
        [JsonProperty("client_id")]
        public string Id { get; set; }
        [JsonProperty("client_secret")]
        public string Key { get; set; }
    }

    public class PagesHelper
    {
        public PdfApi pdfApi { get; private set; }
        public ConfigParams config { get; private set; }

        public PagesHelper()
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
