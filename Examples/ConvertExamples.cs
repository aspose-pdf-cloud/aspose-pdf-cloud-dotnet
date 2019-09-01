using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System.Collections.Generic;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;

namespace Aspose.Pdf.Cloud.Sdk.ConvertExamples
{

    public class ConvertExamples
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
        public void GetPdfInStorageToDocExample()
        {
            //ExStart: GetPdfInStorageToDocExample
            string name = "4pages.pdf";
            UploadFile(name, name);
         
            var response = api.GetPdfInStorageToDoc(name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPdfInStorageToDocExample

        }
        

        public void PutPdfInStorageToDocExample()
        {
            //ExStart: PutPdfInStorageToDocExample
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.doc";

            var response = api.PutPdfInStorageToDoc(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PutPdfInStorageToDocExample

        }


        public void PutPdfInRequestToDocExample()
        {
         //ExStart: PutPdfInRequestToDocExample   
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.doc";

                var response = api.PutPdfInRequestToDoc(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
                     //ExEnd: PutPdfInRequestToDocExample   

        }


        public void GetPdfInStorageToPdfAExample()
        {
            //ExStart: GetPdfInStorageToPdfAExample
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToPdfA(name, type: PdfAType.PDFA1A.ToString(), folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: GetPdfInStorageToPdfAExample

        }


        public void PutPdfInStorageToPdfAExample()
        {
            //ExStart: PutPdfInStorageToPdfAExample
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.pdf";

            var response = api.PutPdfInStorageToPdfA(name, Path.Combine(FolderName, resFileName), type: PdfAType.PDFA1A.ToString(), folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PutPdfInStorageToPdfAExample

        }

        public void PutPdfInRequestToPdfAExample()
        {
            //ExStart: PutPdfInRequestToPdfAExample

            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.doc";

                var response = api.PutPdfInRequestToPdfA(Path.Combine(FolderName, resFileName),
                    type: PdfAType.PDFA1A.ToString(), file: stream);
                Console.WriteLine(response);
            }
                        //ExEnd: PutPdfInRequestToPdfAExample

        }


        public void GetPdfInStorageToTiffExample()
        {
            //ExStart: GetPdfInStorageToTiffExample

            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToTiff(name, folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: GetPdfInStorageToTiffExample

        }

        public void PutPdfInStorageToTiffExample()
        {
            //ExStart: PutPdfInStorageToTiffExample

            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.tiff";

            var response = api.PutPdfInStorageToTiff(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PutPdfInStorageToTiffExample

        }

        public void PutPdfInRequestToTiffExample()
        {
            //ExStart: PutPdfInRequestToTiffExample

            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.tiff";

                var response = api.PutPdfInRequestToTiff(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
            //ExEnd: PutPdfInRequestToTiffExample

        }


        public void GetPdfInStorageToSvgExample()
        {
            //ExStart: GetPdfInStorageToSvgExample

            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToSvg(name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPdfInStorageToSvgExample

        }


        public void PutPdfInStorageToSvgExample()
        {
            //ExStart: PutPdfInStorageToSvgExample

            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.svg";

            var response = api.PutPdfInStorageToSvg(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPdfInStorageToSvgExample

        }


        public void PutPdfInRequestToSvgExample()
        {
            //ExStart: PutPdfInRequestToSvgExample

            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.svg";

                var response = api.PutPdfInRequestToSvg(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
            //ExEnd: PutPdfInRequestToSvgExample

        }


        public void GetPdfInStorageToXpsExample()
        {
            //ExStart: GetPdfInStorageToXpsExample

            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToXps(name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetPdfInStorageToXpsExample

        }


        public void PutPdfInStorageToXpsExample()
        {
            //ExStart: PutPdfInStorageToXpsExample

            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xps";

            var response = api.PutPdfInStorageToXps(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PutPdfInStorageToXpsExample

        }

        public void PutPdfInRequestToXpsExample()
        {
            //ExStart: PutPdfInRequestToXpsExample

            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.xps";

                var response = api.PutPdfInRequestToXps(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
                            //ExEnd: PutPdfInRequestToXpsExample

            }
        }


        public void GetPdfInStorageToXlsExample()
        {
            //ExStart: GetPdfInStorageToXlsExample

            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToXls(name, folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: GetPdfInStorageToXlsExample

        }

        public void PutPdfInStorageToXlsExample()
        {
            //ExStart: PutPdfInStorageToXlsExample

            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xls";

            var response = api.PutPdfInStorageToXls(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PutPdfInStorageToXlsExample

        }


        public void PutPdfInRequestToXlsExample()
        {
            //ExStart: PutPdfInStorageToXlsExample

            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.xls";

                var response = api.PutPdfInRequestToXls(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
                        //ExEnd: PutPdfInStorageToXlsExample

        }



        public void GetPdfInStorageToHtmlExample()
        {
            //ExStart: GetPdfInStorageToHtmlExample
   
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToHtml(name, folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: GetPdfInStorageToHtmlExample

        }

        public void PutPdfInStorageToHtmlExample()
        {
            //ExStart: PutPdfInStorageToHtmlExample

            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.zip";

            var response = api.PutPdfInStorageToHtml(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PutPdfInStorageToHtmlExample

        }

        public void PutPdfInRequestToHtmlExample()
        {
            //ExStart: PutPdfInRequestToHtmlExample

            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.zip";

                var response = api.PutPdfInRequestToHtml(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
                        //ExEnd: PutPdfInRequestToHtmlExample

        }


        public void GetPdfInStorageToEpubExample()
        {
            //ExStart: GetPdfInStorageToEpubExample

            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToEpub(name, folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: GetPdfInStorageToEpubExample

        }


        public void PutPdfInStorageToEpubExample()
        {
            //ExStart: PutPdfInStorageToEpubExample

            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.epub";

            var response = api.PutPdfInStorageToEpub(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PutPdfInStorageToEpubExample

        }


        public void PutPdfInRequestToEpubExample()
        {
            //ExStart: PutPdfInRequestToEpubExample

            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.epub";

                var response = api.PutPdfInRequestToEpub(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
                        //ExEnd: PutPdfInRequestToEpubExample

        }



        public void GetPdfInStorageToPptxExample()
        {
            //ExStart: GetPdfInStorageToPptxExample

            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToPptx(name, folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: GetPdfInStorageToPptxExample

        }


        public void PutPdfInStorageToPptxExample()
        {
            //ExStart: PutPdfInStorageToPptxExample

            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.pptx";

            var response = api.PutPdfInStorageToPptx(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PutPdfInStorageToPptxExample

        }


        public void PutPdfInRequestToPptxExample()
        {
            //ExStart: PutPdfInRequestToPptxExample

            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.pptx";

                var response = api.PutPdfInRequestToPptx(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
            //ExEnd: PutPdfInRequestToPptxExample

        }


        public void GetPdfInStorageToLaTeXExample()
        {
            //ExStart: GetPdfInStorageToLaTeXExample

            string name = "Hello world.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToLaTeX(name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPdfInRequestToPptxExample

        }

        public void PutPdfInStorageToLaTeXExample()
        {
            //ExStart: PutPdfInStorageToLaTeXExample

            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.latex";

            var response = api.PutPdfInStorageToLaTeX(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPdfInStorageToLaTeXExample

        }


        public void PutPdfInRequestToLaTeXExample()
        {
            //ExStart: PutPdfInRequestToLaTeXExample

            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.latex";

                var response = api.PutPdfInRequestToLaTeX(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
            //ExEnd: PutPdfInStorageToLaTeXExample

        }


        public void GetPdfInStorageToMobiXmlExample()
        {
            //ExStart: GetPdfInStorageToMobiXmlExample

            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToMobiXml(name, folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PutPdfInStorageToLaTeXExample

        }

        public void PutPdfInStorageToMobiXmlExample()
        {
                        //ExStart: PutPdfInStorageToMobiXmlExample

            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.mobi";

            var response = api.PutPdfInStorageToMobiXml(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
                                    //ExEnd: PutPdfInStorageToMobiXmlExample

        }

        public void PutPdfInRequestToMobiXmlExample()
        {
            //ExStart: PutPdfInRequestToMobiXmlExample

            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.mobi";

                var response = api.PutPdfInRequestToMobiXml(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
                        //ExEnd: PutPdfInRequestToMobiXmlExample

        }


        public void GetXfaPdfInStorageToAcroFormExample()
        {
            //ExStart: PutPdfInRequestToMobiXmlExample

            string name = "PdfWithXfaForm.pdf";
            UploadFile(name, name);

            var response = api.GetXfaPdfInStorageToAcroForm(name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutPdfInRequestToMobiXmlExample

        }


        public void PutXfaPdfInStorageToAcroFormExample()
        {
            //ExStart: PutXfaPdfInStorageToAcroFormExample

            string name = "PdfWithXfaForm.pdf";
            UploadFile(name, name);
            string resFileName = "result.pdf";

            var response = api.PutXfaPdfInStorageToAcroForm(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PutXfaPdfInStorageToAcroFormExample

            
        }


        public void PutXfaPdfInRequestToAcroFormExample()
        {
            //ExStart: PutXfaPdfInStorageToAcroFormExample

            string name = "PdfWithXfaForm.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.pdf";

                var response = api.PutXfaPdfInRequestToAcroForm(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
                        //ExEnd: PutXfaPdfInStorageToAcroFormExample

        }



        public void GetPdfInStorageToXmlExample()
        {
            //ExStart: GetPdfInStorageToXmlExample

            string name = "Hello world.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToXml(name, folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: GetPdfInStorageToXmlExample

        }


        public void PutPdfInStorageToXmlExample()
        {
            //ExStart: PutPdfInStorageToXmlExample

            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xml";

            var response = api.PutPdfInStorageToXml(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
                        //ExEnd: PutPdfInStorageToXmlExample

        }


        public void PutPdfInRequestToXmlExample()
        {
            //ExStart: PutPdfInRequestToXmlExample

            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.xml";

                var response = api.PutPdfInRequestToXml(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
            //ExEnd: PutPdfInRequestToXmlExample

        }
    }
}