using Bookmarks;
BookmarksHelper helper = new BookmarksHelper();
ConfigParams config = helper.config;

await BookmarksExtract.ShowInfo(helper, config.PDF_DOCUMENT, config.REMOTE_TEMP_FOLDER);

await BookmarksExtractByPath.ShowInfo(helper, config.PDF_DOCUMENT, config.BOOKMARK_PATH, config.REMOTE_TEMP_FOLDER);

await BookmarksAdd.Append(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.BOOKMARK_PATH, config.BOOKMARK_TITLE, config.REMOTE_TEMP_FOLDER);

await BookmarksRemove.Delete(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.BOOKMARK_PATH, config.REMOTE_TEMP_FOLDER);

await BookmarksReplace.Modify(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.BOOKMARK_PATH, config.BOOKMARK_TITLE, config.REMOTE_TEMP_FOLDER);