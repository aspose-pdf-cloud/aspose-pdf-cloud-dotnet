using Aspose.Pdf.Cloud.Sdk.Model;

namespace Links
{
    public class LinksRemove
    {
        public static async Task Delete(LinksHelper helper, string documentName, string outputName, string LinkID, string remoteFolder)
        {
            await LinksExtractById.ShowInfo(helper, documentName, LinkID, remoteFolder);

            await helper.UploadFile(documentName);

            AsposeResponse response = await helper.pdfApi.DeleteLinkAnnotationAsync(documentName, LinkID, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("LinksRemove(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("LinksRemove(): Failed to remove link from the document.");
            else {
                Console.WriteLine("LinksRemove(): link '{0}' successfully removed from the document '{1}.", LinkID, documentName);
                await helper.DownloadFile(documentName, outputName, "del_link_");
            }
        }
    }
}