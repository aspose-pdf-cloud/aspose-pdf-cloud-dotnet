
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
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }
        public void GetEpubInStorageToPdfTest()
        {
            string name = "4pages.epub";
            UploadFile(name, name);

            using (var response = api.GetEpubInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
        }


        public void PutEpubInStorageToPdfTest()
        {
            string name = "4pages.epub";
            UploadFile(name, name);
            string resultName = "fromEpub.pdf";

            var response = api.PutEpubInStorageToPdf(resultName, Path.Combine(FolderName, name), storage: null, dstFolder: FolderName);
            Console.WriteLine(response);
        }


        public void GetWebInStorageToPdfTest()
        {
            string sourceUrl = "http://google.com";

            using (var response = api.GetWebInStorageToPdf(sourceUrl))
            {
                Console.WriteLine(response);
            }
        }


        public void PutWebInStorageToPdfTest()
        {
            string sourceUrl = "http://google.com";
            string resultName = "fromWeb.pdf";

            var response = api.PutWebInStorageToPdf(resultName, sourceUrl, dstFolder: FolderName);
            Console.WriteLine(response);
        }




        public void GetLaTeXInStorageToPdfTest()
        {
            string name = "TexExample.tex";
            UploadFile(name, name);

            using (var response = api.GetLaTeXInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
        }

        public void PutLaTeXInStorageToPdfTest()
        {
            string name = "TexExample.tex";
            UploadFile(name, name);
            string resultName = "fromTex.pdf";

            var response = api.PutLaTeXInStorageToPdf(resultName, Path.Combine(FolderName, name), FolderName);
            Console.WriteLine(response);
        }


        public void GetMhtInStorageToPdfTest()
        {
            string name = "MhtExample.mht";
            UploadFile(name, name);

            using (var response = api.GetMhtInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
        }


        public void PutMhtInStorageToPdfTest()
        {
            string name = "MhtExample.mht";
            UploadFile(name, name);
            string resultName = "fromMht.pdf";

            var response = api.PutMhtInStorageToPdf(resultName, Path.Combine(FolderName, name), FolderName);
            Console.WriteLine(response);
        }


        public void GetHtmlInStorageToPdfTest()
        {
            string name = "HtmlWithImage.zip";
            UploadFile(name, name);
            string htmlFileName = "HtmlWithImage.html";
            int height = 650;
            int width = 250;
            using (var response = api.GetHtmlInStorageToPdf(Path.Combine(FolderName, name), htmlFileName, height, width))
            {
                Console.WriteLine(response);
            }
        }


        public void PutHtmlInStorageToPdfTest()
        {
            string name = "HtmlWithImage.zip";
            UploadFile(name, name);
            string htmlFileName = "HtmlWithImage.html";
            int height = 650;
            int width = 250;
            string resultName = "fromHtml.pdf";

            var response = api.PutHtmlInStorageToPdf(resultName, Path.Combine(FolderName, name), htmlFileName, height, width, dstFolder: FolderName);
            Console.WriteLine(response);
        }


        public void GetXslFoInStorageToPdfTest()
        {
            string name = "XslfoExample.xslfo";
            UploadFile(name, name);

            using (var response = api.GetXslFoInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
        }


        public void PutXslFoInStorageToPdfTest()
        {
            string name = "XslfoExample.xslfo";
            UploadFile(name, name);
            string resultName = "fromXlsFo.pdf";

            var response = api.PutXslFoInStorageToPdf(resultName, Path.Combine(FolderName, name), FolderName);
            Console.WriteLine(response);
        }


        public void GetXpsInStorageToPdfTest()
        {
            string name = "Simple.xps";
            UploadFile(name, name);

            using (var response = api.GetXpsInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
        }


        public void PutXpsInStorageToPdfTest()
        {
            string name = "Simple.xps";
            UploadFile(name, name);
            string resultName = "fromXps.pdf";

            var response = api.PutXpsInStorageToPdf(resultName, Path.Combine(FolderName, name), FolderName);
            Console.WriteLine(response);
        }


        public void GetSvgInStorageToPdfTest()
        {
            string name = "Simple.svg";
            UploadFile(name, name);

            using (var response = api.GetSvgInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
        }


        public void PutSvgInStorageToPdfTest()
        {
            string name = "Simple.svg";
            UploadFile(name, name);
            string resultName = "fromSvg.pdf";

            var response = api.PutSvgInStorageToPdf(resultName, Path.Combine(FolderName, name), dstFolder: FolderName);
            Console.WriteLine(response);
        }


        public void GetPclInStorageToPdfTest()
        {
            string name = "template.pcl";
            UploadFile(name, name);

            using (var response = api.GetPclInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
        }


        public void PutPclInStorageToPdfTest()
        {
            string name = "template.pcl";
            UploadFile(name, name);
            string resultName = "fromPcl.pdf";

            var response = api.PutPclInStorageToPdf(resultName, Path.Combine(FolderName, name), dstFolder: FolderName);
            Console.WriteLine(response);
        }


        public void GetXmlInStorageToPdfTest()
        {
            string name = "template.xml";
            UploadFile(name, name);

            using (var response = api.GetXmlInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
        }


        public void PutXmlInStorageToPdfTest()
        {
            string name = "template.xml";
            UploadFile(name, name);
            string resultName = "fromXml.pdf";

            var response = api.PutXmlInStorageToPdf(resultName, Path.Combine(FolderName, name), dstFolder: FolderName);
            Console.WriteLine(response);
        }



        public void GetPsInStorageToPdfTest()
        {
            const string name = "Typography.PS";
            UploadFile(name, name);
            
            using (var response = api.GetPsInStorageToPdf(Path.Combine(FolderName, name)))
            {
                Console.WriteLine(response);
            }
        }


        public void PutPsInStorageToPdfTest()
        {
            const string name = "Typography.PS";
            UploadFile(name, name);
            string resultName = "fromPs.pdf";

            var response = api.PutPsInStorageToPdf(resultName, Path.Combine(FolderName, name), dstFolder: FolderName);
            Console.WriteLine(response);
        }



        public void PutImageInStorageToPdfTest()
        {
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
        }
    }
}