using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;

namespace ChangeLayout
{
    public class ConfigParams
    {
        public string CrdentialPath { get; } = "..\\credentials.json ";
        public string LOCAL_FOLDER { get; } = "C:\\Samples";
        public string REMOTE_TEMP_FOLDER { get; } = "TempPdfCloud";
        public string PDF_DOCUMENT { get; } = "sample.pdf";
        public string PDF_OUTPUT { get; } = "output_sample.pdf";

        public Rotation ROTATE_PAGES_ANGLE = Rotation.On90;
        public string ROTATE_PAGES { get; } = "1-3";


        public string CROP_PAGE_TEMP_FILE { get; } = "sample_temp_file.png";
        public string CROP_LOCAL_RESULT_DOCUMENT_NAME { get; } = "output_sample.pdf";
        public int CROP_PAGE_NUMBER { get; } = 3;
        public int CROP_HEIGHT { get; } = 400;
        public int CROP_WIDTH { get; } = 300;
        public int CROP_LLX { get; } = 100;
        public int CROP_LLY { get; } = 200;

        public string RESIZE_PDF_HTML_FILE { get; } = "sample_temp_file.html";
        public string RESIZE_RESULT_DOCUMENT_NAME { get; } = "output_sample.pdf";
        public int RESIZE_PAGE_NUMBER { get; } = 2;
        public int RESIZE_NEW_PAGE_WIDTH { get; } = 1000;
        public int RESIZE_NEW_PAGE_HEIGHT { get; } = 500;

        public int CROP_PAGE_WIDTH { get; set; } = 0;
        public int CROP_PAGE_HEIGHT { get; set; } = 0;
    }

    public class Credentials
    {
        public string Id { get; set; }
        public string Key { get; set; }
    }

    public class ChangeLayoutHelper
    {
        public PdfApi pdfApi { get; private set; }
        public ConfigParams config { get; private set; }

        public ChangeLayoutHelper()
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
                        Console.WriteLine("UploadFile(): {0} -> {1}", [ error.Code, error.Message]);
                else
                    Console.WriteLine("UploadFile(): File '{0}' successfully uploaded.", fileName);
            }
        }

        public async Task DownloadFile(string fileName, string outputPrefix)
        {
            Stream stream = pdfApi.DownloadFile(Path.Combine(config.REMOTE_TEMP_FOLDER, fileName));
            using var fileStream = File.Create(Path.Combine(config.LOCAL_FOLDER, outputPrefix + fileName));
            stream.Position = 0;
            await stream.CopyToAsync(fileStream);
            Console.WriteLine("DownloadFile(): File '{0}' successfully downloaded.", outputPrefix + fileName);
        }

        public async Task GetPageInfo(string document, int pageNumber)
        {
            DocumentPageResponse response = await pdfApi.GetPageAsync(document, pageNumber, folder: config.REMOTE_TEMP_FOLDER);
            if (response == null)
                Console.WriteLine("GetPageInfo(): Unexpected error - no response!");
            else if (response.Code != 200)
                Console.WriteLine("GetPageInfo(): Code {0} -> Status '{1}'", [response.Code, response.Status]);
            else
            {
                Page page = response.Page;
                Rectangle rectangle = page.Rectangle;
                Console.WriteLine("GetPageInfo(): page {0} => id: '{1}', lLx: '{2}', lLY: '{3}', uRX: '{4}', uRY: '{5}'",
                    [pageNumber, page.Id, rectangle.LLX, rectangle.LLY, rectangle.URX, rectangle.URY]);
                config.CROP_PAGE_HEIGHT = (int)(Math.Round(rectangle.URY ?? 0) - Math.Round(rectangle.LLY ?? 0));
                config.CROP_PAGE_WIDTH = (int)(Math.Round(rectangle.URX ?? 0) - Math.Round(rectangle.LLX ?? 0));
            }
        }

        public async Task<string> ExtractPdfPage(string document, int pageNumber, int width, int height)
        {
            string imageFile = document + ".png";
            Stream stream = await pdfApi.GetPageConvertToPngAsync(document, pageNumber, width, height, config.REMOTE_TEMP_FOLDER);
            using var fileStream = File.Create(Path.Combine(config.LOCAL_FOLDER, imageFile));
            stream.Position = 0;
            await stream.CopyToAsync(fileStream);

            UploadFile(imageFile);
            Console.WriteLine("ExtractPdfPage(): Page #{0} extracted as image {1}.", [pageNumber, imageFile]);

            return imageFile;
        }

        public async Task<DocumentResponse?> CreatePdfDocument(string newDocument, int width, int height)
        {
            DocumentProperties docProps = new DocumentProperties(
                List: new List<DocumentProperty>() {
                    new DocumentProperty(Name: "prop1", Value: "Value1", BuiltIn: false)
                }
            );

            DisplayProperties dispProps = new DisplayProperties()
            {
                CenterWindow = true,
                HideMenuBar = true,
                Direction = Direction.L2R,
                DisplayDocTitle = true,
                HideToolBar = true,
                HideWindowUI = true,
                NonFullScreenPageMode = PageMode.UseThumbs,
                PageLayout = PageLayout.TwoPageLeft,
                PageMode = PageMode.UseThumbs
            };

            DefaultPageConfig pageConfig = new DefaultPageConfig(height, width);

            DocumentConfig document_config = new DocumentConfig(
                DocumentProperties: docProps,
                DisplayProperties: dispProps,
                DefaultPageConfig: pageConfig,
                PagesCount: 1
            );

            DocumentResponse response = await pdfApi.PostCreateDocumentAsync(newDocument, document_config, folder: config.REMOTE_TEMP_FOLDER);

            if (response != null && response.Code == 200)
            {
                Console.WriteLine("CreatePdfDocument(): Document '{0}' created.", newDocument);
                return response;
            }
            else
            {
                Console.WriteLine("CreatePdfDocument(): Unexpected error!!!");
                return null;
            }
        }

        public async Task<AsposeResponse?> InsertPageAsImage(string document, string imageFileValue, int llx, int lly)
        {
            ImageStamp imageStamp = new ImageStamp(
                Background: true,
                HorizontalAlignment: HorizontalAlignment.None,
                VerticalAlignment: VerticalAlignment.None,
                Rotate: Rotation.None,
                RotateAngle: 0,
                Opacity: 1,
                XIndent: -llx,
                YIndent: -lly,
                Zoom: 1,
                FileName: Path.Combine(config.REMOTE_TEMP_FOLDER, imageFileValue)
            );

            AsposeResponse response = await pdfApi.PostPageImageStampsAsync(document, 1, new List<ImageStamp>() { imageStamp}, folder: config.REMOTE_TEMP_FOLDER );
            if (response != null && response.Code == 200)
            {
                Console.WriteLine("InsertPageAsImage(): Document '{0}' with stamp '{1}' created.", [document, imageFileValue]);
                return response;
            }
            else
            {
                Console.WriteLine("CreatePdfDocument(): Unexpected error!!!");
                return null;
            }
        }
    }
}
