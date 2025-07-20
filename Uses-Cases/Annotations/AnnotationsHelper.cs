using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;

namespace Annotations
{
    public class ConfigParams
    {
        public string CrdentialPath { get; } = "..\\credentials.json ";
        public string LOCAL_FOLDER { get; } = "C:\\Samples";
        public string REMOTE_TEMP_FOLDER { get; } = "TempPdfCloud";
        public string PDF_DOCUMENT { get; } = "sample.pdf";
        public string PDF_OUTPUT { get; } = "output_sample.pdf";
        public int PAGE_NUMBER { get; } = 1;

        public string ANNOTATION_ID { get; } = "GE5TAOZTHA2CYMRZGUWDIMBZFQZTEMA";

        public string NEW_HL_ANNOTATION_TEXT { get; } = "NEW HIGHLIGHT TEXT ANNOTATION";
        public string NEW_HL_ANNOTATION_DESCRIPTION { get; } = "This is a sample highlight annotation";
        public string NEW_HL_ANNOTATION_SUBJECT { get; } = "Highlight Text Box Subject";
        public string NEW_HL_ANNOTATION_CONTENTS { get; } = "Highlight annotation sample contents";

        public string NEW_SO_ANNOTATION_TEXT { get; } = "NEW STRIKEOUT TEXT ANNOTATION";
        public string NEW_SO_ANNOTATION_DESCRIPTION { get; } = "This is a sample strikeout annotation";
        public string NEW_SO_ANNOTATION_SUBJECT { get; } = "Strikeout Text Box Subject";
        public string NEW_SO_ANNOTATION_CONTENTS { get; } = "Strikeout annotation sample contents";

        public string NEW_UL_ANNOTATION_TEXT { get; } = "NEW UNDERLINE TEXT ANNOTATION";
        public string NEW_UL_ANNOTATION_DESCRIPTION { get; } = "This is a sample underline annotation";
        public string NEW_UL_ANNOTATION_SUBJECT { get; } = "Underline Text Box Subject";
        public string NEW_UL_ANNOTATION_CONTENTS { get; } = "Underline annotation sample contents";

        public string NEW_FT_ANNOTATION_TEXT { get; } = "NEW FREE TEXT ANNOTATION";
        public string NEW_FT_ANNOTATION_DESCRIPTION { get; } = "This is a sample annotation";
        public string NEW_FT_ANNOTATION_SUBJECT { get; } = "Free Text Box Subject";
        public string NEW_FT_ANNOTATION_CONTENTS { get; } = "Free Text annotation sample contents";

        public string REPLACED_CONTENT { get; } = "This is a replaced sample annotation";
    }

    public class Credentials
    {
        public string Id { get; set; }
        public string Key { get; set; }
    }

    public class AnnotationsHelper
    {
        public PdfApi pdfApi { get; private set; }
        public ConfigParams config { get; private set; }

        public AnnotationsHelper()
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

        public async Task DeletePopupAnnotationsAsync(string documentName, string parentAnnotation, string remoteFolder)
        {
            // Delete popup annotations for typed parent annotation in the page in the PDF document.
            PopupAnnotationsResponse response = await pdfApi.GetDocumentPopupAnnotationsAsync(documentName, folder: config.REMOTE_TEMP_FOLDER);
            if (response == null)
                Console.WriteLine("DeletePopupAnnotations(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("DeletePopupAnnotations(): Unexpected error '{0}'!", response.Status);
            else
            {
                foreach (PopupAnnotationWithParent annotation in response.Annotations.List)
                {
                    if (annotation.Parent.Id == parentAnnotation)
                    {
                        string popupContents = annotation.Contents;
                        AsposeResponse response2 = await pdfApi.DeleteAnnotationAsync(documentName, annotation.Id, folder: remoteFolder);
                        if (response2 == null)
                            Console.WriteLine("DeletePopupAnnotations(): Unexpected error!");
                        else if (response2.Code < 200 || response2.Code > 299)
                            Console.WriteLine("DeletePopupAnnotations(): Failed to delete popup annotation '{0}' from the document.", popupContents);
                        else
                            Console.WriteLine("DeletePopupAnnotations(): popup annotations '{0}' with '{1}' contents deleted from the document '{1}.", annotation.Id, popupContents, documentName);
                    }
                }
            }
        }
    }
}
