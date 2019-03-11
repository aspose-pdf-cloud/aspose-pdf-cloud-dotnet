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
        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
        string FolderName = "";
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }
        public void PutSearchableDocumentTest()
        {
            const string name = "rusdoc.pdf";
            UploadFile(name, name);

            var response = api.PutSearchableDocument(name, folder: FolderName, lang: "rus,eng");
            Console.WriteLine(response);
        }


        public void PutSearchableDocumentWithDefaultLangTest()
        {
            const string name = "rusdoc.pdf";
            UploadFile(name, name);

            var response = api.PutSearchableDocument(name, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}