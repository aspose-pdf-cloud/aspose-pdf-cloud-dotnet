
using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;


namespace Aspose.Pdf.Cloud.Sdk.Example
{

    public class StorageExamples
    {
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;
        private const string AttachmentFile = "4pages.pdf";

        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";

        
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }

        public void PutCreateExample()
        {
            //ExStart: PutCreateExample
            string name = "4pages.pdf";

            using (var file = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                var response = api.UploadFile(Path.Combine(FolderName, name), file);
                Console.WriteLine(response);
                
            }
            //ExEnd: PutCreateExample
        }


        public void GetDownloadExample()
        {
            //ExStart: GetDownloadExample
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.DownloadFile(Path.Combine(FolderName, name));
            Console.WriteLine(response);
            //ExEnd: GetDownloadExample
        }


        public void PostMoveFileExample()
        {
            //ExStart: PostMoveFileExample
            string name = "4pages.pdf";
            UploadFile(name, name);
            string src = Path.Combine(FolderName, name);
            string dest = Path.Combine(FolderName, "4pages_renamed.pdf");

            api.MoveFile(src, dest);
            //ExEnd: PostMoveFileExample

        }


        public void DeleteFileExample()
        {
            //ExStart: DeleteFileExample
            string name = "4pages.pdf";
            UploadFile(name, name);
            string path = Path.Combine(FolderName, name);

            api.DeleteFile(path);
            //ExEnd: DeleteFileExample
        }

        public void GetListFilesExample()
        {
             //ExStart: GetListFilesExample
            var response = api.GetFilesList(FolderName);
            Console.WriteLine(response);
             //ExEnd: GetListFilesExample
        }

  
        public void PutCreateFolderExample()
        {
            //ExStart: PutCreateFolderExample
            string path = Path.Combine(FolderName, "ExampleFolder");
            api.CreateFolder(path);
            //ExEnd: PutCreateFolderExample
        }


        public void PostMoveFolderExample()
        {
            //ExStart: PostMoveFolderExample
            string src = Path.Combine(FolderName, "ExampleFolder");
            api.CreateFolder(src);

            string dest = Path.Combine(FolderName, "ExampleFolderRenamed");

            api.MoveFolder(src, dest);
            //ExEnd: PostMoveFolderExample
        }


        public void DeleteFolderExample()
        {
            //ExStart: DeleteFolderExample
            string path = Path.Combine(FolderName, "ExampleFolderRenamed");
            api.CreateFolder(path);

            api.DeleteFolder(path);
            //ExEnd: DeleteFolderExample

        }


        public void GetIsStorageExistExample()
        {
            //ExStart: GetIsStorageExistExample
            string name = "PDF-CI";
            var response = api.StorageExists(name);
            Console.WriteLine(response);
            //ExEnd: GetIsStorageExistExample
        }


        public void GetIsExistExample()
        {
            //ExStart: GetIsExistExample
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.ObjectExists(Path.Combine(FolderName, name));
            Console.WriteLine(response);
            //ExEnd: GetIsExistExample
        }


        public void GetDiscUsageExample()
        {
            //ExStart: GetDiscUsageExample
            var response = api.GetDiscUsage();
            Console.WriteLine(response);
            //ExEnd: GetDiscUsageExample
        }


        public void GetListFileVersionsExample()
        {
            //ExStart: GetListFileVersionsExample
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetFileVersions(Path.Combine(FolderName, name));
            Console.WriteLine(response);
            //ExEnd: GetListFileVersionsExample
        }
    }
}