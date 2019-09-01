using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.IO;

namespace Aspose.Pdf.Cloud.Sdk.Example
{

    public class TextReplaceExamples
    {
        private const string Name = "marketing.pdf";

        PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
        string FolderName = "";

        
        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.UploadFile(Path.Combine("", serverFileName), file);
            }
        }

        public void PostDocumentTextReplaceExample()
        {
             //ExStart: PostDocumentTextReplaceExample
            var rect = new Rectangle(100, 100, 300, 300);
            var textReplace = new TextReplace("market", "m_a_r_k_e_t", false, Rect: rect);
            var textReplaceList = new TextReplaceListRequest(new List<TextReplace> { textReplace },
                StartIndex: 0, CountReplace: 0);

            var response = api.PostDocumentTextReplace(Name, textReplaceList, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: PostDocumentTextReplaceExample
        }


        public void PostPageTextReplaceExample()
        {
             //ExStart: PostPageTextReplaceExample
            var rect = new Rectangle(100, 100, 300, 300);
            var textReplace = new TextReplace("market", "m_a_r_k_e_t", false, Rect: rect);
            var textReplaceList = new TextReplaceListRequest(new List<TextReplace> { textReplace },
                StartIndex: 0, CountReplace: 0);

            var response = api.PostPageTextReplace(Name, 1, textReplaceList, folder: FolderName);
            Console.WriteLine(response);
             //ExEnd: PostPageTextReplaceExample
        }
    }
}