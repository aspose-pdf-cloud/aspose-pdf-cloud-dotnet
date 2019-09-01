
using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System;

namespace Aspose.Pdf.Cloud.Sdk.Examples
{

    public class ConvertToPdfExamples
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
        public void GetEpubInStorageToPdfExample()
        {
            //ExStart: GetEpubInStorageToPdfExample
            string name = "4pages.epub";
            UploadFile(name, name);

            using (var response = api.GetEpubInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
            //ExEnd: GetEpubInStorageToPdfExample

        }


        public void PutEpubInStorageToPdfExample()
        {
                        //ExStart: GetEpubInStorageToPdfExample

            string name = "4pages.epub";
            UploadFile(name, name);
            string resultName = "fromEpub.pdf";

            var response = api.PutEpubInStorageToPdf(resultName, Path.Combine(FolderName, name), storage: null, dstFolder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetEpubInStorageToPdfExample

        }


        public void GetWebInStorageToPdfExample()
        {
            //ExStart: GetWebInStorageToPdfExample

            string sourceUrl = "http://google.com";

            using (var response = api.GetWebInStorageToPdf(sourceUrl))
            {
                Console.WriteLine(response);
            }
            //ExEnd: GetWebInStorageToPdfExample

        }


        public void PutWebInStorageToPdfExample()
        {
            //ExStart: GetWebInStorageToPdfExample

            string sourceUrl = "http://google.com";
            string resultName = "fromWeb.pdf";

            var response = api.PutWebInStorageToPdf(resultName, sourceUrl, dstFolder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetWebInStorageToPdfExample
        }




        public void GetLaTeXInStorageToPdfExample()
        {
            //ExStart: GetLaTeXInStorageToPdfExample
            string name = "TexExample.tex";
            UploadFile(name, name);

            using (var response = api.GetLaTeXInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
            //ExEnd: GetLaTeXInStorageToPdfExample
        }

        public void PutLaTeXInStorageToPdfExample()
        {
            //ExStart: PutLaTeXInStorageToPdfExample
            string name = "TexExample.tex";
            UploadFile(name, name);
            string resultName = "fromTex.pdf";

            var response = api.PutLaTeXInStorageToPdf(resultName, Path.Combine(FolderName, name), FolderName);
            Console.WriteLine(response);
            //ExEnd: PutLaTeXInStorageToPdfExample
        }


        public void GetMhtInStorageToPdfExample()
        {
            //ExStart: GetMhtInStorageToPdfExample
            string name = "MhtExample.mht";
            UploadFile(name, name);

            using (var response = api.GetMhtInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
            //ExEnd: GetMhtInStorageToPdfExample
        }


        public void PutMhtInStorageToPdfExample()
        {
            //ExStart: PutMhtInStorageToPdfExample
            string name = "MhtExample.mht";
            UploadFile(name, name);
            string resultName = "fromMht.pdf";

            var response = api.PutMhtInStorageToPdf(resultName, Path.Combine(FolderName, name), FolderName);
            Console.WriteLine(response);
            //ExEnd: PutMhtInStorageToPdfExample
        }


        public void GetHtmlInStorageToPdfExample()
        {
            //ExStart: GetHtmlInStorageToPdfExample
            string name = "HtmlWithImage.zip";
            UploadFile(name, name);
            string htmlFileName = "HtmlWithImage.html";
            int height = 650;
            int width = 250;
            using (var response = api.GetHtmlInStorageToPdf(Path.Combine(FolderName, name), htmlFileName, height, width))
            {
                Console.WriteLine(response);
            }
            //ExEnd: GetHtmlInStorageToPdfExample
        }


        public void PutHtmlInStorageToPdfExample()
        {
            //ExStart: PutHtmlInStorageToPdfExample
            string name = "HtmlWithImage.zip";
            UploadFile(name, name);
            string htmlFileName = "HtmlWithImage.html";
            int height = 650;
            int width = 250;
            string resultName = "fromHtml.pdf";

            var response = api.PutHtmlInStorageToPdf(resultName, Path.Combine(FolderName, name), htmlFileName, height, width, dstFolder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutHtmlInStorageToPdfExample

        }


        public void GetXslFoInStorageToPdfExample()
        {
            //ExStart: GetXslFoInStorageToPdfExample

            string name = "XslfoExample.xslfo";
            UploadFile(name, name);

            using (var response = api.GetXslFoInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
            //ExEnd: GetXslFoInStorageToPdfExample

        }


        public void PutXslFoInStorageToPdfExample()
        {
            //ExStart: PutXslFoInStorageToPdfExample

            string name = "XslfoExample.xslfo";
            UploadFile(name, name);
            string resultName = "fromXlsFo.pdf";

            var response = api.PutXslFoInStorageToPdf(resultName, Path.Combine(FolderName, name), FolderName);
            Console.WriteLine(response);
            //ExEnd: PutXslFoInStorageToPdfExample

        }


        public void GetXpsInStorageToPdfExample()
        {
            //ExStart: GetXpsInStorageToPdfExample
            string name = "Simple.xps";
            UploadFile(name, name);

            using (var response = api.GetXpsInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
            //ExEnd: GetXpsInStorageToPdfExample

        }


        public void PutXpsInStorageToPdfExample()
        {
            //ExStart: PutXpsInStorageToPdfExample

            string name = "Simple.xps";
            UploadFile(name, name);
            string resultName = "fromXps.pdf";

            var response = api.PutXpsInStorageToPdf(resultName, Path.Combine(FolderName, name), FolderName);
            Console.WriteLine(response);
            //ExEnd: PutXpsInStorageToPdfExample
        }


        public void GetSvgInStorageToPdfExample()
        {
            //ExStart: GetSvgInStorageToPdfExample

            string name = "Simple.svg";
            UploadFile(name, name);

            using (var response = api.GetSvgInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
            //ExEnd: GetSvgInStorageToPdfExample
        }


        public void PutSvgInStorageToPdfExample()
        {
            //ExStart: PutSvgInStorageToPdfExample

            string name = "Simple.svg";
            UploadFile(name, name);
            string resultName = "fromSvg.pdf";

            var response = api.PutSvgInStorageToPdf(resultName, Path.Combine(FolderName, name), dstFolder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutSvgInStorageToPdfExample
        }


        public void GetPclInStorageToPdfExample()
        {
            //ExStart: GetPclInStorageToPdfExample

            string name = "template.pcl";
            UploadFile(name, name);

            using (var response = api.GetPclInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
            //ExEnd: GetPclInStorageToPdfExample
        }


        public void PutPclInStorageToPdfExample()
        {
            //ExStart: PutPclInStorageToPdfExample

            string name = "template.pcl";
            UploadFile(name, name);
            string resultName = "fromPcl.pdf";

            var response = api.PutPclInStorageToPdf(resultName, Path.Combine(FolderName, name), dstFolder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPclInStorageToPdfExample
        }


        public void GetXmlInStorageToPdfExample()
        {
            //ExStart: GetXmlInStorageToPdfExample

            string name = "template.xml";
            UploadFile(name, name);

            using (var response = api.GetXmlInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
            //ExEnd: GetXmlInStorageToPdfExample

        }


        public void PutXmlInStorageToPdfExample()
        {
            //ExStart: PutXmlInStorageToPdfExample

            string name = "template.xml";
            UploadFile(name, name);
            string resultName = "fromXml.pdf";

            var response = api.PutXmlInStorageToPdf(resultName, Path.Combine(FolderName, name), dstFolder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutXmlInStorageToPdfExample

        }



        public void GetPsInStorageToPdfExample()
        {
            //ExStart: GetPsInStorageToPdfExample

            const string name = "Typography.PS";
            UploadFile(name, name);
            
            using (var response = api.GetPsInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
            //ExEnd: GetPsInStorageToPdfExample

        }


        public void PutPsInStorageToPdfExample()
        {
            //ExStart: PutPsInStorageToPdfExample

            const string name = "Typography.PS";
            UploadFile(name, name);
            string resultName = "fromPs.pdf";

            var response = api.PutPsInStorageToPdf(resultName, Path.Combine(FolderName, name), dstFolder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPsInStorageToPdfExample

        }



        public void PutImageInStorageToPdfExample()
        {
            //ExStart: PutImageInStorageToPdfExample

            const string dataFile1 = "33539.jpg";
            UploadFile(dataFile1, dataFile1);

            const string dataFile2 = "44781.jpg";
            UploadFile(dataFile2, dataFile2);

            const string resultName = "result.pdf";
            string TempFolder="";

            ImageTemplatesRequest imageTemplatesRequest = new ImageTemplatesRequest(IsOCR: true, 
                OCRLangs: "eng", 
                ImagesList: new List<ImageTemplate>()
                {
                    new ImageTemplate(ImagePath: $"{TempFolder}/{dataFile1}", ImageSrcType: ImageSrcType.Common),
                    new ImageTemplate(ImagePath: $"{TempFolder}/{dataFile2}", ImageSrcType: ImageSrcType.Common)
                }
            );
            var response = api.PutImageInStorageToPdf(resultName, imageTemplatesRequest, dstFolder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutImageInStorageToPdfExample
        }
    }
}