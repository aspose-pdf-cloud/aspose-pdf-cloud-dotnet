
using System.Collections.Generic;
using System.Net;
using System.IO;
using System;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
namespace Aspose.Pdf.Cloud.Sdk.FieldsAPI
{

    public class FieldsExamples
    {
        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
        string FolderName = "";
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }

        public void GetFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = api.GetField(name, "textField", folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = api.GetFields(name, folder: FolderName);
            Console.WriteLine(response);

        }


        public void PostCreateFieldTest()
        {
            const string name = "Hello world.pdf";
            UploadFile(name, name);

            var field = new Field(
                Name: "checkboxfield",
                Type: FieldType.Boolean,
                Values: new List<string> {"1"},
                Rect: new Rectangle(
                    LLX: 50,
                    LLY: 200,
                    URX: 200,
                    URY: 400
                    ));
            var response = api.PostCreateField(name, 1, field, folder: FolderName);
            Console.WriteLine(response);

        }

        public void PutUpdateFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var fieldName = "textField";

            var field = new Field(
                Name: fieldName,
                Type: FieldType.Text,
                Values: new List<string> {"Text field updated value."},
                Rect: new Rectangle(125, 735, 200, 752)                
                );

            var response = api.PutUpdateField(name, fieldName, field, folder: FolderName);
            Console.WriteLine(response);

        }


        public void PutUpdateFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var fieldName = "textField";

            var fields = new Fields(null, new List<Field>()
            {
                new Field(
                    Name: fieldName,
                    Type: FieldType.Text,
                    Values: new List<string> {"Text field updated value."})
                
            });
            
            var response = api.PutUpdateFields(name, fields, folder: FolderName);
            Console.WriteLine(response);

        }


        public void DeleteFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var fieldName = "textField";

            var response = api.DeleteField(name, fieldName, folder: FolderName);
            Console.WriteLine(response);

        }

        public void PutFieldsFlattenTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = api.PutFieldsFlatten(name, folder: FolderName);
            Console.WriteLine(response);

        }

        public void PostFlattenDocumentTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = api.PostFlattenDocument(name, updateAppearances: true, hideButtons: true, folder: FolderName);
            Console.WriteLine(response);
        }
    }

}