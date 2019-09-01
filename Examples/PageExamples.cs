
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Newtonsoft.Json;
using Aspose.Pdf.Cloud.Sdk.Api;
using System;



namespace Aspose.Pdf.Cloud.Sdk.PagesAPI
{

    public class PagesExamples
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

        private const string Name = "4pages.pdf";


        public void DeletePageExample()
        {
            //ExStart: DeletePageExample
            var response = api.DeletePage(Name, 3, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: DeletePageExample
        }

        public void GetPageExample()
        {
            //ExStart: GetPageExample
            var response = api.GetPage(Name, pageNumber: 1, folder: FolderName);
            
            Console.WriteLine(response);
            //ExEnd: GetPageExample
        }
        
     
        public void GetPagesExample()
        {
            //ExStart: GetPagesExample
            var response = api.GetPages(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPagesExample
        }

  
        public void GetWordsPerPageExample()
        {
            //ExStart: GetWordsPerPageExample
            var response = api.GetWordsPerPage(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetWordsPerPageExample
        }

  
        public void PostMovePageExample()
        {
            //ExStart: PostMovePageExample
            var response = api.PostMovePage(Name, 3, 2, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PostMovePageExample
        }

 
        public void PutAddNewPageExample()
        {
            //ExStart: PutAddNewPageExample
            var response = api.PutAddNewPage(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutAddNewPageExample
        }

   
        public void PutPageAddStampExample()
        {
            //ExStart: PutPageAddStampExample
            const string stampFile = "Penguins.jpg";
            UploadFile(stampFile, stampFile);

            var stamp = new Stamp(
                Type: StampType.Image,
                FileName: Path.Combine(FolderName, stampFile),
                Background: true,
                Width: 200,
                Height: 200,
                XIndent: 100,
                YIndent: 100);

            var response = api.PutPageAddStamp(Name, 1, stamp, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPageAddStampExample
        }
    }
}