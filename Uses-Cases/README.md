#### Annotations
- **[Annotations/Program.cs](Annotations/Program.cs)** – Orchestrates annotation CRUD operations including retrieval, deletion, creation, and replacement.
  ```bash
  dotnet run --project Uses-Cases/Annotations/Annotations.csproj
  ```
- *[Annotations/DeletePageAnnotations.cs](Annotations/DeletePageAnnotations.cs)* – Deletes all annotations from a specified page in a PDF document.
- *[Annotations/DeleteTextAnnotation.cs](Annotations/DeleteTextAnnotation.cs)* – Deletes a specific text annotation by ID from a PDF document, including its associated popup annotations.
- *[Annotations/GetAnnotationById.cs](Annotations/GetAnnotationById.cs)* – Retrieves a specific text annotation by its ID from a PDF document.
- *[Annotations/GetAnnotations.cs](Annotations/GetAnnotations.cs)* – Retrieves all annotations from a specified page in a PDF document and returns the ID of the first text annotation found.
- *[Annotations/NewFreetextAnnotation.cs](Annotations/NewFreetextAnnotation.cs)* – Adds a new free text annotation with custom styling to a PDF document page.
- *[Annotations/NewHighlightAnnotation.cs](Annotations/NewHighlightAnnotation.cs)* – Adds a new highlight annotation with specified quad points and color to a PDF document page.
- *[Annotations/NewStrikeoutAnnotation.cs](Annotations/NewStrikeoutAnnotation.cs)* – Adds a new strikeout annotation with specified quad points and color to a PDF document page.
- *[Annotations/NewUnderlineAnnotation.cs](Annotations/NewUnderlineAnnotation.cs)* – Adds a new underline annotation with specified quad points and color to a PDF document page.
- *[Annotations/ReplaceAnnotation.cs](Annotations/ReplaceAnnotation.cs)* – Replaces the content and icon of an existing text annotation in a PDF document.

#### Bookmarks
- **[Bookmarks/Program.cs](Bookmarks/Program.cs)** – Demonstrates bookmarks management: extracts all bookmarks and by path, adds a new bookmark, deletes a bookmark, and replaces an existing one.
  ```bash
  dotnet run --project Uses-Cases/Bookmarks/Bookmarks.csproj
  ```
- *[Bookmarks/BookmarksAdd.cs](Bookmarks/BookmarksAdd.cs)* – Appends a new bookmark with specified properties to a PDF document.
- *[Bookmarks/BookmarksExtract.cs](Bookmarks/BookmarksExtract.cs)* – Extracts and displays all bookmarks present in a PDF document.
- *[Bookmarks/BookmarksExtractByPath.cs](Bookmarks/BookmarksExtractByPath.cs)* – Extracts and displays a specific bookmark from a PDF using its path.
- *[Bookmarks/BookmarksRemove.cs](Bookmarks/BookmarksRemove.cs)* – Deletes a specified bookmark from a PDF document.
- *[Bookmarks/BookmarksReplace.cs](Bookmarks/BookmarksReplace.cs)* – Replaces the properties of an existing bookmark in a PDF document.

#### ChangeLayout
- **[ChangeLayout/Program.cs](ChangeLayout/Program.cs)** – Modifies document layout by rotating pages, resizing all pages, and cropping a specific page.
  ```bash
  dotnet run --project Uses-Cases/ChangeLayout/ChangeLayout.csproj
  ```
- *[ChangeLayout/CropDocumentPage.cs](ChangeLayout/CropDocumentPage.cs)* – Crops a specified page of a PDF document to a defined rectangle and creates a new PDF.
- *[ChangeLayout/ResizeDocumentAllPages.cs](ChangeLayout/ResizeDocumentAllPages.cs)* – Resizes all pages of a PDF document by converting it to HTML and back with new dimensions.
- *[ChangeLayout/RotateDocumentsPages.cs](ChangeLayout/RotateDocumentsPages.cs)* – Rotates a range of pages in a PDF document by a specified angle.

#### Conversions
- **[Conversions/Program.cs](Conversions/Program.cs)** – Converts various image and document formats to PDF, and PDF to multiple output formats.
  ```bash
  dotnet run --project Uses-Cases/Conversions/Conversions.csproj
  ```
