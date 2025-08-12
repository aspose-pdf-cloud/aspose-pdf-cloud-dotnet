using Aspose.Pdf.Cloud.Sdk.Model;

namespace Links
{
    public class LinksReplace
    {
        public static async Task Modify(LinksHelper helper, string documentName, string outputName, string LinkID, string LinkAction, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            LinkAnnotationResponse getResponse = await helper.pdfApi.GetLinkAnnotationAsync(documentName, LinkID, folder: remoteFolder);

            if (getResponse == null)
                Console.WriteLine("LinksReplace(): Unexpected error in GetLink!");
            else if (getResponse.Code < 200 || getResponse.Code > 299)
                Console.WriteLine("LinksReplace(): Failed to receive link from the document.");
            else if (getResponse.Link == null)
                Console.WriteLine("LinksReplace(): link '{0}' not found in the document '{1]'.", LinkID, documentName);
            else {
                Console.WriteLine("LinksReplace(): link '{0}' successfully received from the document '{1}.", LinkID, documentName);
                Console.WriteLine(getResponse.Link.ToString());

                Link link = new Link(LinkAction);

                LinkAnnotation newLink = new LinkAnnotation(
                    new List<Link>() { link },
                    ActionType: getResponse.Link.ActionType,
                    Action: LinkAction,
                    Highlighting: getResponse.Link.Highlighting,
                    Color: new Color(A: 0xFF, R: 0xAA, G: 0x00, B: 0x00),
                    Rect: getResponse.Link.Rect
                );

                AsposeResponse response = await helper.pdfApi.PutLinkAnnotationAsync(documentName, LinkID, newLink, folder: remoteFolder);

                if (response == null)
                    Console.WriteLine("LinksReplace(): Unexpected error in Modify!");
                else if (response.Code < 200 || response.Code > 299)
                    Console.WriteLine("LinksReplace(): Failed to replaced link in the document.");
                {
                    Console.WriteLine("LinksReplace(): link '{0}' successfully replaced in the document '{1}.", LinkID, documentName);
                    await helper.DownloadFile(documentName, outputName, "replace_link_");
                }
            }
        }
    }
}