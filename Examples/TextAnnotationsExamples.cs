using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.IO;
using System;

namespace Aspose.Pdf.Cloud.Sdk.TextAnnotationsAPI
{

    public class TextAnnotationsExamples
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;


        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
        string FolderName = "";

        
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }


        public void GetDocumentTextAnnotationsTest()
        {
            var response = api.GetDocumentTextAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }



        public void GetPageTextAnnotationsTest()
        {
            var response = api.GetPageTextAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }



        public void PostPageTextAnnotationsTest()
        {
            List<TextAnnotation> annotations = new List<TextAnnotation>
            {
                new TextAnnotation()
                {
                    Name = "Test Free Text",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> { AnnotationFlags.Default},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Text Box Subj",
                    ZIndex = 1,
                    Title = "Title"
                }
            };

            var response = api.PostPageTextAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetTextAnnotationTest()
        {
            var textresponse = api.GetDocumentTextAnnotations(Name, folder: FolderName);
            string annotationId = textresponse.Annotations.List[0].Id;

            var response = api.GetTextAnnotation(Name, annotationId, folder: FolderName);
             Console.WriteLine(response);
        }



        public void PutTextAnnotationTest()
        {
            TextAnnotation annotation = new TextAnnotation()
            {
                Name = "Test Free Text",
                Rect = new Rectangle(100, 100, 200, 200),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Default },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Updated Text",
                Subject = "Text Box Subj",
                ZIndex = 1,
                Title = "Title"
            };

            var textresponse = api.GetDocumentTextAnnotations(Name, folder: FolderName);
            string annotationId = textresponse.Annotations.List[0].Id;

            var response = api.PutTextAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}