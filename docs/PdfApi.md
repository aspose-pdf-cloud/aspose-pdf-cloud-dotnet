# Aspose.Pdf.Cloud.Sdk.Api.PdfApi

All URIs are relative to *https://api.aspose.cloud/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAnnotation**](PdfApi.md#deleteannotation) | **DELETE** /pdf/\{name}/annotations/\{annotationId} | Delete document annotation by ID
[**DeleteDocumentAnnotations**](PdfApi.md#deletedocumentannotations) | **DELETE** /pdf/\{name}/annotations | Delete all annotations from the document
[**DeleteDocumentLinkAnnotations**](PdfApi.md#deletedocumentlinkannotations) | **DELETE** /pdf/\{name}/links | Delete all link annotations from the document
[**DeleteField**](PdfApi.md#deletefield) | **DELETE** /pdf/\{name}/fields/\{fieldName} | Delete document field by name.
[**DeleteImage**](PdfApi.md#deleteimage) | **DELETE** /pdf/\{name}/images/\{imageId} | Delete image from document page.
[**DeleteLinkAnnotation**](PdfApi.md#deletelinkannotation) | **DELETE** /pdf/\{name}/links/\{linkId} | Delete document page link annotation by ID
[**DeletePage**](PdfApi.md#deletepage) | **DELETE** /pdf/\{name}/pages/\{pageNumber} | Delete document page by its number.
[**DeletePageAnnotations**](PdfApi.md#deletepageannotations) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/annotations | Delete all annotations from the page
[**DeletePageLinkAnnotations**](PdfApi.md#deletepagelinkannotations) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/links | Delete all link annotations from the page
[**DeleteProperties**](PdfApi.md#deleteproperties) | **DELETE** /pdf/\{name}/documentproperties | Delete custom document properties.
[**DeleteProperty**](PdfApi.md#deleteproperty) | **DELETE** /pdf/\{name}/documentproperties/\{propertyName} | Delete document property.
[**GetDocument**](PdfApi.md#getdocument) | **GET** /pdf/\{name} | Read common document info.
[**GetDocumentAnnotations**](PdfApi.md#getdocumentannotations) | **GET** /pdf/\{name}/annotations | Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
[**GetDocumentAttachmentByIndex**](PdfApi.md#getdocumentattachmentbyindex) | **GET** /pdf/\{name}/attachments/\{attachmentIndex} | Read document attachment info by its index.
[**GetDocumentAttachments**](PdfApi.md#getdocumentattachments) | **GET** /pdf/\{name}/attachments | Read document attachments info.
[**GetDocumentBookmarks**](PdfApi.md#getdocumentbookmarks) | **GET** /pdf/\{name}/bookmarks | Read document bookmark/bookmarks (including children).
[**GetDocumentFreeTextAnnotations**](PdfApi.md#getdocumentfreetextannotations) | **GET** /pdf/\{name}/annotations/freetext | Read document free text annotations.
[**GetDocumentProperties**](PdfApi.md#getdocumentproperties) | **GET** /pdf/\{name}/documentproperties | Read document properties.
[**GetDocumentProperty**](PdfApi.md#getdocumentproperty) | **GET** /pdf/\{name}/documentproperties/\{propertyName} | Read document property by name.
[**GetDocumentTextAnnotations**](PdfApi.md#getdocumenttextannotations) | **GET** /pdf/\{name}/annotations/text | Read document text annotations.
[**GetDownload**](PdfApi.md#getdownload) | **GET** /storage/file | Download a specific file 
[**GetDownloadDocumentAttachmentByIndex**](PdfApi.md#getdownloaddocumentattachmentbyindex) | **GET** /pdf/\{name}/attachments/\{attachmentIndex}/download | Download document attachment content by its index.
[**GetEpubInStorageToPdf**](PdfApi.md#getepubinstoragetopdf) | **GET** /pdf/create/epub | Convert EPUB file (located on storage) to PDF format and return resulting file in response. 
[**GetField**](PdfApi.md#getfield) | **GET** /pdf/\{name}/fields/\{fieldName} | Get document field by name.
[**GetFields**](PdfApi.md#getfields) | **GET** /pdf/\{name}/fields | Get document fields.
[**GetFreeTextAnnotation**](PdfApi.md#getfreetextannotation) | **GET** /pdf/\{name}/annotations/freetext/\{annotationId} | Read document page free text annotation by ID.
[**GetHtmlInStorageToPdf**](PdfApi.md#gethtmlinstoragetopdf) | **GET** /pdf/create/html | Convert HTML file (located on storage) to PDF format and return resulting file in response. 
[**GetImage**](PdfApi.md#getimage) | **GET** /pdf/\{name}/images/\{imageId} | Read document image by ID.
[**GetImageExtractAsGif**](PdfApi.md#getimageextractasgif) | **GET** /pdf/\{name}/images/\{imageId}/extract/gif | Extract document image in GIF format
[**GetImageExtractAsJpeg**](PdfApi.md#getimageextractasjpeg) | **GET** /pdf/\{name}/images/\{imageId}/extract/jpeg | Extract document image in JPEG format
[**GetImageExtractAsPng**](PdfApi.md#getimageextractaspng) | **GET** /pdf/\{name}/images/\{imageId}/extract/png | Extract document image in PNG format
[**GetImageExtractAsTiff**](PdfApi.md#getimageextractastiff) | **GET** /pdf/\{name}/images/\{imageId}/extract/tiff | Extract document image in TIFF format
[**GetImages**](PdfApi.md#getimages) | **GET** /pdf/\{name}/pages/\{pageNumber}/images | Read document images.
[**GetLaTeXInStorageToPdf**](PdfApi.md#getlatexinstoragetopdf) | **GET** /pdf/create/latex | Convert LaTeX file (located on storage) to PDF format and return resulting file in response. 
[**GetLinkAnnotation**](PdfApi.md#getlinkannotation) | **GET** /pdf/\{name}/links/\{linkId} | Read document link annotation by ID.
[**GetMhtInStorageToPdf**](PdfApi.md#getmhtinstoragetopdf) | **GET** /pdf/create/mht | Convert MHT file (located on storage) to PDF format and return resulting file in response. 
[**GetPage**](PdfApi.md#getpage) | **GET** /pdf/\{name}/pages/\{pageNumber} | Read document page info.
[**GetPageAnnotations**](PdfApi.md#getpageannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations | Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
[**GetPageConvertToBmp**](PdfApi.md#getpageconverttobmp) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/bmp | Convert document page to Bmp image and return resulting file in response.
[**GetPageConvertToEmf**](PdfApi.md#getpageconverttoemf) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/emf | Convert document page to Emf image and return resulting file in response.
[**GetPageConvertToGif**](PdfApi.md#getpageconverttogif) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/gif | Convert document page to Gif image and return resulting file in response.
[**GetPageConvertToJpeg**](PdfApi.md#getpageconverttojpeg) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/jpeg | Convert document page to Jpeg image and return resulting file in response.
[**GetPageConvertToPng**](PdfApi.md#getpageconverttopng) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/png | Convert document page to Png image and return resulting file in response.
[**GetPageConvertToTiff**](PdfApi.md#getpageconverttotiff) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/tiff | Convert document page to Tiff image  and return resulting file in response.
[**GetPageFreeTextAnnotations**](PdfApi.md#getpagefreetextannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/freetext | Read document page free text annotations.
[**GetPageLinkAnnotation**](PdfApi.md#getpagelinkannotation) | **GET** /pdf/\{name}/pages/\{pageNumber}/links/\{linkId} | Read document page link annotation by ID.
[**GetPageLinkAnnotations**](PdfApi.md#getpagelinkannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/links | Read document page link annotations.
[**GetPageText**](PdfApi.md#getpagetext) | **GET** /pdf/\{name}/pages/\{pageNumber}/text | Read page text items.
[**GetPageTextAnnotations**](PdfApi.md#getpagetextannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/text | Read document page text annotations.
[**GetPages**](PdfApi.md#getpages) | **GET** /pdf/\{name}/pages | Read document pages info.
[**GetPclInStorageToPdf**](PdfApi.md#getpclinstoragetopdf) | **GET** /pdf/create/pcl | Convert PCL file (located on storage) to PDF format and return resulting file in response. 
[**GetPdfInStorageToDoc**](PdfApi.md#getpdfinstoragetodoc) | **GET** /pdf/\{name}/convert/doc | Converts PDF document (located on storage) to DOC format and returns resulting file in response content
[**GetPdfInStorageToEpub**](PdfApi.md#getpdfinstoragetoepub) | **GET** /pdf/\{name}/convert/epub | Converts PDF document (located on storage) to EPUB format and returns resulting file in response content
[**GetPdfInStorageToHtml**](PdfApi.md#getpdfinstoragetohtml) | **GET** /pdf/\{name}/convert/html | Converts PDF document (located on storage) to Html format and returns resulting file in response content
[**GetPdfInStorageToLaTeX**](PdfApi.md#getpdfinstoragetolatex) | **GET** /pdf/\{name}/convert/latex | Converts PDF document (located on storage) to LaTeX format and returns resulting file in response content
[**GetPdfInStorageToMobiXml**](PdfApi.md#getpdfinstoragetomobixml) | **GET** /pdf/\{name}/convert/mobixml | Converts PDF document (located on storage) to MOBIXML format and returns resulting file in response content
[**GetPdfInStorageToPdfA**](PdfApi.md#getpdfinstoragetopdfa) | **GET** /pdf/\{name}/convert/pdfa | Converts PDF document (located on storage) to PdfA format and returns resulting file in response content
[**GetPdfInStorageToPptx**](PdfApi.md#getpdfinstoragetopptx) | **GET** /pdf/\{name}/convert/pptx | Converts PDF document (located on storage) to PPTX format and returns resulting file in response content
[**GetPdfInStorageToSvg**](PdfApi.md#getpdfinstoragetosvg) | **GET** /pdf/\{name}/convert/svg | Converts PDF document (located on storage) to SVG format and returns resulting file in response content
[**GetPdfInStorageToTiff**](PdfApi.md#getpdfinstoragetotiff) | **GET** /pdf/\{name}/convert/tiff | Converts PDF document (located on storage) to TIFF format and returns resulting file in response content
[**GetPdfInStorageToXls**](PdfApi.md#getpdfinstoragetoxls) | **GET** /pdf/\{name}/convert/xls | Converts PDF document (located on storage) to XLS format and returns resulting file in response content
[**GetPdfInStorageToXml**](PdfApi.md#getpdfinstoragetoxml) | **GET** /pdf/\{name}/convert/xml | Converts PDF document (located on storage) to XML format and returns resulting file in response content
[**GetPdfInStorageToXps**](PdfApi.md#getpdfinstoragetoxps) | **GET** /pdf/\{name}/convert/xps | Converts PDF document (located on storage) to XPS format and returns resulting file in response content
[**GetPsInStorageToPdf**](PdfApi.md#getpsinstoragetopdf) | **GET** /pdf/create/ps | Convert PS file (located on storage) to PDF format and return resulting file in response. 
[**GetSvgInStorageToPdf**](PdfApi.md#getsvginstoragetopdf) | **GET** /pdf/create/svg | Convert SVG file (located on storage) to PDF format and return resulting file in response. 
[**GetText**](PdfApi.md#gettext) | **GET** /pdf/\{name}/text | Read document text.
[**GetTextAnnotation**](PdfApi.md#gettextannotation) | **GET** /pdf/\{name}/annotations/text/\{annotationId} | Read document page text annotation by ID.
[**GetVerifySignature**](PdfApi.md#getverifysignature) | **GET** /pdf/\{name}/verifySignature | Verify signature document.
[**GetWebInStorageToPdf**](PdfApi.md#getwebinstoragetopdf) | **GET** /pdf/create/web | Convert web page to PDF format and return resulting file in response. 
[**GetWordsPerPage**](PdfApi.md#getwordsperpage) | **GET** /pdf/\{name}/pages/wordCount | Get number of words per document page.
[**GetXfaPdfInStorageToAcroForm**](PdfApi.md#getxfapdfinstoragetoacroform) | **GET** /pdf/\{name}/convert/xfatoacroform | Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and returns resulting file response content
[**GetXmlInStorageToPdf**](PdfApi.md#getxmlinstoragetopdf) | **GET** /pdf/create/xml | Convert XML file (located on storage) to PDF format and return resulting file in response. 
[**GetXpsInStorageToPdf**](PdfApi.md#getxpsinstoragetopdf) | **GET** /pdf/create/xps | Convert XPS file (located on storage) to PDF format and return resulting file in response. 
[**GetXslFoInStorageToPdf**](PdfApi.md#getxslfoinstoragetopdf) | **GET** /pdf/create/xslfo | Convert XslFo file (located on storage) to PDF format and return resulting file in response. 
[**PostAppendDocument**](PdfApi.md#postappenddocument) | **POST** /pdf/\{name}/appendDocument | Append document to existing one.
[**PostCreateField**](PdfApi.md#postcreatefield) | **POST** /pdf/\{name}/fields | Create field.
[**PostDocumentTextReplace**](PdfApi.md#postdocumenttextreplace) | **POST** /pdf/\{name}/text/replace | Document&#39;s replace text method.
[**PostInsertImage**](PdfApi.md#postinsertimage) | **POST** /pdf/\{name}/pages/\{pageNumber}/images | Insert image to document page.
[**PostMovePage**](PdfApi.md#postmovepage) | **POST** /pdf/\{name}/pages/\{pageNumber}/movePage | Move page to new position.
[**PostOptimizeDocument**](PdfApi.md#postoptimizedocument) | **POST** /pdf/\{name}/optimize | Optimize document.
[**PostPageFreeTextAnnotations**](PdfApi.md#postpagefreetextannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/freetext | Add document page free text annotations.
[**PostPageLinkAnnotations**](PdfApi.md#postpagelinkannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/links | Add document page link annotations.
[**PostPageTextAnnotations**](PdfApi.md#postpagetextannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/text | Add document page text annotations.
[**PostPageTextReplace**](PdfApi.md#postpagetextreplace) | **POST** /pdf/\{name}/pages/\{pageNumber}/text/replace | Page&#39;s replace text method.
[**PostSignDocument**](PdfApi.md#postsigndocument) | **POST** /pdf/\{name}/sign | Sign document.
[**PostSignPage**](PdfApi.md#postsignpage) | **POST** /pdf/\{name}/pages/\{pageNumber}/sign | Sign page.
[**PostSplitDocument**](PdfApi.md#postsplitdocument) | **POST** /pdf/\{name}/split | Split document to parts.
[**PutAddNewPage**](PdfApi.md#putaddnewpage) | **PUT** /pdf/\{name}/pages | Add new page to end of the document.
[**PutAddText**](PdfApi.md#putaddtext) | **PUT** /pdf/\{name}/pages/\{pageNumber}/text | Add text to PDF document page.
[**PutCreate**](PdfApi.md#putcreate) | **PUT** /storage/file | Upload a specific file 
[**PutCreateDocument**](PdfApi.md#putcreatedocument) | **PUT** /pdf/\{name} | Create empty document.
[**PutEpubInStorageToPdf**](PdfApi.md#putepubinstoragetopdf) | **PUT** /pdf/\{name}/create/epub | Convert EPUB file (located on storage) to PDF format and upload resulting file to storage. 
[**PutFieldsFlatten**](PdfApi.md#putfieldsflatten) | **PUT** /pdf/\{name}/fields/flatten | Flatten form fields in document.
[**PutFreeTextAnnotation**](PdfApi.md#putfreetextannotation) | **PUT** /pdf/\{name}/annotations/freetext/\{annotationId} | Replace document free text annotation
[**PutHtmlInStorageToPdf**](PdfApi.md#puthtmlinstoragetopdf) | **PUT** /pdf/\{name}/create/html | Convert HTML file (located on storage) to PDF format and upload resulting file to storage. 
[**PutImageExtractAsGif**](PdfApi.md#putimageextractasgif) | **PUT** /pdf/\{name}/images/\{imageId}/extract/gif | Extract document image in GIF format to folder
[**PutImageExtractAsJpeg**](PdfApi.md#putimageextractasjpeg) | **PUT** /pdf/\{name}/images/\{imageId}/extract/jpeg | Extract document image in JPEG format to folder
[**PutImageExtractAsPng**](PdfApi.md#putimageextractaspng) | **PUT** /pdf/\{name}/images/\{imageId}/extract/png | Extract document image in PNG format to folder
[**PutImageExtractAsTiff**](PdfApi.md#putimageextractastiff) | **PUT** /pdf/\{name}/images/\{imageId}/extract/tiff | Extract document image in TIFF format to folder
[**PutImageInStorageToPdf**](PdfApi.md#putimageinstoragetopdf) | **PUT** /pdf/\{name}/create/images | Convert image file (located on storage) to PDF format and upload resulting file to storage. 
[**PutImagesExtractAsGif**](PdfApi.md#putimagesextractasgif) | **PUT** /pdf/\{name}/pages/\{pageNumber}/images/extract/gif | Extract document images in GIF format to folder.
[**PutImagesExtractAsJpeg**](PdfApi.md#putimagesextractasjpeg) | **PUT** /pdf/\{name}/pages/\{pageNumber}/images/extract/jpeg | Extract document images in JPEG format to folder.
[**PutImagesExtractAsPng**](PdfApi.md#putimagesextractaspng) | **PUT** /pdf/\{name}/pages/\{pageNumber}/images/extract/png | Extract document images in PNG format to folder.
[**PutImagesExtractAsTiff**](PdfApi.md#putimagesextractastiff) | **PUT** /pdf/\{name}/pages/\{pageNumber}/images/extract/tiff | Extract document images in TIFF format to folder.
[**PutLaTeXInStorageToPdf**](PdfApi.md#putlatexinstoragetopdf) | **PUT** /pdf/\{name}/create/latex | Convert LaTeX file (located on storage) to PDF format and upload resulting file to storage. 
[**PutLinkAnnotation**](PdfApi.md#putlinkannotation) | **PUT** /pdf/\{name}/links/\{linkId} | Replace document page link annotations
[**PutMergeDocuments**](PdfApi.md#putmergedocuments) | **PUT** /pdf/\{name}/merge | Merge a list of documents.
[**PutMhtInStorageToPdf**](PdfApi.md#putmhtinstoragetopdf) | **PUT** /pdf/\{name}/create/mht | Convert MHT file (located on storage) to PDF format and upload resulting file to storage. 
[**PutPageAddStamp**](PdfApi.md#putpageaddstamp) | **PUT** /pdf/\{name}/pages/\{pageNumber}/stamp | Add page stamp.
[**PutPageConvertToBmp**](PdfApi.md#putpageconverttobmp) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/bmp | Convert document page to bmp image and upload resulting file to storage.
[**PutPageConvertToEmf**](PdfApi.md#putpageconverttoemf) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/emf | Convert document page to emf image and upload resulting file to storage.
[**PutPageConvertToGif**](PdfApi.md#putpageconverttogif) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/gif | Convert document page to gif image and upload resulting file to storage.
[**PutPageConvertToJpeg**](PdfApi.md#putpageconverttojpeg) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/jpeg | Convert document page to Jpeg image and upload resulting file to storage.
[**PutPageConvertToPng**](PdfApi.md#putpageconverttopng) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/png | Convert document page to png image and upload resulting file to storage.
[**PutPageConvertToTiff**](PdfApi.md#putpageconverttotiff) | **PUT** /pdf/\{name}/pages/\{pageNumber}/convert/tiff | Convert document page to Tiff image and upload resulting file to storage.
[**PutPclInStorageToPdf**](PdfApi.md#putpclinstoragetopdf) | **PUT** /pdf/\{name}/create/pcl | Convert PCL file (located on storage) to PDF format and upload resulting file to storage. 
[**PutPdfInRequestToDoc**](PdfApi.md#putpdfinrequesttodoc) | **PUT** /pdf/convert/doc | Converts PDF document (in request content) to DOC format and uploads resulting file to storage.
[**PutPdfInRequestToEpub**](PdfApi.md#putpdfinrequesttoepub) | **PUT** /pdf/convert/epub | Converts PDF document (in request content) to EPUB format and uploads resulting file to storage.
[**PutPdfInRequestToHtml**](PdfApi.md#putpdfinrequesttohtml) | **PUT** /pdf/convert/html | Converts PDF document (in request content) to Html format and uploads resulting file to storage.
[**PutPdfInRequestToLaTeX**](PdfApi.md#putpdfinrequesttolatex) | **PUT** /pdf/convert/latex | Converts PDF document (in request content) to LaTeX format and uploads resulting file to storage.
[**PutPdfInRequestToMobiXml**](PdfApi.md#putpdfinrequesttomobixml) | **PUT** /pdf/convert/mobixml | Converts PDF document (in request content) to MOBIXML format and uploads resulting file to storage.
[**PutPdfInRequestToPdfA**](PdfApi.md#putpdfinrequesttopdfa) | **PUT** /pdf/convert/pdfa | Converts PDF document (in request content) to PdfA format and uploads resulting file to storage.
[**PutPdfInRequestToPptx**](PdfApi.md#putpdfinrequesttopptx) | **PUT** /pdf/convert/pptx | Converts PDF document (in request content) to PPTX format and uploads resulting file to storage.
[**PutPdfInRequestToSvg**](PdfApi.md#putpdfinrequesttosvg) | **PUT** /pdf/convert/svg | Converts PDF document (in request content) to SVG format and uploads resulting file to storage.
[**PutPdfInRequestToTiff**](PdfApi.md#putpdfinrequesttotiff) | **PUT** /pdf/convert/tiff | Converts PDF document (in request content) to TIFF format and uploads resulting file to storage.
[**PutPdfInRequestToXls**](PdfApi.md#putpdfinrequesttoxls) | **PUT** /pdf/convert/xls | Converts PDF document (in request content) to XLS format and uploads resulting file to storage.
[**PutPdfInRequestToXml**](PdfApi.md#putpdfinrequesttoxml) | **PUT** /pdf/convert/xml | Converts PDF document (in request content) to XML format and uploads resulting file to storage.
[**PutPdfInRequestToXps**](PdfApi.md#putpdfinrequesttoxps) | **PUT** /pdf/convert/xps | Converts PDF document (in request content) to XPS format and uploads resulting file to storage.
[**PutPdfInStorageToDoc**](PdfApi.md#putpdfinstoragetodoc) | **PUT** /pdf/\{name}/convert/doc | Converts PDF document (located on storage) to DOC format and uploads resulting file to storage
[**PutPdfInStorageToEpub**](PdfApi.md#putpdfinstoragetoepub) | **PUT** /pdf/\{name}/convert/epub | Converts PDF document (located on storage) to EPUB format and uploads resulting file to storage
[**PutPdfInStorageToHtml**](PdfApi.md#putpdfinstoragetohtml) | **PUT** /pdf/\{name}/convert/html | Converts PDF document (located on storage) to Html format and uploads resulting file to storage
[**PutPdfInStorageToLaTeX**](PdfApi.md#putpdfinstoragetolatex) | **PUT** /pdf/\{name}/convert/latex | Converts PDF document (located on storage) to LaTeX format and uploads resulting file to storage
[**PutPdfInStorageToMobiXml**](PdfApi.md#putpdfinstoragetomobixml) | **PUT** /pdf/\{name}/convert/mobixml | Converts PDF document (located on storage) to MOBIXML format and uploads resulting file to storage
[**PutPdfInStorageToPdfA**](PdfApi.md#putpdfinstoragetopdfa) | **PUT** /pdf/\{name}/convert/pdfa | Converts PDF document (located on storage) to PdfA format and uploads resulting file to storage
[**PutPdfInStorageToPptx**](PdfApi.md#putpdfinstoragetopptx) | **PUT** /pdf/\{name}/convert/pptx | Converts PDF document (located on storage) to PPTX format and uploads resulting file to storage
[**PutPdfInStorageToSvg**](PdfApi.md#putpdfinstoragetosvg) | **PUT** /pdf/\{name}/convert/svg | Converts PDF document (located on storage) to SVG format and uploads resulting file to storage
[**PutPdfInStorageToTiff**](PdfApi.md#putpdfinstoragetotiff) | **PUT** /pdf/\{name}/convert/tiff | Converts PDF document (located on storage) to TIFF format and uploads resulting file to storage
[**PutPdfInStorageToXls**](PdfApi.md#putpdfinstoragetoxls) | **PUT** /pdf/\{name}/convert/xls | Converts PDF document (located on storage) to XLS format and uploads resulting file to storage
[**PutPdfInStorageToXml**](PdfApi.md#putpdfinstoragetoxml) | **PUT** /pdf/\{name}/convert/xml | Converts PDF document (located on storage) to XML format and uploads resulting file to storage
[**PutPdfInStorageToXps**](PdfApi.md#putpdfinstoragetoxps) | **PUT** /pdf/\{name}/convert/xps | Converts PDF document (located on storage) to XPS format and uploads resulting file to storage
[**PutPrivileges**](PdfApi.md#putprivileges) | **PUT** /pdf/\{name}/privileges | Update privilege document.
[**PutPsInStorageToPdf**](PdfApi.md#putpsinstoragetopdf) | **PUT** /pdf/\{name}/create/ps | Convert PS file (located on storage) to PDF format and upload resulting file to storage. 
[**PutReplaceImage**](PdfApi.md#putreplaceimage) | **PUT** /pdf/\{name}/images/\{imageId} | Replace document image.
[**PutSearchableDocument**](PdfApi.md#putsearchabledocument) | **PUT** /pdf/\{name}/ocr | Create searchable PDF document. Generate OCR layer for images in input PDF document.
[**PutSetProperty**](PdfApi.md#putsetproperty) | **PUT** /pdf/\{name}/documentproperties/\{propertyName} | Add/update document property.
[**PutSvgInStorageToPdf**](PdfApi.md#putsvginstoragetopdf) | **PUT** /pdf/\{name}/create/svg | Convert SVG file (located on storage) to PDF format and upload resulting file to storage. 
[**PutTextAnnotation**](PdfApi.md#puttextannotation) | **PUT** /pdf/\{name}/annotations/text/\{annotationId} | Replace document text annotation
[**PutUpdateField**](PdfApi.md#putupdatefield) | **PUT** /pdf/\{name}/fields/\{fieldName} | Update field.
[**PutUpdateFields**](PdfApi.md#putupdatefields) | **PUT** /pdf/\{name}/fields | Update fields.
[**PutWebInStorageToPdf**](PdfApi.md#putwebinstoragetopdf) | **PUT** /pdf/\{name}/create/web | Convert web page to PDF format and upload resulting file to storage. 
[**PutXfaPdfInRequestToAcroForm**](PdfApi.md#putxfapdfinrequesttoacroform) | **PUT** /pdf/convert/xfatoacroform | Converts PDF document which contatins XFA form (in request content) to PDF with AcroForm and uploads resulting file to storage.
[**PutXfaPdfInStorageToAcroForm**](PdfApi.md#putxfapdfinstoragetoacroform) | **PUT** /pdf/\{name}/convert/xfatoacroform | Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and uploads resulting file to storage
[**PutXmlInStorageToPdf**](PdfApi.md#putxmlinstoragetopdf) | **PUT** /pdf/\{name}/create/xml | Convert XML file (located on storage) to PDF format and upload resulting file to storage. 
[**PutXpsInStorageToPdf**](PdfApi.md#putxpsinstoragetopdf) | **PUT** /pdf/\{name}/create/xps | Convert XPS file (located on storage) to PDF format and upload resulting file to storage. 
[**PutXslFoInStorageToPdf**](PdfApi.md#putxslfoinstoragetopdf) | **PUT** /pdf/\{name}/create/xslfo | Convert XslFo file (located on storage) to PDF format and upload resulting file to storage. 


<a name="deleteannotation"></a>
# **DeleteAnnotation**
> AsposeResponse DeleteAnnotation (string name, string annotationId, string storage = null, string folder = null)

Delete document annotation by ID


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocumentannotations"></a>
# **DeleteDocumentAnnotations**
> AsposeResponse DeleteDocumentAnnotations (string name, string storage = null, string folder = null)

Delete all annotations from the document


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocumentlinkannotations"></a>
# **DeleteDocumentLinkAnnotations**
> AsposeResponse DeleteDocumentLinkAnnotations (string name, string storage = null, string folder = null)

Delete all link annotations from the document


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefield"></a>
# **DeleteField**
> AsposeResponse DeleteField (string name, string fieldName, string storage = null, string folder = null)

Delete document field by name.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name/ | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteimage"></a>
# **DeleteImage**
> AsposeResponse DeleteImage (string name, string imageId, string storage = null, string folder = null)

Delete image from document page.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelinkannotation"></a>
# **DeleteLinkAnnotation**
> AsposeResponse DeleteLinkAnnotation (string name, string linkId, string storage = null, string folder = null)

Delete document page link annotation by ID


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **linkId** | **string**| The link ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepage"></a>
# **DeletePage**
> AsposeResponse DeletePage (string name, int? pageNumber, string storage = null, string folder = null)

Delete document page by its number.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepageannotations"></a>
# **DeletePageAnnotations**
> AsposeResponse DeletePageAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Delete all annotations from the page


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepagelinkannotations"></a>
# **DeletePageLinkAnnotations**
> AsposeResponse DeletePageLinkAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Delete all link annotations from the page


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproperties"></a>
# **DeleteProperties**
> AsposeResponse DeleteProperties (string name, string storage = null, string folder = null)

Delete custom document properties.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproperty"></a>
# **DeleteProperty**
> AsposeResponse DeleteProperty (string name, string propertyName, string storage = null, string folder = null)

Delete document property.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **propertyName** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> DocumentResponse GetDocument (string name, string storage = null, string folder = null)

Read common document info.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentannotations"></a>
# **GetDocumentAnnotations**
> AnnotationsInfoResponse GetDocumentAnnotations (string name, string storage = null, string folder = null)

Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AnnotationsInfoResponse**](AnnotationsInfoResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentattachmentbyindex"></a>
# **GetDocumentAttachmentByIndex**
> AttachmentResponse GetDocumentAttachmentByIndex (string name, int? attachmentIndex, string storage = null, string folder = null)

Read document attachment info by its index.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **attachmentIndex** | **int?**| The attachment index. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AttachmentResponse**](AttachmentResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentattachments"></a>
# **GetDocumentAttachments**
> AttachmentsResponse GetDocumentAttachments (string name, string storage = null, string folder = null)

Read document attachments info.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AttachmentsResponse**](AttachmentsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentbookmarks"></a>
# **GetDocumentBookmarks**
> System.IO.Stream GetDocumentBookmarks (string name, string bookmarkPath = null, string storage = null, string folder = null)

Read document bookmark/bookmarks (including children).


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **bookmarkPath** | **string**| The bookmark path. Leave it empty if you want to get all the bookmarks in the document. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentfreetextannotations"></a>
# **GetDocumentFreeTextAnnotations**
> FreeTextAnnotationsResponse GetDocumentFreeTextAnnotations (string name, string storage = null, string folder = null)

Read document free text annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FreeTextAnnotationsResponse**](FreeTextAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentproperties"></a>
# **GetDocumentProperties**
> DocumentPropertiesResponse GetDocumentProperties (string name, string storage = null, string folder = null)

Read document properties.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**DocumentPropertiesResponse**](DocumentPropertiesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentproperty"></a>
# **GetDocumentProperty**
> DocumentPropertyResponse GetDocumentProperty (string name, string propertyName, string storage = null, string folder = null)

Read document property by name.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **propertyName** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**DocumentPropertyResponse**](DocumentPropertyResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumenttextannotations"></a>
# **GetDocumentTextAnnotations**
> TextAnnotationsResponse GetDocumentTextAnnotations (string name, string storage = null, string folder = null)

Read document text annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TextAnnotationsResponse**](TextAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdownload"></a>
# **GetDownload**
> System.IO.Stream GetDownload (string path, string versionId = null, string storage = null)

Download a specific file 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path of the file including the file name and extension e.g. /file.ext | 
 **versionId** | **string**| File&#39;s version | [optional] 
 **storage** | **string**| User&#39;s storage name | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdownloaddocumentattachmentbyindex"></a>
# **GetDownloadDocumentAttachmentByIndex**
> System.IO.Stream GetDownloadDocumentAttachmentByIndex (string name, int? attachmentIndex, string storage = null, string folder = null)

Download document attachment content by its index.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **attachmentIndex** | **int?**| The attachment index. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getepubinstoragetopdf"></a>
# **GetEpubInStorageToPdf**
> System.IO.Stream GetEpubInStorageToPdf (string srcPath, string storage = null)

Convert EPUB file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.epub) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfield"></a>
# **GetField**
> FieldResponse GetField (string name, string fieldName, string storage = null, string folder = null)

Get document field by name.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name/ | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FieldResponse**](FieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfields"></a>
# **GetFields**
> FieldsResponse GetFields (string name, string storage = null, string folder = null)

Get document fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FieldsResponse**](FieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfreetextannotation"></a>
# **GetFreeTextAnnotation**
> FreeTextAnnotationResponse GetFreeTextAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page free text annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FreeTextAnnotationResponse**](FreeTextAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethtmlinstoragetopdf"></a>
# **GetHtmlInStorageToPdf**
> System.IO.Stream GetHtmlInStorageToPdf (string srcPath, string htmlFileName, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string storage = null)

Convert HTML file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.zip) | 
 **htmlFileName** | **string**| Name of HTML file in ZIP. | 
 **height** | **double?**| Page height | [optional] 
 **width** | **double?**| Page width | [optional] 
 **isLandscape** | **bool?**| Is page landscaped | [optional] 
 **marginLeft** | **double?**| Page margin left | [optional] 
 **marginBottom** | **double?**| Page margin bottom | [optional] 
 **marginRight** | **double?**| Page margin right | [optional] 
 **marginTop** | **double?**| Page margin top | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimage"></a>
# **GetImage**
> ImageResponse GetImage (string name, string imageId, string storage = null, string folder = null)

Read document image by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ImageResponse**](ImageResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimageextractasgif"></a>
# **GetImageExtractAsGif**
> System.IO.Stream GetImageExtractAsGif (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null)

Extract document image in GIF format


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimageextractasjpeg"></a>
# **GetImageExtractAsJpeg**
> System.IO.Stream GetImageExtractAsJpeg (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null)

Extract document image in JPEG format


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimageextractaspng"></a>
# **GetImageExtractAsPng**
> System.IO.Stream GetImageExtractAsPng (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null)

Extract document image in PNG format


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimageextractastiff"></a>
# **GetImageExtractAsTiff**
> System.IO.Stream GetImageExtractAsTiff (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null)

Extract document image in TIFF format


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimages"></a>
# **GetImages**
> ImagesResponse GetImages (string name, int? pageNumber, string storage = null, string folder = null)

Read document images.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ImagesResponse**](ImagesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlatexinstoragetopdf"></a>
# **GetLaTeXInStorageToPdf**
> System.IO.Stream GetLaTeXInStorageToPdf (string srcPath, string storage = null)

Convert LaTeX file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.tex) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlinkannotation"></a>
# **GetLinkAnnotation**
> LinkAnnotationResponse GetLinkAnnotation (string name, string linkId, string storage = null, string folder = null)

Read document link annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **linkId** | **string**| The link ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**LinkAnnotationResponse**](LinkAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmhtinstoragetopdf"></a>
# **GetMhtInStorageToPdf**
> System.IO.Stream GetMhtInStorageToPdf (string srcPath, string storage = null)

Convert MHT file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.mht) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpage"></a>
# **GetPage**
> DocumentPageResponse GetPage (string name, int? pageNumber, string storage = null, string folder = null)

Read document page info.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**DocumentPageResponse**](DocumentPageResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageannotations"></a>
# **GetPageAnnotations**
> AnnotationsInfoResponse GetPageAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AnnotationsInfoResponse**](AnnotationsInfoResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttobmp"></a>
# **GetPageConvertToBmp**
> System.IO.Stream GetPageConvertToBmp (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Bmp image and return resulting file in response.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttoemf"></a>
# **GetPageConvertToEmf**
> System.IO.Stream GetPageConvertToEmf (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Emf image and return resulting file in response.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttogif"></a>
# **GetPageConvertToGif**
> System.IO.Stream GetPageConvertToGif (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Gif image and return resulting file in response.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttojpeg"></a>
# **GetPageConvertToJpeg**
> System.IO.Stream GetPageConvertToJpeg (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Jpeg image and return resulting file in response.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttopng"></a>
# **GetPageConvertToPng**
> System.IO.Stream GetPageConvertToPng (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Png image and return resulting file in response.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttotiff"></a>
# **GetPageConvertToTiff**
> System.IO.Stream GetPageConvertToTiff (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Tiff image  and return resulting file in response.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagefreetextannotations"></a>
# **GetPageFreeTextAnnotations**
> FreeTextAnnotationsResponse GetPageFreeTextAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page free text annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FreeTextAnnotationsResponse**](FreeTextAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagelinkannotation"></a>
# **GetPageLinkAnnotation**
> LinkAnnotationResponse GetPageLinkAnnotation (string name, int? pageNumber, string linkId, string storage = null, string folder = null)

Read document page link annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **linkId** | **string**| The link ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**LinkAnnotationResponse**](LinkAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagelinkannotations"></a>
# **GetPageLinkAnnotations**
> LinkAnnotationsResponse GetPageLinkAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page link annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**LinkAnnotationsResponse**](LinkAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagetext"></a>
# **GetPageText**
> TextRectsResponse GetPageText (string name, int? pageNumber, double? LLX, double? LLY, double? URX, double? URY, List<string> format = null, string regex = null, bool? splitRects = null, string folder = null, string storage = null)

Read page text items.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| Number of page (starting from 1). | 
 **LLX** | **double?**|  | 
 **LLY** | **double?**|  | 
 **URX** | **double?**|  | 
 **URY** | **double?**|  | 
 **format** | **List&lt;string&gt;**| List of formats for search. | [optional] 
 **regex** | **string**| Formats are specified as a regular expression. | [optional] 
 **splitRects** | **bool?**| Split result fragments (default is true). | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**TextRectsResponse**](TextRectsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagetextannotations"></a>
# **GetPageTextAnnotations**
> TextAnnotationsResponse GetPageTextAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page text annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TextAnnotationsResponse**](TextAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpages"></a>
# **GetPages**
> DocumentPagesResponse GetPages (string name, string storage = null, string folder = null)

Read document pages info.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**DocumentPagesResponse**](DocumentPagesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpclinstoragetopdf"></a>
# **GetPclInStorageToPdf**
> System.IO.Stream GetPclInStorageToPdf (string srcPath, string storage = null)

Convert PCL file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.pcl) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetodoc"></a>
# **GetPdfInStorageToDoc**
> System.IO.Stream GetPdfInStorageToDoc (string name, bool? addReturnToLineEnd = null, string format = null, int? imageResolutionX = null, int? imageResolutionY = null, double? maxDistanceBetweenTextLines = null, string mode = null, bool? recognizeBullets = null, double? relativeHorizontalProximity = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to DOC format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **addReturnToLineEnd** | **bool?**| Add return to line end. | [optional] 
 **format** | **string**| Allows to specify .doc or .docx file format. | [optional] 
 **imageResolutionX** | **int?**| Image resolution X. | [optional] 
 **imageResolutionY** | **int?**| Image resolution Y. | [optional] 
 **maxDistanceBetweenTextLines** | **double?**| Max distance between text lines. | [optional] 
 **mode** | **string**| Allows to control how a PDF document is converted into a word processing document. | [optional] 
 **recognizeBullets** | **bool?**| Recognize bullets. | [optional] 
 **relativeHorizontalProximity** | **double?**| Relative horizontal proximity. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetoepub"></a>
# **GetPdfInStorageToEpub**
> System.IO.Stream GetPdfInStorageToEpub (string name, string contentRecognitionMode = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to EPUB format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **contentRecognitionMode** | **string**| ?roperty tunes conversion for this or that desirable method of recognition of content. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetohtml"></a>
# **GetPdfInStorageToHtml**
> System.IO.Stream GetPdfInStorageToHtml (string name, int? additionalMarginWidthInPoints = null, bool? compressSvgGraphicsIfAny = null, bool? convertMarkedContentToLayers = null, string defaultFontName = null, string documentType = null, bool? fixedLayout = null, int? imageResolution = null, int? minimalLineWidth = null, bool? preventGlyphsGrouping = null, bool? splitCssIntoPages = null, bool? splitIntoPages = null, bool? useZOrder = null, string antialiasingProcessing = null, string cssClassNamesPrefix = null, List<int?> explicitListOfSavedPages = null, string fontEncodingStrategy = null, string fontSavingMode = null, string htmlMarkupGenerationMode = null, string lettersPositioningMethod = null, bool? pagesFlowTypeDependsOnViewersScreenSize = null, string partsEmbeddingMode = null, string rasterImagesSavingMode = null, bool? removeEmptyAreasOnTopAndBottom = null, bool? saveShadowedTextsAsTransparentTexts = null, bool? saveTransparentTexts = null, string specialFolderForAllImages = null, string specialFolderForSvgImages = null, bool? trySaveTextUnderliningAndStrikeoutingInCss = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to Html format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **additionalMarginWidthInPoints** | **int?**| Defines width of margin that will be forcibly left around that output HTML-areas. | [optional] 
 **compressSvgGraphicsIfAny** | **bool?**| The flag that indicates whether found SVG graphics(if any) will be compressed(zipped) into SVGZ format during saving. | [optional] 
 **convertMarkedContentToLayers** | **bool?**| If attribute ConvertMarkedContentToLayers set to true then an all elements inside a PDF marked content (layer) will be put into an HTML div with &quot;data-pdflayer&quot; attribute specifying a layer name. This layer name will be extracted from optional properties of PDF marked content. If this attribute is false (by default) then no any layers will be created from PDF marked content. | [optional] 
 **defaultFontName** | **string**| Specifies the name of an installed font which is used to substitute any document font that is not embedded and not installed in the system. If null then default substitution font is used. | [optional] 
 **documentType** | **string**| Result document type. | [optional] 
 **fixedLayout** | **bool?**| The value indicating whether that HTML is created as fixed layout. | [optional] 
 **imageResolution** | **int?**| Resolution for image rendering. | [optional] 
 **minimalLineWidth** | **int?**| This attribute sets minimal width of graphic path line. If thickness of line is less than 1px Adobe Acrobat rounds it to this value. So this attribute can be used to emulate this behavior for HTML browsers. | [optional] 
 **preventGlyphsGrouping** | **bool?**| This attribute switch on the mode when text glyphs will not be grouped into words and strings This mode allows to keep maximum precision during positioning of glyphs on the page and it can be used for conversion documents with music notes or glyphs that should be placed separately each other. This parameter will be applied to document only when the value of FixedLayout attribute is true. | [optional] 
 **splitCssIntoPages** | **bool?**| When multipage-mode selected(i.e &#39;SplitIntoPages&#39; is &#39;true&#39;), then this attribute defines whether should be created separate CSS-file for each result HTML page. | [optional] 
 **splitIntoPages** | **bool?**| The flag that indicates whether each page of source document will be converted into it&#39;s own target HTML document, i.e whether result HTML will be splitted into several HTML-pages. | [optional] 
 **useZOrder** | **bool?**| If attribute UseZORder set to true, graphics and text are added to resultant HTML document accordingly Z-order in original PDF document. If this attribute is false all graphics is put as single layer which may cause some unnecessary effects for overlapped objects. | [optional] 
 **antialiasingProcessing** | **string**| The parameter defines required antialiasing measures during conversion of compound background images from PDF to HTML. | [optional] 
 **cssClassNamesPrefix** | **string**| When PDFtoHTML converter generates result CSSs, CSS class names (something like &quot;.stl_01 {}&quot; ... &quot;.stl_NN {}) are generated and used in result CSS. This property allows forcibly set class name prefix. | [optional] 
 **explicitListOfSavedPages** | **List&lt;int?&gt;**| With this property You can explicitely define what pages of document should be converted. Pages in this list must have 1-based numbers. I.e. valid numbers of pages must be taken from range (1...[NumberOfPagesInConvertedDocument]) Order of appearing of pages in this list does not affect their order in result HTML page(s) - in result pages allways will go in order in which they are present in source PDF. | [optional] 
 **fontEncodingStrategy** | **string**| Defines encoding special rule to tune PDF decoding for current document. | [optional] 
 **fontSavingMode** | **string**| Defines font saving mode that will be used during saving of PDF to desirable format. | [optional] 
 **htmlMarkupGenerationMode** | **string**| Sometimes specific reqirments to generation of HTML markup are present. This parameter defines HTML preparing modes that can be used during conversion of PDF to HTML to match such specific requirments. | [optional] 
 **lettersPositioningMethod** | **string**| The mode of positioning of letters in words in result HTML. | [optional] 
 **pagesFlowTypeDependsOnViewersScreenSize** | **bool?**| If attribute &#39;SplitOnPages&#x3D;false&#39;, than whole HTML representing all input PDF pages will be put into one big result HTML file. This flag defines whether result HTML will be generated in such way that flow of areas that represent PDF pages in result HTML will depend on screen resolution of viewer. | [optional] 
 **partsEmbeddingMode** | **string**| It defines whether referenced files (HTML, Fonts,Images, CSSes) will be embedded into main HTML file or will be generated as apart binary entities. | [optional] 
 **rasterImagesSavingMode** | **string**| Converted PDF can contain raster images This parameter defines how they should be handled during conversion of PDF to HTML. | [optional] 
 **removeEmptyAreasOnTopAndBottom** | **bool?**| Defines whether in created HTML will be removed top and bottom empty area without any content (if any). | [optional] 
 **saveShadowedTextsAsTransparentTexts** | **bool?**| Pdf can contain texts that are shadowed by another elements (f.e. by images) but can be selected to clipboard in Acrobat Reader (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML to mimic behaviour of Acrobat Reader (othervise such texts are usually saved as hidden, not available for copying to clipboard). | [optional] 
 **saveTransparentTexts** | **bool?**| Pdf can contain transparent texts that can be selected to clipboard (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML. | [optional] 
 **specialFolderForAllImages** | **string**| The path to directory to which must be saved any images if they are encountered during saving of document as HTML. If parameter is empty or null then image files(if any) wil be saved together with other files linked to HTML It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. | [optional] 
 **specialFolderForSvgImages** | **string**| The path to directory to which must be saved only SVG-images if they are encountered during saving of document as HTML. If parameter is empty or null then SVG files(if any) wil be saved together with other image-files (near to output file) or in special folder for images (if it specified in SpecialImagesFolderIfAny option). It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. | [optional] 
 **trySaveTextUnderliningAndStrikeoutingInCss** | **bool?**| PDF itself does not contain underlining markers for texts. It emulated with line situated under text. This option allows converter try guess that this or that line is a text&#39;s underlining and put this info into CSS instead of drawing of underlining graphically. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetolatex"></a>
# **GetPdfInStorageToLaTeX**
> System.IO.Stream GetPdfInStorageToLaTeX (string name, int? pagesCount = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to LaTeX format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pagesCount** | **int?**| Pages count. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetomobixml"></a>
# **GetPdfInStorageToMobiXml**
> System.IO.Stream GetPdfInStorageToMobiXml (string name, string folder = null, string storage = null)

Converts PDF document (located on storage) to MOBIXML format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetopdfa"></a>
# **GetPdfInStorageToPdfA**
> System.IO.Stream GetPdfInStorageToPdfA (string name, string type, string folder = null, string storage = null)

Converts PDF document (located on storage) to PdfA format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **type** | **string**| Type of PdfA format. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetopptx"></a>
# **GetPdfInStorageToPptx**
> System.IO.Stream GetPdfInStorageToPptx (string name, bool? separateImages = null, bool? slidesAsImages = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to PPTX format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **separateImages** | **bool?**| Separate images. | [optional] 
 **slidesAsImages** | **bool?**| Slides as images. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetosvg"></a>
# **GetPdfInStorageToSvg**
> System.IO.Stream GetPdfInStorageToSvg (string name, bool? compressOutputToZipArchive = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to SVG format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **compressOutputToZipArchive** | **bool?**| Specifies whether output will be created as one zip-archive. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetotiff"></a>
# **GetPdfInStorageToTiff**
> System.IO.Stream GetPdfInStorageToTiff (string name, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to TIFF format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **brightness** | **double?**| Image brightness. | [optional] 
 **compression** | **string**| Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. | [optional] 
 **colorDepth** | **string**| Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. | [optional] 
 **leftMargin** | **int?**| Left image margin. | [optional] 
 **rightMargin** | **int?**| Right image margin. | [optional] 
 **topMargin** | **int?**| Top image margin. | [optional] 
 **bottomMargin** | **int?**| Bottom image margin. | [optional] 
 **orientation** | **string**| Image orientation. Possible values are: None, Landscape, Portait. | [optional] 
 **skipBlankPages** | **bool?**| Skip blank pages flag. | [optional] 
 **width** | **int?**| Image width. | [optional] 
 **height** | **int?**| Image height. | [optional] 
 **xResolution** | **int?**| Horizontal resolution. | [optional] 
 **yResolution** | **int?**| Vertical resolution. | [optional] 
 **pageIndex** | **int?**| Start page to export. | [optional] 
 **pageCount** | **int?**| Number of pages to export. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetoxls"></a>
# **GetPdfInStorageToXls**
> System.IO.Stream GetPdfInStorageToXls (string name, bool? insertBlankColumnAtFirst = null, bool? minimizeTheNumberOfWorksheets = null, double? scaleFactor = null, bool? uniformWorksheets = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to XLS format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **insertBlankColumnAtFirst** | **bool?**| Insert blank column at first | [optional] 
 **minimizeTheNumberOfWorksheets** | **bool?**| Minimize the number of worksheets | [optional] 
 **scaleFactor** | **double?**| Scale factor | [optional] 
 **uniformWorksheets** | **bool?**| Uniform worksheets | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetoxml"></a>
# **GetPdfInStorageToXml**
> System.IO.Stream GetPdfInStorageToXml (string name, string folder = null, string storage = null)

Converts PDF document (located on storage) to XML format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetoxps"></a>
# **GetPdfInStorageToXps**
> System.IO.Stream GetPdfInStorageToXps (string name, string folder = null, string storage = null)

Converts PDF document (located on storage) to XPS format and returns resulting file in response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpsinstoragetopdf"></a>
# **GetPsInStorageToPdf**
> System.IO.Stream GetPsInStorageToPdf (string srcPath, string storage = null)

Convert PS file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.ps) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsvginstoragetopdf"></a>
# **GetSvgInStorageToPdf**
> System.IO.Stream GetSvgInStorageToPdf (string srcPath, bool? adjustPageSize = null, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string storage = null)

Convert SVG file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.svg) | 
 **adjustPageSize** | **bool?**| Adjust page size | [optional] 
 **height** | **double?**| Page height | [optional] 
 **width** | **double?**| Page width | [optional] 
 **isLandscape** | **bool?**| Is page landscaped | [optional] 
 **marginLeft** | **double?**| Page margin left | [optional] 
 **marginBottom** | **double?**| Page margin bottom | [optional] 
 **marginRight** | **double?**| Page margin right | [optional] 
 **marginTop** | **double?**| Page margin top | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettext"></a>
# **GetText**
> TextRectsResponse GetText (string name, double? LLX, double? LLY, double? URX, double? URY, List<string> format = null, string regex = null, bool? splitRects = null, string folder = null, string storage = null)

Read document text.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **LLX** | **double?**|  | 
 **LLY** | **double?**|  | 
 **URX** | **double?**|  | 
 **URY** | **double?**|  | 
 **format** | **List&lt;string&gt;**| List of formats for search. | [optional] 
 **regex** | **string**| Formats are specified as a regular expression. | [optional] 
 **splitRects** | **bool?**| Split result fragments (default is true). | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**TextRectsResponse**](TextRectsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettextannotation"></a>
# **GetTextAnnotation**
> TextAnnotationResponse GetTextAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page text annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TextAnnotationResponse**](TextAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getverifysignature"></a>
# **GetVerifySignature**
> SignatureVerifyResponse GetVerifySignature (string name, string signName, string storage = null, string folder = null)

Verify signature document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **signName** | **string**| Sign name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SignatureVerifyResponse**](SignatureVerifyResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebinstoragetopdf"></a>
# **GetWebInStorageToPdf**
> System.IO.Stream GetWebInStorageToPdf (string url, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string storage = null)

Convert web page to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | **string**| Source url | 
 **height** | **double?**| Page height | [optional] 
 **width** | **double?**| Page width | [optional] 
 **isLandscape** | **bool?**| Is page landscaped | [optional] 
 **marginLeft** | **double?**| Page margin left | [optional] 
 **marginBottom** | **double?**| Page margin bottom | [optional] 
 **marginRight** | **double?**| Page margin right | [optional] 
 **marginTop** | **double?**| Page margin top | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwordsperpage"></a>
# **GetWordsPerPage**
> WordCountResponse GetWordsPerPage (string name, string storage = null, string folder = null)

Get number of words per document page.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**WordCountResponse**](WordCountResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxfapdfinstoragetoacroform"></a>
# **GetXfaPdfInStorageToAcroForm**
> System.IO.Stream GetXfaPdfInStorageToAcroForm (string name, string folder = null, string storage = null)

Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and returns resulting file response content


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxmlinstoragetopdf"></a>
# **GetXmlInStorageToPdf**
> System.IO.Stream GetXmlInStorageToPdf (string srcPath, string xslFilePath = null, string storage = null)

Convert XML file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.xml) | 
 **xslFilePath** | **string**| Full XSL source filename (ex. /folder1/folder2/template.xsl) | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxpsinstoragetopdf"></a>
# **GetXpsInStorageToPdf**
> System.IO.Stream GetXpsInStorageToPdf (string srcPath, string storage = null)

Convert XPS file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.xps) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxslfoinstoragetopdf"></a>
# **GetXslFoInStorageToPdf**
> System.IO.Stream GetXslFoInStorageToPdf (string srcPath, string storage = null)

Convert XslFo file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.xslfo) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postappenddocument"></a>
# **PostAppendDocument**
> DocumentResponse PostAppendDocument (string name, AppendDocument appendDocument = null, string appendFile = null, int? startPage = null, int? endPage = null, string storage = null, string folder = null)

Append document to existing one.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The original document name. | 
 **appendDocument** | [**AppendDocument**](AppendDocument.md)| with the append document data. | [optional] 
 **appendFile** | **string**| Append file server path. | [optional] 
 **startPage** | **int?**| Appending start page. | [optional] [default to 0]
 **endPage** | **int?**| Appending end page. | [optional] [default to 0]
 **storage** | **string**| The documents storage. | [optional] 
 **folder** | **string**| The original document folder. | [optional] 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcreatefield"></a>
# **PostCreateField**
> AsposeResponse PostCreateField (string name, int? page, Field field = null, string storage = null, string folder = null)

Create field.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **page** | **int?**| Document page number. | 
 **field** | [**Field**](Field.md)| with the field data. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocumenttextreplace"></a>
# **PostDocumentTextReplace**
> TextReplaceResponse PostDocumentTextReplace (string name, TextReplaceListRequest textReplace, string storage = null, string folder = null)

Document's replace text method.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **textReplace** | [**TextReplaceListRequest**](TextReplaceListRequest.md)|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**TextReplaceResponse**](TextReplaceResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinsertimage"></a>
# **PostInsertImage**
> AsposeResponse PostInsertImage (string name, int? pageNumber, double? llx, double? lly, double? urx, double? ury, string imageFilePath = null, string storage = null, string folder = null, System.IO.Stream image = null)

Insert image to document page.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **llx** | **double?**| Coordinate lower left X. | 
 **lly** | **double?**| Coordinate lower left Y. | 
 **urx** | **double?**| Coordinate upper right X. | 
 **ury** | **double?**| Coordinate upper right Y. | 
 **imageFilePath** | **string**| Path to image file if specified. Request content is used otherwise. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **image** | **System.IO.Stream**| Image file. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmovepage"></a>
# **PostMovePage**
> AsposeResponse PostMovePage (string name, int? pageNumber, int? newIndex, string storage = null, string folder = null)

Move page to new position.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **newIndex** | **int?**| The new page position/index. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postoptimizedocument"></a>
# **PostOptimizeDocument**
> AsposeResponse PostOptimizeDocument (string name, OptimizeOptions options = null, string storage = null, string folder = null)

Optimize document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **options** | [**OptimizeOptions**](OptimizeOptions.md)| The optimization options. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagefreetextannotations"></a>
# **PostPageFreeTextAnnotations**
> AsposeResponse PostPageFreeTextAnnotations (string name, int? pageNumber, List<FreeTextAnnotation> annotations, string storage = null, string folder = null)

Add document page free text annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;FreeTextAnnotation&gt;**](FreeTextAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagelinkannotations"></a>
# **PostPageLinkAnnotations**
> AsposeResponse PostPageLinkAnnotations (string name, int? pageNumber, List<LinkAnnotation> links, string storage = null, string folder = null)

Add document page link annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **links** | [**List&lt;LinkAnnotation&gt;**](LinkAnnotation.md)| Array of link anotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagetextannotations"></a>
# **PostPageTextAnnotations**
> AsposeResponse PostPageTextAnnotations (string name, int? pageNumber, List<TextAnnotation> annotations, string storage = null, string folder = null)

Add document page text annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;TextAnnotation&gt;**](TextAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagetextreplace"></a>
# **PostPageTextReplace**
> TextReplaceResponse PostPageTextReplace (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)

Page's replace text method.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **pageNumber** | **int?**|  | 
 **textReplaceListRequest** | [**TextReplaceListRequest**](TextReplaceListRequest.md)|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**TextReplaceResponse**](TextReplaceResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsigndocument"></a>
# **PostSignDocument**
> AsposeResponse PostSignDocument (string name, Signature signature = null, string storage = null, string folder = null)

Sign document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **signature** | [**Signature**](Signature.md)| Signature object containing signature data. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsignpage"></a>
# **PostSignPage**
> AsposeResponse PostSignPage (string name, int? pageNumber, Signature signature = null, string storage = null, string folder = null)

Sign page.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **signature** | [**Signature**](Signature.md)| Signature object containing signature data. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsplitdocument"></a>
# **PostSplitDocument**
> SplitResultResponse PostSplitDocument (string name, string format = null, int? from = null, int? to = null, string storage = null, string folder = null)

Split document to parts.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **format** | **string**| Resulting documents format. | [optional] 
 **from** | **int?**| Start page if defined. | [optional] 
 **to** | **int?**| End page if defined. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SplitResultResponse**](SplitResultResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putaddnewpage"></a>
# **PutAddNewPage**
> DocumentPagesResponse PutAddNewPage (string name, string storage = null, string folder = null)

Add new page to end of the document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**DocumentPagesResponse**](DocumentPagesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putaddtext"></a>
# **PutAddText**
> AsposeResponse PutAddText (string name, int? pageNumber, Paragraph paragraph = null, string folder = null, string storage = null)

Add text to PDF document page.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| Number of page (starting from 1). | 
 **paragraph** | [**Paragraph**](Paragraph.md)| Paragraph data. | [optional] 
 **folder** | **string**| Document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcreate"></a>
# **PutCreate**
> AsposeResponse PutCreate (string path, System.IO.Stream file, string versionId = null, string storage = null)

Upload a specific file 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext | 
 **file** | **System.IO.Stream**| File to upload | 
 **versionId** | **string**| Source file&#39;s version | [optional] 
 **storage** | **string**| User&#39;s storage name | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcreatedocument"></a>
# **PutCreateDocument**
> DocumentResponse PutCreateDocument (string name, string storage = null, string folder = null)

Create empty document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The new document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The new document folder. | [optional] 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putepubinstoragetopdf"></a>
# **PutEpubInStorageToPdf**
> AsposeResponse PutEpubInStorageToPdf (string name, string srcPath, string storage = null, string dstFolder = null)

Convert EPUB file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.epub) | 
 **storage** | **string**| The document storage. | [optional] 
 **dstFolder** | **string**| The destination document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfieldsflatten"></a>
# **PutFieldsFlatten**
> AsposeResponse PutFieldsFlatten (string name, string storage = null, string folder = null)

Flatten form fields in document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfreetextannotation"></a>
# **PutFreeTextAnnotation**
> FreeTextAnnotationResponse PutFreeTextAnnotation (string name, string annotationId, FreeTextAnnotation annotation, string storage = null, string folder = null)

Replace document free text annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**FreeTextAnnotation**](FreeTextAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FreeTextAnnotationResponse**](FreeTextAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puthtmlinstoragetopdf"></a>
# **PutHtmlInStorageToPdf**
> AsposeResponse PutHtmlInStorageToPdf (string name, string srcPath, string htmlFileName, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string dstFolder = null, string storage = null)

Convert HTML file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.zip) | 
 **htmlFileName** | **string**| Name of HTML file in ZIP. | 
 **height** | **double?**| Page height | [optional] 
 **width** | **double?**| Page width | [optional] 
 **isLandscape** | **bool?**| Is page landscaped | [optional] 
 **marginLeft** | **double?**| Page margin left | [optional] 
 **marginBottom** | **double?**| Page margin bottom | [optional] 
 **marginRight** | **double?**| Page margin right | [optional] 
 **marginTop** | **double?**| Page margin top | [optional] 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimageextractasgif"></a>
# **PutImageExtractAsGif**
> AsposeResponse PutImageExtractAsGif (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document image in GIF format to folder


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **destFolder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimageextractasjpeg"></a>
# **PutImageExtractAsJpeg**
> AsposeResponse PutImageExtractAsJpeg (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document image in JPEG format to folder


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **destFolder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimageextractaspng"></a>
# **PutImageExtractAsPng**
> AsposeResponse PutImageExtractAsPng (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document image in PNG format to folder


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **destFolder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimageextractastiff"></a>
# **PutImageExtractAsTiff**
> AsposeResponse PutImageExtractAsTiff (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document image in TIFF format to folder


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **destFolder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimageinstoragetopdf"></a>
# **PutImageInStorageToPdf**
> AsposeResponse PutImageInStorageToPdf (string name, ImageTemplatesRequest imageTemplates, string dstFolder = null, string storage = null)

Convert image file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageTemplates** | [**ImageTemplatesRequest**](ImageTemplatesRequest.md)| Image templates | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimagesextractasgif"></a>
# **PutImagesExtractAsGif**
> AsposeResponse PutImagesExtractAsGif (string name, int? pageNumber, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document images in GIF format to folder.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **destFolder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimagesextractasjpeg"></a>
# **PutImagesExtractAsJpeg**
> AsposeResponse PutImagesExtractAsJpeg (string name, int? pageNumber, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document images in JPEG format to folder.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**|  | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **destFolder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimagesextractaspng"></a>
# **PutImagesExtractAsPng**
> AsposeResponse PutImagesExtractAsPng (string name, int? pageNumber, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document images in PNG format to folder.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **destFolder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimagesextractastiff"></a>
# **PutImagesExtractAsTiff**
> AsposeResponse PutImagesExtractAsTiff (string name, int? pageNumber, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document images in TIFF format to folder.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **destFolder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putlatexinstoragetopdf"></a>
# **PutLaTeXInStorageToPdf**
> AsposeResponse PutLaTeXInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert LaTeX file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.tex) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putlinkannotation"></a>
# **PutLinkAnnotation**
> LinkAnnotationResponse PutLinkAnnotation (string name, string linkId, LinkAnnotation link, string storage = null, string folder = null)

Replace document page link annotations


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **linkId** | **string**| The link ID. | 
 **link** | [**LinkAnnotation**](LinkAnnotation.md)| Link anotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**LinkAnnotationResponse**](LinkAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putmergedocuments"></a>
# **PutMergeDocuments**
> System.IO.Stream PutMergeDocuments (string name, MergeDocuments mergeDocuments = null, string storage = null, string folder = null)

Merge a list of documents.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Resulting documen name. | 
 **mergeDocuments** | [**MergeDocuments**](MergeDocuments.md)| with a list of documents. | [optional] 
 **storage** | **string**| Resulting document storage. | [optional] 
 **folder** | **string**| Resulting document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putmhtinstoragetopdf"></a>
# **PutMhtInStorageToPdf**
> AsposeResponse PutMhtInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert MHT file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.mht) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageaddstamp"></a>
# **PutPageAddStamp**
> AsposeResponse PutPageAddStamp (string name, int? pageNumber, Stamp stamp, string storage = null, string folder = null)

Add page stamp.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **stamp** | [**Stamp**](Stamp.md)| with data. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttobmp"></a>
# **PutPageConvertToBmp**
> AsposeResponse PutPageConvertToBmp (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to bmp image and upload resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **outPath** | **string**| The out path of result image. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttoemf"></a>
# **PutPageConvertToEmf**
> AsposeResponse PutPageConvertToEmf (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to emf image and upload resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **outPath** | **string**| The out path of result image. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttogif"></a>
# **PutPageConvertToGif**
> AsposeResponse PutPageConvertToGif (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to gif image and upload resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **outPath** | **string**| The out path of result image. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttojpeg"></a>
# **PutPageConvertToJpeg**
> AsposeResponse PutPageConvertToJpeg (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Jpeg image and upload resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **outPath** | **string**| The out path of result image. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttopng"></a>
# **PutPageConvertToPng**
> AsposeResponse PutPageConvertToPng (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to png image and upload resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **outPath** | **string**| The out path of result image. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttotiff"></a>
# **PutPageConvertToTiff**
> AsposeResponse PutPageConvertToTiff (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Tiff image and upload resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **outPath** | **string**| The out path of result image. | 
 **width** | **int?**| The converted image width. | [optional] 
 **height** | **int?**| The converted image height. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpclinstoragetopdf"></a>
# **PutPclInStorageToPdf**
> AsposeResponse PutPclInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert PCL file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.pcl) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttodoc"></a>
# **PutPdfInRequestToDoc**
> AsposeResponse PutPdfInRequestToDoc (string outPath, bool? addReturnToLineEnd = null, string format = null, int? imageResolutionX = null, int? imageResolutionY = null, double? maxDistanceBetweenTextLines = null, string mode = null, bool? recognizeBullets = null, double? relativeHorizontalProximity = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to DOC format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.doc) | 
 **addReturnToLineEnd** | **bool?**| Add return to line end. | [optional] 
 **format** | **string**| Allows to specify .doc or .docx file format. | [optional] 
 **imageResolutionX** | **int?**| Image resolution X. | [optional] 
 **imageResolutionY** | **int?**| Image resolution Y. | [optional] 
 **maxDistanceBetweenTextLines** | **double?**| Max distance between text lines. | [optional] 
 **mode** | **string**| Allows to control how a PDF document is converted into a word processing document. | [optional] 
 **recognizeBullets** | **bool?**| Recognize bullets. | [optional] 
 **relativeHorizontalProximity** | **double?**| Relative horizontal proximity. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttoepub"></a>
# **PutPdfInRequestToEpub**
> AsposeResponse PutPdfInRequestToEpub (string outPath, string contentRecognitionMode = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to EPUB format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.epub) | 
 **contentRecognitionMode** | **string**| ?roperty tunes conversion for this or that desirable method of recognition of content. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttohtml"></a>
# **PutPdfInRequestToHtml**
> AsposeResponse PutPdfInRequestToHtml (string outPath, int? additionalMarginWidthInPoints = null, bool? compressSvgGraphicsIfAny = null, bool? convertMarkedContentToLayers = null, string defaultFontName = null, string documentType = null, bool? fixedLayout = null, int? imageResolution = null, int? minimalLineWidth = null, bool? preventGlyphsGrouping = null, bool? splitCssIntoPages = null, bool? splitIntoPages = null, bool? useZOrder = null, string antialiasingProcessing = null, string cssClassNamesPrefix = null, List<int?> explicitListOfSavedPages = null, string fontEncodingStrategy = null, string fontSavingMode = null, string htmlMarkupGenerationMode = null, string lettersPositioningMethod = null, bool? pagesFlowTypeDependsOnViewersScreenSize = null, string partsEmbeddingMode = null, string rasterImagesSavingMode = null, bool? removeEmptyAreasOnTopAndBottom = null, bool? saveShadowedTextsAsTransparentTexts = null, bool? saveTransparentTexts = null, string specialFolderForAllImages = null, string specialFolderForSvgImages = null, bool? trySaveTextUnderliningAndStrikeoutingInCss = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to Html format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.html) | 
 **additionalMarginWidthInPoints** | **int?**| Defines width of margin that will be forcibly left around that output HTML-areas. | [optional] 
 **compressSvgGraphicsIfAny** | **bool?**| The flag that indicates whether found SVG graphics(if any) will be compressed(zipped) into SVGZ format during saving. | [optional] 
 **convertMarkedContentToLayers** | **bool?**| If attribute ConvertMarkedContentToLayers set to true then an all elements inside a PDF marked content (layer) will be put into an HTML div with &quot;data-pdflayer&quot; attribute specifying a layer name. This layer name will be extracted from optional properties of PDF marked content. If this attribute is false (by default) then no any layers will be created from PDF marked content. | [optional] 
 **defaultFontName** | **string**| Specifies the name of an installed font which is used to substitute any document font that is not embedded and not installed in the system. If null then default substitution font is used. | [optional] 
 **documentType** | **string**| Result document type. | [optional] 
 **fixedLayout** | **bool?**| The value indicating whether that HTML is created as fixed layout. | [optional] 
 **imageResolution** | **int?**| Resolution for image rendering. | [optional] 
 **minimalLineWidth** | **int?**| This attribute sets minimal width of graphic path line. If thickness of line is less than 1px Adobe Acrobat rounds it to this value. So this attribute can be used to emulate this behavior for HTML browsers. | [optional] 
 **preventGlyphsGrouping** | **bool?**| This attribute switch on the mode when text glyphs will not be grouped into words and strings This mode allows to keep maximum precision during positioning of glyphs on the page and it can be used for conversion documents with music notes or glyphs that should be placed separately each other. This parameter will be applied to document only when the value of FixedLayout attribute is true. | [optional] 
 **splitCssIntoPages** | **bool?**| When multipage-mode selected(i.e &#39;SplitIntoPages&#39; is &#39;true&#39;), then this attribute defines whether should be created separate CSS-file for each result HTML page. | [optional] 
 **splitIntoPages** | **bool?**| The flag that indicates whether each page of source document will be converted into it&#39;s own target HTML document, i.e whether result HTML will be splitted into several HTML-pages. | [optional] 
 **useZOrder** | **bool?**| If attribute UseZORder set to true, graphics and text are added to resultant HTML document accordingly Z-order in original PDF document. If this attribute is false all graphics is put as single layer which may cause some unnecessary effects for overlapped objects. | [optional] 
 **antialiasingProcessing** | **string**| The parameter defines required antialiasing measures during conversion of compound background images from PDF to HTML. | [optional] 
 **cssClassNamesPrefix** | **string**| When PDFtoHTML converter generates result CSSs, CSS class names (something like &quot;.stl_01 {}&quot; ... &quot;.stl_NN {}) are generated and used in result CSS. This property allows forcibly set class name prefix. | [optional] 
 **explicitListOfSavedPages** | **List&lt;int?&gt;**| With this property You can explicitely define what pages of document should be converted. Pages in this list must have 1-based numbers. I.e. valid numbers of pages must be taken from range (1...[NumberOfPagesInConvertedDocument]) Order of appearing of pages in this list does not affect their order in result HTML page(s) - in result pages allways will go in order in which they are present in source PDF. | [optional] 
 **fontEncodingStrategy** | **string**| Defines encoding special rule to tune PDF decoding for current document. | [optional] 
 **fontSavingMode** | **string**| Defines font saving mode that will be used during saving of PDF to desirable format. | [optional] 
 **htmlMarkupGenerationMode** | **string**| Sometimes specific reqirments to generation of HTML markup are present. This parameter defines HTML preparing modes that can be used during conversion of PDF to HTML to match such specific requirments. | [optional] 
 **lettersPositioningMethod** | **string**| The mode of positioning of letters in words in result HTML. | [optional] 
 **pagesFlowTypeDependsOnViewersScreenSize** | **bool?**| If attribute &#39;SplitOnPages&#x3D;false&#39;, than whole HTML representing all input PDF pages will be put into one big result HTML file. This flag defines whether result HTML will be generated in such way that flow of areas that represent PDF pages in result HTML will depend on screen resolution of viewer. | [optional] 
 **partsEmbeddingMode** | **string**| It defines whether referenced files (HTML, Fonts,Images, CSSes) will be embedded into main HTML file or will be generated as apart binary entities. | [optional] 
 **rasterImagesSavingMode** | **string**| Converted PDF can contain raster images This parameter defines how they should be handled during conversion of PDF to HTML. | [optional] 
 **removeEmptyAreasOnTopAndBottom** | **bool?**| Defines whether in created HTML will be removed top and bottom empty area without any content (if any). | [optional] 
 **saveShadowedTextsAsTransparentTexts** | **bool?**| Pdf can contain texts that are shadowed by another elements (f.e. by images) but can be selected to clipboard in Acrobat Reader (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML to mimic behaviour of Acrobat Reader (othervise such texts are usually saved as hidden, not available for copying to clipboard). | [optional] 
 **saveTransparentTexts** | **bool?**| Pdf can contain transparent texts that can be selected to clipboard (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML. | [optional] 
 **specialFolderForAllImages** | **string**| The path to directory to which must be saved any images if they are encountered during saving of document as HTML. If parameter is empty or null then image files(if any) wil be saved together with other files linked to HTML It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. | [optional] 
 **specialFolderForSvgImages** | **string**| The path to directory to which must be saved only SVG-images if they are encountered during saving of document as HTML. If parameter is empty or null then SVG files(if any) wil be saved together with other image-files (near to output file) or in special folder for images (if it specified in SpecialImagesFolderIfAny option). It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. | [optional] 
 **trySaveTextUnderliningAndStrikeoutingInCss** | **bool?**| PDF itself does not contain underlining markers for texts. It emulated with line situated under text. This option allows converter try guess that this or that line is a text&#39;s underlining and put this info into CSS instead of drawing of underlining graphically. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttolatex"></a>
# **PutPdfInRequestToLaTeX**
> AsposeResponse PutPdfInRequestToLaTeX (string outPath, int? pagesCount = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to LaTeX format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.tex) | 
 **pagesCount** | **int?**| Pages count. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttomobixml"></a>
# **PutPdfInRequestToMobiXml**
> AsposeResponse PutPdfInRequestToMobiXml (string outPath, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to MOBIXML format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.mobixml) | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttopdfa"></a>
# **PutPdfInRequestToPdfA**
> AsposeResponse PutPdfInRequestToPdfA (string outPath, string type, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to PdfA format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.pdf) | 
 **type** | **string**| Type of PdfA format. | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttopptx"></a>
# **PutPdfInRequestToPptx**
> AsposeResponse PutPdfInRequestToPptx (string outPath, bool? separateImages = null, bool? slidesAsImages = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to PPTX format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.pptx) | 
 **separateImages** | **bool?**| Separate images. | [optional] 
 **slidesAsImages** | **bool?**| Slides as images. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttosvg"></a>
# **PutPdfInRequestToSvg**
> AsposeResponse PutPdfInRequestToSvg (string outPath, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to SVG format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.svg) | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttotiff"></a>
# **PutPdfInRequestToTiff**
> AsposeResponse PutPdfInRequestToTiff (string outPath, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to TIFF format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.tiff) | 
 **brightness** | **double?**| Image brightness. | [optional] 
 **compression** | **string**| Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. | [optional] 
 **colorDepth** | **string**| Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. | [optional] 
 **leftMargin** | **int?**| Left image margin. | [optional] 
 **rightMargin** | **int?**| Right image margin. | [optional] 
 **topMargin** | **int?**| Top image margin. | [optional] 
 **bottomMargin** | **int?**| Bottom image margin. | [optional] 
 **orientation** | **string**| Image orientation. Possible values are: None, Landscape, Portait. | [optional] 
 **skipBlankPages** | **bool?**| Skip blank pages flag. | [optional] 
 **width** | **int?**| Image width. | [optional] 
 **height** | **int?**| Image height. | [optional] 
 **xResolution** | **int?**| Horizontal resolution. | [optional] 
 **yResolution** | **int?**| Vertical resolution. | [optional] 
 **pageIndex** | **int?**| Start page to export. | [optional] 
 **pageCount** | **int?**| Number of pages to export. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttoxls"></a>
# **PutPdfInRequestToXls**
> AsposeResponse PutPdfInRequestToXls (string outPath, bool? insertBlankColumnAtFirst = null, bool? minimizeTheNumberOfWorksheets = null, double? scaleFactor = null, bool? uniformWorksheets = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to XLS format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xls) | 
 **insertBlankColumnAtFirst** | **bool?**| Insert blank column at first | [optional] 
 **minimizeTheNumberOfWorksheets** | **bool?**| Minimize the number of worksheets | [optional] 
 **scaleFactor** | **double?**| Scale factor | [optional] 
 **uniformWorksheets** | **bool?**| Uniform worksheets | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttoxml"></a>
# **PutPdfInRequestToXml**
> AsposeResponse PutPdfInRequestToXml (string outPath, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to XML format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xml) | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttoxps"></a>
# **PutPdfInRequestToXps**
> AsposeResponse PutPdfInRequestToXps (string outPath, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to XPS format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xps) | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetodoc"></a>
# **PutPdfInStorageToDoc**
> AsposeResponse PutPdfInStorageToDoc (string name, string outPath, bool? addReturnToLineEnd = null, string format = null, int? imageResolutionX = null, int? imageResolutionY = null, double? maxDistanceBetweenTextLines = null, string mode = null, bool? recognizeBullets = null, double? relativeHorizontalProximity = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to DOC format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.doc) | 
 **addReturnToLineEnd** | **bool?**| Add return to line end. | [optional] 
 **format** | **string**| Allows to specify .doc or .docx file format. | [optional] 
 **imageResolutionX** | **int?**| Image resolution X. | [optional] 
 **imageResolutionY** | **int?**| Image resolution Y. | [optional] 
 **maxDistanceBetweenTextLines** | **double?**| Max distance between text lines. | [optional] 
 **mode** | **string**| Allows to control how a PDF document is converted into a word processing document. | [optional] 
 **recognizeBullets** | **bool?**| Recognize bullets. | [optional] 
 **relativeHorizontalProximity** | **double?**| Relative horizontal proximity. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetoepub"></a>
# **PutPdfInStorageToEpub**
> AsposeResponse PutPdfInStorageToEpub (string name, string outPath, string contentRecognitionMode = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to EPUB format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.epub) | 
 **contentRecognitionMode** | **string**| ?roperty tunes conversion for this or that desirable method of recognition of content. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetohtml"></a>
# **PutPdfInStorageToHtml**
> AsposeResponse PutPdfInStorageToHtml (string name, string outPath, int? additionalMarginWidthInPoints = null, bool? compressSvgGraphicsIfAny = null, bool? convertMarkedContentToLayers = null, string defaultFontName = null, string documentType = null, bool? fixedLayout = null, int? imageResolution = null, int? minimalLineWidth = null, bool? preventGlyphsGrouping = null, bool? splitCssIntoPages = null, bool? splitIntoPages = null, bool? useZOrder = null, string antialiasingProcessing = null, string cssClassNamesPrefix = null, List<int?> explicitListOfSavedPages = null, string fontEncodingStrategy = null, string fontSavingMode = null, string htmlMarkupGenerationMode = null, string lettersPositioningMethod = null, bool? pagesFlowTypeDependsOnViewersScreenSize = null, string partsEmbeddingMode = null, string rasterImagesSavingMode = null, bool? removeEmptyAreasOnTopAndBottom = null, bool? saveShadowedTextsAsTransparentTexts = null, bool? saveTransparentTexts = null, string specialFolderForAllImages = null, string specialFolderForSvgImages = null, bool? trySaveTextUnderliningAndStrikeoutingInCss = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to Html format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.html) | 
 **additionalMarginWidthInPoints** | **int?**| Defines width of margin that will be forcibly left around that output HTML-areas. | [optional] 
 **compressSvgGraphicsIfAny** | **bool?**| The flag that indicates whether found SVG graphics(if any) will be compressed(zipped) into SVGZ format during saving. | [optional] 
 **convertMarkedContentToLayers** | **bool?**| If attribute ConvertMarkedContentToLayers set to true then an all elements inside a PDF marked content (layer) will be put into an HTML div with &quot;data-pdflayer&quot; attribute specifying a layer name. This layer name will be extracted from optional properties of PDF marked content. If this attribute is false (by default) then no any layers will be created from PDF marked content. | [optional] 
 **defaultFontName** | **string**| Specifies the name of an installed font which is used to substitute any document font that is not embedded and not installed in the system. If null then default substitution font is used. | [optional] 
 **documentType** | **string**| Result document type. | [optional] 
 **fixedLayout** | **bool?**| The value indicating whether that HTML is created as fixed layout. | [optional] 
 **imageResolution** | **int?**| Resolution for image rendering. | [optional] 
 **minimalLineWidth** | **int?**| This attribute sets minimal width of graphic path line. If thickness of line is less than 1px Adobe Acrobat rounds it to this value. So this attribute can be used to emulate this behavior for HTML browsers. | [optional] 
 **preventGlyphsGrouping** | **bool?**| This attribute switch on the mode when text glyphs will not be grouped into words and strings This mode allows to keep maximum precision during positioning of glyphs on the page and it can be used for conversion documents with music notes or glyphs that should be placed separately each other. This parameter will be applied to document only when the value of FixedLayout attribute is true. | [optional] 
 **splitCssIntoPages** | **bool?**| When multipage-mode selected(i.e &#39;SplitIntoPages&#39; is &#39;true&#39;), then this attribute defines whether should be created separate CSS-file for each result HTML page. | [optional] 
 **splitIntoPages** | **bool?**| The flag that indicates whether each page of source document will be converted into it&#39;s own target HTML document, i.e whether result HTML will be splitted into several HTML-pages. | [optional] 
 **useZOrder** | **bool?**| If attribute UseZORder set to true, graphics and text are added to resultant HTML document accordingly Z-order in original PDF document. If this attribute is false all graphics is put as single layer which may cause some unnecessary effects for overlapped objects. | [optional] 
 **antialiasingProcessing** | **string**| The parameter defines required antialiasing measures during conversion of compound background images from PDF to HTML. | [optional] 
 **cssClassNamesPrefix** | **string**| When PDFtoHTML converter generates result CSSs, CSS class names (something like &quot;.stl_01 {}&quot; ... &quot;.stl_NN {}) are generated and used in result CSS. This property allows forcibly set class name prefix. | [optional] 
 **explicitListOfSavedPages** | **List&lt;int?&gt;**| With this property You can explicitely define what pages of document should be converted. Pages in this list must have 1-based numbers. I.e. valid numbers of pages must be taken from range (1...[NumberOfPagesInConvertedDocument]) Order of appearing of pages in this list does not affect their order in result HTML page(s) - in result pages allways will go in order in which they are present in source PDF. | [optional] 
 **fontEncodingStrategy** | **string**| Defines encoding special rule to tune PDF decoding for current document. | [optional] 
 **fontSavingMode** | **string**| Defines font saving mode that will be used during saving of PDF to desirable format. | [optional] 
 **htmlMarkupGenerationMode** | **string**| Sometimes specific reqirments to generation of HTML markup are present. This parameter defines HTML preparing modes that can be used during conversion of PDF to HTML to match such specific requirments. | [optional] 
 **lettersPositioningMethod** | **string**| The mode of positioning of letters in words in result HTML. | [optional] 
 **pagesFlowTypeDependsOnViewersScreenSize** | **bool?**| If attribute &#39;SplitOnPages&#x3D;false&#39;, than whole HTML representing all input PDF pages will be put into one big result HTML file. This flag defines whether result HTML will be generated in such way that flow of areas that represent PDF pages in result HTML will depend on screen resolution of viewer. | [optional] 
 **partsEmbeddingMode** | **string**| It defines whether referenced files (HTML, Fonts,Images, CSSes) will be embedded into main HTML file or will be generated as apart binary entities. | [optional] 
 **rasterImagesSavingMode** | **string**| Converted PDF can contain raster images This parameter defines how they should be handled during conversion of PDF to HTML. | [optional] 
 **removeEmptyAreasOnTopAndBottom** | **bool?**| Defines whether in created HTML will be removed top and bottom empty area without any content (if any). | [optional] 
 **saveShadowedTextsAsTransparentTexts** | **bool?**| Pdf can contain texts that are shadowed by another elements (f.e. by images) but can be selected to clipboard in Acrobat Reader (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML to mimic behaviour of Acrobat Reader (othervise such texts are usually saved as hidden, not available for copying to clipboard). | [optional] 
 **saveTransparentTexts** | **bool?**| Pdf can contain transparent texts that can be selected to clipboard (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML. | [optional] 
 **specialFolderForAllImages** | **string**| The path to directory to which must be saved any images if they are encountered during saving of document as HTML. If parameter is empty or null then image files(if any) wil be saved together with other files linked to HTML It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. | [optional] 
 **specialFolderForSvgImages** | **string**| The path to directory to which must be saved only SVG-images if they are encountered during saving of document as HTML. If parameter is empty or null then SVG files(if any) wil be saved together with other image-files (near to output file) or in special folder for images (if it specified in SpecialImagesFolderIfAny option). It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. | [optional] 
 **trySaveTextUnderliningAndStrikeoutingInCss** | **bool?**| PDF itself does not contain underlining markers for texts. It emulated with line situated under text. This option allows converter try guess that this or that line is a text&#39;s underlining and put this info into CSS instead of drawing of underlining graphically. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetolatex"></a>
# **PutPdfInStorageToLaTeX**
> AsposeResponse PutPdfInStorageToLaTeX (string name, string outPath, int? pagesCount = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to LaTeX format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.tex) | 
 **pagesCount** | **int?**| Pages count. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetomobixml"></a>
# **PutPdfInStorageToMobiXml**
> AsposeResponse PutPdfInStorageToMobiXml (string name, string outPath, string folder = null, string storage = null)

Converts PDF document (located on storage) to MOBIXML format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.mobixml) | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetopdfa"></a>
# **PutPdfInStorageToPdfA**
> AsposeResponse PutPdfInStorageToPdfA (string name, string outPath, string type, string folder = null, string storage = null)

Converts PDF document (located on storage) to PdfA format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.pdf) | 
 **type** | **string**| Type of PdfA format. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetopptx"></a>
# **PutPdfInStorageToPptx**
> AsposeResponse PutPdfInStorageToPptx (string name, string outPath, bool? separateImages = null, bool? slidesAsImages = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to PPTX format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.pptx) | 
 **separateImages** | **bool?**| Separate images. | [optional] 
 **slidesAsImages** | **bool?**| Slides as images. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetosvg"></a>
# **PutPdfInStorageToSvg**
> AsposeResponse PutPdfInStorageToSvg (string name, string outPath, string folder = null, string storage = null)

Converts PDF document (located on storage) to SVG format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.svg) | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetotiff"></a>
# **PutPdfInStorageToTiff**
> AsposeResponse PutPdfInStorageToTiff (string name, string outPath, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to TIFF format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.tiff) | 
 **brightness** | **double?**| Image brightness. | [optional] 
 **compression** | **string**| Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. | [optional] 
 **colorDepth** | **string**| Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. | [optional] 
 **leftMargin** | **int?**| Left image margin. | [optional] 
 **rightMargin** | **int?**| Right image margin. | [optional] 
 **topMargin** | **int?**| Top image margin. | [optional] 
 **bottomMargin** | **int?**| Bottom image margin. | [optional] 
 **orientation** | **string**| Image orientation. Possible values are: None, Landscape, Portait. | [optional] 
 **skipBlankPages** | **bool?**| Skip blank pages flag. | [optional] 
 **width** | **int?**| Image width. | [optional] 
 **height** | **int?**| Image height. | [optional] 
 **xResolution** | **int?**| Horizontal resolution. | [optional] 
 **yResolution** | **int?**| Vertical resolution. | [optional] 
 **pageIndex** | **int?**| Start page to export. | [optional] 
 **pageCount** | **int?**| Number of pages to export. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetoxls"></a>
# **PutPdfInStorageToXls**
> AsposeResponse PutPdfInStorageToXls (string name, string outPath, bool? insertBlankColumnAtFirst = null, bool? minimizeTheNumberOfWorksheets = null, double? scaleFactor = null, bool? uniformWorksheets = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to XLS format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xls) | 
 **insertBlankColumnAtFirst** | **bool?**| Insert blank column at first | [optional] 
 **minimizeTheNumberOfWorksheets** | **bool?**| Minimize the number of worksheets | [optional] 
 **scaleFactor** | **double?**| Scale factor | [optional] 
 **uniformWorksheets** | **bool?**| Uniform worksheets | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetoxml"></a>
# **PutPdfInStorageToXml**
> AsposeResponse PutPdfInStorageToXml (string name, string outPath, string folder = null, string storage = null)

Converts PDF document (located on storage) to XML format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xml) | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetoxps"></a>
# **PutPdfInStorageToXps**
> AsposeResponse PutPdfInStorageToXps (string name, string outPath, string folder = null, string storage = null)

Converts PDF document (located on storage) to XPS format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xps) | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putprivileges"></a>
# **PutPrivileges**
> AsposeResponse PutPrivileges (string name, DocumentPrivilege privileges = null, string storage = null, string folder = null)

Update privilege document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **privileges** | [**DocumentPrivilege**](DocumentPrivilege.md)| Document privileges.  | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpsinstoragetopdf"></a>
# **PutPsInStorageToPdf**
> AsposeResponse PutPsInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert PS file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.ps) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putreplaceimage"></a>
# **PutReplaceImage**
> ImageResponse PutReplaceImage (string name, string imageId, string imageFilePath = null, string storage = null, string folder = null, System.IO.Stream image = null)

Replace document image.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| The image ID. | 
 **imageFilePath** | **string**| Path to image file if specified. Request content is used otherwise. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **image** | **System.IO.Stream**| Image file. | [optional] 

### Return type

[**ImageResponse**](ImageResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsearchabledocument"></a>
# **PutSearchableDocument**
> AsposeResponse PutSearchableDocument (string name, string storage = null, string folder = null, string lang = null)

Create searchable PDF document. Generate OCR layer for images in input PDF document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **lang** | **string**| language for OCR engine. Possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra or thier combination e.g. eng,rus  | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsetproperty"></a>
# **PutSetProperty**
> DocumentPropertyResponse PutSetProperty (string name, string propertyName, string value, string storage = null, string folder = null)

Add/update document property.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **propertyName** | **string**|  | 
 **value** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**DocumentPropertyResponse**](DocumentPropertyResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsvginstoragetopdf"></a>
# **PutSvgInStorageToPdf**
> AsposeResponse PutSvgInStorageToPdf (string name, string srcPath, bool? adjustPageSize = null, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string dstFolder = null, string storage = null)

Convert SVG file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.svg) | 
 **adjustPageSize** | **bool?**| Adjust page size | [optional] 
 **height** | **double?**| Page height | [optional] 
 **width** | **double?**| Page width | [optional] 
 **isLandscape** | **bool?**| Is page landscaped | [optional] 
 **marginLeft** | **double?**| Page margin left | [optional] 
 **marginBottom** | **double?**| Page margin bottom | [optional] 
 **marginRight** | **double?**| Page margin right | [optional] 
 **marginTop** | **double?**| Page margin top | [optional] 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puttextannotation"></a>
# **PutTextAnnotation**
> TextAnnotationResponse PutTextAnnotation (string name, string annotationId, TextAnnotation annotation, string storage = null, string folder = null)

Replace document text annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**TextAnnotation**](TextAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TextAnnotationResponse**](TextAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putupdatefield"></a>
# **PutUpdateField**
> FieldResponse PutUpdateField (string name, string fieldName, Field field = null, string storage = null, string folder = null)

Update field.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The name of a field to be updated. | 
 **field** | [**Field**](Field.md)| with the field data. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FieldResponse**](FieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putupdatefields"></a>
# **PutUpdateFields**
> FieldsResponse PutUpdateFields (string name, Fields fields = null, string storage = null, string folder = null)

Update fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fields** | [**Fields**](Fields.md)| with the fields data. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FieldsResponse**](FieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putwebinstoragetopdf"></a>
# **PutWebInStorageToPdf**
> AsposeResponse PutWebInStorageToPdf (string name, string url, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string dstFolder = null, string storage = null)

Convert web page to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **url** | **string**| Source url | 
 **height** | **double?**| Page height | [optional] 
 **width** | **double?**| Page width | [optional] 
 **isLandscape** | **bool?**| Is page landscaped | [optional] 
 **marginLeft** | **double?**| Page margin left | [optional] 
 **marginBottom** | **double?**| Page margin bottom | [optional] 
 **marginRight** | **double?**| Page margin right | [optional] 
 **marginTop** | **double?**| Page margin top | [optional] 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putxfapdfinrequesttoacroform"></a>
# **PutXfaPdfInRequestToAcroForm**
> AsposeResponse PutXfaPdfInRequestToAcroForm (string outPath, string storage = null, System.IO.Stream file = null)

Converts PDF document which contatins XFA form (in request content) to PDF with AcroForm and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.pdf) | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putxfapdfinstoragetoacroform"></a>
# **PutXfaPdfInStorageToAcroForm**
> AsposeResponse PutXfaPdfInStorageToAcroForm (string name, string outPath, string folder = null, string storage = null)

Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.pdf) | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putxmlinstoragetopdf"></a>
# **PutXmlInStorageToPdf**
> AsposeResponse PutXmlInStorageToPdf (string name, string srcPath, string xslFilePath = null, string dstFolder = null, string storage = null)

Convert XML file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.xml) | 
 **xslFilePath** | **string**| Full XSL source filename (ex. /folder1/folder2/template.xsl) | [optional] 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putxpsinstoragetopdf"></a>
# **PutXpsInStorageToPdf**
> AsposeResponse PutXpsInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert XPS file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.xps) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putxslfoinstoragetopdf"></a>
# **PutXslFoInStorageToPdf**
> AsposeResponse PutXslFoInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert XslFo file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.xpsfo) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

