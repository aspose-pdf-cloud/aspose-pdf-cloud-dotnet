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

        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
        string FolderName = "";

        
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }


        public void GetDocumentStampAnnotationsTest()
        {
            var response = api.GetDocumentStampAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageStampAnnotationsTest()
        {
            var response = api.GetPageStampAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PostPageStampAnnotationsTest()
        {
            UploadFile(AttachmentFile, AttachmentFile);
            List<StampAnnotation> annotations = new List<StampAnnotation>
            {
                new StampAnnotation()
                {
                    Name = "Test Stamp Annotation",
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
        }


        public void GetStampAnnotationTest()
        {
            var annotationresponse = api.GetDocumentStampAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.GetStampAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutStampAnnotationTest()
        {
            UploadFile(AttachmentFile, AttachmentFile);
            StampAnnotation annotation = new StampAnnotation()
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
            };

            var lineResponse = api.GetDocumentStampAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutStampAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetStampAnnotationDataTest()
        {
            var annotationresponse = api.GetDocumentStampAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.GetStampAnnotationData(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutStampAnnotationDataExtractTest()
        {
            var annotationresponse = api.GetDocumentStampAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.PutStampAnnotationDataExtract(Name, annotationId, outFilePath: "stamp.dat", folder: FolderName);
            Console.WriteLine(response);
        }
    }
}