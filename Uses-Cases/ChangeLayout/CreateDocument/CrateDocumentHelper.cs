using Aspose.Pdf.Cloud.Sdk.Api;
using Newtonsoft.Json;

namespace CreateDocument
{
    public class ConfigParams
    {
        public string CrdentialPath { get; } = "c:\\Projects\\ASPOSE\\Pdf.Cloud\\Credentials\\credentials.json";
        public string LOCAL_FOLDER { get; } = "C:\\Samples";
        public string TEMP_FOLDER { get; } = "TempPdfCloud";
        public string LOCAL_RESULT_DOCUMENT_NAME { get; } = "output_sample.pdf";
        public int PAGE_WIDTH { get; } = 590;
        public int PAGE_HEIGHT { get; } = 894;
        public int PAGES_COUNT { get; } = 5;
    }

    public class Credentials
    {
        public string Id { get; set; }
        public string Key { get; set; }
    }

    public class CrateDocumentHelper
    {
        public PdfApi pdfApi {  get; private set; }
        public ConfigParams config { get; private set; }

        public CrateDocumentHelper()
        {
            config = new ConfigParams();
            string jsCredText = File.ReadAllText(config.CrdentialPath);
            Credentials cred = JsonConvert.DeserializeObject<Credentials>(jsCredText);
            pdfApi = new PdfApi(cred.Key, cred.Id);
        }

        public async void DownloadFile(string filename)
        {
            Stream stream = pdfApi.DownloadFile(Path.Combine(config.TEMP_FOLDER, filename));
            using var fileStream = File.Create(Path.Combine(config.LOCAL_FOLDER, config.LOCAL_RESULT_DOCUMENT_NAME));
            stream.Position = 0;
            await stream.CopyToAsync(fileStream);
            Console.WriteLine("DownloadFile(): File '{0}' successfully downloaded.", filename);
        }
    }
}
