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


        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";

        
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }


        public void GetDocumentTextAnnotationsExample()
        {
             //ExStart: GetDocumentTextAnnotationsExample
            var response = api.GetDocumentTextAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetDocumentTextAnnotationsExample
        }



        public void GetPageTextAnnotationsExample()
        {
             //ExStart: GetPageTextAnnotationsExample
            var response = api.GetPageTextAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: GetPageTextAnnotationsExample
        }



        public void PostPageTextAnnotationsExample()
        {
             //ExStart: PostPageTextAnnotationsExample
            List<TextAnnotation> annotations = new List<TextAnnotation>
            {
                new TextAnnotation()
                {
                    Name = "Example Free Text",
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
             //v: PostPageTextAnnotationsExample
        }


        public void GetTextAnnotationExample()
        {
             //ExStart: GetTextAnnotationExample
            var textresponse = api.GetDocumentTextAnnotations(Name, folder: FolderName);
            string annotationId = textresponse.Annotations.List[0].Id;

            var response = api.GetTextAnnotation(Name, annotationId, folder: FolderName);
             Console.WriteLine(response);
              //ExEnd: DeletePageTaGetTextAnnotationExampleblesExample
        }



        public void PutTextAnnotationExample()
        {
             //ExStart: DeletePageTablesExample
            TextAnnotation annotation = new TextAnnotation()
            {
                Name = "Example Free Text",
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
             //ExEnd: DeletePageTablesExample
        }
    }
}