using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;

namespace Aspose.Pdf.Cloud.Sdk.SquareAnnotationsAPI
{


    public class SquareAnnotationsExamples
    {
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");

        string FolderName = "";
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public void GetDocumentSquareAnnotationsExample()
        {
            //ExStart: GetDocumentSquareAnnotationsExample
            var response = api.GetDocumentSquareAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentSquareAnnotationsExample
        }


        public void GetPageSquareAnnotationsExample()
        {
            //ExStart: GetPageSquareAnnotationsExample
            var response = api.GetPageSquareAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageSquareAnnotationsExample
        }

        public void PostPageSquareAnnotationsExample()
        {
            //ExStart: PostPageSquareAnnotationsExample
            List<SquareAnnotation> annotations = new List<SquareAnnotation>
            {
                new SquareAnnotation()
                {
                    Name = "Example Square Annotation",
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
            //ExEnd: PostPageSquareAnnotationsExample
        }


        public void GetSquareAnnotationExample()
        {
            //ExStart: GetSquareAnnotationExample
            var squareresponse = api.GetDocumentSquareAnnotations(Name, folder: FolderName);
            string annotationId = squareresponse.Annotations.List[0].Id;

            var response = api.GetSquareAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetSquareAnnotationExample
        }

        public void PutSquareAnnotationExample()
        {
            //ExStart: PutSquareAnnotationExample
            SquareAnnotation annotation = new SquareAnnotation()
            {
                Name = "Updated Example",
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
            //ExEnd: PutSquareAnnotationExample
        }
    }
}