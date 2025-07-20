using Aspose.Pdf.Cloud.Sdk.Model;


namespace CreateDocument
{
    public class CreatePdfDocument
    {
        public CreatePdfDocument(CrateDocumentHelper helper)
        {
            DocumentProperties docProps = new DocumentProperties(
                List: new List<DocumentProperty>() { 
                    new DocumentProperty(Name: "prop1", Value: "Value1", BuiltIn: false)
                }
            );

            DisplayProperties dispProps = new DisplayProperties()
            {
                CenterWindow = true,
                HideMenuBar = true,
                Direction = Direction.L2R,
                DisplayDocTitle = true,
                HideToolBar = true,
                HideWindowUI = true,
                NonFullScreenPageMode = PageMode.UseThumbs,
                PageLayout = PageLayout.TwoPageLeft,
                PageMode = PageMode.UseThumbs
            };

            DefaultPageConfig pageConfig = new DefaultPageConfig(helper.config.PAGE_HEIGHT, helper.config.PAGE_WIDTH);

            DocumentConfig document_config = new DocumentConfig(
                DocumentProperties: docProps,
                DisplayProperties: dispProps,
                DefaultPageConfig: pageConfig,
                PagesCount: helper.config.PAGES_COUNT
            );

            DocumentResponse response = helper.pdfApi.PostCreateDocument(helper.config.LOCAL_RESULT_DOCUMENT_NAME, document_config, folder: helper.config.TEMP_FOLDER);

            if (response != null && response.Code == 200)
                Console.WriteLine("Document #{0} created.", helper.config.LOCAL_RESULT_DOCUMENT_NAME);
            else
                Console.WriteLine("Unexpected error!!!");
        }
    }
}
