
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;

using Aspose.Pdf.Cloud.Sdk.Api;
using System;
using System.IO;

namespace Aspose.Pdf.Cloud.Sdk.InkAnnotationsAPI
{
    public class InkAnnotationsExamples
    {        
        
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        public void GetDocumentInkAnnotationsExample()
        {
            //ExStart: GetDocumentInkAnnotationsExample
            var response = api.GetDocumentInkAnnotations(Name, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: GetDocumentInkAnnotationsExample
             
        }


        public void GetPageInkAnnotationsExample()
        {
            //ExStart: GetPageInkAnnotationsExample
            var response = api.GetPageInkAnnotations(Name, PageNumber, folder: FolderName);
             Console.WriteLine(response);
            //ExEnd: GetPageInkAnnotationsExample
        }


        public void PostPageInkAnnotationsExample()
        {
            //ExStart: PostPageInkAnnotationsExample
            List<InkAnnotation> annotations = new List<InkAnnotation>
            {
                new InkAnnotation()
                {
                    Name = "Example Ink Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    InkList = new List<List<Point>>
                    {
                        new List<Point>
                        {
                            new Point(10, 40),
                            new Point(30, 40)
                        },
                        new List<Point>
                        {
                            new Point(10, 20),
                            new Point(20, 20),
                            new Point(30, 20)
                        }
                    },
                    CapStyle = CapStyle.Rounded,
                    Modified = "01/01/2018 00:00:00.000 AM"
                }
            };

            var response = api.PostPageInkAnnotations(Name, 1, annotations, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: PostPageInkAnnotationsExample
        }

        public void GetInkAnnotationExample()
        {
            //ExStart: GetInkAnnotationExample
            var Inkresponse = api.GetDocumentInkAnnotations(Name, folder: FolderName);
            string annotationId = Inkresponse.Annotations.List[0].Id;

            var response = api.GetInkAnnotation(Name, annotationId, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: GetInkAnnotationExample
        }


        public void PutInkAnnotationExample()
        {
            //ExStart: PutInkAnnotationExample
            InkAnnotation annotation = new InkAnnotation()
            {
                Name = "Example Ink Annotation Updated",
                Rect = new Rectangle(101, 101, 201, 201),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated",
                InkList = new List<List<Point>>
                {
                    new List<Point>
                    {
                        new Point(10, 40),
                        new Point(30, 40)
                    },
                    new List<Point>
                    {
                        new Point(10, 20),
                        new Point(20, 20),
                        new Point(30, 20)
                    }
                },
                CapStyle = CapStyle.Rounded,
                Modified = "02/02/2018 00:00:00.000 AM"
            };

            var lineResponse = api.GetDocumentInkAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutInkAnnotation(Name, annotationId, annotation, folder: FolderName);
             Console.WriteLine(response);
            //ExEnd: PutInkAnnotationExample
        }
    }
}
