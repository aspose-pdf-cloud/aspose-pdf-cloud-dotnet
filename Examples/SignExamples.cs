
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
namespace Aspose.Pdf.Cloud.Sdk.SignAPI
{

    public class SignExamples
    {
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");

        string FolderName = "";
        private const string Name = "BlankWithSignature.pdf";
        private const int PageNumber = 2;

        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }
        private const string SignatureName = "Example1234.pfx";

        private static readonly Signature signature = new Signature(
            Authority: "Sergey Smal",
            Contact: "Example@mail.ru",
            Date: "08/01/2012 12:15:00.000 PM",
            FormFieldName: "Signature1",
            Location: "Ukraine",
            Password: "Example1234",
            Rectangle: new Rectangle(
                LLX: 100,
                LLY: 100,
                URX: 0,
                URY: 0),
            SignaturePath: Path.Combine("", SignatureName),
            SignatureType: SignatureType.PKCS7,
            Visible: true,
            ShowProperties: false);


        public void PostSignDocumentExample()
        {
            //ExStart: PostSignDocumentExample
            UploadFile(Name, Name);
            UploadFile(SignatureName, SignatureName);

            var response = api.PostSignDocument(Name, signature, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PostSignDocumentExample
        }

        public void PagesPostSignPageExample()
        {
            //ExStart: PagesPostSignPageExample
            UploadFile(Name, Name);
            UploadFile(SignatureName, SignatureName);

            var response = api.PostSignPage(Name, pageNumber: 1, signature, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PagesPostSignPageExample
        }


        public void GetVerifySignatureExample()
        {
            //ExStart: GetVerifySignatureExample
            UploadFile(Name, Name);
            UploadFile(SignatureName, SignatureName);

            var responseSignature = api.PostSignDocument(Name, signature, folder: FolderName);

            var response = api.GetVerifySignature(Name, signature.FormFieldName, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetVerifySignatureExample
        }
    }
}