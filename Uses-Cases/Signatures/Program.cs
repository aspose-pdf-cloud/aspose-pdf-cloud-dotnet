using Signatures;

SignaturesHelper helper = new SignaturesHelper();
ConfigParams config = helper.config;

await helper.UploadFile(config.SIGNATURE_PFX);

await AddSignature.Append(helper, config, config.PDF_DOCUMENT, config.SIGNATURE_FORM_FIELD, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await GetSignatures.Extract(helper, config.PDF_SIGNED_DOCUMENT, config.REMOTE_TEMP_FOLDER);

await ReplaceSignature.Update(helper, config, config.PDF_DOCUMENT, config.SIGNATURE_FORM_FIELD, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await VerifySignature.Check(helper, config.PDF_SIGNED_DOCUMENT, "Signature1", config.REMOTE_TEMP_FOLDER);