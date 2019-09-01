using System.Collections.Generic;
using System.IO;
using System;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;

namespace Aspose.Pdf.Cloud.Sdk.OcrAPI
{

    public class OcrExamples
    {
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }
        public void PutSearchableDocumentExample()
        {
            //ExStart: PutSearchableDocumentExample
            const string name = "rusdoc.pdf";
            UploadFile(name, name);

            var response = api.PutSearchableDocument(name, folder: FolderName, lang: "rus,eng");
            Console.WriteLine(response);
            //ExExnd: PutSearchableDocumentExample
        }


        public void PutSearchableDocumentWithDefaultLangExample()
        {
            //ExStart: PutSearchableDocumentWithDefaultLangExample
            const string name = "rusdoc.pdf";
            UploadFile(name, name);

            var response = api.PutSearchableDocument(name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutSearchableDocumentWithDefaultLangExample
        }
    }
}