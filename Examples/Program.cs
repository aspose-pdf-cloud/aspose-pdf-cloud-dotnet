using System;
using Aspose.Pdf.Cloud.Sdk.Api;


namespace pdf_cloud_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfApi api=new PdfApi("b125f13bf6b76ed81ee990142d841195","78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            var response = api.GetDocumentAnnotations("mpdf.pdf","");

            Console.WriteLine(response);

        }
    }
}
