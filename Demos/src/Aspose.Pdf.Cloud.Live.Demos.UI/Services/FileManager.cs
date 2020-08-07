using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.IO;
using System.Diagnostics;
using System.Net.Http.Headers;
using Aspose.Pdf.Cloud.Live.Demos.UI.Config;
using Aspose.Pdf.Cloud.Live.Demos.UI.Models;
using Aspose.Pdf.Cloud.Sdk;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Net;
using System.Web.Http;

namespace Aspose.Pdf.Cloud.Live.Demos.UI.Services
{
    public static class FileManager
    {	

		public static FileUploadResult UploadFile( System.Web.HttpPostedFileBase postedFile)
		{
			FileUploadResult uploadResult = null;
			string fn = "";
			PdfApi pdfApi = new PdfApi(Config.Configuration.AppKey, Config.Configuration.AppSID);
			try
			{
				string folderName = Guid.NewGuid().ToString();

				// Prepare a path in which the result file will be
				string uploadPath = Config.Configuration.WorkingDirectory + "\\" + folderName;

				// Check directroy already exist or not
				if (!Directory.Exists(uploadPath))
					Directory.CreateDirectory(uploadPath);

				// Check if File is available.
				if (postedFile != null && postedFile.ContentLength > 0)
				{
					fn = System.IO.Path.GetFileName(postedFile.FileName);

					postedFile.SaveAs(uploadPath + "\\" + fn);
				}

				// Upload original document to Cloud Storage
				pdfApi.UploadFile(fn,File.Open(uploadPath + "\\" + fn, FileMode.Open), null);

				
				// Create response
				return new FileUploadResult
				{
					FileName = fn,
					FolderId = ""
				};
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			return uploadResult;
		}
		
		
       
		
	}
}
