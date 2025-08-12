using Aspose.Pdf.Cloud.Sdk.Model;

namespace Stamps
{
    public class StampsDelete
    {
        public static async Task Delete(StampsHelper helper, string documentName, string outputName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            AsposeResponse response = await helper.pdfApi.DeleteDocumentStampsAsync(documentName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("StampsDelete(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("StampsDelete(): Failed to delete text stamp to the document.");
            else
            {
                Console.WriteLine("StampsDelete(): all stamps successfully deleted  the document '{0}.", documentName);
                await helper.DownloadFile(documentName, outputName, "del_stamp_");
            }
        }
    }
}
