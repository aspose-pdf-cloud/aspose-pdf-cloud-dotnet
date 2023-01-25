// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BookmarksTests.cs">
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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///     Class for testing HeaderFooter API
    /// </summary>
    [TestFixture]
    class HeaderFooterTests : TestsBase
    {
        /// <summary>
        /// Test PostDocumentTextHeader
        /// </summary>
        [Test]
        public void PostDocumentTextHeaderTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            TextHeader header = new TextHeader
            {
                Background = true,
                LeftMargin = 1,
                RightMargin = 2,
                TopMargin = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                Opacity = 1,
                Rotate = Rotation.None,
                RotateAngle = 10,
                XIndent = 0,
                YIndent = 0,
                Zoom = 1,
                TextAlignment = HorizontalAlignment.Center,
                Value = "Header",
                TextState = new TextState(FontSize: 14d, Font: "Arial Bold", 
                    ForegroundColor: new Color(255, 0, 255, 0), 
                    BackgroundColor: new Color(255, 255, 0, 0), FontStyle: FontStyles.Bold)
            };

            int startPage = 2;
            int endPage = 3;
            var response = PdfApi.PostDocumentTextHeader(name, header, startPage, endPage, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test PostDocumentTextFooter
        /// </summary>
        [Test]
        public void PostDocumentTextFooterTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            TextFooter footer = new TextFooter
            {
                Background = true,
                LeftMargin = 1,
                RightMargin = 2,
                BottomMargin = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                Opacity = 1,
                Rotate = Rotation.None,
                RotateAngle = -10,
                XIndent = 0,
                YIndent = 0,
                Zoom = 1,
                TextAlignment = HorizontalAlignment.Center,
                Value = "Footer",
                TextState = new TextState(FontSize: 14d, Font: "Arial Bold",
                    ForegroundColor: new Color(255, 0, 255, 0),
                    BackgroundColor: new Color(255, 255, 0, 0), FontStyle: FontStyles.Bold)
            };

            int startPage = 2;
            int endPage = 3;
            var response = PdfApi.PostDocumentTextFooter(name, footer, startPage, endPage, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostDocumentImageHeader
        /// </summary>
        [Test]
        public void PostDocumentImageHeaderTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            const string imageName = "Koala.jpg";
            UploadFile(imageName, imageName);

            ImageHeader header = new ImageHeader
            {
                Background = true,
                LeftMargin = 1,
                RightMargin = 2,
                TopMargin = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                Opacity = 1,
                Rotate = Rotation.None,
                RotateAngle = 0,
                XIndent = 0,
                YIndent = 0,
                Zoom = 0.1,
                FileName = Path.Combine(TempFolder, imageName)
            };

            int startPage = 2;
            int endPage = 3;
            var response = PdfApi.PostDocumentImageHeader(name, header, startPage, endPage, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostDocumentImageFooter
        /// </summary>
        [Test]
        public void PostDocumentImageFooterTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);

            const string imageName = "Koala.jpg";
            UploadFile(imageName, imageName);

            ImageFooter footer = new ImageFooter
            {
                Background = true,
                LeftMargin = 1,
                RightMargin = 2,
                BottomMargin = 20,
                HorizontalAlignment = HorizontalAlignment.Left,
                Opacity = 1,
                Rotate = Rotation.None,
                RotateAngle = 0,
                XIndent = 0,
                YIndent = 0,
                Zoom = 0.1,
                FileName = Path.Combine(TempFolder, imageName)
            };

            int startPage = 2;
            int endPage = 3;
            var response = PdfApi.PostDocumentImageFooter(name, footer, startPage, endPage, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

    }
}
