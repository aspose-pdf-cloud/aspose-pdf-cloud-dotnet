
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;

using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System;

namespace Aspose.Pdf.Cloud.Sdk.Example
{

    public class LinkAnnotationsExamples
    {
        private const string Name = "PdfWithLinks.pdf";
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";


        public void GetPageLinkAnnotationExample()
        {
            //ExStart: GetPageLinkAnnotationExample
            var getLinksResponse = api.GetPageLinkAnnotations(Name, 1, folder: FolderName);

            string linkId = getLinksResponse.Links.List[0].Id;

            var response = api.GetPageLinkAnnotation(Name, pageNumber: 1, linkId: linkId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageLinkAnnotationExample
        }


        public void DeleteLinkAnnotationExample()
        {
            //ExStart: DeleteLinkAnnotationExample
            var getLinksResponse = api.GetPageLinkAnnotations(Name, 1, folder: FolderName);

            string linkId = getLinksResponse.Links.List[0].Id;

            var response = api.DeleteLinkAnnotation(Name, linkId: linkId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: DeleteLinkAnnotationExample
        }


        public void GetPageLinkAnnotationsExample()
        {
            //ExStart: GetPageLinkAnnotationsExample
            var response = api.GetPageLinkAnnotations(Name, 1, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageLinkAnnotationsExample
        }


        public void PostPageLinkAnnotationsExample()
        {
            //ExStart: PostPageLinkAnnotationsExample
            LinkAnnotation linkAnnotation = new LinkAnnotation(null, LinkActionType.GoToURIAction, "https://products.aspose.cloud/pdf",
                LinkHighlightingMode.Invert, new Color(0xFF, 0xAA, 0xAA, 0xAA), new Rectangle(100, 100, 500, 500));

            var linkAnnotations = new List<LinkAnnotation>
            {
                linkAnnotation
            };

            var response = api.PostPageLinkAnnotations(Name, pageNumber: 1, links: linkAnnotations, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: PostPageLinkAnnotationsExample
        }


        public void PutLinkAnnotationExample()
        {
             //ExStart: PutLinkAnnotationExample
            var getLinksResponse = api.GetPageLinkAnnotations(Name, 1, folder: FolderName);

            string linkId = getLinksResponse.Links.List[0].Id;

            LinkAnnotation linkAnnotation = new LinkAnnotation(null, LinkActionType.GoToURIAction, "https://products.aspose.cloud/pdf",
                LinkHighlightingMode.Invert, new Color(0xFF, 0xAA, 0xAA, 0xAA), new Rectangle(100, 100, 500, 500));

            var response = api.PutLinkAnnotation(Name, linkId: linkId, link: linkAnnotation, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutLinkAnnotationExample
        }


        public void DeletePageLinkAnnotationsExample()
        {
            //ExStart: DeletePageLinkAnnotationsExample
            var response = api.DeletePageLinkAnnotations(Name, pageNumber: 1, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: DeletePageLinkAnnotationsExample
        }


        public void DeleteDocumentLinkAnnotationsExample()
        {
            //ExStart: DeleteDocumentLinkAnnotationsExample
            var response = api.DeleteDocumentLinkAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: DeleteDocumentLinkAnnotationsExample
        }


        public void GetLinkAnnotationExample()
        {
            //ExStart: GetLinkAnnotationExample
            var getLinksResponse = api.GetPageLinkAnnotations(Name, 1, folder: FolderName);


            string linkId = getLinksResponse.Links.List[0].Id;

            var response = api.GetLinkAnnotation(Name, linkId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetLinkAnnotationExample
        }
    }
}