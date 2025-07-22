using CreateDocument;

CrateDocumentHelper helper = new CrateDocumentHelper ();
CreatePdfDocument pdfCreatror = new CreatePdfDocument(helper);

helper.DownloadFile(helper.config.LOCAL_RESULT_DOCUMENT_NAME);

Console.WriteLine(helper.config.LOCAL_RESULT_DOCUMENT_NAME);

ClreatePdfDocumentSimple simpleDoc = new ClreatePdfDocumentSimple();