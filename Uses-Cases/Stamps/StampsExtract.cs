using Aspose.Pdf.Cloud.Sdk.Model;

namespace Stamps
{
    public class StampsExtract
    {
        public static async Task ShowInfo(StampsHelper helper, string documentName, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            StampsInfoResponse response = await helper.pdfApi.GetDocumentStampsAsync(documentName, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("StampsDeleteOnPage(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("StampsDeleteOnPage(): Failed to receive stamps from the document.");
            else
            {
                Console.WriteLine("StampsDeleteOnPage(): all stamps successfully received from the document '{0}.", documentName);
                foreach (StampInfo stamp in response.Stamps.List)
                    Console.WriteLine(stamp.ToString());
            }
        }
    }
}
