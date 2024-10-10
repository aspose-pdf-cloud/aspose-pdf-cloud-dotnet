using System.Collections.Generic;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    [TestFixture]
    public class XmpMetadataTests : TestsBase
    {
        private const string Name = "4pages.pdf";

        /// <summary>
        /// Test GetXmpMetadataJson
        /// </summary>
        [Test]
        public void GetXmpMetadataJsonTest()
        {
            UploadFile(Name, Name);

            var response = PdfApi.GetXmpMetadataJson(Name, TempFolder);
            Assert.That(response.Properties.Count, Is.EqualTo(9));
        }

        /// <summary>
        /// Test GetXmpMetadataXml
        /// </summary>
        [Test]
        public void GetXmpMetadataXmlTest()
        {
            UploadFile(Name, Name);

            var response = PdfApi.GetXmpMetadataXml(Name, TempFolder);
            Assert.That(response.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Test GetXmpMetadataXml
        /// </summary>
        [Test]
        public void PostXmpMetadataTest()
        {
            UploadFile(Name, Name);

            const string date = "2024-10-27T09:59:52+02:00";
            var metadata = new XmpMetadata {
                Properties = new List<XmpMetadataProperty> {
                    // Modify Default property without prefix
                    new XmpMetadataProperty
                    (
                        Key: "ModifyDate",
                        Value: date
                    ),
                    // Modify Default property with prefix
                    new XmpMetadataProperty
                    (
                        Key: "xmp:CreateDate",
                        Value: date
                    ),
                    //Remove Default property
                    new XmpMetadataProperty
                    (
                        Key: "CreatorTool",
                        Value: null
                    ),
                    //Add Default property
                    new XmpMetadataProperty
                    (
                        Key: "BaseURL",
                        Value: "http://www.somename.com/path"
                    ),

                    //Remove User defined property
                    new XmpMetadataProperty
                    (
                        Key: "dc:title",
                        Value: null
                    ),
                    
                    // Update user defined property
                    new XmpMetadataProperty
                    (
                        Key: "pdf:Producer",
                        Value: "Aspose.PDF Cloud",
                        NamespaceUri: "http://ns.adobe.com/pdf/1.3/"
                    ),
                    
                    // Add user defined property
                    new XmpMetadataProperty
                    (
                        Key: "pdf:Prop",
                        Value: "PropValue",
                        NamespaceUri: "http://ns.adobe.com/pdf/1.3/"
                    )
                }
            };
            var response = PdfApi.PostXmpMetadata(Name, metadata, TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));

            var xmp = PdfApi.GetXmpMetadataJson(Name, TempFolder);
            Assert.That(xmp.Properties.Count, Is.EqualTo(9));
        }
    }
}
