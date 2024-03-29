// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FieldsTests.cs">
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
    ///  Class for testing Fields Api
    /// </summary>
    [TestFixture]
    public class FieldsTests : TestsBase
    {
        /// <summary>
        /// Test GetField
        /// </summary>
        [Test]
        public void GetFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetField(name, "textField", folder: TempFolder);
            Assert.That(response.Field, Is.Not.Null);
        }

        /// <summary>
        /// Test GetFields
        /// </summary>
        [Test]
        public void GetFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetFields(name, folder: TempFolder);
            Assert.That(response.Fields, Is.Not.Null);
        }

        /// <summary>
        /// Test PostCreateField
        /// </summary>
        [Test]
        public void PostCreateFieldTest()
        {
            const string name = "Hello world.pdf";
            UploadFile(name, name);

            var field = new Field(
                Name: "checkboxfield",
                Type: FieldType.Boolean,
                Values: new List<string> {"1"},
                Rect: new Rectangle(
                    LLX: 50,
                    LLY: 200,
                    URX: 200,
                    URY: 400
                ));
            var response = PdfApi.PostCreateField(name, 1, field, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutUpdateField
        /// </summary>
        [Test]
        public void PutUpdateFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var fieldName = "textField";

            var field = new Field(
                Name: fieldName,
                Type: FieldType.Text,
                Values: new List<string> {"Text field updated value."},
                Rect: new Rectangle(125, 735, 200, 752)
            );

            var response = PdfApi.PutUpdateField(name, fieldName, field, folder: TempFolder);
            Assert.That(response.Field, Is.Not.Null);
        }

        /// <summary>
        /// Test PutUpdateFields
        /// </summary>
        [Test]
        public void PutUpdateFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var fieldName = "textField";

            var fields = new Fields(null, new List<Field>()
            {
                new Field(
                    Name: fieldName,
                    Type: FieldType.Text,
                    Values: new List<string> {"Text field updated value."})

            });

            var response = PdfApi.PutUpdateFields(name, fields, folder: TempFolder);
            Assert.That(response.Fields, Is.Not.Null);
        }


        /// <summary>
        /// Test DeleteField
        /// </summary>
        [Test]
        public void DeleteFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var fieldName = "textField";

            var response = PdfApi.DeleteField(name, fieldName, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutFieldsFlatten
        /// </summary>
        [Test]
        public void PutFieldsFlattenTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.PutFieldsFlatten(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostFlattenDocument
        /// </summary>
        [Test]
        public void PostFlattenDocumentTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response =
                PdfApi.PostFlattenDocument(name, updateAppearances: true, hideButtons: true, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetDocumentSignatureFields
        /// </summary>
        [Test]
        public void GetDocumentSignatureFieldsTest()
        {
            const string name = "adbe.x509.rsa_sha1.valid.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetDocumentSignatureFields(name, folder: TempFolder);
            Assert.That(response.Fields, Is.Not.Null);
        }

        /// <summary>
        /// Test GetPageSignatureFields
        /// </summary>
        [Test]
        public void GetPageSignatureFieldsTest()
        {
            const string name = "adbe.x509.rsa_sha1.valid.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPageSignatureFields(name, pageNumber: 1, folder: TempFolder);
            Assert.That(response.Fields, Is.Not.Null);
        }

        /// <summary>
        /// Test GetSignatureField
        /// </summary>
        [Test]
        public void GetSignatureFieldTest()
        {
            const string name = "adbe.x509.rsa_sha1.valid.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetSignatureField(name, fieldName: "Signature1", folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostSignatureField
        /// </summary>
        [Test]
        public void PostSignatureFieldTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);
            const string SignatureName = "33226.p12";
            UploadFile(SignatureName, SignatureName);

            SignatureField field = new SignatureField(PageIndex: 1)
            {
                PartialName = "sign1",
                Signature = new Signature(
                    Authority: "Sergey Smal",
                    Contact: "test@mail.ru",
                    Date: "08/01/2012 12:15:00.000 PM",
                    FormFieldName: "Signature1",
                    Location: "Ukraine",
                    Password: "sIikZSmz",
                    Rectangle: new Rectangle(
                        LLX: 100,
                        LLY: 100,
                        URX: 0,
                        URY: 0),
                    SignaturePath: Path.Combine(TempFolder, SignatureName),
                    SignatureType: SignatureType.PKCS7,
                    Visible: true,
                    ShowProperties: false
                ),
                Rect = new Rectangle(100, 100, 500, 200),
            };

            var response = PdfApi.PostSignatureField(name, field, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
        /// <summary>
        /// Test PutSignatureField
        /// </summary>
        [Test]
        public void PutSignatureFieldTest()
        {
            const string name = "adbe.x509.rsa_sha1.valid.pdf";
            UploadFile(name, name);
            const string SignatureName = "33226.p12";
            UploadFile(SignatureName, SignatureName);

            SignatureField field = new SignatureField(PageIndex: 1)
            {
                PartialName = "sign1",
                Signature = new Signature(
                    Authority: "Sergey Smal",
                    Contact: "test@mail.ru",
                    Date: "08/01/2012 12:15:00.000 PM",
                    FormFieldName: "Signature1",
                    Location: "Ukraine",
                    Password: "sIikZSmz",
                    Rectangle: new Rectangle(
                        LLX: 100,
                        LLY: 100,
                        URX: 0,
                        URY: 0),
                    SignaturePath: Path.Combine(TempFolder, SignatureName),
                    SignatureType: SignatureType.PKCS7,
                    Visible: true,
                    ShowProperties: false
                ),
                Rect = new Rectangle(100, 100, 500, 200),
            };

            var response = PdfApi.PutSignatureField(name, "Signature1", field, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
        
        /// <summary>
        /// Test GetDocumentTextBoxFields
        /// </summary>
        [Test]
        public void GetDocumentTextBoxFieldsTest()
        {
            const string name = "FormDataTextBox.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetDocumentTextBoxFields(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageTextBoxFields
        /// </summary>
        [Test]
        public void GetPageTextBoxFieldsTest()
        {
            const string name = "FormDataTextBox.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPageTextBoxFields(name, pageNumber: 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetTextBoxField
        /// </summary>
        [Test]
        public void GetTextBoxFieldTest()
        {
            const string name = "FormDataTextBox.pdf";
            UploadFile(name, name);
            //const string name = "4pages.pdf";

            //var response = PdfApi.GetTextBoxField(name, fieldName: "testField", folder: TempFolder);
            var response = PdfApi.GetTextBoxField(name, fieldName: "Petitioner", folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostTextBoxFieldTest
        /// </summary>
        [Test]
        public void PostTextBoxFieldTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);
            var textBoxes = new List<TextBoxField>
            {
                new TextBoxField(PageIndex: 1, IsGroup: false)
                {
                    Border = new Border()
                    {
                        Style = BorderStyle.Underline,
                        Width = 3,
                        EffectIntensity = 0,
                        Effect = BorderEffect.None,
                        Dash = new Dash(On: 3, Off: 6),
                    },
                    Color = new Color(255, 0, 0, 0),
                    Multiline = false,
                    SpellCheck = true,
                    Scrollable = true,
                    MaxLen = 100,
                    Rect = new Rectangle(35.5669, 650.061, 290.567, 671.181),
                    Value = null,
                    PartialName = "testField",
                    Highlighting = LinkHighlightingMode.Invert,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,

                },
                new TextBoxField(PageIndex: 2, IsGroup: false)
                {
                    Color = new Color(255, 255, 0, 0),
                    Multiline = true,
                    MaxLen = 100,
                    Rect = new Rectangle(100, 100, 500, 200),
                    Value = "Page 2\nValue",
                    PartialName = "testField1",
                }
            };

            var response = PdfApi.PostTextBoxFields(name, textBoxes, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutTextBoxFieldTest
        /// </summary>
        [Test]
        public void PutTextBoxFieldTest()
        {
            const string name = "FormDataTextBox.pdf";
            UploadFile(name, name);

            var textBox = new TextBoxField(PageIndex: 1, IsGroup: false)
            {
                Color = new Color(255, 255, 0, 0),
                Multiline = false,
                MaxLen = 100,
                Rect = new Rectangle(35, 650, 290, 600),
                Value = "Value!\nValue",
                PartialName = "testField",
            };

            var response = PdfApi.PutTextBoxField(name, "Petitioner", textBox, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetDocumentCheckBoxFieldsTest
        /// </summary>
        [Test]
        public void GetDocumentCheckBoxFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetDocumentCheckBoxFields(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageCheckBoxFieldsTest
        /// </summary>
        [Test]
        public void GetPageCheckBoxFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPageCheckBoxFields(name, pageNumber: 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetCheckBoxFieldTest
        /// </summary>
        [Test]
        public void GetCheckBoxFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetCheckBoxField(name, fieldName: "checkboxField", folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test PostCheckBoxFieldsTest
        /// </summary>
        [Test]
        public void PostCheckBoxFieldsTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);
            var checkBoxes = new List<CheckBoxField>
            {
                new CheckBoxField(PageIndex: 1, IsGroup: false, _Checked: true)
                {
                    Color = new Color(255, 255, 0, 0),
                    Rect = new Rectangle(100, 100, 200, 200),
                    ExportValue = "true",
                    PartialName = "testField",
                    Style = BoxStyle.Cross
                },
                new CheckBoxField(PageIndex: 1, IsGroup: false, _Checked: false)
                {
                    Color = new Color(255, 0, 255, 0),
                    Rect = new Rectangle(200, 200, 400, 400),
                    ExportValue = "false",
                    PartialName = "testField1",
                    _Checked = false,
                    Style = BoxStyle.Diamond
                }
            };

            var response = PdfApi.PostCheckBoxFields(name, checkBoxes, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutCheckBoxFieldTest
        /// </summary>
        [Test]
        public void PutCheckBoxFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);
            var checkBox = new CheckBoxField(PageIndex: 1, IsGroup: false, _Checked: true)
            {
                Color = new Color(255, 255, 0, 0),
                Rect = new Rectangle(100, 100, 200, 200),
                ExportValue = "true",
                PartialName = "testField",
                Style = BoxStyle.Star
            };

            var response =
                PdfApi.PutCheckBoxField(name, fieldName: "checkboxField", field: checkBox, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test GetDocumentRadioButtonFieldsTest
        /// </summary>
        [Test]
        public void GetDocumentRadioButtonFieldsTest()
        {
            //const string name = "4pages.pdf";
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetDocumentRadioButtonFields(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageRadioButtonFieldsTest
        /// </summary>
        [Test]
        public void GetPageRadioButtonFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPageRadioButtonFields(name, pageNumber: 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetRadioButtonFieldTest
        /// </summary>
        [Test]
        public void GetRadioButtonFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetRadioButtonField(name, fieldName: "radiobuttonField", folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostRadioButtonFieldsTest
        /// </summary>
        [Test]
        public void PostRadioButtonFieldsTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);
            var radioButtons = new List<RadioButtonField>
            {
                new RadioButtonField(PageIndex: 1, IsGroup: false, Selected: 1)
                {
                    Color = new Color(255, 255, 0, 0),
                    Rect = new Rectangle(100, 100, 160, 140),
                    PartialName = "testField",
                    Style = BoxStyle.Cross,
                    Margin = new MarginInfo {Bottom = 0, Left = 0, Right = 0, Top = 0},
                    RadioButtonOptionsField = new List<RadioButtonOptionField>
                    {
                        new RadioButtonOptionField(PageIndex: 1, IsGroup: false)
                        {
                            OptionName = "1",
                            Rect = new Rectangle(100, 130, 160, 140),
                            Style = BoxStyle.Square
                        },
                        new RadioButtonOptionField(PageIndex: 1, IsGroup: false)
                        {
                            OptionName = "2",
                            Rect = new Rectangle(150, 120, 160, 130),
                        }
                    }
                }
            };

            var response = PdfApi.PostRadioButtonFields(name, radioButtons, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutRadioButtonFieldTest
        /// </summary>
        [Test]
        public void PutRadioButtonFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);
            RadioButtonField field =
                new RadioButtonField(PageIndex: 1, IsGroup: false, Selected: 1)
                {
                    Color = new Color(255, 255, 0, 0),
                    Rect = new Rectangle(100, 100, 160, 140),
                    PartialName = "testField",
                    Style = BoxStyle.Cross,
                    Margin = new MarginInfo {Bottom = 0, Left = 0, Right = 0, Top = 0},
                    RadioButtonOptionsField = new List<RadioButtonOptionField>
                    {
                        new RadioButtonOptionField(PageIndex: 1, IsGroup: false)
                        {
                            OptionName = "1",
                            Rect = new Rectangle(100, 130, 160, 140),
                            Style = BoxStyle.Square
                        },
                        new RadioButtonOptionField(PageIndex: 1, IsGroup: false)
                        {
                            OptionName = "2",
                            Rect = new Rectangle(150, 120, 160, 130),
                        }
                    }
                };

            var response =
                PdfApi.PutRadioButtonField(name, fieldName: "radiobuttonField", field: field, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        // ComboBoxField

        /// <summary>
        /// Test GetDocumentComboBoxFieldsTest
        /// </summary>
        [Test]
        public void GetDocumentComboBoxFieldsTest()
        {
            //const string name = "4pages.pdf";
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetDocumentComboBoxFields(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageComboBoxFieldsTest
        /// </summary>
        [Test]
        public void GetPageComboBoxFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPageComboBoxFields(name, pageNumber: 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetComboBoxFieldTest
        /// </summary>
        [Test]
        public void GetComboBoxFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetComboBoxField(name, fieldName: "comboboxField", folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test PostComboBoxFieldsTest
        /// </summary>
        [Test]
        public void PostComboBoxFieldsTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);
            var comboBoxes = new List<ComboBoxField>
            {
                new ComboBoxField(PageIndex: 1, IsGroup: false, Selected: 2)
                {
                    Color = new Color(255, 255, 0, 0),
                    Rect = new Rectangle(100, 100, 160, 140),
                    PartialName = "testField",
                    Margin = new MarginInfo {Bottom = 0, Left = 0, Right = 0, Top = 0},
                    Options = new List<Option>
                    {
                        new Option
                        {
                            Name = "one",
                            Value = "one",
                        },
                        new Option
                        {
                            Name = "two",
                            Value = "two",
                            Selected = true,
                        },
                    }
                }
            };

            var response = PdfApi.PostComboBoxFields(name, comboBoxes, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutComboBoxFieldTest
        /// </summary>
        [Test]
        public void PutComboBoxFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);
            var comboBox = new ComboBoxField(PageIndex: 1, IsGroup: false, Selected: 2)
            {
                Color = new Color(255, 255, 0, 0),
                Rect = new Rectangle(100, 100, 160, 140),
                PartialName = "testField",
                Margin = new MarginInfo {Bottom = 0, Left = 0, Right = 0, Top = 0},
                Options = new List<Option>
                {
                    new Option
                    {
                        Name = "one",
                        Value = "one",
                    },
                    new Option
                    {
                        Name = "two",
                        Value = "two",
                        Selected = true,
                    },
                }
            };


            var response = PdfApi.PutComboBoxField(name, fieldName: "comboboxField", comboBox, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        // ListBoxField

        /// <summary>
        /// Test GetDocumentListBoxFieldsTest
        /// </summary>
        [Test]
        public void GetDocumentListBoxFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetDocumentListBoxFields(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageListBoxFieldsTest
        /// </summary>
        [Test]
        public void GetPageListBoxFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetPageListBoxFields(name, pageNumber: 1, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetListBoxFieldTest
        /// </summary>
        [Test]
        public void GetListBoxFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetListBoxField(name, fieldName: "listboxField", folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }


        /// <summary>
        /// Test PostListBoxFieldsTest
        /// </summary>
        [Test]
        public void PostListBoxFieldsTest()
        {
            const string name = "4pages.pdf";
            UploadFile(name, name);
            var listBoxes = new List<ListBoxField>
            {
                new ListBoxField(PageIndex: 1)
                {
                    SelectedItems = new List<int?> {1, 4},
                    MultiSelect = true,
                    Color = new Color(255, 255, 0, 0),
                    Rect = new Rectangle(100, 100, 180, 180),
                    PartialName = "testField",
                    Margin = new MarginInfo {Bottom = 0, Left = 0, Right = 0, Top = 0},
                    Options = new List<Option>
                    {
                        new Option
                        {
                            Name = "one",
                            Value = "one",
                        },
                        new Option
                        {
                            Name = "two",
                            Value = "two",
                        },
                        new Option
                        {
                            Name = "three",
                            Value = "three",
                        },
                        new Option
                        {
                            Name = "four",
                            Value = "four",
                        },
                    }
                }
            };

            var response = PdfApi.PostListBoxFields(name, listBoxes, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutListBoxFieldTest
        /// </summary>
        [Test]
        public void PutListBoxFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);
            var listBox = new ListBoxField(PageIndex: 1)
            {
                SelectedItems = new List<int?> { 1, 4 },
                MultiSelect = true,
                Color = new Color(255, 255, 0, 0),
                Rect = new Rectangle(100, 100, 180, 180),
                PartialName = "testField",
                Margin = new MarginInfo { Bottom = 0, Left = 0, Right = 0, Top = 0 },
                Options = new List<Option>
                {
                    new Option
                    {
                        Name = "one",
                        Value = "one",
                    },
                    new Option
                    {
                        Name = "two",
                        Value = "two",
                    },
                    new Option
                    {
                        Name = "three",
                        Value = "three",
                    },
                    new Option
                    {
                        Name = "four",
                        Value = "four",
                    },
                }
            };


            var response = PdfApi.PutListBoxField(name, fieldName: "listboxField", listBox, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}
