using EncryptDecrypt;
using EnryptDecrypt;

EncryptDecryptHelper helper = new EncryptDecryptHelper();
ConfigParams config = helper.config;

await EncryptPdf.Encrypt(helper, config.PDF_DOCUMENT, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await DecryptPdf.Decrypt(helper, config.PDF_DOCUMENT_ENCRYPTED, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);

await PasswordModify.Change(helper, config.PDF_DOCUMENT_ENCRYPTED, config.PDF_OUTPUT, config.REMOTE_TEMP_FOLDER);