using Merges;

MergesHelper helper = new MergesHelper();
ConfigParams config = helper.config;

await MergeDocuments.Merge(helper, new List<string> { config.PDF_DOCUMENT, config.PDF_DOCUMENT_2, config.PDF_DOCUMENT_3 }, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);
