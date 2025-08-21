using Pages;

PagesHelper helper = new PagesHelper();
ConfigParams config = helper.config;

await PagesExtractInfo.Extract(helper, config.PDF_DOCUMENT, config.REMOTE_TEMP_FOLDER);

string outputImageName = Path.Combine(config.LOCAL_FOLDER, config.PNG_PAGE_OUTPUT);
await PagesSaveToImage.ExtractPNG(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, outputImageName, config.REMOTE_TEMP_FOLDER);

await PagesAdd.Append(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await PagesAddImageStamp.Append(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.PAGE_NUMBER, config.IMAGE_STAMP_FILE, config.IMAGE_STAMP_WIDTH, config.IMAGE_STAMP_HEIGHT, config.REMOTE_TEMP_FOLDER);

await PagesAddTextStamp.Append(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.PAGE_NUMBER, config.STAMP_TEXT, config.REMOTE_TEMP_FOLDER);

await PagesMove.Move(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.PAGE_NUMBER, config.PAGE_NUMBER + 1, config.REMOTE_TEMP_FOLDER);

await PagesDelete.Delete(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.PAGE_NUMBER, config.REMOTE_TEMP_FOLDER);

await PagesWordsCount.Get(helper, config.PDF_DOCUMENT, config.REMOTE_TEMP_FOLDER);
