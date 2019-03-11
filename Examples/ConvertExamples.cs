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
        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");

        string FolderName = "";

        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }
        public void GetPdfInStorageToDocTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
         
            var response = api.GetPdfInStorageToDoc(name, folder: FolderName);
            Console.WriteLine(response);
        }
        

        public void PutPdfInStorageToDocTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.doc";

            var response = api.PutPdfInStorageToDoc(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInRequestToDocTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.doc";

                var response = api.PutPdfInRequestToDoc(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }


        public void GetPdfInStorageToPdfATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToPdfA(name, type: PdfAType.PDFA1A.ToString(), folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInStorageToPdfATest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.pdf";

            var response = api.PutPdfInStorageToPdfA(name, Path.Combine(FolderName, resFileName), type: PdfAType.PDFA1A.ToString(), folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutPdfInRequestToPdfATest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.doc";

                var response = api.PutPdfInRequestToPdfA(Path.Combine(FolderName, resFileName),
                    type: PdfAType.PDFA1A.ToString(), file: stream);
                Console.WriteLine(response);
            }
        }


        public void GetPdfInStorageToTiffTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToTiff(name, folder: FolderName);
            Console.WriteLine(response);        
        }

        public void PutPdfInStorageToTiffTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.tiff";

            var response = api.PutPdfInStorageToTiff(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutPdfInRequestToTiffTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.tiff";

                var response = api.PutPdfInRequestToTiff(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }


        public void GetPdfInStorageToSvgTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToSvg(name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInStorageToSvgTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.svg";

            var response = api.PutPdfInStorageToSvg(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInRequestToSvgTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.svg";

                var response = api.PutPdfInRequestToSvg(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }


        public void GetPdfInStorageToXpsTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToXps(name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInStorageToXpsTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xps";

            var response = api.PutPdfInStorageToXps(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutPdfInRequestToXpsTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.xps";

                var response = api.PutPdfInRequestToXps(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }


        public void GetPdfInStorageToXlsTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToXls(name, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutPdfInStorageToXlsTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xls";

            var response = api.PutPdfInStorageToXls(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInRequestToXlsTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.xls";

                var response = api.PutPdfInRequestToXls(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }



        public void GetPdfInStorageToHtmlTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToHtml(name, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutPdfInStorageToHtmlTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.zip";

            var response = api.PutPdfInStorageToHtml(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutPdfInRequestToHtmlTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.zip";

                var response = api.PutPdfInRequestToHtml(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }


        public void GetPdfInStorageToEpubTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToEpub(name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInStorageToEpubTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.epub";

            var response = api.PutPdfInStorageToEpub(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInRequestToEpubTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.epub";

                var response = api.PutPdfInRequestToEpub(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }



        public void GetPdfInStorageToPptxTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToPptx(name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInStorageToPptxTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.pptx";

            var response = api.PutPdfInStorageToPptx(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInRequestToPptxTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.pptx";

                var response = api.PutPdfInRequestToPptx(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }


        public void GetPdfInStorageToLaTeXTest()
        {
            string name = "Hello world.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToLaTeX(name, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutPdfInStorageToLaTeXTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.latex";

            var response = api.PutPdfInStorageToLaTeX(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInRequestToLaTeXTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.latex";

                var response = api.PutPdfInRequestToLaTeX(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }


        public void GetPdfInStorageToMobiXmlTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToMobiXml(name, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutPdfInStorageToMobiXmlTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.mobi";

            var response = api.PutPdfInStorageToMobiXml(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }

        public void PutPdfInRequestToMobiXmlTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.mobi";

                var response = api.PutPdfInRequestToMobiXml(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }


        public void GetXfaPdfInStorageToAcroFormTest()
        {
            string name = "PdfWithXfaForm.pdf";
            UploadFile(name, name);

            var response = api.GetXfaPdfInStorageToAcroForm(name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutXfaPdfInStorageToAcroFormTest()
        {
            string name = "PdfWithXfaForm.pdf";
            UploadFile(name, name);
            string resFileName = "result.pdf";

            var response = api.PutXfaPdfInStorageToAcroForm(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutXfaPdfInRequestToAcroFormTest()
        {
            string name = "PdfWithXfaForm.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.pdf";

                var response = api.PutXfaPdfInRequestToAcroForm(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }



        public void GetPdfInStorageToXmlTest()
        {
            string name = "Hello world.pdf";
            UploadFile(name, name);

            var response = api.GetPdfInStorageToXml(name, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInStorageToXmlTest()
        {
            string name = "4pages.pdf";
            UploadFile(name, name);
            string resFileName = "result.xml";

            var response = api.PutPdfInStorageToXml(name, Path.Combine(FolderName, resFileName), folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutPdfInRequestToXmlTest()
        {
            string name = "4pages.pdf";
            using (Stream stream = System.IO.File.OpenRead(Path.Combine("", name)))
            {
                string resFileName = "result.xml";

                var response = api.PutPdfInRequestToXml(Path.Combine(FolderName, resFileName), file: stream);
                Console.WriteLine(response);
            }
        }
    }
}