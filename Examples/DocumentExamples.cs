
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
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }

        public void GetDocumentExample()
        {
            //ExStart: GetDocumentExample
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var result = api.GetDocument(name, folder: FolderName);
            Console.WriteLine(result);
            //ExEnd: GetDocumentExample
        }
        


        public void PostOptimizeDocumentExample()
        {
            //ExStart: PostOptimizeDocumentExample
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var options = new OptimizeOptions(
                AllowReusePageContent: false,
                CompressImages: true,
                ImageQuality: 100,
                RemoveUnusedObjects: true,
                RemoveUnusedStreams: true,
                UnembedFonts: true);
            var response = api.PostOptimizeDocument(name, options, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PostOptimizeDocumentExample
        }
        

        public void PostSplitDocumentExample()
        {
            //ExStart: PostSplitDocumentExample
            const string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.PostSplitDocument(name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PostSplitDocumentExample
        }


        public void PutCreateEmptyDocumentExample()
        {
            //ExStart: PutCreateEmptyDocumentExample
            
            const string name = "empty.pdf";
            var response = api.PutCreateDocument(name, folder: FolderName);
            Console.WriteLine(response);
           //ExEnd: PutCreateEmptyDocumentExample
        }
    }
}