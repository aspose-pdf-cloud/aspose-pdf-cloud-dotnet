using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System.Collections.Generic;
using Aspose.Pdf.Cloud.Sdk.Model;


namespace Aspose.Pdf.Cloud.AnnotationExamples
{
    public class AnnotationsExamples 
    {
        PdfApi api=new PdfApi("b125f13bf6b76ed81ee990142d841195","78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
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

        public void GetDocumentAnnotationsTest()
        {
            var response = api.GetDocumentAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }

        public void DeleteDocumentAnnotationsTest()
        {
            var response = api.DeleteDocumentAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageAnnotationsTest()
        {
            var response = api.GetPageAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }


        public void DeletePageAnnotationsTest()
        {
            var response = api.DeletePageAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }



        public void DeleteAnnotationTest()
        {
            var response = api.DeleteAnnotation(Name, AnnotationId, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutAnnotationsFlattenTest()
        {
            var response = api.PutAnnotationsFlatten(Name, endPage: 2, annotationTypes: new List<AnnotationType>{ AnnotationType .Stamp}, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}