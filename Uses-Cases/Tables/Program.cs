using Tables;

TablesHelper helper = new TablesHelper();
ConfigParams config = helper.config;

await GetTables.Extract(helper, config.PDF_DOCUMENT, config.REMOTE_TEMP_FOLDER);

await GetTablesOnPage.Extract(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.REMOTE_TEMP_FOLDER);

await GetTable.Extract(helper, config.PDF_DOCUMENT, config.TABLE_ID, config.REMOTE_TEMP_FOLDER);

await AddTable.Append(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await DeleteTables.Remove(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await DeleteTableOnPage.Remove(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await DeleteTable.Remove(helper, config.PDF_DOCUMENT, config.TABLE_ID, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ReplaceTable.Modify(helper, config.PDF_DOCUMENT, config.TABLE_ID, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);