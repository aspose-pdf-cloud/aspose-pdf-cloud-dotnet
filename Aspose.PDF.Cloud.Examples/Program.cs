using System;
using System.IO;
using Aspose.Pdf.Cloud.Sdk;
using Aspose.Pdf.Cloud.Sdk.Api;

namespace Aspose.PDF.Cloud.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfApi pdfApi = new PdfApi("API_KEY", "APP_SID");
           

            String imageName = "SampleImage.jpg";
            String fileName =  "PDFWithImages.pdf";
            int pageNumber = 1;
            
            double llx = 10.0;
            double lly = 10.0;
            double urx = 100.0;
            double ury = 100.0;
            
          
            String folder = "temp_folder_path";
            String imageFilePath = Path.Combine(folder, imageName);
            
            byte[] file = System.IO.File.ReadAllBytes("DATA_DIR_PATH" + imageName);

            try
            {
                // Upload source file to aspose cloud storage
                pdfApi.UploadFile(fileName,File.Open("..\\..\\..\\Resources\\" + imageName, FileMode.Open));

                // Invoke Aspose.PDF Cloud SDK API to replace image using image file
                var response = pdfApi.PostInsertImage(fileName, pageNumber, llx, lly, urx, ury, imageFilePath, folder);

                if (response != null && response.Status.Equals("OK"))
                {
                    Console.WriteLine("Added new image to PDF, Done!");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
