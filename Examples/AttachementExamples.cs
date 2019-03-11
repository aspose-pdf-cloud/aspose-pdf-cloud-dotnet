using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System.Collections.Generic;
using Aspose.Pdf.Cloud.Sdk.Model;
namespace Aspose.Pdf.Cloud.Sdk.AttachmentExamples
{

    public class AttachmentsExamples
    {
        PdfApi api=new PdfApi("b125f13bf6b76ed81ee990142d841195","78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
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