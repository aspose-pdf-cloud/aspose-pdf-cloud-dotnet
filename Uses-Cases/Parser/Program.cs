using Parser;

ParserHelper helper = new ParserHelper();
ConfigParams config = helper.config;

await GetTextBoxes.Extract(helper, config.PDF_DOCUMENT, config.REMOTE_TEMP_FOLDER);

await GetTextBox.Extract(helper, config.PDF_DOCUMENT, config.TEXT_BOX_FIELD_NAME, config.REMOTE_TEMP_FOLDER);

await GetTables.Extract(helper, config.PDF_DOCUMENT, config.REMOTE_TEMP_FOLDER);

await GetTable.Extract(helper, config.PDF_DOCUMENT, config.TABLE_ID, config.REMOTE_TEMP_FOLDER);

await GetImages.Extract(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.REMOTE_TEMP_FOLDER);

await GetImage.Extract(helper, config.PDF_DOCUMENT, config.IMAGE_ID, config.REMOTE_TEMP_FOLDER);

await ExportFormToFdf.Extract(helper, config.PDF_DOCUMENT, config.FDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ExportFormToXML.Extract(helper, config.PDF_DOCUMENT, config.XML_OUTPUT, config.REMOTE_TEMP_FOLDER);
