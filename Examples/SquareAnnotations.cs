using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;

namespace Aspose.Pdf.Cloud.Sdk.SquareAnnotationsAPI
{


    public class SquareAnnotationsExamples
    {
        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");

        string FolderName = "";
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public void GetDocumentSquareAnnotationsTest()
        {
            var response = api.GetDocumentSquareAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageSquareAnnotationsTest()
        {
            var response = api.GetPageSquareAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PostPageSquareAnnotationsTest()
        {
            List<SquareAnnotation> annotations = new List<SquareAnnotation>
            {
                new SquareAnnotation()
                {
                    Name = "Test Square Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title"
                }
            };

            var response = api.PostPageSquareAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetSquareAnnotationTest()
        {
            var squareresponse = api.GetDocumentSquareAnnotations(Name, folder: FolderName);
            string annotationId = squareresponse.Annotations.List[0].Id;

            var response = api.GetSquareAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutSquareAnnotationTest()
        {
            SquareAnnotation annotation = new SquareAnnotation()
            {
                Name = "Updated Test",
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated"
            };

            var lineResponse = api.GetDocumentSquareAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutSquareAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}