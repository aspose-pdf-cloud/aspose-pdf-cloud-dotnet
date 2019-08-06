
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System;

namespace Aspose.Pdf.Cloud.Sdk.HighlightAnnotationsAPI
{

    public class HighlightAnnotationsExamples
    {
        
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public void GetDocumentHighlightAnnotationsTest()
        {
            var response = api.GetDocumentHighlightAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageHighlightAnnotationsTest()
        {
            var response = api.GetPageHighlightAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PostPageHighlightAnnotationsTest()
        {
            List<HighlightAnnotation> annotations = new List<HighlightAnnotation>
            {
                new HighlightAnnotation()
                {
                    Name = "Test Highlight Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    QuadPoints = new List<Point>
                    {
                        new Point(10, 10),
                        new Point(20, 10),
                        new Point(10, 20),
                        new Point(10, 10)
                    },
                    Modified = "01/01/2018 00:00:00.000 AM"
                }
            };

            var response = api.PostPageHighlightAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
        }

        public void GetHighlightAnnotationTest()
        {
            var Highlightresponse = api.GetDocumentHighlightAnnotations(Name, folder: FolderName);
            string annotationId = Highlightresponse.Annotations.List[0].Id;

            var response = api.GetHighlightAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutHighlightAnnotationTest()
        {
            HighlightAnnotation annotation = new HighlightAnnotation()
            {
                Name = "Test Highlight Annotation Updated",
                Rect = new Rectangle(101, 101, 201, 201),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated",
                QuadPoints = new List<Point>
                {
                    new Point(11, 11),
                    new Point(21, 11),
                    new Point(11, 21),
                    new Point(11, 11)
                },
                Modified = "02/02/2018 00:00:00.000 AM"
            };

            var lineResponse = api.GetDocumentHighlightAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutHighlightAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}
