
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;


namespace Aspose.Pdf.Cloud.Sdk.PolyLineAnnotationsAPI
{
    public class PolyLineAnnotationsExamples
    {
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;


        public void GetDocumentPolyLineAnnotationsTest()
        {
            var response = api.GetDocumentPolyLineAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPagePolyLineAnnotationsTest()
        {
            var response = api.GetPagePolyLineAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PostPagePolyLineAnnotationsTest()
        {
            List<PolyLineAnnotation> annotations = new List<PolyLineAnnotation>
            {
                new PolyLineAnnotation()
                {
                    Name = "Test PolyLine Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    Vertices = new List<Point>
                    {
                        new Point(10, 10),
                        new Point(20, 10),
                        new Point(10, 20),
                        new Point(10, 10)
                    }
                }
            };

            var response = api.PostPagePolyLineAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
        }

        public void GetPolyLineAnnotationTest()
        {
            var polyLineResponse = api.GetDocumentPolyLineAnnotations(Name, folder: FolderName);
            string annotationId = polyLineResponse.Annotations.List[0].Id;

            var response = api.GetPolyLineAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPolyLineAnnotationTest()
        {
            PolyLineAnnotation annotation = new PolyLineAnnotation()
            {
                Name = "Updated Test",
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated",
                Vertices = new List<Point>
                {
                    new Point(10, 10),
                    new Point(20, 10),
                    new Point(10, 20),
                    new Point(10, 10)
                }
            };

            var lineResponse = api.GetDocumentPolyLineAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutPolyLineAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}