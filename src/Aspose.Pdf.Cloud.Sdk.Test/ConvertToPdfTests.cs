// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PagesTests.cs">
//   Copyright (c) 2021 Aspose.PDF Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Convert Api
    /// </summary>
    [TestFixture]
    public class ConvertToPdfTests : TestsBase
    {
        /// <summary>
        /// Test GetEpubInStorageToPdf
        /// </summary>
        [Test]
        public void GetEpubInStorageToPdfTest()
        {
            string name = "4pages.epub";
            UploadFile(name, name);

            using (var response = PdfApi.GetEpubInStorageToPdf(Path.Combine(TempFolder, name)))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutEpubInStorageToPdf
        /// </summary>
        [Test]
        public void PutEpubInStorageToPdfTest()
        {
            string name = "4pages.epub";
            UploadFile(name, name);
            string resultName = "fromEpub.pdf";

            var response = PdfApi.PutEpubInStorageToPdf(resultName, Path.Combine(TempFolder, name), storage: null, dstFolder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetWebInStorageToPdf
        /// </summary>
        [Test]
        public void GetWebInStorageToPdfTest()
        {
            string sourceUrl = "http://google.com";

            using (var response = PdfApi.GetWebInStorageToPdf(sourceUrl))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutWebInStorageToPdf
        /// </summary>
        [Test]
        public void PutWebInStorageToPdfTest()
        {
            string sourceUrl = "http://google.com";
            string resultName = "fromWeb.pdf";

            var response = PdfApi.PutWebInStorageToPdf(resultName, sourceUrl, dstFolder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }



        /// <summary>
        /// Test GetTeXInStorageToPdf
        /// </summary>
        [Test]
        public void GetTeXInStorageToPdfTest()
        {
            string name = "sample.tex";
            UploadFile(name, name);

            using (var response = PdfApi.GetTeXInStorageToPdf(Path.Combine(TempFolder, name)))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutTeXInStorageToPdf
        /// </summary>
        [Test]
        public void PutTeXInStorageToPdfTest()
        {
            string name = "sample.tex";
            UploadFile(name, name);
            string resultName = "fromTex.pdf";

            var response = PdfApi.PutTeXInStorageToPdf(resultName, Path.Combine(TempFolder, name), TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetMhtInStorageToPdf
        /// </summary>
        [Test]
        public void GetMhtInStorageToPdfTest()
        {
            string name = "MhtExample.mht";
            UploadFile(name, name);

            using (var response = PdfApi.GetMhtInStorageToPdf(Path.Combine(TempFolder, name)))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutMhtInStorageToPdf
        /// </summary>
        [Test]
        public void PutMhtInStorageToPdfTest()
        {
            string name = "MhtExample.mht";
            UploadFile(name, name);
            string resultName = "fromMht.pdf";

            var response = PdfApi.PutMhtInStorageToPdf(resultName, Path.Combine(TempFolder, name), TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetHtmlInStorageToPdf
        /// </summary>
        [Test]
        public void GetHtmlInStorageToPdfTest()
        {
            string name = "HtmlWithImage.zip";
            UploadFile(name, name);
            string htmlFileName = "HtmlWithImage.html";
            int height = 650;
            int width = 250;
            using (var response = PdfApi.GetHtmlInStorageToPdf(Path.Combine(TempFolder, name), htmlFileName, height, width))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutHtmlInStorageToPdf
        /// </summary>
        [Test]
        public void PutHtmlInStorageToPdfTest()
        {
            string name = "HtmlWithImage.zip";
            UploadFile(name, name);
            string htmlFileName = "HtmlWithImage.html";
            int height = 650;
            int width = 250;
            string resultName = "fromHtml.pdf";

            var response = PdfApi.PutHtmlInStorageToPdf(resultName, Path.Combine(TempFolder, name), htmlFileName, height, width, dstFolder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetXslFoInStorageToPdf
        /// </summary>
        [Test]
        public void GetXslFoInStorageToPdfTest()
        {
            string name = "XslfoExample.xslfo";
            UploadFile(name, name);

            using (var response = PdfApi.GetXslFoInStorageToPdf(Path.Combine(TempFolder, name)))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutXslFoInStorageToPdf
        /// </summary>
        [Test]
        public void PutXslFoInStorageToPdfTest()
        {
            string name = "XslfoExample.xslfo";
            UploadFile(name, name);
            string resultName = "fromXlsFo.pdf";

            var response = PdfApi.PutXslFoInStorageToPdf(resultName, Path.Combine(TempFolder, name), TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetXpsInStorageToPdf
        /// </summary>
        [Test]
        public void GetXpsInStorageToPdfTest()
        {
            string name = "Simple.xps";
            UploadFile(name, name);

            using (var response = PdfApi.GetXpsInStorageToPdf(Path.Combine(TempFolder, name)))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutXpsInStorageToPdf
        /// </summary>
        [Test]
        public void PutXpsInStorageToPdfTest()
        {
            string name = "Simple.xps";
            UploadFile(name, name);
            string resultName = "fromXps.pdf";

            var response = PdfApi.PutXpsInStorageToPdf(resultName, Path.Combine(TempFolder, name), TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetSvgInStorageToPdf
        /// </summary>
        [Test]
        public void GetSvgInStorageToPdfTest()
        {
            string name = "Simple.svg";
            UploadFile(name, name);

            using (var response = PdfApi.GetSvgInStorageToPdf(Path.Combine(TempFolder, name)))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutSvgInStorageToPdf
        /// </summary>
        [Test]
        public void PutSvgInStorageToPdfTest()
        {
            string name = "Simple.svg";
            UploadFile(name, name);
            string resultName = "fromSvg.pdf";

            var response = PdfApi.PutSvgInStorageToPdf(resultName, Path.Combine(TempFolder, name), dstFolder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPclInStorageToPdf
        /// </summary>
        [Test]
        public void GetPclInStorageToPdfTest()
        {
            string name = "template.pcl";
            UploadFile(name, name);

            using (var response = PdfApi.GetPclInStorageToPdf(Path.Combine(TempFolder, name)))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutPclInStorageToPdf
        /// </summary>
        [Test]
        public void PutPclInStorageToPdfTest()
        {
            string name = "template.pcl";
            UploadFile(name, name);
            string resultName = "fromPcl.pdf";

            var response = PdfApi.PutPclInStorageToPdf(resultName, Path.Combine(TempFolder, name), dstFolder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetXmlInStorageToPdf
        /// </summary>
        [Test]
        public void GetXmlInStorageToPdfTest()
        {
            string name = "template.xml";
            UploadFile(name, name);

            using (var response = PdfApi.GetXmlInStorageToPdf(Path.Combine(TempFolder, name)))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutXmlInStorageToPdf
        /// </summary>
        [Test]
        public void PutXmlInStorageToPdfTest()
        {
            string name = "template.xml";
            UploadFile(name, name);
            string resultName = "fromXml.pdf";

            var response = PdfApi.PutXmlInStorageToPdf(resultName, Path.Combine(TempFolder, name), dstFolder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetPsInStorageToPdf
        /// </summary>
        [Test]
        public void GetPsInStorageToPdfTest()
        {
            const string name = "Typography.PS";
            UploadFile(name, name);
            
            using (var response = PdfApi.GetPsInStorageToPdf(Path.Combine(TempFolder, name)))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutPsInStorageToPdf
        /// </summary>
        [Test]
        public void PutPsInStorageToPdfTest()
        {
            const string name = "Typography.PS";
            UploadFile(name, name);
            string resultName = "fromPs.pdf";

            var response = PdfApi.PutPsInStorageToPdf(resultName, Path.Combine(TempFolder, name), dstFolder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test PutImageInStorageToPdf
        /// </summary>
        [Test]
        public void PutImageInStorageToPdfTest()
        {
            const string dataFile1 = "33539.jpg";
            UploadFile(dataFile1, dataFile1);

            const string dataFile2 = "44781.jpg";
            UploadFile(dataFile2, dataFile2);

            const string resultName = "result.pdf";

            ImageTemplatesRequest imageTemplatesRequest = new ImageTemplatesRequest(IsOCR: true, 
                OCRLangs: "eng", 
                ImagesList: new List<ImageTemplate>()
                {
                    new ImageTemplate(ImagePath: $"{TempFolder}/{dataFile1}", ImageSrcType: ImageSrcType.Common),
                    new ImageTemplate(ImagePath: $"{TempFolder}/{dataFile2}", ImageSrcType: ImageSrcType.Common)
                }
            );
            var response = PdfApi.PutImageInStorageToPdf(resultName, imageTemplatesRequest, dstFolder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetMarkdownInStorageToPdf
        /// </summary>
        [Test]
        public void GetMarkdownInStorageToPdfTest()
        {
            const string name = "mixed.md";
            UploadFile(name, name);

            using (var response = PdfApi.GetMarkdownInStorageToPdf(Path.Combine(TempFolder, name)))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutMarkdownInStorageToPdf
        /// </summary>
        [Test]
        public void PutMarkdownInStorageToPdfTest()
        {
            const string name = "mixed.md";
            UploadFile(name, name);
            string resultName = "md.pdf";

            var response = PdfApi.PutMarkdownInStorageToPdf(resultName, Path.Combine(TempFolder, name), dstFolder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPdfAInStorageToPdf
        /// </summary>
        [Test]
        public void GetPdfAInStorageToPdfTest()
        {
            const string name = "4pagesPdfA.pdf";
            UploadFile(name, name);

            using (var response = PdfApi.GetPdfAInStorageToPdf(Path.Combine(TempFolder, name)))
            {
                Assert.That(response.Length, Is.GreaterThan(0));
            }
        }

        /// <summary>
        /// Test PutPdfAInStorageToPdf
        /// </summary>
        [Test]
        public void PutPdfAInStorageToPdfTest()
        {
            const string name = "4pagesPdfA.pdf";
            UploadFile(name, name);
            string resultName = "pdf.pdf";

            var response = PdfApi.PutPdfAInStorageToPdf(resultName, Path.Combine(TempFolder, name), dstFolder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
