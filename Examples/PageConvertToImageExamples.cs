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


        public void GetPageConvertToTiffExample()
        {
            //ExStart: GetPageConvertToTiffExample
            var response = api.GetPageConvertToTiff(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageConvertToTiffExample
        }
        


        public void PutPageConvertToTiffExample()
        {
            //ExStart: PutPageConvertToTiffExample
            string resultFile = "page.tiff";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToTiff(Name, pageNumber, outPath: outPath, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPageConvertToTiffExample
        }


        public void GetPageConvertToJpegExample()
        {
            //ExStart: GetPageConvertToJpegExample
            var response = api.GetPageConvertToJpeg(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageConvertToJpegExample
        }


 
        public void PutPageConvertToJpegExample()
        {
            //ExStart: PutPageConvertToJpegExample
            string resultFile = "page.jpeg";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToJpeg(Name, pageNumber, outPath: outPath, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPageConvertToJpegExample
        }


 
        public void GetPageConvertToPngExample()
        {
            //ExStart: GetPageConvertToPngExample
            var response = api.GetPageConvertToPng(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageConvertToPngExample
        }



        public void PutPageConvertToPngExample()
        {
            //ExStart: PutPageConvertToPngExample
            string resultFile = "page.png";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToPng(Name, pageNumber, outPath: outPath, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPageConvertToPngExample
        }


        public void GetPageConvertToEmfExample()
        {
            //ExStart: GetPageConvertToEmfExample
            var response = api.GetPageConvertToEmf(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageConvertToEmfExample
        }



        public void PutPageConvertToEmfExample()
        {
            //ExStart: PutPageConvertToEmfExample
            string resultFile = "page.emf";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToEmf(Name, pageNumber, outPath: outPath, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPageConvertToEmfExample
        }


  
        public void GetPageConvertToBmpExample()
        {
            //ExStart: GetPageConvertToBmpExample
            var response = api.GetPageConvertToBmp(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageConvertToBmpExample
        }


 
        public void PutPageConvertToBmpExample()
        {
            //ExStart: PutPageConvertToBmpExample
            string resultFile = "page.bmp";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToBmp(Name, pageNumber, outPath: outPath, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPageConvertToBmpExample
        }


   
        public void GetPageConvertToGifExample()
        {
            //ExStart: GetPageConvertToGifExample
            var response = api.GetPageConvertToBmp(Name, pageNumber, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPageConvertToGifExample
        }



        public void PutPageConvertToGifExample()
        {
            //ExStart: PutPageConvertToGifExample
            string resultFile = "page.gif";
            string outPath = Path.Combine(FolderName, resultFile);
            var response = api.PutPageConvertToGif(Name, pageNumber, outPath: outPath, folder: FolderName);
           Console.WriteLine(response);
           //ExEnd: PutPageConvertToGifExample
        }
    }

}