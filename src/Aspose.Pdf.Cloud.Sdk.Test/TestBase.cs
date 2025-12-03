// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestsBase.cs">
//   Copyright (c) 2025 Aspose.PDF Cloud
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

using System;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test {

  public abstract class TestsBase {

    private const string BaseProductUri = @"https://api.aspose.cloud";
    private const string ServerCredsFile = @"settings/credentials.json";
    protected const string TempFolder = "TempPdfCloud";
    
    protected string TestDataFolder
    {
        get
        {
            string path = Directory.GetCurrentDirectory();
            while(Directory.GetParent(path) != null)
            {
                string testdataPath = Path.Combine(path, "testData");
                if (Directory.Exists(testdataPath))
                {
                    return testdataPath;
                }

                path = Directory.GetParent(path).FullName;
            }

            throw new DirectoryNotFoundException();
        }
    }

    private class Creds {
      [JsonProperty("client_id")]
      public string ClientId { get; set; }
      [JsonProperty("client_secret")]
      public string ClientSecret { get; set; }
      [JsonProperty("self_host")]
      public bool SelfHost { get; set; }
      [JsonProperty("api_url")]
      public string ProductUri { get; set; }
    }

    private Creds _creds;

    private Creds _GetCreds() {
      return JsonConvert.DeserializeObject<Creds>(File.ReadAllText(ServerCredsFile));
    }

    [SetUp]
    public virtual void SetUp() {
      ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
      Console.WriteLine(TestContext.CurrentContext.Test.Name);
      // To run tests with your own credentials please uncomment following line of code
      // this._creds = new Creds { clientSecret = "your client_secret", clientId = "your client_id" };
      if (_creds == null)
        _creds = _GetCreds();
      if (_creds.SelfHost) {
        if (string.IsNullOrEmpty(_creds.ProductUri))
          throw new FileNotFoundException("servercreds.json doesn't contain ProductUri");
      } else {
        if (string.IsNullOrEmpty(_creds.ClientSecret) || string.IsNullOrEmpty(_creds.ClientId))
          throw new FileNotFoundException("servercreds.json doesn't contain clientId and/or clientSecret");
      }
      Configuration = new Configuration(_creds.SelfHost, _creds.ClientSecret, _creds.ClientId, _creds.ProductUri);
      PdfApi = new PdfApi(Configuration);
    }

    [TearDown]
    public virtual void TearDown() { }

    protected PdfApi PdfApi { get; set; }
    protected Configuration Configuration { get; private set; }

    protected void UploadFile(string sourcePath, string serverFileName) {
      using (var file = File.OpenRead(Path.Combine(TestDataFolder, sourcePath))) {
        Model.FilesUploadResult response = PdfApi.UploadFile(Path.Combine(TempFolder, serverFileName), file);
      }
    }
  }
}
