using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
namespace Aspose.Pdf.Cloud.Sdk.StampAnnotationsAPI
{

    public class StampAnnotationsExamples
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


        public void GetDocumentStampAnnotationsExample()
        {
             //ExStart: GetDocumentSquigglyAnnotationsExample
            var response = api.GetDocumentStampAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetDocumentSquigglyAnnotationsExample
        }


        public void GetPageStampAnnotationsExample()
        {
             //ExStart: GetDocumentSquigglyAnnotationsExample
            var response = api.GetPageStampAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetDocumentSquigglyAnnotationsExample
        }


        public void PostPageStampAnnotationsExample()
        {
             //ExStart: GetDocumentSquigglyAnnotationsExample
            UploadFile(AttachmentFile, AttachmentFile);
            List<StampAnnotation> annotations = new List<StampAnnotation>
            {
                new StampAnnotation()
                {
                    Name = "Example Stamp Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    Modified = "01/01/2018 00:00:00.000 AM",
                    FilePath = Path.Combine(FolderName, AttachmentFile),
                }
            };

            var response = api.PostPageStampAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetDocumentSquigglyAnnotationsExample
        }


        public void GetStampAnnotationExample()
        {
             //ExStart: GetDocumentSquigglyAnnotationsExample
            var annotationresponse = api.GetDocumentStampAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.GetStampAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetDocumentSquigglyAnnotationsExample
        }


        public void PutStampAnnotationExample()
        {
             //ExStart: GetDocumentSquigglyAnnotationsExample
            UploadFile(AttachmentFile, AttachmentFile);
            StampAnnotation annotation = new StampAnnotation()
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
            };

            var lineResponse = api.GetDocumentStampAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutStampAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetDocumentSquigglyAnnotationsExample
        }


        public void GetStampAnnotationDataExample()
        {
             //ExStart: GetDocumentSquigglyAnnotationsExample
            var annotationresponse = api.GetDocumentStampAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.GetStampAnnotationData(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetDocumentSquigglyAnnotationsExample
        }


        public void PutStampAnnotationDataExtractExample()
        {
             //ExStart: GetDocumentSquigglyAnnotationsExample
            var annotationresponse = api.GetDocumentStampAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.PutStampAnnotationDataExtract(Name, annotationId, outFilePath: "stamp.dat", folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetDocumentSquigglyAnnotationsExample
        }
    }
}