- *[Conversions/ConvertBMPToPDF.cs](Conversions/ConvertBMPToPDF.cs)* – Converts a BMP image file to a PDF document.
- *[Conversions/ConvertEPUBToPDF.cs](Conversions/ConvertEPUBToPDF.cs)* – Converts an EPUB file to a PDF document.
- *[Conversions/ConvertGIFToPDF.cs](Conversions/ConvertGIFToPDF.cs)* – Converts a GIF image file to a PDF document.
- *[Conversions/ConvertHTMLToPDF.cs](Conversions/ConvertHTMLToPDF.cs)* – Converts an HTML file to a PDF document with specified page dimensions.
- *[Conversions/ConvertImagesToPDF.cs](Conversions/ConvertImagesToPDF.cs)* – Converts a list of image files into a single PDF document.
- *[Conversions/ConvertJPEGToPDF.cs](Conversions/ConvertJPEGToPDF.cs)* – Converts a JPEG image file to a PDF document.
- *[Conversions/ConvertMDToPDF.cs](Conversions/ConvertMDToPDF.cs)* – Converts a Markdown file to a PDF document.
- *[Conversions/ConvertMHTMLToPDF.cs](Conversions/ConvertMHTMLToPDF.cs)* – Converts an MHTML file to a PDF document.
- *[Conversions/ConvertPCLToPDF.cs](Conversions/ConvertPCLToPDF.cs)* – Converts a PCL file to a PDF document.
- *[Conversions/ConvertPDFToDOC.cs](Conversions/ConvertPDFToDOC.cs)* – Converts a PDF document to DOC format.
- *[Conversions/ConvertPDFToDOCX.cs](Conversions/ConvertPDFToDOCX.cs)* – Converts a PDF document to DOCX format.
- *[Conversions/ConvertPDFToEPUB.cs](Conversions/ConvertPDFToEPUB.cs)* – Converts a PDF document to EPUB format.
- *[Conversions/ConvertPDFToExcel.cs](Conversions/ConvertPDFToExcel.cs)* – Converts a PDF document to XLS format.
- *[Conversions/ConvertPDFToHTML.cs](Conversions/ConvertPDFToHTML.cs)* – Converts a PDF document to a ZIP containing HTML files.
- *[Conversions/ConvertPDFToMobiXML.cs](Conversions/ConvertPDFToMobiXML.cs)* – Converts a PDF document to MobiXML format.
- *[Conversions/ConvertPDFToPowerpoint.cs](Conversions/ConvertPDFToPowerpoint.cs)* – Converts a PDF document to PPTX format.
- *[Conversions/ConvertPDFToSVG.cs](Conversions/ConvertPDFToSVG.cs)* – Converts a PDF document to a ZIP containing SVG files.
- *[Conversions/ConvertPDFToTEX.cs](Conversions/ConvertPDFToTEX.cs)* – Converts a PDF document to TEX format.
- *[Conversions/ConvertPDFToTIFF.cs](Conversions/ConvertPDFToTIFF.cs)* – Converts a PDF document to TIFF format.
- *[Conversions/ConvertPDFToXLSX.cs](Conversions/ConvertPDFToXLSX.cs)* – Converts a PDF document to XLSX format.
- *[Conversions/ConvertPDFToXML.cs](Conversions/ConvertPDFToXML.cs)* – Converts a PDF document to XML format.
- *[Conversions/ConvertPDFToXPS.cs](Conversions/ConvertPDFToXPS.cs)* – Converts a PDF document to XPS format.
- *[Conversions/ConvertPNGToPDF.cs](Conversions/ConvertPNGToPDF.cs)* – Converts a PNG image file to a PDF document.
- *[Conversions/ConvertPSToPDF.cs](Conversions/ConvertPSToPDF.cs)* – Converts a PostScript (PS) file to a PDF document.

#### CreateDocument
- **[CreateDocument/Program.cs](CreateDocument/Program.cs)** – Creates a new PDF document with custom properties and a simple blank document.
  ```bash
  dotnet run --project Uses-Cases/CreateDocument/CreateDocument.csproj
  ```
- *[CreateDocument/ClreatePdfDocumentSimple.cs](CreateDocument/ClreatePdfDocumentSimple.cs)* – Creates a simple, blank PDF document.
- *[CreateDocument/CreatePdfDocument.cs](CreateDocument/CreatePdfDocument.cs)* – Creates a new PDF document with specified page count, dimensions, and document properties.

