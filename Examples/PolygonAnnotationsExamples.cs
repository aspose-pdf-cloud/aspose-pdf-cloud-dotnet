
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
        
       PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
        string FolderName = ""; 
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }

        public void GetDocumentPolygonAnnotationsTest()
        {
            var response = api.GetDocumentPolygonAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);

        }


        public void GetPagePolygonAnnotationsTest()
        {
            var response = api.GetPagePolygonAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);

        }


        public void PostPagePolygonAnnotationsTest()
        {
            List<PolygonAnnotation> annotations = new List<PolygonAnnotation>
            {
                new PolygonAnnotation()
                {
                    Name = "Test Polygon Annotation",
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

        }


        public void GetPolygonAnnotationTest()
        {
            var polygonresponse = api.GetDocumentPolygonAnnotations(Name, folder: FolderName);
            string annotationId = polygonresponse.Annotations.List[0].Id;

            var response = api.GetPolygonAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);

        }


        public void PutPolygonAnnotationTest()
        {
            PolygonAnnotation annotation = new PolygonAnnotation()
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

            var lineResponse = api.GetDocumentPolygonAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutPolygonAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);

        }
    }
}