using Aspose.Pdf.Cloud.Sdk.Model;

namespace Links
{
    public class LinksExtract
    {
        public static async Task ShowInfo(LinksHelper helper, string documentName, int pageNumber, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            LinkAnnotationsResponse response = await helper.pdfApi.GetPageLinkAnnotationsAsync(documentName, pageNumber, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("LinksExtract(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("LinksExtract(): Failed to receive links from the document.");
            else if (response.Links == null || response.Links.List == null || response.Links.List.Count == 0)
                Console.WriteLine("LinksExtract(): links not found in the document.");
            else {
                Console.WriteLine("LinksExtract(): all links successfully received from the document '{0}.", documentName);
                foreach (LinkAnnotation link in response.Links.List)
                    Console.WriteLine(link.ToString());
            }
        }
    }
}
