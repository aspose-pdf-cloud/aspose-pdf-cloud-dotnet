// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BookmarksTests.cs">
//   Copyright (c) 2019 Aspose.PDF Cloud
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

using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Bookmarks Api
    /// </summary>
    [TestFixture]
    public class BookmarksTests : TestsBase
    {
        
        /// <summary>
        /// Test GetDocumentBookmarks
        /// </summary>
        [Test]
        public void GetDocumentBookmarksTest()
        {
            const string name = "PdfWithBookmarks.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetDocumentBookmarks(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetBookmarks
        /// </summary>
        [Test]
        public void GetBookmarksTest()
        {
            const string name = "PdfWithBookmarks.pdf";
            UploadFile(name, name);

            string bookmarkPath = "1";

            var response = PdfApi.GetBookmarks(name, bookmarkPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetBookmark
        /// </summary>
        [Test]
        public void GetBookmarkTest()
        {
            const string name = "PdfWithBookmarks.pdf";
            UploadFile(name, name);

            string bookmarkPath = "1";

            var response = PdfApi.GetBookmark(name, bookmarkPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeleteDocumentBookmarks
        /// </summary>
        [Test]
        public void DeleteDocumentBookmarksTest()
        {
            const string name = "PdfWithBookmarks.pdf";
            UploadFile(name, name);

            var response = PdfApi.DeleteDocumentBookmarks(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeleteBookmark
        /// </summary>
        [Test]
        public void DeleteBookmarkByPathTest()
        {
            const string name = "PdfWithBookmarks.pdf";
            UploadFile(name, name);

            string bookmarkPath = "1/1";

            var response = PdfApi.DeleteBookmark(name, bookmarkPath, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostBookmark
        /// </summary>
        [Test]
        public void PostBookmarkTest()
        {
            const string name = "PdfWithBookmarks.pdf";
            UploadFile(name, name);

            string bookmarkPath = "1/1";

            var bookmark = new Bookmark();
            bookmark.Action = "GoTo";
            bookmark.Bold = true;
            bookmark.Italic = false;
            bookmark.Title = "New Bookmark XYZ";
            bookmark.PageDisplay = "XYZ";
            bookmark.PageDisplayBottom = 10;
            bookmark.PageDisplayLeft = 10;
            bookmark.PageDisplayRight = 10;
            bookmark.PageDisplayTop = 10;
            bookmark.PageDisplayZoom = 2;
            bookmark.PageNumber = 2;
            bookmark.Color = new Color(255, 255, 0, 0);
            var bookmarks = new List<Bookmark>();
            bookmarks.Add(bookmark);

            var response = PdfApi.PostBookmark(name, bookmarkPath, bookmarks, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutBookmark
        /// </summary>
        [Test]
        public void PutBookmarkTest()
        {
            const string name = "PdfWithBookmarks.pdf";
            UploadFile(name, name);

            string bookmarkPath = "2";

            var bookmark = new Bookmark();
            bookmark.Action = "GoTo";
            bookmark.Bold = true;
            bookmark.Italic = false;
            bookmark.Title = "New Bookmark XYZ";
            bookmark.PageDisplay = "XYZ";
            bookmark.PageDisplayBottom = 10;
            bookmark.PageDisplayLeft = 10;
            bookmark.PageDisplayRight = 10;
            bookmark.PageDisplayTop = 10;
            bookmark.PageDisplayZoom = 2;
            bookmark.PageNumber = 2;
            bookmark.Color = new Color(255, 255, 0, 0);

            var response = PdfApi.PutBookmark(name, bookmarkPath, bookmark, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
    }
}
