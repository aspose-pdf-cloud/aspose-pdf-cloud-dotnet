
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

        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
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
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }



        public void GetImageExample()
        { 
            //ExStart: GetImageExample
            var response = api.GetImage(Name, ImageId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetImageExample
        }



        public void DeleteImageExample()
        {
            //ExStart: DeleteImageExample
            var response = api.DeleteImage(Name, ImageId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: DeleteImageExample
        }


        public void GetImagesExample()
        {
            //ExStart: GetImagesExample
            var response = api.GetImages(Name, 1, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetImagesExample
        }
        

        public void PutReplaceImageExample()
        {
            //ExStart: PutReplaceImageExample
            const string imageName = "Koala.jpg";
            UploadFile(imageName, imageName);
            
            var response = api.PutReplaceImage(name: Name, imageId: ImageId, imageFilePath: Path.Combine(FolderName, imageName), folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: PutReplaceImageExample
        }

        public void PostInsertImageExample()
        {
            //ExStart: PostInsertImageExample
            const string imageName = "Koala.jpg";
            UploadFile(imageName, imageName);

            var response = api.PostInsertImage(name: Name, pageNumber: 1, llx: 10, lly:10, urx: 100, ury: 100, imageFilePath: Path.Combine(FolderName, imageName), folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: PostInsertImageExample
        }


        public void PutImagesExtractAsJpegExample()
        {
           //ExStart: PutImagesExtractAsJpegExample   
            const int pageNumber = 1;
            const string destFolder = "extract_jpg";

            var response = api.PutImagesExtractAsJpeg(Name, pageNumber: pageNumber, 
                folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
             Console.WriteLine(response);
             //ExEnd: PutImagesExtractAsJpegExample 
        }


        public void PutImagesExtractAsTiffExample()
        {
            //ExStart: PutImagesExtractAsTiffExample 
            const int pageNumber = 1;
            const string destFolder = "extract_tiff";

            var response = api.PutImagesExtractAsTiff(Name, pageNumber: pageNumber,
                folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
             Console.WriteLine(response);
             //ExEnd: PutImagesExtractAsTiffExample 
        }

        public void PutImagesExtractAsGifExample()
        {
            //ExStart: PutImagesExtractAsGifExample 
            const int pageNumber = 1;
            const string destFolder = "extract_gif";

            var response = api.PutImagesExtractAsGif(Name, pageNumber: pageNumber,
                folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
            Console.WriteLine(response);
             //ExEnd: PutImagesExtractAsGifExample 
        }


        public void PutImagesExtractAsPngExample()
        {
             //ExStart: PutImagesExtractAsPngExample 
            const int pageNumber = 1;
            const string destFolder = "extract_png";

            var response = api.PutImagesExtractAsPng(Name, pageNumber: pageNumber,
                folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
             Console.WriteLine(response);
              //ExEnd: PutImagesExtractAsPngExample 
        }



        public void PutImageExtractAsJpegExample()
        {
         //ExStart: PutImageExtractAsJpegExample    
            const string destFolder = "extract_jpg";
            var response = api.PutImageExtractAsJpeg(Name, ImageId, folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
             Console.WriteLine(response);
             //ExEnd: PutImageExtractAsJpegExample   
        }


        public void GetImageExtractAsJpegExample()
        {
            //ExStart: GetImageExtractAsJpegExample   
            var response = api.GetImageExtractAsJpeg(Name, ImageId, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: GetImageExtractAsJpegExample   
        }


        public void PutImageExtractAsTiffExample()
        {
            //ExStart: PutImageExtractAsTiffExample   
            const string destFolder = "extract_tiff";
            var response = api.PutImageExtractAsTiff(Name, ImageId, folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
             Console.WriteLine(response);
             //ExEnd: PutImageExtractAsTiffExample   
        }


        public void GetImageExtractAsTiffExample()
        {
             //ExStart: GetImageExtractAsTiffExample
            var response = api.GetImageExtractAsTiff(Name, ImageId, folder: FolderName);
             Console.WriteLine(response);
              //ExEnd: GetImageExtractAsTiffExample
        }

 
        public void PutImageExtractAsGifExample()
        {
            //ExStart: PutImageExtractAsGifExample
            const string destFolder = "extract_gif";
            var response = api.PutImageExtractAsGif(Name, ImageId, folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
            Console.WriteLine(response);
            //ExEnd: PutImageExtractAsGifExample
        }

        public void GetImageExtractAsGifExample()
        {
            //ExStart: GetImageExtractAsGifExample
            var response = api.GetImageExtractAsGif(Name, ImageId, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetImageExtractAsGifExample
        }


        public void PutImageExtractAsPngExample()
        {
            //ExStart: PutImageExtractAsPngExample
            const string destFolder = "extract_png";
            var response = api.PutImageExtractAsPng(Name, ImageId, folder: FolderName, destFolder: Path.Combine(FolderName, destFolder));
            Console.WriteLine(response);
            //ExEnd: PutImageExtractAsPngExample
        }

    
        public void GetImageExtractAsPngExample()
        {
            //ExStart: GetImageExtractAsPngExample
            var response = api.GetImageExtractAsPng(Name, ImageId, folder: FolderName);
             Console.WriteLine(response);
             //ExEnd: GetImageExtractAsPngExample
        }
    }
}