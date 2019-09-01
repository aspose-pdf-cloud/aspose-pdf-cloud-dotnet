using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;

namespace Aspose.Pdf.Cloud.Sdk.Example
{

    public class SquigglyAnnotationsExamples
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");

        string FolderName = "";


        public void GetDocumentSquigglyAnnotationsExample()
        {
            //ExStart: GetDocumentSquigglyAnnotationsExample
            var response = api.GetDocumentSquigglyAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentSquigglyAnnotationsExample
        }


        public void GetPageSquigglyAnnotationsExample()
        {
            //ExStart: GetPageSquigglyAnnotationsExample
            var response = api.GetPageSquigglyAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageSquigglyAnnotationsExample
        }


        public void PostPageSquigglyAnnotationsExample()
        {
            //ExStart: PostPageSquigglyAnnotationsExample
            List<SquigglyAnnotation> annotations = new List<SquigglyAnnotation>
            {
                new SquigglyAnnotation()
                {
                    Name = "Example Squiggly Annotation",
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

            var response = api.PostPageSquigglyAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PostPageSquigglyAnnotationsExample
        }


        public void GetSquigglyAnnotationExample()
        {
            //ExStart: GetSquigglyAnnotationExample
            var Squigglyresponse = api.GetDocumentSquigglyAnnotations(Name, folder: FolderName);
            string annotationId = Squigglyresponse.Annotations.List[0].Id;

            var response = api.GetSquigglyAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetSquigglyAnnotationExample
        }


        public void PutSquigglyAnnotationExample()
        {
            //ExStart: PutSquigglyAnnotationExample
            SquigglyAnnotation annotation = new SquigglyAnnotation()
            {
                Name = "Example Squiggly Annotation Updated",
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

            var lineResponse = api.GetDocumentSquigglyAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutSquigglyAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutSquigglyAnnotationExample
        }
    }
}
