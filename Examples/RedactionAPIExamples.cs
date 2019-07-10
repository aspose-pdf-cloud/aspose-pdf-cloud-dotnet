
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System.IO;
using Aspose.Pdf.Cloud.Sdk.Api;
using System;
namespace Aspose.Pdf.Cloud.Sdk.RedactionAnnotationsAPI
{

    public class RedactionAnnotationsExamples
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";

        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }

        public void GetDocumentRedactionAnnotationsTest()
        {
            var response = api.GetDocumentRedactionAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageRedactionAnnotationsTest()
        {
            var response = api.GetPageRedactionAnnotations(Name, PageNumber, folder: FolderName);
             Console.WriteLine(response);
        }


        public void PostPageRedactionAnnotationsTest()
        {
            List<RedactionAnnotation> annotations = new List<RedactionAnnotation>
            {
                new RedactionAnnotation()
                {
                    Name = "Test Redaction Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    ZIndex = 1,
                    QuadPoint = new List<Point>
                    {
                        new Point(10, 40),
                        new Point(30, 40)
                    },
                    Modified = "01/01/2018 00:00:00.000 AM"
                }
            };

            var response = api.PostPageRedactionAnnotations(Name, 1, annotations, folder: FolderName);
             Console.WriteLine(response);
        }


        public void GetRedactionAnnotationTest()
        {
            var Redactionresponse = api.GetDocumentRedactionAnnotations(Name, folder: FolderName);
            string annotationId = Redactionresponse.Annotations.List[0].Id;

            var response = api.GetRedactionAnnotation(Name, annotationId, folder: FolderName);
             Console.WriteLine(response);
        }


        public void PutRedactionAnnotationTest()
        {
            RedactionAnnotation annotation = new RedactionAnnotation()
            {
                Name = "Updated Test",
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                ZIndex = 1,
                QuadPoint = new List<Point>
                {
                    new Point(10, 20)
                },
                Modified = "01/01/2018 00:00:00.000 AM"
            };

            var lineResponse = api.GetDocumentRedactionAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutRedactionAnnotation(Name, annotationId, annotation, folder: FolderName);
             Console.WriteLine(response);
        }
    }
}