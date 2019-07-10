
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System;

namespace Aspose.Pdf.Cloud.Sdk.FreeTextAnnotationsAPI
{

    public class FreeTextAnnotationsExamples
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";
        public void PostPageFreeTextAnnotationsTest()
        {
            List<FreeTextAnnotation> annotations = new List<FreeTextAnnotation>
            {
                new FreeTextAnnotation()
                {
                    Name = "Test Free Text",
                    TextStyle = new TextStyle(FontSize: 12, Font: "Arial", ForegroundColor: new Color(0xFF, 0, 0xFF, 0), BackgroundColor: new Color(0xFF, 0xFF, 0, 0)),
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> { AnnotationFlags.Default},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Intent = FreeTextIntent.FreeTextTypeWriter,
                    RichText = "Rich Text",
                    Subject = "Text Box Subj",
                    ZIndex = 1,
                    Justification = Justification.Center,
                    Title = "Title"
                }
            };

            var response = api.PostPageFreeTextAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetDocumentFreeTextAnnotationsTest()
        {
            var response = api.GetDocumentFreeTextAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }

        public void GetPageFreeTextAnnotationsTest()
        {
            var response = api.GetPageFreeTextAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetFreeTextAnnotationTest()
        {
            var freeTextresponse = api.GetDocumentFreeTextAnnotations(Name, folder: FolderName);
            string annotationId = freeTextresponse.Annotations.List[0].Id;

            var response = api.GetFreeTextAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutFreeTextAnnotationTest()
        {
            FreeTextAnnotation annotation = new FreeTextAnnotation()
            {
                Name = "Test Free Text",
                TextStyle = new TextStyle(FontSize: 12, Font: "Arial", ForegroundColor: new Color(0xFF, 0, 0xFF, 0), BackgroundColor: new Color(0xFF, 0xFF, 0, 0)),
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Default },
                HorizontalAlignment = HorizontalAlignment.Center,
                Intent = FreeTextIntent.FreeTextTypeWriter,
                RichText = "Updated Text",
                Subject = "Text Box Subj",
                ZIndex = 1,
                Justification = Justification.Center,
                Title = "Title"
            };

            var freeTextresponse = api.GetDocumentFreeTextAnnotations(Name, folder: FolderName);
            string annotationId = freeTextresponse.Annotations.List[0].Id;

            var response = api.PutFreeTextAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);        
        }
                
    }
}