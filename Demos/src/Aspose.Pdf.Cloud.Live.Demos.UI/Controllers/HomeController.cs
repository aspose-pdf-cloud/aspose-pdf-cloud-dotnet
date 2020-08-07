using Aspose.Pdf.Cloud.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Pdf.Cloud.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Build PDF Generator &amp; Converter Cloud Apps (C# &amp; .NET SDK)";
			ViewBag.MetaDescription = "Aspose.PDF Cloud SDK for .NET enhances your C#, ASP.NET &amp; other .NET applications to create, edit, merge, split, digitally sign &amp; convert cloud PDF files.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
