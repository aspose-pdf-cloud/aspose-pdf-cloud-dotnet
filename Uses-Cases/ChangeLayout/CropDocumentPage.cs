using Aspose.Pdf.Cloud.Sdk.Model;

namespace ChangeLayout
{
    public class CropDocumentPage
    {
        private ChangeLayoutHelper _helper;

        public CropDocumentPage(ChangeLayoutHelper helper)
        {
            _helper = helper;
        }

        public async Task MakeCropDocumentPage(string document, string outputDocument, int pageNumber, int llx, int lly, int width, int height)
        {
            await _helper.UploadFile(document);
            await _helper.GetPageInfo(document, pageNumber);
            string imageFile = await _helper.ExtractPdfPage(document, pageNumber, _helper.config.CROP_PAGE_WIDTH, _helper.config.CROP_PAGE_HEIGHT);
            DocumentResponse? newPdf = await _helper.CreatePdfDocument(outputDocument, width, height);
            if (newPdf == null)
                Console.WriteLine("MakeCropDocumentPage(): Unexpected error - new document is NULL");
            else if (newPdf.Code != 200)
                Console.WriteLine("MakeCropDocumentPage(): Failed to create new PDF document!");
            else
            {
                AsposeResponse? response = await _helper.InsertPageAsImage(outputDocument, imageFile, llx, lly);
                if (response == null)
                    Console.WriteLine("MakeCropDocumentPage(): Unexpected error - insert image return NULL");
                else if (newPdf.Code != 200)
                    Console.WriteLine("MakeCropDocumentPage(): Failed to insert image to the new PDF document!");
                else
                {
                    Console.WriteLine("cropPage(): Page successfully cropped.");
                    await _helper.DownloadFile(outputDocument, "cropped_");
                }
            }
        }
    }
}