#### EnvryptDecrypt
- **[EnvryptDecrypt/Program.cs](EnvryptDecrypt/Program.cs)** – Manages PDF security by encrypting, decrypting, and changing passwords for documents.
  ```bash
  dotnet run --project Uses-Cases/EnvryptDecrypt/EncryptDecrypt.csproj
  ```
- *[EnvryptDecrypt/DecryptPdf.cs](EnvryptDecrypt/DecryptPdf.cs)* – Removes encryption from a password-protected PDF document.
- *[EnvryptDecrypt/EncryptPdf.cs](EnvryptDecrypt/EncryptPdf.cs)* – Applies encryption with user and owner passwords to a PDF document.
- *[EnvryptDecrypt/PasswordModify.cs](EnvryptDecrypt/PasswordModify.cs)* – Changes the user and owner passwords of an encrypted PDF document.

#### HeadersFooters
- **[HeadersFooters/Program.cs](HeadersFooters/Program.cs)** – Adds image and text headers and footers to specified pages of a PDF document.
  ```bash
  dotnet run --project Uses-Cases/HeadersFooters/HeadersFooters.csproj
  ```
- *[HeadersFooters/HeadersFooterAddTextFooter.cs](HeadersFooters/HeadersFooterAddTextFooter.cs)* – Appends a text footer to a range of pages in a PDF document.
- *[HeadersFooters/HeadersFootersAddImageFooter.cs](HeadersFooters/HeadersFootersAddImageFooter.cs)* – Appends an image footer to a range of pages in a PDF document.
- *[HeadersFooters/HeadersFootersAddImageHeader.cs](HeadersFooters/HeadersFootersAddImageHeader.cs)* – Appends an image header to a range of pages in a PDF document.
- *[HeadersFooters/HeadersFootersAddTextHeader.cs](HeadersFooters/HeadersFootersAddTextHeader.cs)* – Appends a text header to a range of pages in a PDF document.

#### Links
- **[Links/Program.cs](Links/Program.cs)** – Manages hyperlinks in a PDF: extracts links, adds a new link, deletes a link, and replaces a link.
  ```bash
  dotnet run --project Uses-Cases/Links/Links.csproj
  ```
- *[Links/LinksAdd.cs](Links/LinksAdd.cs)* – Adds a new hyperlink annotation to a specified page in a PDF document.
- *[Links/LinksExtract.cs](Links/LinksExtract.cs)* – Extracts and displays all link annotations from a specific page in a PDF document.
- *[Links/LinksExtractById.cs](Links/LinksExtractById.cs)* – Extracts and displays a specific link annotation by its ID from a PDF document.
- *[Links/LinksRemove.cs](Links/LinksRemove.cs)* – Deletes a specified link annotation from a PDF document.
- *[Links/LinksReplace.cs](Links/LinksReplace.cs)* – Replaces the properties of an existing link annotation in a PDF document.

#### Merges
- **[Merges/Program.cs](Merges/Program.cs)** – Merges multiple PDF documents into a single output file.
  ```bash
  dotnet run --project Uses-Cases/Merges/Merges.csproj
  ```
- *[Merges/MergeDocuments.cs](Merges/MergeDocuments.cs)* – Merges a list of PDF documents into one combined PDF file.

#### Pages
- **[Pages/Program.cs](Pages/Program.cs)** – Performs comprehensive page management: extracts page info, converts to image, adds/deletes/moves pages, adds stamps, and counts words.
  ```bash
  dotnet run --project Uses-Cases/Pages/Pages.csproj
  ```
- *[Pages/PagesAdd.cs](Pages/PagesAdd.cs)* – Appends a new blank page to a PDF document.
- *[Pages/PagesAddImageStamp.cs](Pages/PagesAddImageStamp.cs)* – Appends an image stamp to a specified page in a PDF document.
- *[Pages/PagesAddTextStamp.cs](Pages/PagesAddTextStamp.cs)* – Appends a text stamp to a specified page in a PDF document.
- *[Pages/PagesDelete.cs](Pages/PagesDelete.cs)* – Deletes a specified page from a PDF document.
- *[Pages/PagesExtractInfo.cs](Pages/PagesExtractInfo.cs)* – Extracts and displays information about all pages in a PDF document.
- *[Pages/PagesMove.cs](Pages/PagesMove.cs)* – Moves a page to a new index within a PDF document.
- *[Pages/PagesSaveToImage.cs](Pages/PagesSaveToImage.cs)* – Converts a specified PDF page to a PNG image file.
- *[Pages/PagesWordsCount.cs](Pages/PagesWordsCount.cs)* – Counts the number of words on each page of a PDF document.

