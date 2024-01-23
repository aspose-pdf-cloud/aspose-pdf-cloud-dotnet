// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ScreenAnnotationsTests.cs">
//   Copyright (c) 2024 Aspose.PDF Cloud
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
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Stamp Api
    /// </summary>
    [TestFixture]
    class TablesTests : TestsBase
    {
        private const string Name = "PdfWithTable.pdf";
        private const string Image = "Penguins.jpg";
        private const int PageNumber = 1;

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test DeleteDocumentTables
        /// </summary>
        [Test]
        public void DeleteDocumentTablesTest()
        {
            var response = PdfApi.DeleteDocumentTables(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetDocumentTables
        /// </summary>
        [Test]
        public void GetDocumentTablesTest()
        {
            var response = PdfApi.GetDocumentTables(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageTables
        /// </summary>
        [Test]
        public void GetPageTablesTest()
        {
            var response = PdfApi.GetPageTables(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeletePageTables
        /// </summary>
        [Test]
        public void DeletePageTablesTest()
        {
            var response = PdfApi.DeletePageTables(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetTable
        /// </summary>
        [Test]
        public void GetTableTest()
        {
            var tablesResponse = PdfApi.GetDocumentTables(Name, folder: TempFolder);
            string tableId = tablesResponse.Tables.List[0].Id;

            var response = PdfApi.GetTable(Name, tableId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeleteTable
        /// </summary>
        [Test]
        public void DeleteTableTest()
        {
            var tablesResponse = PdfApi.GetDocumentTables(Name, folder: TempFolder);
            string tableId = tablesResponse.Tables.List[0].Id;

            var response = PdfApi.DeleteTable(Name, tableId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostPageTables
        /// </summary>
        [Test]
        public void PostPageTablesTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);
            UploadFile(Image, Image);

            int pageNumber = 1;

            var tables = new List<Table>
            {
                DrawTable()
            };

            var response = PdfApi.PostPageTables(name, pageNumber, tables, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutTable
        /// </summary>
        [Test]
        public void PutTableTest()
        {
            UploadFile(Image, Image);

            var tablesResponse = PdfApi.GetDocumentTables(Name, folder: TempFolder);
            string tableId = tablesResponse.Tables.List[0].Id;

            var response = PdfApi.PutTable(Name, tableId, DrawTable(), folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        #region private methods
        private static Table DrawTable()
        {
            var colorBlack = new Color(255, 0, 0, 0);

            var borderGraphInfo = new GraphInfo
            {
                Color = colorBlack,
                LineWidth = 1,
            };

            var table = new Table(Rows: new List<Row>())
            {
                Top = 100,
                ColumnWidths = "150 300",
                IsBordersIncluded = true,
                DefaultCellTextState = new TextState(FontSize: 11)
                {
                    ForegroundColor = new Color(255, 0, 255, 0),
                },
                Margin = new MarginInfo
                {
                    Bottom = 10,
                    Left = 10,
                    Right = 10,
                    Top = 10
                },
                Border = new BorderInfo
                {
                    Top = borderGraphInfo,
                    Left = borderGraphInfo
                },
                DefaultCellBorder = new BorderInfo
                {
                    Right = borderGraphInfo,
                },
                DefaultCellPadding = new MarginInfo
                {
                    Top = 5,
                    Left = 5,
                    Right = 5,
                    Bottom = 5,
                },
                Rows = new List<Row>
                {
                    new Row(Cells: new List<Cell>())
                    {
                        MinRowHeight = 100,
                        Border = new BorderInfo
                        {
                            Bottom = borderGraphInfo,
                        },
                        Cells = new List<Cell>
                        {
                            new Cell
                            {
                                Paragraphs = new List<TextRect>
                                {
                                    new TextRect
                                    {
                                        Text = "BackgroundImageStorageFile field, from storage file",
                                        HorizontalAlignment = HorizontalAlignment.Center,
                                        TextState = new TextState(FontSize: 10)
                                        {
                                            ForegroundColor =
                                                new Color(255, 0x3d, 0x8e, 0xc4),
                                        }
                                    }
                                },
                            },
                            new Cell
                            {
                                BackgroundColor = colorBlack,
                                BackgroundImageStorageFile = $"{TempFolder}/{Image}"
                            }
                        }
                    },
                    new Row(Cells: new List<Cell>())
                    {
                        MinRowHeight = 100,
                        Border = new BorderInfo
                        {
                            Bottom = borderGraphInfo,
                        },
                        Cells = new List<Cell>
                        {
                            new Cell
                            {
                                Paragraphs = new List<TextRect>
                                {
                                    new TextRect
                                    {
                                        Text = "HtmlFragment",
                                        HorizontalAlignment = HorizontalAlignment.Center,
                                        TextState = new TextState(FontSize: 10)
                                        {
                                            ForegroundColor =
                                                new Color(255, 0x3d, 0x8e, 0xc4),
                                        }
                                    }
                                },
                            },
                            new Cell
                            {
                                HtmlFragment = "<ul><li>First</li><li>Second</li></ul>"
                            },
                        }
                    },
                    new Row(Cells: new List<Cell>())
                    {
                        FixedRowHeight = 100,
                        Border = new BorderInfo
                        {
                            Bottom = borderGraphInfo,
                        },
                        Cells = new List<Cell>
                        {
                            new Cell
                            {
                                Paragraphs = new List<TextRect>
                                {
                                    new TextRect
                                    {
                                        Text = "FixedRowHeight = 100",
                                    },
                                    new TextRect
                                    {
                                        Text = "Images field, from storage file, without Margin and Size",
                                        HorizontalAlignment = HorizontalAlignment.Center,
                                        TextState = new TextState(FontSize: 10)
                                        {
                                            ForegroundColor =
                                                new Color(255, 0x3d, 0x8e, 0xc4),
                                        }
                                    }
                                },
                            },
                            new Cell
                            {
                                BackgroundColor = colorBlack,
                                Images = new List<ImageFragment>{
                                    new ImageFragment(ImageFile: $"{TempFolder}/{Image}"),
                                }
                            },
                        }
                    },
                    new Row(Cells: new List<Cell>())
                    {
                        FixedRowHeight = 100,
                        Border = new BorderInfo
                        {
                            Bottom = borderGraphInfo,
                        },
                        Cells = new List<Cell>
                        {
                            new Cell
                            {
                                Paragraphs = new List<TextRect>
                                {
                                    new TextRect
                                    {
                                        Text = "FixedRowHeight = 100",
                                    },
                                    new TextRect
                                    {
                                        Text = "Images field, from storage file, with no Margin and Size = 150x50",
                                        HorizontalAlignment = HorizontalAlignment.Center,
                                        TextState = new TextState(FontSize: 10)
                                        {
                                            ForegroundColor =
                                                new Color(255, 0x3d, 0x8e, 0xc4),
                                        }
                                    }
                                },
                            },
                            new Cell
                            {
                                BackgroundColor = colorBlack,
                                Images = new List<ImageFragment>{
                                    new ImageFragment(ImageFile: $"{TempFolder}/{Image}") 
                                    {
                                        ImageScale = 0.1,
                                    }
                                }
                            },
                        }
                    },
                }
            };
            return table;
        }

        #endregion private methods
    }
}
