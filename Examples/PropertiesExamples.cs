
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


        public void DeletePropertiesTest()
        {
            api.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: FolderName);
            api.PutSetProperty(Name, PropertyNames[1], PropertyValues[1], folder: FolderName);

            var response = api.DeleteProperties(Name, folder: FolderName);
            Console.WriteLine(response);
        }



        public void DeletePropertyTest()
        {
            api.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: FolderName);

            var response = api.DeleteProperty(Name, PropertyNames[0], folder: FolderName);
            Console.WriteLine(response);
        }



        public void GetDocumentPropertiesTest()
        {
            api.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: FolderName);
            api.PutSetProperty(Name, PropertyNames[1], PropertyValues[1], folder: FolderName);

            var response = api.GetDocumentProperties(Name, folder: FolderName);
            Console.WriteLine(response);
        }



        public void GetDocumentPropertyTest()
        {
            api.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: FolderName);

            var response = api.GetDocumentProperty(Name, PropertyNames[0], folder: FolderName);
            Console.WriteLine(response);
        }



        public void PutSetPropertyTest()
        {
            var response = api.PutSetProperty(Name, PropertyNames[0], PropertyValues[0], folder: FolderName);
            Console.WriteLine(response);
        }

    }
}