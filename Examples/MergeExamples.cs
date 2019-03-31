using Aspose.Pdf.Cloud.Sdk.Api;

using System.Collections.Generic;
using System.IO;
using System.Net;
using System;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Aspose.Pdf.Cloud.Sdk.MergeAPI
{
    public class MergeExamples
    {
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }
        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
        string FolderName = "";

        public void PutMergeDocumentsTest()
        {
            var names = new[] { "4pages.pdf", "PdfWithImages2.pdf", "marketing.pdf" };
            const string resultName = "MergingResult.pdf";

            var mergeDocuments = new MergeDocuments(new List<string>());
            foreach (var name in names)
            {
                UploadFile(name, name);
                mergeDocuments.List.Add(Path.Combine(FolderName, name));
            }

            var response = api.PutMergeDocuments(resultName, mergeDocuments, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}