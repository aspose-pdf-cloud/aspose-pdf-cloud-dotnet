using Aspose.Pdf.Cloud.Sdk.Model;


namespace ChangeLayout
{
    public class ResizeDocumentAllPages
    {
        private ChangeLayoutHelper _helper;

        public ResizeDocumentAllPages(ChangeLayoutHelper helper)
        {
            _helper = helper;
        }

        public async Task MakeResizeDocumentAllPages(string document, string htmlTempDoc, int pageWidth, int pageHeight)
        {
            await _helper.UploadFile(document);
            string htmlTempPath = Path.Combine(_helper.config.REMOTE_TEMP_FOLDER, htmlTempDoc);
            AsposeResponse response = await _helper.pdfApi.PutPdfInStorageToHtmlAsync(
                document, htmlTempPath,
                documentType: HtmlDocumentType.Xhtml.ToString(),
                outputFormat: OutputFormat.Folder.ToString(),
                folder: _helper.config.REMOTE_TEMP_FOLDER
            );
            if (response == null)
                Console.WriteLine("MakeResizeDocumentAllPages(): Unexpected error - no response in Pdf to Html convert!");
            else if (response.Code != 200)
                Console.WriteLine("MakeResizeDocumentAllPages(): Error -> Code {0} -> Status '{1}'", [response.Code, response.Status]);
            else
            {
                Console.WriteLine("MakeResizeDocumentAllPages(): temporary file '{0}' successfully created.", htmlTempDoc);
                string outputDocument = "resized_" + document;
                await _helper.pdfApi.PutHtmlInStorageToPdfAsync(
                    outputDocument, htmlTempPath,
                    dstFolder: _helper.config.REMOTE_TEMP_FOLDER,
                    htmlFileName: htmlTempDoc,
                    height: pageHeight,
                    width: pageWidth
                );

                if (response == null)
                    Console.WriteLine("MakeResizeDocumentAllPages(): Unexpected error - no response in html to Pdf convert!");
                else if (response.Code != 200)
                    Console.WriteLine("MakeResizeDocumentAllPages(): Error -> Code {0} -> Status '{1}'", [response.Code, response.Status]);
                else
                {
                    Console.WriteLine("resizePages(): Pages successfully resized.");
                    await _helper.DownloadFile(outputDocument, "resized_doc_");
                }
            }

        }
    }
}