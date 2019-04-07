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
         PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");

        private const string Name = "PdfWithTable.pdf";
        private const int PageNumber = 1;

        public void DeleteDocumentTablesTest()
        {
            var response = api.DeleteDocumentTables(Name, folder: "");
            Console.WriteLine(response);
        }


        public void GetDocumentTablesTest()
        {
            var response = api.GetDocumentTables(Name, folder: "");
            Console.WriteLine(response);
        }

 
        public void GetPageTablesTest()
        {
            var response = api.GetPageTables(Name, PageNumber, folder: "");
            Console.WriteLine(response);
        }


        public void DeletePageTablesTest()
        {
            var response = api.DeletePageTables(Name, PageNumber, folder: "");
            Console.WriteLine(response);
        }

        public void GetTableTest()
        {
            var tablesResponse = api.GetDocumentTables(Name, folder: "");
            string tableId = tablesResponse.Tables.List[0].Id;

            var response = api.GetTable(Name, tableId, folder: "");
            Console.WriteLine(response);
        }


        public void DeleteTableTest()
        {
            var tablesResponse = api.GetDocumentTables(Name, folder: "");
            string tableId = tablesResponse.Tables.List[0].Id;

            var response = api.DeleteTable(Name, tableId, folder: "");
            Console.WriteLine(response);
        }
    }
}