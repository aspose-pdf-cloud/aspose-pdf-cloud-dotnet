using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System.IO;

namespace Aspose.Pdf.Cloud.Sdk.Examples
{

    public class CaretAnnotationsExamples
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

        public void GetDocumentCaretAnnotationsExample()
        {
             //ExStart: GetDocumentCaretAnnotationsExample
            UploadFile(Name, Name);
            var response = api.GetDocumentCaretAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentCaretAnnotationsExample

        }

        public void GetPageCaretAnnotationsExample()
        {
             //ExStart: GetPageCaretAnnotationsExample
            UploadFile(Name, Name);
            var response = api.GetPageCaretAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetPageCaretAnnotationsExample
        }


        public void PostPageCaretAnnotationsExample()
        {
             //ExStart: PostPageCaretAnnotationsExample
            UploadFile(Name, Name);
            List<CaretAnnotation> annotations = new List<CaretAnnotation>
            {
                new CaretAnnotation()
                {
                    Name = "Example Caret Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    Frame = new Rectangle(100, 100, 200, 200),
                    Modified = "01/01/2018 00:00:00.000 AM"
                }
            };

            var response = api.PostPageCaretAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PostPageCaretAnnotationsExample

        }


        public void GetCaretAnnotationExample()
        {
             //ExStart: GetCaretAnnotationExample
            UploadFile(Name, Name);
            var Caretresponse = api.GetDocumentCaretAnnotations(Name, folder: FolderName);
            string annotationId = Caretresponse.Annotations.List[0].Id;

            var response = api.GetCaretAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
                         //ExEnd: GetCaretAnnotationExample

        }


        public void PutCaretAnnotationExample()
        {
             //ExStart: PutCaretAnnotationExample
            UploadFile(Name, Name);
            CaretAnnotation annotation = new CaretAnnotation()
            {
                Name = "Example Caret Annotation Updated",
                Rect = new Rectangle(101, 101, 201, 201),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated",
                Frame = new Rectangle(100, 100, 200, 200),
                Modified = "02/02/2018 00:00:00.000 AM"
            };

            var lineResponse = api.GetDocumentCaretAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutCaretAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
                         //ExEnd: PutCaretAnnotationExample

        }
    }
}