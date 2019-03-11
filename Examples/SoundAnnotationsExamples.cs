using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
 
    public class SoundAnnotationsTests

    {
        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");

        string FolderName = "";
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }


        private const string AttachmentFile = "4pages.pdf";

        public void GetDocumentSoundAnnotationsTest()
        {
            var response = api.GetDocumentSoundAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageSoundAnnotationsTest()
        {
            var response = api.GetPageSoundAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PostPageSoundAnnotationsTest()
        {
            UploadFile(AttachmentFile, AttachmentFile);
            List<SoundAnnotation> annotations = new List<SoundAnnotation>
            {
                new SoundAnnotation()
                {
                    Name = "Test Sound Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    Modified = "01/01/2018 00:00:00.000 AM",
                    FilePath = Path.Combine(FolderName, AttachmentFile)
                }
            };

            var response = api.PostPageSoundAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetSoundAnnotationTest()
        {
            var annotationresponse = api.GetDocumentSoundAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.GetSoundAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutSoundAnnotationTest()
        {
            SoundAnnotation annotation = new SoundAnnotation()
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
                FilePath = Path.Combine("", AttachmentFile)
            };

            var lineResponse = api.GetDocumentSoundAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutSoundAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetSoundAnnotationDataTest()
        {
            var annotationresponse = api.GetDocumentSoundAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.GetSoundAnnotationData(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutSoundAnnotationDataExtractTest()
        {
            var annotationresponse = api.GetDocumentSoundAnnotations(Name, folder: FolderName);
            string annotationId = annotationresponse.Annotations.List[0].Id;

            var response = api.PutSoundAnnotationDataExtract(Name, annotationId, outFilePath: "outFile.dat", folder: FolderName);
            Console.WriteLine(response);
        }
    }
}