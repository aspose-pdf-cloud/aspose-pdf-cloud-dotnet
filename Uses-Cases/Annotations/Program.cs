using Annotations;

AnnotationsHelper helper = new AnnotationsHelper();
ConfigParams config = helper.config;

string annotationId = await GetAnnotations.RequestAnnotationsOnPageAsync(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.REMOTE_TEMP_FOLDER);
await GetAnnotationById.RequestTextAnnotationAsync(helper, config.PDF_DOCUMENT, annotationId, config.REMOTE_TEMP_FOLDER);

await DeletePageAnnotations.MakeDeleteAsync(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);
await DeleteTextAnnotation.MakeDeleteAsync(helper, config.PDF_DOCUMENT, config.ANNOTATION_ID, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await NewHighlightAnnotation.Append(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);
await NewStrikeoutAnnotation.Append(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);
await NewUnderlineAnnotation.Append(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);
await NewFreetextAnnotation.Append(helper, config.PDF_DOCUMENT, config.PAGE_NUMBER, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await ReplaceAnnotation.ModifyAsync(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.ANNOTATION_ID, config.REMOTE_TEMP_FOLDER);