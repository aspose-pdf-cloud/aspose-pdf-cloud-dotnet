
using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using Aspose.Pdf.Cloud.Sdk.Api;
using System;
using System.IO;


namespace Aspose.Pdf.Cloud.Sdk.PropertiesAPI
{

    public class PropertiesExamples
    {
        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";
        private const string Name = "PdfWithAcroForm.pdf";

        private static readonly string[] PropertyNames = { "prop1", "prop2" };
        private static readonly string[] PropertyValues = { "val1", "val2" };


        public void DeletePropertiesExample()
        {
            //ExStart: DeletePropertiesExample
            api.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: FolderName);
            api.PutSetProperty(Name, PropertyNames[1], PropertyValues[1], folder: FolderName);

            var response = api.DeleteProperties(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: DeletePropertiesExample
        }



        public void DeletePropertyExample()
        {
            //ExStart: DeletePropertyExample
            api.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: FolderName);

            var response = api.DeleteProperty(Name, PropertyNames[0], folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: DeletePropertyExample
        }



        public void GetDocumentPropertiesExample()
        {
            //ExStart: GetDocumentPropertiesExample
            api.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: FolderName);
            api.PutSetProperty(Name, PropertyNames[1], PropertyValues[1], folder: FolderName);

            var response = api.GetDocumentProperties(Name, folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentPropertiesExample
        }



        public void GetDocumentPropertyExample()
        {
            //ExStart: GetDocumentPropertyExample
            api.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: FolderName);

            var response = api.GetDocumentProperty(Name, PropertyNames[0], folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: GetDocumentPropertyExample
        }



        public void PutSetPropertyExample()
        {
            //ExStart: PutSetPropertyExample
            var response = api.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: FolderName);
            Console.WriteLine(response);
            //ExEnd: PutSetPropertyExample
        }

    }
}