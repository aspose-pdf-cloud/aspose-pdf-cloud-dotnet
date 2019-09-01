
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System;
using System.IO;
namespace Aspose.Pdf.Cloud.Sdk.PolygonAnnotationsAPI
{

    public class PolygonAnnotationsExamples
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

        public void GetDocumentPolygonAnnotationsExample()
        {
            //ExStart: GetDocumentPolygonAnnotationsExample
            var response = api.GetDocumentPolygonAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentPolygonAnnotationsExample

        }


        public void GetPagePolygonAnnotationsExample()
        {
            //ExStart: GetPagePolygonAnnotationsExample
            var response = api.GetPagePolygonAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPagePolygonAnnotationsExample

        }


        public void PostPagePolygonAnnotationsExample()
        {
            //ExStart: PostPagePolygonAnnotationsExample
            List<PolygonAnnotation> annotations = new List<PolygonAnnotation>
            {
                new PolygonAnnotation()
                {
                    Name = "Example Polygon Annotation",
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

            var response = api.PostPagePolygonAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PostPagePolygonAnnotationsExample

        }


        public void GetPolygonAnnotationExample()
        {
            //ExStart: GetPolygonAnnotationExample
            var polygonresponse = api.GetDocumentPolygonAnnotations(Name, folder: FolderName);
            string annotationId = polygonresponse.Annotations.List[0].Id;

            var response = api.GetPolygonAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPolygonAnnotationExample

        }


        public void PutPolygonAnnotationExample()
        {
            //ExStart: PutPolygonAnnotationExample
            PolygonAnnotation annotation = new PolygonAnnotation()
            {
                Name = "Updated Example",
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

            var lineResponse = api.GetDocumentPolygonAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutPolygonAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPolygonAnnotationExample

        }
    }
}