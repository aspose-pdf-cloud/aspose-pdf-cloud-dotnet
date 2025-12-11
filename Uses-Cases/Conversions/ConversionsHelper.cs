using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;

namespace Conversions
{
    public class ConfigParams
    {
        public string CrdentialPath { get; } = "settings/credentials.json";
        public string LOCAL_FOLDER { get; } = "testData";
        public string REMOTE_TEMP_FOLDER { get; } = "TempPdfCloud";
        public string PDF_DOCUMENT { get; } = "sample.pdf";

        public string JPEG_FILE_NAME { get; } = "Koala.jpg";
        public string BMP_FILE_NAME { get; } = "sample.bmp";
        public string PNG_FILE_NAME { get; } = "sample.png";
        public string GIF_FILE_NAME { get; } = "sample.gif";

        public string PDF_BMP_OUTPUT { get; } = "output_bmp.pdf";
        public string PDF_JPEG_OUTPUT { get; } = "output_jpeg.pdf";
        public string PDF_PNG_OUTPUT { get; } = "output_png.pdf";
        public string PDF_GIF_OUTPUT { get; } = "output_gif.pdf";

        public string HTML_FILE_NAME { get; } = "HtmlExample1.html";
        public double PDF_HTML_WIDTH { get; } = 600;
        public double PDF_HTML_HEIGHT { get; } = 850;
        public string PDF_HTML_OUTPUT { get; } = "output_html.pdf";

        public string MHTML_FILE_NAME { get; } = "MhtExample.mht";
        public string PDF_MHTML_OUTPUT { get; } = "output_mht.pdf";

        public string MD_FILE_NAME { get; } = "sample.md";
        public string PDF_MD_OUTPUT { get; } = "output_md.pdf";

        public string EPUB_FILE_NAME { get; } = "4pages.epub";
        public string PDF_EPUB_OUTPUT { get; } = "output_epub.pdf";

        public string PCL_FILE_NAME { get; } = "template.pcl";
        public string PDF_PCL_OUTPUT { get; } = "output_pcl.pdf";

        public string PS_FILE_NAME { get; } = "sample.ps";
        public string PDF_PS_OUTPUT { get; } = "output_ps.pdf";

        public string PDF_OUTPUT { get; } = "output_sample.pdf";
        public string DOC_OUTPUT { get; } = "output_sample.doc";
        public string DOCX_OUTPUT { get; } = "output_sample.docx";
        public string EPUB_OUTPUT { get; } = "output_sample.epub";
        public string HTML_ZIP_OUTPUT { get; } = "output_sample_html.zip";
        public string TIFF_OUTPUT { get; } = "output_sample.tiff";
        public string SVG_ZIP_OUTPUT { get; } = "output_sample_svg.zip";
        public string XLS_OUTPUT { get; } = "output_sample.xls";
        public string XLSX_OUTPUT { get; } = "output_sample.xlsx";
        public string PPTX_OUTPUT { get; } = "output_sample.pptx";
        public string XML_OUTPUT { get; } = "output_sample.xml";
        public string MXML_OUTPUT { get; } = "output_sample.mobi";
        public string TEX_OUTPUT { get; } = "output_sample.tex";
        public string XPS_OUTPUT { get; } = "output_sample.xps";
    }

    public class Credentials
    {
        [JsonProperty("client_id")]
        public string Id { get; set; }
        [JsonProperty("client_secret")]
        public string Key { get; set; }
    }

    public class ConversionsHelper
    {
        public PdfApi pdfApi { get; private set; }
        public ConfigParams config { get; private set; }

        public ConversionsHelper()
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

        public async Task DownloadFile(string fileName)
        {
            Stream stream = pdfApi.DownloadFile(Path.Combine(config.REMOTE_TEMP_FOLDER, fileName));
            using var fileStream = File.Create(Path.Combine(config.LOCAL_FOLDER, fileName));
            stream.Position = 0;
            await stream.CopyToAsync(fileStream);
            Console.WriteLine("DownloadFile(): File '{0}' successfully downloaded.", fileName);
        }
    }
}
