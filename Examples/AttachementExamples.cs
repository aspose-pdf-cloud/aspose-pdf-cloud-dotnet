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
       

        public void GetDocumentAttachmentByIndexTest()
        {
            var response = api.GetDocumentAttachmentByIndex(Name, 1, folder: FolderName);
            Console.WriteLine(response);
        }
        

        public void GetDocumentAttachmentsTest()
        {
            var response = api.GetDocumentAttachments(Name, folder: FolderName);
             Console.WriteLine(response);
        }


        public void GetDownloadDocumentAttachmentByIndexTest()
        {
            var result = api.GetDownloadDocumentAttachmentByIndex(Name, 1, folder: FolderName);
            Console.WriteLine(result);
        }

    }

}