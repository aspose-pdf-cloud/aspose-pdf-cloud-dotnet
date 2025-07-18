using ChangeLayout;


ChangeLayoutHelper helper = new ChangeLayoutHelper();

RotateDocumentsPages rotate = new RotateDocumentsPages(helper);
await rotate.MakeRotateDocumentsPages(helper.config.PDF_DOCUMENT, helper.config.ROTATE_PAGES_ANGLE.ToString(), helper.config.ROTATE_PAGES);

ResizeDocumentAllPages resize = new ResizeDocumentAllPages(helper);
await resize.MakeResizeDocumentAllPages(helper.config.PDF_DOCUMENT, helper.config.RESIZE_PDF_HTML_FILE, helper.config.RESIZE_NEW_PAGE_WIDTH, helper.config.RESIZE_NEW_PAGE_HEIGHT);

CropDocumentPage crop = new CropDocumentPage(helper);
await crop.MakeCropDocumentPage(helper.config.PDF_DOCUMENT, helper.config.CROP_LOCAL_RESULT_DOCUMENT_NAME, helper.config.CROP_PAGE_NUMBER, helper.config.CROP_LLX, helper.config.CROP_LLY, helper.config.CROP_WIDTH, helper.config.CROP_HEIGHT);