#### Parser
- **[Parser/Program.cs](Parser/Program.cs)** – Extracts structured data from PDFs: text boxes, tables, images, and exports form fields to FDF/XML.
  ```bash
  dotnet run --project Uses-Cases/Parser/Parser.csproj
  ```
- *[Parser/ExportFormToFdf.cs](Parser/ExportFormToFdf.cs)* – Exports form field data from a PDF document to an FDF file.
- *[Parser/ExportFormToXML.cs](Parser/ExportFormToXML.cs)* – Exports form field data from a PDF document to an XML file.
- *[Parser/GetImages.cs](Parser/GetImages.cs)* – Extracts images from a specified page of a PDF document and saves them as PNG files.
- *[Parser/GetTables.cs](Parser/GetTables.cs)* – Extracts recognized tables from a PDF document and saves their data as JSON.
- *[Parser/GetTextBoxes.cs](Parser/GetTextBoxes.cs)* – Extracts text box field data from a PDF document and saves it as JSON.

#### Signatures
- **[Signatures/Program.cs](Signatures/Program.cs)** – Manages digital signatures: adds a new signature, extracts existing signatures, replaces a signature, and verifies a signature.
  ```bash
  dotnet run --project Uses-Cases/Signatures/Signatures.csproj
  ```
- *[Signatures/AddSignature.cs](Signatures/AddSignature.cs)* – Adds a new digital signature field to a PDF document.
- *[Signatures/GetSignatures.cs](Signatures/GetSignatures.cs)* – Extracts and displays information about all signature fields in a PDF document.
- *[Signatures/ReplaceSignature.cs](Signatures/ReplaceSignature.cs)* – Replaces an existing digital signature field in a PDF document.
- *[Signatures/VerifySignature.cs](Signatures/VerifySignature.cs)* – Verifies the validity of a specific digital signature in a PDF document.

#### Stamps
- **[Stamps/Program.cs](Stamps/Program.cs)** – Manages document stamps: adds image and text stamps, extracts stamp info, and deletes stamps from the document or a specific page.
  ```bash
  dotnet run --project Uses-Cases/Stamps/Stamps.csproj
  ```
- *[Stamps/StampsDelete.cs](Stamps/StampsDelete.cs)* – Deletes all stamps from a PDF document.
- *[Stamps/StampsDeleteOnPage.cs](Stamps/StampsDeleteOnPage.cs)* – Deletes all stamps from a specified page of a PDF document.
- *[Stamps/StampsExtract.cs](Stamps/StampsExtract.cs)* – Extracts and displays information about all stamps in a PDF document.
- *[Stamps/StampsNewImages.cs](Stamps/StampsNewImages.cs)* – Appends an image stamp to all pages of a PDF document.
- *[Stamps/StampsNewTexts.cs](Stamps/StampsNewTexts.cs)* – Appends a text stamp to all pages of a PDF document.

#### Tables
- **[Tables/Program.cs](Tables/Program.cs)** – Manages tables in PDFs: extracts tables, adds a new table, and deletes tables from the document, a page, or by ID.
  ```bash
  dotnet run --project Uses-Cases/Tables/Tables.csproj
  ```
- *[Tables/AddTable.cs](Tables/AddTable.cs)* – Appends a new table to a specified page in a PDF document.
- *[Tables/DeleteTable.cs](Tables/DeleteTable.cs)* – Deletes a specific table by its ID from a PDF document.
- *[Tables/DeleteTableOnPage.cs](Tables/DeleteTableOnPage.cs)* – Deletes all tables from a specified page of a PDF document.
- *[Tables/DeleteTables.cs](Tables/DeleteTables.cs)* – Deletes all tables from a PDF document.
- *[Tables/GetTable.cs](Tables/GetTable.cs)* – Extracts and displays a specific table by its ID from a PDF document.
- *[Tables/GetTables.cs](Tables/GetTables.cs)* – Extracts and displays all tables from a PDF document.
- *[Tables/GetTablesOnPage.cs](Tables/GetTablesOnPage.cs)* – Extracts and displays all tables from a specified page of a PDF document.
- *[Tables/ReplaceTable.cs](Tables/ReplaceTable.cs)* – Replaces an existing table with a new one in a PDF document.
