
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System.IO;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;


namespace Aspose.Pdf.Cloud.Sdk.Example
{
    public class ImportExportExamples
    {
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }
        private const string Name = "PdfWithLinks.pdf";
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";

     
        public void GetExportFieldsFromPdfToXmlInStorageExample()
        {
            //ExStart: GetExportFieldsFromPdfToXmlInStorageExample
            const string name = "FormData.pdf";
            UploadFile(name, name);

            var response = api.GetExportFieldsFromPdfToXmlInStorage(name, folder: FolderName);
           Console.WriteLine(response);
           //ExEnd: GetExportFieldsFromPdfToXmlInStorageExample
        }

    
        public void GetExportFieldsFromPdfToFdfInStorageExample()
        {
            //ExStart: GetExportFieldsFromPdfToFdfInStorageExample
            const string name = "FormData.pdf";
            UploadFile(name, name);

            var response = api.GetExportFieldsFromPdfToFdfInStorage(name, folder: FolderName);
           Console.WriteLine(response);
           //ExEnd: GetExportFieldsFromPdfToFdfInStorageExample
        }

      
        public void GetExportFieldsFromPdfToXfdfInStorageExample()
        {
            //ExStart: GetExportFieldsFromPdfToXfdfInStorageExample
            const string name = "FormData.pdf";
            UploadFile(name, name);

            var response = api.GetExportFieldsFromPdfToXfdfInStorage(name, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: GetExportFieldsFromPdfToXfdfInStorageExample
        }

        
        public void PutExportFieldsFromPdfToXmlInStorageExample()
        {
            //ExStart: PutExportFieldsFromPdfToXmlInStorageExample
            const string name = "FormData.pdf";
            UploadFile(name, name);

            string outPath = Path.Combine(FolderName, "exportData.xml");

            var response = api.PutExportFieldsFromPdfToXmlInStorage(name, outPath, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: PutExportFieldsFromPdfToXmlInStorageExample
        }

        
        public void PutExportFieldsFromPdfToFdfInStorageExample()
        {
            //ExStart: PutExportFieldsFromPdfToFdfInStorageExample
            const string name = "FormData.pdf";
            UploadFile(name, name);

            string outPath = Path.Combine(FolderName, "exportData.fdf");

            var response = api.PutExportFieldsFromPdfToFdfInStorage(name, outPath, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: PutExportFieldsFromPdfToFdfInStorageExample
        }

        
        public void PutExportFieldsFromPdfToXfdfInStorageExample()
        {
            //ExStart: PutExportFieldsFromPdfToXfdfInStorageExample
            const string name = "FormData.pdf";
            UploadFile(name, name);

            string outPath = Path.Combine(FolderName, "exportData.xfdf");

            var response = api.PutExportFieldsFromPdfToXfdfInStorage(name, outPath, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutExportFieldsFromPdfToXfdfInStorageExample
        }


        
        public void GetImportFieldsFromFdfInStorageExample()
        {
            //ExStart: GetImportFieldsFromFdfInStorageExample
            const string name = "FormData.pdf";
            UploadFile(name, name);

            const string fdfFileName = "FormData.fdf";
            UploadFile(fdfFileName, fdfFileName);

            string fdfFilePath = Path.Combine(FolderName, fdfFileName);
            
            var response = api.GetImportFieldsFromFdfInStorage(name, fdfFilePath, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: GetImportFieldsFromFdfInStorageExample
        }

        
        public void GetImportFieldsFromXfdfInStorageExample()
        {
            //ExStart: GetImportFieldsFromXfdfInStorageExample
            const string name = "FormDataXfdf_in.pdf";
            UploadFile(name, name);

            const string fdfxFileName = "FormDataXfdf_in.xfdf";
            UploadFile(fdfxFileName, fdfxFileName);

            string fdfxFilePath = Path.Combine(FolderName, fdfxFileName);

            var response = api.GetImportFieldsFromXfdfInStorage(name, fdfxFilePath, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: GetImportFieldsFromXfdfInStorageExample
        }

        
        public void GetImportFieldsFromXmlInStorageExample()
        {
            //ExStart: GetImportFieldsFromXmlInStorageExample
            const string name = "FormDataXfa_in.pdf";
            UploadFile(name, name);

            const string xmlFileName = "FormDataXfa_in.xml";
            UploadFile(xmlFileName, xmlFileName);

            string xmlFilePath = Path.Combine(FolderName, xmlFileName);

            var response = api.GetImportFieldsFromXmlInStorage(name, xmlFilePath, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetImportFieldsFromXmlInStorageExample
        }


        
        public void PutImportFieldsFromFdfInStorageExample()
        {
            //ExStart: PutImportFieldsFromFdfInStorageExample
            const string name = "FormData.pdf";
            UploadFile(name, name);

            const string fdfFileName = "FormData.fdf";
            UploadFile(fdfFileName, fdfFileName);

            string fdfFilePath = Path.Combine(FolderName, fdfFileName);

            var response = api.PutImportFieldsFromFdfInStorage(name, fdfFilePath, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutImportFieldsFromFdfInStorageExample
        }

        
        public void PutImportFieldsFromXfdfInStorageExample()
        {
            //ExStart: PutImportFieldsFromXfdfInStorageExample
            const string name = "FormDataXfdf_in.pdf";
            UploadFile(name, name);

            const string fdfxFileName = "FormDataXfdf_in.xfdf";
            UploadFile(fdfxFileName, fdfxFileName);

            string fdfxFilePath = Path.Combine(FolderName, fdfxFileName);

            var response = api.PutImportFieldsFromXfdfInStorage(name, fdfxFilePath, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: PutImportFieldsFromXfdfInStorageExample
        }

      
        public void PutImportFieldsFromXmlInStorageExample()
        {
            //ExStart: PutImportFieldsFromXmlInStorageExample
            const string name = "FormDataXfa_in.pdf";
            UploadFile(name, name);

            const string xmlFileName = "FormDataXfa_in.xml";
            UploadFile(xmlFileName, xmlFileName);

            string xmlFilePath = Path.Combine(FolderName, xmlFileName);

            var response = api.PutImportFieldsFromXmlInStorage(name, xmlFilePath, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: PutImportFieldsFromXmlInStorageExample
        }


       
        public void PostImportFieldsFromFdfExample()
        {
            //ExStart: PostImportFieldsFromFdfExample
            const string name = "FormData.pdf";
            UploadFile(name, name);

            const string fdfFileName = "FormData.fdf";
            
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", fdfFileName)))
            {
                var response = api.PostImportFieldsFromFdf(name, folder: FolderName, fdfData: stream);
                 Console.WriteLine(response);
                 
            }
            //ExEnd: PostImportFieldsFromFdfExample
        }

       
        public void PostImportFieldsFromXfdfExample()
        {
            //ExStart: PostImportFieldsFromXfdfExample
            const string name = "FormDataXfdf_in.pdf";
            UploadFile(name, name);

            const string fdfxFileName = "FormDataXfdf_in.xfdf";

            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", fdfxFileName)))
            {
                var response = api.PostImportFieldsFromXfdf(name, folder: FolderName, xfdfData: stream);
                 Console.WriteLine(response);
            }
            //ExEnd: PostImportFieldsFromXfdfExample
        }

        
        public void PostImportFieldsFromXmlExample()
        {
            //ExStart: PostImportFieldsFromXmlExample
            const string name = "FormDataXfa_in.pdf";
            UploadFile(name, name);

            const string xmlFileName = "FormDataXfa_in.xml";

            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", xmlFileName)))
            {
                var response = api.PostImportFieldsFromXml(name, folder: FolderName, xmlData: stream);
                 Console.WriteLine(response);
                 
            }
            //ExEnd: PostImportFieldsFromXmlExample
        }
 
    }
}