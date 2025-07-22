using Aspose.Pdf.Cloud.Sdk.Model;

namespace Merges
{
    public class MergeDocuments
    {
        public static async Task Merge(MergesHelper helper, List<string> files, string outputName, string remoteFolder)
        {
            Aspose.Pdf.Cloud.Sdk.Model.MergeDocuments documetItems = new(new List<string>());
   
            foreach (var file in files)
            {
                await helper.UploadFile(Path.GetFileName(file));
                documetItems.List.Add(Path.Combine( remoteFolder, file));
            }
  
            DocumentResponse response = await helper.pdfApi.PutMergeDocumentsAsync(outputName, documetItems, folder: remoteFolder);

            if (response == null)
                Console.WriteLine("MergeDocuments(): Unexpected error!");
            else if (response.Code < 200 || response.Code > 299)
                Console.WriteLine("MergeDocuments(): Failed to documents.");
            else
            {
                Console.WriteLine("MergeDocuments(): documents successfully merged to '{0}' file.", outputName);
                await helper.DownloadFile(outputName);
            }
        }
    }
}
