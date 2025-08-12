using Links;

LinksHelper helper = new LinksHelper();
ConfigParams config = helper.config;

await LinksExtract.ShowInfo(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.REMOTE_TEMP_FOLDER);

await LinksExtractById.ShowInfo(helper, config.PDF_DOCUMENT, config.LINK_ID, config.REMOTE_TEMP_FOLDER);

await LinksAdd.Append(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.PAGE_NUMBER, config.NEW_LINK_ACTION, config.REMOTE_TEMP_FOLDER);

await LinksRemove.Delete(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.LINK_ID, config.REMOTE_TEMP_FOLDER);

await LinksReplace.Modify(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.LINK_ID, config.NEW_LINK_ACTION, config.REMOTE_TEMP_FOLDER);