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
            //ExStart: UploadFile
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
            //ExEnd: UploadFile
        }
        public void GetDocumentBookmarksExample()
        {
            //ExStart: GetDocumentBookmarksExample
            const string name = "PdfWithBookmarks.pdf";
            UploadFile(name, name);

            var response = api.GetDocumentBookmarks(name, folder: FolderName);
            Console.WriteLine( response);
            //ExEnd: GetDocumentBookmarksExample
        }
    }
}