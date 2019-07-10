
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;

using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System;

namespace Aspose.Pdf.Cloud.Sdk.Test
{

    public class LinkAnnotationsTests
    {
        private const string Name = "PdfWithLinks.pdf";
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";


        public void GetPageLinkAnnotationTest()
        {
            var getLinksResponse = api.GetPageLinkAnnotations(Name, 1, folder: FolderName);

            string linkId = getLinksResponse.Links.List[0].Id;

            var response = api.GetPageLinkAnnotation(Name, pageNumber: 1, linkId: linkId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void DeleteLinkAnnotationTest()
        {
            var getLinksResponse = api.GetPageLinkAnnotations(Name, 1, folder: FolderName);

            string linkId = getLinksResponse.Links.List[0].Id;

            var response = api.DeleteLinkAnnotation(Name, linkId: linkId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageLinkAnnotationsTest()
        {
            var response = api.GetPageLinkAnnotations(Name, 1, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PostPageLinkAnnotationsTest()
        {
            LinkAnnotation linkAnnotation = new LinkAnnotation(null, LinkActionType.GoToURIAction, "https://products.aspose.cloud/pdf",
                LinkHighlightingMode.Invert, new Color(0xFF, 0xAA, 0xAA, 0xAA), new Rectangle(100, 100, 500, 500));

            var linkAnnotations = new List<LinkAnnotation>
            {
                linkAnnotation
            };

            var response = api.PostPageLinkAnnotations(Name, pageNumber: 1, links: linkAnnotations, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutLinkAnnotationTest()
        {
            var getLinksResponse = api.GetPageLinkAnnotations(Name, 1, folder: FolderName);

            string linkId = getLinksResponse.Links.List[0].Id;

            LinkAnnotation linkAnnotation = new LinkAnnotation(null, LinkActionType.GoToURIAction, "https://products.aspose.cloud/pdf",
                LinkHighlightingMode.Invert, new Color(0xFF, 0xAA, 0xAA, 0xAA), new Rectangle(100, 100, 500, 500));

            var response = api.PutLinkAnnotation(Name, linkId: linkId, link: linkAnnotation, folder: FolderName);
            Console.WriteLine(response);
        }


        public void DeletePageLinkAnnotationsTest()
        {
            var response = api.DeletePageLinkAnnotations(Name, pageNumber: 1, folder: FolderName);
            Console.WriteLine(response);
        }


        public void DeleteDocumentLinkAnnotationsTest()
        {
            var response = api.DeleteDocumentLinkAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetLinkAnnotationTest()
        {
            var getLinksResponse = api.GetPageLinkAnnotations(Name, 1, folder: FolderName);


            string linkId = getLinksResponse.Links.List[0].Id;

            var response = api.GetLinkAnnotation(Name, linkId, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}