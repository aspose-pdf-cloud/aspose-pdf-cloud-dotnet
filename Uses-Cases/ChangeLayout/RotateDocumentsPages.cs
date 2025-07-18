using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace ChangeLayout
{
    public class RotateDocumentsPages
    {
        private ChangeLayoutHelper _helper;

        public RotateDocumentsPages(ChangeLayoutHelper helper)
        {
            _helper = helper;
        }

        public async Task MakeRotateDocumentsPages(string document, string rotateAngle, string pages)
        { 
            await _helper.UploadFile(document);
            AsposeResponse response = await _helper.pdfApi.PostDocumentPagesRotateAsync(document, rotateAngle, pages, folder: _helper.config.REMOTE_TEMP_FOLDER);
            if (response.Code != 200)
                Console.WriteLine("MakeRotateDocumentsPages(): Unexpected error!");
            else {
                Console.WriteLine("MakeRotateDocumentsPages(): Pages '{0}' successfully rotated!");

                await _helper.DownloadFile(document, "rotated_");
            } 
        }
    }
}