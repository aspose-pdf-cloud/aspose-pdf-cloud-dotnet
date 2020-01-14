// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImagesTests.cs">
//   Copyright (c) 2020 Aspose.PDF Cloud
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

using System.IO;
using System.Net;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Images Api
    /// </summary>
    [TestFixture]
    public class ImagesTests : TestsBase
    {
        private const string Name = "PdfWithImages2.pdf";

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        private string _imageId;
        private string ImageId
        {
            get
            {
                if (_imageId != null) return _imageId;

                var imagesResponse = PdfApi.GetImages(Name, pageNumber: 1, folder: TempFolder);
                Assert.That(imagesResponse.Code, Is.EqualTo(200));
                _imageId = imagesResponse.Images.List[0].Id;

                return _imageId;
            }
        }
        

        /// <summary>
        /// Test GetImage
        /// </summary>
        [Test]
        public void GetImageTest()
        {
            var response = PdfApi.GetImage(Name, ImageId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test DeleteImage
        /// </summary>
        [Test]
        public void DeleteImageTest()
        {
            var response = PdfApi.DeleteImage(Name, ImageId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetImages
        /// </summary>
        [Test]
        public void GetImagesTest()
        {
            var response = PdfApi.GetImages(Name, 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
        /// <summary>
        /// Test PostReplaceImage
        /// </summary>
        [Test]
        public void PutReplaceImageTest()
        {
            const string imageName = "Koala.jpg";
            UploadFile(imageName, imageName);
            
            var response = PdfApi.PutReplaceImage(name: Name, imageId: ImageId, imageFilePath: Path.Combine(TempFolder, imageName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test PostInsertImage
        /// </summary>
        [Test]
        public void PostInsertImageTest()
        {
            const string imageName = "Koala.jpg";
            UploadFile(imageName, imageName);

            var response = PdfApi.PostInsertImage(name: Name, pageNumber: 1, llx: 10, lly:10, urx: 100, ury: 100, imageFilePath: Path.Combine(TempFolder, imageName), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutImagesExtractAsJpeg
        /// </summary>
        [Test]
        public void PutImagesExtractAsJpegTest()
        {
            const int pageNumber = 1;
            const string destFolder = "extract_jpg";

            var response = PdfApi.PutImagesExtractAsJpeg(Name, pageNumber: pageNumber, 
                folder: TempFolder, destFolder: Path.Combine(TempFolder, destFolder));
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutImagesExtractAsTiff
        /// </summary>
        [Test]
        public void PutImagesExtractAsTiffTest()
        {
            const int pageNumber = 1;
            const string destFolder = "extract_tiff";

            var response = PdfApi.PutImagesExtractAsTiff(Name, pageNumber: pageNumber,
                folder: TempFolder, destFolder: Path.Combine(TempFolder, destFolder));
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutImagesExtractAsGif
        /// </summary>
        [Test]
        public void PutImagesExtractAsGifTest()
        {
            const int pageNumber = 1;
            const string destFolder = "extract_gif";

            var response = PdfApi.PutImagesExtractAsGif(Name, pageNumber: pageNumber,
                folder: TempFolder, destFolder: Path.Combine(TempFolder, destFolder));
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutImagesExtractAsPng
        /// </summary>
        [Test]
        public void PutImagesExtractAsPngTest()
        {
            const int pageNumber = 1;
            const string destFolder = "extract_png";

            var response = PdfApi.PutImagesExtractAsPng(Name, pageNumber: pageNumber,
                folder: TempFolder, destFolder: Path.Combine(TempFolder, destFolder));
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test PutImageExtractAsJpeg
        /// </summary>
        [Test]
        public void PutImageExtractAsJpegTest()
        {
            const string destFolder = "extract_jpg";
            var response = PdfApi.PutImageExtractAsJpeg(Name, ImageId, folder: TempFolder, destFolder: Path.Combine(TempFolder, destFolder));
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetImageExtractAsJpeg
        /// </summary>
        [Test]
        public void GetImageExtractAsJpegTest()
        {
            var response = PdfApi.GetImageExtractAsJpeg(Name, ImageId, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutImageExtractAsTiff
        /// </summary>
        [Test]
        public void PutImageExtractAsTiffTest()
        {
            const string destFolder = "extract_tiff";
            var response = PdfApi.PutImageExtractAsTiff(Name, ImageId, folder: TempFolder, destFolder: Path.Combine(TempFolder, destFolder));
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetImageExtractAsTiff
        /// </summary>
        [Test]
        public void GetImageExtractAsTiffTest()
        {
            var response = PdfApi.GetImageExtractAsTiff(Name, ImageId, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutImageExtractAsGif
        /// </summary>
        [Test]
        public void PutImageExtractAsGifTest()
        {
            const string destFolder = "extract_gif";
            var response = PdfApi.PutImageExtractAsGif(Name, ImageId, folder: TempFolder, destFolder: Path.Combine(TempFolder, destFolder));
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetImageExtractAsGif
        /// </summary>
        [Test]
        public void GetImageExtractAsGifTest()
        {
            var response = PdfApi.GetImageExtractAsGif(Name, ImageId, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test PutImageExtractAsPng
        /// </summary>
        [Test]
        public void PutImageExtractAsPngTest()
        {
            const string destFolder = "extract_png";
            var response = PdfApi.PutImageExtractAsPng(Name, ImageId, folder: TempFolder, destFolder: Path.Combine(TempFolder, destFolder));
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetImageExtractAsPng
        /// </summary>
        [Test]
        public void GetImageExtractAsPngTest()
        {
            var response = PdfApi.GetImageExtractAsPng(Name, ImageId, folder: TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }
    }
}
