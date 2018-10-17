# Aspose.Pdf for Cloud

- API version: 2.0
- SDK version: 18.9.0

[Aspose.Pdf for Cloud](https://products.aspose.cloud/pdf) is a true REST API that enables you to perform a wide range of document processing operations including creation, manipulation, conversion and rendering of Pdf documents in the cloud.

Our Cloud SDKs are wrappers around REST API in various programming languages, allowing you to process documents in language of your choice quickly and easily, gaining all benefits of strong types and IDE highlights. This repository contains new generation SDKs for Aspose.Pdf for Cloud and examples.

These SDKs are now fully supported. If you have any questions, see any bugs or have enhancement request, feel free to reach out to us at [Free Support Forums](https://forum.aspose.cloud/c/pdf).

## Currently Available SDKs

Currently available SDKs can be found [here](https://github.com/aspose-pdf-cloud).
To use theese SDKs, you will need App SID and App Key which can be looked up at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) (free registration in Aspose Cloud is required for this).

## Unit Tests
Aspose PDF SDK includes a suite of unit tests. These Unit Tests also serves as examples of how to use the Aspose PDF SDK.

## Licensing
All Aspose.Pdf for Cloud SDKs are licensed under [MIT License](LICENSE).

## Resources
+ [**Website**](https://www.aspose.cloud)
+ [**Product Home**](https://products.aspose.cloud/pdf/cloud)
+ [**Documentation**](https://docs.aspose.cloud/display/pdfcloud/Home)
+ [**Free Support Forum**](https://forum.aspose.cloud/c/pdf)
+ [**Paid Support Helpdesk**](https://helpdesk.aspose.cloud/)
+ [**Blog**](https://blog.aspose.cloud/category/pdf/)


<a name="dependencies"></a>
## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.2.2
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 11.0.2

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.aspose.cloud/v2.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PdfApi* | [**DeleteAnnotation**](docs/PdfApi.md#deleteannotation) | **DELETE** /pdf/\{name}/annotations/\{annotationId} | Delete document annotation by ID
*PdfApi* | [**DeleteDocumentAnnotations**](docs/PdfApi.md#deletedocumentannotations) | **DELETE** /pdf/\{name}/annotations | Delete all annotations from the document
*PdfApi* | [**DeleteDocumentLinkAnnotations**](docs/PdfApi.md#deletedocumentlinkannotations) | **DELETE** /pdf/\{name}/links | Delete all link annotations from the document
*PdfApi* | [**DeleteField**](docs/PdfApi.md#deletefield) | **DELETE** /pdf/\{name}/fields/\{fieldName} | Delete document field by name.
*PdfApi* | [**DeleteImage**](docs/PdfApi.md#deleteimage) | **DELETE** /pdf/\{name}/images/\{imageId} | Delete image from document page.
*PdfApi* | [**DeleteLinkAnnotation**](docs/PdfApi.md#deletelinkannotation) | **DELETE** /pdf/\{name}/links/\{linkId} | Delete document page link annotation by ID
*PdfApi* | [**DeletePage**](docs/PdfApi.md#deletepage) | **DELETE** /pdf/\{name}/pages/\{pageNumber} | Delete document page by its number.
*PdfApi* | [**DeletePageAnnotations**](docs/PdfApi.md#deletepageannotations) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/annotations | Delete all annotations from the page
*PdfApi* | [**DeletePageLinkAnnotations**](docs/PdfApi.md#deletepagelinkannotations) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/links | Delete all link annotations from the page
*PdfApi* | [**DeleteProperties**](docs/PdfApi.md#deleteproperties) | **DELETE** /pdf/\{name}/documentproperties | Delete custom document properties.
*PdfApi* | [**DeleteProperty**](docs/PdfApi.md#deleteproperty) | **DELETE** /pdf/\{name}/documentproperties/\{propertyName} | Delete document property.
*PdfApi* | [**GetDocument**](docs/PdfApi.md#getdocument) | **GET** /pdf/\{name} | Read common document info.
*PdfApi* | [**GetDocumentAnnotations**](docs/PdfApi.md#getdocumentannotations) | **GET** /pdf/\{name}/annotations | Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
*PdfApi* | [**GetDocumentAttachmentByIndex**](docs/PdfApi.md#getdocumentattachmentbyindex) | **GET** /pdf/\{name}/attachments/\{attachmentIndex} | Read document attachment info by its index.
*PdfApi* | [**GetDocumentAttachments**](docs/PdfApi.md#getdocumentattachments) | **GET** /pdf/\{name}/attachments | Read document attachments info.
*PdfApi* | [**GetDocumentBookmarks**](docs/PdfApi.md#getdocumentbookmarks) | **GET** /pdf/\{name}/bookmarks | Read document bookmark/bookmarks (including children).
*PdfApi* | [**GetDocumentFreeTextAnnotations**](docs/PdfApi.md#getdocumentfreetextannotations) | **GET** /pdf/\{name}/annotations/freetext | Read document free text annotations.
*PdfApi* | [**GetDocumentProperties**](docs/PdfApi.md#getdocumentproperties) | **GET** /pdf/\{name}/documentproperties | Read document properties.
*PdfApi* | [**GetDocumentProperty**](docs/PdfApi.md#getdocumentproperty) | **GET** /pdf/\{name}/documentproperties/\{propertyName} | Read document property by name.
*PdfApi* | [**GetDocumentTextAnnotations**](docs/PdfApi.md#getdocumenttextannotations) | **GET** /pdf/\{name}/annotations/text | Read document text annotations.
*PdfApi* | [**GetDownload**](docs/PdfApi.md#getdownload) | **GET** /storage/file | Download a specific file 
*PdfApi* | [**GetDownloadDocumentAttachmentByIndex**](docs/PdfApi.md#getdownloaddocumentattachmentbyindex) | **GET** /pdf/\{name}/attachments/\{attachmentIndex}/download | Download document attachment content by its index.
*PdfApi* | [**GetEpubInStorageToPdf**](docs/PdfApi.md#getepubinstoragetopdf) | **GET** /pdf/create/epub | Convert EPUB file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetField**](docs/PdfApi.md#getfield) | **GET** /pdf/\{name}/fields/\{fieldName} | Get document field by name.
*PdfApi* | [**GetFields**](docs/PdfApi.md#getfields) | **GET** /pdf/\{name}/fields | Get document fields.
*PdfApi* | [**GetFreeTextAnnotation**](docs/PdfApi.md#getfreetextannotation) | **GET** /pdf/\{name}/annotations/freetext/\{annotationId} | Read document page free text annotation by ID.
*PdfApi* | [**GetHtmlInStorageToPdf**](docs/PdfApi.md#gethtmlinstoragetopdf) | **GET** /pdf/create/html | Convert HTML file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetImage**](docs/PdfApi.md#getimage) | **GET** /pdf/\{name}/images/\{imageId} | Read document image by ID.
*PdfApi* | [**GetImageExtractAsGif**](docs/PdfApi.md#getimageextractasgif) | **GET** /pdf/\{name}/images/\{imageId}/extract/gif | Extract document image in GIF format
*PdfApi* | [**GetImageExtractAsJpeg**](docs/PdfApi.md#getimageextractasjpeg) | **GET** /pdf/\{name}/images/\{imageId}/extract/jpeg | Extract document image in JPEG format
*PdfApi* | [**GetImageExtractAsPng**](docs/PdfApi.md#getimageextractaspng) | **GET** /pdf/\{name}/images/\{imageId}/extract/png | Extract document image in PNG format
*PdfApi* | [**GetImageExtractAsTiff**](docs/PdfApi.md#getimageextractastiff) | **GET** /pdf/\{name}/images/\{imageId}/extract/tiff | Extract document image in TIFF format
*PdfApi* | [**GetImages**](docs/PdfApi.md#getimages) | **GET** /pdf/\{name}/pages/\{pageNumber}/images | Read document images.
*PdfApi* | [**GetLaTeXInStorageToPdf**](docs/PdfApi.md#getlatexinstoragetopdf) | **GET** /pdf/create/latex | Convert LaTeX file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetLinkAnnotation**](docs/PdfApi.md#getlinkannotation) | **GET** /pdf/\{name}/links/\{linkId} | Read document link annotation by ID.
*PdfApi* | [**GetMhtInStorageToPdf**](docs/PdfApi.md#getmhtinstoragetopdf) | **GET** /pdf/create/mht | Convert MHT file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetPage**](docs/PdfApi.md#getpage) | **GET** /pdf/\{name}/pages/\{pageNumber} | Read document page info.
*PdfApi* | [**GetPageAnnotations**](docs/PdfApi.md#getpageannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations | Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
*PdfApi* | [**GetPageConvertToBmp**](docs/PdfApi.md#getpageconverttobmp) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/bmp | Convert document page to Bmp image and return resulting file in response.
*PdfApi* | [**GetPageConvertToEmf**](docs/PdfApi.md#getpageconverttoemf) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/emf | Convert document page to Emf image and return resulting file in response.
*PdfApi* | [**GetPageConvertToGif**](docs/PdfApi.md#getpageconverttogif) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/gif | Convert document page to Gif image and return resulting file in response.
*PdfApi* | [**GetPageConvertToJpeg**](docs/PdfApi.md#getpageconverttojpeg) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/jpeg | Convert document page to Jpeg image and return resulting file in response.
*PdfApi* | [**GetPageConvertToPng**](docs/PdfApi.md#getpageconverttopng) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/png | Convert document page to Png image and return resulting file in response.
*PdfApi* | [**GetPageConvertToTiff**](docs/PdfApi.md#getpageconverttotiff) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/tiff | Convert document page to Tiff image  and return resulting file in response.
*PdfApi* | [**GetPageFreeTextAnnotations**](docs/PdfApi.md#getpagefreetextannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/freetext | Read document page free text annotations.
*PdfApi* | [**GetPageLinkAnnotation**](docs/PdfApi.md#getpagelinkannotation) | **GET** /pdf/\{name}/pages/\{pageNumber}/links/\{linkId} | Read document page link annotation by ID.
*PdfApi* | [**GetPageLinkAnnotations**](docs/PdfApi.md#getpagelinkannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/links | Read document page link annotations.
*PdfApi* | [**GetPageText**](docs/PdfApi.md#getpagetext) | **GET** /pdf/\{name}/pages/\{pageNumber}/text | Read page text items.
*PdfApi* | [**GetPageTextAnnotations**](docs/PdfApi.md#getpagetextannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/text | Read document page text annotations.
*PdfApi* | [**GetPages**](docs/PdfApi.md#getpages) | **GET** /pdf/\{name}/pages | Read document pages info.
*PdfApi* | [**GetPclInStorageToPdf**](docs/PdfApi.md#getpclinstoragetopdf) | **GET** /pdf/create/pcl | Convert PCL file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetPdfInStorageToDoc**](docs/PdfApi.md#getpdfinstoragetodoc) | **GET** /pdf/\{name}/convert/doc | Converts PDF document (located on storage) to DOC format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToEpub**](docs/PdfApi.md#getpdfinstoragetoepub) | **GET** /pdf/\{name}/convert/epub | Converts PDF document (located on storage) to EPUB format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToHtml**](docs/PdfApi.md#getpdfinstoragetohtml) | **GET** /pdf/\{name}/convert/html | Converts PDF document (located on storage) to Html format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToLaTeX**](docs/PdfApi.md#getpdfinstoragetolatex) | **GET** /pdf/\{name}/convert/latex | Converts PDF document (located on storage) to LaTeX format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToMobiXml**](docs/PdfApi.md#getpdfinstoragetomobixml) | **GET** /pdf/\{name}/convert/mobixml | Converts PDF document (located on storage) to MOBIXML format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToPdfA**](docs/PdfApi.md#getpdfinstoragetopdfa) | **GET** /pdf/\{name}/convert/pdfa | Converts PDF document (located on storage) to PdfA format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToPptx**](docs/PdfApi.md#getpdfinstoragetopptx) | **GET** /pdf/\{name}/convert/pptx | Converts PDF document (located on storage) to PPTX format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToSvg**](docs/PdfApi.md#getpdfinstoragetosvg) | **GET** /pdf/\{name}/convert/svg | Converts PDF document (located on storage) to SVG format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToTiff**](docs/PdfApi.md#getpdfinstoragetotiff) | **GET** /pdf/\{name}/convert/tiff | Converts PDF document (located on storage) to TIFF format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToXls**](docs/PdfApi.md#getpdfinstoragetoxls) | **GET** /pdf/\{name}/convert/xls | Converts PDF document (located on storage) to XLS format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToXml**](docs/PdfApi.md#getpdfinstoragetoxml) | **GET** /pdf/\{name}/convert/xml | Converts PDF document (located on storage) to XML format and returns resulting file in response content
*PdfApi* | [**GetPdfInStorageToXps**](docs/PdfApi.md#getpdfinstoragetoxps) | **GET** /pdf/\{name}/convert/xps | Converts PDF document (located on storage) to XPS format and returns resulting file in response content
*PdfApi* | [**GetPsInStorageToPdf**](docs/PdfApi.md#getpsinstoragetopdf) | **GET** /pdf/create/ps | Convert PS file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetSvgInStorageToPdf**](docs/PdfApi.md#getsvginstoragetopdf) | **GET** /pdf/create/svg | Convert SVG file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetText**](docs/PdfApi.md#gettext) | **GET** /pdf/\{name}/text | Read document text.
*PdfApi* | [**GetTextAnnotation**](docs/PdfApi.md#gettextannotation) | **GET** /pdf/\{name}/annotations/text/\{annotationId} | Read document page text annotation by ID.
*PdfApi* | [**GetVerifySignature**](docs/PdfApi.md#getverifysignature) | **GET** /pdf/\{name}/verifySignature | Verify signature document.
*PdfApi* | [**GetWebInStorageToPdf**](docs/PdfApi.md#getwebinstoragetopdf) | **GET** /pdf/create/web | Convert web page to PDF format and return resulting file in response. 
*PdfApi* | [**GetWordsPerPage**](docs/PdfApi.md#getwordsperpage) | **GET** /pdf/\{name}/pages/wordCount | Get number of words per document page.
*PdfApi* | [**GetXfaPdfInStorageToAcroForm**](docs/PdfApi.md#getxfapdfinstoragetoacroform) | **GET** /pdf/\{name}/convert/xfatoacroform | Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and returns resulting file response content
*PdfApi* | [**GetXmlInStorageToPdf**](docs/PdfApi.md#getxmlinstoragetopdf) | **GET** /pdf/create/xml | Convert XML file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetXpsInStorageToPdf**](docs/PdfApi.md#getxpsinstoragetopdf) | **GET** /pdf/create/xps | Convert XPS file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**GetXslFoInStorageToPdf**](docs/PdfApi.md#getxslfoinstoragetopdf) | **GET** /pdf/create/xslfo | Convert XslFo file (located on storage) to PDF format and return resulting file in response. 
*PdfApi* | [**PostAppendDocument**](docs/PdfApi.md#postappenddocument) | **POST** /pdf/\{name}/appendDocument | Append document to existing one.
*PdfApi* | [**PostCreateField**](docs/PdfApi.md#postcreatefield) | **POST** /pdf/\{name}/fields | Create field.
*PdfApi* | [**PostDocumentTextReplace**](docs/PdfApi.md#postdocumenttextreplace) | **POST** /pdf/\{name}/text/replace | Document's replace text method.
*PdfApi* | [**PostInsertImage**](docs/PdfApi.md#postinsertimage) | **POST** /pdf/\{name}/pages/\{pageNumber}/images | Insert image to document page.
*PdfApi* | [**PostMovePage**](docs/PdfApi.md#postmovepage) | **POST** /pdf/\{name}/pages/\{pageNumber}/movePage | Move page to new position.
*PdfApi* | [**PostOptimizeDocument**](docs/PdfApi.md#postoptimizedocument) | **POST** /pdf/\{name}/optimize | Optimize document.
*PdfApi* | [**PostPageFreeTextAnnotations**](docs/PdfApi.md#postpagefreetextannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/freetext | Add document page free text annotations.
*PdfApi* | [**PostPageLinkAnnotations**](docs/PdfApi.md#postpagelinkannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/links | Add document page link annotations.
*PdfApi* | [**PostPageTextAnnotations**](docs/PdfApi.md#postpagetextannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/text | Add document page text annotations.
*PdfApi* | [**PostPageTextReplace**](docs/PdfApi.md#postpagetextreplace) | **POST** /pdf/\{name}/pages/\{pageNumber}/text/replace | Page's replace text method.
*PdfApi* | [**PostSignDocument**](docs/PdfApi.md#postsigndocument) | **POST** /pdf/\{name}/sign | Sign document.
*PdfApi* | [**PostSignPage**](docs/PdfApi.md#postsignpage) | **POST** /pdf/\{name}/pages/\{pageNumber}/sign | Sign page.
*PdfApi* | [**PostSplitDocument**](docs/PdfApi.md#postsplitdocument) | **POST** /pdf/\{name}/split | Split document to parts.
*PdfApi* | [**PutAddNewPage**](docs/PdfApi.md#putaddnewpage) | **PUT** /pdf/\{name}/pages | Add new page to end of the document.
*PdfApi* | [**PutAddText**](docs/PdfApi.md#putaddtext) | **PUT** /pdf/\{name}/pages/\{pageNumber}/text | Add text to PDF document page.
*PdfApi* | [**PutCreate**](docs/PdfApi.md#putcreate) | **PUT** /storage/file | Upload a specific file 
*PdfApi* | [**PutCreateDocument**](docs/PdfApi.md#putcreatedocument) | **PUT** /pdf/\{name} | Create empty document.
*PdfApi* | [**PutEpubInStorageToPdf**](docs/PdfApi.md#putepubinstoragetopdf) | **PUT** /pdf/\{name}/create/epub | Convert EPUB file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutFieldsFlatten**](docs/PdfApi.md#putfieldsflatten) | **PUT** /pdf/\{name}/fields/flatten | Flatten form fields in document.
*PdfApi* | [**PutFreeTextAnnotation**](docs/PdfApi.md#putfreetextannotation) | **PUT** /pdf/\{name}/annotations/freetext/\{annotationId} | Replace document free text annotation
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
*PdfApi* | [**PutLaTeXInStorageToPdf**](docs/PdfApi.md#putlatexinstoragetopdf) | **PUT** /pdf/\{name}/create/latex | Convert LaTeX file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutLinkAnnotation**](docs/PdfApi.md#putlinkannotation) | **PUT** /pdf/\{name}/links/\{linkId} | Replace document page link annotations
*PdfApi* | [**PutMergeDocuments**](docs/PdfApi.md#putmergedocuments) | **PUT** /pdf/\{name}/merge | Merge a list of documents.
*PdfApi* | [**PutMhtInStorageToPdf**](docs/PdfApi.md#putmhtinstoragetopdf) | **PUT** /pdf/\{name}/create/mht | Convert MHT file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutPageAddStamp**](docs/PdfApi.md#putpageaddstamp) | **PUT** /pdf/\{name}/pages/\{pageNumber}/stamp | Add page stamp.
*PdfApi* | [**PutPageConvertToBmp**](docs/PdfApi.md#putpageconverttobmp) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/bmp | Convert document page to bmp image and upload resulting file to storage.
*PdfApi* | [**PutPageConvertToEmf**](docs/PdfApi.md#putpageconverttoemf) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/emf | Convert document page to emf image and upload resulting file to storage.
*PdfApi* | [**PutPageConvertToGif**](docs/PdfApi.md#putpageconverttogif) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/gif | Convert document page to gif image and upload resulting file to storage.
*PdfApi* | [**PutPageConvertToJpeg**](docs/PdfApi.md#putpageconverttojpeg) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/jpeg | Convert document page to Jpeg image and upload resulting file to storage.
*PdfApi* | [**PutPageConvertToPng**](docs/PdfApi.md#putpageconverttopng) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/png | Convert document page to png image and upload resulting file to storage.
*PdfApi* | [**PutPageConvertToTiff**](docs/PdfApi.md#putpageconverttotiff) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/tiff | Convert document page to Tiff image and upload resulting file to storage.
*PdfApi* | [**PutPclInStorageToPdf**](docs/PdfApi.md#putpclinstoragetopdf) | **PUT** /pdf/\{name}/create/pcl | Convert PCL file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutPdfInRequestToDoc**](docs/PdfApi.md#putpdfinrequesttodoc) | **PUT** /pdf/convert/doc | Converts PDF document (in request content) to DOC format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToEpub**](docs/PdfApi.md#putpdfinrequesttoepub) | **PUT** /pdf/convert/epub | Converts PDF document (in request content) to EPUB format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToHtml**](docs/PdfApi.md#putpdfinrequesttohtml) | **PUT** /pdf/convert/html | Converts PDF document (in request content) to Html format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToLaTeX**](docs/PdfApi.md#putpdfinrequesttolatex) | **PUT** /pdf/convert/latex | Converts PDF document (in request content) to LaTeX format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToMobiXml**](docs/PdfApi.md#putpdfinrequesttomobixml) | **PUT** /pdf/convert/mobixml | Converts PDF document (in request content) to MOBIXML format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToPdfA**](docs/PdfApi.md#putpdfinrequesttopdfa) | **PUT** /pdf/convert/pdfa | Converts PDF document (in request content) to PdfA format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToPptx**](docs/PdfApi.md#putpdfinrequesttopptx) | **PUT** /pdf/convert/pptx | Converts PDF document (in request content) to PPTX format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToSvg**](docs/PdfApi.md#putpdfinrequesttosvg) | **PUT** /pdf/convert/svg | Converts PDF document (in request content) to SVG format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToTiff**](docs/PdfApi.md#putpdfinrequesttotiff) | **PUT** /pdf/convert/tiff | Converts PDF document (in request content) to TIFF format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToXls**](docs/PdfApi.md#putpdfinrequesttoxls) | **PUT** /pdf/convert/xls | Converts PDF document (in request content) to XLS format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToXml**](docs/PdfApi.md#putpdfinrequesttoxml) | **PUT** /pdf/convert/xml | Converts PDF document (in request content) to XML format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInRequestToXps**](docs/PdfApi.md#putpdfinrequesttoxps) | **PUT** /pdf/convert/xps | Converts PDF document (in request content) to XPS format and uploads resulting file to storage.
*PdfApi* | [**PutPdfInStorageToDoc**](docs/PdfApi.md#putpdfinstoragetodoc) | **PUT** /pdf/\{name}/convert/doc | Converts PDF document (located on storage) to DOC format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToEpub**](docs/PdfApi.md#putpdfinstoragetoepub) | **PUT** /pdf/\{name}/convert/epub | Converts PDF document (located on storage) to EPUB format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToHtml**](docs/PdfApi.md#putpdfinstoragetohtml) | **PUT** /pdf/\{name}/convert/html | Converts PDF document (located on storage) to Html format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToLaTeX**](docs/PdfApi.md#putpdfinstoragetolatex) | **PUT** /pdf/\{name}/convert/latex | Converts PDF document (located on storage) to LaTeX format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToMobiXml**](docs/PdfApi.md#putpdfinstoragetomobixml) | **PUT** /pdf/\{name}/convert/mobixml | Converts PDF document (located on storage) to MOBIXML format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToPdfA**](docs/PdfApi.md#putpdfinstoragetopdfa) | **PUT** /pdf/\{name}/convert/pdfa | Converts PDF document (located on storage) to PdfA format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToPptx**](docs/PdfApi.md#putpdfinstoragetopptx) | **PUT** /pdf/\{name}/convert/pptx | Converts PDF document (located on storage) to PPTX format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToSvg**](docs/PdfApi.md#putpdfinstoragetosvg) | **PUT** /pdf/\{name}/convert/svg | Converts PDF document (located on storage) to SVG format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToTiff**](docs/PdfApi.md#putpdfinstoragetotiff) | **PUT** /pdf/\{name}/convert/tiff | Converts PDF document (located on storage) to TIFF format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToXls**](docs/PdfApi.md#putpdfinstoragetoxls) | **PUT** /pdf/\{name}/convert/xls | Converts PDF document (located on storage) to XLS format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToXml**](docs/PdfApi.md#putpdfinstoragetoxml) | **PUT** /pdf/\{name}/convert/xml | Converts PDF document (located on storage) to XML format and uploads resulting file to storage
*PdfApi* | [**PutPdfInStorageToXps**](docs/PdfApi.md#putpdfinstoragetoxps) | **PUT** /pdf/\{name}/convert/xps | Converts PDF document (located on storage) to XPS format and uploads resulting file to storage
*PdfApi* | [**PutPrivileges**](docs/PdfApi.md#putprivileges) | **PUT** /pdf/\{name}/privileges | Update privilege document.
*PdfApi* | [**PutPsInStorageToPdf**](docs/PdfApi.md#putpsinstoragetopdf) | **PUT** /pdf/\{name}/create/ps | Convert PS file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutReplaceImage**](docs/PdfApi.md#putreplaceimage) | **PUT** /pdf/\{name}/images/\{imageId} | Replace document image.
*PdfApi* | [**PutSearchableDocument**](docs/PdfApi.md#putsearchabledocument) | **PUT** /pdf/\{name}/ocr | Create searchable PDF document. Generate OCR layer for images in input PDF document.
*PdfApi* | [**PutSetProperty**](docs/PdfApi.md#putsetproperty) | **PUT** /pdf/\{name}/documentproperties/\{propertyName} | Add/update document property.
*PdfApi* | [**PutSvgInStorageToPdf**](docs/PdfApi.md#putsvginstoragetopdf) | **PUT** /pdf/\{name}/create/svg | Convert SVG file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutTextAnnotation**](docs/PdfApi.md#puttextannotation) | **PUT** /pdf/\{name}/annotations/text/\{annotationId} | Replace document text annotation
*PdfApi* | [**PutUpdateField**](docs/PdfApi.md#putupdatefield) | **PUT** /pdf/\{name}/fields/\{fieldName} | Update field.
*PdfApi* | [**PutUpdateFields**](docs/PdfApi.md#putupdatefields) | **PUT** /pdf/\{name}/fields | Update fields.
*PdfApi* | [**PutWebInStorageToPdf**](docs/PdfApi.md#putwebinstoragetopdf) | **PUT** /pdf/\{name}/create/web | Convert web page to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutXfaPdfInRequestToAcroForm**](docs/PdfApi.md#putxfapdfinrequesttoacroform) | **PUT** /pdf/convert/xfatoacroform | Converts PDF document which contatins XFA form (in request content) to PDF with AcroForm and uploads resulting file to storage.
*PdfApi* | [**PutXfaPdfInStorageToAcroForm**](docs/PdfApi.md#putxfapdfinstoragetoacroform) | **PUT** /pdf/\{name}/convert/xfatoacroform | Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and uploads resulting file to storage
*PdfApi* | [**PutXmlInStorageToPdf**](docs/PdfApi.md#putxmlinstoragetopdf) | **PUT** /pdf/\{name}/create/xml | Convert XML file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutXpsInStorageToPdf**](docs/PdfApi.md#putxpsinstoragetopdf) | **PUT** /pdf/\{name}/create/xps | Convert XPS file (located on storage) to PDF format and upload resulting file to storage. 
*PdfApi* | [**PutXslFoInStorageToPdf**](docs/PdfApi.md#putxslfoinstoragetopdf) | **PUT** /pdf/\{name}/create/xslfo | Convert XslFo file (located on storage) to PDF format and upload resulting file to storage. 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AnnotationFlags](docs/AnnotationFlags.md)
 - [Model.AnnotationState](docs/AnnotationState.md)
 - [Model.AnnotationType](docs/AnnotationType.md)
 - [Model.AntialiasingProcessingType](docs/AntialiasingProcessingType.md)
 - [Model.AppendDocument](docs/AppendDocument.md)
 - [Model.AsposeResponse](docs/AsposeResponse.md)
 - [Model.Color](docs/Color.md)
 - [Model.ColorDepth](docs/ColorDepth.md)
 - [Model.CompressionType](docs/CompressionType.md)
 - [Model.DocFormat](docs/DocFormat.md)
 - [Model.DocRecognitionMode](docs/DocRecognitionMode.md)
 - [Model.DocumentPrivilege](docs/DocumentPrivilege.md)
 - [Model.EpubRecognitionMode](docs/EpubRecognitionMode.md)
 - [Model.FieldType](docs/FieldType.md)
 - [Model.FontEncodingRules](docs/FontEncodingRules.md)
 - [Model.FontSavingModes](docs/FontSavingModes.md)
 - [Model.FontStyles](docs/FontStyles.md)
 - [Model.FreeTextIntent](docs/FreeTextIntent.md)
 - [Model.HorizontalAlignment](docs/HorizontalAlignment.md)
 - [Model.HtmlDocumentType](docs/HtmlDocumentType.md)
 - [Model.HtmlMarkupGenerationModes](docs/HtmlMarkupGenerationModes.md)
 - [Model.ImageSrcType](docs/ImageSrcType.md)
 - [Model.ImageTemplate](docs/ImageTemplate.md)
 - [Model.ImageTemplatesRequest](docs/ImageTemplatesRequest.md)
 - [Model.Justification](docs/Justification.md)
 - [Model.LettersPositioningMethods](docs/LettersPositioningMethods.md)
 - [Model.LineSpacing](docs/LineSpacing.md)
 - [Model.Link](docs/Link.md)
 - [Model.LinkActionType](docs/LinkActionType.md)
 - [Model.LinkElement](docs/LinkElement.md)
 - [Model.LinkHighlightingMode](docs/LinkHighlightingMode.md)
 - [Model.MarginInfo](docs/MarginInfo.md)
 - [Model.MergeDocuments](docs/MergeDocuments.md)
 - [Model.OptimizeOptions](docs/OptimizeOptions.md)
 - [Model.PageWordCount](docs/PageWordCount.md)
 - [Model.Paragraph](docs/Paragraph.md)
 - [Model.PartsEmbeddingModes](docs/PartsEmbeddingModes.md)
 - [Model.PdfAType](docs/PdfAType.md)
 - [Model.RasterImagesSavingModes](docs/RasterImagesSavingModes.md)
 - [Model.RectanglePdf](docs/RectanglePdf.md)
 - [Model.Rotation](docs/Rotation.md)
 - [Model.Segment](docs/Segment.md)
 - [Model.ShapeType](docs/ShapeType.md)
 - [Model.Signature](docs/Signature.md)
 - [Model.SignatureType](docs/SignatureType.md)
 - [Model.SplitResult](docs/SplitResult.md)
 - [Model.Stamp](docs/Stamp.md)
 - [Model.StampType](docs/StampType.md)
 - [Model.TextHorizontalAlignment](docs/TextHorizontalAlignment.md)
 - [Model.TextIcon](docs/TextIcon.md)
 - [Model.TextLine](docs/TextLine.md)
 - [Model.TextRect](docs/TextRect.md)
 - [Model.TextRects](docs/TextRects.md)
 - [Model.TextReplace](docs/TextReplace.md)
 - [Model.TextReplaceListRequest](docs/TextReplaceListRequest.md)
 - [Model.TextState](docs/TextState.md)
 - [Model.TextStyle](docs/TextStyle.md)
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
 - [Model.FreeTextAnnotationResponse](docs/FreeTextAnnotationResponse.md)
 - [Model.FreeTextAnnotations](docs/FreeTextAnnotations.md)
 - [Model.FreeTextAnnotationsResponse](docs/FreeTextAnnotationsResponse.md)
 - [Model.Image](docs/Image.md)
 - [Model.ImageResponse](docs/ImageResponse.md)
 - [Model.Images](docs/Images.md)
 - [Model.ImagesResponse](docs/ImagesResponse.md)
 - [Model.LinkAnnotation](docs/LinkAnnotation.md)
 - [Model.LinkAnnotationResponse](docs/LinkAnnotationResponse.md)
 - [Model.LinkAnnotations](docs/LinkAnnotations.md)
 - [Model.LinkAnnotationsResponse](docs/LinkAnnotationsResponse.md)
 - [Model.Page](docs/Page.md)
 - [Model.Pages](docs/Pages.md)
 - [Model.SignatureVerifyResponse](docs/SignatureVerifyResponse.md)
 - [Model.SplitResultDocument](docs/SplitResultDocument.md)
 - [Model.SplitResultResponse](docs/SplitResultResponse.md)
 - [Model.TextAnnotationResponse](docs/TextAnnotationResponse.md)
 - [Model.TextAnnotations](docs/TextAnnotations.md)
 - [Model.TextAnnotationsResponse](docs/TextAnnotationsResponse.md)
 - [Model.TextRectsResponse](docs/TextRectsResponse.md)
 - [Model.TextReplaceResponse](docs/TextReplaceResponse.md)
 - [Model.WordCountResponse](docs/WordCountResponse.md)
 - [Model.AnnotationInfo](docs/AnnotationInfo.md)
 - [Model.MarkupAnnotation](docs/MarkupAnnotation.md)
 - [Model.FreeTextAnnotation](docs/FreeTextAnnotation.md)
 - [Model.TextAnnotation](docs/TextAnnotation.md)

