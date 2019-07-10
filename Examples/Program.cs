using System;
using Aspose.Pdf.Cloud.Sdk.Api;


namespace pdf_cloud_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfApi api = new PdfApi("XXXXXXX", "XXXXXXX");
            var response = api.GetDocumentAnnotations("mpdf.pdf","");

            Console.WriteLine(response);

        }
    }
}
