
using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System;

namespace Aspose.Pdf.Cloud.Sdk.DocumentAPI
{

    public class DocumentExamples
    {
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";

        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }

        public void GetDocumentTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var result = api.GetDocument(name, folder: FolderName);
            Console.WriteLine(result);
        }
        


        public void PostOptimizeDocumentTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var options = new OptimizeOptions(
                AllowReusePageContent: false,
                CompressImages: true,
                ImageQuality: 100,
                LinkDuplcateStreams: true,
                RemoveUnusedObjects: true,
                RemoveUnusedStreams: true,
                UnembedFonts: true);
            var response = api.PostOptimizeDocument(name, options, folder: FolderName);
            Console.WriteLine(response);
        }
        

        public void PostSplitDocumentTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.PostSplitDocument(name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutCreateEmptyDocumentTest()
        {
            const string name = "empty.pdf";
            var response = api.PutCreateDocument(name, folder: FolderName);
           Console.WriteLine(response);
        }
    }
}