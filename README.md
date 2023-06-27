![](https://img.shields.io/badge/api-v3.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/Aspose.pdf-Cloud) ![Nuget](https://img.shields.io/nuget/dt/Aspose.pdf-Cloud) [![GitHub license](https://img.shields.io/github/license/aspose-pdf-cloud/aspose-pdf-cloud-dotnet)](https://github.com/aspose-pdf-cloud/aspose-pdf-cloud-dotnet/blob/master/LICENSE)
# .NET REST API to Process PDF in Cloud
[Aspose.PDF Cloud](https://products.aspose.cloud/pdf) is a true REST API that enables you to perform a wide range of document processing operations including creation, manipulation, conversion and rendering of PDF documents in the cloud.

Our Cloud SDKs are wrappers around REST API in various programming languages, allowing you to process documents in language of your choice quickly and easily, gaining all benefits of strong types and IDE highlights. This repository contains new generation SDKs for Aspose.PDF Cloud and examples.

These SDKs are now fully supported. If you have any questions, see any bugs or have enhancement request, feel free to reach out to us at [Free Support Forums](https://forum.aspose.cloud/c/pdf).

Extract Text & Images of a PDF document online https://products.aspose.app/pdf/parser.

## PDF Processing Features
- Add PDF document's header & footer in text or image format.
- Add tables & stamps (text or image) to PDF documents.
- Append multiple PDF documents to an existing file.
- Work with PDF attachments, annotations, & form fields.
- Apply encryption or decryption to PDF documents & set a password.
- Delete all stamps & tables from a page or entire PDF document.
- Delete a specific stamp or table from the PDF document by its ID.
- Replace single or multiple instances of text on a PDF page or from the entire document.
- Extensive support for converting PDF documents to various other file formats.
- Extract various elements of PDF files & make PDF documents optimized.

## Read & Write PDF Formats
PDF, EPUB, HTML, TeX, SVG, XML, XPS, FDF, XFDF

## Save PDF As
XLS, XLSX, PPTX, DOC, DOCX, MobiXML, JPEG, EMF, PNG, BMP, GIF, TIFF, Text

## Read PDF Formats
MHT, PCL, PS, XSLFO, MD

## Enhancements in Version 23.6
- Support to convert password protected PDF documents to PPTX.
- A new version of Aspose.PDF Cloud was prepared using the latest version of Aspose.PDF for .NET.

## Bugs fixed in Version 23.6
- Text Replacement API constantly hitting 504 Gateway Timeout.

## Unit Tests
Aspose PDF SDK includes a suite of unit tests. These Unit Tests also serves as examples of how to use the Aspose PDF SDK.

## Licensing
All Aspose.Pdf for Cloud SDKs are licensed under [MIT License](LICENSE).

## Dependencies
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.12.0

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

## Convert PDF to Epub in Dotnet

```csharp
	// Get your ClientId and ClientSecret from https://dashboard.aspose.cloud (free registration required).
	var config = new Configuration
	{
		ClientId = "MY_CLIENT_ID",
		ClientSecret = "MY_CLIENT_SECRET",
		ApiBaseUrl = baseUrl,
	};

	var pdfApi = new PdfApi(config);

	using (var file = File.OpenRead(Path.Combine(TestDataFolder, "sample.pdf")))
	{
		var response = pdfApi.UploadFile(Path.Combine(TempFolder, serverFileName), file);
	}
			
	var response = pdfApi.GetPdfInStorageToEpub("sample.pdf", folder: TempFolder);
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)
