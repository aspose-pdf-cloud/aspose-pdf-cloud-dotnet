
using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;


namespace Aspose.Pdf.Cloud.Sdk.Test
{

    public class StorageTests
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
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }

        public void PutCreateTest()
        {
            string name = "4pages.pdf";

            using (var file = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                var response = api.PutCreate(Path.Combine(FolderName, name), file);
                Console.WriteLine(response);
            }
        }


        public void GetDownloadTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetDownload(Path.Combine(FolderName, name));
            Console.WriteLine(response);
        }


        public void PostMoveFileTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string src = Path.Combine(FolderName, name);
            string dest = Path.Combine(FolderName, "4pages_renamed.pdf");

            var response = api.PostMoveFile(src, dest);
            Console.WriteLine(response);
        }


        public void DeleteFileTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string path = Path.Combine(FolderName, name);

            var response = api.DeleteFile(path);
            Console.WriteLine(response);
        }

        public void GetListFilesTest()
        {
            var response = api.GetListFiles(FolderName);
            Console.WriteLine(response);
        }

  
        public void PutCreateFolderTest()
        {
            string path = Path.Combine(FolderName, "testFolder");
            var response = api.PutCreateFolder(path);
            Console.WriteLine(response);
        }


        public void PostMoveFolderTest()
        {
            string src = Path.Combine(FolderName, "testFolder");
            var createFolderresponse = api.PutCreateFolder(src);

            string dest = Path.Combine(FolderName, "testFolderRenamed");

            var response = api.PostMoveFolder(src, dest);
            Console.WriteLine(response);
        }


        public void DeleteFolderTest()
        {
            string path = Path.Combine(FolderName, "testFolderRenamed");
            var createFolderresponse = api.PutCreateFolder(path);

            var response = api.DeleteFolder(path);
            Console.WriteLine(response);
        }


        public void GetIsStorageExistTest()
        {
            string name = "PDF-CI";
            var response = api.GetIsStorageExist(name);
            Console.WriteLine(response);
        }


        public void GetIsExistTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetIsExist(Path.Combine(FolderName, name));
            Console.WriteLine(response);
        }


        public void GetDiscUsageTest()
        {
            var response = api.GetDiscUsage();
            Console.WriteLine(response);
        }


        public void GetListFileVersionsTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetListFileVersions(Path.Combine(FolderName, name));
            Console.WriteLine(response);
        }
    }
}