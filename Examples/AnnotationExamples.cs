using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System.Collections.Generic;
using Aspose.Pdf.Cloud.Sdk.Model;


namespace Aspose.Pdf.Cloud.AnnotationExamples
{
    public class AnnotationsExamples 
    {
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName="";

        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;
        private string _annotationId;

        private string AnnotationId
        {
            get
            {
                if (null == _annotationId)
                {
                    var response = api.GetDocumentAnnotations(Name, folder: FolderName);
                    _annotationId = response.Annotations.List[0].Id;
                }

                return _annotationId;
            }
        }

        public void GetDocumentAnnotationsExample()
        {
            //ExStart: GetDocumentAnnotationsExample
            var response = api.GetDocumentAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentAnnotationsExample
        }

        public void DeleteDocumentAnnotationsExample()
        {
            //ExStart: DeleteDocumentAnnotationsExample
            var response = api.DeleteDocumentAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: DeleteDocumentAnnotationsExample
        }


        public void GetPageAnnotationsExample()
        {
            //ExStart: GetPageAnnotationsExample
            var response = api.GetPageAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageAnnotationsExample
        }


        public void DeletePageAnnotationsExample()
        {
            //ExStart: DeletePageAnnotationsExample
            var response = api.DeletePageAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: DeletePageAnnotationsExample
        }



        public void DeleteAnnotationExample()
        {
            //ExStart: DeleteAnnotationExample
            var response = api.DeleteAnnotation(Name, AnnotationId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: DeleteAnnotationExample
        }

        public void PutAnnotationsFlattenExample()
        {
            //ExStart: PutAnnotationsFlattenExample
            var response = api.PutAnnotationsFlatten(Name, endPage: 2, annotationTypes: new List<AnnotationType>{ AnnotationType .Stamp}, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutAnnotationsFlattenExample
        }
    }
}