
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
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }

        public void GetFieldExample()
        {
            //ExStart: GetFieldExample
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = api.GetField(name, "textField", folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetFieldExample
        }


        public void GetFieldsExample()
        {
            //ExStart: GetFieldsExample
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = api.GetFields(name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetFieldsExample
        }


        public void PostCreateFieldExample()
        {
            //ExStart: PostCreateFieldExample
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
            //ExEnd: PostCreateFieldExample
        }

        public void PutUpdateFieldExample()
        {
             //ExStart: PutUpdateFieldExample
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
             //ExEnd: PutUpdateFieldExample

        }


        public void PutUpdateFieldsExample()
        {
             //ExStart: PutUpdateFieldsExample
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
             //ExEnd: PutUpdateFieldsExample

        }


        public void DeleteFieldExample()
        {
             //ExStart: DeleteFieldExample
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var fieldName = "textField";

            var response = api.DeleteField(name, fieldName, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: DeleteFieldExample
        }

        public void PutFieldsFlattenExample()
        {
            //ExStart: PutFieldsFlattenExample
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = api.PutFieldsFlatten(name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutFieldsFlattenExample
        }

        public void PostFlattenDocumentExample()
        {
             //ExStart: PostFlattenDocumentExample
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = api.PostFlattenDocument(name, updateAppearances: true, hideButtons: true, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PostFlattenDocumentExample
        }
    }

}