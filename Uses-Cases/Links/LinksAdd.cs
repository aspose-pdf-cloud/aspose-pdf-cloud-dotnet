using Aspose.Pdf.Cloud.Sdk.Model;

namespace Links
{
    public class LinksAdd
    {
        public static async Task Append(LinksHelper helper, string documentName, string outputName, int pageNumber, string LinkAction, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            Rectangle rectangle = new Rectangle(LLX: 238, LLY: 488.622, URX: 305, URY: 498.588);

            Link link = new Link(LinkAction);

            LinkAnnotation newLink = new LinkAnnotation(
                new List<Link>() { link },
                ActionType: LinkActionType.GoToURIAction,
                Action: LinkAction,
                Highlighting: LinkHighlightingMode.Invert,
                Color: new Color(A: 0xFF, R: 0xAA, G: 0x00, B: 0x00),
                Rect: rectangle
            );

            AsposeResponse response = await helper.pdfApi.PostPageLinkAnnotationsAsync(documentName, pageNumber, new List<LinkAnnotation>() { newLink }, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("LinksAdd(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("LinksAdd(): Failed to add link to the document.");
            else {
                Console.WriteLine("LinksAdd(): link '{0}' successfully appended to the document '{1}.", LinkAction, documentName);
                await helper.DownloadFile(documentName, outputName, "add_link_");
            }
        }
    }
}
