using Parser;

ParserHelper helper = new ParserHelper();
ConfigParams config = helper.config;

await GetTextBoxes.Extract(helper, config.PDF_DOCUMENT, config.LOCAL_FOLDER, config.REMOTE_TEMP_FOLDER);

await GetTables.Extract(helper, config.PDF_DOCUMENT, config.LOCAL_FOLDER, config.REMOTE_TEMP_FOLDER);

await GetImages.Extract(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.LOCAL_FOLDER, config.REMOTE_TEMP_FOLDER);

await ExportFormToFdf.Extract(helper, config.PDF_DOCUMENT, config.FDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ExportFormToXML.Extract(helper, config.PDF_DOCUMENT, config.XML_OUTPUT, config.REMOTE_TEMP_FOLDER);
