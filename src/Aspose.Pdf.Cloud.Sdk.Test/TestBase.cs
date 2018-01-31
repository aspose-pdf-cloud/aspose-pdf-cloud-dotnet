// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestsBase.cs">
//   Copyright (c) 2018 Aspose.Pdf for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Com.Aspose.Storage.Api;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp.Extensions;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    public abstract class TestsBase
    {
        private const string BaseProductUri = @"http://api-dev.aspose.cloud";

        private const string TestDataFolder = @"..\..\..\..\testData";
        private const string ServerCredsFile = @"..\..\..\Settings\servercreds.json";

        protected const string TempFolder = "TempPdf";

        private Keys keys;

        [SetUp]
        public virtual void SetUp()
        {
            // To run tests with your own credentials please uncomment following line of code
            // this.keys = new Keys { AppKey = "your app key", AppSid = "your app sid" };

            if (null == keys)
            {
                keys = JsonConvert.DeserializeObject<Keys>(File.ReadAllText(ServerCredsFile));
            }

            if (string.IsNullOrEmpty(keys?.AppKey) || string.IsNullOrEmpty(keys.AppSID))
            {
                throw new FileNotFoundException("servercreds.json doesn't contain AppKey and AppSid");
            }

            StorageApi = new StorageApi(keys.AppKey, keys.AppSID, BaseProductUri + "/v1.1");
            Configuration = new Configuration(keys.AppKey, keys.AppSID, BaseProductUri, authType: AuthType.OAuth2);
            PdfApi = new PdfApi(Configuration);
        }

        [TearDown]
        public virtual void TearDown()
        {
            StorageApi = null;
        }

        protected StorageApi StorageApi { get; private set; }
        protected PdfApi PdfApi { get; set; }
        protected Configuration Configuration { get; private set; }


        protected void UploadFile(string sourcePath, string serverFileName)
        {
            byte[] data;
            using (var file = File.OpenRead(Path.Combine(TestDataFolder, sourcePath)))
            {
                data = file.ReadAsBytes();
            }

            StorageApi.PutCreate(Path.Combine(TempFolder, serverFileName), null, null, data);
        }

        private class Keys
        {
            public string AppSID { get; set; }

            public string AppKey { get; set; }
        }
    }
}