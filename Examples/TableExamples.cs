using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;

namespace Aspose.Pdf.Cloud.Sdk.TableAPI
{

    class TablesExamples
    {
         PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");

        private const string Name = "PdfWithTable.pdf";
        private const int PageNumber = 1;

        public void DeleteDocumentTablesExample()
        {
             //ExStart: PutStrikeOutAnnotationExample
            var response = api.DeleteDocumentTables(Name, folder: "");
            Console.WriteLine(response);
             //ExEnd: PutStrikeOutAnnotationExample
        }


        public void GetDocumentTablesExample()
        {
            //ExStart: GetDocumentTablesExample
            var response = api.GetDocumentTables(Name, folder: "");
            Console.WriteLine(response);
             //ExEnd: GetDocumentTablesExample
        }

 
        public void GetPageTablesExample()
        {
             //ExStart: GetPageTablesExample
            var response = api.GetPageTables(Name, PageNumber, folder: "");
            Console.WriteLine(response);
             //ExEnd: GetPageTablesExample
        }


        public void DeletePageTablesExample()
        {
             //ExStart: DeletePageTablesExample
            var response = api.DeletePageTables(Name, PageNumber, folder: "");
            Console.WriteLine(response);
             //ExEnd: DeletePageTablesExample
        }

        public void GetTableExample()
        {
             //ExStart: GetTableExample
            var tablesResponse = api.GetDocumentTables(Name, folder: "");
            string tableId = tablesResponse.Tables.List[0].Id;

            var response = api.GetTable(Name, tableId, folder: "");
            Console.WriteLine(response);
             //ExEnd: GetTableExample
        }


        public void DeleteTableExample()
        {
             //ExStart: DeleteTableExample
            var tablesResponse = api.GetDocumentTables(Name, folder: "");
            string tableId = tablesResponse.Tables.List[0].Id;

            var response = api.DeleteTable(Name, tableId, folder: "");
            Console.WriteLine(response);
             //ExEnd: DeleteTableExample
        }
    }
}