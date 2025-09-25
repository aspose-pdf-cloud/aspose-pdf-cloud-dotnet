using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;

namespace Tables
{
    public class ConfigParams
    {
        public string CrdentialPath { get; } = "c:\\Projects\\ASPOSE\\Pdf.Cloud\\Credentials\\credentials.json";
        public string LOCAL_FOLDER { get; } = "C:\\Samples";
        public string REMOTE_TEMP_FOLDER { get; } = "TempPdfCloud";
        public string PDF_DOCUMENT { get; } = "sample.pdf";

        public string PDF_OUTPUT { get; } = "output_sample.pdf";
        
        public int PAGE_NUMBER { get; } = 2;

        public string TABLE_ID { get; } = "GE5TCOZSGAYCYNRQGUWDINZVFQ3DGMA";
    }

    public class Credentials
    {
        public string Id { get; set; }
        public string Key { get; set; }
    }

    public class TablesHelper
    {
        public PdfApi pdfApi { get; private set; }
        public ConfigParams config { get; private set; }

        public TablesHelper()
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