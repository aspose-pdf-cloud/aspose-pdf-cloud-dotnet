using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System.Collections.Generic;
using Aspose.Pdf.Cloud.Sdk.Model;
namespace Aspose.Pdf.Cloud.Sdk.AttachmentExamples
{

    public class AttachmentsExamples
    {
        PdfApi api=new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName="";
        private const string Name = "PdfWithEmbeddedFiles.pdf";
       

        public void GetDocumentAttachmentByIndexExample()
        {
            //ExStart: GetDocumentAttachmentByIndexExample
            var response = api.GetDocumentAttachmentByIndex(Name, 1, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentAttachmentByIndexExample
        }
        

        public void GetDocumentAttachmentsExample()
        {
            //ExStart: GetDocumentAttachmentsExample
            var response = api.GetDocumentAttachments(Name, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: GetDocumentAttachmentsExample
        }


        public void GetDownloadDocumentAttachmentByIndexExample()
        {
             //ExStart: GetDownloadDocumentAttachmentByIndexExample
            var result = api.GetDownloadDocumentAttachmentByIndex(Name, 1, folder: FolderName);
            Console.WriteLine(result);
            //ExEnd: GetDownloadDocumentAttachmentByIndexExample
        }

    }

}