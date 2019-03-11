using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.IO;

namespace Aspose.Pdf.Cloud.Sdk.Test
{

    public class TextReplaceExamples
    {
        private const string Name = "marketing.pdf";

        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
        string FolderName = "";

        
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }

        public void PostDocumentTextReplaceTest()
        {
            var rect = new Rectangle(100, 100, 300, 300);
            var textReplace = new TextReplace("market", "m_a_r_k_e_t", false, Rect: rect);
            var textReplaceList = new TextReplaceListRequest(new List<TextReplace> { textReplace },
                StartIndex: 0, CountReplace: 0);

            var response = api.PostDocumentTextReplace(Name, textReplaceList, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PostPageTextReplaceTest()
        {
            var rect = new Rectangle(100, 100, 300, 300);
            var textReplace = new TextReplace("market", "m_a_r_k_e_t", false, Rect: rect);
            var textReplaceList = new TextReplaceListRequest(new List<TextReplace> { textReplace },
                StartIndex: 0, CountReplace: 0);

            var response = api.PostPageTextReplace(Name, 1, textReplaceList, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}