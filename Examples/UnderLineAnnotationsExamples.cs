using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.IO;
using System;


namespace Aspose.Pdf.Cloud.Sdk.Test
{

    public class UnderlineAnnotationsExamples
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


        public void GetDocumentUnderlineAnnotationsTest()
        {
            var response = api.GetDocumentUnderlineAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }

        public void GetPageUnderlineAnnotationsTest()
        {
            var response = api.GetPageUnderlineAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PostPageUnderlineAnnotationsTest()
        {
            List<UnderlineAnnotation> annotations = new List<UnderlineAnnotation>
            {
                new UnderlineAnnotation()
                {
                    Name = "Test Underline Annotation",
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

            var response = api.PostPageUnderlineAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
        }

 
        public void GetUnderlineAnnotationTest()
        {
            var Underlineresponse = api.GetDocumentUnderlineAnnotations(Name, folder: FolderName);
            string annotationId = Underlineresponse.Annotations.List[0].Id;

            var response = api.GetUnderlineAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutUnderlineAnnotationTest()
        {
            UnderlineAnnotation annotation = new UnderlineAnnotation()
            {
                Name = "Test Underline Annotation Updated",
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

            var lineResponse = api.GetDocumentUnderlineAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutUnderlineAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}
