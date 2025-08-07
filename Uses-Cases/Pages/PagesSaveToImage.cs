namespace Pages
{
    public class PagesSaveToImage
    {
        public static async Task ExtractPNG(PagesHelper helper, string documentName, int pageNumber, string outputPNG, string remoteFolder)
        {
            await helper.UploadFile(documentName);

            Stream stream = await helper.pdfApi.GetPageConvertToPngAsync(documentName, pageNumber, folder: remoteFolder);

            if (stream == null)
                Console.WriteLine("PagesSaveToImage(): Unexpected error!");
            else
            {
                Console.WriteLine("PagesSaveToImage(): page successfully converted to image.");
                using var fileStream = File.Create(outputPNG);
                stream.Position = 0;
                await stream.CopyToAsync(fileStream);
                Console.WriteLine("DownloadFile(): File '{0}' successfully downloaded.", outputPNG);
            }
        }
    }
}
