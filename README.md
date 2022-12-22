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

## Enhancements in Version 22.12
- A new version of Aspose.PDF Cloud was prepared using the latest version of Aspose.PDF for .NET.

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.aspose.cloud/v3.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PdfApi* | [**CopyFile**](docs/PdfApi.md#copyfile) | **PUT** /pdf/storage/file/copy/\{srcPath} | Copy file
*PdfApi* | [**CopyFolder**](docs/PdfApi.md#copyfolder) | **PUT** /pdf/storage/folder/copy/\{srcPath} | Copy folder
*PdfApi* | [**CreateFolder**](docs/PdfApi.md#createfolder) | **PUT** /pdf/storage/folder/\{path} | Create the folder
*PdfApi* | [**DeleteAnnotation**](docs/PdfApi.md#deleteannotation) | **DELETE** /pdf/\{name}/annotations/\{annotationId} | Delete document annotation by ID
*PdfApi* | [**DeleteBookmark**](docs/PdfApi.md#deletebookmark) | **DELETE** /pdf/\{name}/bookmarks/bookmark/\{bookmarkPath} | Delete document bookmark by ID.
*PdfApi* | [**DeleteDocumentAnnotations**](docs/PdfApi.md#deletedocumentannotations) | **DELETE** /pdf/\{name}/annotations | Delete all annotations from the document
*PdfApi* | [**DeleteDocumentBookmarks**](docs/PdfApi.md#deletedocumentbookmarks) | **DELETE** /pdf/\{name}/bookmarks/tree | Delete all document bookmarks.
*PdfApi* | [**DeleteDocumentLinkAnnotations**](docs/PdfApi.md#deletedocumentlinkannotations) | **DELETE** /pdf/\{name}/links | Delete all link annotations from the document
*PdfApi* | [**DeleteDocumentStamps**](docs/PdfApi.md#deletedocumentstamps) | **DELETE** /pdf/\{name}/stamps | Delete all stamps from the document
*PdfApi* | [**DeleteDocumentTables**](docs/PdfApi.md#deletedocumenttables) | **DELETE** /pdf/\{name}/tables | Delete all tables from the document
*PdfApi* | [**DeleteField**](docs/PdfApi.md#deletefield) | **DELETE** /pdf/\{name}/fields/\{fieldName} | Delete document field by name.
*PdfApi* | [**DeleteFile**](docs/PdfApi.md#deletefile) | **DELETE** /pdf/storage/file/\{path} | Delete file
*PdfApi* | [**DeleteFolder**](docs/PdfApi.md#deletefolder) | **DELETE** /pdf/storage/folder/\{path} | Delete folder
*PdfApi* | [**DeleteImage**](docs/PdfApi.md#deleteimage) | **DELETE** /pdf/\{name}/images/\{imageId} | Delete image from document page.
*PdfApi* | [**DeleteLinkAnnotation**](docs/PdfApi.md#deletelinkannotation) | **DELETE** /pdf/\{name}/links/\{linkId} | Delete document page link annotation by ID
*PdfApi* | [**DeletePage**](docs/PdfApi.md#deletepage) | **DELETE** /pdf/\{name}/pages/\{pageNumber} | Delete document page by its number.
*PdfApi* | [**DeletePageAnnotations**](docs/PdfApi.md#deletepageannotations) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/annotations | Delete all annotations from the page
*PdfApi* | [**DeletePageLinkAnnotations**](docs/PdfApi.md#deletepagelinkannotations) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/links | Delete all link annotations from the page
*PdfApi* | [**DeletePageStamps**](docs/PdfApi.md#deletepagestamps) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/stamps | Delete all stamps from the page
*PdfApi* | [**DeletePageTables**](docs/PdfApi.md#deletepagetables) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/tables | Delete all tables from the page
*PdfApi* | [**DeleteProperties**](docs/PdfApi.md#deleteproperties) | **DELETE** /pdf/\{name}/documentproperties | Delete custom document properties.
*PdfApi* | [**DeleteProperty**](docs/PdfApi.md#deleteproperty) | **DELETE** /pdf/\{name}/documentproperties/\{propertyName} | Delete document property.
*PdfApi* | [**DeleteStamp**](docs/PdfApi.md#deletestamp) | **DELETE** /pdf/\{name}/stamps/\{stampId} | Delete document stamp by ID
*PdfApi* | [**DeleteTable**](docs/PdfApi.md#deletetable) | **DELETE** /pdf/\{name}/tables/\{tableId} | Delete document table by ID
*PdfApi* | [**DownloadFile**](docs/PdfApi.md#downloadfile) | **GET** /pdf/storage/file/\{path} | Download file
*PdfApi* | [**GetBookmark**](docs/PdfApi.md#getbookmark) | **GET** /pdf/\{name}/bookmarks/bookmark/\{bookmarkPath} | Read document bookmark.
*PdfApi* | [**GetBookmarks**](docs/PdfApi.md#getbookmarks) | **GET** /pdf/\{name}/bookmarks/list/\{bookmarkPath} | Read document bookmarks node list.
*PdfApi* | [**GetCaretAnnotation**](docs/PdfApi.md#getcaretannotation) | **GET** /pdf/\{name}/annotations/caret/\{annotationId} | Read document page caret annotation by ID.
*PdfApi* | [**GetCheckBoxField**](docs/PdfApi.md#getcheckboxfield) | **GET** /pdf/\{name}/fields/checkbox/\{fieldName} | Read document checkbox field by name.
*PdfApi* | [**GetCircleAnnotation**](docs/PdfApi.md#getcircleannotation) | **GET** /pdf/\{name}/annotations/circle/\{annotationId} | Read document page circle annotation by ID.
*PdfApi* | [**GetComboBoxField**](docs/PdfApi.md#getcomboboxfield) | **GET** /pdf/\{name}/fields/combobox/\{fieldName} | Read document combobox field by name.
*PdfApi* | [**GetDiscUsage**](docs/PdfApi.md#getdiscusage) | **GET** /pdf/storage/disc | Get disc usage
*PdfApi* | [**GetDocument**](docs/PdfApi.md#getdocument) | **GET** /pdf/\{name} | Read common document info.
*PdfApi* | [**GetDocumentAnnotations**](docs/PdfApi.md#getdocumentannotations) | **GET** /pdf/\{name}/annotations | Read document page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
*PdfApi* | [**GetDocumentAttachmentByIndex**](docs/PdfApi.md#getdocumentattachmentbyindex) | **GET** /pdf/\{name}/attachments/\{attachmentIndex} | Read document attachment info by its index.
*PdfApi* | [**GetDocumentAttachments**](docs/PdfApi.md#getdocumentattachments) | **GET** /pdf/\{name}/attachments | Read document attachments info.
*PdfApi* | [**GetDocumentBookmarks**](docs/PdfApi.md#getdocumentbookmarks) | **GET** /pdf/\{name}/bookmarks/tree | Read document bookmarks tree.
*PdfApi* | [**GetDocumentCaretAnnotations**](docs/PdfApi.md#getdocumentcaretannotations) | **GET** /pdf/\{name}/annotations/caret | Read document caret annotations.
*PdfApi* | [**GetDocumentCheckBoxFields**](docs/PdfApi.md#getdocumentcheckboxfields) | **GET** /pdf/\{name}/fields/checkbox | Read document checkbox fields.
*PdfApi* | [**GetDocumentCircleAnnotations**](docs/PdfApi.md#getdocumentcircleannotations) | **GET** /pdf/\{name}/annotations/circle | Read document circle annotations.
*PdfApi* | [**GetDocumentComboBoxFields**](docs/PdfApi.md#getdocumentcomboboxfields) | **GET** /pdf/\{name}/fields/combobox | Read document combobox fields.
*PdfApi* | [**GetDocumentDisplayProperties**](docs/PdfApi.md#getdocumentdisplayproperties) | **GET** /pdf/\{name}/displayproperties | Read document display properties.
*PdfApi* | [**GetDocumentFileAttachmentAnnotations**](docs/PdfApi.md#getdocumentfileattachmentannotations) | **GET** /pdf/\{name}/annotations/fileattachment | Read document FileAttachment annotations.
*PdfApi* | [**GetDocumentFreeTextAnnotations**](docs/PdfApi.md#getdocumentfreetextannotations) | **GET** /pdf/\{name}/annotations/freetext | Read document free text annotations.
*PdfApi* | [**GetDocumentHighlightAnnotations**](docs/PdfApi.md#getdocumenthighlightannotations) | **GET** /pdf/\{name}/annotations/highlight | Read document highlight annotations.
*PdfApi* | [**GetDocumentInkAnnotations**](docs/PdfApi.md#getdocumentinkannotations) | **GET** /pdf/\{name}/annotations/ink | Read document ink annotations.
*PdfApi* | [**GetDocumentLineAnnotations**](docs/PdfApi.md#getdocumentlineannotations) | **GET** /pdf/\{name}/annotations/line | Read document line annotations.
*PdfApi* | [**GetDocumentListBoxFields**](docs/PdfApi.md#getdocumentlistboxfields) | **GET** /pdf/\{name}/fields/listbox | Read document listbox fields.
*PdfApi* | [**GetDocumentMovieAnnotations**](docs/PdfApi.md#getdocumentmovieannotations) | **GET** /pdf/\{name}/annotations/movie | Read document movie annotations.
*PdfApi* | [**GetDocumentPolyLineAnnotations**](docs/PdfApi.md#getdocumentpolylineannotations) | **GET** /pdf/\{name}/annotations/polyline | Read document polyline annotations.
*PdfApi* | [**GetDocumentPolygonAnnotations**](docs/PdfApi.md#getdocumentpolygonannotations) | **GET** /pdf/\{name}/annotations/polygon | Read document polygon annotations.
*PdfApi* | [**GetDocumentPopupAnnotations**](docs/PdfApi.md#getdocumentpopupannotations) | **GET** /pdf/\{name}/annotations/popup | Read document popup annotations.
*PdfApi* | [**GetDocumentPopupAnnotationsByParent**](docs/PdfApi.md#getdocumentpopupannotationsbyparent) | **GET** /pdf/\{name}/annotations/\{annotationId}/popup | Read document popup annotations by parent id.
*PdfApi* | [**GetDocumentProperties**](docs/PdfApi.md#getdocumentproperties) | **GET** /pdf/\{name}/documentproperties | Read document properties.
*PdfApi* | [**GetDocumentProperty**](docs/PdfApi.md#getdocumentproperty) | **GET** /pdf/\{name}/documentproperties/\{propertyName} | Read document property by name.
*PdfApi* | [**GetDocumentRadioButtonFields**](docs/PdfApi.md#getdocumentradiobuttonfields) | **GET** /pdf/\{name}/fields/radiobutton | Read document radiobutton fields.
*PdfApi* | [**GetDocumentRedactionAnnotations**](docs/PdfApi.md#getdocumentredactionannotations) | **GET** /pdf/\{name}/annotations/redaction | Read document redaction annotations.
*PdfApi* | [**GetDocumentScreenAnnotations**](docs/PdfApi.md#getdocumentscreenannotations) | **GET** /pdf/\{name}/annotations/screen | Read document screen annotations.
*PdfApi* | [**GetDocumentSignatureFields**](docs/PdfApi.md#getdocumentsignaturefields) | **GET** /pdf/\{name}/fields/signature | Read document signature fields.
*PdfApi* | [**GetDocumentSoundAnnotations**](docs/PdfApi.md#getdocumentsoundannotations) | **GET** /pdf/\{name}/annotations/sound | Read document sound annotations.
*PdfApi* | [**GetDocumentSquareAnnotations**](docs/PdfApi.md#getdocumentsquareannotations) | **GET** /pdf/\{name}/annotations/square | Read document square annotations.
*PdfApi* | [**GetDocumentSquigglyAnnotations**](docs/PdfApi.md#getdocumentsquigglyannotations) | **GET** /pdf/\{name}/annotations/squiggly | Read document squiggly annotations.
*PdfApi* | [**GetDocumentStampAnnotations**](docs/PdfApi.md#getdocumentstampannotations) | **GET** /pdf/\{name}/annotations/stamp | Read document stamp annotations.
*PdfApi* | [**GetDocumentStamps**](docs/PdfApi.md#getdocumentstamps) | **GET** /pdf/\{name}/stamps | Read document stamps.
*PdfApi* | [**GetDocumentStrikeOutAnnotations**](docs/PdfApi.md#getdocumentstrikeoutannotations) | **GET** /pdf/\{name}/annotations/strikeout | Read document StrikeOut annotations.
*PdfApi* | [**GetDocumentTables**](docs/PdfApi.md#getdocumenttables) | **GET** /pdf/\{name}/tables | Read document tables.
*PdfApi* | [**GetDocumentTextAnnotations**](docs/PdfApi.md#getdocumenttextannotations) | **GET** /pdf/\{name}/annotations/text | Read document text annotations.
*PdfApi* | [**GetDocumentTextBoxFields**](docs/PdfApi.md#getdocumenttextboxfields) | **GET** /pdf/\{name}/fields/textbox | Read document text box fields.
*PdfApi* | [**GetDocumentUnderlineAnnotations**](docs/PdfApi.md#getdocumentunderlineannotations) | **GET** /pdf/\{name}/annotations/underline | Read document underline annotations.
*PdfApi* | [**GetDownloadDocumentAttachmentByIndex**](docs/PdfApi.md#getdownloaddocumentattachmentbyindex) | **GET** /pdf/\{name}/attachments/\{attachmentIndex}/download | Download document attachment content by its index.
*PdfApi* | [**GetEpubInStorageToPdf**](docs/PdfApi.md#getepubinstoragetopdf) | **GET** /pdf/create/epub | Convert EPUB file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetExportFieldsFromPdfToFdfInStorage**](docs/PdfApi.md#getexportfieldsfrompdftofdfinstorage) | **GET** /pdf/\{name}/export/fdf | Export fields from from PDF in storage to FDF file.
*PdfApi* | [**GetExportFieldsFromPdfToXfdfInStorage**](docs/PdfApi.md#getexportfieldsfrompdftoxfdfinstorage) | **GET** /pdf/\{name}/export/xfdf | Export fields from from PDF in storage to XFDF file.
*PdfApi* | [**GetExportFieldsFromPdfToXmlInStorage**](docs/PdfApi.md#getexportfieldsfrompdftoxmlinstorage) | **GET** /pdf/\{name}/export/xml | Export fields from from PDF in storage to XML file.
*PdfApi* | [**GetField**](docs/PdfApi.md#getfield) | **GET** /pdf/\{name}/fields/\{fieldName} | Get document field by name.
*PdfApi* | [**GetFields**](docs/PdfApi.md#getfields) | **GET** /pdf/\{name}/fields | Get document fields.
*PdfApi* | [**GetFileAttachmentAnnotation**](docs/PdfApi.md#getfileattachmentannotation) | **GET** /pdf/\{name}/annotations/fileattachment/\{annotationId} | Read document page FileAttachment annotation by ID.
*PdfApi* | [**GetFileAttachmentAnnotationData**](docs/PdfApi.md#getfileattachmentannotationdata) | **GET** /pdf/\{name}/annotations/fileattachment/\{annotationId}/data | Read document page FileAttachment annotation by ID.
*PdfApi* | [**GetFileVersions**](docs/PdfApi.md#getfileversions) | **GET** /pdf/storage/version/\{path} | Get file versions
*PdfApi* | [**GetFilesList**](docs/PdfApi.md#getfileslist) | **GET** /pdf/storage/folder/\{path} | Get all files and folders within a folder
*PdfApi* | [**GetFreeTextAnnotation**](docs/PdfApi.md#getfreetextannotation) | **GET** /pdf/\{name}/annotations/freetext/\{annotationId} | Read document page free text annotation by ID.
*PdfApi* | [**GetHighlightAnnotation**](docs/PdfApi.md#gethighlightannotation) | **GET** /pdf/\{name}/annotations/highlight/\{annotationId} | Read document page highlight annotation by ID.
*PdfApi* | [**GetHtmlInStorageToPdf**](docs/PdfApi.md#gethtmlinstoragetopdf) | **GET** /pdf/create/html | Convert HTML file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetImage**](docs/PdfApi.md#getimage) | **GET** /pdf/\{name}/images/\{imageId} | Read document image by ID.
*PdfApi* | [**GetImageExtractAsGif**](docs/PdfApi.md#getimageextractasgif) | **GET** /pdf/\{name}/images/\{imageId}/extract/gif | Extract document image in GIF format
*PdfApi* | [**GetImageExtractAsJpeg**](docs/PdfApi.md#getimageextractasjpeg) | **GET** /pdf/\{name}/images/\{imageId}/extract/jpeg | Extract document image in JPEG format
*PdfApi* | [**GetImageExtractAsPng**](docs/PdfApi.md#getimageextractaspng) | **GET** /pdf/\{name}/images/\{imageId}/extract/png | Extract document image in PNG format
*PdfApi* | [**GetImageExtractAsTiff**](docs/PdfApi.md#getimageextractastiff) | **GET** /pdf/\{name}/images/\{imageId}/extract/tiff | Extract document image in TIFF format
*PdfApi* | [**GetImages**](docs/PdfApi.md#getimages) | **GET** /pdf/\{name}/pages/\{pageNumber}/images | Read document images.
*PdfApi* | [**GetImportFieldsFromFdfInStorage**](docs/PdfApi.md#getimportfieldsfromfdfinstorage) | **GET** /pdf/\{name}/import/fdf | Update fields from FDF file in storage.
*PdfApi* | [**GetImportFieldsFromXfdfInStorage**](docs/PdfApi.md#getimportfieldsfromxfdfinstorage) | **GET** /pdf/\{name}/import/xfdf | Update fields from XFDF file in storage.
*PdfApi* | [**GetImportFieldsFromXmlInStorage**](docs/PdfApi.md#getimportfieldsfromxmlinstorage) | **GET** /pdf/\{name}/import/xml | Import from XML file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetInkAnnotation**](docs/PdfApi.md#getinkannotation) | **GET** /pdf/\{name}/annotations/ink/\{annotationId} | Read document page ink annotation by ID.
*PdfApi* | [**GetLineAnnotation**](docs/PdfApi.md#getlineannotation) | **GET** /pdf/\{name}/annotations/line/\{annotationId} | Read document page line annotation by ID.
*PdfApi* | [**GetLinkAnnotation**](docs/PdfApi.md#getlinkannotation) | **GET** /pdf/\{name}/links/\{linkId} | Read document link annotation by ID.
*PdfApi* | [**GetListBoxField**](docs/PdfApi.md#getlistboxfield) | **GET** /pdf/\{name}/fields/listbox/\{fieldName} | Read document listbox field by name.
*PdfApi* | [**GetMarkdownInStorageToPdf**](docs/PdfApi.md#getmarkdowninstoragetopdf) | **GET** /pdf/create/markdown | Convert MD file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetMhtInStorageToPdf**](docs/PdfApi.md#getmhtinstoragetopdf) | **GET** /pdf/create/mht | Convert MHT file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetMovieAnnotation**](docs/PdfApi.md#getmovieannotation) | **GET** /pdf/\{name}/annotations/movie/\{annotationId} | Read document page movie annotation by ID.
*PdfApi* | [**GetPage**](docs/PdfApi.md#getpage) | **GET** /pdf/\{name}/pages/\{pageNumber} | Read document page info.
*PdfApi* | [**GetPageAnnotations**](docs/PdfApi.md#getpageannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations | Read document page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
*PdfApi* | [**GetPageCaretAnnotations**](docs/PdfApi.md#getpagecaretannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/caret | Read document page caret annotations.
*PdfApi* | [**GetPageCheckBoxFields**](docs/PdfApi.md#getpagecheckboxfields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/checkbox | Read document page checkbox fields.
*PdfApi* | [**GetPageCircleAnnotations**](docs/PdfApi.md#getpagecircleannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/circle | Read document page circle annotations.
*PdfApi* | [**GetPageComboBoxFields**](docs/PdfApi.md#getpagecomboboxfields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/combobox | Read document page combobox fields.
*PdfApi* | [**GetPageConvertToBmp**](docs/PdfApi.md#getpageconverttobmp) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/bmp | Convert document page to Bmp image and return resulting file in response.
*PdfApi* | [**GetPageConvertToEmf**](docs/PdfApi.md#getpageconverttoemf) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/emf | Convert document page to Emf image and return resulting file in response.
*PdfApi* | [**GetPageConvertToGif**](docs/PdfApi.md#getpageconverttogif) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/gif | Convert document page to Gif image and return resulting file in response.
*PdfApi* | [**GetPageConvertToJpeg**](docs/PdfApi.md#getpageconverttojpeg) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/jpeg | Convert document page to Jpeg image and return resulting file in response.
*PdfApi* | [**GetPageConvertToPng**](docs/PdfApi.md#getpageconverttopng) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/png | Convert document page to Png image and return resulting file in response.
*PdfApi* | [**GetPageConvertToTiff**](docs/PdfApi.md#getpageconverttotiff) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/tiff | Convert document page to Tiff image  and return resulting file in response.
*PdfApi* | [**GetPageFileAttachmentAnnotations**](docs/PdfApi.md#getpagefileattachmentannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/fileattachment | Read document page FileAttachment annotations.
*PdfApi* | [**GetPageFreeTextAnnotations**](docs/PdfApi.md#getpagefreetextannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/freetext | Read document page free text annotations.
*PdfApi* | [**GetPageHighlightAnnotations**](docs/PdfApi.md#getpagehighlightannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/highlight | Read document page highlight annotations.
*PdfApi* | [**GetPageInkAnnotations**](docs/PdfApi.md#getpageinkannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/ink | Read document page ink annotations.
*PdfApi* | [**GetPageLineAnnotations**](docs/PdfApi.md#getpagelineannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/line | Read document page line annotations.
*PdfApi* | [**GetPageLinkAnnotation**](docs/PdfApi.md#getpagelinkannotation) | **GET** /pdf/\{name}/pages/\{pageNumber}/links/\{linkId} | Read document page link annotation by ID.
*PdfApi* | [**GetPageLinkAnnotations**](docs/PdfApi.md#getpagelinkannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/links | Read document page link annotations.
*PdfApi* | [**GetPageListBoxFields**](docs/PdfApi.md#getpagelistboxfields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/listbox | Read document page listbox fields.
*PdfApi* | [**GetPageMovieAnnotations**](docs/PdfApi.md#getpagemovieannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/movie | Read document page movie annotations.
*PdfApi* | [**GetPagePolyLineAnnotations**](docs/PdfApi.md#getpagepolylineannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/polyline | Read document page polyline annotations.
*PdfApi* | [**GetPagePolygonAnnotations**](docs/PdfApi.md#getpagepolygonannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/polygon | Read document page polygon annotations.
*PdfApi* | [**GetPagePopupAnnotations**](docs/PdfApi.md#getpagepopupannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/popup | Read document page popup annotations.
*PdfApi* | [**GetPageRadioButtonFields**](docs/PdfApi.md#getpageradiobuttonfields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/radiobutton | Read document page radiobutton fields.
*PdfApi* | [**GetPageRedactionAnnotations**](docs/PdfApi.md#getpageredactionannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/redaction | Read document page redaction annotations.
*PdfApi* | [**GetPageScreenAnnotations**](docs/PdfApi.md#getpagescreenannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/screen | Read document page screen annotations.
*PdfApi* | [**GetPageSignatureFields**](docs/PdfApi.md#getpagesignaturefields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/signature | Read document page signature fields.
*PdfApi* | [**GetPageSoundAnnotations**](docs/PdfApi.md#getpagesoundannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/sound | Read document page sound annotations.
*PdfApi* | [**GetPageSquareAnnotations**](docs/PdfApi.md#getpagesquareannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/square | Read document page square annotations.
*PdfApi* | [**GetPageSquigglyAnnotations**](docs/PdfApi.md#getpagesquigglyannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/squiggly | Read document page squiggly annotations.
*PdfApi* | [**GetPageStampAnnotations**](docs/PdfApi.md#getpagestampannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/stamp | Read document page stamp annotations.
*PdfApi* | [**GetPageStamps**](docs/PdfApi.md#getpagestamps) | **GET** /pdf/\{name}/pages/\{pageNumber}/stamps | Read page document stamps.
*PdfApi* | [**GetPageStrikeOutAnnotations**](docs/PdfApi.md#getpagestrikeoutannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/strikeout | Read document page StrikeOut annotations.
*PdfApi* | [**GetPageTables**](docs/PdfApi.md#getpagetables) | **GET** /pdf/\{name}/pages/\{pageNumber}/tables | Read document page tables.
*PdfApi* | [**GetPageText**](docs/PdfApi.md#getpagetext) | **GET** /pdf/\{name}/pages/\{pageNumber}/text | Read page text items.
*PdfApi* | [**GetPageTextAnnotations**](docs/PdfApi.md#getpagetextannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/text | Read document page text annotations.
*PdfApi* | [**GetPageTextBoxFields**](docs/PdfApi.md#getpagetextboxfields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/textbox | Read document page text box fields.
*PdfApi* | [**GetPageUnderlineAnnotations**](docs/PdfApi.md#getpageunderlineannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/underline | Read document page underline annotations.
*PdfApi* | [**GetPages**](docs/PdfApi.md#getpages) | **GET** /pdf/\{name}/pages | Read document pages info.
*PdfApi* | [**GetPclInStorageToPdf**](docs/PdfApi.md#getpclinstoragetopdf) | **GET** /pdf/create/pcl | Convert PCL file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetPdfAInStorageToPdf**](docs/PdfApi.md#getpdfainstoragetopdf) | **GET** /pdf/create/pdfa | Convert PDFA file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetPdfInStorageToDoc**](docs/PdfApi.md#getpdfinstoragetodoc) | **GET** /pdf/\{name}/convert/doc | Converts PDF document (located on storage) to DOC format and returns resulting file in response content.
*PdfApi* | [**GetPdfInStorageToEpub**](docs/PdfApi.md#getpdfinstoragetoepub) | **GET** /pdf/\{name}/convert/epub | Converts PDF document (located on storage) to EPUB format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToHtml**](docs/PdfApi.md#getpdfinstoragetohtml) | **GET** /pdf/\{name}/convert/html | Converts PDF document (located on storage) to Html format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToMobiXml**](docs/PdfApi.md#getpdfinstoragetomobixml) | **GET** /pdf/\{name}/convert/mobixml | Converts PDF document (located on storage) to MOBIXML format and returns resulting ZIP archive file in response content.
*PdfApi* | [**GetPdfInStorageToPdfA**](docs/PdfApi.md#getpdfinstoragetopdfa) | **GET** /pdf/\{name}/convert/pdfa | Converts PDF document (located on storage) to PdfA format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToPptx**](docs/PdfApi.md#getpdfinstoragetopptx) | **GET** /pdf/\{name}/convert/pptx | Converts PDF document (located on storage) to PPTX format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToSvg**](docs/PdfApi.md#getpdfinstoragetosvg) | **GET** /pdf/\{name}/convert/svg | Converts PDF document (located on storage) to SVG format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToTeX**](docs/PdfApi.md#getpdfinstoragetotex) | **GET** /pdf/\{name}/convert/tex | Converts PDF document (located on storage) to TeX format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToTiff**](docs/PdfApi.md#getpdfinstoragetotiff) | **GET** /pdf/\{name}/convert/tiff | Converts PDF document (located on storage) to TIFF format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToXls**](docs/PdfApi.md#getpdfinstoragetoxls) | **GET** /pdf/\{name}/convert/xls | Converts PDF document (located on storage) to XLS format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToXlsx**](docs/PdfApi.md#getpdfinstoragetoxlsx) | **GET** /pdf/\{name}/convert/xlsx | Converts PDF document (located on storage) to XLSX format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToXml**](docs/PdfApi.md#getpdfinstoragetoxml) | **GET** /pdf/\{name}/convert/xml | Converts PDF document (located on storage) to XML format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToXps**](docs/PdfApi.md#getpdfinstoragetoxps) | **GET** /pdf/\{name}/convert/xps | Converts PDF document (located on storage) to XPS format and returns resulting file in response content
*PdfApi* | [**GetPolyLineAnnotation**](docs/PdfApi.md#getpolylineannotation) | **GET** /pdf/\{name}/annotations/polyline/\{annotationId} | Read document page polyline annotation by ID.
*PdfApi* | [**GetPolygonAnnotation**](docs/PdfApi.md#getpolygonannotation) | **GET** /pdf/\{name}/annotations/polygon/\{annotationId} | Read document page polygon annotation by ID.
*PdfApi* | [**GetPopupAnnotation**](docs/PdfApi.md#getpopupannotation) | **GET** /pdf/\{name}/annotations/popup/\{annotationId} | Read document page popup annotation by ID.
*PdfApi* | [**GetPsInStorageToPdf**](docs/PdfApi.md#getpsinstoragetopdf) | **GET** /pdf/create/ps | Convert PS file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetRadioButtonField**](docs/PdfApi.md#getradiobuttonfield) | **GET** /pdf/\{name}/fields/radiobutton/\{fieldName} | Read document RadioButton field by name.
*PdfApi* | [**GetRedactionAnnotation**](docs/PdfApi.md#getredactionannotation) | **GET** /pdf/\{name}/annotations/redaction/\{annotationId} | Read document page redaction annotation by ID.
*PdfApi* | [**GetScreenAnnotation**](docs/PdfApi.md#getscreenannotation) | **GET** /pdf/\{name}/annotations/screen/\{annotationId} | Read document page screen annotation by ID.
*PdfApi* | [**GetScreenAnnotationData**](docs/PdfApi.md#getscreenannotationdata) | **GET** /pdf/\{name}/annotations/screen/\{annotationId}/data | Read document page screen annotation by ID.
*PdfApi* | [**GetSignatureField**](docs/PdfApi.md#getsignaturefield) | **GET** /pdf/\{name}/fields/signature/\{fieldName} | Read document signature field by name.
*PdfApi* | [**GetSoundAnnotation**](docs/PdfApi.md#getsoundannotation) | **GET** /pdf/\{name}/annotations/sound/\{annotationId} | Read document page sound annotation by ID.
*PdfApi* | [**GetSoundAnnotationData**](docs/PdfApi.md#getsoundannotationdata) | **GET** /pdf/\{name}/annotations/sound/\{annotationId}/data | Read document page sound annotation by ID.
*PdfApi* | [**GetSquareAnnotation**](docs/PdfApi.md#getsquareannotation) | **GET** /pdf/\{name}/annotations/square/\{annotationId} | Read document page square annotation by ID.
*PdfApi* | [**GetSquigglyAnnotation**](docs/PdfApi.md#getsquigglyannotation) | **GET** /pdf/\{name}/annotations/squiggly/\{annotationId} | Read document page squiggly annotation by ID.
*PdfApi* | [**GetStampAnnotation**](docs/PdfApi.md#getstampannotation) | **GET** /pdf/\{name}/annotations/stamp/\{annotationId} | Read document page stamp annotation by ID.
*PdfApi* | [**GetStampAnnotationData**](docs/PdfApi.md#getstampannotationdata) | **GET** /pdf/\{name}/annotations/stamp/\{annotationId}/data | Read document page stamp annotation by ID.
*PdfApi* | [**GetStrikeOutAnnotation**](docs/PdfApi.md#getstrikeoutannotation) | **GET** /pdf/\{name}/annotations/strikeout/\{annotationId} | Read document page StrikeOut annotation by ID.
*PdfApi* | [**GetSvgInStorageToPdf**](docs/PdfApi.md#getsvginstoragetopdf) | **GET** /pdf/create/svg | Convert SVG file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetTable**](docs/PdfApi.md#gettable) | **GET** /pdf/\{name}/tables/\{tableId} | Read document page table by ID.
*PdfApi* | [**GetTeXInStorageToPdf**](docs/PdfApi.md#gettexinstoragetopdf) | **GET** /pdf/create/tex | Convert TeX file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetText**](docs/PdfApi.md#gettext) | **GET** /pdf/\{name}/text | Read document text.
*PdfApi* | [**GetTextAnnotation**](docs/PdfApi.md#gettextannotation) | **GET** /pdf/\{name}/annotations/text/\{annotationId} | Read document page text annotation by ID.
*PdfApi* | [**GetTextBoxField**](docs/PdfApi.md#gettextboxfield) | **GET** /pdf/\{name}/fields/textbox/\{fieldName} | Read document text box field by name.
*PdfApi* | [**GetUnderlineAnnotation**](docs/PdfApi.md#getunderlineannotation) | **GET** /pdf/\{name}/annotations/underline/\{annotationId} | Read document page underline annotation by ID.
*PdfApi* | [**GetVerifySignature**](docs/PdfApi.md#getverifysignature) | **GET** /pdf/\{name}/verifySignature | Verify signature document.
*PdfApi* | [**GetWebInStorageToPdf**](docs/PdfApi.md#getwebinstoragetopdf) | **GET** /pdf/create/web | Convert web page to PDF format and return resulting file in response. 
*PdfApi* | [**GetWordsPerPage**](docs/PdfApi.md#getwordsperpage) | **GET** /pdf/\{name}/pages/wordCount | Get number of words per document page.
*PdfApi* | [**GetXfaPdfInStorageToAcroForm**](docs/PdfApi.md#getxfapdfinstoragetoacroform) | **GET** /pdf/\{name}/convert/xfatoacroform | Converts PDF document which contains XFA form (located on storage) to PDF with AcroForm and returns resulting file response content
*PdfApi* | [**GetXmlInStorageToPdf**](docs/PdfApi.md#getxmlinstoragetopdf) | **GET** /pdf/create/xml | Convert XML file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetXpsInStorageToPdf**](docs/PdfApi.md#getxpsinstoragetopdf) | **GET** /pdf/create/xps | Convert XPS file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetXslFoInStorageToPdf**](docs/PdfApi.md#getxslfoinstoragetopdf) | **GET** /pdf/create/xslfo | Convert XslFo file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**MoveFile**](docs/PdfApi.md#movefile) | **PUT** /pdf/storage/file/move/\{srcPath} | Move file
*PdfApi* | [**MoveFolder**](docs/PdfApi.md#movefolder) | **PUT** /pdf/storage/folder/move/\{srcPath} | Move folder
*PdfApi* | [**ObjectExists**](docs/PdfApi.md#objectexists) | **GET** /pdf/storage/exist/\{path} | Check if file or folder exists
*PdfApi* | [**PostAppendDocument**](docs/PdfApi.md#postappenddocument) | **POST** /pdf/\{name}/appendDocument | Append document to existing one.
*PdfApi* | [**PostBookmark**](docs/PdfApi.md#postbookmark) | **POST** /pdf/\{name}/bookmarks/bookmark/\{bookmarkPath} | Add document bookmarks.
*PdfApi* | [**PostChangePasswordDocumentInStorage**](docs/PdfApi.md#postchangepassworddocumentinstorage) | **POST** /pdf/\{name}/changepassword | Change document password in storage.
*PdfApi* | [**PostCheckBoxFields**](docs/PdfApi.md#postcheckboxfields) | **POST** /pdf/\{name}/fields/checkbox | Add document checkbox fields.
*PdfApi* | [**PostComboBoxFields**](docs/PdfApi.md#postcomboboxfields) | **POST** /pdf/\{name}/fields/combobox | Add document combobox fields.
*PdfApi* | [**PostCreateDocument**](docs/PdfApi.md#postcreatedocument) | **POST** /pdf/\{name} | Create empty document.
*PdfApi* | [**PostCreateField**](docs/PdfApi.md#postcreatefield) | **POST** /pdf/\{name}/fields | Create field.
*PdfApi* | [**PostDecryptDocumentInStorage**](docs/PdfApi.md#postdecryptdocumentinstorage) | **POST** /pdf/\{name}/decrypt | Decrypt document in storage.
*PdfApi* | [**PostDocumentImageFooter**](docs/PdfApi.md#postdocumentimagefooter) | **POST** /pdf/\{name}/footer/image | Add document image footer.
*PdfApi* | [**PostDocumentImageHeader**](docs/PdfApi.md#postdocumentimageheader) | **POST** /pdf/\{name}/header/image | Add document image header.
*PdfApi* | [**PostDocumentPageNumberStamps**](docs/PdfApi.md#postdocumentpagenumberstamps) | **POST** /pdf/\{name}/stamps/pagenumber | Add document page number stamps.
*PdfApi* | [**PostDocumentTextFooter**](docs/PdfApi.md#postdocumenttextfooter) | **POST** /pdf/\{name}/footer/text | Add document text footer.
*PdfApi* | [**PostDocumentTextHeader**](docs/PdfApi.md#postdocumenttextheader) | **POST** /pdf/\{name}/header/text | Add document text header.
*PdfApi* | [**PostDocumentTextReplace**](docs/PdfApi.md#postdocumenttextreplace) | **POST** /pdf/\{name}/text/replace | Document's replace text method.
*PdfApi* | [**PostEncryptDocumentInStorage**](docs/PdfApi.md#postencryptdocumentinstorage) | **POST** /pdf/\{name}/encrypt | Encrypt document in storage.
*PdfApi* | [**PostFlattenDocument**](docs/PdfApi.md#postflattendocument) | **POST** /pdf/\{name}/flatten | Flatten the document.
*PdfApi* | [**PostImportFieldsFromFdf**](docs/PdfApi.md#postimportfieldsfromfdf) | **POST** /pdf/\{name}/import/fdf | Update fields from FDF file in request.
*PdfApi* | [**PostImportFieldsFromXfdf**](docs/PdfApi.md#postimportfieldsfromxfdf) | **POST** /pdf/\{name}/import/xfdf | Update fields from XFDF file in request.
*PdfApi* | [**PostImportFieldsFromXml**](docs/PdfApi.md#postimportfieldsfromxml) | **POST** /pdf/\{name}/import/xml | Update fields from XML file in request.
*PdfApi* | [**PostInsertImage**](docs/PdfApi.md#postinsertimage) | **POST** /pdf/\{name}/pages/\{pageNumber}/images | Insert image to document page.
*PdfApi* | [**PostListBoxFields**](docs/PdfApi.md#postlistboxfields) | **POST** /pdf/\{name}/fields/listbox | Add document listbox fields.
*PdfApi* | [**PostMovePage**](docs/PdfApi.md#postmovepage) | **POST** /pdf/\{name}/pages/\{pageNumber}/movePage | Move page to new position.
*PdfApi* | [**PostOptimizeDocument**](docs/PdfApi.md#postoptimizedocument) | **POST** /pdf/\{name}/optimize | Optimize document.
*PdfApi* | [**PostPageCaretAnnotations**](docs/PdfApi.md#postpagecaretannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/caret | Add document page caret annotations.
*PdfApi* | [**PostPageCertify**](docs/PdfApi.md#postpagecertify) | **POST** /pdf/\{name}/pages/\{pageNumber}/certify | Certify document page.
*PdfApi* | [**PostPageCircleAnnotations**](docs/PdfApi.md#postpagecircleannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/circle | Add document page circle annotations.
*PdfApi* | [**PostPageFileAttachmentAnnotations**](docs/PdfApi.md#postpagefileattachmentannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/fileattachment | Add document page FileAttachment annotations.
*PdfApi* | [**PostPageFreeTextAnnotations**](docs/PdfApi.md#postpagefreetextannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/freetext | Add document page free text annotations.
*PdfApi* | [**PostPageHighlightAnnotations**](docs/PdfApi.md#postpagehighlightannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/highlight | Add document page highlight annotations.
*PdfApi* | [**PostPageImageStamps**](docs/PdfApi.md#postpageimagestamps) | **POST** /pdf/\{name}/pages/\{pageNumber}/stamps/image | Add document page image stamps.
*PdfApi* | [**PostPageInkAnnotations**](docs/PdfApi.md#postpageinkannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/ink | Add document page ink annotations.
*PdfApi* | [**PostPageLineAnnotations**](docs/PdfApi.md#postpagelineannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/line | Add document page line annotations.
*PdfApi* | [**PostPageLinkAnnotations**](docs/PdfApi.md#postpagelinkannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/links | Add document page link annotations.
*PdfApi* | [**PostPageMovieAnnotations**](docs/PdfApi.md#postpagemovieannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/movie | Add document page movie annotations.
*PdfApi* | [**PostPagePdfPageStamps**](docs/PdfApi.md#postpagepdfpagestamps) | **POST** /pdf/\{name}/pages/\{pageNumber}/stamps/pdfpage | Add document pdf page stamps.
*PdfApi* | [**PostPagePolyLineAnnotations**](docs/PdfApi.md#postpagepolylineannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/polyline | Add document page polyline annotations.
*PdfApi* | [**PostPagePolygonAnnotations**](docs/PdfApi.md#postpagepolygonannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/polygon | Add document page polygon annotations.
*PdfApi* | [**PostPageRedactionAnnotations**](docs/PdfApi.md#postpageredactionannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/redaction | Add document page redaction annotations.
*PdfApi* | [**PostPageScreenAnnotations**](docs/PdfApi.md#postpagescreenannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/screen | Add document page screen annotations.
*PdfApi* | [**PostPageSoundAnnotations**](docs/PdfApi.md#postpagesoundannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/sound | Add document page sound annotations.
*PdfApi* | [**PostPageSquareAnnotations**](docs/PdfApi.md#postpagesquareannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/square | Add document page square annotations.
*PdfApi* | [**PostPageSquigglyAnnotations**](docs/PdfApi.md#postpagesquigglyannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/squiggly | Add document page squiggly annotations.
*PdfApi* | [**PostPageStampAnnotations**](docs/PdfApi.md#postpagestampannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/stamp | Add document page stamp annotations.
*PdfApi* | [**PostPageStrikeOutAnnotations**](docs/PdfApi.md#postpagestrikeoutannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/strikeout | Add document page StrikeOut annotations.
*PdfApi* | [**PostPageTables**](docs/PdfApi.md#postpagetables) | **POST** /pdf/\{name}/pages/\{pageNumber}/tables | Add document page tables.
*PdfApi* | [**PostPageTextAnnotations**](docs/PdfApi.md#postpagetextannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/text | Add document page text annotations.
*PdfApi* | [**PostPageTextReplace**](docs/PdfApi.md#postpagetextreplace) | **POST** /pdf/\{name}/pages/\{pageNumber}/text/replace | Page's replace text method.
*PdfApi* | [**PostPageTextStamps**](docs/PdfApi.md#postpagetextstamps) | **POST** /pdf/\{name}/pages/\{pageNumber}/stamps/text | Add document page text stamps.
*PdfApi* | [**PostPageUnderlineAnnotations**](docs/PdfApi.md#postpageunderlineannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/underline | Add document page underline annotations.
*PdfApi* | [**PostPopupAnnotation**](docs/PdfApi.md#postpopupannotation) | **POST** /pdf/\{name}/annotations/\{annotationId}/popup | Add document popup annotations.
*PdfApi* | [**PostRadioButtonFields**](docs/PdfApi.md#postradiobuttonfields) | **POST** /pdf/\{name}/fields/radiobutton | Add document RadioButton fields.
*PdfApi* | [**PostSignDocument**](docs/PdfApi.md#postsigndocument) | **POST** /pdf/\{name}/sign | Sign document.
*PdfApi* | [**PostSignPage**](docs/PdfApi.md#postsignpage) | **POST** /pdf/\{name}/pages/\{pageNumber}/sign | Sign page.
*PdfApi* | [**PostSignatureField**](docs/PdfApi.md#postsignaturefield) | **POST** /pdf/\{name}/fields/signature | Add document signature field.
*PdfApi* | [**PostSplitDocument**](docs/PdfApi.md#postsplitdocument) | **POST** /pdf/\{name}/split | Split document to parts.
*PdfApi* | [**PostSplitRangePdfDocument**](docs/PdfApi.md#postsplitrangepdfdocument) | **POST** /pdf/\{name}/splitrangepdf | Split document into ranges.
*PdfApi* | [**PostTextBoxFields**](docs/PdfApi.md#posttextboxfields) | **POST** /pdf/\{name}/fields/textbox | Add document text box fields.
*PdfApi* | [**PutAddNewPage**](docs/PdfApi.md#putaddnewpage) | **PUT** /pdf/\{name}/pages | Add new page to end of the document.
*PdfApi* | [**PutAddText**](docs/PdfApi.md#putaddtext) | **PUT** /pdf/\{name}/pages/\{pageNumber}/text | Add text to PDF document page.
*PdfApi* | [**PutAnnotationsFlatten**](docs/PdfApi.md#putannotationsflatten) | **PUT** /pdf/\{name}/annotations/flatten | Flattens the annotations of the specified types
*PdfApi* | [**PutBookmark**](docs/PdfApi.md#putbookmark) | **PUT** /pdf/\{name}/bookmarks/bookmark/\{bookmarkPath} | Update document bookmark.
*PdfApi* | [**PutCaretAnnotation**](docs/PdfApi.md#putcaretannotation) | **PUT** /pdf/\{name}/annotations/caret/\{annotationId} | Replace document caret annotation
*PdfApi* | [**PutChangePasswordDocument**](docs/PdfApi.md#putchangepassworddocument) | **PUT** /pdf/changepassword | Change document password from content.
*PdfApi* | [**PutCheckBoxField**](docs/PdfApi.md#putcheckboxfield) | **PUT** /pdf/\{name}/fields/checkbox/\{fieldName} | Replace document checkbox field
*PdfApi* | [**PutCircleAnnotation**](docs/PdfApi.md#putcircleannotation) | **PUT** /pdf/\{name}/annotations/circle/\{annotationId} | Replace document circle annotation
*PdfApi* | [**PutComboBoxField**](docs/PdfApi.md#putcomboboxfield) | **PUT** /pdf/\{name}/fields/combobox/\{fieldName} | Replace document combobox field
*PdfApi* | [**PutCreateDocument**](docs/PdfApi.md#putcreatedocument) | **PUT** /pdf/\{name} | Create empty document.
*PdfApi* | [**PutDecryptDocument**](docs/PdfApi.md#putdecryptdocument) | **PUT** /pdf/decrypt | Decrypt document from content.
*PdfApi* | [**PutDocumentDisplayProperties**](docs/PdfApi.md#putdocumentdisplayproperties) | **PUT** /pdf/\{name}/displayproperties | Update document display properties.
*PdfApi* | [**PutEncryptDocument**](docs/PdfApi.md#putencryptdocument) | **PUT** /pdf/encrypt | Encrypt document from content.
*PdfApi* | [**PutEpubInStorageToPdf**](docs/PdfApi.md#putepubinstoragetopdf) | **PUT** /pdf/\{name}/create/epub | Convert EPUB file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutExportFieldsFromPdfToFdfInStorage**](docs/PdfApi.md#putexportfieldsfrompdftofdfinstorage) | **PUT** /pdf/\{name}/export/fdf | Export fields from from PDF in storage to FDF file in storage.
*PdfApi* | [**PutExportFieldsFromPdfToXfdfInStorage**](docs/PdfApi.md#putexportfieldsfrompdftoxfdfinstorage) | **PUT** /pdf/\{name}/export/xfdf | Export fields from from PDF in storage to XFDF file in storage.
*PdfApi* | [**PutExportFieldsFromPdfToXmlInStorage**](docs/PdfApi.md#putexportfieldsfrompdftoxmlinstorage) | **PUT** /pdf/\{name}/export/xml | Export fields from from PDF in storage to XML file in storage.
*PdfApi* | [**PutFieldsFlatten**](docs/PdfApi.md#putfieldsflatten) | **PUT** /pdf/\{name}/fields/flatten | Flatten form fields in document.
*PdfApi* | [**PutFileAttachmentAnnotation**](docs/PdfApi.md#putfileattachmentannotation) | **PUT** /pdf/\{name}/annotations/fileattachment/\{annotationId} | Replace document FileAttachment annotation
*PdfApi* | [**PutFileAttachmentAnnotationDataExtract**](docs/PdfApi.md#putfileattachmentannotationdataextract) | **PUT** /pdf/\{name}/annotations/fileattachment/\{annotationId}/data/extract | Extract document FileAttachment annotation content to storage
*PdfApi* | [**PutFreeTextAnnotation**](docs/PdfApi.md#putfreetextannotation) | **PUT** /pdf/\{name}/annotations/freetext/\{annotationId} | Replace document free text annotation
*PdfApi* | [**PutHighlightAnnotation**](docs/PdfApi.md#puthighlightannotation) | **PUT** /pdf/\{name}/annotations/highlight/\{annotationId} | Replace document highlight annotation
*PdfApi* | [**PutHtmlInStorageToPdf**](docs/PdfApi.md#puthtmlinstoragetopdf) | **PUT** /pdf/\{name}/create/html | Convert HTML file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutImageExtractAsGif**](docs/PdfApi.md#putimageextractasgif) | **PUT** /pdf/\{name}/images/\{imageId}/extract/gif | Extract document image in GIF format to folder
*PdfApi* | [**PutImageExtractAsJpeg**](docs/PdfApi.md#putimageextractasjpeg) | **PUT** /pdf/\{name}/images/\{imageId}/extract/jpeg | Extract document image in JPEG format to folder
*PdfApi* | [**PutImageExtractAsPng**](docs/PdfApi.md#putimageextractaspng) | **PUT** /pdf/\{name}/images/\{imageId}/extract/png | Extract document image in PNG format to folder
*PdfApi* | [**PutImageExtractAsTiff**](docs/PdfApi.md#putimageextractastiff) | **PUT** /pdf/\{name}/images/\{imageId}/extract/tiff | Extract document image in TIFF format to folder
*PdfApi* | [**PutImageInStorageToPdf**](docs/PdfApi.md#putimageinstoragetopdf) | **PUT** /pdf/\{name}/create/images | Convert image file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutImagesExtractAsGif**](docs/PdfApi.md#putimagesextractasgif) | **PUT** /pdf/\{name}/pages/\{pageNumber}/images/extract/gif | Extract document images in GIF format to folder.
*PdfApi* | [**PutImagesExtractAsJpeg**](docs/PdfApi.md#putimagesextractasjpeg) | **PUT** /pdf/\{name}/pages/\{pageNumber}/images/extract/jpeg | Extract document images in JPEG format to folder.
*PdfApi* | [**PutImagesExtractAsPng**](docs/PdfApi.md#putimagesextractaspng) | **PUT** /pdf/\{name}/pages/\{pageNumber}/images/extract/png | Extract document images in PNG format to folder.
*PdfApi* | [**PutImagesExtractAsTiff**](docs/PdfApi.md#putimagesextractastiff) | **PUT** /pdf/\{name}/pages/\{pageNumber}/images/extract/tiff | Extract document images in TIFF format to folder.
*PdfApi* | [**PutImportFieldsFromFdfInStorage**](docs/PdfApi.md#putimportfieldsfromfdfinstorage) | **PUT** /pdf/\{name}/import/fdf | Update fields from FDF file in storage.
*PdfApi* | [**PutImportFieldsFromXfdfInStorage**](docs/PdfApi.md#putimportfieldsfromxfdfinstorage) | **PUT** /pdf/\{name}/import/xfdf | Update fields from XFDF file in storage.
*PdfApi* | [**PutImportFieldsFromXmlInStorage**](docs/PdfApi.md#putimportfieldsfromxmlinstorage) | **PUT** /pdf/\{name}/import/xml | Update fields from XML file in storage.
*PdfApi* | [**PutInkAnnotation**](docs/PdfApi.md#putinkannotation) | **PUT** /pdf/\{name}/annotations/ink/\{annotationId} | Replace document ink annotation
*PdfApi* | [**PutLineAnnotation**](docs/PdfApi.md#putlineannotation) | **PUT** /pdf/\{name}/annotations/line/\{annotationId} | Replace document line annotation
*PdfApi* | [**PutLinkAnnotation**](docs/PdfApi.md#putlinkannotation) | **PUT** /pdf/\{name}/links/\{linkId} | Replace document page link annotations
*PdfApi* | [**PutListBoxField**](docs/PdfApi.md#putlistboxfield) | **PUT** /pdf/\{name}/fields/listbox/\{fieldName} | Replace document listbox field
*PdfApi* | [**PutMarkdownInStorageToPdf**](docs/PdfApi.md#putmarkdowninstoragetopdf) | **PUT** /pdf/\{name}/create/markdown | Convert MD file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutMergeDocuments**](docs/PdfApi.md#putmergedocuments) | **PUT** /pdf/\{name}/merge | Merge a list of documents.
*PdfApi* | [**PutMhtInStorageToPdf**](docs/PdfApi.md#putmhtinstoragetopdf) | **PUT** /pdf/\{name}/create/mht | Convert MHT file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutMovieAnnotation**](docs/PdfApi.md#putmovieannotation) | **PUT** /pdf/\{name}/annotations/movie/\{annotationId} | Replace document movie annotation
*PdfApi* | [**PutPageAddStamp**](docs/PdfApi.md#putpageaddstamp) | **PUT** /pdf/\{name}/pages/\{pageNumber}/stamp | Add page stamp.
*PdfApi* | [**PutPageConvertToBmp**](docs/PdfApi.md#putpageconverttobmp) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/bmp | Convert document page to bmp image and upload resulting file to storage.
*PdfApi* | [**PutPageConvertToEmf**](docs/PdfApi.md#putpageconverttoemf) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/emf | Convert document page to emf image and upload resulting file to storage.
*PdfApi* | [**PutPageConvertToGif**](docs/PdfApi.md#putpageconverttogif) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/gif | Convert document page to gif image and upload resulting file to storage.
*PdfApi* | [**PutPageConvertToJpeg**](docs/PdfApi.md#putpageconverttojpeg) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/jpeg | Convert document page to Jpeg image and upload resulting file to storage.
*PdfApi* | [**PutPageConvertToPng**](docs/PdfApi.md#putpageconverttopng) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/png | Convert document page to png image and upload resulting file to storage.
*PdfApi* | [**PutPageConvertToTiff**](docs/PdfApi.md#putpageconverttotiff) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/tiff | Convert document page to Tiff image and upload resulting file to storage.
*PdfApi* | [**PutPclInStorageToPdf**](docs/PdfApi.md#putpclinstoragetopdf) | **PUT** /pdf/\{name}/create/pcl | Convert PCL file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutPdfAInStorageToPdf**](docs/PdfApi.md#putpdfainstoragetopdf) | **PUT** /pdf/\{name}/create/pdfa | Convert PDFA file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutPdfInRequestToDoc**](docs/PdfApi.md#putpdfinrequesttodoc) | **PUT** /pdf/convert/doc | Converts PDF document (in request content) to DOC format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToEpub**](docs/PdfApi.md#putpdfinrequesttoepub) | **PUT** /pdf/convert/epub | Converts PDF document (in request content) to EPUB format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToHtml**](docs/PdfApi.md#putpdfinrequesttohtml) | **PUT** /pdf/convert/html | Converts PDF document (in request content) to Html format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToMobiXml**](docs/PdfApi.md#putpdfinrequesttomobixml) | **PUT** /pdf/convert/mobixml | Converts PDF document (in request content) to MOBIXML format and uploads resulting ZIP archive file to storage.
*PdfApi* | [**PutPdfInRequestToPdfA**](docs/PdfApi.md#putpdfinrequesttopdfa) | **PUT** /pdf/convert/pdfa | Converts PDF document (in request content) to PdfA format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToPptx**](docs/PdfApi.md#putpdfinrequesttopptx) | **PUT** /pdf/convert/pptx | Converts PDF document (in request content) to PPTX format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToSvg**](docs/PdfApi.md#putpdfinrequesttosvg) | **PUT** /pdf/convert/svg | Converts PDF document (in request content) to SVG format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToTeX**](docs/PdfApi.md#putpdfinrequesttotex) | **PUT** /pdf/convert/tex | Converts PDF document (in request content) to TeX format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToTiff**](docs/PdfApi.md#putpdfinrequesttotiff) | **PUT** /pdf/convert/tiff | Converts PDF document (in request content) to TIFF format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToXls**](docs/PdfApi.md#putpdfinrequesttoxls) | **PUT** /pdf/convert/xls | Converts PDF document (in request content) to XLS format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToXlsx**](docs/PdfApi.md#putpdfinrequesttoxlsx) | **PUT** /pdf/convert/xlsx | Converts PDF document (in request content) to XLSX format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToXml**](docs/PdfApi.md#putpdfinrequesttoxml) | **PUT** /pdf/convert/xml | Converts PDF document (in request content) to XML format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToXps**](docs/PdfApi.md#putpdfinrequesttoxps) | **PUT** /pdf/convert/xps | Converts PDF document (in request content) to XPS format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInStorageToDoc**](docs/PdfApi.md#putpdfinstoragetodoc) | **PUT** /pdf/\{name}/convert/doc | Converts PDF document (located on storage) to DOC format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInStorageToEpub**](docs/PdfApi.md#putpdfinstoragetoepub) | **PUT** /pdf/\{name}/convert/epub | Converts PDF document (located on storage) to EPUB format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToHtml**](docs/PdfApi.md#putpdfinstoragetohtml) | **PUT** /pdf/\{name}/convert/html | Converts PDF document (located on storage) to Html format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToMobiXml**](docs/PdfApi.md#putpdfinstoragetomobixml) | **PUT** /pdf/\{name}/convert/mobixml | Converts PDF document (located on storage) to MOBIXML format and uploads resulting ZIP archive file to storage
*PdfApi* | [**PutPdfInStorageToPdfA**](docs/PdfApi.md#putpdfinstoragetopdfa) | **PUT** /pdf/\{name}/convert/pdfa | Converts PDF document (located on storage) to PdfA format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToPptx**](docs/PdfApi.md#putpdfinstoragetopptx) | **PUT** /pdf/\{name}/convert/pptx | Converts PDF document (located on storage) to PPTX format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToSvg**](docs/PdfApi.md#putpdfinstoragetosvg) | **PUT** /pdf/\{name}/convert/svg | Converts PDF document (located on storage) to SVG format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToTeX**](docs/PdfApi.md#putpdfinstoragetotex) | **PUT** /pdf/\{name}/convert/tex | Converts PDF document (located on storage) to TeX format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToTiff**](docs/PdfApi.md#putpdfinstoragetotiff) | **PUT** /pdf/\{name}/convert/tiff | Converts PDF document (located on storage) to TIFF format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToXls**](docs/PdfApi.md#putpdfinstoragetoxls) | **PUT** /pdf/\{name}/convert/xls | Converts PDF document (located on storage) to XLS format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToXlsx**](docs/PdfApi.md#putpdfinstoragetoxlsx) | **PUT** /pdf/\{name}/convert/xlsx | Converts PDF document (located on storage) to XLSX format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToXml**](docs/PdfApi.md#putpdfinstoragetoxml) | **PUT** /pdf/\{name}/convert/xml | Converts PDF document (located on storage) to XML format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToXps**](docs/PdfApi.md#putpdfinstoragetoxps) | **PUT** /pdf/\{name}/convert/xps | Converts PDF document (located on storage) to XPS format and uploads resulting file to storage
*PdfApi* | [**PutPolyLineAnnotation**](docs/PdfApi.md#putpolylineannotation) | **PUT** /pdf/\{name}/annotations/polyline/\{annotationId} | Replace document polyline annotation
*PdfApi* | [**PutPolygonAnnotation**](docs/PdfApi.md#putpolygonannotation) | **PUT** /pdf/\{name}/annotations/polygon/\{annotationId} | Replace document polygon annotation
*PdfApi* | [**PutPopupAnnotation**](docs/PdfApi.md#putpopupannotation) | **PUT** /pdf/\{name}/annotations/popup/\{annotationId} | Replace document popup annotation
*PdfApi* | [**PutPrivileges**](docs/PdfApi.md#putprivileges) | **PUT** /pdf/\{name}/privileges | Update privilege document.
*PdfApi* | [**PutPsInStorageToPdf**](docs/PdfApi.md#putpsinstoragetopdf) | **PUT** /pdf/\{name}/create/ps | Convert PS file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutRadioButtonField**](docs/PdfApi.md#putradiobuttonfield) | **PUT** /pdf/\{name}/fields/radiobutton/\{fieldName} | Replace document RadioButton field
*PdfApi* | [**PutRedactionAnnotation**](docs/PdfApi.md#putredactionannotation) | **PUT** /pdf/\{name}/annotations/redaction/\{annotationId} | Replace document redaction annotation
*PdfApi* | [**PutReplaceImage**](docs/PdfApi.md#putreplaceimage) | **PUT** /pdf/\{name}/images/\{imageId} | Replace document image.
*PdfApi* | [**PutScreenAnnotation**](docs/PdfApi.md#putscreenannotation) | **PUT** /pdf/\{name}/annotations/screen/\{annotationId} | Replace document screen annotation
*PdfApi* | [**PutScreenAnnotationDataExtract**](docs/PdfApi.md#putscreenannotationdataextract) | **PUT** /pdf/\{name}/annotations/screen/\{annotationId}/data/extract | Extract document screen annotation content to storage
*PdfApi* | [**PutSearchableDocument**](docs/PdfApi.md#putsearchabledocument) | **PUT** /pdf/\{name}/ocr | Create searchable PDF document. Generate OCR layer for images in input PDF document.
*PdfApi* | [**PutSetProperty**](docs/PdfApi.md#putsetproperty) | **PUT** /pdf/\{name}/documentproperties/\{propertyName} | Add/update document property.
*PdfApi* | [**PutSignatureField**](docs/PdfApi.md#putsignaturefield) | **PUT** /pdf/\{name}/fields/signature/\{fieldName} | Replace document signature field.
*PdfApi* | [**PutSoundAnnotation**](docs/PdfApi.md#putsoundannotation) | **PUT** /pdf/\{name}/annotations/sound/\{annotationId} | Replace document sound annotation
*PdfApi* | [**PutSoundAnnotationDataExtract**](docs/PdfApi.md#putsoundannotationdataextract) | **PUT** /pdf/\{name}/annotations/sound/\{annotationId}/data/extract | Extract document sound annotation content to storage
*PdfApi* | [**PutSquareAnnotation**](docs/PdfApi.md#putsquareannotation) | **PUT** /pdf/\{name}/annotations/square/\{annotationId} | Replace document square annotation
*PdfApi* | [**PutSquigglyAnnotation**](docs/PdfApi.md#putsquigglyannotation) | **PUT** /pdf/\{name}/annotations/squiggly/\{annotationId} | Replace document squiggly annotation
*PdfApi* | [**PutStampAnnotation**](docs/PdfApi.md#putstampannotation) | **PUT** /pdf/\{name}/annotations/stamp/\{annotationId} | Replace document stamp annotation
*PdfApi* | [**PutStampAnnotationDataExtract**](docs/PdfApi.md#putstampannotationdataextract) | **PUT** /pdf/\{name}/annotations/stamp/\{annotationId}/data/extract | Extract document stamp annotation content to storage
*PdfApi* | [**PutStrikeOutAnnotation**](docs/PdfApi.md#putstrikeoutannotation) | **PUT** /pdf/\{name}/annotations/strikeout/\{annotationId} | Replace document StrikeOut annotation
*PdfApi* | [**PutSvgInStorageToPdf**](docs/PdfApi.md#putsvginstoragetopdf) | **PUT** /pdf/\{name}/create/svg | Convert SVG file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutTable**](docs/PdfApi.md#puttable) | **PUT** /pdf/\{name}/tables/\{tableId} | Replace document page table.
*PdfApi* | [**PutTeXInStorageToPdf**](docs/PdfApi.md#puttexinstoragetopdf) | **PUT** /pdf/\{name}/create/tex | Convert TeX file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutTextAnnotation**](docs/PdfApi.md#puttextannotation) | **PUT** /pdf/\{name}/annotations/text/\{annotationId} | Replace document text annotation
*PdfApi* | [**PutTextBoxField**](docs/PdfApi.md#puttextboxfield) | **PUT** /pdf/\{name}/fields/textbox/\{fieldName} | Replace document text box field
*PdfApi* | [**PutUnderlineAnnotation**](docs/PdfApi.md#putunderlineannotation) | **PUT** /pdf/\{name}/annotations/underline/\{annotationId} | Replace document underline annotation
*PdfApi* | [**PutUpdateField**](docs/PdfApi.md#putupdatefield) | **PUT** /pdf/\{name}/fields/\{fieldName} | Update field.
*PdfApi* | [**PutUpdateFields**](docs/PdfApi.md#putupdatefields) | **PUT** /pdf/\{name}/fields | Update fields.
*PdfApi* | [**PutWebInStorageToPdf**](docs/PdfApi.md#putwebinstoragetopdf) | **PUT** /pdf/\{name}/create/web | Convert web page to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutXfaPdfInRequestToAcroForm**](docs/PdfApi.md#putxfapdfinrequesttoacroform) | **PUT** /pdf/convert/xfatoacroform | Converts PDF document which contains XFA form (in request content) to PDF with AcroForm and uploads resulting file to storage.
*PdfApi* | [**PutXfaPdfInStorageToAcroForm**](docs/PdfApi.md#putxfapdfinstoragetoacroform) | **PUT** /pdf/\{name}/convert/xfatoacroform | Converts PDF document which contains XFA form (located on storage) to PDF with AcroForm and uploads resulting file to storage
*PdfApi* | [**PutXmlInStorageToPdf**](docs/PdfApi.md#putxmlinstoragetopdf) | **PUT** /pdf/\{name}/create/xml | Convert XML file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutXpsInStorageToPdf**](docs/PdfApi.md#putxpsinstoragetopdf) | **PUT** /pdf/\{name}/create/xps | Convert XPS file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutXslFoInStorageToPdf**](docs/PdfApi.md#putxslfoinstoragetopdf) | **PUT** /pdf/\{name}/create/xslfo | Convert XslFo file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**StorageExists**](docs/PdfApi.md#storageexists) | **GET** /pdf/storage/\{storageName}/exist | Check if storage exists
*PdfApi* | [**UploadFile**](docs/PdfApi.md#uploadfile) | **PUT** /pdf/storage/file/\{path} | Upload file


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AnnotationFlags](docs/AnnotationFlags.md)
 - [Model.AnnotationState](docs/AnnotationState.md)
 - [Model.AnnotationType](docs/AnnotationType.md)
 - [Model.AntialiasingProcessingType](docs/AntialiasingProcessingType.md)
 - [Model.AsposeResponse](docs/AsposeResponse.md)
 - [Model.Border](docs/Border.md)
 - [Model.BorderCornerStyle](docs/BorderCornerStyle.md)
 - [Model.BorderEffect](docs/BorderEffect.md)
 - [Model.BorderInfo](docs/BorderInfo.md)
 - [Model.BorderStyle](docs/BorderStyle.md)
 - [Model.BoxStyle](docs/BoxStyle.md)
 - [Model.CapStyle](docs/CapStyle.md)
 - [Model.CaptionPosition](docs/CaptionPosition.md)
 - [Model.CaretSymbol](docs/CaretSymbol.md)
 - [Model.Cell](docs/Cell.md)
 - [Model.CellRecognized](docs/CellRecognized.md)
 - [Model.Color](docs/Color.md)
 - [Model.ColorDepth](docs/ColorDepth.md)
 - [Model.ColumnAdjustment](docs/ColumnAdjustment.md)
 - [Model.CompressionType](docs/CompressionType.md)
 - [Model.CryptoAlgorithm](docs/CryptoAlgorithm.md)
 - [Model.Dash](docs/Dash.md)
 - [Model.DefaultPageConfig](docs/DefaultPageConfig.md)
 - [Model.Direction](docs/Direction.md)
 - [Model.DiscUsage](docs/DiscUsage.md)
 - [Model.DocFormat](docs/DocFormat.md)
 - [Model.DocMDPAccessPermissionType](docs/DocMDPAccessPermissionType.md)
 - [Model.DocRecognitionMode](docs/DocRecognitionMode.md)
 - [Model.DocumentConfig](docs/DocumentConfig.md)
 - [Model.DocumentPrivilege](docs/DocumentPrivilege.md)
 - [Model.EpubRecognitionMode](docs/EpubRecognitionMode.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorDetails](docs/ErrorDetails.md)
 - [Model.FieldType](docs/FieldType.md)
 - [Model.FileIcon](docs/FileIcon.md)
 - [Model.FileVersions](docs/FileVersions.md)
 - [Model.FilesList](docs/FilesList.md)
 - [Model.FilesUploadResult](docs/FilesUploadResult.md)
 - [Model.FontEncodingRules](docs/FontEncodingRules.md)
 - [Model.FontSavingModes](docs/FontSavingModes.md)
 - [Model.FontStyles](docs/FontStyles.md)
 - [Model.FreeTextIntent](docs/FreeTextIntent.md)
 - [Model.GraphInfo](docs/GraphInfo.md)
 - [Model.HorizontalAlignment](docs/HorizontalAlignment.md)
 - [Model.HtmlDocumentType](docs/HtmlDocumentType.md)
 - [Model.HtmlMarkupGenerationModes](docs/HtmlMarkupGenerationModes.md)
 - [Model.ImageCompressionVersion](docs/ImageCompressionVersion.md)
 - [Model.ImageEncoding](docs/ImageEncoding.md)
 - [Model.ImageFragment](docs/ImageFragment.md)
 - [Model.ImageSrcType](docs/ImageSrcType.md)
 - [Model.ImageTemplate](docs/ImageTemplate.md)
 - [Model.ImageTemplatesRequest](docs/ImageTemplatesRequest.md)
 - [Model.Justification](docs/Justification.md)
 - [Model.LettersPositioningMethods](docs/LettersPositioningMethods.md)
 - [Model.LineEnding](docs/LineEnding.md)
 - [Model.LineIntent](docs/LineIntent.md)
 - [Model.LineSpacing](docs/LineSpacing.md)
 - [Model.Link](docs/Link.md)
 - [Model.LinkActionType](docs/LinkActionType.md)
 - [Model.LinkElement](docs/LinkElement.md)
 - [Model.LinkHighlightingMode](docs/LinkHighlightingMode.md)
 - [Model.MarginInfo](docs/MarginInfo.md)
 - [Model.MergeDocuments](docs/MergeDocuments.md)
 - [Model.ObjectExist](docs/ObjectExist.md)
 - [Model.OptimizeOptions](docs/OptimizeOptions.md)
 - [Model.Option](docs/Option.md)
 - [Model.OutputFormat](docs/OutputFormat.md)
 - [Model.PageLayout](docs/PageLayout.md)
 - [Model.PageMode](docs/PageMode.md)
 - [Model.PageRange](docs/PageRange.md)
 - [Model.PageWordCount](docs/PageWordCount.md)
 - [Model.Paragraph](docs/Paragraph.md)
 - [Model.PartsEmbeddingModes](docs/PartsEmbeddingModes.md)
 - [Model.PdfAType](docs/PdfAType.md)
 - [Model.PermissionsFlags](docs/PermissionsFlags.md)
 - [Model.Point](docs/Point.md)
 - [Model.PolyIntent](docs/PolyIntent.md)
 - [Model.Position](docs/Position.md)
 - [Model.RasterImagesSavingModes](docs/RasterImagesSavingModes.md)
 - [Model.Rectangle](docs/Rectangle.md)
 - [Model.Rotation](docs/Rotation.md)
 - [Model.Row](docs/Row.md)
 - [Model.RowRecognized](docs/RowRecognized.md)
 - [Model.Segment](docs/Segment.md)
 - [Model.ShapeType](docs/ShapeType.md)
 - [Model.Signature](docs/Signature.md)
 - [Model.SignatureCustomAppearance](docs/SignatureCustomAppearance.md)
 - [Model.SignatureType](docs/SignatureType.md)
 - [Model.SoundEncoding](docs/SoundEncoding.md)
 - [Model.SoundIcon](docs/SoundIcon.md)
 - [Model.SplitRangePdfOptions](docs/SplitRangePdfOptions.md)
 - [Model.SplitResult](docs/SplitResult.md)
 - [Model.Stamp](docs/Stamp.md)
 - [Model.StampIcon](docs/StampIcon.md)
 - [Model.StampType](docs/StampType.md)
 - [Model.StorageExist](docs/StorageExist.md)
 - [Model.StorageFile](docs/StorageFile.md)
 - [Model.TableBroken](docs/TableBroken.md)
 - [Model.TextHorizontalAlignment](docs/TextHorizontalAlignment.md)
 - [Model.TextIcon](docs/TextIcon.md)
 - [Model.TextLine](docs/TextLine.md)
 - [Model.TextRect](docs/TextRect.md)
 - [Model.TextRects](docs/TextRects.md)
 - [Model.TextReplace](docs/TextReplace.md)
 - [Model.TextReplaceListRequest](docs/TextReplaceListRequest.md)
 - [Model.TextState](docs/TextState.md)
 - [Model.TextStyle](docs/TextStyle.md)
 - [Model.TimestampSettings](docs/TimestampSettings.md)
 - [Model.VerticalAlignment](docs/VerticalAlignment.md)
 - [Model.WordCount](docs/WordCount.md)
 - [Model.WrapMode](docs/WrapMode.md)
 - [Model.Annotation](docs/Annotation.md)
 - [Model.AnnotationsInfo](docs/AnnotationsInfo.md)
 - [Model.AnnotationsInfoResponse](docs/AnnotationsInfoResponse.md)
 - [Model.Attachment](docs/Attachment.md)
 - [Model.AttachmentResponse](docs/AttachmentResponse.md)
 - [Model.Attachments](docs/Attachments.md)
 - [Model.AttachmentsResponse](docs/AttachmentsResponse.md)
 - [Model.Bookmark](docs/Bookmark.md)
 - [Model.BookmarkResponse](docs/BookmarkResponse.md)
 - [Model.Bookmarks](docs/Bookmarks.md)
 - [Model.BookmarksResponse](docs/BookmarksResponse.md)
 - [Model.CaretAnnotationResponse](docs/CaretAnnotationResponse.md)
 - [Model.CaretAnnotations](docs/CaretAnnotations.md)
 - [Model.CaretAnnotationsResponse](docs/CaretAnnotationsResponse.md)
 - [Model.CheckBoxFieldResponse](docs/CheckBoxFieldResponse.md)
 - [Model.CheckBoxFields](docs/CheckBoxFields.md)
 - [Model.CheckBoxFieldsResponse](docs/CheckBoxFieldsResponse.md)
 - [Model.CircleAnnotationResponse](docs/CircleAnnotationResponse.md)
 - [Model.CircleAnnotations](docs/CircleAnnotations.md)
 - [Model.CircleAnnotationsResponse](docs/CircleAnnotationsResponse.md)
 - [Model.ComboBoxFieldResponse](docs/ComboBoxFieldResponse.md)
 - [Model.ComboBoxFields](docs/ComboBoxFields.md)
 - [Model.ComboBoxFieldsResponse](docs/ComboBoxFieldsResponse.md)
 - [Model.DisplayProperties](docs/DisplayProperties.md)
 - [Model.DisplayPropertiesResponse](docs/DisplayPropertiesResponse.md)
 - [Model.Document](docs/Document.md)
 - [Model.DocumentPageResponse](docs/DocumentPageResponse.md)
 - [Model.DocumentPagesResponse](docs/DocumentPagesResponse.md)
 - [Model.DocumentProperties](docs/DocumentProperties.md)
 - [Model.DocumentPropertiesResponse](docs/DocumentPropertiesResponse.md)
 - [Model.DocumentProperty](docs/DocumentProperty.md)
 - [Model.DocumentPropertyResponse](docs/DocumentPropertyResponse.md)
 - [Model.DocumentResponse](docs/DocumentResponse.md)
 - [Model.Field](docs/Field.md)
 - [Model.FieldResponse](docs/FieldResponse.md)
 - [Model.Fields](docs/Fields.md)
 - [Model.FieldsResponse](docs/FieldsResponse.md)
 - [Model.FileAttachmentAnnotationResponse](docs/FileAttachmentAnnotationResponse.md)
 - [Model.FileAttachmentAnnotations](docs/FileAttachmentAnnotations.md)
 - [Model.FileAttachmentAnnotationsResponse](docs/FileAttachmentAnnotationsResponse.md)
 - [Model.FileVersion](docs/FileVersion.md)
 - [Model.FormField](docs/FormField.md)
 - [Model.FreeTextAnnotationResponse](docs/FreeTextAnnotationResponse.md)
 - [Model.FreeTextAnnotations](docs/FreeTextAnnotations.md)
 - [Model.FreeTextAnnotationsResponse](docs/FreeTextAnnotationsResponse.md)
 - [Model.HighlightAnnotationResponse](docs/HighlightAnnotationResponse.md)
 - [Model.HighlightAnnotations](docs/HighlightAnnotations.md)
 - [Model.HighlightAnnotationsResponse](docs/HighlightAnnotationsResponse.md)
 - [Model.Image](docs/Image.md)
 - [Model.ImageResponse](docs/ImageResponse.md)
 - [Model.Images](docs/Images.md)
 - [Model.ImagesResponse](docs/ImagesResponse.md)
 - [Model.InkAnnotationResponse](docs/InkAnnotationResponse.md)
 - [Model.InkAnnotations](docs/InkAnnotations.md)
 - [Model.InkAnnotationsResponse](docs/InkAnnotationsResponse.md)
 - [Model.LineAnnotationResponse](docs/LineAnnotationResponse.md)
 - [Model.LineAnnotations](docs/LineAnnotations.md)
 - [Model.LineAnnotationsResponse](docs/LineAnnotationsResponse.md)
 - [Model.LinkAnnotation](docs/LinkAnnotation.md)
 - [Model.LinkAnnotationResponse](docs/LinkAnnotationResponse.md)
 - [Model.LinkAnnotations](docs/LinkAnnotations.md)
 - [Model.LinkAnnotationsResponse](docs/LinkAnnotationsResponse.md)
 - [Model.ListBoxFieldResponse](docs/ListBoxFieldResponse.md)
 - [Model.ListBoxFields](docs/ListBoxFields.md)
 - [Model.ListBoxFieldsResponse](docs/ListBoxFieldsResponse.md)
 - [Model.MovieAnnotationResponse](docs/MovieAnnotationResponse.md)
 - [Model.MovieAnnotations](docs/MovieAnnotations.md)
 - [Model.MovieAnnotationsResponse](docs/MovieAnnotationsResponse.md)
 - [Model.Page](docs/Page.md)
 - [Model.Pages](docs/Pages.md)
 - [Model.PolyLineAnnotationResponse](docs/PolyLineAnnotationResponse.md)
 - [Model.PolyLineAnnotations](docs/PolyLineAnnotations.md)
 - [Model.PolyLineAnnotationsResponse](docs/PolyLineAnnotationsResponse.md)
 - [Model.PolygonAnnotationResponse](docs/PolygonAnnotationResponse.md)
 - [Model.PolygonAnnotations](docs/PolygonAnnotations.md)
 - [Model.PolygonAnnotationsResponse](docs/PolygonAnnotationsResponse.md)
 - [Model.PopupAnnotationResponse](docs/PopupAnnotationResponse.md)
 - [Model.PopupAnnotations](docs/PopupAnnotations.md)
 - [Model.PopupAnnotationsResponse](docs/PopupAnnotationsResponse.md)
 - [Model.RadioButtonFieldResponse](docs/RadioButtonFieldResponse.md)
 - [Model.RadioButtonFields](docs/RadioButtonFields.md)
 - [Model.RadioButtonFieldsResponse](docs/RadioButtonFieldsResponse.md)
 - [Model.RedactionAnnotationResponse](docs/RedactionAnnotationResponse.md)
 - [Model.RedactionAnnotations](docs/RedactionAnnotations.md)
 - [Model.RedactionAnnotationsResponse](docs/RedactionAnnotationsResponse.md)
 - [Model.ScreenAnnotationResponse](docs/ScreenAnnotationResponse.md)
 - [Model.ScreenAnnotations](docs/ScreenAnnotations.md)
 - [Model.ScreenAnnotationsResponse](docs/ScreenAnnotationsResponse.md)
 - [Model.SignatureFieldResponse](docs/SignatureFieldResponse.md)
 - [Model.SignatureFields](docs/SignatureFields.md)
 - [Model.SignatureFieldsResponse](docs/SignatureFieldsResponse.md)
 - [Model.SignatureVerifyResponse](docs/SignatureVerifyResponse.md)
 - [Model.SoundAnnotationResponse](docs/SoundAnnotationResponse.md)
 - [Model.SoundAnnotations](docs/SoundAnnotations.md)
 - [Model.SoundAnnotationsResponse](docs/SoundAnnotationsResponse.md)
 - [Model.SplitResultDocument](docs/SplitResultDocument.md)
 - [Model.SplitResultResponse](docs/SplitResultResponse.md)
 - [Model.SquareAnnotationResponse](docs/SquareAnnotationResponse.md)
 - [Model.SquareAnnotations](docs/SquareAnnotations.md)
 - [Model.SquareAnnotationsResponse](docs/SquareAnnotationsResponse.md)
 - [Model.SquigglyAnnotationResponse](docs/SquigglyAnnotationResponse.md)
 - [Model.SquigglyAnnotations](docs/SquigglyAnnotations.md)
 - [Model.SquigglyAnnotationsResponse](docs/SquigglyAnnotationsResponse.md)
 - [Model.StampAnnotationResponse](docs/StampAnnotationResponse.md)
 - [Model.StampAnnotations](docs/StampAnnotations.md)
 - [Model.StampAnnotationsResponse](docs/StampAnnotationsResponse.md)
 - [Model.StampBase](docs/StampBase.md)
 - [Model.StampInfo](docs/StampInfo.md)
 - [Model.StampsInfo](docs/StampsInfo.md)
 - [Model.StampsInfoResponse](docs/StampsInfoResponse.md)
 - [Model.StrikeOutAnnotationResponse](docs/StrikeOutAnnotationResponse.md)
 - [Model.StrikeOutAnnotations](docs/StrikeOutAnnotations.md)
 - [Model.StrikeOutAnnotationsResponse](docs/StrikeOutAnnotationsResponse.md)
 - [Model.Table](docs/Table.md)
 - [Model.TableRecognized](docs/TableRecognized.md)
 - [Model.TableRecognizedResponse](docs/TableRecognizedResponse.md)
 - [Model.TablesRecognized](docs/TablesRecognized.md)
 - [Model.TablesRecognizedResponse](docs/TablesRecognizedResponse.md)
 - [Model.TextAnnotationResponse](docs/TextAnnotationResponse.md)
 - [Model.TextAnnotations](docs/TextAnnotations.md)
 - [Model.TextAnnotationsResponse](docs/TextAnnotationsResponse.md)
 - [Model.TextBoxFieldResponse](docs/TextBoxFieldResponse.md)
 - [Model.TextBoxFields](docs/TextBoxFields.md)
 - [Model.TextBoxFieldsResponse](docs/TextBoxFieldsResponse.md)
 - [Model.TextRectsResponse](docs/TextRectsResponse.md)
 - [Model.TextReplaceResponse](docs/TextReplaceResponse.md)
 - [Model.UnderlineAnnotationResponse](docs/UnderlineAnnotationResponse.md)
 - [Model.UnderlineAnnotations](docs/UnderlineAnnotations.md)
 - [Model.UnderlineAnnotationsResponse](docs/UnderlineAnnotationsResponse.md)
 - [Model.WordCountResponse](docs/WordCountResponse.md)
 - [Model.AnnotationInfo](docs/AnnotationInfo.md)
 - [Model.CheckBoxField](docs/CheckBoxField.md)
 - [Model.ChoiceField](docs/ChoiceField.md)
 - [Model.ImageFooter](docs/ImageFooter.md)
 - [Model.ImageHeader](docs/ImageHeader.md)
 - [Model.ImageStamp](docs/ImageStamp.md)
 - [Model.MarkupAnnotation](docs/MarkupAnnotation.md)
 - [Model.MovieAnnotation](docs/MovieAnnotation.md)
 - [Model.PageNumberStamp](docs/PageNumberStamp.md)
 - [Model.PdfPageStamp](docs/PdfPageStamp.md)
 - [Model.PopupAnnotation](docs/PopupAnnotation.md)
 - [Model.RadioButtonOptionField](docs/RadioButtonOptionField.md)
 - [Model.RedactionAnnotation](docs/RedactionAnnotation.md)
 - [Model.ScreenAnnotation](docs/ScreenAnnotation.md)
 - [Model.SignatureField](docs/SignatureField.md)
 - [Model.TextBoxField](docs/TextBoxField.md)
 - [Model.TextFooter](docs/TextFooter.md)
 - [Model.TextHeader](docs/TextHeader.md)
 - [Model.TextStamp](docs/TextStamp.md)
 - [Model.CaretAnnotation](docs/CaretAnnotation.md)
 - [Model.ComboBoxField](docs/ComboBoxField.md)
 - [Model.CommonFigureAnnotation](docs/CommonFigureAnnotation.md)
 - [Model.FileAttachmentAnnotation](docs/FileAttachmentAnnotation.md)
 - [Model.FreeTextAnnotation](docs/FreeTextAnnotation.md)
 - [Model.HighlightAnnotation](docs/HighlightAnnotation.md)
 - [Model.InkAnnotation](docs/InkAnnotation.md)
 - [Model.LineAnnotation](docs/LineAnnotation.md)
 - [Model.ListBoxField](docs/ListBoxField.md)
 - [Model.PolyAnnotation](docs/PolyAnnotation.md)
 - [Model.PopupAnnotationWithParent](docs/PopupAnnotationWithParent.md)
 - [Model.RadioButtonField](docs/RadioButtonField.md)
 - [Model.SoundAnnotation](docs/SoundAnnotation.md)
 - [Model.SquigglyAnnotation](docs/SquigglyAnnotation.md)
 - [Model.StampAnnotation](docs/StampAnnotation.md)
 - [Model.StrikeOutAnnotation](docs/StrikeOutAnnotation.md)
 - [Model.TextAnnotation](docs/TextAnnotation.md)
 - [Model.UnderlineAnnotation](docs/UnderlineAnnotation.md)
 - [Model.CircleAnnotation](docs/CircleAnnotation.md)
 - [Model.PolyLineAnnotation](docs/PolyLineAnnotation.md)
 - [Model.PolygonAnnotation](docs/PolygonAnnotation.md)
 - [Model.SquareAnnotation](docs/SquareAnnotation.md)

