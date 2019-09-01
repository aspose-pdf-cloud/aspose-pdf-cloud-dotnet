
using System.Collections.Generic;
using System.Net;
using System;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.IO;

namespace Aspose.Pdf.Cloud.Sdk.MovieAnnotationsAPI
{

    public class MovieAnnotationsExamples
    {
        private const string Name = "PdfWithAnnotations1.pdf";
        private const int PageNumber = 2;
        private const string AttachmentFile = "4pages.pdf";


        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";


        public void GetDocumentMovieAnnotationsExample()
        {
            //ExStart: GetDocumentMovieAnnotationsExample
            var response = api.GetDocumentMovieAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetDocumentMovieAnnotationsExample
        }


        public void GetPageMovieAnnotationsExample()
        {
            //ExStart: GetPageMovieAnnotationsExample
            var response = api.GetPageMovieAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageMovieAnnotationsExample
        }

        public void PostPageMovieAnnotationsExample()
        {
            //ExStart: PostPageMovieAnnotationsExample
            UploadFile(AttachmentFile, AttachmentFile);
            List<MovieAnnotation> annotations = new List<MovieAnnotation>
            {
                new MovieAnnotation()
                {
                    Name = "Example Movie Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    ZIndex = 1,
                    FilePath = AttachmentFile,
                    Modified = "01/01/2018 00:00:00.000 AM"
                }
            };

            var response = api.PostPageMovieAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PostPageMovieAnnotationsExample
        }

        public void GetMovieAnnotationExample()
        {
            //ExStart: GetMovieAnnotationExample
            var Movieresponse = api.GetDocumentMovieAnnotations(Name, folder: FolderName);
            string annotationId = Movieresponse.Annotations.List[0].Id;

            var response = api.GetMovieAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetMovieAnnotationExample
        }


        public void PutMovieAnnotationExample()
        {
             //ExStart: PutMovieAnnotationExample
            UploadFile(AttachmentFile, AttachmentFile);
            MovieAnnotation annotation = new MovieAnnotation()
            {
                Name = "Updated Example",
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                ZIndex = 1,
                FilePath = AttachmentFile,
                Modified = "01/01/2018 00:00:00.000 AM"
            };

            var lineResponse = api.GetDocumentMovieAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutMovieAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: PutMovieAnnotationExample
            
        }
    }
}