
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System;
using System.IO;

namespace Aspose.Pdf.Cloud.Sdk.ImageAPI
{

    public class ImagesExamples
    {
        private const string Name = "PdfWithImages2.pdf";

        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
        string FolderName = "";
        private string _imageId;
        private string ImageId
        {
            get
            {
                if (_imageId != null) return _imageId;

                var imagesResponse = api.GetImages(Name, pageNumber: 1, folder: FolderName);
                _imageId = imagesResponse.Images.List[0].Id;

                return _imageId;
            }
        }
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }



        public void GetImageTest()
        {
            var response = api.GetImage(Name, ImageId, folder: FolderName);
            Console.WriteLine(response);
        }



        public void DeleteImageTest()
        {
            var response = api.DeleteImage(Name, ImageId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetImagesTest()
        {
            var response = api.GetImages(Name, 1, folder: FolderName);
            Console.WriteLine(response);
        }
        

        public void PutReplaceImageTest()
        {
            const string imageName = "Koala.jpg";
            UploadFile(imageName, imageName);
            
            var response = api.PutReplaceImage(name: Name, imageId: ImageId, imageFilePath: Path.Combine(FolderName, imageName), folder: FolderName);
             Console.WriteLine(response);;
        }



        public void PostInsertImageTest()
        {
            const string imageName = "Koala.jpg";
            UploadFile(imageName, imageName);

            var response = api.PostInsertImage(name: Name, pageNumber: 1, llx: 10, lly:10, urx: 100, ury: 100, imageFilePath: Path.Combine(FolderName, imageName), folder: FolderName);
             Console.WriteLine(response);
        }


        public void PutImagesExtractAsJpegTest()
        {
            const int pageNumber = 1;
            const string destFolder = "extract_jpg";

            var response = api.PutImagesExtractAsJpeg(Name, pageNumber: pageNumber, 
                folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
             Console.WriteLine(response);
        }


        public void PutImagesExtractAsTiffTest()
        {
            const int pageNumber = 1;
            const string destFolder = "extract_tiff";

            var response = api.PutImagesExtractAsTiff(Name, pageNumber: pageNumber,
                folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
             Console.WriteLine(response);
        }

        public void PutImagesExtractAsGifTest()
        {
            const int pageNumber = 1;
            const string destFolder = "extract_gif";

            var response = api.PutImagesExtractAsGif(Name, pageNumber: pageNumber,
                folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
            Console.WriteLine(response);
        }


        public void PutImagesExtractAsPngTest()
        {
            const int pageNumber = 1;
            const string destFolder = "extract_png";

            var response = api.PutImagesExtractAsPng(Name, pageNumber: pageNumber,
                folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
             Console.WriteLine(response);
        }



        public void PutImageExtractAsJpegTest()
        {
            const string destFolder = "extract_jpg";
            var response = api.PutImageExtractAsJpeg(Name, ImageId, folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
             Console.WriteLine(response);
        }


        public void GetImageExtractAsJpegTest()
        {
            var response = api.GetImageExtractAsJpeg(Name, ImageId, folder: FolderName);
             Console.WriteLine(response);
        }


        public void PutImageExtractAsTiffTest()
        {
            const string destFolder = "extract_tiff";
            var response = api.PutImageExtractAsTiff(Name, ImageId, folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
             Console.WriteLine(response);
        }


        public void GetImageExtractAsTiffTest()
        {
            var response = api.GetImageExtractAsTiff(Name, ImageId, folder: FolderName);
             Console.WriteLine(response);
        }

 
        public void PutImageExtractAsGifTest()
        {
            const string destFolder = "extract_gif";
            var response = api.PutImageExtractAsGif(Name, ImageId, folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
            Console.WriteLine(response);
        }

        public void GetImageExtractAsGifTest()
        {
            var response = api.GetImageExtractAsGif(Name, ImageId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutImageExtractAsPngTest()
        {
            const string destFolder = "extract_png";
            var response = api.PutImageExtractAsPng(Name, ImageId, folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
            Console.WriteLine(response);
        }

    
        public void GetImageExtractAsPngTest()
        {
            var response = api.GetImageExtractAsPng(Name, ImageId, folder: FolderName);
             Console.WriteLine(response);
        }
    }
}