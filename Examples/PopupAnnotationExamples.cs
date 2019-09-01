
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System;
using System.IO;

namespace Aspose.Pdf.Cloud.Sdk.PopupAnnotationsAPI
{
    public class PopupAnnotationsExamples
    {
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;


        public void GetDocumentPopupAnnotationsExample()
        {
            //ExStart: GetDocumentPopupAnnotationsExample
            var response = api.GetDocumentPopupAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentPopupAnnotationsExample
        }


        public void GetDocumentPopupAnnotationsByParentExample()
        {
            //ExStart: GetDocumentPopupAnnotationsByParentExample
            const string parentId = "GI5TAOZRGU3CYNZSGEWDCNZWFQ3TGOI";
            var response = api.GetDocumentPopupAnnotationsByParent(Name, parentId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentPopupAnnotationsByParentExample
        }


        public void GetPagePopupAnnotationsExample()
        {
            //ExStart: GetPagePopupAnnotationsExample
            var response = api.GetPagePopupAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPagePopupAnnotationsExample
        }


        public void PostPopupAnnotationExample()
        {
            //ExStart: PostPopupAnnotationExample
            const string parentId = "GI5TCMR3GE2TQLBSGM3CYMJYGUWDENRV";

            PopupAnnotation annotation = new PopupAnnotation()
            {
                Name = "Example Popup Annotation",
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                ZIndex = 1,
                Modified = "01/01/2018 00:00:00.000 AM"
            };

            var response = api.PostPopupAnnotation(Name, parentId, annotation, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PostPopupAnnotationExample
        }


        public void GetPopupAnnotationExample()
        {
            //ExStart: GetPopupAnnotationExample
            var Popupresponse = api.GetDocumentPopupAnnotations(Name, folder: FolderName);
            string annotationId = Popupresponse.Annotations.List[0].Id;

            var response = api.GetPopupAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPopupAnnotationExample
        }

        public void PutPopupAnnotationExample()
        {
            //ExStart: PutPopupAnnotationExample
            PopupAnnotation annotation = new PopupAnnotation()
            {
                Name = "Example Popup Annotation Updated",
                Rect = new Rectangle(101, 101, 201, 201),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                ZIndex = 1,
                Modified = "02/02/2018 00:00:00.000 AM"
            };

            var lineResponse = api.GetDocumentPopupAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutPopupAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPopupAnnotationExample
        }
    }
}