using Aspose.Pdf.Cloud.Sdk.Model;


namespace Links
{
    public class LinksExtractById
    {
        public static async Task ShowInfo(LinksHelper helper, string documentName, string LinkID, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            LinkAnnotationResponse response = await helper.pdfApi.GetLinkAnnotationAsync(documentName, LinkID, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("LinksExtractById(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("LinksExtractById(): Failed to receive link from the document.");
            else if (response.Link == null)
                Console.WriteLine("LinksExtract(): link '{0}' not found in the document '{1]'.", LinkID, documentName);
            else {
                Console.WriteLine("LinksExtractById(): link '{0}' successfully received from the document '{1}.", LinkID, documentName);
                Console.WriteLine(response.Link.ToString());
            }
        }
    }
}
