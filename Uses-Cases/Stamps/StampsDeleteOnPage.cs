using Aspose.Pdf.Cloud.Sdk.Model;

namespace Stamps
{
    public class StampsDeleteOnPage
    {
        public static async Task Delete(StampsHelper helper, string documentName, string outputName, int pageNumber, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            AsposeResponse response = await helper.pdfApi.DeletePageStampsAsync(documentName, pageNumber, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("StampsDeleteOnPage(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("StampsDeleteOnPage(): Failed to delete text stamp to the document.");
            else
            {
                Console.WriteLine("StampsDeleteOnPage(): all stamps on page {0} successfully deleted in the document '{1}.", pageNumber, documentName);
                await helper.DownloadFile(documentName, outputName, "del_page_stamps_");
            }
        }
    }
}
