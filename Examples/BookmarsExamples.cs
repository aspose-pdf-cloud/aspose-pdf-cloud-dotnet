using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System.Collections.Generic;
using Aspose.Pdf.Cloud.Sdk.Model;
using System.IO;

namespace Aspose.Pdf.Cloud.Sdk.BookmarkAPI
{

    public class BookmarksExamples
    {
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");

        string FolderName="";

        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }
        public void GetDocumentBookmarksTest()
        {
            const string name = "PdfWithBookmarks.pdf";
            UploadFile(name, name);

            var response = api.GetDocumentBookmarks(name, folder: FolderName);
            Console.WriteLine( response);
        }
    }
}