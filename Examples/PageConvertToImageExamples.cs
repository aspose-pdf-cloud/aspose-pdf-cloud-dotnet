using System.Collections.Generic;
using System.IO;
using System;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
namespace Aspose.Pdf.Cloud.Sdk.PageConvertToImageAPI
{
    
    public class PageConvertToImageExamples
    {
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";
        const string Name = "4pages.pdf";
        const int pageNumber = 2;


        public void GetPageConvertToTiffTest()
        {
            var response = api.GetPageConvertToTiff(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
        }
        


        public void PutPageConvertToTiffTest()
        {
            string resultFile = "page.tiff";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToTiff(Name, pageNumber, outPath: outPath, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageConvertToJpegTest()
        {
            var response = api.GetPageConvertToJpeg(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
        }


 
        public void PutPageConvertToJpegTest()
        {
            string resultFile = "page.jpeg";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToJpeg(Name, pageNumber, outPath: outPath, folder: FolderName);
            Console.WriteLine(response);
        }


 
        public void GetPageConvertToPngTest()
        {
            var response = api.GetPageConvertToPng(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
        }



        public void PutPageConvertToPngTest()
        {
            string resultFile = "page.png";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToPng(Name, pageNumber, outPath: outPath, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPageConvertToEmfTest()
        {
            var response = api.GetPageConvertToEmf(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
        }



        public void PutPageConvertToEmfTest()
        {
            string resultFile = "page.emf";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToEmf(Name, pageNumber, outPath: outPath, folder: FolderName);
            Console.WriteLine(response);
        }


  
        public void GetPageConvertToBmpTest()
        {
            var response = api.GetPageConvertToBmp(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
        }


 
        public void PutPageConvertToBmpTest()
        {
            string resultFile = "page.bmp";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToBmp(Name, pageNumber, outPath: outPath, folder: FolderName);
            Console.WriteLine(response);
        }


   
        public void GetPageConvertToGifTest()
        {
            var response = api.GetPageConvertToBmp(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
        }



        public void PutPageConvertToGifTest()
        {
            string resultFile = "page.gif";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToGif(Name, pageNumber, outPath: outPath, folder: FolderName);
           Console.WriteLine(response);
        }
    }

}