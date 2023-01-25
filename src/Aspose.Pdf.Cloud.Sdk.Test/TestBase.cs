// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestsBase.cs">
//   Copyright (c) 2023 Aspose.PDF Cloud
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
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test {

  public abstract class TestsBase {

    private const string BaseProductUri = @"https://api.aspose.cloud";
    protected const string TestDataFolder = @"..\..\..\..\testData";
    private const string ServerCredsFile = @"Settings\servercreds.json";
    protected const string TempFolder = "TempPdfCloud";

    private class Keys {
      public string AppSID { get; set; }
      public string AppKey { get; set; }
    }

    private Keys keys;

    private string _GetServercredsJson() {
      DirectoryInfo di = Directory.GetParent(Directory.GetCurrentDirectory());
      while (di != null) {
        string servercreds_json = Path.Combine(di.FullName, ServerCredsFile);
        if (File.Exists(servercreds_json)) {
          return servercreds_json;
        }
        di = Directory.GetParent(di.FullName);
      }
      throw new FileNotFoundException("servercreds.json not found");
    }

    private Keys _GetKeys() {
      return JsonConvert.DeserializeObject<Keys>(File.ReadAllText(_GetServercredsJson()));
    }

    [SetUp]
    public virtual void SetUp() {
      Console.WriteLine(TestContext.CurrentContext.Test.Name);
      // To run tests with your own credentials please uncomment following line of code
      // this.keys = new Keys { AppKey = "your app key", AppSID = "your app sid" };
      if (keys == null)
        keys = _GetKeys();
      if (string.IsNullOrEmpty(keys.AppKey) || string.IsNullOrEmpty(keys.AppSID))
        throw new FileNotFoundException("servercreds.json doesn't contain AppSID and/or AppKey");
      Configuration = new Configuration(keys.AppKey, keys.AppSID, BaseProductUri);
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
