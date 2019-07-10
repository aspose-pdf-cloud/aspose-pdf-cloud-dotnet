using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System.Collections.Generic;
using Aspose.Pdf.Cloud.Sdk.Model;
using System.IO;


namespace Aspose.Pdf.Cloud.Sdk.AppendAPI
{

    public class AppendDocumentExamples
    {
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }

        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");

        private const string Name = "PdfWithImages2.pdf";
        private const string AppendFile = "4pages.pdf";
        private const int StartPage = 2;
        private const int EndPage = 4;
        string FolderName="";

        public void PostAppendDocumentUsingQueryParamsTest()
        {
            UploadFile(Name, Name);
            UploadFile(AppendFile, AppendFile);

            var responce =
                api.PostAppendDocument(Name, appendFile: Path.Combine(FolderName, AppendFile), startPage: StartPage, endPage: EndPage, folder: FolderName);
           Console.WriteLine(responce);
        }


        public void PostAppendDocumentUsingBodyParamsTest()
        {
            UploadFile(Name, Name);
            UploadFile(AppendFile, AppendFile);

            var appendDocument = new AppendDocument(Path.Combine(FolderName, AppendFile), StartPage, EndPage);
            var responce =
                api.PostAppendDocument(Name, appendDocument, folder: FolderName);
             Console.WriteLine(responce);
        }
    }
}