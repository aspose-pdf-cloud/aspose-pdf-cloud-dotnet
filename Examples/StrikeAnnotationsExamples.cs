using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.IO;

namespace Aspose.Pdf.Cloud.Sdk.StrikeOutAnnotationsAPI
{

    public class StrikeOutAnnotationsExamples
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;
        private const string AttachmentFile = "4pages.pdf";

        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";

        
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }


        public void GetDocumentStrikeOutAnnotationsExample()
        {
            //ExStart: GetDocumentStrikeOutAnnotationsExample
            var response = api.GetDocumentStrikeOutAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentStrikeOutAnnotationsExample
           
        }


        public void GetPageStrikeOutAnnotationsExample()
        {
            //ExStart: GetPageStrikeOutAnnotationsExample
            var response = api.GetPageStrikeOutAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageStrikeOutAnnotationsExample
        }


        public void PostPageStrikeOutAnnotationsExample()
        {
            //ExStart: PostPageStrikeOutAnnotationsExample
            List<StrikeOutAnnotation> annotations = new List<StrikeOutAnnotation>
            {
                new StrikeOutAnnotation()
                {
                    Name = "Example StrikeOut Annotation",
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

            var response = api.PostPageStrikeOutAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PostPageStrikeOutAnnotationsExample
        }


        public void GetStrikeOutAnnotationExample()
        {
            //ExStart: GetStrikeOutAnnotationExample
            var StrikeOutresponse = api.GetDocumentStrikeOutAnnotations(Name, folder: FolderName);
            string annotationId = StrikeOutresponse.Annotations.List[0].Id;

            var response = api.GetStrikeOutAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetStrikeOutAnnotationExample
        }


        public void PutStrikeOutAnnotationExample()
        {
            //ExStart: PutStrikeOutAnnotationExample
            StrikeOutAnnotation annotation = new StrikeOutAnnotation()
            {
                Name = "Example StrikeOut Annotation Updated",
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

            var lineResponse = api.GetDocumentStrikeOutAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutStrikeOutAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutStrikeOutAnnotationExample
        }
    }
}
