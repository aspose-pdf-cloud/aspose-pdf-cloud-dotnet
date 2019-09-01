using System.Collections.Generic;
using System.IO;
using System;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;

namespace Aspose.Pdf.Cloud.Sdk.FileAttachementAPI
{

    public class FileAttachmentAnnotationsExamples
    {
        
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;
        private const string AttachmentFile = "4pages.pdf";

        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }


        public void GetDocumentFileAttachmentAnnotationsExample()
        {
            //ExStart: GetDocumentFileAttachmentAnnotationsExample
            var response = api.GetDocumentFileAttachmentAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentFileAttachmentAnnotationsExample
        }


        public void GetPageFileAttachmentAnnotationsExample()
        {
            //ExStart: GetPageFileAttachmentAnnotationsExample
            var response = api.GetPageFileAttachmentAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageFileAttachmentAnnotationsExample
        }


        public void PostPageFileAttachmentAnnotationsExample()
        {
            //ExStart: PostPageFileAttachmentAnnotationsExample
            UploadFile(AttachmentFile, AttachmentFile);
            List<FileAttachmentAnnotation> annotations = new List<FileAttachmentAnnotation>
            {
                new FileAttachmentAnnotation()
                {
                    Name = "Example FileAttachmrizontalAlignment.Center",
                    RichText = "Rich Texent Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment =  HorizontalAlignment.Center,
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    Modified = "01/01/2018 00:00:00.000 AM",
                    FilePath = Path.Combine(FolderName, AttachmentFile),
                    FileName = AttachmentFile
                }
            };

            var response = api.PostPageFileAttachmentAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PostPageFileAttachmentAnnotationsExample
        }

        public void GetFileAttachmentAnnotationExample()
        {
            //ExStart: GetFileAttachmentAnnotationExample
            var annotationresponse = api.GetDocumentFileAttachmentAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.GetFileAttachmentAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetFileAttachmentAnnotationExample
        }

        public void PutFileAttachmentAnnotationExample()
        {
            //ExStart: PutFileAttachmentAnnotationExample
            UploadFile(AttachmentFile, AttachmentFile);
            FileAttachmentAnnotation annotation = new FileAttachmentAnnotation()
            {
                Name = "Updated Example",
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated",
                Modified = "01/01/2018 00:00:00.000 AM",
                FilePath = Path.Combine(FolderName, AttachmentFile),
                FileName = AttachmentFile
            };

            var lineResponse = api.GetDocumentFileAttachmentAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutFileAttachmentAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutFileAttachmentAnnotationExample
        }

        public void GetFileAttachmentAnnotationDataExample()
        {
            //ExStart: GetFileAttachmentAnnotationDataExample
            var annotationresponse = api.GetDocumentFileAttachmentAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.GetFileAttachmentAnnotationData(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetFileAttachmentAnnotationDataExample
        }

        public void PutFileAttachmentAnnotationDataExtractExample()
        {
            //ExStart: PutFileAttachmentAnnotationDataExtractExample
            var annotationresponse = api.GetDocumentFileAttachmentAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.PutFileAttachmentAnnotationDataExtract(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutFileAttachmentAnnotationDataExtractExample
        }
    }
}