
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System.IO;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;


namespace Aspose.Pdf.Cloud.Sdk.LineAnnotationsAPI
{

    public class LineAnnotationsExamples
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
        string FolderName = "";

        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }
        

        public void GetDocumentLineAnnotationsTest()
        {
            var response = api.GetDocumentLineAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageLineAnnotationsTest()
        {
            var response = api.GetPageLineAnnotations(Name, 1, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PostPageLineAnnotationsTest()
        {
            List<LineAnnotation> annotations = new List<LineAnnotation>
            {
                new LineAnnotation()
                {
                    Name = "Test Line Annotation",
                    Rect = new Rectangle(100, 100, 300, 300),
                    Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    ShowCaption = true,
                    Title = "Title",
                    Starting = new Point(10, 10),
                    Ending = new Point(100, 100),
                    Color = new Color(0x99, 0xFF, 0, 0)
                }
            };

            var response = api.PostPageLineAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
        }
        

        public void GetLineAnnotationTest()
        {
            var lineresponse = api.GetDocumentLineAnnotations(Name, folder: FolderName);
            string annotationId = lineresponse.Annotations.List[0].Id;

            var response = api.GetLineAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutLineAnnotationTest()
        {
            LineAnnotation annotation = new LineAnnotation()
            {
                Name = "Test Line Annotation",
                Rect = new Rectangle(100, 100, 300, 300),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Updated Rich Text",
                Subject = "Subj",
                ZIndex = 1,
                ShowCaption = true,
                Title = "Title Updated",
                Starting = new Point(10, 10),
                Ending = new Point(100, 100)
            };

            var lineResponse = api.GetDocumentLineAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutLineAnnotation(Name, annotationId, annotation, folder: FolderName);
           Console.WriteLine(response);
        }
    }
}