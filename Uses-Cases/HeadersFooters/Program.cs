using HeadersFooters;

HeadersFootersHelper helper = new HeadersFootersHelper();
ConfigParams config = helper.config;

await HeadersFootersAddImageFooter.Append(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.IMAGE_FILE, config.PAGE_NUMBER, config.PAGE_NUMBER + 1, config.REMOTE_TEMP_FOLDER);
await HeadersFootersAddTextFooter.Append(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.TEXT_FOOTER, config.PAGE_NUMBER, config.PAGE_NUMBER + 1, config.REMOTE_TEMP_FOLDER);

await HeadersFootersAddImageHeader.Append(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.IMAGE_FILE, config.PAGE_NUMBER, config.PAGE_NUMBER + 1, config.REMOTE_TEMP_FOLDER);
await HeadersFootersAddTextHeader.Append(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.TEXT_FOOTER, config.PAGE_NUMBER, config.PAGE_NUMBER + 1, config.REMOTE_TEMP_FOLDER);
