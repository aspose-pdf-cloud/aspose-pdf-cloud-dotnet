using Conversions;

ConversionsHelper helper = new ConversionsHelper();
ConfigParams config = helper.config;

await ConvertBMPToPDF.Convert(helper, config.BMP_FILE_NAME, config.PDF_BMP_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertJPEGToPDF.Convert(helper, config.JPEG_FILE_NAME, config.PDF_JPEG_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPNGToPDF.Convert(helper, config.PNG_FILE_NAME, config.PDF_PNG_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertGIFToPDF.Convert(helper, config.GIF_FILE_NAME, config.PDF_GIF_OUTPUT, config.REMOTE_TEMP_FOLDER);

List<string> images = new List<string> { config.BMP_FILE_NAME, config.JPEG_FILE_NAME, config.PNG_FILE_NAME };
await ConvertImagesToPDF.Convert(helper, images, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertEPUBToPDF.Convert(helper, config.EPUB_FILE_NAME, config.PDF_EPUB_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertHTMLToPDF.Convert(helper, config.HTML_FILE_NAME, config.PDF_HTML_OUTPUT, config.PDF_HTML_WIDTH, config.PDF_HTML_HEIGHT, config.REMOTE_TEMP_FOLDER);

await ConvertMHTMLToPDF.Convert(helper, config.MHTML_FILE_NAME, config.PDF_MHTML_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertMarkdownToPDF.Convert(helper, config.MD_FILE_NAME, config.PDF_MD_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPCLToPDF.Convert(helper, config.PCL_FILE_NAME, config.PDF_PCL_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPSToPDF.Convert(helper, config.PS_FILE_NAME, config.PDF_PS_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToDOC.Convert(helper, config.PDF_DOCUMENT, config.DOC_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToDOCX.Convert(helper, config.PDF_DOCUMENT, config.DOCX_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToExcel.Convert(helper, config.PDF_DOCUMENT, config.XLS_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToXLSX.Convert(helper, config.PDF_DOCUMENT, config.XLSX_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToPowerpoint.Convert(helper, config.PDF_DOCUMENT, config.PPTX_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToEPUB.Convert(helper, config.PDF_DOCUMENT, config.EPUB_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToHTML.Convert(helper, config.PDF_DOCUMENT, config.HTML_ZIP_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToMobiXML.Convert(helper, config.PDF_DOCUMENT, config.MXML_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToTEX.Convert(helper, config.PDF_DOCUMENT, config.TEX_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToSVG.Convert(helper, config.PDF_DOCUMENT, config.SVG_ZIP_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToTIFF.Convert(helper, config.PDF_DOCUMENT, config.TIFF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToXML.Convert(helper, config.PDF_DOCUMENT, config.XML_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ConvertPDFToXPS.Convert(helper, config.PDF_DOCUMENT, config.XPS_OUTPUT, config.REMOTE_TEMP_FOLDER);