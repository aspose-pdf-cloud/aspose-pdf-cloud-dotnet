# Aspose.Pdf.Cloud.Sdk.Api.PdfApi

All URIs are relative to *https://api.aspose.cloud/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAnnotation**](PdfApi.md#deleteannotation) | **DELETE** /pdf/{name}/annotations/{annotationId} | Delete document annotation by ID
[**DeleteDocumentAnnotations**](PdfApi.md#deletedocumentannotations) | **DELETE** /pdf/{name}/annotations | Delete all annotations from the document
[**DeleteDocumentLinkAnnotations**](PdfApi.md#deletedocumentlinkannotations) | **DELETE** /pdf/{name}/links | Delete all link annotations from the document
[**DeleteField**](PdfApi.md#deletefield) | **DELETE** /pdf/{name}/fields/{fieldName} | Delete document field by name.
[**DeleteImage**](PdfApi.md#deleteimage) | **DELETE** /pdf/{name}/images/{imageId} | Delete image from document page.
[**DeleteLinkAnnotation**](PdfApi.md#deletelinkannotation) | **DELETE** /pdf/{name}/links/{linkId} | Delete document page link annotation by ID
[**DeletePage**](PdfApi.md#deletepage) | **DELETE** /pdf/{name}/pages/{pageNumber} | Delete document page by its number.
[**DeletePageAnnotations**](PdfApi.md#deletepageannotations) | **DELETE** /pdf/{name}/pages/{pageNumber}/annotations | Delete all annotations from the page
[**DeletePageLinkAnnotations**](PdfApi.md#deletepagelinkannotations) | **DELETE** /pdf/{name}/pages/{pageNumber}/links | Delete all link annotations from the page
[**DeleteProperties**](PdfApi.md#deleteproperties) | **DELETE** /pdf/{name}/documentproperties | Delete custom document properties.
[**DeleteProperty**](PdfApi.md#deleteproperty) | **DELETE** /pdf/{name}/documentproperties/{propertyName} | Delete document property.
[**GetDocument**](PdfApi.md#getdocument) | **GET** /pdf/{name} | Read common document info.
[**GetDocumentAnnotations**](PdfApi.md#getdocumentannotations) | **GET** /pdf/{name}/annotations | Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
[**GetDocumentAttachmentByIndex**](PdfApi.md#getdocumentattachmentbyindex) | **GET** /pdf/{name}/attachments/{attachmentIndex} | Read document attachment info by its index.
[**GetDocumentAttachments**](PdfApi.md#getdocumentattachments) | **GET** /pdf/{name}/attachments | Read document attachments info.
[**GetDocumentBookmarks**](PdfApi.md#getdocumentbookmarks) | **GET** /pdf/{name}/bookmarks | Read document bookmark/bookmarks (including children).
[**GetDocumentFreeTextAnnotations**](PdfApi.md#getdocumentfreetextannotations) | **GET** /pdf/{name}/annotations/freetext | Read document free text annotations.
[**GetDocumentProperties**](PdfApi.md#getdocumentproperties) | **GET** /pdf/{name}/documentproperties | Read document properties.
[**GetDocumentProperty**](PdfApi.md#getdocumentproperty) | **GET** /pdf/{name}/documentproperties/{propertyName} | Read document property by name.
[**GetDocumentTextAnnotations**](PdfApi.md#getdocumenttextannotations) | **GET** /pdf/{name}/annotations/text | Read document text annotations.
[**GetDownload**](PdfApi.md#getdownload) | **GET** /storage/file | Download a specific file 
[**GetDownloadDocumentAttachmentByIndex**](PdfApi.md#getdownloaddocumentattachmentbyindex) | **GET** /pdf/{name}/attachments/{attachmentIndex}/download | Download document attachment content by its index.
[**GetEpubInStorageToPdf**](PdfApi.md#getepubinstoragetopdf) | **GET** /pdf/create/epub | Convert EPUB file (located on storage) to PDF format and return resulting file in response. 
[**GetField**](PdfApi.md#getfield) | **GET** /pdf/{name}/fields/{fieldName} | Get document field by name.
[**GetFields**](PdfApi.md#getfields) | **GET** /pdf/{name}/fields | Get document fields.
[**GetFreeTextAnnotation**](PdfApi.md#getfreetextannotation) | **GET** /pdf/{name}/annotations/freetext/{annotationId} | Read document page free text annotation by ID.
[**GetHtmlInStorageToPdf**](PdfApi.md#gethtmlinstoragetopdf) | **GET** /pdf/create/html | Convert HTML file (located on storage) to PDF format and return resulting file in response. 
[**GetImage**](PdfApi.md#getimage) | **GET** /pdf/{name}/images/{imageId} | Read document image by ID.
[**GetImageExtractAsGif**](PdfApi.md#getimageextractasgif) | **GET** /pdf/{name}/images/{imageId}/extract/gif | Extract document image in GIF format
[**GetImageExtractAsJpeg**](PdfApi.md#getimageextractasjpeg) | **GET** /pdf/{name}/images/{imageId}/extract/jpeg | Extract document image in JPEG format
[**GetImageExtractAsPng**](PdfApi.md#getimageextractaspng) | **GET** /pdf/{name}/images/{imageId}/extract/png | Extract document image in PNG format
[**GetImageExtractAsTiff**](PdfApi.md#getimageextractastiff) | **GET** /pdf/{name}/images/{imageId}/extract/tiff | Extract document image in TIFF format
[**GetImages**](PdfApi.md#getimages) | **GET** /pdf/{name}/pages/{pageNumber}/images | Read document images.
[**GetLaTeXInStorageToPdf**](PdfApi.md#getlatexinstoragetopdf) | **GET** /pdf/create/latex | Convert LaTeX file (located on storage) to PDF format and return resulting file in response. 
[**GetLinkAnnotation**](PdfApi.md#getlinkannotation) | **GET** /pdf/{name}/links/{linkId} | Read document link annotation by ID.
[**GetMhtInStorageToPdf**](PdfApi.md#getmhtinstoragetopdf) | **GET** /pdf/create/mht | Convert MHT file (located on storage) to PDF format and return resulting file in response. 
[**GetPage**](PdfApi.md#getpage) | **GET** /pdf/{name}/pages/{pageNumber} | Read document page info.
[**GetPageAnnotations**](PdfApi.md#getpageannotations) | **GET** /pdf/{name}/pages/{pageNumber}/annotations | Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
[**GetPageConvertToBmp**](PdfApi.md#getpageconverttobmp) | **GET** /pdf/{name}/pages/{pageNumber}/convert/bmp | Convert document page to Bmp image and return resulting file in response.
[**GetPageConvertToEmf**](PdfApi.md#getpageconverttoemf) | **GET** /pdf/{name}/pages/{pageNumber}/convert/emf | Convert document page to Emf image and return resulting file in response.
[**GetPageConvertToGif**](PdfApi.md#getpageconverttogif) | **GET** /pdf/{name}/pages/{pageNumber}/convert/gif | Convert document page to Gif image and return resulting file in response.
[**GetPageConvertToJpeg**](PdfApi.md#getpageconverttojpeg) | **GET** /pdf/{name}/pages/{pageNumber}/convert/jpeg | Convert document page to Jpeg image and return resulting file in response.
[**GetPageConvertToPng**](PdfApi.md#getpageconverttopng) | **GET** /pdf/{name}/pages/{pageNumber}/convert/png | Convert document page to Png image and return resulting file in response.
[**GetPageConvertToTiff**](PdfApi.md#getpageconverttotiff) | **GET** /pdf/{name}/pages/{pageNumber}/convert/tiff | Convert document page to Tiff image  and return resulting file in response.
[**GetPageFreeTextAnnotations**](PdfApi.md#getpagefreetextannotations) | **GET** /pdf/{name}/pages/{pageNumber}/annotations/freetext | Read document page free text annotations.
[**GetPageLinkAnnotation**](PdfApi.md#getpagelinkannotation) | **GET** /pdf/{name}/pages/{pageNumber}/links/{linkId} | Read document page link annotation by ID.
[**GetPageLinkAnnotations**](PdfApi.md#getpagelinkannotations) | **GET** /pdf/{name}/pages/{pageNumber}/links | Read document page link annotations.
[**GetPageText**](PdfApi.md#getpagetext) | **GET** /pdf/{name}/pages/{pageNumber}/text | Read page text items.
[**GetPageTextAnnotations**](PdfApi.md#getpagetextannotations) | **GET** /pdf/{name}/pages/{pageNumber}/annotations/text | Read document page text annotations.
[**GetPages**](PdfApi.md#getpages) | **GET** /pdf/{name}/pages | Read document pages info.
[**GetPclInStorageToPdf**](PdfApi.md#getpclinstoragetopdf) | **GET** /pdf/create/pcl | Convert PCL file (located on storage) to PDF format and return resulting file in response. 
[**GetPdfInStorageToDoc**](PdfApi.md#getpdfinstoragetodoc) | **GET** /pdf/{name}/convert/doc | Converts PDF document (located on storage) to DOC format and returns resulting file in response content
[**GetPdfInStorageToEpub**](PdfApi.md#getpdfinstoragetoepub) | **GET** /pdf/{name}/convert/epub | Converts PDF document (located on storage) to EPUB format and returns resulting file in response content
[**GetPdfInStorageToHtml**](PdfApi.md#getpdfinstoragetohtml) | **GET** /pdf/{name}/convert/html | Converts PDF document (located on storage) to Html format and returns resulting file in response content
[**GetPdfInStorageToLaTeX**](PdfApi.md#getpdfinstoragetolatex) | **GET** /pdf/{name}/convert/latex | Converts PDF document (located on storage) to LaTeX format and returns resulting file in response content
[**GetPdfInStorageToMobiXml**](PdfApi.md#getpdfinstoragetomobixml) | **GET** /pdf/{name}/convert/mobixml | Converts PDF document (located on storage) to MOBIXML format and returns resulting file in response content
[**GetPdfInStorageToPdfA**](PdfApi.md#getpdfinstoragetopdfa) | **GET** /pdf/{name}/convert/pdfa | Converts PDF document (located on storage) to PdfA format and returns resulting file in response content
[**GetPdfInStorageToPptx**](PdfApi.md#getpdfinstoragetopptx) | **GET** /pdf/{name}/convert/pptx | Converts PDF document (located on storage) to PPTX format and returns resulting file in response content
[**GetPdfInStorageToSvg**](PdfApi.md#getpdfinstoragetosvg) | **GET** /pdf/{name}/convert/svg | Converts PDF document (located on storage) to SVG format and returns resulting file in response content
[**GetPdfInStorageToTiff**](PdfApi.md#getpdfinstoragetotiff) | **GET** /pdf/{name}/convert/tiff | Converts PDF document (located on storage) to TIFF format and returns resulting file in response content
[**GetPdfInStorageToXls**](PdfApi.md#getpdfinstoragetoxls) | **GET** /pdf/{name}/convert/xls | Converts PDF document (located on storage) to XLS format and returns resulting file in response content
[**GetPdfInStorageToXml**](PdfApi.md#getpdfinstoragetoxml) | **GET** /pdf/{name}/convert/xml | Converts PDF document (located on storage) to XML format and returns resulting file in response content
[**GetPdfInStorageToXps**](PdfApi.md#getpdfinstoragetoxps) | **GET** /pdf/{name}/convert/xps | Converts PDF document (located on storage) to XPS format and returns resulting file in response content
[**GetPsInStorageToPdf**](PdfApi.md#getpsinstoragetopdf) | **GET** /pdf/create/ps | Convert PS file (located on storage) to PDF format and return resulting file in response. 
[**GetSvgInStorageToPdf**](PdfApi.md#getsvginstoragetopdf) | **GET** /pdf/create/svg | Convert SVG file (located on storage) to PDF format and return resulting file in response. 
[**GetText**](PdfApi.md#gettext) | **GET** /pdf/{name}/text | Read document text.
[**GetTextAnnotation**](PdfApi.md#gettextannotation) | **GET** /pdf/{name}/annotations/text/{annotationId} | Read document page text annotation by ID.
[**GetVerifySignature**](PdfApi.md#getverifysignature) | **GET** /pdf/{name}/verifySignature | Verify signature document.
[**GetWebInStorageToPdf**](PdfApi.md#getwebinstoragetopdf) | **GET** /pdf/create/web | Convert web page to PDF format and return resulting file in response. 
[**GetWordsPerPage**](PdfApi.md#getwordsperpage) | **GET** /pdf/{name}/pages/wordCount | Get number of words per document page.
[**GetXfaPdfInStorageToAcroForm**](PdfApi.md#getxfapdfinstoragetoacroform) | **GET** /pdf/{name}/convert/xfatoacroform | Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and returns resulting file response content
[**GetXmlInStorageToPdf**](PdfApi.md#getxmlinstoragetopdf) | **GET** /pdf/create/xml | Convert XML file (located on storage) to PDF format and return resulting file in response. 
[**GetXpsInStorageToPdf**](PdfApi.md#getxpsinstoragetopdf) | **GET** /pdf/create/xps | Convert XPS file (located on storage) to PDF format and return resulting file in response. 
[**GetXslFoInStorageToPdf**](PdfApi.md#getxslfoinstoragetopdf) | **GET** /pdf/create/xslfo | Convert XslFo file (located on storage) to PDF format and return resulting file in response. 
[**PostAppendDocument**](PdfApi.md#postappenddocument) | **POST** /pdf/{name}/appendDocument | Append document to existing one.
[**PostCreateField**](PdfApi.md#postcreatefield) | **POST** /pdf/{name}/fields | Create field.
[**PostDocumentTextReplace**](PdfApi.md#postdocumenttextreplace) | **POST** /pdf/{name}/text/replace | Document&#39;s replace text method.
[**PostInsertImage**](PdfApi.md#postinsertimage) | **POST** /pdf/{name}/pages/{pageNumber}/images | Insert image to document page.
[**PostMovePage**](PdfApi.md#postmovepage) | **POST** /pdf/{name}/pages/{pageNumber}/movePage | Move page to new position.
[**PostOptimizeDocument**](PdfApi.md#postoptimizedocument) | **POST** /pdf/{name}/optimize | Optimize document.
[**PostPageFreeTextAnnotations**](PdfApi.md#postpagefreetextannotations) | **POST** /pdf/{name}/pages/{pageNumber}/annotations/freetext | Add document page free text annotations.
[**PostPageLinkAnnotations**](PdfApi.md#postpagelinkannotations) | **POST** /pdf/{name}/pages/{pageNumber}/links | Add document page link annotations.
[**PostPageTextAnnotations**](PdfApi.md#postpagetextannotations) | **POST** /pdf/{name}/pages/{pageNumber}/annotations/text | Add document page text annotations.
[**PostPageTextReplace**](PdfApi.md#postpagetextreplace) | **POST** /pdf/{name}/pages/{pageNumber}/text/replace | Page&#39;s replace text method.
[**PostSignDocument**](PdfApi.md#postsigndocument) | **POST** /pdf/{name}/sign | Sign document.
[**PostSignPage**](PdfApi.md#postsignpage) | **POST** /pdf/{name}/pages/{pageNumber}/sign | Sign page.
[**PostSplitDocument**](PdfApi.md#postsplitdocument) | **POST** /pdf/{name}/split | Split document to parts.
[**PutAddNewPage**](PdfApi.md#putaddnewpage) | **PUT** /pdf/{name}/pages | Add new page to end of the document.
[**PutAddText**](PdfApi.md#putaddtext) | **PUT** /pdf/{name}/pages/{pageNumber}/text | Add text to PDF document page.
[**PutCreate**](PdfApi.md#putcreate) | **PUT** /storage/file | Upload a specific file 
[**PutCreateDocument**](PdfApi.md#putcreatedocument) | **PUT** /pdf/{name} | Create empty document.
[**PutEpubInStorageToPdf**](PdfApi.md#putepubinstoragetopdf) | **PUT** /pdf/{name}/create/epub | Convert EPUB file (located on storage) to PDF format and upload resulting file to storage. 
[**PutFieldsFlatten**](PdfApi.md#putfieldsflatten) | **PUT** /pdf/{name}/fields/flatten | Flatten form fields in document.
[**PutFreeTextAnnotation**](PdfApi.md#putfreetextannotation) | **PUT** /pdf/{name}/annotations/freetext/{annotationId} | Replace document free text annotation
[**PutHtmlInStorageToPdf**](PdfApi.md#puthtmlinstoragetopdf) | **PUT** /pdf/{name}/create/html | Convert HTML file (located on storage) to PDF format and upload resulting file to storage. 
[**PutImageExtractAsGif**](PdfApi.md#putimageextractasgif) | **PUT** /pdf/{name}/images/{imageId}/extract/gif | Extract document image in GIF format to folder
[**PutImageExtractAsJpeg**](PdfApi.md#putimageextractasjpeg) | **PUT** /pdf/{name}/images/{imageId}/extract/jpeg | Extract document image in JPEG format to folder
[**PutImageExtractAsPng**](PdfApi.md#putimageextractaspng) | **PUT** /pdf/{name}/images/{imageId}/extract/png | Extract document image in PNG format to folder
[**PutImageExtractAsTiff**](PdfApi.md#putimageextractastiff) | **PUT** /pdf/{name}/images/{imageId}/extract/tiff | Extract document image in TIFF format to folder
[**PutImageInStorageToPdf**](PdfApi.md#putimageinstoragetopdf) | **PUT** /pdf/{name}/create/images | Convert image file (located on storage) to PDF format and upload resulting file to storage. 
[**PutImagesExtractAsGif**](PdfApi.md#putimagesextractasgif) | **PUT** /pdf/{name}/pages/{pageNumber}/images/extract/gif | Extract document images in GIF format to folder.
[**PutImagesExtractAsJpeg**](PdfApi.md#putimagesextractasjpeg) | **PUT** /pdf/{name}/pages/{pageNumber}/images/extract/jpeg | Extract document images in JPEG format to folder.
[**PutImagesExtractAsPng**](PdfApi.md#putimagesextractaspng) | **PUT** /pdf/{name}/pages/{pageNumber}/images/extract/png | Extract document images in PNG format to folder.
[**PutImagesExtractAsTiff**](PdfApi.md#putimagesextractastiff) | **PUT** /pdf/{name}/pages/{pageNumber}/images/extract/tiff | Extract document images in TIFF format to folder.
[**PutLaTeXInStorageToPdf**](PdfApi.md#putlatexinstoragetopdf) | **PUT** /pdf/{name}/create/latex | Convert LaTeX file (located on storage) to PDF format and upload resulting file to storage. 
[**PutLinkAnnotation**](PdfApi.md#putlinkannotation) | **PUT** /pdf/{name}/links/{linkId} | Replace document page link annotations
[**PutMergeDocuments**](PdfApi.md#putmergedocuments) | **PUT** /pdf/{name}/merge | Merge a list of documents.
[**PutMhtInStorageToPdf**](PdfApi.md#putmhtinstoragetopdf) | **PUT** /pdf/{name}/create/mht | Convert MHT file (located on storage) to PDF format and upload resulting file to storage. 
[**PutPageAddStamp**](PdfApi.md#putpageaddstamp) | **PUT** /pdf/{name}/pages/{pageNumber}/stamp | Add page stamp.
[**PutPageConvertToBmp**](PdfApi.md#putpageconverttobmp) | **PUT** /pdf/{name}/pages/{pageNumber}/convert/bmp | Convert document page to bmp image and upload resulting file to storage.
[**PutPageConvertToEmf**](PdfApi.md#putpageconverttoemf) | **PUT** /pdf/{name}/pages/{pageNumber}/convert/emf | Convert document page to emf image and upload resulting file to storage.
[**PutPageConvertToGif**](PdfApi.md#putpageconverttogif) | **PUT** /pdf/{name}/pages/{pageNumber}/convert/gif | Convert document page to gif image and upload resulting file to storage.
[**PutPageConvertToJpeg**](PdfApi.md#putpageconverttojpeg) | **PUT** /pdf/{name}/pages/{pageNumber}/convert/jpeg | Convert document page to Jpeg image and upload resulting file to storage.
[**PutPageConvertToPng**](PdfApi.md#putpageconverttopng) | **PUT** /pdf/{name}/pages/{pageNumber}/convert/png | Convert document page to png image and upload resulting file to storage.
[**PutPageConvertToTiff**](PdfApi.md#putpageconverttotiff) | **PUT** /pdf/{name}/pages/{pageNumber}/convert/tiff | Convert document page to Tiff image and upload resulting file to storage.
[**PutPclInStorageToPdf**](PdfApi.md#putpclinstoragetopdf) | **PUT** /pdf/{name}/create/pcl | Convert PCL file (located on storage) to PDF format and upload resulting file to storage. 
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
[**PutPdfInStorageToDoc**](PdfApi.md#putpdfinstoragetodoc) | **PUT** /pdf/{name}/convert/doc | Converts PDF document (located on storage) to DOC format and uploads resulting file to storage
[**PutPdfInStorageToEpub**](PdfApi.md#putpdfinstoragetoepub) | **PUT** /pdf/{name}/convert/epub | Converts PDF document (located on storage) to EPUB format and uploads resulting file to storage
[**PutPdfInStorageToHtml**](PdfApi.md#putpdfinstoragetohtml) | **PUT** /pdf/{name}/convert/html | Converts PDF document (located on storage) to Html format and uploads resulting file to storage
[**PutPdfInStorageToLaTeX**](PdfApi.md#putpdfinstoragetolatex) | **PUT** /pdf/{name}/convert/latex | Converts PDF document (located on storage) to LaTeX format and uploads resulting file to storage
[**PutPdfInStorageToMobiXml**](PdfApi.md#putpdfinstoragetomobixml) | **PUT** /pdf/{name}/convert/mobixml | Converts PDF document (located on storage) to MOBIXML format and uploads resulting file to storage
[**PutPdfInStorageToPdfA**](PdfApi.md#putpdfinstoragetopdfa) | **PUT** /pdf/{name}/convert/pdfa | Converts PDF document (located on storage) to PdfA format and uploads resulting file to storage
[**PutPdfInStorageToPptx**](PdfApi.md#putpdfinstoragetopptx) | **PUT** /pdf/{name}/convert/pptx | Converts PDF document (located on storage) to PPTX format and uploads resulting file to storage
[**PutPdfInStorageToSvg**](PdfApi.md#putpdfinstoragetosvg) | **PUT** /pdf/{name}/convert/svg | Converts PDF document (located on storage) to SVG format and uploads resulting file to storage
[**PutPdfInStorageToTiff**](PdfApi.md#putpdfinstoragetotiff) | **PUT** /pdf/{name}/convert/tiff | Converts PDF document (located on storage) to TIFF format and uploads resulting file to storage
[**PutPdfInStorageToXls**](PdfApi.md#putpdfinstoragetoxls) | **PUT** /pdf/{name}/convert/xls | Converts PDF document (located on storage) to XLS format and uploads resulting file to storage
[**PutPdfInStorageToXml**](PdfApi.md#putpdfinstoragetoxml) | **PUT** /pdf/{name}/convert/xml | Converts PDF document (located on storage) to XML format and uploads resulting file to storage
[**PutPdfInStorageToXps**](PdfApi.md#putpdfinstoragetoxps) | **PUT** /pdf/{name}/convert/xps | Converts PDF document (located on storage) to XPS format and uploads resulting file to storage
[**PutPrivileges**](PdfApi.md#putprivileges) | **PUT** /pdf/{name}/privileges | Update privilege document.
[**PutPsInStorageToPdf**](PdfApi.md#putpsinstoragetopdf) | **PUT** /pdf/{name}/create/ps | Convert PS file (located on storage) to PDF format and upload resulting file to storage. 
[**PutReplaceImage**](PdfApi.md#putreplaceimage) | **PUT** /pdf/{name}/images/{imageId} | Replace document image.
[**PutSearchableDocument**](PdfApi.md#putsearchabledocument) | **PUT** /pdf/{name}/ocr | Create searchable PDF document. Generate OCR layer for images in input PDF document.
[**PutSetProperty**](PdfApi.md#putsetproperty) | **PUT** /pdf/{name}/documentproperties/{propertyName} | Add/update document property.
[**PutSvgInStorageToPdf**](PdfApi.md#putsvginstoragetopdf) | **PUT** /pdf/{name}/create/svg | Convert SVG file (located on storage) to PDF format and upload resulting file to storage. 
[**PutTextAnnotation**](PdfApi.md#puttextannotation) | **PUT** /pdf/{name}/annotations/text/{annotationId} | Replace document text annotation
[**PutUpdateField**](PdfApi.md#putupdatefield) | **PUT** /pdf/{name}/fields/{fieldName} | Update field.
[**PutUpdateFields**](PdfApi.md#putupdatefields) | **PUT** /pdf/{name}/fields | Update fields.
[**PutWebInStorageToPdf**](PdfApi.md#putwebinstoragetopdf) | **PUT** /pdf/{name}/create/web | Convert web page to PDF format and upload resulting file to storage. 
[**PutXfaPdfInRequestToAcroForm**](PdfApi.md#putxfapdfinrequesttoacroform) | **PUT** /pdf/convert/xfatoacroform | Converts PDF document which contatins XFA form (in request content) to PDF with AcroForm and uploads resulting file to storage.
[**PutXfaPdfInStorageToAcroForm**](PdfApi.md#putxfapdfinstoragetoacroform) | **PUT** /pdf/{name}/convert/xfatoacroform | Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and uploads resulting file to storage
[**PutXmlInStorageToPdf**](PdfApi.md#putxmlinstoragetopdf) | **PUT** /pdf/{name}/create/xml | Convert XML file (located on storage) to PDF format and upload resulting file to storage. 
[**PutXpsInStorageToPdf**](PdfApi.md#putxpsinstoragetopdf) | **PUT** /pdf/{name}/create/xps | Convert XPS file (located on storage) to PDF format and upload resulting file to storage. 
[**PutXslFoInStorageToPdf**](PdfApi.md#putxslfoinstoragetopdf) | **PUT** /pdf/{name}/create/xslfo | Convert XslFo file (located on storage) to PDF format and upload resulting file to storage. 


<a name="deleteannotation"></a>
# **DeleteAnnotation**
> AsposeResponse DeleteAnnotation (string name, string annotationId, string storage = null, string folder = null)

Delete document annotation by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class DeleteAnnotationExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var annotationId = annotationId_example;  // string | The annotation ID.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Delete document annotation by ID
                AsposeResponse result = apiInstance.DeleteAnnotation(name, annotationId, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.DeleteAnnotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocumentannotations"></a>
# **DeleteDocumentAnnotations**
> AsposeResponse DeleteDocumentAnnotations (string name, string storage = null, string folder = null)

Delete all annotations from the document

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class DeleteDocumentAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Delete all annotations from the document
                AsposeResponse result = apiInstance.DeleteDocumentAnnotations(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.DeleteDocumentAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocumentlinkannotations"></a>
# **DeleteDocumentLinkAnnotations**
> AsposeResponse DeleteDocumentLinkAnnotations (string name, string storage = null, string folder = null)

Delete all link annotations from the document

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class DeleteDocumentLinkAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Delete all link annotations from the document
                AsposeResponse result = apiInstance.DeleteDocumentLinkAnnotations(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.DeleteDocumentLinkAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefield"></a>
# **DeleteField**
> AsposeResponse DeleteField (string name, string fieldName, string storage = null, string folder = null)

Delete document field by name.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class DeleteFieldExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var fieldName = fieldName_example;  // string | The field name/
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Delete document field by name.
                AsposeResponse result = apiInstance.DeleteField(name, fieldName, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.DeleteField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name/ | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteimage"></a>
# **DeleteImage**
> AsposeResponse DeleteImage (string name, string imageId, string storage = null, string folder = null)

Delete image from document page.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class DeleteImageExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageId = imageId_example;  // string | Image ID.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Delete image from document page.
                AsposeResponse result = apiInstance.DeleteImage(name, imageId, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.DeleteImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelinkannotation"></a>
# **DeleteLinkAnnotation**
> AsposeResponse DeleteLinkAnnotation (string name, string linkId, string storage = null, string folder = null)

Delete document page link annotation by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class DeleteLinkAnnotationExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var linkId = linkId_example;  // string | The link ID.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Delete document page link annotation by ID
                AsposeResponse result = apiInstance.DeleteLinkAnnotation(name, linkId, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.DeleteLinkAnnotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **linkId** | **string**| The link ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepage"></a>
# **DeletePage**
> AsposeResponse DeletePage (string name, int? pageNumber, string storage = null, string folder = null)

Delete document page by its number.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class DeletePageExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Delete document page by its number.
                AsposeResponse result = apiInstance.DeletePage(name, pageNumber, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.DeletePage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepageannotations"></a>
# **DeletePageAnnotations**
> AsposeResponse DeletePageAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Delete all annotations from the page

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class DeletePageAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Delete all annotations from the page
                AsposeResponse result = apiInstance.DeletePageAnnotations(name, pageNumber, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.DeletePageAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepagelinkannotations"></a>
# **DeletePageLinkAnnotations**
> AsposeResponse DeletePageLinkAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Delete all link annotations from the page

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class DeletePageLinkAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Delete all link annotations from the page
                AsposeResponse result = apiInstance.DeletePageLinkAnnotations(name, pageNumber, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.DeletePageLinkAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproperties"></a>
# **DeleteProperties**
> AsposeResponse DeleteProperties (string name, string storage = null, string folder = null)

Delete custom document properties.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class DeletePropertiesExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | 
            var storage = storage_example;  // string |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Delete custom document properties.
                AsposeResponse result = apiInstance.DeleteProperties(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.DeleteProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproperty"></a>
# **DeleteProperty**
> AsposeResponse DeleteProperty (string name, string propertyName, string storage = null, string folder = null)

Delete document property.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class DeletePropertyExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | 
            var propertyName = propertyName_example;  // string | 
            var storage = storage_example;  // string |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Delete document property.
                AsposeResponse result = apiInstance.DeleteProperty(name, propertyName, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.DeleteProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **propertyName** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> DocumentResponse GetDocument (string name, string storage = null, string folder = null)

Read common document info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetDocumentExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read common document info.
                DocumentResponse result = apiInstance.GetDocument(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentannotations"></a>
# **GetDocumentAnnotations**
> AnnotationsInfoResponse GetDocumentAnnotations (string name, string storage = null, string folder = null)

Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetDocumentAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
                AnnotationsInfoResponse result = apiInstance.GetDocumentAnnotations(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetDocumentAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AnnotationsInfoResponse**](AnnotationsInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentattachmentbyindex"></a>
# **GetDocumentAttachmentByIndex**
> AttachmentResponse GetDocumentAttachmentByIndex (string name, int? attachmentIndex, string storage = null, string folder = null)

Read document attachment info by its index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetDocumentAttachmentByIndexExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var attachmentIndex = 56;  // int? | The attachment index.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document attachment info by its index.
                AttachmentResponse result = apiInstance.GetDocumentAttachmentByIndex(name, attachmentIndex, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetDocumentAttachmentByIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **attachmentIndex** | **int?**| The attachment index. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AttachmentResponse**](AttachmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentattachments"></a>
# **GetDocumentAttachments**
> AttachmentsResponse GetDocumentAttachments (string name, string storage = null, string folder = null)

Read document attachments info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetDocumentAttachmentsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document attachments info.
                AttachmentsResponse result = apiInstance.GetDocumentAttachments(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetDocumentAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AttachmentsResponse**](AttachmentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentbookmarks"></a>
# **GetDocumentBookmarks**
> System.IO.Stream GetDocumentBookmarks (string name, string bookmarkPath = null, string storage = null, string folder = null)

Read document bookmark/bookmarks (including children).

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetDocumentBookmarksExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var bookmarkPath = bookmarkPath_example;  // string | The bookmark path. Leave it empty if you want to get all the bookmarks in the document. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document bookmark/bookmarks (including children).
                System.IO.Stream result = apiInstance.GetDocumentBookmarks(name, bookmarkPath, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetDocumentBookmarks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **bookmarkPath** | **string**| The bookmark path. Leave it empty if you want to get all the bookmarks in the document. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentfreetextannotations"></a>
# **GetDocumentFreeTextAnnotations**
> FreeTextAnnotationsResponse GetDocumentFreeTextAnnotations (string name, string storage = null, string folder = null)

Read document free text annotations.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetDocumentFreeTextAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document free text annotations.
                FreeTextAnnotationsResponse result = apiInstance.GetDocumentFreeTextAnnotations(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetDocumentFreeTextAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FreeTextAnnotationsResponse**](FreeTextAnnotationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentproperties"></a>
# **GetDocumentProperties**
> DocumentPropertiesResponse GetDocumentProperties (string name, string storage = null, string folder = null)

Read document properties.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetDocumentPropertiesExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | 
            var storage = storage_example;  // string |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Read document properties.
                DocumentPropertiesResponse result = apiInstance.GetDocumentProperties(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetDocumentProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**DocumentPropertiesResponse**](DocumentPropertiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentproperty"></a>
# **GetDocumentProperty**
> DocumentPropertyResponse GetDocumentProperty (string name, string propertyName, string storage = null, string folder = null)

Read document property by name.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetDocumentPropertyExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | 
            var propertyName = propertyName_example;  // string | 
            var storage = storage_example;  // string |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Read document property by name.
                DocumentPropertyResponse result = apiInstance.GetDocumentProperty(name, propertyName, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetDocumentProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **propertyName** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**DocumentPropertyResponse**](DocumentPropertyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumenttextannotations"></a>
# **GetDocumentTextAnnotations**
> TextAnnotationsResponse GetDocumentTextAnnotations (string name, string storage = null, string folder = null)

Read document text annotations.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetDocumentTextAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document text annotations.
                TextAnnotationsResponse result = apiInstance.GetDocumentTextAnnotations(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetDocumentTextAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TextAnnotationsResponse**](TextAnnotationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdownload"></a>
# **GetDownload**
> System.IO.Stream GetDownload (string path, string versionId = null, string storage = null)

Download a specific file 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetDownloadExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var path = path_example;  // string | Path of the file including the file name and extension e.g. /file.ext
            var versionId = versionId_example;  // string | File's version (optional) 
            var storage = storage_example;  // string | User's storage name (optional) 

            try
            {
                // Download a specific file 
                System.IO.Stream result = apiInstance.GetDownload(path, versionId, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetDownload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path of the file including the file name and extension e.g. /file.ext | 
 **versionId** | **string**| File&#39;s version | [optional] 
 **storage** | **string**| User&#39;s storage name | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdownloaddocumentattachmentbyindex"></a>
# **GetDownloadDocumentAttachmentByIndex**
> System.IO.Stream GetDownloadDocumentAttachmentByIndex (string name, int? attachmentIndex, string storage = null, string folder = null)

Download document attachment content by its index.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetDownloadDocumentAttachmentByIndexExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var attachmentIndex = 56;  // int? | The attachment index.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Download document attachment content by its index.
                System.IO.Stream result = apiInstance.GetDownloadDocumentAttachmentByIndex(name, attachmentIndex, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetDownloadDocumentAttachmentByIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **attachmentIndex** | **int?**| The attachment index. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getepubinstoragetopdf"></a>
# **GetEpubInStorageToPdf**
> System.IO.Stream GetEpubInStorageToPdf (string srcPath, string storage = null)

Convert EPUB file (located on storage) to PDF format and return resulting file in response. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetEpubInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.epub)
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert EPUB file (located on storage) to PDF format and return resulting file in response. 
                System.IO.Stream result = apiInstance.GetEpubInStorageToPdf(srcPath, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetEpubInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.epub) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfield"></a>
# **GetField**
> FieldResponse GetField (string name, string fieldName, string storage = null, string folder = null)

Get document field by name.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetFieldExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var fieldName = fieldName_example;  // string | The field name/
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Get document field by name.
                FieldResponse result = apiInstance.GetField(name, fieldName, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name/ | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FieldResponse**](FieldResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfields"></a>
# **GetFields**
> FieldsResponse GetFields (string name, string storage = null, string folder = null)

Get document fields.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetFieldsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Get document fields.
                FieldsResponse result = apiInstance.GetFields(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FieldsResponse**](FieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfreetextannotation"></a>
# **GetFreeTextAnnotation**
> FreeTextAnnotationResponse GetFreeTextAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page free text annotation by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetFreeTextAnnotationExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var annotationId = annotationId_example;  // string | The annotation ID.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document page free text annotation by ID.
                FreeTextAnnotationResponse result = apiInstance.GetFreeTextAnnotation(name, annotationId, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetFreeTextAnnotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FreeTextAnnotationResponse**](FreeTextAnnotationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethtmlinstoragetopdf"></a>
# **GetHtmlInStorageToPdf**
> System.IO.Stream GetHtmlInStorageToPdf (string srcPath, string htmlFileName, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string storage = null)

Convert HTML file (located on storage) to PDF format and return resulting file in response. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetHtmlInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.zip)
            var htmlFileName = htmlFileName_example;  // string | Name of HTML file in ZIP.
            var height = 1.2;  // double? | Page height (optional) 
            var width = 1.2;  // double? | Page width (optional) 
            var isLandscape = true;  // bool? | Is page landscaped (optional) 
            var marginLeft = 1.2;  // double? | Page margin left (optional) 
            var marginBottom = 1.2;  // double? | Page margin bottom (optional) 
            var marginRight = 1.2;  // double? | Page margin right (optional) 
            var marginTop = 1.2;  // double? | Page margin top (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert HTML file (located on storage) to PDF format and return resulting file in response. 
                System.IO.Stream result = apiInstance.GetHtmlInStorageToPdf(srcPath, htmlFileName, height, width, isLandscape, marginLeft, marginBottom, marginRight, marginTop, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetHtmlInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimage"></a>
# **GetImage**
> ImageResponse GetImage (string name, string imageId, string storage = null, string folder = null)

Read document image by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetImageExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageId = imageId_example;  // string | Image ID.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document image by ID.
                ImageResponse result = apiInstance.GetImage(name, imageId, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageId** | **string**| Image ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ImageResponse**](ImageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimageextractasgif"></a>
# **GetImageExtractAsGif**
> System.IO.Stream GetImageExtractAsGif (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null)

Extract document image in GIF format

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetImageExtractAsGifExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageId = imageId_example;  // string | Image ID.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document image in GIF format
                System.IO.Stream result = apiInstance.GetImageExtractAsGif(name, imageId, width, height, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetImageExtractAsGif: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimageextractasjpeg"></a>
# **GetImageExtractAsJpeg**
> System.IO.Stream GetImageExtractAsJpeg (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null)

Extract document image in JPEG format

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetImageExtractAsJpegExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageId = imageId_example;  // string | Image ID.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document image in JPEG format
                System.IO.Stream result = apiInstance.GetImageExtractAsJpeg(name, imageId, width, height, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetImageExtractAsJpeg: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimageextractaspng"></a>
# **GetImageExtractAsPng**
> System.IO.Stream GetImageExtractAsPng (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null)

Extract document image in PNG format

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetImageExtractAsPngExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageId = imageId_example;  // string | Image ID.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document image in PNG format
                System.IO.Stream result = apiInstance.GetImageExtractAsPng(name, imageId, width, height, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetImageExtractAsPng: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimageextractastiff"></a>
# **GetImageExtractAsTiff**
> System.IO.Stream GetImageExtractAsTiff (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null)

Extract document image in TIFF format

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetImageExtractAsTiffExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageId = imageId_example;  // string | Image ID.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document image in TIFF format
                System.IO.Stream result = apiInstance.GetImageExtractAsTiff(name, imageId, width, height, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetImageExtractAsTiff: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimages"></a>
# **GetImages**
> ImagesResponse GetImages (string name, int? pageNumber, string storage = null, string folder = null)

Read document images.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetImagesExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document images.
                ImagesResponse result = apiInstance.GetImages(name, pageNumber, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetImages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ImagesResponse**](ImagesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlatexinstoragetopdf"></a>
# **GetLaTeXInStorageToPdf**
> System.IO.Stream GetLaTeXInStorageToPdf (string srcPath, string storage = null)

Convert LaTeX file (located on storage) to PDF format and return resulting file in response. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetLaTeXInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.tex)
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert LaTeX file (located on storage) to PDF format and return resulting file in response. 
                System.IO.Stream result = apiInstance.GetLaTeXInStorageToPdf(srcPath, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetLaTeXInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.tex) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlinkannotation"></a>
# **GetLinkAnnotation**
> LinkAnnotationResponse GetLinkAnnotation (string name, string linkId, string storage = null, string folder = null)

Read document link annotation by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetLinkAnnotationExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var linkId = linkId_example;  // string | The link ID.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document link annotation by ID.
                LinkAnnotationResponse result = apiInstance.GetLinkAnnotation(name, linkId, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetLinkAnnotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **linkId** | **string**| The link ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**LinkAnnotationResponse**](LinkAnnotationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmhtinstoragetopdf"></a>
# **GetMhtInStorageToPdf**
> System.IO.Stream GetMhtInStorageToPdf (string srcPath, string storage = null)

Convert MHT file (located on storage) to PDF format and return resulting file in response. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetMhtInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.mht)
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert MHT file (located on storage) to PDF format and return resulting file in response. 
                System.IO.Stream result = apiInstance.GetMhtInStorageToPdf(srcPath, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetMhtInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.mht) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpage"></a>
# **GetPage**
> DocumentPageResponse GetPage (string name, int? pageNumber, string storage = null, string folder = null)

Read document page info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document page info.
                DocumentPageResponse result = apiInstance.GetPage(name, pageNumber, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**DocumentPageResponse**](DocumentPageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageannotations"></a>
# **GetPageAnnotations**
> AnnotationsInfoResponse GetPageAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
                AnnotationsInfoResponse result = apiInstance.GetPageAnnotations(name, pageNumber, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AnnotationsInfoResponse**](AnnotationsInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttobmp"></a>
# **GetPageConvertToBmp**
> System.IO.Stream GetPageConvertToBmp (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Bmp image and return resulting file in response.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageConvertToBmpExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to Bmp image and return resulting file in response.
                System.IO.Stream result = apiInstance.GetPageConvertToBmp(name, pageNumber, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageConvertToBmp: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttoemf"></a>
# **GetPageConvertToEmf**
> System.IO.Stream GetPageConvertToEmf (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Emf image and return resulting file in response.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageConvertToEmfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to Emf image and return resulting file in response.
                System.IO.Stream result = apiInstance.GetPageConvertToEmf(name, pageNumber, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageConvertToEmf: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttogif"></a>
# **GetPageConvertToGif**
> System.IO.Stream GetPageConvertToGif (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Gif image and return resulting file in response.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageConvertToGifExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to Gif image and return resulting file in response.
                System.IO.Stream result = apiInstance.GetPageConvertToGif(name, pageNumber, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageConvertToGif: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttojpeg"></a>
# **GetPageConvertToJpeg**
> System.IO.Stream GetPageConvertToJpeg (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Jpeg image and return resulting file in response.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageConvertToJpegExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to Jpeg image and return resulting file in response.
                System.IO.Stream result = apiInstance.GetPageConvertToJpeg(name, pageNumber, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageConvertToJpeg: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttopng"></a>
# **GetPageConvertToPng**
> System.IO.Stream GetPageConvertToPng (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Png image and return resulting file in response.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageConvertToPngExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to Png image and return resulting file in response.
                System.IO.Stream result = apiInstance.GetPageConvertToPng(name, pageNumber, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageConvertToPng: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageconverttotiff"></a>
# **GetPageConvertToTiff**
> System.IO.Stream GetPageConvertToTiff (string name, int? pageNumber, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Tiff image  and return resulting file in response.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageConvertToTiffExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to Tiff image  and return resulting file in response.
                System.IO.Stream result = apiInstance.GetPageConvertToTiff(name, pageNumber, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageConvertToTiff: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagefreetextannotations"></a>
# **GetPageFreeTextAnnotations**
> FreeTextAnnotationsResponse GetPageFreeTextAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page free text annotations.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageFreeTextAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document page free text annotations.
                FreeTextAnnotationsResponse result = apiInstance.GetPageFreeTextAnnotations(name, pageNumber, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageFreeTextAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FreeTextAnnotationsResponse**](FreeTextAnnotationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagelinkannotation"></a>
# **GetPageLinkAnnotation**
> LinkAnnotationResponse GetPageLinkAnnotation (string name, int? pageNumber, string linkId, string storage = null, string folder = null)

Read document page link annotation by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageLinkAnnotationExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var linkId = linkId_example;  // string | The link ID.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document page link annotation by ID.
                LinkAnnotationResponse result = apiInstance.GetPageLinkAnnotation(name, pageNumber, linkId, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageLinkAnnotation: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagelinkannotations"></a>
# **GetPageLinkAnnotations**
> LinkAnnotationsResponse GetPageLinkAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page link annotations.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageLinkAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document page link annotations.
                LinkAnnotationsResponse result = apiInstance.GetPageLinkAnnotations(name, pageNumber, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageLinkAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**LinkAnnotationsResponse**](LinkAnnotationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagetext"></a>
# **GetPageText**
> TextRectsResponse GetPageText (string name, int? pageNumber, double? LLX, double? LLY, double? URX, double? URY, List<string> format = null, string regex = null, bool? splitRects = null, string folder = null, string storage = null)

Read page text items.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageTextExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | Number of page (starting from 1).
            var LLX = 1.2;  // double? | 
            var LLY = 1.2;  // double? | 
            var URX = 1.2;  // double? | 
            var URY = 1.2;  // double? | 
            var format = new List<string>(); // List<string> | List of formats for search. (optional) 
            var regex = regex_example;  // string | Formats are specified as a regular expression. (optional) 
            var splitRects = true;  // bool? | Split result fragments (default is true). (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Read page text items.
                TextRectsResponse result = apiInstance.GetPageText(name, pageNumber, LLX, LLY, URX, URY, format, regex, splitRects, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| Number of page (starting from 1). | 
 **LLX** | **double?**|  | 
 **LLY** | **double?**|  | 
 **URX** | **double?**|  | 
 **URY** | **double?**|  | 
 **format** | [**List&lt;string&gt;**](string.md)| List of formats for search. | [optional] 
 **regex** | **string**| Formats are specified as a regular expression. | [optional] 
 **splitRects** | **bool?**| Split result fragments (default is true). | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**TextRectsResponse**](TextRectsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagetextannotations"></a>
# **GetPageTextAnnotations**
> TextAnnotationsResponse GetPageTextAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page text annotations.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPageTextAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document page text annotations.
                TextAnnotationsResponse result = apiInstance.GetPageTextAnnotations(name, pageNumber, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPageTextAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TextAnnotationsResponse**](TextAnnotationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpages"></a>
# **GetPages**
> DocumentPagesResponse GetPages (string name, string storage = null, string folder = null)

Read document pages info.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPagesExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document pages info.
                DocumentPagesResponse result = apiInstance.GetPages(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**DocumentPagesResponse**](DocumentPagesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpclinstoragetopdf"></a>
# **GetPclInStorageToPdf**
> System.IO.Stream GetPclInStorageToPdf (string srcPath, string storage = null)

Convert PCL file (located on storage) to PDF format and return resulting file in response. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPclInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.pcl)
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert PCL file (located on storage) to PDF format and return resulting file in response. 
                System.IO.Stream result = apiInstance.GetPclInStorageToPdf(srcPath, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPclInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.pcl) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetodoc"></a>
# **GetPdfInStorageToDoc**
> System.IO.Stream GetPdfInStorageToDoc (string name, bool? addReturnToLineEnd = null, string format = null, int? imageResolutionX = null, int? imageResolutionY = null, double? maxDistanceBetweenTextLines = null, string mode = null, bool? recognizeBullets = null, double? relativeHorizontalProximity = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to DOC format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToDocExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var addReturnToLineEnd = true;  // bool? | Add return to line end. (optional) 
            var format = format_example;  // string | Allows to specify .doc or .docx file format. (optional) 
            var imageResolutionX = 56;  // int? | Image resolution X. (optional) 
            var imageResolutionY = 56;  // int? | Image resolution Y. (optional) 
            var maxDistanceBetweenTextLines = 1.2;  // double? | Max distance between text lines. (optional) 
            var mode = mode_example;  // string | Allows to control how a PDF document is converted into a word processing document. (optional) 
            var recognizeBullets = true;  // bool? | Recognize bullets. (optional) 
            var relativeHorizontalProximity = 1.2;  // double? | Relative horizontal proximity. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to DOC format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToDoc(name, addReturnToLineEnd, format, imageResolutionX, imageResolutionY, maxDistanceBetweenTextLines, mode, recognizeBullets, relativeHorizontalProximity, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToDoc: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetoepub"></a>
# **GetPdfInStorageToEpub**
> System.IO.Stream GetPdfInStorageToEpub (string name, string contentRecognitionMode = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to EPUB format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToEpubExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var contentRecognitionMode = contentRecognitionMode_example;  // string | ?roperty tunes conversion for this or that desirable method of recognition of content. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to EPUB format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToEpub(name, contentRecognitionMode, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToEpub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **contentRecognitionMode** | **string**| ?roperty tunes conversion for this or that desirable method of recognition of content. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetohtml"></a>
# **GetPdfInStorageToHtml**
> System.IO.Stream GetPdfInStorageToHtml (string name, int? additionalMarginWidthInPoints = null, bool? compressSvgGraphicsIfAny = null, bool? convertMarkedContentToLayers = null, string defaultFontName = null, string documentType = null, bool? fixedLayout = null, int? imageResolution = null, int? minimalLineWidth = null, bool? preventGlyphsGrouping = null, bool? splitCssIntoPages = null, bool? splitIntoPages = null, bool? useZOrder = null, string antialiasingProcessing = null, string cssClassNamesPrefix = null, List<int?> explicitListOfSavedPages = null, string fontEncodingStrategy = null, string fontSavingMode = null, string htmlMarkupGenerationMode = null, string lettersPositioningMethod = null, bool? pagesFlowTypeDependsOnViewersScreenSize = null, string partsEmbeddingMode = null, string rasterImagesSavingMode = null, bool? removeEmptyAreasOnTopAndBottom = null, bool? saveShadowedTextsAsTransparentTexts = null, bool? saveTransparentTexts = null, string specialFolderForAllImages = null, string specialFolderForSvgImages = null, bool? trySaveTextUnderliningAndStrikeoutingInCss = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to Html format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToHtmlExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var additionalMarginWidthInPoints = 56;  // int? | Defines width of margin that will be forcibly left around that output HTML-areas. (optional) 
            var compressSvgGraphicsIfAny = true;  // bool? | The flag that indicates whether found SVG graphics(if any) will be compressed(zipped) into SVGZ format during saving. (optional) 
            var convertMarkedContentToLayers = true;  // bool? | If attribute ConvertMarkedContentToLayers set to true then an all elements inside a PDF marked content (layer) will be put into an HTML div with \"data-pdflayer\" attribute specifying a layer name. This layer name will be extracted from optional properties of PDF marked content. If this attribute is false (by default) then no any layers will be created from PDF marked content. (optional) 
            var defaultFontName = defaultFontName_example;  // string | Specifies the name of an installed font which is used to substitute any document font that is not embedded and not installed in the system. If null then default substitution font is used. (optional) 
            var documentType = documentType_example;  // string | Result document type. (optional) 
            var fixedLayout = true;  // bool? | The value indicating whether that HTML is created as fixed layout. (optional) 
            var imageResolution = 56;  // int? | Resolution for image rendering. (optional) 
            var minimalLineWidth = 56;  // int? | This attribute sets minimal width of graphic path line. If thickness of line is less than 1px Adobe Acrobat rounds it to this value. So this attribute can be used to emulate this behavior for HTML browsers. (optional) 
            var preventGlyphsGrouping = true;  // bool? | This attribute switch on the mode when text glyphs will not be grouped into words and strings This mode allows to keep maximum precision during positioning of glyphs on the page and it can be used for conversion documents with music notes or glyphs that should be placed separately each other. This parameter will be applied to document only when the value of FixedLayout attribute is true. (optional) 
            var splitCssIntoPages = true;  // bool? | When multipage-mode selected(i.e 'SplitIntoPages' is 'true'), then this attribute defines whether should be created separate CSS-file for each result HTML page. (optional) 
            var splitIntoPages = true;  // bool? | The flag that indicates whether each page of source document will be converted into it's own target HTML document, i.e whether result HTML will be splitted into several HTML-pages. (optional) 
            var useZOrder = true;  // bool? | If attribute UseZORder set to true, graphics and text are added to resultant HTML document accordingly Z-order in original PDF document. If this attribute is false all graphics is put as single layer which may cause some unnecessary effects for overlapped objects. (optional) 
            var antialiasingProcessing = antialiasingProcessing_example;  // string | The parameter defines required antialiasing measures during conversion of compound background images from PDF to HTML. (optional) 
            var cssClassNamesPrefix = cssClassNamesPrefix_example;  // string | When PDFtoHTML converter generates result CSSs, CSS class names (something like \".stl_01 {}\" ... \".stl_NN {}) are generated and used in result CSS. This property allows forcibly set class name prefix. (optional) 
            var explicitListOfSavedPages = new List<int?>(); // List<int?> | With this property You can explicitely define what pages of document should be converted. Pages in this list must have 1-based numbers. I.e. valid numbers of pages must be taken from range (1...[NumberOfPagesInConvertedDocument]) Order of appearing of pages in this list does not affect their order in result HTML page(s) - in result pages allways will go in order in which they are present in source PDF. (optional) 
            var fontEncodingStrategy = fontEncodingStrategy_example;  // string | Defines encoding special rule to tune PDF decoding for current document. (optional) 
            var fontSavingMode = fontSavingMode_example;  // string | Defines font saving mode that will be used during saving of PDF to desirable format. (optional) 
            var htmlMarkupGenerationMode = htmlMarkupGenerationMode_example;  // string | Sometimes specific reqirments to generation of HTML markup are present. This parameter defines HTML preparing modes that can be used during conversion of PDF to HTML to match such specific requirments. (optional) 
            var lettersPositioningMethod = lettersPositioningMethod_example;  // string | The mode of positioning of letters in words in result HTML. (optional) 
            var pagesFlowTypeDependsOnViewersScreenSize = true;  // bool? | If attribute 'SplitOnPages=false', than whole HTML representing all input PDF pages will be put into one big result HTML file. This flag defines whether result HTML will be generated in such way that flow of areas that represent PDF pages in result HTML will depend on screen resolution of viewer. (optional) 
            var partsEmbeddingMode = partsEmbeddingMode_example;  // string | It defines whether referenced files (HTML, Fonts,Images, CSSes) will be embedded into main HTML file or will be generated as apart binary entities. (optional) 
            var rasterImagesSavingMode = rasterImagesSavingMode_example;  // string | Converted PDF can contain raster images This parameter defines how they should be handled during conversion of PDF to HTML. (optional) 
            var removeEmptyAreasOnTopAndBottom = true;  // bool? | Defines whether in created HTML will be removed top and bottom empty area without any content (if any). (optional) 
            var saveShadowedTextsAsTransparentTexts = true;  // bool? | Pdf can contain texts that are shadowed by another elements (f.e. by images) but can be selected to clipboard in Acrobat Reader (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML to mimic behaviour of Acrobat Reader (othervise such texts are usually saved as hidden, not available for copying to clipboard). (optional) 
            var saveTransparentTexts = true;  // bool? | Pdf can contain transparent texts that can be selected to clipboard (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML. (optional) 
            var specialFolderForAllImages = specialFolderForAllImages_example;  // string | The path to directory to which must be saved any images if they are encountered during saving of document as HTML. If parameter is empty or null then image files(if any) wil be saved together with other files linked to HTML It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. (optional) 
            var specialFolderForSvgImages = specialFolderForSvgImages_example;  // string | The path to directory to which must be saved only SVG-images if they are encountered during saving of document as HTML. If parameter is empty or null then SVG files(if any) wil be saved together with other image-files (near to output file) or in special folder for images (if it specified in SpecialImagesFolderIfAny option). It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. (optional) 
            var trySaveTextUnderliningAndStrikeoutingInCss = true;  // bool? | PDF itself does not contain underlining markers for texts. It emulated with line situated under text. This option allows converter try guess that this or that line is a text's underlining and put this info into CSS instead of drawing of underlining graphically. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to Html format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToHtml(name, additionalMarginWidthInPoints, compressSvgGraphicsIfAny, convertMarkedContentToLayers, defaultFontName, documentType, fixedLayout, imageResolution, minimalLineWidth, preventGlyphsGrouping, splitCssIntoPages, splitIntoPages, useZOrder, antialiasingProcessing, cssClassNamesPrefix, explicitListOfSavedPages, fontEncodingStrategy, fontSavingMode, htmlMarkupGenerationMode, lettersPositioningMethod, pagesFlowTypeDependsOnViewersScreenSize, partsEmbeddingMode, rasterImagesSavingMode, removeEmptyAreasOnTopAndBottom, saveShadowedTextsAsTransparentTexts, saveTransparentTexts, specialFolderForAllImages, specialFolderForSvgImages, trySaveTextUnderliningAndStrikeoutingInCss, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToHtml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **additionalMarginWidthInPoints** | **int?**| Defines width of margin that will be forcibly left around that output HTML-areas. | [optional] 
 **compressSvgGraphicsIfAny** | **bool?**| The flag that indicates whether found SVG graphics(if any) will be compressed(zipped) into SVGZ format during saving. | [optional] 
 **convertMarkedContentToLayers** | **bool?**| If attribute ConvertMarkedContentToLayers set to true then an all elements inside a PDF marked content (layer) will be put into an HTML div with \&quot;data-pdflayer\&quot; attribute specifying a layer name. This layer name will be extracted from optional properties of PDF marked content. If this attribute is false (by default) then no any layers will be created from PDF marked content. | [optional] 
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
 **cssClassNamesPrefix** | **string**| When PDFtoHTML converter generates result CSSs, CSS class names (something like \&quot;.stl_01 {}\&quot; ... \&quot;.stl_NN {}) are generated and used in result CSS. This property allows forcibly set class name prefix. | [optional] 
 **explicitListOfSavedPages** | [**List&lt;int?&gt;**](int?.md)| With this property You can explicitely define what pages of document should be converted. Pages in this list must have 1-based numbers. I.e. valid numbers of pages must be taken from range (1...[NumberOfPagesInConvertedDocument]) Order of appearing of pages in this list does not affect their order in result HTML page(s) - in result pages allways will go in order in which they are present in source PDF. | [optional] 
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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetolatex"></a>
# **GetPdfInStorageToLaTeX**
> System.IO.Stream GetPdfInStorageToLaTeX (string name, int? pagesCount = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to LaTeX format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToLaTeXExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pagesCount = 56;  // int? | Pages count. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to LaTeX format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToLaTeX(name, pagesCount, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToLaTeX: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pagesCount** | **int?**| Pages count. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetomobixml"></a>
# **GetPdfInStorageToMobiXml**
> System.IO.Stream GetPdfInStorageToMobiXml (string name, string folder = null, string storage = null)

Converts PDF document (located on storage) to MOBIXML format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToMobiXmlExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to MOBIXML format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToMobiXml(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToMobiXml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetopdfa"></a>
# **GetPdfInStorageToPdfA**
> System.IO.Stream GetPdfInStorageToPdfA (string name, string type, string folder = null, string storage = null)

Converts PDF document (located on storage) to PdfA format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToPdfAExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var type = type_example;  // string | Type of PdfA format.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to PdfA format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToPdfA(name, type, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToPdfA: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **type** | **string**| Type of PdfA format. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetopptx"></a>
# **GetPdfInStorageToPptx**
> System.IO.Stream GetPdfInStorageToPptx (string name, bool? separateImages = null, bool? slidesAsImages = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to PPTX format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToPptxExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var separateImages = true;  // bool? | Separate images. (optional) 
            var slidesAsImages = true;  // bool? | Slides as images. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to PPTX format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToPptx(name, separateImages, slidesAsImages, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToPptx: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetosvg"></a>
# **GetPdfInStorageToSvg**
> System.IO.Stream GetPdfInStorageToSvg (string name, bool? compressOutputToZipArchive = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to SVG format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToSvgExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var compressOutputToZipArchive = true;  // bool? | Specifies whether output will be created as one zip-archive. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to SVG format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToSvg(name, compressOutputToZipArchive, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToSvg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **compressOutputToZipArchive** | **bool?**| Specifies whether output will be created as one zip-archive. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetotiff"></a>
# **GetPdfInStorageToTiff**
> System.IO.Stream GetPdfInStorageToTiff (string name, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to TIFF format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToTiffExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var brightness = 1.2;  // double? | Image brightness. (optional) 
            var compression = compression_example;  // string | Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. (optional) 
            var colorDepth = colorDepth_example;  // string | Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. (optional) 
            var leftMargin = 56;  // int? | Left image margin. (optional) 
            var rightMargin = 56;  // int? | Right image margin. (optional) 
            var topMargin = 56;  // int? | Top image margin. (optional) 
            var bottomMargin = 56;  // int? | Bottom image margin. (optional) 
            var orientation = orientation_example;  // string | Image orientation. Possible values are: None, Landscape, Portait. (optional) 
            var skipBlankPages = true;  // bool? | Skip blank pages flag. (optional) 
            var width = 56;  // int? | Image width. (optional) 
            var height = 56;  // int? | Image height. (optional) 
            var xResolution = 56;  // int? | Horizontal resolution. (optional) 
            var yResolution = 56;  // int? | Vertical resolution. (optional) 
            var pageIndex = 56;  // int? | Start page to export. (optional) 
            var pageCount = 56;  // int? | Number of pages to export. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to TIFF format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToTiff(name, brightness, compression, colorDepth, leftMargin, rightMargin, topMargin, bottomMargin, orientation, skipBlankPages, width, height, xResolution, yResolution, pageIndex, pageCount, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToTiff: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetoxls"></a>
# **GetPdfInStorageToXls**
> System.IO.Stream GetPdfInStorageToXls (string name, bool? insertBlankColumnAtFirst = null, bool? minimizeTheNumberOfWorksheets = null, double? scaleFactor = null, bool? uniformWorksheets = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to XLS format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToXlsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var insertBlankColumnAtFirst = true;  // bool? | Insert blank column at first (optional) 
            var minimizeTheNumberOfWorksheets = true;  // bool? | Minimize the number of worksheets (optional) 
            var scaleFactor = 1.2;  // double? | Scale factor (optional) 
            var uniformWorksheets = true;  // bool? | Uniform worksheets (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to XLS format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToXls(name, insertBlankColumnAtFirst, minimizeTheNumberOfWorksheets, scaleFactor, uniformWorksheets, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToXls: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetoxml"></a>
# **GetPdfInStorageToXml**
> System.IO.Stream GetPdfInStorageToXml (string name, string folder = null, string storage = null)

Converts PDF document (located on storage) to XML format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToXmlExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to XML format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToXml(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToXml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpdfinstoragetoxps"></a>
# **GetPdfInStorageToXps**
> System.IO.Stream GetPdfInStorageToXps (string name, string folder = null, string storage = null)

Converts PDF document (located on storage) to XPS format and returns resulting file in response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPdfInStorageToXpsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to XPS format and returns resulting file in response content
                System.IO.Stream result = apiInstance.GetPdfInStorageToXps(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPdfInStorageToXps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpsinstoragetopdf"></a>
# **GetPsInStorageToPdf**
> System.IO.Stream GetPsInStorageToPdf (string srcPath, string storage = null)

Convert PS file (located on storage) to PDF format and return resulting file in response. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetPsInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.ps)
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert PS file (located on storage) to PDF format and return resulting file in response. 
                System.IO.Stream result = apiInstance.GetPsInStorageToPdf(srcPath, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetPsInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.ps) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsvginstoragetopdf"></a>
# **GetSvgInStorageToPdf**
> System.IO.Stream GetSvgInStorageToPdf (string srcPath, bool? adjustPageSize = null, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string storage = null)

Convert SVG file (located on storage) to PDF format and return resulting file in response. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetSvgInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.svg)
            var adjustPageSize = true;  // bool? | Adjust page size (optional) 
            var height = 1.2;  // double? | Page height (optional) 
            var width = 1.2;  // double? | Page width (optional) 
            var isLandscape = true;  // bool? | Is page landscaped (optional) 
            var marginLeft = 1.2;  // double? | Page margin left (optional) 
            var marginBottom = 1.2;  // double? | Page margin bottom (optional) 
            var marginRight = 1.2;  // double? | Page margin right (optional) 
            var marginTop = 1.2;  // double? | Page margin top (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert SVG file (located on storage) to PDF format and return resulting file in response. 
                System.IO.Stream result = apiInstance.GetSvgInStorageToPdf(srcPath, adjustPageSize, height, width, isLandscape, marginLeft, marginBottom, marginRight, marginTop, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetSvgInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettext"></a>
# **GetText**
> TextRectsResponse GetText (string name, double? LLX, double? LLY, double? URX, double? URY, List<string> format = null, string regex = null, bool? splitRects = null, string folder = null, string storage = null)

Read document text.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetTextExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var LLX = 1.2;  // double? | 
            var LLY = 1.2;  // double? | 
            var URX = 1.2;  // double? | 
            var URY = 1.2;  // double? | 
            var format = new List<string>(); // List<string> | List of formats for search. (optional) 
            var regex = regex_example;  // string | Formats are specified as a regular expression. (optional) 
            var splitRects = true;  // bool? | Split result fragments (default is true). (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Read document text.
                TextRectsResponse result = apiInstance.GetText(name, LLX, LLY, URX, URY, format, regex, splitRects, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **LLX** | **double?**|  | 
 **LLY** | **double?**|  | 
 **URX** | **double?**|  | 
 **URY** | **double?**|  | 
 **format** | [**List&lt;string&gt;**](string.md)| List of formats for search. | [optional] 
 **regex** | **string**| Formats are specified as a regular expression. | [optional] 
 **splitRects** | **bool?**| Split result fragments (default is true). | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**TextRectsResponse**](TextRectsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettextannotation"></a>
# **GetTextAnnotation**
> TextAnnotationResponse GetTextAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page text annotation by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetTextAnnotationExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var annotationId = annotationId_example;  // string | The annotation ID.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Read document page text annotation by ID.
                TextAnnotationResponse result = apiInstance.GetTextAnnotation(name, annotationId, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetTextAnnotation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TextAnnotationResponse**](TextAnnotationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getverifysignature"></a>
# **GetVerifySignature**
> SignatureVerifyResponse GetVerifySignature (string name, string signName, string storage = null, string folder = null)

Verify signature document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetVerifySignatureExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var signName = signName_example;  // string | Sign name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Verify signature document.
                SignatureVerifyResponse result = apiInstance.GetVerifySignature(name, signName, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetVerifySignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **signName** | **string**| Sign name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SignatureVerifyResponse**](SignatureVerifyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebinstoragetopdf"></a>
# **GetWebInStorageToPdf**
> System.IO.Stream GetWebInStorageToPdf (string url, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string storage = null)

Convert web page to PDF format and return resulting file in response. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetWebInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var url = url_example;  // string | Source url
            var height = 1.2;  // double? | Page height (optional) 
            var width = 1.2;  // double? | Page width (optional) 
            var isLandscape = true;  // bool? | Is page landscaped (optional) 
            var marginLeft = 1.2;  // double? | Page margin left (optional) 
            var marginBottom = 1.2;  // double? | Page margin bottom (optional) 
            var marginRight = 1.2;  // double? | Page margin right (optional) 
            var marginTop = 1.2;  // double? | Page margin top (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert web page to PDF format and return resulting file in response. 
                System.IO.Stream result = apiInstance.GetWebInStorageToPdf(url, height, width, isLandscape, marginLeft, marginBottom, marginRight, marginTop, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetWebInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwordsperpage"></a>
# **GetWordsPerPage**
> WordCountResponse GetWordsPerPage (string name, string storage = null, string folder = null)

Get number of words per document page.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetWordsPerPageExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Get number of words per document page.
                WordCountResponse result = apiInstance.GetWordsPerPage(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetWordsPerPage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**WordCountResponse**](WordCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxfapdfinstoragetoacroform"></a>
# **GetXfaPdfInStorageToAcroForm**
> System.IO.Stream GetXfaPdfInStorageToAcroForm (string name, string folder = null, string storage = null)

Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and returns resulting file response content

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetXfaPdfInStorageToAcroFormExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and returns resulting file response content
                System.IO.Stream result = apiInstance.GetXfaPdfInStorageToAcroForm(name, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetXfaPdfInStorageToAcroForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxmlinstoragetopdf"></a>
# **GetXmlInStorageToPdf**
> System.IO.Stream GetXmlInStorageToPdf (string srcPath, string xslFilePath = null, string storage = null)

Convert XML file (located on storage) to PDF format and return resulting file in response. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetXmlInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.xml)
            var xslFilePath = xslFilePath_example;  // string | Full XSL source filename (ex. /folder1/folder2/template.xsl) (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert XML file (located on storage) to PDF format and return resulting file in response. 
                System.IO.Stream result = apiInstance.GetXmlInStorageToPdf(srcPath, xslFilePath, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetXmlInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.xml) | 
 **xslFilePath** | **string**| Full XSL source filename (ex. /folder1/folder2/template.xsl) | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxpsinstoragetopdf"></a>
# **GetXpsInStorageToPdf**
> System.IO.Stream GetXpsInStorageToPdf (string srcPath, string storage = null)

Convert XPS file (located on storage) to PDF format and return resulting file in response. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetXpsInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.xps)
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert XPS file (located on storage) to PDF format and return resulting file in response. 
                System.IO.Stream result = apiInstance.GetXpsInStorageToPdf(srcPath, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetXpsInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.xps) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxslfoinstoragetopdf"></a>
# **GetXslFoInStorageToPdf**
> System.IO.Stream GetXslFoInStorageToPdf (string srcPath, string storage = null)

Convert XslFo file (located on storage) to PDF format and return resulting file in response. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class GetXslFoInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.xslfo)
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert XslFo file (located on storage) to PDF format and return resulting file in response. 
                System.IO.Stream result = apiInstance.GetXslFoInStorageToPdf(srcPath, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.GetXslFoInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.xslfo) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postappenddocument"></a>
# **PostAppendDocument**
> DocumentResponse PostAppendDocument (string name, AppendDocument appendDocument = null, string appendFile = null, int? startPage = null, int? endPage = null, string storage = null, string folder = null)

Append document to existing one.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostAppendDocumentExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The original document name.
            var appendDocument = new AppendDocument(); // AppendDocument | with the append document data. (optional) 
            var appendFile = appendFile_example;  // string | Append file server path. (optional) 
            var startPage = 56;  // int? | Appending start page. (optional)  (default to 0)
            var endPage = 56;  // int? | Appending end page. (optional)  (default to 0)
            var storage = storage_example;  // string | The documents storage. (optional) 
            var folder = folder_example;  // string | The original document folder. (optional) 

            try
            {
                // Append document to existing one.
                DocumentResponse result = apiInstance.PostAppendDocument(name, appendDocument, appendFile, startPage, endPage, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostAppendDocument: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcreatefield"></a>
# **PostCreateField**
> AsposeResponse PostCreateField (string name, int? page, Field field = null, string storage = null, string folder = null)

Create field.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostCreateFieldExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var page = 56;  // int? | Document page number.
            var field = new Field(); // Field | with the field data. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Create field.
                AsposeResponse result = apiInstance.PostCreateField(name, page, field, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostCreateField: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocumenttextreplace"></a>
# **PostDocumentTextReplace**
> TextReplaceResponse PostDocumentTextReplace (string name, TextReplaceListRequest textReplace, string storage = null, string folder = null)

Document's replace text method.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostDocumentTextReplaceExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | 
            var textReplace = new TextReplaceListRequest(); // TextReplaceListRequest | 
            var storage = storage_example;  // string |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Document's replace text method.
                TextReplaceResponse result = apiInstance.PostDocumentTextReplace(name, textReplace, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostDocumentTextReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **textReplace** | [**TextReplaceListRequest**](TextReplaceListRequest.md)|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**TextReplaceResponse**](TextReplaceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinsertimage"></a>
# **PostInsertImage**
> AsposeResponse PostInsertImage (string name, int? pageNumber, double? llx, double? lly, double? urx, double? ury, string imageFilePath = null, string storage = null, string folder = null, System.IO.Stream image = null)

Insert image to document page.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostInsertImageExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var llx = 1.2;  // double? | Coordinate lower left X.
            var lly = 1.2;  // double? | Coordinate lower left Y.
            var urx = 1.2;  // double? | Coordinate upper right X.
            var ury = 1.2;  // double? | Coordinate upper right Y.
            var imageFilePath = imageFilePath_example;  // string | Path to image file if specified. Request content is used otherwise. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var image = new System.IO.Stream(); // System.IO.Stream | Image file. (optional) 

            try
            {
                // Insert image to document page.
                AsposeResponse result = apiInstance.PostInsertImage(name, pageNumber, llx, lly, urx, ury, imageFilePath, storage, folder, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostInsertImage: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmovepage"></a>
# **PostMovePage**
> AsposeResponse PostMovePage (string name, int? pageNumber, int? newIndex, string storage = null, string folder = null)

Move page to new position.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostMovePageExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var newIndex = 56;  // int? | The new page position/index.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Move page to new position.
                AsposeResponse result = apiInstance.PostMovePage(name, pageNumber, newIndex, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostMovePage: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postoptimizedocument"></a>
# **PostOptimizeDocument**
> AsposeResponse PostOptimizeDocument (string name, OptimizeOptions options = null, string storage = null, string folder = null)

Optimize document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostOptimizeDocumentExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var options = new OptimizeOptions(); // OptimizeOptions | The optimization options. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Optimize document.
                AsposeResponse result = apiInstance.PostOptimizeDocument(name, options, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostOptimizeDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **options** | [**OptimizeOptions**](OptimizeOptions.md)| The optimization options. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagefreetextannotations"></a>
# **PostPageFreeTextAnnotations**
> AsposeResponse PostPageFreeTextAnnotations (string name, int? pageNumber, List<FreeTextAnnotation> annotations, string storage = null, string folder = null)

Add document page free text annotations.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostPageFreeTextAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var annotations = new List<FreeTextAnnotation>(); // List<FreeTextAnnotation> | The array of annotation.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Add document page free text annotations.
                AsposeResponse result = apiInstance.PostPageFreeTextAnnotations(name, pageNumber, annotations, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostPageFreeTextAnnotations: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagelinkannotations"></a>
# **PostPageLinkAnnotations**
> AsposeResponse PostPageLinkAnnotations (string name, int? pageNumber, List<LinkAnnotation> links, string storage = null, string folder = null)

Add document page link annotations.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostPageLinkAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var links = new List<LinkAnnotation>(); // List<LinkAnnotation> | Array of link anotation.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Add document page link annotations.
                AsposeResponse result = apiInstance.PostPageLinkAnnotations(name, pageNumber, links, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostPageLinkAnnotations: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagetextannotations"></a>
# **PostPageTextAnnotations**
> AsposeResponse PostPageTextAnnotations (string name, int? pageNumber, List<TextAnnotation> annotations, string storage = null, string folder = null)

Add document page text annotations.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostPageTextAnnotationsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var annotations = new List<TextAnnotation>(); // List<TextAnnotation> | The array of annotation.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Add document page text annotations.
                AsposeResponse result = apiInstance.PostPageTextAnnotations(name, pageNumber, annotations, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostPageTextAnnotations: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagetextreplace"></a>
# **PostPageTextReplace**
> TextReplaceResponse PostPageTextReplace (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)

Page's replace text method.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostPageTextReplaceExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | 
            var pageNumber = 56;  // int? | 
            var textReplaceListRequest = new TextReplaceListRequest(); // TextReplaceListRequest | 
            var storage = storage_example;  // string |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Page's replace text method.
                TextReplaceResponse result = apiInstance.PostPageTextReplace(name, pageNumber, textReplaceListRequest, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostPageTextReplace: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsigndocument"></a>
# **PostSignDocument**
> AsposeResponse PostSignDocument (string name, Signature signature = null, string storage = null, string folder = null)

Sign document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostSignDocumentExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var signature = new Signature(); // Signature | Signature object containing signature data. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Sign document.
                AsposeResponse result = apiInstance.PostSignDocument(name, signature, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostSignDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **signature** | [**Signature**](Signature.md)| Signature object containing signature data. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsignpage"></a>
# **PostSignPage**
> AsposeResponse PostSignPage (string name, int? pageNumber, Signature signature = null, string storage = null, string folder = null)

Sign page.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostSignPageExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var signature = new Signature(); // Signature | Signature object containing signature data. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Sign page.
                AsposeResponse result = apiInstance.PostSignPage(name, pageNumber, signature, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostSignPage: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsplitdocument"></a>
# **PostSplitDocument**
> SplitResultResponse PostSplitDocument (string name, string format = null, int? from = null, int? to = null, string storage = null, string folder = null)

Split document to parts.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PostSplitDocumentExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | Document name.
            var format = format_example;  // string | Resulting documents format. (optional) 
            var from = 56;  // int? | Start page if defined. (optional) 
            var to = 56;  // int? | End page if defined. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Split document to parts.
                SplitResultResponse result = apiInstance.PostSplitDocument(name, format, from, to, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PostSplitDocument: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putaddnewpage"></a>
# **PutAddNewPage**
> DocumentPagesResponse PutAddNewPage (string name, string storage = null, string folder = null)

Add new page to end of the document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutAddNewPageExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Add new page to end of the document.
                DocumentPagesResponse result = apiInstance.PutAddNewPage(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutAddNewPage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**DocumentPagesResponse**](DocumentPagesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putaddtext"></a>
# **PutAddText**
> AsposeResponse PutAddText (string name, int? pageNumber, Paragraph paragraph = null, string folder = null, string storage = null)

Add text to PDF document page.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutAddTextExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | Number of page (starting from 1).
            var paragraph = new Paragraph(); // Paragraph | Paragraph data. (optional) 
            var folder = folder_example;  // string | Document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Add text to PDF document page.
                AsposeResponse result = apiInstance.PutAddText(name, pageNumber, paragraph, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutAddText: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcreate"></a>
# **PutCreate**
> AsposeResponse PutCreate (string path, System.IO.Stream file, string versionId = null, string storage = null)

Upload a specific file 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutCreateExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var path = path_example;  // string | Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext
            var file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var versionId = versionId_example;  // string | Source file's version (optional) 
            var storage = storage_example;  // string | User's storage name (optional) 

            try
            {
                // Upload a specific file 
                AsposeResponse result = apiInstance.PutCreate(path, file, versionId, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext | 
 **file** | **System.IO.Stream**| File to upload | 
 **versionId** | **string**| Source file&#39;s version | [optional] 
 **storage** | **string**| User&#39;s storage name | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcreatedocument"></a>
# **PutCreateDocument**
> DocumentResponse PutCreateDocument (string name, string storage = null, string folder = null)

Create empty document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutCreateDocumentExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The new document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The new document folder. (optional) 

            try
            {
                // Create empty document.
                DocumentResponse result = apiInstance.PutCreateDocument(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutCreateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The new document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The new document folder. | [optional] 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putepubinstoragetopdf"></a>
# **PutEpubInStorageToPdf**
> AsposeResponse PutEpubInStorageToPdf (string name, string srcPath, string storage = null, string dstFolder = null)

Convert EPUB file (located on storage) to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutEpubInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.epub)
            var storage = storage_example;  // string | The document storage. (optional) 
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 

            try
            {
                // Convert EPUB file (located on storage) to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutEpubInStorageToPdf(name, srcPath, storage, dstFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutEpubInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.epub) | 
 **storage** | **string**| The document storage. | [optional] 
 **dstFolder** | **string**| The destination document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfieldsflatten"></a>
# **PutFieldsFlatten**
> AsposeResponse PutFieldsFlatten (string name, string storage = null, string folder = null)

Flatten form fields in document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutFieldsFlattenExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Flatten form fields in document.
                AsposeResponse result = apiInstance.PutFieldsFlatten(name, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutFieldsFlatten: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfreetextannotation"></a>
# **PutFreeTextAnnotation**
> FreeTextAnnotationResponse PutFreeTextAnnotation (string name, string annotationId, FreeTextAnnotation annotation, string storage = null, string folder = null)

Replace document free text annotation

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutFreeTextAnnotationExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var annotationId = annotationId_example;  // string | The annotation ID.
            var annotation = new FreeTextAnnotation(); // FreeTextAnnotation | Annotation.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Replace document free text annotation
                FreeTextAnnotationResponse result = apiInstance.PutFreeTextAnnotation(name, annotationId, annotation, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutFreeTextAnnotation: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puthtmlinstoragetopdf"></a>
# **PutHtmlInStorageToPdf**
> AsposeResponse PutHtmlInStorageToPdf (string name, string srcPath, string htmlFileName, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string dstFolder = null, string storage = null)

Convert HTML file (located on storage) to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutHtmlInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.zip)
            var htmlFileName = htmlFileName_example;  // string | Name of HTML file in ZIP.
            var height = 1.2;  // double? | Page height (optional) 
            var width = 1.2;  // double? | Page width (optional) 
            var isLandscape = true;  // bool? | Is page landscaped (optional) 
            var marginLeft = 1.2;  // double? | Page margin left (optional) 
            var marginBottom = 1.2;  // double? | Page margin bottom (optional) 
            var marginRight = 1.2;  // double? | Page margin right (optional) 
            var marginTop = 1.2;  // double? | Page margin top (optional) 
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert HTML file (located on storage) to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutHtmlInStorageToPdf(name, srcPath, htmlFileName, height, width, isLandscape, marginLeft, marginBottom, marginRight, marginTop, dstFolder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutHtmlInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimageextractasgif"></a>
# **PutImageExtractAsGif**
> AsposeResponse PutImageExtractAsGif (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document image in GIF format to folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutImageExtractAsGifExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageId = imageId_example;  // string | Image ID.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var destFolder = destFolder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document image in GIF format to folder
                AsposeResponse result = apiInstance.PutImageExtractAsGif(name, imageId, width, height, storage, folder, destFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutImageExtractAsGif: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimageextractasjpeg"></a>
# **PutImageExtractAsJpeg**
> AsposeResponse PutImageExtractAsJpeg (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document image in JPEG format to folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutImageExtractAsJpegExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageId = imageId_example;  // string | Image ID.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var destFolder = destFolder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document image in JPEG format to folder
                AsposeResponse result = apiInstance.PutImageExtractAsJpeg(name, imageId, width, height, storage, folder, destFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutImageExtractAsJpeg: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimageextractaspng"></a>
# **PutImageExtractAsPng**
> AsposeResponse PutImageExtractAsPng (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document image in PNG format to folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutImageExtractAsPngExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageId = imageId_example;  // string | Image ID.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var destFolder = destFolder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document image in PNG format to folder
                AsposeResponse result = apiInstance.PutImageExtractAsPng(name, imageId, width, height, storage, folder, destFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutImageExtractAsPng: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimageextractastiff"></a>
# **PutImageExtractAsTiff**
> AsposeResponse PutImageExtractAsTiff (string name, string imageId, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document image in TIFF format to folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutImageExtractAsTiffExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageId = imageId_example;  // string | Image ID.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var destFolder = destFolder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document image in TIFF format to folder
                AsposeResponse result = apiInstance.PutImageExtractAsTiff(name, imageId, width, height, storage, folder, destFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutImageExtractAsTiff: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimageinstoragetopdf"></a>
# **PutImageInStorageToPdf**
> AsposeResponse PutImageInStorageToPdf (string name, ImageTemplatesRequest imageTemplates, string dstFolder = null, string storage = null)

Convert image file (located on storage) to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutImageInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageTemplates = new ImageTemplatesRequest(); // ImageTemplatesRequest | Image templates
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert image file (located on storage) to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutImageInStorageToPdf(name, imageTemplates, dstFolder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutImageInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageTemplates** | [**ImageTemplatesRequest**](ImageTemplatesRequest.md)| Image templates | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimagesextractasgif"></a>
# **PutImagesExtractAsGif**
> AsposeResponse PutImagesExtractAsGif (string name, int? pageNumber, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document images in GIF format to folder.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutImagesExtractAsGifExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var destFolder = destFolder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document images in GIF format to folder.
                AsposeResponse result = apiInstance.PutImagesExtractAsGif(name, pageNumber, width, height, storage, folder, destFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutImagesExtractAsGif: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimagesextractasjpeg"></a>
# **PutImagesExtractAsJpeg**
> AsposeResponse PutImagesExtractAsJpeg (string name, int? pageNumber, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document images in JPEG format to folder.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutImagesExtractAsJpegExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string |  (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var destFolder = destFolder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document images in JPEG format to folder.
                AsposeResponse result = apiInstance.PutImagesExtractAsJpeg(name, pageNumber, width, height, storage, folder, destFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutImagesExtractAsJpeg: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimagesextractaspng"></a>
# **PutImagesExtractAsPng**
> AsposeResponse PutImagesExtractAsPng (string name, int? pageNumber, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document images in PNG format to folder.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutImagesExtractAsPngExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var destFolder = destFolder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document images in PNG format to folder.
                AsposeResponse result = apiInstance.PutImagesExtractAsPng(name, pageNumber, width, height, storage, folder, destFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutImagesExtractAsPng: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimagesextractastiff"></a>
# **PutImagesExtractAsTiff**
> AsposeResponse PutImagesExtractAsTiff (string name, int? pageNumber, int? width = null, int? height = null, string storage = null, string folder = null, string destFolder = null)

Extract document images in TIFF format to folder.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutImagesExtractAsTiffExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var destFolder = destFolder_example;  // string | The document folder. (optional) 

            try
            {
                // Extract document images in TIFF format to folder.
                AsposeResponse result = apiInstance.PutImagesExtractAsTiff(name, pageNumber, width, height, storage, folder, destFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutImagesExtractAsTiff: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putlatexinstoragetopdf"></a>
# **PutLaTeXInStorageToPdf**
> AsposeResponse PutLaTeXInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert LaTeX file (located on storage) to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutLaTeXInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.tex)
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert LaTeX file (located on storage) to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutLaTeXInStorageToPdf(name, srcPath, dstFolder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutLaTeXInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.tex) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putlinkannotation"></a>
# **PutLinkAnnotation**
> LinkAnnotationResponse PutLinkAnnotation (string name, string linkId, LinkAnnotation link, string storage = null, string folder = null)

Replace document page link annotations

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutLinkAnnotationExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var linkId = linkId_example;  // string | The link ID.
            var link = new LinkAnnotation(); // LinkAnnotation | Link anotation.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Replace document page link annotations
                LinkAnnotationResponse result = apiInstance.PutLinkAnnotation(name, linkId, link, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutLinkAnnotation: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putmergedocuments"></a>
# **PutMergeDocuments**
> System.IO.Stream PutMergeDocuments (string name, MergeDocuments mergeDocuments = null, string storage = null, string folder = null)

Merge a list of documents.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutMergeDocumentsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | Resulting documen name.
            var mergeDocuments = new MergeDocuments(); // MergeDocuments | with a list of documents. (optional) 
            var storage = storage_example;  // string | Resulting document storage. (optional) 
            var folder = folder_example;  // string | Resulting document folder. (optional) 

            try
            {
                // Merge a list of documents.
                System.IO.Stream result = apiInstance.PutMergeDocuments(name, mergeDocuments, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutMergeDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Resulting documen name. | 
 **mergeDocuments** | [**MergeDocuments**](MergeDocuments.md)| with a list of documents. | [optional] 
 **storage** | **string**| Resulting document storage. | [optional] 
 **folder** | **string**| Resulting document folder. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putmhtinstoragetopdf"></a>
# **PutMhtInStorageToPdf**
> AsposeResponse PutMhtInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert MHT file (located on storage) to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutMhtInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.mht)
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert MHT file (located on storage) to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutMhtInStorageToPdf(name, srcPath, dstFolder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutMhtInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.mht) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageaddstamp"></a>
# **PutPageAddStamp**
> AsposeResponse PutPageAddStamp (string name, int? pageNumber, Stamp stamp, string storage = null, string folder = null)

Add page stamp.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPageAddStampExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var stamp = new Stamp(); // Stamp | with data.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Add page stamp.
                AsposeResponse result = apiInstance.PutPageAddStamp(name, pageNumber, stamp, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPageAddStamp: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttobmp"></a>
# **PutPageConvertToBmp**
> AsposeResponse PutPageConvertToBmp (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to bmp image and upload resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPageConvertToBmpExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var outPath = outPath_example;  // string | The out path of result image.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to bmp image and upload resulting file to storage.
                AsposeResponse result = apiInstance.PutPageConvertToBmp(name, pageNumber, outPath, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPageConvertToBmp: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttoemf"></a>
# **PutPageConvertToEmf**
> AsposeResponse PutPageConvertToEmf (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to emf image and upload resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPageConvertToEmfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var outPath = outPath_example;  // string | The out path of result image.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to emf image and upload resulting file to storage.
                AsposeResponse result = apiInstance.PutPageConvertToEmf(name, pageNumber, outPath, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPageConvertToEmf: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttogif"></a>
# **PutPageConvertToGif**
> AsposeResponse PutPageConvertToGif (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to gif image and upload resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPageConvertToGifExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var outPath = outPath_example;  // string | The out path of result image.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to gif image and upload resulting file to storage.
                AsposeResponse result = apiInstance.PutPageConvertToGif(name, pageNumber, outPath, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPageConvertToGif: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttojpeg"></a>
# **PutPageConvertToJpeg**
> AsposeResponse PutPageConvertToJpeg (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Jpeg image and upload resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPageConvertToJpegExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var outPath = outPath_example;  // string | The out path of result image.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to Jpeg image and upload resulting file to storage.
                AsposeResponse result = apiInstance.PutPageConvertToJpeg(name, pageNumber, outPath, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPageConvertToJpeg: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttopng"></a>
# **PutPageConvertToPng**
> AsposeResponse PutPageConvertToPng (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to png image and upload resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPageConvertToPngExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var outPath = outPath_example;  // string | The out path of result image.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to png image and upload resulting file to storage.
                AsposeResponse result = apiInstance.PutPageConvertToPng(name, pageNumber, outPath, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPageConvertToPng: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpageconverttotiff"></a>
# **PutPageConvertToTiff**
> AsposeResponse PutPageConvertToTiff (string name, int? pageNumber, string outPath, int? width = null, int? height = null, string folder = null, string storage = null)

Convert document page to Tiff image and upload resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPageConvertToTiffExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var pageNumber = 56;  // int? | The page number.
            var outPath = outPath_example;  // string | The out path of result image.
            var width = 56;  // int? | The converted image width. (optional) 
            var height = 56;  // int? | The converted image height. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert document page to Tiff image and upload resulting file to storage.
                AsposeResponse result = apiInstance.PutPageConvertToTiff(name, pageNumber, outPath, width, height, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPageConvertToTiff: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpclinstoragetopdf"></a>
# **PutPclInStorageToPdf**
> AsposeResponse PutPclInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert PCL file (located on storage) to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPclInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.pcl)
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert PCL file (located on storage) to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutPclInStorageToPdf(name, srcPath, dstFolder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPclInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.pcl) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttodoc"></a>
# **PutPdfInRequestToDoc**
> AsposeResponse PutPdfInRequestToDoc (string outPath, bool? addReturnToLineEnd = null, string format = null, int? imageResolutionX = null, int? imageResolutionY = null, double? maxDistanceBetweenTextLines = null, string mode = null, bool? recognizeBullets = null, double? relativeHorizontalProximity = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to DOC format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToDocExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.doc)
            var addReturnToLineEnd = true;  // bool? | Add return to line end. (optional) 
            var format = format_example;  // string | Allows to specify .doc or .docx file format. (optional) 
            var imageResolutionX = 56;  // int? | Image resolution X. (optional) 
            var imageResolutionY = 56;  // int? | Image resolution Y. (optional) 
            var maxDistanceBetweenTextLines = 1.2;  // double? | Max distance between text lines. (optional) 
            var mode = mode_example;  // string | Allows to control how a PDF document is converted into a word processing document. (optional) 
            var recognizeBullets = true;  // bool? | Recognize bullets. (optional) 
            var relativeHorizontalProximity = 1.2;  // double? | Relative horizontal proximity. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to DOC format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToDoc(outPath, addReturnToLineEnd, format, imageResolutionX, imageResolutionY, maxDistanceBetweenTextLines, mode, recognizeBullets, relativeHorizontalProximity, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToDoc: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttoepub"></a>
# **PutPdfInRequestToEpub**
> AsposeResponse PutPdfInRequestToEpub (string outPath, string contentRecognitionMode = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to EPUB format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToEpubExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.epub)
            var contentRecognitionMode = contentRecognitionMode_example;  // string | ?roperty tunes conversion for this or that desirable method of recognition of content. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to EPUB format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToEpub(outPath, contentRecognitionMode, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToEpub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.epub) | 
 **contentRecognitionMode** | **string**| ?roperty tunes conversion for this or that desirable method of recognition of content. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttohtml"></a>
# **PutPdfInRequestToHtml**
> AsposeResponse PutPdfInRequestToHtml (string outPath, int? additionalMarginWidthInPoints = null, bool? compressSvgGraphicsIfAny = null, bool? convertMarkedContentToLayers = null, string defaultFontName = null, string documentType = null, bool? fixedLayout = null, int? imageResolution = null, int? minimalLineWidth = null, bool? preventGlyphsGrouping = null, bool? splitCssIntoPages = null, bool? splitIntoPages = null, bool? useZOrder = null, string antialiasingProcessing = null, string cssClassNamesPrefix = null, List<int?> explicitListOfSavedPages = null, string fontEncodingStrategy = null, string fontSavingMode = null, string htmlMarkupGenerationMode = null, string lettersPositioningMethod = null, bool? pagesFlowTypeDependsOnViewersScreenSize = null, string partsEmbeddingMode = null, string rasterImagesSavingMode = null, bool? removeEmptyAreasOnTopAndBottom = null, bool? saveShadowedTextsAsTransparentTexts = null, bool? saveTransparentTexts = null, string specialFolderForAllImages = null, string specialFolderForSvgImages = null, bool? trySaveTextUnderliningAndStrikeoutingInCss = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to Html format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToHtmlExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.html)
            var additionalMarginWidthInPoints = 56;  // int? | Defines width of margin that will be forcibly left around that output HTML-areas. (optional) 
            var compressSvgGraphicsIfAny = true;  // bool? | The flag that indicates whether found SVG graphics(if any) will be compressed(zipped) into SVGZ format during saving. (optional) 
            var convertMarkedContentToLayers = true;  // bool? | If attribute ConvertMarkedContentToLayers set to true then an all elements inside a PDF marked content (layer) will be put into an HTML div with \"data-pdflayer\" attribute specifying a layer name. This layer name will be extracted from optional properties of PDF marked content. If this attribute is false (by default) then no any layers will be created from PDF marked content. (optional) 
            var defaultFontName = defaultFontName_example;  // string | Specifies the name of an installed font which is used to substitute any document font that is not embedded and not installed in the system. If null then default substitution font is used. (optional) 
            var documentType = documentType_example;  // string | Result document type. (optional) 
            var fixedLayout = true;  // bool? | The value indicating whether that HTML is created as fixed layout. (optional) 
            var imageResolution = 56;  // int? | Resolution for image rendering. (optional) 
            var minimalLineWidth = 56;  // int? | This attribute sets minimal width of graphic path line. If thickness of line is less than 1px Adobe Acrobat rounds it to this value. So this attribute can be used to emulate this behavior for HTML browsers. (optional) 
            var preventGlyphsGrouping = true;  // bool? | This attribute switch on the mode when text glyphs will not be grouped into words and strings This mode allows to keep maximum precision during positioning of glyphs on the page and it can be used for conversion documents with music notes or glyphs that should be placed separately each other. This parameter will be applied to document only when the value of FixedLayout attribute is true. (optional) 
            var splitCssIntoPages = true;  // bool? | When multipage-mode selected(i.e 'SplitIntoPages' is 'true'), then this attribute defines whether should be created separate CSS-file for each result HTML page. (optional) 
            var splitIntoPages = true;  // bool? | The flag that indicates whether each page of source document will be converted into it's own target HTML document, i.e whether result HTML will be splitted into several HTML-pages. (optional) 
            var useZOrder = true;  // bool? | If attribute UseZORder set to true, graphics and text are added to resultant HTML document accordingly Z-order in original PDF document. If this attribute is false all graphics is put as single layer which may cause some unnecessary effects for overlapped objects. (optional) 
            var antialiasingProcessing = antialiasingProcessing_example;  // string | The parameter defines required antialiasing measures during conversion of compound background images from PDF to HTML. (optional) 
            var cssClassNamesPrefix = cssClassNamesPrefix_example;  // string | When PDFtoHTML converter generates result CSSs, CSS class names (something like \".stl_01 {}\" ... \".stl_NN {}) are generated and used in result CSS. This property allows forcibly set class name prefix. (optional) 
            var explicitListOfSavedPages = new List<int?>(); // List<int?> | With this property You can explicitely define what pages of document should be converted. Pages in this list must have 1-based numbers. I.e. valid numbers of pages must be taken from range (1...[NumberOfPagesInConvertedDocument]) Order of appearing of pages in this list does not affect their order in result HTML page(s) - in result pages allways will go in order in which they are present in source PDF. (optional) 
            var fontEncodingStrategy = fontEncodingStrategy_example;  // string | Defines encoding special rule to tune PDF decoding for current document. (optional) 
            var fontSavingMode = fontSavingMode_example;  // string | Defines font saving mode that will be used during saving of PDF to desirable format. (optional) 
            var htmlMarkupGenerationMode = htmlMarkupGenerationMode_example;  // string | Sometimes specific reqirments to generation of HTML markup are present. This parameter defines HTML preparing modes that can be used during conversion of PDF to HTML to match such specific requirments. (optional) 
            var lettersPositioningMethod = lettersPositioningMethod_example;  // string | The mode of positioning of letters in words in result HTML. (optional) 
            var pagesFlowTypeDependsOnViewersScreenSize = true;  // bool? | If attribute 'SplitOnPages=false', than whole HTML representing all input PDF pages will be put into one big result HTML file. This flag defines whether result HTML will be generated in such way that flow of areas that represent PDF pages in result HTML will depend on screen resolution of viewer. (optional) 
            var partsEmbeddingMode = partsEmbeddingMode_example;  // string | It defines whether referenced files (HTML, Fonts,Images, CSSes) will be embedded into main HTML file or will be generated as apart binary entities. (optional) 
            var rasterImagesSavingMode = rasterImagesSavingMode_example;  // string | Converted PDF can contain raster images This parameter defines how they should be handled during conversion of PDF to HTML. (optional) 
            var removeEmptyAreasOnTopAndBottom = true;  // bool? | Defines whether in created HTML will be removed top and bottom empty area without any content (if any). (optional) 
            var saveShadowedTextsAsTransparentTexts = true;  // bool? | Pdf can contain texts that are shadowed by another elements (f.e. by images) but can be selected to clipboard in Acrobat Reader (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML to mimic behaviour of Acrobat Reader (othervise such texts are usually saved as hidden, not available for copying to clipboard). (optional) 
            var saveTransparentTexts = true;  // bool? | Pdf can contain transparent texts that can be selected to clipboard (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML. (optional) 
            var specialFolderForAllImages = specialFolderForAllImages_example;  // string | The path to directory to which must be saved any images if they are encountered during saving of document as HTML. If parameter is empty or null then image files(if any) wil be saved together with other files linked to HTML It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. (optional) 
            var specialFolderForSvgImages = specialFolderForSvgImages_example;  // string | The path to directory to which must be saved only SVG-images if they are encountered during saving of document as HTML. If parameter is empty or null then SVG files(if any) wil be saved together with other image-files (near to output file) or in special folder for images (if it specified in SpecialImagesFolderIfAny option). It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. (optional) 
            var trySaveTextUnderliningAndStrikeoutingInCss = true;  // bool? | PDF itself does not contain underlining markers for texts. It emulated with line situated under text. This option allows converter try guess that this or that line is a text's underlining and put this info into CSS instead of drawing of underlining graphically. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to Html format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToHtml(outPath, additionalMarginWidthInPoints, compressSvgGraphicsIfAny, convertMarkedContentToLayers, defaultFontName, documentType, fixedLayout, imageResolution, minimalLineWidth, preventGlyphsGrouping, splitCssIntoPages, splitIntoPages, useZOrder, antialiasingProcessing, cssClassNamesPrefix, explicitListOfSavedPages, fontEncodingStrategy, fontSavingMode, htmlMarkupGenerationMode, lettersPositioningMethod, pagesFlowTypeDependsOnViewersScreenSize, partsEmbeddingMode, rasterImagesSavingMode, removeEmptyAreasOnTopAndBottom, saveShadowedTextsAsTransparentTexts, saveTransparentTexts, specialFolderForAllImages, specialFolderForSvgImages, trySaveTextUnderliningAndStrikeoutingInCss, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToHtml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.html) | 
 **additionalMarginWidthInPoints** | **int?**| Defines width of margin that will be forcibly left around that output HTML-areas. | [optional] 
 **compressSvgGraphicsIfAny** | **bool?**| The flag that indicates whether found SVG graphics(if any) will be compressed(zipped) into SVGZ format during saving. | [optional] 
 **convertMarkedContentToLayers** | **bool?**| If attribute ConvertMarkedContentToLayers set to true then an all elements inside a PDF marked content (layer) will be put into an HTML div with \&quot;data-pdflayer\&quot; attribute specifying a layer name. This layer name will be extracted from optional properties of PDF marked content. If this attribute is false (by default) then no any layers will be created from PDF marked content. | [optional] 
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
 **cssClassNamesPrefix** | **string**| When PDFtoHTML converter generates result CSSs, CSS class names (something like \&quot;.stl_01 {}\&quot; ... \&quot;.stl_NN {}) are generated and used in result CSS. This property allows forcibly set class name prefix. | [optional] 
 **explicitListOfSavedPages** | [**List&lt;int?&gt;**](int?.md)| With this property You can explicitely define what pages of document should be converted. Pages in this list must have 1-based numbers. I.e. valid numbers of pages must be taken from range (1...[NumberOfPagesInConvertedDocument]) Order of appearing of pages in this list does not affect their order in result HTML page(s) - in result pages allways will go in order in which they are present in source PDF. | [optional] 
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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttolatex"></a>
# **PutPdfInRequestToLaTeX**
> AsposeResponse PutPdfInRequestToLaTeX (string outPath, int? pagesCount = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to LaTeX format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToLaTeXExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.tex)
            var pagesCount = 56;  // int? | Pages count. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to LaTeX format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToLaTeX(outPath, pagesCount, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToLaTeX: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.tex) | 
 **pagesCount** | **int?**| Pages count. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttomobixml"></a>
# **PutPdfInRequestToMobiXml**
> AsposeResponse PutPdfInRequestToMobiXml (string outPath, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to MOBIXML format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToMobiXmlExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.mobixml)
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to MOBIXML format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToMobiXml(outPath, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToMobiXml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.mobixml) | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttopdfa"></a>
# **PutPdfInRequestToPdfA**
> AsposeResponse PutPdfInRequestToPdfA (string outPath, string type, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to PdfA format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToPdfAExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.pdf)
            var type = type_example;  // string | Type of PdfA format.
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to PdfA format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToPdfA(outPath, type, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToPdfA: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.pdf) | 
 **type** | **string**| Type of PdfA format. | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttopptx"></a>
# **PutPdfInRequestToPptx**
> AsposeResponse PutPdfInRequestToPptx (string outPath, bool? separateImages = null, bool? slidesAsImages = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to PPTX format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToPptxExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.pptx)
            var separateImages = true;  // bool? | Separate images. (optional) 
            var slidesAsImages = true;  // bool? | Slides as images. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to PPTX format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToPptx(outPath, separateImages, slidesAsImages, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToPptx: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttosvg"></a>
# **PutPdfInRequestToSvg**
> AsposeResponse PutPdfInRequestToSvg (string outPath, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to SVG format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToSvgExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.svg)
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to SVG format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToSvg(outPath, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToSvg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.svg) | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttotiff"></a>
# **PutPdfInRequestToTiff**
> AsposeResponse PutPdfInRequestToTiff (string outPath, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to TIFF format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToTiffExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.tiff)
            var brightness = 1.2;  // double? | Image brightness. (optional) 
            var compression = compression_example;  // string | Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. (optional) 
            var colorDepth = colorDepth_example;  // string | Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. (optional) 
            var leftMargin = 56;  // int? | Left image margin. (optional) 
            var rightMargin = 56;  // int? | Right image margin. (optional) 
            var topMargin = 56;  // int? | Top image margin. (optional) 
            var bottomMargin = 56;  // int? | Bottom image margin. (optional) 
            var orientation = orientation_example;  // string | Image orientation. Possible values are: None, Landscape, Portait. (optional) 
            var skipBlankPages = true;  // bool? | Skip blank pages flag. (optional) 
            var width = 56;  // int? | Image width. (optional) 
            var height = 56;  // int? | Image height. (optional) 
            var xResolution = 56;  // int? | Horizontal resolution. (optional) 
            var yResolution = 56;  // int? | Vertical resolution. (optional) 
            var pageIndex = 56;  // int? | Start page to export. (optional) 
            var pageCount = 56;  // int? | Number of pages to export. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to TIFF format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToTiff(outPath, brightness, compression, colorDepth, leftMargin, rightMargin, topMargin, bottomMargin, orientation, skipBlankPages, width, height, xResolution, yResolution, pageIndex, pageCount, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToTiff: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttoxls"></a>
# **PutPdfInRequestToXls**
> AsposeResponse PutPdfInRequestToXls (string outPath, bool? insertBlankColumnAtFirst = null, bool? minimizeTheNumberOfWorksheets = null, double? scaleFactor = null, bool? uniformWorksheets = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to XLS format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToXlsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.xls)
            var insertBlankColumnAtFirst = true;  // bool? | Insert blank column at first (optional) 
            var minimizeTheNumberOfWorksheets = true;  // bool? | Minimize the number of worksheets (optional) 
            var scaleFactor = 1.2;  // double? | Scale factor (optional) 
            var uniformWorksheets = true;  // bool? | Uniform worksheets (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to XLS format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToXls(outPath, insertBlankColumnAtFirst, minimizeTheNumberOfWorksheets, scaleFactor, uniformWorksheets, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToXls: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttoxml"></a>
# **PutPdfInRequestToXml**
> AsposeResponse PutPdfInRequestToXml (string outPath, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to XML format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToXmlExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.xml)
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to XML format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToXml(outPath, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToXml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xml) | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinrequesttoxps"></a>
# **PutPdfInRequestToXps**
> AsposeResponse PutPdfInRequestToXps (string outPath, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to XPS format and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInRequestToXpsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.xps)
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document (in request content) to XPS format and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutPdfInRequestToXps(outPath, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInRequestToXps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xps) | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetodoc"></a>
# **PutPdfInStorageToDoc**
> AsposeResponse PutPdfInStorageToDoc (string name, string outPath, bool? addReturnToLineEnd = null, string format = null, int? imageResolutionX = null, int? imageResolutionY = null, double? maxDistanceBetweenTextLines = null, string mode = null, bool? recognizeBullets = null, double? relativeHorizontalProximity = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to DOC format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToDocExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.doc)
            var addReturnToLineEnd = true;  // bool? | Add return to line end. (optional) 
            var format = format_example;  // string | Allows to specify .doc or .docx file format. (optional) 
            var imageResolutionX = 56;  // int? | Image resolution X. (optional) 
            var imageResolutionY = 56;  // int? | Image resolution Y. (optional) 
            var maxDistanceBetweenTextLines = 1.2;  // double? | Max distance between text lines. (optional) 
            var mode = mode_example;  // string | Allows to control how a PDF document is converted into a word processing document. (optional) 
            var recognizeBullets = true;  // bool? | Recognize bullets. (optional) 
            var relativeHorizontalProximity = 1.2;  // double? | Relative horizontal proximity. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to DOC format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToDoc(name, outPath, addReturnToLineEnd, format, imageResolutionX, imageResolutionY, maxDistanceBetweenTextLines, mode, recognizeBullets, relativeHorizontalProximity, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToDoc: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetoepub"></a>
# **PutPdfInStorageToEpub**
> AsposeResponse PutPdfInStorageToEpub (string name, string outPath, string contentRecognitionMode = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to EPUB format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToEpubExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.epub)
            var contentRecognitionMode = contentRecognitionMode_example;  // string | ?roperty tunes conversion for this or that desirable method of recognition of content. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to EPUB format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToEpub(name, outPath, contentRecognitionMode, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToEpub: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetohtml"></a>
# **PutPdfInStorageToHtml**
> AsposeResponse PutPdfInStorageToHtml (string name, string outPath, int? additionalMarginWidthInPoints = null, bool? compressSvgGraphicsIfAny = null, bool? convertMarkedContentToLayers = null, string defaultFontName = null, string documentType = null, bool? fixedLayout = null, int? imageResolution = null, int? minimalLineWidth = null, bool? preventGlyphsGrouping = null, bool? splitCssIntoPages = null, bool? splitIntoPages = null, bool? useZOrder = null, string antialiasingProcessing = null, string cssClassNamesPrefix = null, List<int?> explicitListOfSavedPages = null, string fontEncodingStrategy = null, string fontSavingMode = null, string htmlMarkupGenerationMode = null, string lettersPositioningMethod = null, bool? pagesFlowTypeDependsOnViewersScreenSize = null, string partsEmbeddingMode = null, string rasterImagesSavingMode = null, bool? removeEmptyAreasOnTopAndBottom = null, bool? saveShadowedTextsAsTransparentTexts = null, bool? saveTransparentTexts = null, string specialFolderForAllImages = null, string specialFolderForSvgImages = null, bool? trySaveTextUnderliningAndStrikeoutingInCss = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to Html format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToHtmlExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.html)
            var additionalMarginWidthInPoints = 56;  // int? | Defines width of margin that will be forcibly left around that output HTML-areas. (optional) 
            var compressSvgGraphicsIfAny = true;  // bool? | The flag that indicates whether found SVG graphics(if any) will be compressed(zipped) into SVGZ format during saving. (optional) 
            var convertMarkedContentToLayers = true;  // bool? | If attribute ConvertMarkedContentToLayers set to true then an all elements inside a PDF marked content (layer) will be put into an HTML div with \"data-pdflayer\" attribute specifying a layer name. This layer name will be extracted from optional properties of PDF marked content. If this attribute is false (by default) then no any layers will be created from PDF marked content. (optional) 
            var defaultFontName = defaultFontName_example;  // string | Specifies the name of an installed font which is used to substitute any document font that is not embedded and not installed in the system. If null then default substitution font is used. (optional) 
            var documentType = documentType_example;  // string | Result document type. (optional) 
            var fixedLayout = true;  // bool? | The value indicating whether that HTML is created as fixed layout. (optional) 
            var imageResolution = 56;  // int? | Resolution for image rendering. (optional) 
            var minimalLineWidth = 56;  // int? | This attribute sets minimal width of graphic path line. If thickness of line is less than 1px Adobe Acrobat rounds it to this value. So this attribute can be used to emulate this behavior for HTML browsers. (optional) 
            var preventGlyphsGrouping = true;  // bool? | This attribute switch on the mode when text glyphs will not be grouped into words and strings This mode allows to keep maximum precision during positioning of glyphs on the page and it can be used for conversion documents with music notes or glyphs that should be placed separately each other. This parameter will be applied to document only when the value of FixedLayout attribute is true. (optional) 
            var splitCssIntoPages = true;  // bool? | When multipage-mode selected(i.e 'SplitIntoPages' is 'true'), then this attribute defines whether should be created separate CSS-file for each result HTML page. (optional) 
            var splitIntoPages = true;  // bool? | The flag that indicates whether each page of source document will be converted into it's own target HTML document, i.e whether result HTML will be splitted into several HTML-pages. (optional) 
            var useZOrder = true;  // bool? | If attribute UseZORder set to true, graphics and text are added to resultant HTML document accordingly Z-order in original PDF document. If this attribute is false all graphics is put as single layer which may cause some unnecessary effects for overlapped objects. (optional) 
            var antialiasingProcessing = antialiasingProcessing_example;  // string | The parameter defines required antialiasing measures during conversion of compound background images from PDF to HTML. (optional) 
            var cssClassNamesPrefix = cssClassNamesPrefix_example;  // string | When PDFtoHTML converter generates result CSSs, CSS class names (something like \".stl_01 {}\" ... \".stl_NN {}) are generated and used in result CSS. This property allows forcibly set class name prefix. (optional) 
            var explicitListOfSavedPages = new List<int?>(); // List<int?> | With this property You can explicitely define what pages of document should be converted. Pages in this list must have 1-based numbers. I.e. valid numbers of pages must be taken from range (1...[NumberOfPagesInConvertedDocument]) Order of appearing of pages in this list does not affect their order in result HTML page(s) - in result pages allways will go in order in which they are present in source PDF. (optional) 
            var fontEncodingStrategy = fontEncodingStrategy_example;  // string | Defines encoding special rule to tune PDF decoding for current document. (optional) 
            var fontSavingMode = fontSavingMode_example;  // string | Defines font saving mode that will be used during saving of PDF to desirable format. (optional) 
            var htmlMarkupGenerationMode = htmlMarkupGenerationMode_example;  // string | Sometimes specific reqirments to generation of HTML markup are present. This parameter defines HTML preparing modes that can be used during conversion of PDF to HTML to match such specific requirments. (optional) 
            var lettersPositioningMethod = lettersPositioningMethod_example;  // string | The mode of positioning of letters in words in result HTML. (optional) 
            var pagesFlowTypeDependsOnViewersScreenSize = true;  // bool? | If attribute 'SplitOnPages=false', than whole HTML representing all input PDF pages will be put into one big result HTML file. This flag defines whether result HTML will be generated in such way that flow of areas that represent PDF pages in result HTML will depend on screen resolution of viewer. (optional) 
            var partsEmbeddingMode = partsEmbeddingMode_example;  // string | It defines whether referenced files (HTML, Fonts,Images, CSSes) will be embedded into main HTML file or will be generated as apart binary entities. (optional) 
            var rasterImagesSavingMode = rasterImagesSavingMode_example;  // string | Converted PDF can contain raster images This parameter defines how they should be handled during conversion of PDF to HTML. (optional) 
            var removeEmptyAreasOnTopAndBottom = true;  // bool? | Defines whether in created HTML will be removed top and bottom empty area without any content (if any). (optional) 
            var saveShadowedTextsAsTransparentTexts = true;  // bool? | Pdf can contain texts that are shadowed by another elements (f.e. by images) but can be selected to clipboard in Acrobat Reader (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML to mimic behaviour of Acrobat Reader (othervise such texts are usually saved as hidden, not available for copying to clipboard). (optional) 
            var saveTransparentTexts = true;  // bool? | Pdf can contain transparent texts that can be selected to clipboard (usually it happen when document contains images and OCRed texts extracted from it). This settings tells to converter whether we need save such texts as transparent selectable texts in result HTML. (optional) 
            var specialFolderForAllImages = specialFolderForAllImages_example;  // string | The path to directory to which must be saved any images if they are encountered during saving of document as HTML. If parameter is empty or null then image files(if any) wil be saved together with other files linked to HTML It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. (optional) 
            var specialFolderForSvgImages = specialFolderForSvgImages_example;  // string | The path to directory to which must be saved only SVG-images if they are encountered during saving of document as HTML. If parameter is empty or null then SVG files(if any) wil be saved together with other image-files (near to output file) or in special folder for images (if it specified in SpecialImagesFolderIfAny option). It does not affect anything if CustomImageSavingStrategy property was successfully used to process relevant image file. (optional) 
            var trySaveTextUnderliningAndStrikeoutingInCss = true;  // bool? | PDF itself does not contain underlining markers for texts. It emulated with line situated under text. This option allows converter try guess that this or that line is a text's underlining and put this info into CSS instead of drawing of underlining graphically. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to Html format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToHtml(name, outPath, additionalMarginWidthInPoints, compressSvgGraphicsIfAny, convertMarkedContentToLayers, defaultFontName, documentType, fixedLayout, imageResolution, minimalLineWidth, preventGlyphsGrouping, splitCssIntoPages, splitIntoPages, useZOrder, antialiasingProcessing, cssClassNamesPrefix, explicitListOfSavedPages, fontEncodingStrategy, fontSavingMode, htmlMarkupGenerationMode, lettersPositioningMethod, pagesFlowTypeDependsOnViewersScreenSize, partsEmbeddingMode, rasterImagesSavingMode, removeEmptyAreasOnTopAndBottom, saveShadowedTextsAsTransparentTexts, saveTransparentTexts, specialFolderForAllImages, specialFolderForSvgImages, trySaveTextUnderliningAndStrikeoutingInCss, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToHtml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.html) | 
 **additionalMarginWidthInPoints** | **int?**| Defines width of margin that will be forcibly left around that output HTML-areas. | [optional] 
 **compressSvgGraphicsIfAny** | **bool?**| The flag that indicates whether found SVG graphics(if any) will be compressed(zipped) into SVGZ format during saving. | [optional] 
 **convertMarkedContentToLayers** | **bool?**| If attribute ConvertMarkedContentToLayers set to true then an all elements inside a PDF marked content (layer) will be put into an HTML div with \&quot;data-pdflayer\&quot; attribute specifying a layer name. This layer name will be extracted from optional properties of PDF marked content. If this attribute is false (by default) then no any layers will be created from PDF marked content. | [optional] 
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
 **cssClassNamesPrefix** | **string**| When PDFtoHTML converter generates result CSSs, CSS class names (something like \&quot;.stl_01 {}\&quot; ... \&quot;.stl_NN {}) are generated and used in result CSS. This property allows forcibly set class name prefix. | [optional] 
 **explicitListOfSavedPages** | [**List&lt;int?&gt;**](int?.md)| With this property You can explicitely define what pages of document should be converted. Pages in this list must have 1-based numbers. I.e. valid numbers of pages must be taken from range (1...[NumberOfPagesInConvertedDocument]) Order of appearing of pages in this list does not affect their order in result HTML page(s) - in result pages allways will go in order in which they are present in source PDF. | [optional] 
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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetolatex"></a>
# **PutPdfInStorageToLaTeX**
> AsposeResponse PutPdfInStorageToLaTeX (string name, string outPath, int? pagesCount = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to LaTeX format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToLaTeXExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.tex)
            var pagesCount = 56;  // int? | Pages count. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to LaTeX format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToLaTeX(name, outPath, pagesCount, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToLaTeX: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetomobixml"></a>
# **PutPdfInStorageToMobiXml**
> AsposeResponse PutPdfInStorageToMobiXml (string name, string outPath, string folder = null, string storage = null)

Converts PDF document (located on storage) to MOBIXML format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToMobiXmlExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.mobixml)
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to MOBIXML format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToMobiXml(name, outPath, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToMobiXml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.mobixml) | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetopdfa"></a>
# **PutPdfInStorageToPdfA**
> AsposeResponse PutPdfInStorageToPdfA (string name, string outPath, string type, string folder = null, string storage = null)

Converts PDF document (located on storage) to PdfA format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToPdfAExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.pdf)
            var type = type_example;  // string | Type of PdfA format.
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to PdfA format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToPdfA(name, outPath, type, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToPdfA: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetopptx"></a>
# **PutPdfInStorageToPptx**
> AsposeResponse PutPdfInStorageToPptx (string name, string outPath, bool? separateImages = null, bool? slidesAsImages = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to PPTX format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToPptxExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.pptx)
            var separateImages = true;  // bool? | Separate images. (optional) 
            var slidesAsImages = true;  // bool? | Slides as images. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to PPTX format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToPptx(name, outPath, separateImages, slidesAsImages, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToPptx: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetosvg"></a>
# **PutPdfInStorageToSvg**
> AsposeResponse PutPdfInStorageToSvg (string name, string outPath, string folder = null, string storage = null)

Converts PDF document (located on storage) to SVG format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToSvgExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.svg)
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to SVG format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToSvg(name, outPath, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToSvg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.svg) | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetotiff"></a>
# **PutPdfInStorageToTiff**
> AsposeResponse PutPdfInStorageToTiff (string name, string outPath, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to TIFF format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToTiffExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.tiff)
            var brightness = 1.2;  // double? | Image brightness. (optional) 
            var compression = compression_example;  // string | Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. (optional) 
            var colorDepth = colorDepth_example;  // string | Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. (optional) 
            var leftMargin = 56;  // int? | Left image margin. (optional) 
            var rightMargin = 56;  // int? | Right image margin. (optional) 
            var topMargin = 56;  // int? | Top image margin. (optional) 
            var bottomMargin = 56;  // int? | Bottom image margin. (optional) 
            var orientation = orientation_example;  // string | Image orientation. Possible values are: None, Landscape, Portait. (optional) 
            var skipBlankPages = true;  // bool? | Skip blank pages flag. (optional) 
            var width = 56;  // int? | Image width. (optional) 
            var height = 56;  // int? | Image height. (optional) 
            var xResolution = 56;  // int? | Horizontal resolution. (optional) 
            var yResolution = 56;  // int? | Vertical resolution. (optional) 
            var pageIndex = 56;  // int? | Start page to export. (optional) 
            var pageCount = 56;  // int? | Number of pages to export. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to TIFF format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToTiff(name, outPath, brightness, compression, colorDepth, leftMargin, rightMargin, topMargin, bottomMargin, orientation, skipBlankPages, width, height, xResolution, yResolution, pageIndex, pageCount, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToTiff: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetoxls"></a>
# **PutPdfInStorageToXls**
> AsposeResponse PutPdfInStorageToXls (string name, string outPath, bool? insertBlankColumnAtFirst = null, bool? minimizeTheNumberOfWorksheets = null, double? scaleFactor = null, bool? uniformWorksheets = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to XLS format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToXlsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.xls)
            var insertBlankColumnAtFirst = true;  // bool? | Insert blank column at first (optional) 
            var minimizeTheNumberOfWorksheets = true;  // bool? | Minimize the number of worksheets (optional) 
            var scaleFactor = 1.2;  // double? | Scale factor (optional) 
            var uniformWorksheets = true;  // bool? | Uniform worksheets (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to XLS format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToXls(name, outPath, insertBlankColumnAtFirst, minimizeTheNumberOfWorksheets, scaleFactor, uniformWorksheets, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToXls: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetoxml"></a>
# **PutPdfInStorageToXml**
> AsposeResponse PutPdfInStorageToXml (string name, string outPath, string folder = null, string storage = null)

Converts PDF document (located on storage) to XML format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToXmlExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.xml)
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to XML format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToXml(name, outPath, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToXml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xml) | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpdfinstoragetoxps"></a>
# **PutPdfInStorageToXps**
> AsposeResponse PutPdfInStorageToXps (string name, string outPath, string folder = null, string storage = null)

Converts PDF document (located on storage) to XPS format and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPdfInStorageToXpsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.xps)
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document (located on storage) to XPS format and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutPdfInStorageToXps(name, outPath, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPdfInStorageToXps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xps) | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putprivileges"></a>
# **PutPrivileges**
> AsposeResponse PutPrivileges (string name, DocumentPrivilege privileges = null, string storage = null, string folder = null)

Update privilege document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPrivilegesExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var privileges = new DocumentPrivilege(); // DocumentPrivilege | Document privileges.  (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Update privilege document.
                AsposeResponse result = apiInstance.PutPrivileges(name, privileges, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPrivileges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **privileges** | [**DocumentPrivilege**](DocumentPrivilege.md)| Document privileges.  | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpsinstoragetopdf"></a>
# **PutPsInStorageToPdf**
> AsposeResponse PutPsInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert PS file (located on storage) to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutPsInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.ps)
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert PS file (located on storage) to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutPsInStorageToPdf(name, srcPath, dstFolder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutPsInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.ps) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putreplaceimage"></a>
# **PutReplaceImage**
> ImageResponse PutReplaceImage (string name, string imageId, string imageFilePath = null, string storage = null, string folder = null, System.IO.Stream image = null)

Replace document image.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutReplaceImageExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var imageId = imageId_example;  // string | The image ID.
            var imageFilePath = imageFilePath_example;  // string | Path to image file if specified. Request content is used otherwise. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var image = new System.IO.Stream(); // System.IO.Stream | Image file. (optional) 

            try
            {
                // Replace document image.
                ImageResponse result = apiInstance.PutReplaceImage(name, imageId, imageFilePath, storage, folder, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutReplaceImage: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsearchabledocument"></a>
# **PutSearchableDocument**
> AsposeResponse PutSearchableDocument (string name, string storage = null, string folder = null, string lang = null)

Create searchable PDF document. Generate OCR layer for images in input PDF document.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutSearchableDocumentExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var lang = lang_example;  // string | language for OCR engine. Possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra or thier combination e.g. eng,rus  (optional) 

            try
            {
                // Create searchable PDF document. Generate OCR layer for images in input PDF document.
                AsposeResponse result = apiInstance.PutSearchableDocument(name, storage, folder, lang);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutSearchableDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **lang** | **string**| language for OCR engine. Possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra or thier combination e.g. eng,rus  | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsetproperty"></a>
# **PutSetProperty**
> DocumentPropertyResponse PutSetProperty (string name, string propertyName, string value, string storage = null, string folder = null)

Add/update document property.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutSetPropertyExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | 
            var propertyName = propertyName_example;  // string | 
            var value = value_example;  // string | 
            var storage = storage_example;  // string |  (optional) 
            var folder = folder_example;  // string |  (optional) 

            try
            {
                // Add/update document property.
                DocumentPropertyResponse result = apiInstance.PutSetProperty(name, propertyName, value, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutSetProperty: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsvginstoragetopdf"></a>
# **PutSvgInStorageToPdf**
> AsposeResponse PutSvgInStorageToPdf (string name, string srcPath, bool? adjustPageSize = null, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string dstFolder = null, string storage = null)

Convert SVG file (located on storage) to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutSvgInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.svg)
            var adjustPageSize = true;  // bool? | Adjust page size (optional) 
            var height = 1.2;  // double? | Page height (optional) 
            var width = 1.2;  // double? | Page width (optional) 
            var isLandscape = true;  // bool? | Is page landscaped (optional) 
            var marginLeft = 1.2;  // double? | Page margin left (optional) 
            var marginBottom = 1.2;  // double? | Page margin bottom (optional) 
            var marginRight = 1.2;  // double? | Page margin right (optional) 
            var marginTop = 1.2;  // double? | Page margin top (optional) 
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert SVG file (located on storage) to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutSvgInStorageToPdf(name, srcPath, adjustPageSize, height, width, isLandscape, marginLeft, marginBottom, marginRight, marginTop, dstFolder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutSvgInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puttextannotation"></a>
# **PutTextAnnotation**
> TextAnnotationResponse PutTextAnnotation (string name, string annotationId, TextAnnotation annotation, string storage = null, string folder = null)

Replace document text annotation

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutTextAnnotationExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var annotationId = annotationId_example;  // string | The annotation ID.
            var annotation = new TextAnnotation(); // TextAnnotation | Annotation.
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Replace document text annotation
                TextAnnotationResponse result = apiInstance.PutTextAnnotation(name, annotationId, annotation, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutTextAnnotation: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putupdatefield"></a>
# **PutUpdateField**
> FieldResponse PutUpdateField (string name, string fieldName, Field field = null, string storage = null, string folder = null)

Update field.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutUpdateFieldExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var fieldName = fieldName_example;  // string | The name of a field to be updated.
            var field = new Field(); // Field | with the field data. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Update field.
                FieldResponse result = apiInstance.PutUpdateField(name, fieldName, field, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutUpdateField: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putupdatefields"></a>
# **PutUpdateFields**
> FieldsResponse PutUpdateFields (string name, Fields fields = null, string storage = null, string folder = null)

Update fields.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutUpdateFieldsExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var fields = new Fields(); // Fields | with the fields data. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 

            try
            {
                // Update fields.
                FieldsResponse result = apiInstance.PutUpdateFields(name, fields, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutUpdateFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fields** | [**Fields**](Fields.md)| with the fields data. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FieldsResponse**](FieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putwebinstoragetopdf"></a>
# **PutWebInStorageToPdf**
> AsposeResponse PutWebInStorageToPdf (string name, string url, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string dstFolder = null, string storage = null)

Convert web page to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutWebInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var url = url_example;  // string | Source url
            var height = 1.2;  // double? | Page height (optional) 
            var width = 1.2;  // double? | Page width (optional) 
            var isLandscape = true;  // bool? | Is page landscaped (optional) 
            var marginLeft = 1.2;  // double? | Page margin left (optional) 
            var marginBottom = 1.2;  // double? | Page margin bottom (optional) 
            var marginRight = 1.2;  // double? | Page margin right (optional) 
            var marginTop = 1.2;  // double? | Page margin top (optional) 
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert web page to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutWebInStorageToPdf(name, url, height, width, isLandscape, marginLeft, marginBottom, marginRight, marginTop, dstFolder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutWebInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putxfapdfinrequesttoacroform"></a>
# **PutXfaPdfInRequestToAcroForm**
> AsposeResponse PutXfaPdfInRequestToAcroForm (string outPath, string storage = null, System.IO.Stream file = null)

Converts PDF document which contatins XFA form (in request content) to PDF with AcroForm and uploads resulting file to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutXfaPdfInRequestToAcroFormExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.pdf)
            var storage = storage_example;  // string | The document storage. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | A file to be converted. (optional) 

            try
            {
                // Converts PDF document which contatins XFA form (in request content) to PDF with AcroForm and uploads resulting file to storage.
                AsposeResponse result = apiInstance.PutXfaPdfInRequestToAcroForm(outPath, storage, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutXfaPdfInRequestToAcroForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.pdf) | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be converted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putxfapdfinstoragetoacroform"></a>
# **PutXfaPdfInStorageToAcroForm**
> AsposeResponse PutXfaPdfInStorageToAcroForm (string name, string outPath, string folder = null, string storage = null)

Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and uploads resulting file to storage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutXfaPdfInStorageToAcroFormExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var outPath = outPath_example;  // string | Full resulting filename (ex. /folder1/folder2/result.pdf)
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and uploads resulting file to storage
                AsposeResponse result = apiInstance.PutXfaPdfInStorageToAcroForm(name, outPath, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutXfaPdfInStorageToAcroForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.pdf) | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putxmlinstoragetopdf"></a>
# **PutXmlInStorageToPdf**
> AsposeResponse PutXmlInStorageToPdf (string name, string srcPath, string xslFilePath = null, string dstFolder = null, string storage = null)

Convert XML file (located on storage) to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutXmlInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.xml)
            var xslFilePath = xslFilePath_example;  // string | Full XSL source filename (ex. /folder1/folder2/template.xsl) (optional) 
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert XML file (located on storage) to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutXmlInStorageToPdf(name, srcPath, xslFilePath, dstFolder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutXmlInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

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

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putxpsinstoragetopdf"></a>
# **PutXpsInStorageToPdf**
> AsposeResponse PutXpsInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert XPS file (located on storage) to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutXpsInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.xps)
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert XPS file (located on storage) to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutXpsInStorageToPdf(name, srcPath, dstFolder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutXpsInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.xps) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putxslfoinstoragetopdf"></a>
# **PutXslFoInStorageToPdf**
> AsposeResponse PutXslFoInStorageToPdf (string name, string srcPath, string dstFolder = null, string storage = null)

Convert XslFo file (located on storage) to PDF format and upload resulting file to storage. 

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Example
{
    public class PutXslFoInStorageToPdfExample
    {
        public void main()
        {
            var apiInstance = new PdfApi();
            var name = name_example;  // string | The document name.
            var srcPath = srcPath_example;  // string | Full source filename (ex. /folder1/folder2/template.xpsfo)
            var dstFolder = dstFolder_example;  // string | The destination document folder. (optional) 
            var storage = storage_example;  // string | The document storage. (optional) 

            try
            {
                // Convert XslFo file (located on storage) to PDF format and upload resulting file to storage. 
                AsposeResponse result = apiInstance.PutXslFoInStorageToPdf(name, srcPath, dstFolder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PdfApi.PutXslFoInStorageToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.xpsfo) | 
 **dstFolder** | **string**| The destination document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

