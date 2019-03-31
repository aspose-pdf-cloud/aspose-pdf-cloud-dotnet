
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
        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
        string FolderName = "";
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;


        public void GetDocumentPopupAnnotationsTest()
        {
            var response = api.GetDocumentPopupAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetDocumentPopupAnnotationsByParentTest()
        {
            const string parentId = "GI5TAOZRGU3CYNZSGEWDCNZWFQ3TGOI";
            var response = api.GetDocumentPopupAnnotationsByParent(Name, parentId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPagePopupAnnotationsTest()
        {
            var response = api.GetPagePopupAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PostPopupAnnotationTest()
        {

            const string parentId = "GI5TCMR3GE2TQLBSGM3CYMJYGUWDENRV";

            PopupAnnotation annotation = new PopupAnnotation()
            {
                Name = "Test Popup Annotation",
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                ZIndex = 1,
                Modified = "01/01/2018 00:00:00.000 AM"
            };

            var response = api.PostPopupAnnotation(Name, parentId, annotation, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPopupAnnotationTest()
        {
            var Popupresponse = api.GetDocumentPopupAnnotations(Name, folder: FolderName);
            string annotationId = Popupresponse.Annotations.List[0].Id;

            var response = api.GetPopupAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutPopupAnnotationTest()
        {
            PopupAnnotation annotation = new PopupAnnotation()
            {
                Name = "Test Popup Annotation Updated",
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
        }
    }
}