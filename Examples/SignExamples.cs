
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
namespace Aspose.Pdf.Cloud.Sdk.SignAPI
{

    public class SignExamples
    {
        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");

        string FolderName = "";
        private const string Name = "BlankWithSignature.pdf";
        private const int PageNumber = 2;

        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }
        private const string SignatureName = "test1234.pfx";

        private static readonly Signature Signature = new Signature(
            Authority: "Sergey Smal",
            Contact: "test@mail.ru",
            Date: "08/01/2012 12:15:00.000 PM",
            FormFieldName: "Signature1",
            Location: "Ukraine",
            Password: "test1234",
            Rectangle: new Rectangle(
                LLX: 100,
                LLY: 100,
                URX: 0,
                URY: 0),
            SignaturePath: Path.Combine("", SignatureName),
            SignatureType: SignatureType.PKCS7,
            Visible: true,
            ShowProperties: false);


        public void PostSignDocumentTest()
        {
            UploadFile(Name, Name);
            UploadFile(SignatureName, SignatureName);

            var response = api.PostSignDocument(Name, Signature, folder: FolderName);
            Console.WriteLine(response);
        }

        public void PagesPostSignPageTest()
        {
            UploadFile(Name, Name);
            UploadFile(SignatureName, SignatureName);

            var response = api.PostSignPage(Name, pageNumber: 1, signature: Signature, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetVerifySignatureTest()
        {
            UploadFile(Name, Name);
            UploadFile(SignatureName, SignatureName);

            var responseSignature = api.PostSignDocument(Name, Signature, folder: FolderName);

            var response = api.GetVerifySignature(Name, Signature.FormFieldName, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}