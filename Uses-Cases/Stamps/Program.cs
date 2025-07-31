using Stamps;

StampsHelper helper = new StampsHelper();
ConfigParams config = helper.config;

await StampsNewImages.Append(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.IMAGE_STAMP_FILE, config.IMAGE_STAMP_WIDTH, config.IMAGE_STAMP_HEIGHT, config.REMOTE_TEMP_FOLDER);

await StampsExtract.ShowInfo(helper, config.PDF_DOCUMENT, config.REMOTE_TEMP_FOLDER);

await StampsNewTexts.Append(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.STAMP_TEXT, config.REMOTE_TEMP_FOLDER);

await StampsDelete.Delete(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await StampsDeleteOnPage.Delete(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.PAGE_NUMBER, config.REMOTE_TEMP_FOLDER);

