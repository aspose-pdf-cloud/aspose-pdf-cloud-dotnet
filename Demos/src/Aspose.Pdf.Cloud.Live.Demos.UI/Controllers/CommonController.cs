using Aspose.Pdf.Cloud.Live.Demos.UI.Models;
using Aspose.Pdf.Cloud.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Aspose.Pdf.Cloud.Sdk;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;

namespace Aspose.Pdf.Cloud.Live.Demos.UI.Controllers
{
	/// <summary>
	/// Common  API controller.
	/// </summary>
	public  class CommonController : BaseController
	{
		public override string Product => (string)RouteData.Values["product"];
		/// <summary>
		/// Sends back specified file from specified folder inside OutputDirectory.
		/// </summary>
		/// <param name="folder">Folder inside OutputDirectory.</param>
		/// <param name="file">File.</param>
		/// <returns>HTTP response with file.</returns>


		public FileResult DownloadFile(string file)
		{
			PdfApi pdfApi = new PdfApi(Config.Configuration.AppKey, Config.Configuration.AppSID);

			return File(pdfApi.DownloadFile(file), "application/octet-stream", file);
		}
		
		
	
	
		

		
	}
}
