# Aspose.Pdf.Cloud.Sdk.Api.PdfApi

All URIs are relative to *https://api.aspose.cloud/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CopyFile**](PdfApi.md#copyfile) | **PUT** /pdf/storage/file/copy/\{srcPath} | Copy file
[**CopyFolder**](PdfApi.md#copyfolder) | **PUT** /pdf/storage/folder/copy/\{srcPath} | Copy folder
[**CreateFolder**](PdfApi.md#createfolder) | **PUT** /pdf/storage/folder/\{path} | Create the folder
[**DeleteAnnotation**](PdfApi.md#deleteannotation) | **DELETE** /pdf/\{name}/annotations/\{annotationId} | Delete document annotation by ID
[**DeleteBookmark**](PdfApi.md#deletebookmark) | **DELETE** /pdf/\{name}/bookmarks/bookmark/\{bookmarkPath} | Delete document bookmark by ID.
[**DeleteDocumentAnnotations**](PdfApi.md#deletedocumentannotations) | **DELETE** /pdf/\{name}/annotations | Delete all annotations from the document
[**DeleteDocumentBookmarks**](PdfApi.md#deletedocumentbookmarks) | **DELETE** /pdf/\{name}/bookmarks/tree | Delete all document bookmarks.
[**DeleteDocumentLinkAnnotations**](PdfApi.md#deletedocumentlinkannotations) | **DELETE** /pdf/\{name}/links | Delete all link annotations from the document
[**DeleteDocumentStamps**](PdfApi.md#deletedocumentstamps) | **DELETE** /pdf/\{name}/stamps | Delete all stamps from the document
[**DeleteDocumentTables**](PdfApi.md#deletedocumenttables) | **DELETE** /pdf/\{name}/tables | Delete all tables from the document
[**DeleteField**](PdfApi.md#deletefield) | **DELETE** /pdf/\{name}/fields/\{fieldName} | Delete document field by name.
[**DeleteFile**](PdfApi.md#deletefile) | **DELETE** /pdf/storage/file/\{path} | Delete file
[**DeleteFolder**](PdfApi.md#deletefolder) | **DELETE** /pdf/storage/folder/\{path} | Delete folder
[**DeleteImage**](PdfApi.md#deleteimage) | **DELETE** /pdf/\{name}/images/\{imageId} | Delete image from document page.
[**DeleteLinkAnnotation**](PdfApi.md#deletelinkannotation) | **DELETE** /pdf/\{name}/links/\{linkId} | Delete document page link annotation by ID
[**DeletePage**](PdfApi.md#deletepage) | **DELETE** /pdf/\{name}/pages/\{pageNumber} | Delete document page by its number.
[**DeletePageAnnotations**](PdfApi.md#deletepageannotations) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/annotations | Delete all annotations from the page
[**DeletePageLinkAnnotations**](PdfApi.md#deletepagelinkannotations) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/links | Delete all link annotations from the page
[**DeletePageStamps**](PdfApi.md#deletepagestamps) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/stamps | Delete all stamps from the page
[**DeletePageTables**](PdfApi.md#deletepagetables) | **DELETE** /pdf/\{name}/pages/\{pageNumber}/tables | Delete all tables from the page
[**DeleteProperties**](PdfApi.md#deleteproperties) | **DELETE** /pdf/\{name}/documentproperties | Delete custom document properties.
[**DeleteProperty**](PdfApi.md#deleteproperty) | **DELETE** /pdf/\{name}/documentproperties/\{propertyName} | Delete document property.
[**DeleteStamp**](PdfApi.md#deletestamp) | **DELETE** /pdf/\{name}/stamps/\{stampId} | Delete document stamp by ID
[**DeleteTable**](PdfApi.md#deletetable) | **DELETE** /pdf/\{name}/tables/\{tableId} | Delete document table by ID
[**DownloadFile**](PdfApi.md#downloadfile) | **GET** /pdf/storage/file/\{path} | Download file
[**GetBookmark**](PdfApi.md#getbookmark) | **GET** /pdf/\{name}/bookmarks/bookmark/\{bookmarkPath} | Read document bookmark.
[**GetBookmarks**](PdfApi.md#getbookmarks) | **GET** /pdf/\{name}/bookmarks/list/\{bookmarkPath} | Read document bookmarks node list.
[**GetCaretAnnotation**](PdfApi.md#getcaretannotation) | **GET** /pdf/\{name}/annotations/caret/\{annotationId} | Read document page caret annotation by ID.
[**GetCheckBoxField**](PdfApi.md#getcheckboxfield) | **GET** /pdf/\{name}/fields/checkbox/\{fieldName} | Read document checkbox field by name.
[**GetCircleAnnotation**](PdfApi.md#getcircleannotation) | **GET** /pdf/\{name}/annotations/circle/\{annotationId} | Read document page circle annotation by ID.
[**GetComboBoxField**](PdfApi.md#getcomboboxfield) | **GET** /pdf/\{name}/fields/combobox/\{fieldName} | Read document combobox field by name.
[**GetDiscUsage**](PdfApi.md#getdiscusage) | **GET** /pdf/storage/disc | Get disc usage
[**GetDocument**](PdfApi.md#getdocument) | **GET** /pdf/\{name} | Read common document info.
[**GetDocumentAnnotations**](PdfApi.md#getdocumentannotations) | **GET** /pdf/\{name}/annotations | Read documant page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
[**GetDocumentAttachmentByIndex**](PdfApi.md#getdocumentattachmentbyindex) | **GET** /pdf/\{name}/attachments/\{attachmentIndex} | Read document attachment info by its index.
[**GetDocumentAttachments**](PdfApi.md#getdocumentattachments) | **GET** /pdf/\{name}/attachments | Read document attachments info.
[**GetDocumentBookmarks**](PdfApi.md#getdocumentbookmarks) | **GET** /pdf/\{name}/bookmarks/tree | Read document bookmarks tree.
[**GetDocumentCaretAnnotations**](PdfApi.md#getdocumentcaretannotations) | **GET** /pdf/\{name}/annotations/caret | Read document caret annotations.
[**GetDocumentCheckBoxFields**](PdfApi.md#getdocumentcheckboxfields) | **GET** /pdf/\{name}/fields/checkbox | Read document checkbox fields.
[**GetDocumentCircleAnnotations**](PdfApi.md#getdocumentcircleannotations) | **GET** /pdf/\{name}/annotations/circle | Read document circle annotations.
[**GetDocumentComboBoxFields**](PdfApi.md#getdocumentcomboboxfields) | **GET** /pdf/\{name}/fields/combobox | Read document combobox fields.
[**GetDocumentDisplayProperties**](PdfApi.md#getdocumentdisplayproperties) | **GET** /pdf/\{name}/displayproperties | Read document display properties.
[**GetDocumentFileAttachmentAnnotations**](PdfApi.md#getdocumentfileattachmentannotations) | **GET** /pdf/\{name}/annotations/fileattachment | Read document FileAttachment annotations.
[**GetDocumentFreeTextAnnotations**](PdfApi.md#getdocumentfreetextannotations) | **GET** /pdf/\{name}/annotations/freetext | Read document free text annotations.
[**GetDocumentHighlightAnnotations**](PdfApi.md#getdocumenthighlightannotations) | **GET** /pdf/\{name}/annotations/highlight | Read document highlight annotations.
[**GetDocumentInkAnnotations**](PdfApi.md#getdocumentinkannotations) | **GET** /pdf/\{name}/annotations/ink | Read document ink annotations.
[**GetDocumentLineAnnotations**](PdfApi.md#getdocumentlineannotations) | **GET** /pdf/\{name}/annotations/line | Read document line annotations.
[**GetDocumentListBoxFields**](PdfApi.md#getdocumentlistboxfields) | **GET** /pdf/\{name}/fields/listbox | Read document listbox fields.
[**GetDocumentMovieAnnotations**](PdfApi.md#getdocumentmovieannotations) | **GET** /pdf/\{name}/annotations/movie | Read document movie annotations.
[**GetDocumentPolyLineAnnotations**](PdfApi.md#getdocumentpolylineannotations) | **GET** /pdf/\{name}/annotations/polyline | Read document polyline annotations.
[**GetDocumentPolygonAnnotations**](PdfApi.md#getdocumentpolygonannotations) | **GET** /pdf/\{name}/annotations/polygon | Read document polygon annotations.
[**GetDocumentPopupAnnotations**](PdfApi.md#getdocumentpopupannotations) | **GET** /pdf/\{name}/annotations/popup | Read document popup annotations.
[**GetDocumentPopupAnnotationsByParent**](PdfApi.md#getdocumentpopupannotationsbyparent) | **GET** /pdf/\{name}/annotations/\{annotationId}/popup | Read document popup annotations by parent id.
[**GetDocumentProperties**](PdfApi.md#getdocumentproperties) | **GET** /pdf/\{name}/documentproperties | Read document properties.
[**GetDocumentProperty**](PdfApi.md#getdocumentproperty) | **GET** /pdf/\{name}/documentproperties/\{propertyName} | Read document property by name.
[**GetDocumentRadioButtonFields**](PdfApi.md#getdocumentradiobuttonfields) | **GET** /pdf/\{name}/fields/radiobutton | Read document radiobutton fields.
[**GetDocumentRedactionAnnotations**](PdfApi.md#getdocumentredactionannotations) | **GET** /pdf/\{name}/annotations/redaction | Read document redaction annotations.
[**GetDocumentScreenAnnotations**](PdfApi.md#getdocumentscreenannotations) | **GET** /pdf/\{name}/annotations/screen | Read document screen annotations.
[**GetDocumentSignatureFields**](PdfApi.md#getdocumentsignaturefields) | **GET** /pdf/\{name}/fields/signature | Read document signature fields.
[**GetDocumentSoundAnnotations**](PdfApi.md#getdocumentsoundannotations) | **GET** /pdf/\{name}/annotations/sound | Read document sound annotations.
[**GetDocumentSquareAnnotations**](PdfApi.md#getdocumentsquareannotations) | **GET** /pdf/\{name}/annotations/square | Read document square annotations.
[**GetDocumentSquigglyAnnotations**](PdfApi.md#getdocumentsquigglyannotations) | **GET** /pdf/\{name}/annotations/squiggly | Read document squiggly annotations.
[**GetDocumentStampAnnotations**](PdfApi.md#getdocumentstampannotations) | **GET** /pdf/\{name}/annotations/stamp | Read document stamp annotations.
[**GetDocumentStamps**](PdfApi.md#getdocumentstamps) | **GET** /pdf/\{name}/stamps | Read document stamps.
[**GetDocumentStrikeOutAnnotations**](PdfApi.md#getdocumentstrikeoutannotations) | **GET** /pdf/\{name}/annotations/strikeout | Read document StrikeOut annotations.
[**GetDocumentTables**](PdfApi.md#getdocumenttables) | **GET** /pdf/\{name}/tables | Read document tables.
[**GetDocumentTextAnnotations**](PdfApi.md#getdocumenttextannotations) | **GET** /pdf/\{name}/annotations/text | Read document text annotations.
[**GetDocumentTextBoxFields**](PdfApi.md#getdocumenttextboxfields) | **GET** /pdf/\{name}/fields/textbox | Read document text box fields.
[**GetDocumentUnderlineAnnotations**](PdfApi.md#getdocumentunderlineannotations) | **GET** /pdf/\{name}/annotations/underline | Read document underline annotations.
[**GetDownloadDocumentAttachmentByIndex**](PdfApi.md#getdownloaddocumentattachmentbyindex) | **GET** /pdf/\{name}/attachments/\{attachmentIndex}/download | Download document attachment content by its index.
[**GetEpubInStorageToPdf**](PdfApi.md#getepubinstoragetopdf) | **GET** /pdf/create/epub | Convert EPUB file (located on storage) to PDF format and return resulting file in response. 
[**GetExportFieldsFromPdfToFdfInStorage**](PdfApi.md#getexportfieldsfrompdftofdfinstorage) | **GET** /pdf/\{name}/export/fdf | Export fields from from PDF in storage to FDF file.
[**GetExportFieldsFromPdfToXfdfInStorage**](PdfApi.md#getexportfieldsfrompdftoxfdfinstorage) | **GET** /pdf/\{name}/export/xfdf | Export fields from from PDF in storage to XFDF file.
[**GetExportFieldsFromPdfToXmlInStorage**](PdfApi.md#getexportfieldsfrompdftoxmlinstorage) | **GET** /pdf/\{name}/export/xml | Export fields from from PDF in storage to XML file.
[**GetField**](PdfApi.md#getfield) | **GET** /pdf/\{name}/fields/\{fieldName} | Get document field by name.
[**GetFields**](PdfApi.md#getfields) | **GET** /pdf/\{name}/fields | Get document fields.
[**GetFileAttachmentAnnotation**](PdfApi.md#getfileattachmentannotation) | **GET** /pdf/\{name}/annotations/fileattachment/\{annotationId} | Read document page FileAttachment annotation by ID.
[**GetFileAttachmentAnnotationData**](PdfApi.md#getfileattachmentannotationdata) | **GET** /pdf/\{name}/annotations/fileattachment/\{annotationId}/data | Read document page FileAttachment annotation by ID.
[**GetFileVersions**](PdfApi.md#getfileversions) | **GET** /pdf/storage/version/\{path} | Get file versions
[**GetFilesList**](PdfApi.md#getfileslist) | **GET** /pdf/storage/folder/\{path} | Get all files and folders within a folder
[**GetFreeTextAnnotation**](PdfApi.md#getfreetextannotation) | **GET** /pdf/\{name}/annotations/freetext/\{annotationId} | Read document page free text annotation by ID.
[**GetHighlightAnnotation**](PdfApi.md#gethighlightannotation) | **GET** /pdf/\{name}/annotations/highlight/\{annotationId} | Read document page highlight annotation by ID.
[**GetHtmlInStorageToPdf**](PdfApi.md#gethtmlinstoragetopdf) | **GET** /pdf/create/html | Convert HTML file (located on storage) to PDF format and return resulting file in response. 
[**GetImage**](PdfApi.md#getimage) | **GET** /pdf/\{name}/images/\{imageId} | Read document image by ID.
[**GetImageExtractAsGif**](PdfApi.md#getimageextractasgif) | **GET** /pdf/\{name}/images/\{imageId}/extract/gif | Extract document image in GIF format
[**GetImageExtractAsJpeg**](PdfApi.md#getimageextractasjpeg) | **GET** /pdf/\{name}/images/\{imageId}/extract/jpeg | Extract document image in JPEG format
[**GetImageExtractAsPng**](PdfApi.md#getimageextractaspng) | **GET** /pdf/\{name}/images/\{imageId}/extract/png | Extract document image in PNG format
[**GetImageExtractAsTiff**](PdfApi.md#getimageextractastiff) | **GET** /pdf/\{name}/images/\{imageId}/extract/tiff | Extract document image in TIFF format
[**GetImages**](PdfApi.md#getimages) | **GET** /pdf/\{name}/pages/\{pageNumber}/images | Read document images.
[**GetImportFieldsFromFdfInStorage**](PdfApi.md#getimportfieldsfromfdfinstorage) | **GET** /pdf/\{name}/import/fdf | Update fields from FDF file in storage.
[**GetImportFieldsFromXfdfInStorage**](PdfApi.md#getimportfieldsfromxfdfinstorage) | **GET** /pdf/\{name}/import/xfdf | Update fields from XFDF file in storage.
[**GetImportFieldsFromXmlInStorage**](PdfApi.md#getimportfieldsfromxmlinstorage) | **GET** /pdf/\{name}/import/xml | Import from XML file (located on storage) to PDF format and return resulting file in response. 
[**GetInkAnnotation**](PdfApi.md#getinkannotation) | **GET** /pdf/\{name}/annotations/ink/\{annotationId} | Read document page ink annotation by ID.
[**GetLaTeXInStorageToPdf**](PdfApi.md#getlatexinstoragetopdf) | **GET** /pdf/create/latex | Convert LaTeX file (located on storage) to PDF format and return resulting file in response. 
[**GetLineAnnotation**](PdfApi.md#getlineannotation) | **GET** /pdf/\{name}/annotations/line/\{annotationId} | Read document page line annotation by ID.
[**GetLinkAnnotation**](PdfApi.md#getlinkannotation) | **GET** /pdf/\{name}/links/\{linkId} | Read document link annotation by ID.
[**GetListBoxField**](PdfApi.md#getlistboxfield) | **GET** /pdf/\{name}/fields/listbox/\{fieldName} | Read document listbox field by name.
[**GetMarkdownInStorageToPdf**](PdfApi.md#getmarkdowninstoragetopdf) | **GET** /pdf/create/markdown | Convert MD file (located on storage) to PDF format and return resulting file in response. 
[**GetMhtInStorageToPdf**](PdfApi.md#getmhtinstoragetopdf) | **GET** /pdf/create/mht | Convert MHT file (located on storage) to PDF format and return resulting file in response. 
[**GetMovieAnnotation**](PdfApi.md#getmovieannotation) | **GET** /pdf/\{name}/annotations/movie/\{annotationId} | Read document page movie annotation by ID.
[**GetPage**](PdfApi.md#getpage) | **GET** /pdf/\{name}/pages/\{pageNumber} | Read document page info.
[**GetPageAnnotations**](PdfApi.md#getpageannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations | Read document page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.
[**GetPageCaretAnnotations**](PdfApi.md#getpagecaretannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/caret | Read document page caret annotations.
[**GetPageCheckBoxFields**](PdfApi.md#getpagecheckboxfields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/checkbox | Read document page checkbox fields.
[**GetPageCircleAnnotations**](PdfApi.md#getpagecircleannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/circle | Read document page circle annotations.
[**GetPageComboBoxFields**](PdfApi.md#getpagecomboboxfields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/combobox | Read document page combobox fields.
[**GetPageConvertToBmp**](PdfApi.md#getpageconverttobmp) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/bmp | Convert document page to Bmp image and return resulting file in response.
[**GetPageConvertToEmf**](PdfApi.md#getpageconverttoemf) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/emf | Convert document page to Emf image and return resulting file in response.
[**GetPageConvertToGif**](PdfApi.md#getpageconverttogif) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/gif | Convert document page to Gif image and return resulting file in response.
[**GetPageConvertToJpeg**](PdfApi.md#getpageconverttojpeg) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/jpeg | Convert document page to Jpeg image and return resulting file in response.
[**GetPageConvertToPng**](PdfApi.md#getpageconverttopng) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/png | Convert document page to Png image and return resulting file in response.
[**GetPageConvertToTiff**](PdfApi.md#getpageconverttotiff) | **GET** /pdf/\{name}/pages/\{pageNumber}/convert/tiff | Convert document page to Tiff image  and return resulting file in response.
[**GetPageFileAttachmentAnnotations**](PdfApi.md#getpagefileattachmentannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/fileattachment | Read document page FileAttachment annotations.
[**GetPageFreeTextAnnotations**](PdfApi.md#getpagefreetextannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/freetext | Read document page free text annotations.
[**GetPageHighlightAnnotations**](PdfApi.md#getpagehighlightannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/highlight | Read document page highlight annotations.
[**GetPageInkAnnotations**](PdfApi.md#getpageinkannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/ink | Read document page ink annotations.
[**GetPageLineAnnotations**](PdfApi.md#getpagelineannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/line | Read document page line annotations.
[**GetPageLinkAnnotation**](PdfApi.md#getpagelinkannotation) | **GET** /pdf/\{name}/pages/\{pageNumber}/links/\{linkId} | Read document page link annotation by ID.
[**GetPageLinkAnnotations**](PdfApi.md#getpagelinkannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/links | Read document page link annotations.
[**GetPageListBoxFields**](PdfApi.md#getpagelistboxfields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/listbox | Read document page listbox fields.
[**GetPageMovieAnnotations**](PdfApi.md#getpagemovieannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/movie | Read document page movie annotations.
[**GetPagePolyLineAnnotations**](PdfApi.md#getpagepolylineannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/polyline | Read document page polyline annotations.
[**GetPagePolygonAnnotations**](PdfApi.md#getpagepolygonannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/polygon | Read document page polygon annotations.
[**GetPagePopupAnnotations**](PdfApi.md#getpagepopupannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/popup | Read document page popup annotations.
[**GetPageRadioButtonFields**](PdfApi.md#getpageradiobuttonfields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/radiobutton | Read document page radiobutton fields.
[**GetPageRedactionAnnotations**](PdfApi.md#getpageredactionannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/redaction | Read document page redaction annotations.
[**GetPageScreenAnnotations**](PdfApi.md#getpagescreenannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/screen | Read document page screen annotations.
[**GetPageSignatureFields**](PdfApi.md#getpagesignaturefields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/signature | Read document page signature fields.
[**GetPageSoundAnnotations**](PdfApi.md#getpagesoundannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/sound | Read document page sound annotations.
[**GetPageSquareAnnotations**](PdfApi.md#getpagesquareannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/square | Read document page square annotations.
[**GetPageSquigglyAnnotations**](PdfApi.md#getpagesquigglyannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/squiggly | Read document page squiggly annotations.
[**GetPageStampAnnotations**](PdfApi.md#getpagestampannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/stamp | Read document page stamp annotations.
[**GetPageStamps**](PdfApi.md#getpagestamps) | **GET** /pdf/\{name}/pages/\{pageNumber}/stamps | Read page document stamps.
[**GetPageStrikeOutAnnotations**](PdfApi.md#getpagestrikeoutannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/strikeout | Read document page StrikeOut annotations.
[**GetPageTables**](PdfApi.md#getpagetables) | **GET** /pdf/\{name}/pages/\{pageNumber}/tables | Read document page tables.
[**GetPageText**](PdfApi.md#getpagetext) | **GET** /pdf/\{name}/pages/\{pageNumber}/text | Read page text items.
[**GetPageTextAnnotations**](PdfApi.md#getpagetextannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/text | Read document page text annotations.
[**GetPageTextBoxFields**](PdfApi.md#getpagetextboxfields) | **GET** /pdf/\{name}/page/\{pageNumber}/fields/textbox | Read document page text box fields.
[**GetPageUnderlineAnnotations**](PdfApi.md#getpageunderlineannotations) | **GET** /pdf/\{name}/pages/\{pageNumber}/annotations/underline | Read document page underline annotations.
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
[**GetPdfInStorageToXlsx**](PdfApi.md#getpdfinstoragetoxlsx) | **GET** /pdf/\{name}/convert/xlsx | Converts PDF document (located on storage) to XLSX format and returns resulting file in response content
[**GetPdfInStorageToXml**](PdfApi.md#getpdfinstoragetoxml) | **GET** /pdf/\{name}/convert/xml | Converts PDF document (located on storage) to XML format and returns resulting file in response content
[**GetPdfInStorageToXps**](PdfApi.md#getpdfinstoragetoxps) | **GET** /pdf/\{name}/convert/xps | Converts PDF document (located on storage) to XPS format and returns resulting file in response content
[**GetPolyLineAnnotation**](PdfApi.md#getpolylineannotation) | **GET** /pdf/\{name}/annotations/polyline/\{annotationId} | Read document page polyline annotation by ID.
[**GetPolygonAnnotation**](PdfApi.md#getpolygonannotation) | **GET** /pdf/\{name}/annotations/polygon/\{annotationId} | Read document page polygon annotation by ID.
[**GetPopupAnnotation**](PdfApi.md#getpopupannotation) | **GET** /pdf/\{name}/annotations/popup/\{annotationId} | Read document page popup annotation by ID.
[**GetPsInStorageToPdf**](PdfApi.md#getpsinstoragetopdf) | **GET** /pdf/create/ps | Convert PS file (located on storage) to PDF format and return resulting file in response. 
[**GetRadioButtonField**](PdfApi.md#getradiobuttonfield) | **GET** /pdf/\{name}/fields/radiobutton/\{fieldName} | Read document RadioButton field by name.
[**GetRedactionAnnotation**](PdfApi.md#getredactionannotation) | **GET** /pdf/\{name}/annotations/redaction/\{annotationId} | Read document page redaction annotation by ID.
[**GetScreenAnnotation**](PdfApi.md#getscreenannotation) | **GET** /pdf/\{name}/annotations/screen/\{annotationId} | Read document page screen annotation by ID.
[**GetScreenAnnotationData**](PdfApi.md#getscreenannotationdata) | **GET** /pdf/\{name}/annotations/screen/\{annotationId}/data | Read document page screen annotation by ID.
[**GetSignatureField**](PdfApi.md#getsignaturefield) | **GET** /pdf/\{name}/fields/signature/\{fieldName} | Read document signature field by name.
[**GetSoundAnnotation**](PdfApi.md#getsoundannotation) | **GET** /pdf/\{name}/annotations/sound/\{annotationId} | Read document page sound annotation by ID.
[**GetSoundAnnotationData**](PdfApi.md#getsoundannotationdata) | **GET** /pdf/\{name}/annotations/sound/\{annotationId}/data | Read document page sound annotation by ID.
[**GetSquareAnnotation**](PdfApi.md#getsquareannotation) | **GET** /pdf/\{name}/annotations/square/\{annotationId} | Read document page square annotation by ID.
[**GetSquigglyAnnotation**](PdfApi.md#getsquigglyannotation) | **GET** /pdf/\{name}/annotations/squiggly/\{annotationId} | Read document page squiggly annotation by ID.
[**GetStampAnnotation**](PdfApi.md#getstampannotation) | **GET** /pdf/\{name}/annotations/stamp/\{annotationId} | Read document page stamp annotation by ID.
[**GetStampAnnotationData**](PdfApi.md#getstampannotationdata) | **GET** /pdf/\{name}/annotations/stamp/\{annotationId}/data | Read document page stamp annotation by ID.
[**GetStrikeOutAnnotation**](PdfApi.md#getstrikeoutannotation) | **GET** /pdf/\{name}/annotations/strikeout/\{annotationId} | Read document page StrikeOut annotation by ID.
[**GetSvgInStorageToPdf**](PdfApi.md#getsvginstoragetopdf) | **GET** /pdf/create/svg | Convert SVG file (located on storage) to PDF format and return resulting file in response. 
[**GetTable**](PdfApi.md#gettable) | **GET** /pdf/\{name}/tables/\{tableId} | Read document page table by ID.
[**GetText**](PdfApi.md#gettext) | **GET** /pdf/\{name}/text | Read document text.
[**GetTextAnnotation**](PdfApi.md#gettextannotation) | **GET** /pdf/\{name}/annotations/text/\{annotationId} | Read document page text annotation by ID.
[**GetTextBoxField**](PdfApi.md#gettextboxfield) | **GET** /pdf/\{name}/fields/textbox/\{fieldName} | Read document text box field by name.
[**GetUnderlineAnnotation**](PdfApi.md#getunderlineannotation) | **GET** /pdf/\{name}/annotations/underline/\{annotationId} | Read document page underline annotation by ID.
[**GetVerifySignature**](PdfApi.md#getverifysignature) | **GET** /pdf/\{name}/verifySignature | Verify signature document.
[**GetWebInStorageToPdf**](PdfApi.md#getwebinstoragetopdf) | **GET** /pdf/create/web | Convert web page to PDF format and return resulting file in response. 
[**GetWordsPerPage**](PdfApi.md#getwordsperpage) | **GET** /pdf/\{name}/pages/wordCount | Get number of words per document page.
[**GetXfaPdfInStorageToAcroForm**](PdfApi.md#getxfapdfinstoragetoacroform) | **GET** /pdf/\{name}/convert/xfatoacroform | Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and returns resulting file response content
[**GetXmlInStorageToPdf**](PdfApi.md#getxmlinstoragetopdf) | **GET** /pdf/create/xml | Convert XML file (located on storage) to PDF format and return resulting file in response. 
[**GetXpsInStorageToPdf**](PdfApi.md#getxpsinstoragetopdf) | **GET** /pdf/create/xps | Convert XPS file (located on storage) to PDF format and return resulting file in response. 
[**GetXslFoInStorageToPdf**](PdfApi.md#getxslfoinstoragetopdf) | **GET** /pdf/create/xslfo | Convert XslFo file (located on storage) to PDF format and return resulting file in response. 
[**MoveFile**](PdfApi.md#movefile) | **PUT** /pdf/storage/file/move/\{srcPath} | Move file
[**MoveFolder**](PdfApi.md#movefolder) | **PUT** /pdf/storage/folder/move/\{srcPath} | Move folder
[**ObjectExists**](PdfApi.md#objectexists) | **GET** /pdf/storage/exist/\{path} | Check if file or folder exists
[**PostAppendDocument**](PdfApi.md#postappenddocument) | **POST** /pdf/\{name}/appendDocument | Append document to existing one.
[**PostBookmark**](PdfApi.md#postbookmark) | **POST** /pdf/\{name}/bookmarks/bookmark/\{bookmarkPath} | Add document bookmarks.
[**PostChangePasswordDocumentInStorage**](PdfApi.md#postchangepassworddocumentinstorage) | **POST** /pdf/\{name}/changepassword | Change document password in storage.
[**PostCheckBoxFields**](PdfApi.md#postcheckboxfields) | **POST** /pdf/\{name}/fields/checkbox | Add document checkbox fields.
[**PostComboBoxFields**](PdfApi.md#postcomboboxfields) | **POST** /pdf/\{name}/fields/combobox | Add document combobox fields.
[**PostCreateDocument**](PdfApi.md#postcreatedocument) | **POST** /pdf/\{name} | Create empty document.
[**PostCreateField**](PdfApi.md#postcreatefield) | **POST** /pdf/\{name}/fields | Create field.
[**PostDecryptDocumentInStorage**](PdfApi.md#postdecryptdocumentinstorage) | **POST** /pdf/\{name}/decrypt | Decrypt document in storage.
[**PostDocumentImageFooter**](PdfApi.md#postdocumentimagefooter) | **POST** /pdf/\{name}/footer/image | Add document image footer.
[**PostDocumentImageHeader**](PdfApi.md#postdocumentimageheader) | **POST** /pdf/\{name}/header/image | Add document image header.
[**PostDocumentPageNumberStamps**](PdfApi.md#postdocumentpagenumberstamps) | **POST** /pdf/\{name}/stamps/pagenumber | Add document page number stamps.
[**PostDocumentTextFooter**](PdfApi.md#postdocumenttextfooter) | **POST** /pdf/\{name}/footer/text | Add document text footer.
[**PostDocumentTextHeader**](PdfApi.md#postdocumenttextheader) | **POST** /pdf/\{name}/header/text | Add document text header.
[**PostDocumentTextReplace**](PdfApi.md#postdocumenttextreplace) | **POST** /pdf/\{name}/text/replace | Document&#39;s replace text method.
[**PostEncryptDocumentInStorage**](PdfApi.md#postencryptdocumentinstorage) | **POST** /pdf/\{name}/encrypt | Encrypt document in storage.
[**PostFlattenDocument**](PdfApi.md#postflattendocument) | **POST** /pdf/\{name}/flatten | Flatten the document.
[**PostImportFieldsFromFdf**](PdfApi.md#postimportfieldsfromfdf) | **POST** /pdf/\{name}/import/fdf | Update fields from FDF file in request.
[**PostImportFieldsFromXfdf**](PdfApi.md#postimportfieldsfromxfdf) | **POST** /pdf/\{name}/import/xfdf | Update fields from XFDF file in request.
[**PostImportFieldsFromXml**](PdfApi.md#postimportfieldsfromxml) | **POST** /pdf/\{name}/import/xml | Update fields from XML file in request.
[**PostInsertImage**](PdfApi.md#postinsertimage) | **POST** /pdf/\{name}/pages/\{pageNumber}/images | Insert image to document page.
[**PostListBoxFields**](PdfApi.md#postlistboxfields) | **POST** /pdf/\{name}/fields/listbox | Add document listbox fields.
[**PostMovePage**](PdfApi.md#postmovepage) | **POST** /pdf/\{name}/pages/\{pageNumber}/movePage | Move page to new position.
[**PostOptimizeDocument**](PdfApi.md#postoptimizedocument) | **POST** /pdf/\{name}/optimize | Optimize document.
[**PostPageCaretAnnotations**](PdfApi.md#postpagecaretannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/caret | Add document page caret annotations.
[**PostPageCertify**](PdfApi.md#postpagecertify) | **POST** /pdf/\{name}/pages/\{pageNumber}/certify | Certify document page.
[**PostPageCircleAnnotations**](PdfApi.md#postpagecircleannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/circle | Add document page circle annotations.
[**PostPageFileAttachmentAnnotations**](PdfApi.md#postpagefileattachmentannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/fileattachment | Add document page FileAttachment annotations.
[**PostPageFreeTextAnnotations**](PdfApi.md#postpagefreetextannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/freetext | Add document page free text annotations.
[**PostPageHighlightAnnotations**](PdfApi.md#postpagehighlightannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/highlight | Add document page highlight annotations.
[**PostPageImageStamps**](PdfApi.md#postpageimagestamps) | **POST** /pdf/\{name}/pages/\{pageNumber}/stamps/image | Add document page image stamps.
[**PostPageInkAnnotations**](PdfApi.md#postpageinkannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/ink | Add document page ink annotations.
[**PostPageLineAnnotations**](PdfApi.md#postpagelineannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/line | Add document page line annotations.
[**PostPageLinkAnnotations**](PdfApi.md#postpagelinkannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/links | Add document page link annotations.
[**PostPageMovieAnnotations**](PdfApi.md#postpagemovieannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/movie | Add document page movie annotations.
[**PostPagePdfPageStamps**](PdfApi.md#postpagepdfpagestamps) | **POST** /pdf/\{name}/pages/\{pageNumber}/stamps/pdfpage | Add document pdf page stamps.
[**PostPagePolyLineAnnotations**](PdfApi.md#postpagepolylineannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/polyline | Add document page polyline annotations.
[**PostPagePolygonAnnotations**](PdfApi.md#postpagepolygonannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/polygon | Add document page polygon annotations.
[**PostPageRedactionAnnotations**](PdfApi.md#postpageredactionannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/redaction | Add document page redaction annotations.
[**PostPageScreenAnnotations**](PdfApi.md#postpagescreenannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/screen | Add document page screen annotations.
[**PostPageSoundAnnotations**](PdfApi.md#postpagesoundannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/sound | Add document page sound annotations.
[**PostPageSquareAnnotations**](PdfApi.md#postpagesquareannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/square | Add document page square annotations.
[**PostPageSquigglyAnnotations**](PdfApi.md#postpagesquigglyannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/squiggly | Add document page squiggly annotations.
[**PostPageStampAnnotations**](PdfApi.md#postpagestampannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/stamp | Add document page stamp annotations.
[**PostPageStrikeOutAnnotations**](PdfApi.md#postpagestrikeoutannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/strikeout | Add document page StrikeOut annotations.
[**PostPageTables**](PdfApi.md#postpagetables) | **POST** /pdf/\{name}/pages/\{pageNumber}/tables | Add document page tables.
[**PostPageTextAnnotations**](PdfApi.md#postpagetextannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/text | Add document page text annotations.
[**PostPageTextReplace**](PdfApi.md#postpagetextreplace) | **POST** /pdf/\{name}/pages/\{pageNumber}/text/replace | Page&#39;s replace text method.
[**PostPageTextStamps**](PdfApi.md#postpagetextstamps) | **POST** /pdf/\{name}/pages/\{pageNumber}/stamps/text | Add document page text stamps.
[**PostPageUnderlineAnnotations**](PdfApi.md#postpageunderlineannotations) | **POST** /pdf/\{name}/pages/\{pageNumber}/annotations/underline | Add document page underline annotations.
[**PostPopupAnnotation**](PdfApi.md#postpopupannotation) | **POST** /pdf/\{name}/annotations/\{annotationId}/popup | Add document popup annotations.
[**PostRadioButtonFields**](PdfApi.md#postradiobuttonfields) | **POST** /pdf/\{name}/fields/radiobutton | Add document RadioButton fields.
[**PostSignDocument**](PdfApi.md#postsigndocument) | **POST** /pdf/\{name}/sign | Sign document.
[**PostSignPage**](PdfApi.md#postsignpage) | **POST** /pdf/\{name}/pages/\{pageNumber}/sign | Sign page.
[**PostSignatureField**](PdfApi.md#postsignaturefield) | **POST** /pdf/\{name}/fields/signature | Add document signature field.
[**PostSplitDocument**](PdfApi.md#postsplitdocument) | **POST** /pdf/\{name}/split | Split document to parts.
[**PostTextBoxFields**](PdfApi.md#posttextboxfields) | **POST** /pdf/\{name}/fields/textbox | Add document text box fields.
[**PutAddNewPage**](PdfApi.md#putaddnewpage) | **PUT** /pdf/\{name}/pages | Add new page to end of the document.
[**PutAddText**](PdfApi.md#putaddtext) | **PUT** /pdf/\{name}/pages/\{pageNumber}/text | Add text to PDF document page.
[**PutAnnotationsFlatten**](PdfApi.md#putannotationsflatten) | **PUT** /pdf/\{name}/annotations/flatten | Flattens the annotations of the specified types
[**PutBookmark**](PdfApi.md#putbookmark) | **PUT** /pdf/\{name}/bookmarks/bookmark/\{bookmarkPath} | Update document bookmark.
[**PutCaretAnnotation**](PdfApi.md#putcaretannotation) | **PUT** /pdf/\{name}/annotations/caret/\{annotationId} | Replace document caret annotation
[**PutChangePasswordDocument**](PdfApi.md#putchangepassworddocument) | **PUT** /pdf/changepassword | Change document password from content.
[**PutCheckBoxField**](PdfApi.md#putcheckboxfield) | **PUT** /pdf/\{name}/fields/checkbox/\{fieldName} | Replace document checkbox field
[**PutCircleAnnotation**](PdfApi.md#putcircleannotation) | **PUT** /pdf/\{name}/annotations/circle/\{annotationId} | Replace document circle annotation
[**PutComboBoxField**](PdfApi.md#putcomboboxfield) | **PUT** /pdf/\{name}/fields/combobox/\{fieldName} | Replace document combobox field
[**PutCreateDocument**](PdfApi.md#putcreatedocument) | **PUT** /pdf/\{name} | Create empty document.
[**PutDecryptDocument**](PdfApi.md#putdecryptdocument) | **PUT** /pdf/decrypt | Decrypt document from content.
[**PutDocumentDisplayProperties**](PdfApi.md#putdocumentdisplayproperties) | **PUT** /pdf/\{name}/displayproperties | Update document display properties.
[**PutEncryptDocument**](PdfApi.md#putencryptdocument) | **PUT** /pdf/encrypt | Encrypt document from content.
[**PutEpubInStorageToPdf**](PdfApi.md#putepubinstoragetopdf) | **PUT** /pdf/\{name}/create/epub | Convert EPUB file (located on storage) to PDF format and upload resulting file to storage. 
[**PutExportFieldsFromPdfToFdfInStorage**](PdfApi.md#putexportfieldsfrompdftofdfinstorage) | **PUT** /pdf/\{name}/export/fdf | Export fields from from PDF in storage to FDF file in storage.
[**PutExportFieldsFromPdfToXfdfInStorage**](PdfApi.md#putexportfieldsfrompdftoxfdfinstorage) | **PUT** /pdf/\{name}/export/xfdf | Export fields from from PDF in storage to XFDF file in storage.
[**PutExportFieldsFromPdfToXmlInStorage**](PdfApi.md#putexportfieldsfrompdftoxmlinstorage) | **PUT** /pdf/\{name}/export/xml | Export fields from from PDF in storage to XML file in storage.
[**PutFieldsFlatten**](PdfApi.md#putfieldsflatten) | **PUT** /pdf/\{name}/fields/flatten | Flatten form fields in document.
[**PutFileAttachmentAnnotation**](PdfApi.md#putfileattachmentannotation) | **PUT** /pdf/\{name}/annotations/fileattachment/\{annotationId} | Replace document FileAttachment annotation
[**PutFileAttachmentAnnotationDataExtract**](PdfApi.md#putfileattachmentannotationdataextract) | **PUT** /pdf/\{name}/annotations/fileattachment/\{annotationId}/data/extract | Extract document FileAttachment annotation content to storage
[**PutFreeTextAnnotation**](PdfApi.md#putfreetextannotation) | **PUT** /pdf/\{name}/annotations/freetext/\{annotationId} | Replace document free text annotation
[**PutHighlightAnnotation**](PdfApi.md#puthighlightannotation) | **PUT** /pdf/\{name}/annotations/highlight/\{annotationId} | Replace document highlight annotation
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
[**PutImportFieldsFromFdfInStorage**](PdfApi.md#putimportfieldsfromfdfinstorage) | **PUT** /pdf/\{name}/import/fdf | Update fields from FDF file in storage.
[**PutImportFieldsFromXfdfInStorage**](PdfApi.md#putimportfieldsfromxfdfinstorage) | **PUT** /pdf/\{name}/import/xfdf | Update fields from XFDF file in storage.
[**PutImportFieldsFromXmlInStorage**](PdfApi.md#putimportfieldsfromxmlinstorage) | **PUT** /pdf/\{name}/import/xml | Update fields from XML file in storage.
[**PutInkAnnotation**](PdfApi.md#putinkannotation) | **PUT** /pdf/\{name}/annotations/ink/\{annotationId} | Replace document ink annotation
[**PutLaTeXInStorageToPdf**](PdfApi.md#putlatexinstoragetopdf) | **PUT** /pdf/\{name}/create/latex | Convert LaTeX file (located on storage) to PDF format and upload resulting file to storage. 
[**PutLineAnnotation**](PdfApi.md#putlineannotation) | **PUT** /pdf/\{name}/annotations/line/\{annotationId} | Replace document line annotation
[**PutLinkAnnotation**](PdfApi.md#putlinkannotation) | **PUT** /pdf/\{name}/links/\{linkId} | Replace document page link annotations
[**PutListBoxField**](PdfApi.md#putlistboxfield) | **PUT** /pdf/\{name}/fields/listbox/\{fieldName} | Replace document listbox field
[**PutMarkdownInStorageToPdf**](PdfApi.md#putmarkdowninstoragetopdf) | **PUT** /pdf/\{name}/create/markdown | Convert MD file (located on storage) to PDF format and upload resulting file to storage. 
[**PutMergeDocuments**](PdfApi.md#putmergedocuments) | **PUT** /pdf/\{name}/merge | Merge a list of documents.
[**PutMhtInStorageToPdf**](PdfApi.md#putmhtinstoragetopdf) | **PUT** /pdf/\{name}/create/mht | Convert MHT file (located on storage) to PDF format and upload resulting file to storage. 
[**PutMovieAnnotation**](PdfApi.md#putmovieannotation) | **PUT** /pdf/\{name}/annotations/movie/\{annotationId} | Replace document movie annotation
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
[**PutPdfInRequestToXlsx**](PdfApi.md#putpdfinrequesttoxlsx) | **PUT** /pdf/convert/xlsx | Converts PDF document (in request content) to XLSX format and uploads resulting file to storage.
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
[**PutPdfInStorageToXlsx**](PdfApi.md#putpdfinstoragetoxlsx) | **PUT** /pdf/\{name}/convert/xlsx | Converts PDF document (located on storage) to XLSX format and uploads resulting file to storage
[**PutPdfInStorageToXml**](PdfApi.md#putpdfinstoragetoxml) | **PUT** /pdf/\{name}/convert/xml | Converts PDF document (located on storage) to XML format and uploads resulting file to storage
[**PutPdfInStorageToXps**](PdfApi.md#putpdfinstoragetoxps) | **PUT** /pdf/\{name}/convert/xps | Converts PDF document (located on storage) to XPS format and uploads resulting file to storage
[**PutPolyLineAnnotation**](PdfApi.md#putpolylineannotation) | **PUT** /pdf/\{name}/annotations/polyline/\{annotationId} | Replace document polyline annotation
[**PutPolygonAnnotation**](PdfApi.md#putpolygonannotation) | **PUT** /pdf/\{name}/annotations/polygon/\{annotationId} | Replace document polygon annotation
[**PutPopupAnnotation**](PdfApi.md#putpopupannotation) | **PUT** /pdf/\{name}/annotations/popup/\{annotationId} | Replace document popup annotation
[**PutPrivileges**](PdfApi.md#putprivileges) | **PUT** /pdf/\{name}/privileges | Update privilege document.
[**PutPsInStorageToPdf**](PdfApi.md#putpsinstoragetopdf) | **PUT** /pdf/\{name}/create/ps | Convert PS file (located on storage) to PDF format and upload resulting file to storage. 
[**PutRadioButtonField**](PdfApi.md#putradiobuttonfield) | **PUT** /pdf/\{name}/fields/radiobutton/\{fieldName} | Replace document RadioButton field
[**PutRedactionAnnotation**](PdfApi.md#putredactionannotation) | **PUT** /pdf/\{name}/annotations/redaction/\{annotationId} | Replace document redaction annotation
[**PutReplaceImage**](PdfApi.md#putreplaceimage) | **PUT** /pdf/\{name}/images/\{imageId} | Replace document image.
[**PutScreenAnnotation**](PdfApi.md#putscreenannotation) | **PUT** /pdf/\{name}/annotations/screen/\{annotationId} | Replace document screen annotation
[**PutScreenAnnotationDataExtract**](PdfApi.md#putscreenannotationdataextract) | **PUT** /pdf/\{name}/annotations/screen/\{annotationId}/data/extract | Extract document screen annotation content to storage
[**PutSearchableDocument**](PdfApi.md#putsearchabledocument) | **PUT** /pdf/\{name}/ocr | Create searchable PDF document. Generate OCR layer for images in input PDF document.
[**PutSetProperty**](PdfApi.md#putsetproperty) | **PUT** /pdf/\{name}/documentproperties/\{propertyName} | Add/update document property.
[**PutSignatureField**](PdfApi.md#putsignaturefield) | **PUT** /pdf/\{name}/fields/signature/\{fieldName} | Replace document signature field.
[**PutSoundAnnotation**](PdfApi.md#putsoundannotation) | **PUT** /pdf/\{name}/annotations/sound/\{annotationId} | Replace document sound annotation
[**PutSoundAnnotationDataExtract**](PdfApi.md#putsoundannotationdataextract) | **PUT** /pdf/\{name}/annotations/sound/\{annotationId}/data/extract | Extract document sound annotation content to storage
[**PutSquareAnnotation**](PdfApi.md#putsquareannotation) | **PUT** /pdf/\{name}/annotations/square/\{annotationId} | Replace document square annotation
[**PutSquigglyAnnotation**](PdfApi.md#putsquigglyannotation) | **PUT** /pdf/\{name}/annotations/squiggly/\{annotationId} | Replace document squiggly annotation
[**PutStampAnnotation**](PdfApi.md#putstampannotation) | **PUT** /pdf/\{name}/annotations/stamp/\{annotationId} | Replace document stamp annotation
[**PutStampAnnotationDataExtract**](PdfApi.md#putstampannotationdataextract) | **PUT** /pdf/\{name}/annotations/stamp/\{annotationId}/data/extract | Extract document stamp annotation content to storage
[**PutStrikeOutAnnotation**](PdfApi.md#putstrikeoutannotation) | **PUT** /pdf/\{name}/annotations/strikeout/\{annotationId} | Replace document StrikeOut annotation
[**PutSvgInStorageToPdf**](PdfApi.md#putsvginstoragetopdf) | **PUT** /pdf/\{name}/create/svg | Convert SVG file (located on storage) to PDF format and upload resulting file to storage. 
[**PutTable**](PdfApi.md#puttable) | **PUT** /pdf/\{name}/tables/\{tableId} | Replace document page table.
[**PutTextAnnotation**](PdfApi.md#puttextannotation) | **PUT** /pdf/\{name}/annotations/text/\{annotationId} | Replace document text annotation
[**PutTextBoxField**](PdfApi.md#puttextboxfield) | **PUT** /pdf/\{name}/fields/textbox/\{fieldName} | Replace document text box field
[**PutUnderlineAnnotation**](PdfApi.md#putunderlineannotation) | **PUT** /pdf/\{name}/annotations/underline/\{annotationId} | Replace document underline annotation
[**PutUpdateField**](PdfApi.md#putupdatefield) | **PUT** /pdf/\{name}/fields/\{fieldName} | Update field.
[**PutUpdateFields**](PdfApi.md#putupdatefields) | **PUT** /pdf/\{name}/fields | Update fields.
[**PutWebInStorageToPdf**](PdfApi.md#putwebinstoragetopdf) | **PUT** /pdf/\{name}/create/web | Convert web page to PDF format and upload resulting file to storage. 
[**PutXfaPdfInRequestToAcroForm**](PdfApi.md#putxfapdfinrequesttoacroform) | **PUT** /pdf/convert/xfatoacroform | Converts PDF document which contatins XFA form (in request content) to PDF with AcroForm and uploads resulting file to storage.
[**PutXfaPdfInStorageToAcroForm**](PdfApi.md#putxfapdfinstoragetoacroform) | **PUT** /pdf/\{name}/convert/xfatoacroform | Converts PDF document which contatins XFA form (located on storage) to PDF with AcroForm and uploads resulting file to storage
[**PutXmlInStorageToPdf**](PdfApi.md#putxmlinstoragetopdf) | **PUT** /pdf/\{name}/create/xml | Convert XML file (located on storage) to PDF format and upload resulting file to storage. 
[**PutXpsInStorageToPdf**](PdfApi.md#putxpsinstoragetopdf) | **PUT** /pdf/\{name}/create/xps | Convert XPS file (located on storage) to PDF format and upload resulting file to storage. 
[**PutXslFoInStorageToPdf**](PdfApi.md#putxslfoinstoragetopdf) | **PUT** /pdf/\{name}/create/xslfo | Convert XslFo file (located on storage) to PDF format and upload resulting file to storage. 
[**StorageExists**](PdfApi.md#storageexists) | **GET** /pdf/storage/\{storageName}/exist | Check if storage exists
[**UploadFile**](PdfApi.md#uploadfile) | **PUT** /pdf/storage/file/\{path} | Upload file


<a name="copyfile"></a>
# **CopyFile**
> void CopyFile (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)

Copy file


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/folder/file.ext&#39; | 
 **destPath** | **string**| Destination file path | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to copy | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copyfolder"></a>
# **CopyFolder**
> void CopyFolder (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)

Copy folder


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source folder path e.g. &#39;/src&#39; | 
 **destPath** | **string**| Destination folder path e.g. &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfolder"></a>
# **CreateFolder**
> void CreateFolder (string path, string storageName = null)

Create the folder


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path to create e.g. &#39;folder_1/folder_2/&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

<a name="deletebookmark"></a>
# **DeleteBookmark**
> AsposeResponse DeleteBookmark (string name, string bookmarkPath, string folder = null, string storage = null)

Delete document bookmark by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **bookmarkPath** | **string**| The bookmark path. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

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

<a name="deletedocumentbookmarks"></a>
# **DeleteDocumentBookmarks**
> AsposeResponse DeleteDocumentBookmarks (string name, string folder = null, string storage = null)

Delete all document bookmarks.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

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

<a name="deletedocumentstamps"></a>
# **DeleteDocumentStamps**
> AsposeResponse DeleteDocumentStamps (string name, string storage = null, string folder = null)

Delete all stamps from the document


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

<a name="deletedocumenttables"></a>
# **DeleteDocumentTables**
> AsposeResponse DeleteDocumentTables (string name, string storage = null, string folder = null)

Delete all tables from the document


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

<a name="deletefile"></a>
# **DeleteFile**
> void DeleteFile (string path, string storageName = null, string versionId = null)

Delete file


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to delete | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefolder"></a>
# **DeleteFolder**
> void DeleteFolder (string path, string storageName = null, bool? recursive = null)

Delete folder


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **recursive** | **bool?**| Enable to delete folders, subfolders and files | [optional] [default to false]

### Return type

void (empty response body)

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

<a name="deletepagestamps"></a>
# **DeletePageStamps**
> AsposeResponse DeletePageStamps (string name, int? pageNumber, string storage = null, string folder = null)

Delete all stamps from the page


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

<a name="deletepagetables"></a>
# **DeletePageTables**
> AsposeResponse DeletePageTables (string name, int? pageNumber, string storage = null, string folder = null)

Delete all tables from the page


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

<a name="deletestamp"></a>
# **DeleteStamp**
> AsposeResponse DeleteStamp (string name, string stampId, string storage = null, string folder = null)

Delete document stamp by ID


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **stampId** | **string**| The stamp ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetable"></a>
# **DeleteTable**
> AsposeResponse DeleteTable (string name, string tableId, string storage = null, string folder = null)

Delete document table by ID


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **tableId** | **string**| The table ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadfile"></a>
# **DownloadFile**
> System.IO.Stream DownloadFile (string path, string storageName = null, string versionId = null)

Download file


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to download | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbookmark"></a>
# **GetBookmark**
> BookmarkResponse GetBookmark (string name, string bookmarkPath, string folder = null, string storage = null)

Read document bookmark.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **bookmarkPath** | **string**| The bookmark path. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**BookmarkResponse**](BookmarkResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbookmarks"></a>
# **GetBookmarks**
> BookmarksResponse GetBookmarks (string name, string bookmarkPath, string folder = null, string storage = null)

Read document bookmarks node list.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **bookmarkPath** | **string**| The bookmark path. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**BookmarksResponse**](BookmarksResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcaretannotation"></a>
# **GetCaretAnnotation**
> CaretAnnotationResponse GetCaretAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page caret annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CaretAnnotationResponse**](CaretAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcheckboxfield"></a>
# **GetCheckBoxField**
> CheckBoxFieldResponse GetCheckBoxField (string name, string fieldName, string storage = null, string folder = null)

Read document checkbox field by name.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CheckBoxFieldResponse**](CheckBoxFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcircleannotation"></a>
# **GetCircleAnnotation**
> CircleAnnotationResponse GetCircleAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page circle annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CircleAnnotationResponse**](CircleAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomboboxfield"></a>
# **GetComboBoxField**
> ComboBoxFieldResponse GetComboBoxField (string name, string fieldName, string storage = null, string folder = null)

Read document combobox field by name.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ComboBoxFieldResponse**](ComboBoxFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiscusage"></a>
# **GetDiscUsage**
> DiscUsage GetDiscUsage (string storageName = null)

Get disc usage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**DiscUsage**](DiscUsage.md)

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
 - **Accept**: application/json

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
> BookmarksResponse GetDocumentBookmarks (string name, string folder = null, string storage = null)

Read document bookmarks tree.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**BookmarksResponse**](BookmarksResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentcaretannotations"></a>
# **GetDocumentCaretAnnotations**
> CaretAnnotationsResponse GetDocumentCaretAnnotations (string name, string storage = null, string folder = null)

Read document caret annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CaretAnnotationsResponse**](CaretAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentcheckboxfields"></a>
# **GetDocumentCheckBoxFields**
> CheckBoxFieldsResponse GetDocumentCheckBoxFields (string name, string storage = null, string folder = null)

Read document checkbox fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CheckBoxFieldsResponse**](CheckBoxFieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentcircleannotations"></a>
# **GetDocumentCircleAnnotations**
> CircleAnnotationsResponse GetDocumentCircleAnnotations (string name, string storage = null, string folder = null)

Read document circle annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CircleAnnotationsResponse**](CircleAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentcomboboxfields"></a>
# **GetDocumentComboBoxFields**
> ComboBoxFieldsResponse GetDocumentComboBoxFields (string name, string storage = null, string folder = null)

Read document combobox fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ComboBoxFieldsResponse**](ComboBoxFieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentdisplayproperties"></a>
# **GetDocumentDisplayProperties**
> DisplayPropertiesResponse GetDocumentDisplayProperties (string name, string storage = null, string folder = null)

Read document display properties.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**DisplayPropertiesResponse**](DisplayPropertiesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentfileattachmentannotations"></a>
# **GetDocumentFileAttachmentAnnotations**
> FileAttachmentAnnotationsResponse GetDocumentFileAttachmentAnnotations (string name, string storage = null, string folder = null)

Read document FileAttachment annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FileAttachmentAnnotationsResponse**](FileAttachmentAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

<a name="getdocumenthighlightannotations"></a>
# **GetDocumentHighlightAnnotations**
> HighlightAnnotationsResponse GetDocumentHighlightAnnotations (string name, string storage = null, string folder = null)

Read document highlight annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**HighlightAnnotationsResponse**](HighlightAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentinkannotations"></a>
# **GetDocumentInkAnnotations**
> InkAnnotationsResponse GetDocumentInkAnnotations (string name, string storage = null, string folder = null)

Read document ink annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**InkAnnotationsResponse**](InkAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentlineannotations"></a>
# **GetDocumentLineAnnotations**
> LineAnnotationsResponse GetDocumentLineAnnotations (string name, string storage = null, string folder = null)

Read document line annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**LineAnnotationsResponse**](LineAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentlistboxfields"></a>
# **GetDocumentListBoxFields**
> ListBoxFieldsResponse GetDocumentListBoxFields (string name, string storage = null, string folder = null)

Read document listbox fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ListBoxFieldsResponse**](ListBoxFieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentmovieannotations"></a>
# **GetDocumentMovieAnnotations**
> MovieAnnotationsResponse GetDocumentMovieAnnotations (string name, string storage = null, string folder = null)

Read document movie annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**MovieAnnotationsResponse**](MovieAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentpolylineannotations"></a>
# **GetDocumentPolyLineAnnotations**
> PolyLineAnnotationsResponse GetDocumentPolyLineAnnotations (string name, string storage = null, string folder = null)

Read document polyline annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PolyLineAnnotationsResponse**](PolyLineAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentpolygonannotations"></a>
# **GetDocumentPolygonAnnotations**
> PolygonAnnotationsResponse GetDocumentPolygonAnnotations (string name, string storage = null, string folder = null)

Read document polygon annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PolygonAnnotationsResponse**](PolygonAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentpopupannotations"></a>
# **GetDocumentPopupAnnotations**
> PopupAnnotationsResponse GetDocumentPopupAnnotations (string name, string storage = null, string folder = null)

Read document popup annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PopupAnnotationsResponse**](PopupAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentpopupannotationsbyparent"></a>
# **GetDocumentPopupAnnotationsByParent**
> PopupAnnotationsResponse GetDocumentPopupAnnotationsByParent (string name, string annotationId, string storage = null, string folder = null)

Read document popup annotations by parent id.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The parent annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PopupAnnotationsResponse**](PopupAnnotationsResponse.md)

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

<a name="getdocumentradiobuttonfields"></a>
# **GetDocumentRadioButtonFields**
> RadioButtonFieldsResponse GetDocumentRadioButtonFields (string name, string storage = null, string folder = null)

Read document radiobutton fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**RadioButtonFieldsResponse**](RadioButtonFieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentredactionannotations"></a>
# **GetDocumentRedactionAnnotations**
> RedactionAnnotationsResponse GetDocumentRedactionAnnotations (string name, string storage = null, string folder = null)

Read document redaction annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**RedactionAnnotationsResponse**](RedactionAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentscreenannotations"></a>
# **GetDocumentScreenAnnotations**
> ScreenAnnotationsResponse GetDocumentScreenAnnotations (string name, string storage = null, string folder = null)

Read document screen annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ScreenAnnotationsResponse**](ScreenAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentsignaturefields"></a>
# **GetDocumentSignatureFields**
> SignatureFieldsResponse GetDocumentSignatureFields (string name, string storage = null, string folder = null)

Read document signature fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SignatureFieldsResponse**](SignatureFieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentsoundannotations"></a>
# **GetDocumentSoundAnnotations**
> SoundAnnotationsResponse GetDocumentSoundAnnotations (string name, string storage = null, string folder = null)

Read document sound annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SoundAnnotationsResponse**](SoundAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentsquareannotations"></a>
# **GetDocumentSquareAnnotations**
> SquareAnnotationsResponse GetDocumentSquareAnnotations (string name, string storage = null, string folder = null)

Read document square annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SquareAnnotationsResponse**](SquareAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentsquigglyannotations"></a>
# **GetDocumentSquigglyAnnotations**
> SquigglyAnnotationsResponse GetDocumentSquigglyAnnotations (string name, string storage = null, string folder = null)

Read document squiggly annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SquigglyAnnotationsResponse**](SquigglyAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentstampannotations"></a>
# **GetDocumentStampAnnotations**
> StampAnnotationsResponse GetDocumentStampAnnotations (string name, string storage = null, string folder = null)

Read document stamp annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**StampAnnotationsResponse**](StampAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentstamps"></a>
# **GetDocumentStamps**
> StampsInfoResponse GetDocumentStamps (string name, string storage = null, string folder = null)

Read document stamps.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**StampsInfoResponse**](StampsInfoResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentstrikeoutannotations"></a>
# **GetDocumentStrikeOutAnnotations**
> StrikeOutAnnotationsResponse GetDocumentStrikeOutAnnotations (string name, string storage = null, string folder = null)

Read document StrikeOut annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**StrikeOutAnnotationsResponse**](StrikeOutAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumenttables"></a>
# **GetDocumentTables**
> TablesRecognizedResponse GetDocumentTables (string name, string storage = null, string folder = null)

Read document tables.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**TablesRecognizedResponse**](TablesRecognizedResponse.md)

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

<a name="getdocumenttextboxfields"></a>
# **GetDocumentTextBoxFields**
> TextBoxFieldsResponse GetDocumentTextBoxFields (string name, string storage = null, string folder = null)

Read document text box fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TextBoxFieldsResponse**](TextBoxFieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentunderlineannotations"></a>
# **GetDocumentUnderlineAnnotations**
> UnderlineAnnotationsResponse GetDocumentUnderlineAnnotations (string name, string storage = null, string folder = null)

Read document underline annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**UnderlineAnnotationsResponse**](UnderlineAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

<a name="getexportfieldsfrompdftofdfinstorage"></a>
# **GetExportFieldsFromPdfToFdfInStorage**
> System.IO.Stream GetExportFieldsFromPdfToFdfInStorage (string name, string storage = null, string folder = null)

Export fields from from PDF in storage to FDF file.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexportfieldsfrompdftoxfdfinstorage"></a>
# **GetExportFieldsFromPdfToXfdfInStorage**
> System.IO.Stream GetExportFieldsFromPdfToXfdfInStorage (string name, string storage = null, string folder = null)

Export fields from from PDF in storage to XFDF file.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexportfieldsfrompdftoxmlinstorage"></a>
# **GetExportFieldsFromPdfToXmlInStorage**
> System.IO.Stream GetExportFieldsFromPdfToXmlInStorage (string name, string storage = null, string folder = null)

Export fields from from PDF in storage to XML file.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

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
 **fieldName** | **string**| The field name (name should be encoded). | 
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

<a name="getfileattachmentannotation"></a>
# **GetFileAttachmentAnnotation**
> FileAttachmentAnnotationResponse GetFileAttachmentAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page FileAttachment annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FileAttachmentAnnotationResponse**](FileAttachmentAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfileattachmentannotationdata"></a>
# **GetFileAttachmentAnnotationData**
> System.IO.Stream GetFileAttachmentAnnotationData (string name, string annotationId, string storage = null, string folder = null)

Read document page FileAttachment annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfileversions"></a>
# **GetFileVersions**
> FileVersions GetFileVersions (string path, string storageName = null)

Get file versions


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FileVersions**](FileVersions.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfileslist"></a>
# **GetFilesList**
> FilesList GetFilesList (string path, string storageName = null)

Get all files and folders within a folder


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesList**](FilesList.md)

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

<a name="gethighlightannotation"></a>
# **GetHighlightAnnotation**
> HighlightAnnotationResponse GetHighlightAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page highlight annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**HighlightAnnotationResponse**](HighlightAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethtmlinstoragetopdf"></a>
# **GetHtmlInStorageToPdf**
> System.IO.Stream GetHtmlInStorageToPdf (string srcPath, string htmlFileName = null, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string storage = null)

Convert HTML file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.zip) | 
 **htmlFileName** | **string**| Name of HTML file in ZIP. | [optional] 
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

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

<a name="getimportfieldsfromfdfinstorage"></a>
# **GetImportFieldsFromFdfInStorage**
> System.IO.Stream GetImportFieldsFromFdfInStorage (string name, string fdfFilePath, string storage = null, string folder = null)

Update fields from FDF file in storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fdfFilePath** | **string**| The Fdf file path. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimportfieldsfromxfdfinstorage"></a>
# **GetImportFieldsFromXfdfInStorage**
> System.IO.Stream GetImportFieldsFromXfdfInStorage (string name, string xfdfFilePath, string storage = null, string folder = null)

Update fields from XFDF file in storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **xfdfFilePath** | **string**| The XFDF file path. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimportfieldsfromxmlinstorage"></a>
# **GetImportFieldsFromXmlInStorage**
> System.IO.Stream GetImportFieldsFromXmlInStorage (string name, string xmlFilePath, string storage = null, string folder = null)

Import from XML file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **xmlFilePath** | **string**| Full source filename (ex. /folder1/folder2/template.xml) | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinkannotation"></a>
# **GetInkAnnotation**
> InkAnnotationResponse GetInkAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page ink annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**InkAnnotationResponse**](InkAnnotationResponse.md)

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

<a name="getlineannotation"></a>
# **GetLineAnnotation**
> LineAnnotationResponse GetLineAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page line annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**LineAnnotationResponse**](LineAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

<a name="getlistboxfield"></a>
# **GetListBoxField**
> ListBoxFieldResponse GetListBoxField (string name, string fieldName, string storage = null, string folder = null)

Read document listbox field by name.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ListBoxFieldResponse**](ListBoxFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarkdowninstoragetopdf"></a>
# **GetMarkdownInStorageToPdf**
> System.IO.Stream GetMarkdownInStorageToPdf (string srcPath, string storage = null)

Convert MD file (located on storage) to PDF format and return resulting file in response. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.md) | 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

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

<a name="getmovieannotation"></a>
# **GetMovieAnnotation**
> MovieAnnotationResponse GetMovieAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page movie annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**MovieAnnotationResponse**](MovieAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

Read document page annotations. Returns only FreeTextAnnotations, TextAnnotations, other annotations will implemented next releases.


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

<a name="getpagecaretannotations"></a>
# **GetPageCaretAnnotations**
> CaretAnnotationsResponse GetPageCaretAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page caret annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CaretAnnotationsResponse**](CaretAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagecheckboxfields"></a>
# **GetPageCheckBoxFields**
> CheckBoxFieldsResponse GetPageCheckBoxFields (string name, int? pageNumber, string storage = null, string folder = null)

Read document page checkbox fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CheckBoxFieldsResponse**](CheckBoxFieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagecircleannotations"></a>
# **GetPageCircleAnnotations**
> CircleAnnotationsResponse GetPageCircleAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page circle annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CircleAnnotationsResponse**](CircleAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagecomboboxfields"></a>
# **GetPageComboBoxFields**
> ComboBoxFieldsResponse GetPageComboBoxFields (string name, int? pageNumber, string storage = null, string folder = null)

Read document page combobox fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ComboBoxFieldsResponse**](ComboBoxFieldsResponse.md)

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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagefileattachmentannotations"></a>
# **GetPageFileAttachmentAnnotations**
> FileAttachmentAnnotationsResponse GetPageFileAttachmentAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page FileAttachment annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FileAttachmentAnnotationsResponse**](FileAttachmentAnnotationsResponse.md)

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

<a name="getpagehighlightannotations"></a>
# **GetPageHighlightAnnotations**
> HighlightAnnotationsResponse GetPageHighlightAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page highlight annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**HighlightAnnotationsResponse**](HighlightAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageinkannotations"></a>
# **GetPageInkAnnotations**
> InkAnnotationsResponse GetPageInkAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page ink annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**InkAnnotationsResponse**](InkAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagelineannotations"></a>
# **GetPageLineAnnotations**
> LineAnnotationsResponse GetPageLineAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page line annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**LineAnnotationsResponse**](LineAnnotationsResponse.md)

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

<a name="getpagelistboxfields"></a>
# **GetPageListBoxFields**
> ListBoxFieldsResponse GetPageListBoxFields (string name, int? pageNumber, string storage = null, string folder = null)

Read document page listbox fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ListBoxFieldsResponse**](ListBoxFieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagemovieannotations"></a>
# **GetPageMovieAnnotations**
> MovieAnnotationsResponse GetPageMovieAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page movie annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**MovieAnnotationsResponse**](MovieAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagepolylineannotations"></a>
# **GetPagePolyLineAnnotations**
> PolyLineAnnotationsResponse GetPagePolyLineAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page polyline annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PolyLineAnnotationsResponse**](PolyLineAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagepolygonannotations"></a>
# **GetPagePolygonAnnotations**
> PolygonAnnotationsResponse GetPagePolygonAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page polygon annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PolygonAnnotationsResponse**](PolygonAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagepopupannotations"></a>
# **GetPagePopupAnnotations**
> PopupAnnotationsResponse GetPagePopupAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page popup annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PopupAnnotationsResponse**](PopupAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageradiobuttonfields"></a>
# **GetPageRadioButtonFields**
> RadioButtonFieldsResponse GetPageRadioButtonFields (string name, int? pageNumber, string storage = null, string folder = null)

Read document page radiobutton fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**RadioButtonFieldsResponse**](RadioButtonFieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageredactionannotations"></a>
# **GetPageRedactionAnnotations**
> RedactionAnnotationsResponse GetPageRedactionAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page redaction annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**RedactionAnnotationsResponse**](RedactionAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagescreenannotations"></a>
# **GetPageScreenAnnotations**
> ScreenAnnotationsResponse GetPageScreenAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page screen annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ScreenAnnotationsResponse**](ScreenAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagesignaturefields"></a>
# **GetPageSignatureFields**
> SignatureFieldsResponse GetPageSignatureFields (string name, int? pageNumber, string storage = null, string folder = null)

Read document page signature fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SignatureFieldsResponse**](SignatureFieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagesoundannotations"></a>
# **GetPageSoundAnnotations**
> SoundAnnotationsResponse GetPageSoundAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page sound annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SoundAnnotationsResponse**](SoundAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagesquareannotations"></a>
# **GetPageSquareAnnotations**
> SquareAnnotationsResponse GetPageSquareAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page square annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SquareAnnotationsResponse**](SquareAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagesquigglyannotations"></a>
# **GetPageSquigglyAnnotations**
> SquigglyAnnotationsResponse GetPageSquigglyAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page squiggly annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SquigglyAnnotationsResponse**](SquigglyAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagestampannotations"></a>
# **GetPageStampAnnotations**
> StampAnnotationsResponse GetPageStampAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page stamp annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**StampAnnotationsResponse**](StampAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagestamps"></a>
# **GetPageStamps**
> StampsInfoResponse GetPageStamps (string name, int? pageNumber, string storage = null, string folder = null)

Read page document stamps.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**StampsInfoResponse**](StampsInfoResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagestrikeoutannotations"></a>
# **GetPageStrikeOutAnnotations**
> StrikeOutAnnotationsResponse GetPageStrikeOutAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page StrikeOut annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**StrikeOutAnnotationsResponse**](StrikeOutAnnotationsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagetables"></a>
# **GetPageTables**
> TablesRecognizedResponse GetPageTables (string name, int? pageNumber, string storage = null, string folder = null)

Read document page tables.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **pageNumber** | **int?**|  | 
 **storage** | **string**|  | [optional] 
 **folder** | **string**|  | [optional] 

### Return type

[**TablesRecognizedResponse**](TablesRecognizedResponse.md)

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
 **LLX** | **double?**| X-coordinate of lower - left corner. | 
 **LLY** | **double?**| Y - coordinate of lower-left corner. | 
 **URX** | **double?**| X - coordinate of upper-right corner. | 
 **URY** | **double?**| Y - coordinate of upper-right corner. | 
 **format** | **List&lt;string&gt;**| List of formats for search. | [optional] 
 **regex** | **string**| Formats are specified as a regular expression. | [optional] 
 **splitRects** | **bool?**| Split result fragments (default is true). | [optional] [default to true]
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

<a name="getpagetextboxfields"></a>
# **GetPageTextBoxFields**
> TextBoxFieldsResponse GetPageTextBoxFields (string name, int? pageNumber, string storage = null, string folder = null)

Read document page text box fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TextBoxFieldsResponse**](TextBoxFieldsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpageunderlineannotations"></a>
# **GetPageUnderlineAnnotations**
> UnderlineAnnotationsResponse GetPageUnderlineAnnotations (string name, int? pageNumber, string storage = null, string folder = null)

Read document page underline annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**UnderlineAnnotationsResponse**](UnderlineAnnotationsResponse.md)

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
 **contentRecognitionMode** | **string**| Property tunes conversion for this or that desirable method of recognition of content. | [optional] 
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
> System.IO.Stream GetPdfInStorageToHtml (string name, int? additionalMarginWidthInPoints = null, bool? compressSvgGraphicsIfAny = null, bool? convertMarkedContentToLayers = null, string defaultFontName = null, string documentType = null, bool? fixedLayout = null, int? imageResolution = null, int? minimalLineWidth = null, bool? preventGlyphsGrouping = null, bool? splitCssIntoPages = null, bool? splitIntoPages = null, bool? useZOrder = null, string antialiasingProcessing = null, string cssClassNamesPrefix = null, List<int?> explicitListOfSavedPages = null, string fontEncodingStrategy = null, string fontSavingMode = null, string htmlMarkupGenerationMode = null, string lettersPositioningMethod = null, bool? pagesFlowTypeDependsOnViewersScreenSize = null, string partsEmbeddingMode = null, string rasterImagesSavingMode = null, bool? removeEmptyAreasOnTopAndBottom = null, bool? saveShadowedTextsAsTransparentTexts = null, bool? saveTransparentTexts = null, string specialFolderForAllImages = null, string specialFolderForSvgImages = null, bool? trySaveTextUnderliningAndStrikeoutingInCss = null, string folder = null, string storage = null, bool? flowLayoutParagraphFullWidth = null)

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
 **flowLayoutParagraphFullWidth** | **bool?**| This attribute specifies full width paragraph text for Flow mode, FixedLayout &#x3D; false. | [optional] 

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

<a name="getpdfinstoragetoxlsx"></a>
# **GetPdfInStorageToXlsx**
> System.IO.Stream GetPdfInStorageToXlsx (string name, bool? insertBlankColumnAtFirst = null, bool? minimizeTheNumberOfWorksheets = null, double? scaleFactor = null, bool? uniformWorksheets = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to XLSX format and returns resulting file in response content


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

<a name="getpolylineannotation"></a>
# **GetPolyLineAnnotation**
> PolyLineAnnotationResponse GetPolyLineAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page polyline annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PolyLineAnnotationResponse**](PolyLineAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpolygonannotation"></a>
# **GetPolygonAnnotation**
> PolygonAnnotationResponse GetPolygonAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page polygon annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PolygonAnnotationResponse**](PolygonAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpopupannotation"></a>
# **GetPopupAnnotation**
> PopupAnnotationResponse GetPopupAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page popup annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PopupAnnotationResponse**](PopupAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

<a name="getradiobuttonfield"></a>
# **GetRadioButtonField**
> RadioButtonFieldResponse GetRadioButtonField (string name, string fieldName, string storage = null, string folder = null)

Read document RadioButton field by name.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**RadioButtonFieldResponse**](RadioButtonFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getredactionannotation"></a>
# **GetRedactionAnnotation**
> RedactionAnnotationResponse GetRedactionAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page redaction annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**RedactionAnnotationResponse**](RedactionAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscreenannotation"></a>
# **GetScreenAnnotation**
> ScreenAnnotationResponse GetScreenAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page screen annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ScreenAnnotationResponse**](ScreenAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscreenannotationdata"></a>
# **GetScreenAnnotationData**
> System.IO.Stream GetScreenAnnotationData (string name, string annotationId, string storage = null, string folder = null)

Read document page screen annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsignaturefield"></a>
# **GetSignatureField**
> SignatureFieldResponse GetSignatureField (string name, string fieldName, string storage = null, string folder = null)

Read document signature field by name.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SignatureFieldResponse**](SignatureFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsoundannotation"></a>
# **GetSoundAnnotation**
> SoundAnnotationResponse GetSoundAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page sound annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SoundAnnotationResponse**](SoundAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsoundannotationdata"></a>
# **GetSoundAnnotationData**
> System.IO.Stream GetSoundAnnotationData (string name, string annotationId, string storage = null, string folder = null)

Read document page sound annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsquareannotation"></a>
# **GetSquareAnnotation**
> SquareAnnotationResponse GetSquareAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page square annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SquareAnnotationResponse**](SquareAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsquigglyannotation"></a>
# **GetSquigglyAnnotation**
> SquigglyAnnotationResponse GetSquigglyAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page squiggly annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SquigglyAnnotationResponse**](SquigglyAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstampannotation"></a>
# **GetStampAnnotation**
> StampAnnotationResponse GetStampAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page stamp annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**StampAnnotationResponse**](StampAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstampannotationdata"></a>
# **GetStampAnnotationData**
> System.IO.Stream GetStampAnnotationData (string name, string annotationId, string storage = null, string folder = null)

Read document page stamp annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstrikeoutannotation"></a>
# **GetStrikeOutAnnotation**
> StrikeOutAnnotationResponse GetStrikeOutAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page StrikeOut annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**StrikeOutAnnotationResponse**](StrikeOutAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

<a name="gettable"></a>
# **GetTable**
> TableRecognizedResponse GetTable (string name, string tableId, string storage = null, string folder = null)

Read document page table by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **tableId** | **string**| The table ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TableRecognizedResponse**](TableRecognizedResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettext"></a>
# **GetText**
> TextRectsResponse GetText (string name, double? LLX, double? LLY, double? URX, double? URY, List<string> format = null, string regex = null, bool? splitRects = null, string folder = null, string storage = null)

Read document text.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **LLX** | **double?**| X-coordinate of lower - left corner. | 
 **LLY** | **double?**| Y - coordinate of lower-left corner. | 
 **URX** | **double?**| X - coordinate of upper-right corner. | 
 **URY** | **double?**| Y - coordinate of upper-right corner. | 
 **format** | **List&lt;string&gt;**| List of formats for search. | [optional] 
 **regex** | **string**| Formats are specified as a regular expression. | [optional] 
 **splitRects** | **bool?**| Split result fragments (default is true). | [optional] [default to true]
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

<a name="gettextboxfield"></a>
# **GetTextBoxField**
> TextBoxFieldResponse GetTextBoxField (string name, string fieldName, string storage = null, string folder = null)

Read document text box field by name.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TextBoxFieldResponse**](TextBoxFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getunderlineannotation"></a>
# **GetUnderlineAnnotation**
> UnderlineAnnotationResponse GetUnderlineAnnotation (string name, string annotationId, string storage = null, string folder = null)

Read document page underline annotation by ID.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**UnderlineAnnotationResponse**](UnderlineAnnotationResponse.md)

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

<a name="movefile"></a>
# **MoveFile**
> void MoveFile (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)

Move file


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/src.ext&#39; | 
 **destPath** | **string**| Destination file path e.g. &#39;/dest.ext&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to move | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movefolder"></a>
# **MoveFolder**
> void MoveFolder (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)

Move folder


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Folder path to move e.g. &#39;/folder&#39; | 
 **destPath** | **string**| Destination folder path to move to e.g &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="objectexists"></a>
# **ObjectExists**
> ObjectExist ObjectExists (string path, string storageName = null, string versionId = null)

Check if file or folder exists


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID | [optional] 

### Return type

[**ObjectExist**](ObjectExist.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postappenddocument"></a>
# **PostAppendDocument**
> DocumentResponse PostAppendDocument (string name, string appendFile, int? startPage = null, int? endPage = null, string storage = null, string folder = null)

Append document to existing one.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The original document name. | 
 **appendFile** | **string**| Append file server path. | 
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

<a name="postbookmark"></a>
# **PostBookmark**
> BookmarksResponse PostBookmark (string name, string bookmarkPath, List<Bookmark> bookmarks, string folder = null, string storage = null)

Add document bookmarks.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **bookmarkPath** | **string**| The bookmark path. | 
 **bookmarks** | [**List&lt;Bookmark&gt;**](Bookmark.md)| The array of bookmark. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**BookmarksResponse**](BookmarksResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postchangepassworddocumentinstorage"></a>
# **PostChangePasswordDocumentInStorage**
> AsposeResponse PostChangePasswordDocumentInStorage (string name, string ownerPassword, string newUserPassword, string newOwnerPassword, string storage = null, string folder = null)

Change document password in storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **ownerPassword** | **string**| Owner password (encrypted Base64). | 
 **newUserPassword** | **string**| New user password (encrypted Base64). | 
 **newOwnerPassword** | **string**| New owner password (encrypted Base64). | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcheckboxfields"></a>
# **PostCheckBoxFields**
> AsposeResponse PostCheckBoxFields (string name, List<CheckBoxField> fields, string storage = null, string folder = null)

Add document checkbox fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fields** | [**List&lt;CheckBoxField&gt;**](CheckBoxField.md)| The array of field. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcomboboxfields"></a>
# **PostComboBoxFields**
> AsposeResponse PostComboBoxFields (string name, List<ComboBoxField> fields, string storage = null, string folder = null)

Add document combobox fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fields** | [**List&lt;ComboBoxField&gt;**](ComboBoxField.md)| The array of field. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcreatedocument"></a>
# **PostCreateDocument**
> DocumentResponse PostCreateDocument (string name, DocumentConfig documentConfig, string storage = null, string folder = null)

Create empty document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The new document name. | 
 **documentConfig** | [**DocumentConfig**](DocumentConfig.md)| The document config for new document. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The new document folder. | [optional] 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcreatefield"></a>
# **PostCreateField**
> AsposeResponse PostCreateField (string name, int? page, Field field, string storage = null, string folder = null)

Create field.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **page** | **int?**| Document page number. | 
 **field** | [**Field**](Field.md)| Field with the field data. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdecryptdocumentinstorage"></a>
# **PostDecryptDocumentInStorage**
> AsposeResponse PostDecryptDocumentInStorage (string name, string password, string storage = null, string folder = null)

Decrypt document in storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **password** | **string**| The password (encrypted Base64). | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocumentimagefooter"></a>
# **PostDocumentImageFooter**
> AsposeResponse PostDocumentImageFooter (string name, ImageFooter imageFooter, int? startPageNumber = null, int? endPageNumber = null, string storage = null, string folder = null)

Add document image footer.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageFooter** | [**ImageFooter**](ImageFooter.md)| The image footer. | 
 **startPageNumber** | **int?**| The start page number. | [optional] 
 **endPageNumber** | **int?**| The end page number. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocumentimageheader"></a>
# **PostDocumentImageHeader**
> AsposeResponse PostDocumentImageHeader (string name, ImageHeader imageHeader, int? startPageNumber = null, int? endPageNumber = null, string storage = null, string folder = null)

Add document image header.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **imageHeader** | [**ImageHeader**](ImageHeader.md)| The image header. | 
 **startPageNumber** | **int?**| The start page number. | [optional] 
 **endPageNumber** | **int?**| The end page number. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocumentpagenumberstamps"></a>
# **PostDocumentPageNumberStamps**
> AsposeResponse PostDocumentPageNumberStamps (string name, PageNumberStamp stamp, int? startPageNumber = null, int? endPageNumber = null, string storage = null, string folder = null)

Add document page number stamps.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **stamp** | [**PageNumberStamp**](PageNumberStamp.md)| The stamp. | 
 **startPageNumber** | **int?**| The start page number. | [optional] 
 **endPageNumber** | **int?**| The end page number. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocumenttextfooter"></a>
# **PostDocumentTextFooter**
> AsposeResponse PostDocumentTextFooter (string name, TextFooter textFooter, int? startPageNumber = null, int? endPageNumber = null, string storage = null, string folder = null)

Add document text footer.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **textFooter** | [**TextFooter**](TextFooter.md)| The text footer. | 
 **startPageNumber** | **int?**| The start page number. | [optional] 
 **endPageNumber** | **int?**| The end page number. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocumenttextheader"></a>
# **PostDocumentTextHeader**
> AsposeResponse PostDocumentTextHeader (string name, TextHeader textHeader, int? startPageNumber = null, int? endPageNumber = null, string storage = null, string folder = null)

Add document text header.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **textHeader** | [**TextHeader**](TextHeader.md)| The text header. | 
 **startPageNumber** | **int?**| The start page number. | [optional] 
 **endPageNumber** | **int?**| The end page number. | [optional] 
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

<a name="postencryptdocumentinstorage"></a>
# **PostEncryptDocumentInStorage**
> AsposeResponse PostEncryptDocumentInStorage (string name, string userPassword, string ownerPassword, string cryptoAlgorithm, List<PermissionsFlags> permissionsFlags = null, bool? usePdf20 = null, string storage = null, string folder = null)

Encrypt document in storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document name. | 
 **userPassword** | **string**| User password (encrypted Base64). | 
 **ownerPassword** | **string**| Owner password (encrypted Base64). | 
 **cryptoAlgorithm** | **string**| Cryptographic algorithm, see CryptoAlgorithm for details. | 
 **permissionsFlags** | [**List&lt;PermissionsFlags&gt;**](PermissionsFlags.md)| Array of document permissions, see PermissionsFlags for details. | [optional] 
 **usePdf20** | **bool?**| Support for revision 6 (Extension 8). | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postflattendocument"></a>
# **PostFlattenDocument**
> AsposeResponse PostFlattenDocument (string name, bool? updateAppearances = null, bool? callEvents = null, bool? hideButtons = null, string storage = null, string folder = null)

Flatten the document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **updateAppearances** | **bool?**| If set, all field appearances will be regenerated before flattening. This option may help if field is incorrectly flattened. This option may decrease performance.. | [optional] 
 **callEvents** | **bool?**| If set, formatting and other JavaScript events will be called. | [optional] 
 **hideButtons** | **bool?**| If set, buttons will be removed from flattened document. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postimportfieldsfromfdf"></a>
# **PostImportFieldsFromFdf**
> AsposeResponse PostImportFieldsFromFdf (string name, string storage = null, string folder = null, System.IO.Stream fdfData = null)

Update fields from FDF file in request.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **fdfData** | **System.IO.Stream**| Fdf file. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postimportfieldsfromxfdf"></a>
# **PostImportFieldsFromXfdf**
> AsposeResponse PostImportFieldsFromXfdf (string name, string storage = null, string folder = null, System.IO.Stream xfdfData = null)

Update fields from XFDF file in request.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **xfdfData** | **System.IO.Stream**| Xfdf file. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postimportfieldsfromxml"></a>
# **PostImportFieldsFromXml**
> AsposeResponse PostImportFieldsFromXml (string name, string storage = null, string folder = null, System.IO.Stream xmlData = null)

Update fields from XML file in request.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **xmlData** | **System.IO.Stream**| Xml file. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
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

<a name="postlistboxfields"></a>
# **PostListBoxFields**
> AsposeResponse PostListBoxFields (string name, List<ListBoxField> fields, string storage = null, string folder = null)

Add document listbox fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fields** | [**List&lt;ListBoxField&gt;**](ListBoxField.md)| The array of field. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
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
> AsposeResponse PostOptimizeDocument (string name, OptimizeOptions options, string storage = null, string folder = null)

Optimize document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **options** | [**OptimizeOptions**](OptimizeOptions.md)| The optimization options. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagecaretannotations"></a>
# **PostPageCaretAnnotations**
> AsposeResponse PostPageCaretAnnotations (string name, int? pageNumber, List<CaretAnnotation> annotations, string storage = null, string folder = null)

Add document page caret annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;CaretAnnotation&gt;**](CaretAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagecertify"></a>
# **PostPageCertify**
> AsposeResponse PostPageCertify (string name, int? pageNumber, Signature sign, string docMdpAccessPermissionType, string storage = null, string folder = null)

Certify document page.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **sign** | [**Signature**](Signature.md)| Signature object containing signature data. | 
 **docMdpAccessPermissionType** | **string**| The access permissions granted for this document. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagecircleannotations"></a>
# **PostPageCircleAnnotations**
> AsposeResponse PostPageCircleAnnotations (string name, int? pageNumber, List<CircleAnnotation> annotations, string storage = null, string folder = null)

Add document page circle annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;CircleAnnotation&gt;**](CircleAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagefileattachmentannotations"></a>
# **PostPageFileAttachmentAnnotations**
> AsposeResponse PostPageFileAttachmentAnnotations (string name, int? pageNumber, List<FileAttachmentAnnotation> annotations, string storage = null, string folder = null)

Add document page FileAttachment annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;FileAttachmentAnnotation&gt;**](FileAttachmentAnnotation.md)| Annotation. | 
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

<a name="postpagehighlightannotations"></a>
# **PostPageHighlightAnnotations**
> AsposeResponse PostPageHighlightAnnotations (string name, int? pageNumber, List<HighlightAnnotation> annotations, string storage = null, string folder = null)

Add document page highlight annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;HighlightAnnotation&gt;**](HighlightAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpageimagestamps"></a>
# **PostPageImageStamps**
> AsposeResponse PostPageImageStamps (string name, int? pageNumber, List<ImageStamp> stamps, string storage = null, string folder = null)

Add document page image stamps.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **stamps** | [**List&lt;ImageStamp&gt;**](ImageStamp.md)| The array of stamp. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpageinkannotations"></a>
# **PostPageInkAnnotations**
> AsposeResponse PostPageInkAnnotations (string name, int? pageNumber, List<InkAnnotation> annotations, string storage = null, string folder = null)

Add document page ink annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;InkAnnotation&gt;**](InkAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagelineannotations"></a>
# **PostPageLineAnnotations**
> AsposeResponse PostPageLineAnnotations (string name, int? pageNumber, List<LineAnnotation> annotations, string storage = null, string folder = null)

Add document page line annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;LineAnnotation&gt;**](LineAnnotation.md)| The array of annotation. | 
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

<a name="postpagemovieannotations"></a>
# **PostPageMovieAnnotations**
> AsposeResponse PostPageMovieAnnotations (string name, int? pageNumber, List<MovieAnnotation> annotations, string storage = null, string folder = null)

Add document page movie annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;MovieAnnotation&gt;**](MovieAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagepdfpagestamps"></a>
# **PostPagePdfPageStamps**
> AsposeResponse PostPagePdfPageStamps (string name, int? pageNumber, List<PdfPageStamp> stamps, string storage = null, string folder = null)

Add document pdf page stamps.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **stamps** | [**List&lt;PdfPageStamp&gt;**](PdfPageStamp.md)| The array of stamp. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagepolylineannotations"></a>
# **PostPagePolyLineAnnotations**
> AsposeResponse PostPagePolyLineAnnotations (string name, int? pageNumber, List<PolyLineAnnotation> annotations, string storage = null, string folder = null)

Add document page polyline annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;PolyLineAnnotation&gt;**](PolyLineAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagepolygonannotations"></a>
# **PostPagePolygonAnnotations**
> AsposeResponse PostPagePolygonAnnotations (string name, int? pageNumber, List<PolygonAnnotation> annotations, string storage = null, string folder = null)

Add document page polygon annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;PolygonAnnotation&gt;**](PolygonAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpageredactionannotations"></a>
# **PostPageRedactionAnnotations**
> AsposeResponse PostPageRedactionAnnotations (string name, int? pageNumber, List<RedactionAnnotation> annotations, string storage = null, string folder = null)

Add document page redaction annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;RedactionAnnotation&gt;**](RedactionAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagescreenannotations"></a>
# **PostPageScreenAnnotations**
> AsposeResponse PostPageScreenAnnotations (string name, int? pageNumber, List<ScreenAnnotation> annotations, string storage = null, string folder = null)

Add document page screen annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;ScreenAnnotation&gt;**](ScreenAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagesoundannotations"></a>
# **PostPageSoundAnnotations**
> AsposeResponse PostPageSoundAnnotations (string name, int? pageNumber, List<SoundAnnotation> annotations, string storage = null, string folder = null)

Add document page sound annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;SoundAnnotation&gt;**](SoundAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagesquareannotations"></a>
# **PostPageSquareAnnotations**
> AsposeResponse PostPageSquareAnnotations (string name, int? pageNumber, List<SquareAnnotation> annotations, string storage = null, string folder = null)

Add document page square annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;SquareAnnotation&gt;**](SquareAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagesquigglyannotations"></a>
# **PostPageSquigglyAnnotations**
> AsposeResponse PostPageSquigglyAnnotations (string name, int? pageNumber, List<SquigglyAnnotation> annotations, string storage = null, string folder = null)

Add document page squiggly annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;SquigglyAnnotation&gt;**](SquigglyAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagestampannotations"></a>
# **PostPageStampAnnotations**
> AsposeResponse PostPageStampAnnotations (string name, int? pageNumber, List<StampAnnotation> annotations, string storage = null, string folder = null)

Add document page stamp annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;StampAnnotation&gt;**](StampAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagestrikeoutannotations"></a>
# **PostPageStrikeOutAnnotations**
> AsposeResponse PostPageStrikeOutAnnotations (string name, int? pageNumber, List<StrikeOutAnnotation> annotations, string storage = null, string folder = null)

Add document page StrikeOut annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;StrikeOutAnnotation&gt;**](StrikeOutAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpagetables"></a>
# **PostPageTables**
> AsposeResponse PostPageTables (string name, int? pageNumber, List<Table> tables, string storage = null, string folder = null)

Add document page tables.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **tables** | [**List&lt;Table&gt;**](Table.md)| The array of table. | 
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

<a name="postpagetextstamps"></a>
# **PostPageTextStamps**
> AsposeResponse PostPageTextStamps (string name, int? pageNumber, List<TextStamp> stamps, string storage = null, string folder = null)

Add document page text stamps.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **stamps** | [**List&lt;TextStamp&gt;**](TextStamp.md)| The array of stamp. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpageunderlineannotations"></a>
# **PostPageUnderlineAnnotations**
> AsposeResponse PostPageUnderlineAnnotations (string name, int? pageNumber, List<UnderlineAnnotation> annotations, string storage = null, string folder = null)

Add document page underline annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **annotations** | [**List&lt;UnderlineAnnotation&gt;**](UnderlineAnnotation.md)| The array of annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpopupannotation"></a>
# **PostPopupAnnotation**
> AsposeResponse PostPopupAnnotation (string name, string annotationId, PopupAnnotation annotation, string storage = null, string folder = null)

Add document popup annotations.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The parent annotation ID. | 
 **annotation** | [**PopupAnnotation**](PopupAnnotation.md)| The annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postradiobuttonfields"></a>
# **PostRadioButtonFields**
> AsposeResponse PostRadioButtonFields (string name, List<RadioButtonField> fields, string storage = null, string folder = null)

Add document RadioButton fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fields** | [**List&lt;RadioButtonField&gt;**](RadioButtonField.md)| The array of field. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsigndocument"></a>
# **PostSignDocument**
> AsposeResponse PostSignDocument (string name, Signature sign, string storage = null, string folder = null)

Sign document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **sign** | [**Signature**](Signature.md)| Signature object containing signature data. | 
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
> AsposeResponse PostSignPage (string name, int? pageNumber, Signature sign, string storage = null, string folder = null)

Sign page.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| The page number. | 
 **sign** | [**Signature**](Signature.md)| Signature object containing signature data. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsignaturefield"></a>
# **PostSignatureField**
> AsposeResponse PostSignatureField (string name, SignatureField field, string storage = null, string folder = null)

Add document signature field.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **field** | [**SignatureField**](SignatureField.md)| The field. | 
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

<a name="posttextboxfields"></a>
# **PostTextBoxFields**
> AsposeResponse PostTextBoxFields (string name, List<TextBoxField> fields, string storage = null, string folder = null)

Add document text box fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fields** | [**List&lt;TextBoxField&gt;**](TextBoxField.md)| The array of field. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

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
> AsposeResponse PutAddText (string name, int? pageNumber, Paragraph paragraph, string folder = null, string storage = null)

Add text to PDF document page.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **pageNumber** | **int?**| Number of page (starting from 1). | 
 **paragraph** | [**Paragraph**](Paragraph.md)| Paragraph data. | 
 **folder** | **string**| Document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putannotationsflatten"></a>
# **PutAnnotationsFlatten**
> AsposeResponse PutAnnotationsFlatten (string name, int? startPage = null, int? endPage = null, List<AnnotationType> annotationTypes = null, string storage = null, string folder = null)

Flattens the annotations of the specified types


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **startPage** | **int?**| The start page number. | [optional] 
 **endPage** | **int?**| The end page number. | [optional] 
 **annotationTypes** | [**List&lt;AnnotationType&gt;**](AnnotationType.md)| Array of annotation types. | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbookmark"></a>
# **PutBookmark**
> BookmarkResponse PutBookmark (string name, string bookmarkPath, Bookmark bookmark, string folder = null, string storage = null)

Update document bookmark.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **bookmarkPath** | **string**| The bookmark path. | 
 **bookmark** | [**Bookmark**](Bookmark.md)| The bookmark. | 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| The document storage. | [optional] 

### Return type

[**BookmarkResponse**](BookmarkResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcaretannotation"></a>
# **PutCaretAnnotation**
> CaretAnnotationResponse PutCaretAnnotation (string name, string annotationId, CaretAnnotation annotation, string storage = null, string folder = null)

Replace document caret annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**CaretAnnotation**](CaretAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CaretAnnotationResponse**](CaretAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putchangepassworddocument"></a>
# **PutChangePasswordDocument**
> AsposeResponse PutChangePasswordDocument (string outPath, string ownerPassword, string newUserPassword, string newOwnerPassword, string storage = null, System.IO.Stream file = null)

Change document password from content.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.doc) | 
 **ownerPassword** | **string**| Owner password (encrypted Base64). | 
 **newUserPassword** | **string**| New user password (encrypted Base64). | 
 **newOwnerPassword** | **string**| New owner password (encrypted Base64). | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be changed password. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcheckboxfield"></a>
# **PutCheckBoxField**
> CheckBoxFieldResponse PutCheckBoxField (string name, string fieldName, CheckBoxField field, string storage = null, string folder = null)

Replace document checkbox field


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **field** | [**CheckBoxField**](CheckBoxField.md)| The field. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CheckBoxFieldResponse**](CheckBoxFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcircleannotation"></a>
# **PutCircleAnnotation**
> CircleAnnotationResponse PutCircleAnnotation (string name, string annotationId, CircleAnnotation annotation, string storage = null, string folder = null)

Replace document circle annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**CircleAnnotation**](CircleAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**CircleAnnotationResponse**](CircleAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcomboboxfield"></a>
# **PutComboBoxField**
> ComboBoxFieldResponse PutComboBoxField (string name, string fieldName, ComboBoxField field, string storage = null, string folder = null)

Replace document combobox field


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **field** | [**ComboBoxField**](ComboBoxField.md)| The field. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ComboBoxFieldResponse**](ComboBoxFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="putdecryptdocument"></a>
# **PutDecryptDocument**
> AsposeResponse PutDecryptDocument (string outPath, string password, string storage = null, System.IO.Stream file = null)

Decrypt document from content.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.doc) | 
 **password** | **string**| The password (encrypted Base64). | 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be derypted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdocumentdisplayproperties"></a>
# **PutDocumentDisplayProperties**
> DisplayPropertiesResponse PutDocumentDisplayProperties (string name, DisplayProperties displayProperties, string storage = null, string folder = null)

Update document display properties.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **displayProperties** | [**DisplayProperties**](DisplayProperties.md)| The display properties. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**DisplayPropertiesResponse**](DisplayPropertiesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putencryptdocument"></a>
# **PutEncryptDocument**
> AsposeResponse PutEncryptDocument (string outPath, string userPassword, string ownerPassword, string cryptoAlgorithm, List<PermissionsFlags> permissionsFlags = null, bool? usePdf20 = null, string storage = null, System.IO.Stream file = null)

Encrypt document from content.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.doc) | 
 **userPassword** | **string**| User password (encrypted Base64). | 
 **ownerPassword** | **string**| Owner password (encrypted Base64). | 
 **cryptoAlgorithm** | **string**| Cryptographic algorithm, see CryptoAlgorithm for details. | 
 **permissionsFlags** | [**List&lt;PermissionsFlags&gt;**](PermissionsFlags.md)| Array of document permissions, see PermissionsFlags for details. | [optional] 
 **usePdf20** | **bool?**| Support for revision 6 (Extension 8). | [optional] 
 **storage** | **string**| The document storage. | [optional] 
 **file** | **System.IO.Stream**| A file to be encrypted. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
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

<a name="putexportfieldsfrompdftofdfinstorage"></a>
# **PutExportFieldsFromPdfToFdfInStorage**
> AsposeResponse PutExportFieldsFromPdfToFdfInStorage (string name, string fdfOutputFilePath, string storage = null, string folder = null)

Export fields from from PDF in storage to FDF file in storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fdfOutputFilePath** | **string**| The output Fdf file path. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putexportfieldsfrompdftoxfdfinstorage"></a>
# **PutExportFieldsFromPdfToXfdfInStorage**
> AsposeResponse PutExportFieldsFromPdfToXfdfInStorage (string name, string xfdfOutputFilePath, string storage = null, string folder = null)

Export fields from from PDF in storage to XFDF file in storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **xfdfOutputFilePath** | **string**| The output xfdf file path. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putexportfieldsfrompdftoxmlinstorage"></a>
# **PutExportFieldsFromPdfToXmlInStorage**
> AsposeResponse PutExportFieldsFromPdfToXmlInStorage (string name, string xmlOutputFilePath, string storage = null, string folder = null)

Export fields from from PDF in storage to XML file in storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **xmlOutputFilePath** | **string**| The output xml file path. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

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

<a name="putfileattachmentannotation"></a>
# **PutFileAttachmentAnnotation**
> FileAttachmentAnnotationResponse PutFileAttachmentAnnotation (string name, string annotationId, FileAttachmentAnnotation annotation, string storage = null, string folder = null)

Replace document FileAttachment annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**FileAttachmentAnnotation**](FileAttachmentAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**FileAttachmentAnnotationResponse**](FileAttachmentAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfileattachmentannotationdataextract"></a>
# **PutFileAttachmentAnnotationDataExtract**
> AsposeResponse PutFileAttachmentAnnotationDataExtract (string name, string annotationId, string outFolder = null, string storage = null, string folder = null)

Extract document FileAttachment annotation content to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **outFolder** | **string**| The output folder. | [optional] 
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

<a name="puthighlightannotation"></a>
# **PutHighlightAnnotation**
> HighlightAnnotationResponse PutHighlightAnnotation (string name, string annotationId, HighlightAnnotation annotation, string storage = null, string folder = null)

Replace document highlight annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**HighlightAnnotation**](HighlightAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**HighlightAnnotationResponse**](HighlightAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puthtmlinstoragetopdf"></a>
# **PutHtmlInStorageToPdf**
> AsposeResponse PutHtmlInStorageToPdf (string name, string srcPath, string htmlFileName = null, double? height = null, double? width = null, bool? isLandscape = null, double? marginLeft = null, double? marginBottom = null, double? marginRight = null, double? marginTop = null, string dstFolder = null, string storage = null)

Convert HTML file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.zip) | 
 **htmlFileName** | **string**| Name of HTML file in ZIP. | [optional] 
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **imageTemplates** | [**ImageTemplatesRequest**](ImageTemplatesRequest.md)| ImageTemplatesRequestImage templates | 
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **storage** | **string**| The document storage. | [optional] 
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **destFolder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimportfieldsfromfdfinstorage"></a>
# **PutImportFieldsFromFdfInStorage**
> AsposeResponse PutImportFieldsFromFdfInStorage (string name, string fdfFilePath, string storage = null, string folder = null)

Update fields from FDF file in storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fdfFilePath** | **string**| The Fdf file path. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimportfieldsfromxfdfinstorage"></a>
# **PutImportFieldsFromXfdfInStorage**
> AsposeResponse PutImportFieldsFromXfdfInStorage (string name, string xfdfFilePath, string storage = null, string folder = null)

Update fields from XFDF file in storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **xfdfFilePath** | **string**| The XFDF file path. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putimportfieldsfromxmlinstorage"></a>
# **PutImportFieldsFromXmlInStorage**
> AsposeResponse PutImportFieldsFromXmlInStorage (string name, string xmlFilePath, string storage = null, string folder = null)

Update fields from XML file in storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **xmlFilePath** | **string**| Full source filename (ex. /folder1/folder2/template.xml) | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putinkannotation"></a>
# **PutInkAnnotation**
> InkAnnotationResponse PutInkAnnotation (string name, string annotationId, InkAnnotation annotation, string storage = null, string folder = null)

Replace document ink annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**InkAnnotation**](InkAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**InkAnnotationResponse**](InkAnnotationResponse.md)

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

<a name="putlineannotation"></a>
# **PutLineAnnotation**
> LineAnnotationResponse PutLineAnnotation (string name, string annotationId, LineAnnotation annotation, string storage = null, string folder = null)

Replace document line annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**LineAnnotation**](LineAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**LineAnnotationResponse**](LineAnnotationResponse.md)

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

<a name="putlistboxfield"></a>
# **PutListBoxField**
> ListBoxFieldResponse PutListBoxField (string name, string fieldName, ListBoxField field, string storage = null, string folder = null)

Replace document listbox field


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **field** | [**ListBoxField**](ListBoxField.md)| The field. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ListBoxFieldResponse**](ListBoxFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putmarkdowninstoragetopdf"></a>
# **PutMarkdownInStorageToPdf**
> AsposeResponse PutMarkdownInStorageToPdf (string name, string srcPath, string storage = null, string dstFolder = null)

Convert MD file (located on storage) to PDF format and upload resulting file to storage. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **srcPath** | **string**| Full source filename (ex. /folder1/folder2/template.md) | 
 **storage** | **string**| The document storage. | [optional] 
 **dstFolder** | **string**| The destination document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putmergedocuments"></a>
# **PutMergeDocuments**
> DocumentResponse PutMergeDocuments (string name, MergeDocuments mergeDocuments, string storage = null, string folder = null)

Merge a list of documents.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Resulting documen name. | 
 **mergeDocuments** | [**MergeDocuments**](MergeDocuments.md)| MergeDocuments with a list of documents. | 
 **storage** | **string**| Resulting document storage. | [optional] 
 **folder** | **string**| Resulting document folder. | [optional] 

### Return type

[**DocumentResponse**](DocumentResponse.md)

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

<a name="putmovieannotation"></a>
# **PutMovieAnnotation**
> MovieAnnotationResponse PutMovieAnnotation (string name, string annotationId, MovieAnnotation annotation, string storage = null, string folder = null)

Replace document movie annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**MovieAnnotation**](MovieAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**MovieAnnotationResponse**](MovieAnnotationResponse.md)

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
 **stamp** | [**Stamp**](Stamp.md)| Stamp with data. | 
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **width** | **int?**| The converted image width. | [optional] [default to 0]
 **height** | **int?**| The converted image height. | [optional] [default to 0]
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
 **contentRecognitionMode** | **string**| Property tunes conversion for this or that desirable method of recognition of content. | [optional] 
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
> AsposeResponse PutPdfInRequestToHtml (string outPath, int? additionalMarginWidthInPoints = null, bool? compressSvgGraphicsIfAny = null, bool? convertMarkedContentToLayers = null, string defaultFontName = null, string documentType = null, bool? fixedLayout = null, int? imageResolution = null, int? minimalLineWidth = null, bool? preventGlyphsGrouping = null, bool? splitCssIntoPages = null, bool? splitIntoPages = null, bool? useZOrder = null, string antialiasingProcessing = null, string cssClassNamesPrefix = null, List<int?> explicitListOfSavedPages = null, string fontEncodingStrategy = null, string fontSavingMode = null, string htmlMarkupGenerationMode = null, string lettersPositioningMethod = null, bool? pagesFlowTypeDependsOnViewersScreenSize = null, string partsEmbeddingMode = null, string rasterImagesSavingMode = null, bool? removeEmptyAreasOnTopAndBottom = null, bool? saveShadowedTextsAsTransparentTexts = null, bool? saveTransparentTexts = null, string specialFolderForAllImages = null, string specialFolderForSvgImages = null, bool? trySaveTextUnderliningAndStrikeoutingInCss = null, string storage = null, bool? flowLayoutParagraphFullWidth = null, System.IO.Stream file = null)

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
 **flowLayoutParagraphFullWidth** | **bool?**| This attribute specifies full width paragraph text for Flow mode, FixedLayout &#x3D; false. | [optional] 
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

<a name="putpdfinrequesttoxlsx"></a>
# **PutPdfInRequestToXlsx**
> AsposeResponse PutPdfInRequestToXlsx (string outPath, bool? insertBlankColumnAtFirst = null, bool? minimizeTheNumberOfWorksheets = null, double? scaleFactor = null, bool? uniformWorksheets = null, string storage = null, System.IO.Stream file = null)

Converts PDF document (in request content) to XLSX format and uploads resulting file to storage.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xlsx) | 
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
 **contentRecognitionMode** | **string**| Property tunes conversion for this or that desirable method of recognition of content. | [optional] 
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
> AsposeResponse PutPdfInStorageToHtml (string name, string outPath, int? additionalMarginWidthInPoints = null, bool? compressSvgGraphicsIfAny = null, bool? convertMarkedContentToLayers = null, string defaultFontName = null, string documentType = null, bool? fixedLayout = null, int? imageResolution = null, int? minimalLineWidth = null, bool? preventGlyphsGrouping = null, bool? splitCssIntoPages = null, bool? splitIntoPages = null, bool? useZOrder = null, string antialiasingProcessing = null, string cssClassNamesPrefix = null, List<int?> explicitListOfSavedPages = null, string fontEncodingStrategy = null, string fontSavingMode = null, string htmlMarkupGenerationMode = null, string lettersPositioningMethod = null, bool? pagesFlowTypeDependsOnViewersScreenSize = null, string partsEmbeddingMode = null, string rasterImagesSavingMode = null, bool? removeEmptyAreasOnTopAndBottom = null, bool? saveShadowedTextsAsTransparentTexts = null, bool? saveTransparentTexts = null, string specialFolderForAllImages = null, string specialFolderForSvgImages = null, bool? trySaveTextUnderliningAndStrikeoutingInCss = null, string folder = null, string storage = null, bool? flowLayoutParagraphFullWidth = null)

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
 **flowLayoutParagraphFullWidth** | **bool?**| This attribute specifies full width paragraph text for Flow mode, FixedLayout &#x3D; false. | [optional] 

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

<a name="putpdfinstoragetoxlsx"></a>
# **PutPdfInStorageToXlsx**
> AsposeResponse PutPdfInStorageToXlsx (string name, string outPath, bool? insertBlankColumnAtFirst = null, bool? minimizeTheNumberOfWorksheets = null, double? scaleFactor = null, bool? uniformWorksheets = null, string folder = null, string storage = null)

Converts PDF document (located on storage) to XLSX format and uploads resulting file to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **outPath** | **string**| Full resulting filename (ex. /folder1/folder2/result.xlsx) | 
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

<a name="putpolylineannotation"></a>
# **PutPolyLineAnnotation**
> PolyLineAnnotationResponse PutPolyLineAnnotation (string name, string annotationId, PolyLineAnnotation annotation, string storage = null, string folder = null)

Replace document polyline annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**PolyLineAnnotation**](PolyLineAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PolyLineAnnotationResponse**](PolyLineAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpolygonannotation"></a>
# **PutPolygonAnnotation**
> PolygonAnnotationResponse PutPolygonAnnotation (string name, string annotationId, PolygonAnnotation annotation, string storage = null, string folder = null)

Replace document polygon annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**PolygonAnnotation**](PolygonAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PolygonAnnotationResponse**](PolygonAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpopupannotation"></a>
# **PutPopupAnnotation**
> PopupAnnotationResponse PutPopupAnnotation (string name, string annotationId, PopupAnnotation annotation, string storage = null, string folder = null)

Replace document popup annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**PopupAnnotation**](PopupAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**PopupAnnotationResponse**](PopupAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putprivileges"></a>
# **PutPrivileges**
> AsposeResponse PutPrivileges (string name, DocumentPrivilege privileges, string storage = null, string folder = null)

Update privilege document.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **privileges** | [**DocumentPrivilege**](DocumentPrivilege.md)| Document privileges. DocumentPrivilege | 
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

<a name="putradiobuttonfield"></a>
# **PutRadioButtonField**
> RadioButtonFieldResponse PutRadioButtonField (string name, string fieldName, RadioButtonField field, string storage = null, string folder = null)

Replace document RadioButton field


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **field** | [**RadioButtonField**](RadioButtonField.md)| The field. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**RadioButtonFieldResponse**](RadioButtonFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putredactionannotation"></a>
# **PutRedactionAnnotation**
> RedactionAnnotationResponse PutRedactionAnnotation (string name, string annotationId, RedactionAnnotation annotation, string storage = null, string folder = null)

Replace document redaction annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**RedactionAnnotation**](RedactionAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**RedactionAnnotationResponse**](RedactionAnnotationResponse.md)

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

<a name="putscreenannotation"></a>
# **PutScreenAnnotation**
> ScreenAnnotationResponse PutScreenAnnotation (string name, string annotationId, ScreenAnnotation annotation, string storage = null, string folder = null)

Replace document screen annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**ScreenAnnotation**](ScreenAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**ScreenAnnotationResponse**](ScreenAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putscreenannotationdataextract"></a>
# **PutScreenAnnotationDataExtract**
> AsposeResponse PutScreenAnnotationDataExtract (string name, string annotationId, string outFilePath, string storage = null, string folder = null)

Extract document screen annotation content to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **outFilePath** | **string**| The output file path. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="putsignaturefield"></a>
# **PutSignatureField**
> SignatureFieldResponse PutSignatureField (string name, string fieldName, SignatureField field, string storage = null, string folder = null)

Replace document signature field.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **field** | [**SignatureField**](SignatureField.md)| The field. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SignatureFieldResponse**](SignatureFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsoundannotation"></a>
# **PutSoundAnnotation**
> SoundAnnotationResponse PutSoundAnnotation (string name, string annotationId, SoundAnnotation annotation, string storage = null, string folder = null)

Replace document sound annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**SoundAnnotation**](SoundAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SoundAnnotationResponse**](SoundAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsoundannotationdataextract"></a>
# **PutSoundAnnotationDataExtract**
> AsposeResponse PutSoundAnnotationDataExtract (string name, string annotationId, string outFilePath, string storage = null, string folder = null)

Extract document sound annotation content to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **outFilePath** | **string**| The output file path. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsquareannotation"></a>
# **PutSquareAnnotation**
> SquareAnnotationResponse PutSquareAnnotation (string name, string annotationId, SquareAnnotation annotation, string storage = null, string folder = null)

Replace document square annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**SquareAnnotation**](SquareAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SquareAnnotationResponse**](SquareAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsquigglyannotation"></a>
# **PutSquigglyAnnotation**
> SquigglyAnnotationResponse PutSquigglyAnnotation (string name, string annotationId, SquigglyAnnotation annotation, string storage = null, string folder = null)

Replace document squiggly annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**SquigglyAnnotation**](SquigglyAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**SquigglyAnnotationResponse**](SquigglyAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstampannotation"></a>
# **PutStampAnnotation**
> StampAnnotationResponse PutStampAnnotation (string name, string annotationId, StampAnnotation annotation, string storage = null, string folder = null)

Replace document stamp annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**StampAnnotation**](StampAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**StampAnnotationResponse**](StampAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstampannotationdataextract"></a>
# **PutStampAnnotationDataExtract**
> AsposeResponse PutStampAnnotationDataExtract (string name, string annotationId, string outFilePath, string storage = null, string folder = null)

Extract document stamp annotation content to storage


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **outFilePath** | **string**| The output file path. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**AsposeResponse**](AsposeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstrikeoutannotation"></a>
# **PutStrikeOutAnnotation**
> StrikeOutAnnotationResponse PutStrikeOutAnnotation (string name, string annotationId, StrikeOutAnnotation annotation, string storage = null, string folder = null)

Replace document StrikeOut annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**StrikeOutAnnotation**](StrikeOutAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**StrikeOutAnnotationResponse**](StrikeOutAnnotationResponse.md)

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

<a name="puttable"></a>
# **PutTable**
> AsposeResponse PutTable (string name, string tableId, Table table, string storage = null, string folder = null)

Replace document page table.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **tableId** | **string**| The table ID. | 
 **table** | [**Table**](Table.md)| The table. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

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

<a name="puttextboxfield"></a>
# **PutTextBoxField**
> TextBoxFieldResponse PutTextBoxField (string name, string fieldName, TextBoxField field, string storage = null, string folder = null)

Replace document text box field


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The field name. | 
 **field** | [**TextBoxField**](TextBoxField.md)| The field. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**TextBoxFieldResponse**](TextBoxFieldResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putunderlineannotation"></a>
# **PutUnderlineAnnotation**
> UnderlineAnnotationResponse PutUnderlineAnnotation (string name, string annotationId, UnderlineAnnotation annotation, string storage = null, string folder = null)

Replace document underline annotation


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **annotationId** | **string**| The annotation ID. | 
 **annotation** | [**UnderlineAnnotation**](UnderlineAnnotation.md)| Annotation. | 
 **storage** | **string**| The document storage. | [optional] 
 **folder** | **string**| The document folder. | [optional] 

### Return type

[**UnderlineAnnotationResponse**](UnderlineAnnotationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putupdatefield"></a>
# **PutUpdateField**
> FieldResponse PutUpdateField (string name, string fieldName, Field field, string storage = null, string folder = null)

Update field.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fieldName** | **string**| The name of a field to be updated. | 
 **field** | [**Field**](Field.md)| Field with the field data. | 
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
> FieldsResponse PutUpdateFields (string name, Fields fields, string storage = null, string folder = null)

Update fields.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The document name. | 
 **fields** | [**Fields**](Fields.md)| Fields with the fields data. | 
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

<a name="storageexists"></a>
# **StorageExists**
> StorageExist StorageExists (string storageName)

Check if storage exists


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | 

### Return type

[**StorageExist**](StorageExist.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadfile"></a>
# **UploadFile**
> FilesUploadResult UploadFile (string path, System.IO.Stream file, string storageName = null)

Upload file


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.              | 
 **file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesUploadResult**](FilesUploadResult.md)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

