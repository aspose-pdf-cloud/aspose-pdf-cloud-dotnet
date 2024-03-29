using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System.IO;



namespace Aspose.Pdf.Cloud.Sdk.Example
{

    public class CircleAnnotationsExamples 
    {
        
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");

        string FolderName = "";
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }
 
        public void GetDocumentCircleAnnotationsExample()
        {
            //ExStart: GetDocumentCircleAnnotationsExample
            var response = api.GetDocumentCircleAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentCircleAnnotationsExample

        }

        public void GetPageCircleAnnotationsExample()
        {
             //ExStart: GetPageCircleAnnotationsExample
            var response = api.GetPageCircleAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageCircleAnnotationsExample

        }


        public void PostPageCircleAnnotationsExample()
        {
             //ExStart: PostPageCircleAnnotationsExample
            List<CircleAnnotation> annotations = new List<CircleAnnotation>
            {
                new CircleAnnotation()
                {
                    Name = "Example Circle Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title"
                }
            };

            var response = api.PostPageCircleAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
                         //ExStart: PostPageCircleAnnotationsExample

        }


        public void GetCircleAnnotationExample()
        {
             //ExStart: GetCircleAnnotationExample
            var circleresponse = api.GetDocumentCircleAnnotations(Name, folder: FolderName);
            string annotationId = circleresponse.Annotations.List[0].Id;

            var response = api.GetCircleAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetCircleAnnotationExample

        }


        public void PutCircleAnnotationExample()
        {
             //ExStart: PutCircleAnnotationExample
            CircleAnnotation annotation = new CircleAnnotation()
            {
                Name = "Updated Example",
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated"
            };

            var lineResponse = api.GetDocumentCircleAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutCircleAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutCircleAnnotationExample

        }
    }
}