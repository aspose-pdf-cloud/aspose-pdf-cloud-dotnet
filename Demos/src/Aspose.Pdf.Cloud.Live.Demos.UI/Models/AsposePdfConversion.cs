
using System.Threading.Tasks;
using System.IO;
using System.Web.Http;
using Aspose.Pdf.Cloud.Live.Demos.UI.Models;
using Aspose.Pdf.Cloud.Sdk;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Diagnostics;

namespace Aspose.Pdf.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// Aspose.PDF Cloud API convert method to convert word document file to other format
	///</Summary>
	
	public class AsposePdfConversion : AsposePdfCloudBase
    {        
        
		///<Summary>
		/// Convert method to convert PDF file to other format
		///</Summary>
		public Response Convert(string fileName,  string outputType)
        {	

			PdfApi pdfApi = new PdfApi(Config.Configuration.AppKey, Config.Configuration.AppSID);
			string fileNamewithOutExtension = Path.GetFileNameWithoutExtension(fileName);
			string fileExtension = Path.GetExtension(fileName);
			fileExtension = fileExtension.Replace(".", "").Trim().ToLower();
			string outputFileName = fileNamewithOutExtension + "." + outputType;			
			
			if (pdfApi != null)
			{
				AsposeResponse response = null;
				if ((outputType.Equals("pdf")) && (fileExtension.Equals("epub") || fileExtension.Equals("latex") || fileExtension.Equals("mht") || fileExtension.Equals("html") || fileExtension.Equals("ps") || fileExtension.Equals("xps") || fileExtension.Equals("svg")   || fileExtension.Equals("pcl") || fileExtension.Equals("xml")))
				{
					switch (fileExtension)
					{
						case "epub":
							response = pdfApi.PutEpubInStorageToPdf(fileName, outputFileName);
							break;
						case "latex":
							response = pdfApi.PutLaTeXInStorageToPdf(fileName, outputFileName);
							break;
						case "mht":
							response = pdfApi.PutMhtInStorageToPdf(fileName, outputFileName);
							break;
						case "html":
							response = pdfApi.PutHtmlInStorageToPdf(fileName, outputFileName);
							break;
						case "ps":
							response = pdfApi.PutPsInStorageToPdf(fileName, outputFileName);
							break;
						case "xps":
							response = pdfApi.PutXpsInStorageToPdf(fileName, outputFileName);
							break;
						case "svg":
							response = pdfApi.PutSvgInStorageToPdf(fileName, outputFileName);
							break;
						case "pcl":
							response = pdfApi.PutPclInStorageToPdf(fileName, outputFileName);
							break;
						case "xml":
							response = pdfApi.PutXmlInStorageToPdf(fileName, outputFileName);
							break;
					}
				}
				else if (outputType.Equals("jpeg") || outputType.Equals("emf") || outputType.Equals("png") || outputType.Equals("bmp") || outputType.Equals("gif"))
				{
					// Invoke Aspose.PDF Cloud SDK API to get page count from pdf document
					DocumentPagesResponse apiResponse = pdfApi.GetPages(fileName, storage: null, folder: null);

					if (apiResponse != null && apiResponse.Status.Equals("OK"))
					{
						int count = apiResponse.Pages.List.Count;
						int pageNumber = 0;
						for (int i = 0; i < count; i++)
						{
							pageNumber = i + 1;
							outputFileName = Path.Combine(fileNamewithOutExtension, "Page_" + pageNumber + "." + outputType);

							switch (outputType)
							{
								case "jpeg":
									response = pdfApi.PutPageConvertToJpeg(fileName, pageNumber, outputFileName, width: null, height: null, folder: null, storage: null);
									break;
								case "emf":
									response = pdfApi.PutPageConvertToEmf(fileName, pageNumber, outputFileName, width: null, height: null, folder: null, storage: null);
									break;
								case "png":
									response = pdfApi.PutPageConvertToPng(fileName, pageNumber, outputFileName, width: null, height: null, folder: null, storage: null);
									break;
								case "bmp":
									response = pdfApi.PutPageConvertToBmp(fileName, pageNumber, outputFileName, width: null, height: null, folder: null, storage: null);
									break;
								case "gif":
									response = pdfApi.PutPageConvertToGif(fileName, pageNumber, outputFileName, width: null, height: null, folder: null, storage: null);
									break;
							}
						}
					}

				}
				else
				{
					switch (outputType)
					{
						case "xls":
							response = pdfApi.PutPdfInStorageToXls(fileName, outputFileName, folder: null);
							break;
						case "xlsx":
							response = pdfApi.PutPdfInStorageToXlsx(fileName, outputFileName, folder: null);
							break;
						case "pptx":
							response = pdfApi.PutPdfInStorageToPptx(fileName, outputFileName, folder: null);
							break;
						case "doc":
							response = pdfApi.PutPdfInStorageToDoc(fileName, outputFileName, folder: null);
							break;
						case "epub":
							response = pdfApi.PutPdfInStorageToEpub(fileName, outputFileName, folder: null);
							break;
						case "html":
							response = pdfApi.PutPdfInStorageToHtml(fileName, outputFileName, folder: null);
							break;
						case "tex":
							response = pdfApi.PutPdfInStorageToTeX(fileName, outputFileName, folder: null);
							break;
						case "svg":
							response = pdfApi.PutPdfInStorageToSvg(fileName, outputFileName, folder: null);
							break;
						case "latex":
							response = pdfApi.PutPdfInStorageToLaTeX(fileName, outputFileName, folder: null);
							break;
						case "tiff":
							response = pdfApi.PutPdfInStorageToTiff(fileName, outputFileName, folder: null);
							break;
						case "xml":
							response = pdfApi.PutPdfInStorageToXml(fileName, outputFileName, folder: null);
							break;
						case "xps":
							response = pdfApi.PutPdfInStorageToXps(fileName, outputFileName, folder: null);
							break;
						case "text":
							response = pdfApi.PutPdfInStorageToTeX(fileName, outputFileName, folder: null);
							break;
					}
				}
				
					return new Response
					{

						FileName = outputFileName,
						Status = "OK",
						StatusCode = 200,
					};
				
			}
			return new Response
			{
				FileName = null,
				Status = "Output type not found",
				StatusCode = 500
			};
		}
		
    }
}
