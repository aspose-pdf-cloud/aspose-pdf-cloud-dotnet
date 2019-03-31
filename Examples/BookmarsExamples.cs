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
        PdfApi api=new PdfApi("b125f13bf6b76ed81ee990142d841195","78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");

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