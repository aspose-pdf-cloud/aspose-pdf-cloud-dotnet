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
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }


        public void GetDocumentFileAttachmentAnnotationsTest()
        {
            var response = api.GetDocumentFileAttachmentAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageFileAttachmentAnnotationsTest()
        {
            var response = api.GetPageFileAttachmentAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PostPageFileAttachmentAnnotationsTest()
        {
            UploadFile(AttachmentFile, AttachmentFile);
            List<FileAttachmentAnnotation> annotations = new List<FileAttachmentAnnotation>
            {
                new FileAttachmentAnnotation()
                {
                    Name = "Test FileAttachmrizontalAlignment.Center",
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
        }

        public void GetFileAttachmentAnnotationTest()
        {
            var annotationresponse = api.GetDocumentFileAttachmentAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.GetFileAttachmentAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutFileAttachmentAnnotationTest()
        {
            UploadFile(AttachmentFile, AttachmentFile);
            FileAttachmentAnnotation annotation = new FileAttachmentAnnotation()
            {
                Name = "Updated Test",
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
        }

        public void GetFileAttachmentAnnotationDataTest()
        {
            var annotationresponse = api.GetDocumentFileAttachmentAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.GetFileAttachmentAnnotationData(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutFileAttachmentAnnotationDataExtractTest()
        {
            var annotationresponse = api.GetDocumentFileAttachmentAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.PutFileAttachmentAnnotationDataExtract(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}