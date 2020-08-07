using System;
using System.IO;
using System.Web.Http;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Drawing;
using System.Drawing.Imaging;

namespace  Aspose.Pdf.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeWordsCloudBase class to have base methods
	///</Summary>

	public abstract class AsposePdfCloudBase : ApiController
    {
		
		///<Summary>
		/// Get File extension
		///</Summary>
		protected string GetoutFileExtension(string fileName, string folderName)
        {
			string sourceFolder = Config.Configuration.WorkingDirectory + folderName;
            fileName = sourceFolder + "\\" + fileName;
            return Path.GetExtension(fileName);
        }
		
       
		
    }
}
