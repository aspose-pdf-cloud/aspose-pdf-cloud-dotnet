# Aspose.PDF Cloud SDK for .NET — Agent Analysis

> **Repository:** [aspose-pdf-cloud/aspose-pdf-cloud-dotnet](https://github.com/aspose-pdf-cloud/aspose-pdf-cloud-dotnet)  
> **Version:** 26.7 | **NuGet:** `Aspose.Pdf.Cloud`  
> **License:** MIT | **.NET Targets:** `net452`, `netstandard2.0`  
> **API Version:** v3.0

---

## 1. Repository Overview

The **Aspose.PDF Cloud SDK for .NET** is a generated REST API client that wraps the Aspose.PDF Cloud API v3.0. It enables .NET applications to perform a wide range of PDF document processing operations — creation, manipulation, conversion, and rendering — entirely in the cloud.

The SDK is auto-generated from the OpenAPI specification and follows a **multi-project, namespace-based** structure. The core library (`Aspose.Pdf.Cloud.Sdk`) contains the API client, models, and services organized into three namespaces: `Api`, `Client`, and `Model`.

---

## 2. Architecture & Core Components

### 2.1 Solution Structure

```
aspose-pdf-cloud-dotnet/
├── Aspose.Pdf.Cloud.Sdk.sln          # Visual Studio solution
├── src/
│   ├── Aspose.Pdf.Cloud.Sdk/         # Core SDK library
│   │   ├── Aspose.Pdf.Cloud.Sdk.csproj
│   │   ├── Api/
│   │   │   └── PdfApi.cs             # PdfApi — 200+ API methods (~86K lines)
│   │   ├── Client/
│   │   │   ├── ApiClient.cs          # HTTP client, OAuth2 auth, request building
│   │   │   ├── ApiException.cs       # API exception class
│   │   │   ├── ApiResponse.cs        # Generic HTTP response wrapper
│   │   │   ├── Configuration.cs      # Configuration struct & factory
│   │   │   ├── ExceptionFactory.cs   # Default exception factory
│   │   │   ├── IApiAccessor.cs       # API accessor interface
│   │   │   └── SwaggerDateConverter.cs
│   │   ├── Extensions/
│   │   │   └── ListExtensions.cs     # Collection helpers
│   │   └── Model/                    # Flat model files (~250+ files)
│   ├── Aspose.Pdf.Cloud.Sdk.Test/    # NUnit unit tests
│   │   ├── TestBase.cs               # Test base class with auth setup
│   │   └── {Feature}Tests.cs         # Per-feature test files
│   └── ...                           # (project files, config)
├── docs/                             # Markdown API docs
├── settings/
│   └── credentials.json              # Credentials template
├── testData/                         # Test fixture PDF files
└── Uses-Cases/                       # Domain-specific runnable examples
```

### 2.2 Core Files

| File | Purpose |
|------|---------|
| **`Api/PdfApi.cs`** | `PdfApi` class implementing `IPdfApi` — the main API surface with all REST endpoint methods (200+ methods, ~86K lines) |
| **`Client/ApiClient.cs`** | HTTP client with OAuth2 client credentials flow, JWT token caching, multipart upload, request building, response deserialization |
| **`Client/Configuration.cs`** | `Configuration` class holding `SelfHost`, `ClientId`, `ClientSecret`, `BasePath`, `Timeout`, `UserAgent`, default headers, `DateTimeFormat` |
| **`Client/ApiResponse.cs`** | `ApiResponse<T>` — generic wrapper with `StatusCode`, `Headers`, `Data` |
| **`Client/ApiException.cs`** | `ApiException` — extends `Exception` with `ErrorCode` and `ErrorContent` |
| **`Model/AsposeResponse.cs`** | `AsposeResponse` — base response type with `Code` (int?) and `Status` (string) |

---

## 3. Data Model Organization

### 3.1 Namespaces

All SDK code lives under the `Aspose.Pdf.Cloud.Sdk` root namespace with three sub-namespaces:

| Namespace | Contents |
|-----------|----------|
| `Aspose.Pdf.Cloud.Sdk.Api` | `PdfApi` class and `IPdfApi` interface |
| `Aspose.Pdf.Cloud.Sdk.Client` | `ApiClient`, `Configuration`, `ApiResponse<T>`, `ApiException`, `SwaggerDateConverter`, `ExceptionFactory`, `IApiAccessor` |
| `Aspose.Pdf.Cloud.Sdk.Model` | All model/DTO classes |

### 3.2 Model Files

All models are flat files in the `Model/` directory. Each PDF concept gets its own file:

| Category | Example Files |
|----------|---------------|
| **Annotations** | `Annotation.cs`, `AnnotationInfo.cs`, `AnnotationType.cs`, `AnnotationFlags.cs`, `AnnotationState.cs`, `CaretAnnotation.cs`, `CircleAnnotation.cs`, `FileAttachmentAnnotation.cs`, `FreeTextAnnotation.cs`, `HighlightAnnotation.cs`, `InkAnnotation.cs`, `LineAnnotation.cs`, `LinkAnnotation.cs`, `MovieAnnotation.cs`, `PolygonAnnotation.cs`, `PolyLineAnnotation.cs`, `PopupAnnotation.cs`, `RedactionAnnotation.cs`, `ScreenAnnotation.cs`, `SoundAnnotation.cs`, `SquareAnnotation.cs`, `SquigglyAnnotation.cs`, `StampAnnotation.cs`, `StrikeOutAnnotation.cs`, `TextAnnotation.cs`, `UnderlineAnnotation.cs`, `MarkupAnnotation.cs` |
| **Form Fields** | `Field.cs`, `FieldType.cs`, `FormField.cs`, `CheckBoxField.cs`, `ComboBoxField.cs`, `ListBoxField.cs`, `RadioButtonField.cs`, `RadioButtonOptionField.cs`, `TextBoxField.cs`, `SignatureField.cs`, `ChoiceField.cs` |
| **Document** | `Document.cs`, `DocumentConfig.cs`, `DocumentProperty.cs`, `DocumentProperties.cs`, `DisplayProperties.cs`, `DocumentPrivilege.cs`, `DocumentLayers.cs` |
| **Pages** | `Page.cs`, `Pages.cs`, `PageLayout.cs`, `PageMode.cs`, `PageRange.cs`, `PageWordCount.cs` |
| **Stamps** | `Stamp.cs`, `ImageStamp.cs`, `TextStamp.cs`, `PageNumberStamp.cs`, `PdfPageStamp.cs`, `ImageStampPageSpecified.cs`, `TextStampPageSpecified.cs` |
| **Conversions** | `DocFormat.cs`, `HtmlDocumentType.cs`, `EpubRecognitionMode.cs`, `ColorDepth.cs`, `CompressionType.cs`, `PdfAType.cs`, `OutputFormat.cs` |
| **Storage** | `FileVersion.cs`, `FileVersions.cs`, `FilesList.cs`, `FilesUploadResult.cs`, `DiscUsage.cs`, `ObjectExist.cs` |
| **Primitives** | `Color.cs`, `Point.cs`, `Rectangle.cs`, `Dash.cs`, `Border.cs`, `BorderInfo.cs`, `MarginInfo.cs`, `GraphInfo.cs`, `Link.cs`, `LinkElement.cs`, `Position.cs` |
| **Enums** | `AnnotationType.cs`, `BorderStyle.cs`, `BorderEffect.cs`, `CapStyle.cs`, `Direction.cs`, `FontStyles.cs`, `HorizontalAlignment.cs`, `Justification.cs`, `LineEnding.cs`, `LineSpacing.cs`, `CryptoAlgorithm.cs`, `PermissionsFlags.cs`, `Rotation.cs`, `VerticalAlignment.cs`, `WrapMode.cs` |
| **Text** | `TextRects.cs`, `TextRectsResponse.cs`, `TextReplace.cs`, `TextReplaceListRequest.cs`, `TextReplaceResponse.cs`, `TextStamp.cs`, `TextState.cs`, `TextStyle.cs` |
| **Signatures** | `Signature.cs`, `SignatureField.cs`, `SignatureType.cs`, `TimestampSettings.cs` |

### 3.3 Response Type Naming Convention

- **Single entity:** `{Entity}Response` — e.g., `DocumentResponse`, `BookmarkResponse`, `CircleAnnotationResponse`
- **Collection:** `{Entity}sResponse` — e.g., `BookmarksResponse`, `CircleAnnotationsResponse`, `FieldsResponse`
- **Base:** `AsposeResponse` with `Code` (int?) and `Status` (string)

---

## 4. API Capabilities

The `PdfApi` class implements the `IPdfApi` interface and provides both synchronous and asynchronous (`Async`) methods for each operation.

### 4.1 Document Operations

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GetDocument` | GET `/pdf/{name}` | Read document info |
| `PutCreateDocument` | PUT `/pdf/{name}` | Create empty document |
| `PostCreateDocument` | POST `/pdf/{name}` | Create document with config |
| `PostOptimizeDocument` | POST `/pdf/{name}/optimize` | Optimize document (compress images, remove unused objects, unembed fonts) |
| `PostSplitDocument` | POST `/pdf/{name}/split` | Split document into pages |
| `PostSplitRangePdfDocument` | POST `/pdf/{name}/split/range` | Split by page ranges |
| `PostOrganizeDocument` | POST `/pdf/{name}/organize` | Reorder pages |
| `PostOrganizeDocuments` | POST `/pdf/organize` | Organize pages from multiple documents |
| `PostMergeDocuments` | PUT `/pdf/{name}/merge` | Merge multiple documents |

### 4.2 Page Operations

| Method | Description |
|--------|-------------|
| `GetPage` | Read page info |
| `PostPage` | Add new page |
| `DeletePage` | Delete page by number |
| `PostMovePage` | Move page to new position |
| `PostDocumentPagesRotate` | Rotate pages by angle |
| `PostDocumentPagesResize` | Resize pages |
| `PostDocumentPagesCrop` | Crop pages |
| `GetPageConvertToTiff/Jpeg/Png/Emf/Bmp/Gif` | Convert page to image (GET) |
| `PutPageConvertToTiff/Jpeg/Png/Emf/Bmp/Gif` | Convert page to image (PUT) |
| `PostPageImageStamps` | Add image stamp to page |
| `PostPageTextStamps` | Add text stamp to page |
| `PostPagePdfPageStamps` | Add PDF page stamp to page |
| `PostPagePageNumberStamps` | Add page number stamp |

### 4.3 Annotations (20+ Types)

Each annotation type supports full CRUD operations:

| Operation | Pattern |
|-----------|---------|
| **Get all** | `GetDocument{Type}Annotations(name, ...)` |
| **Get by page** | `GetPage{Type}Annotations(name, pageNumber, ...)` |
| **Get by ID** | `Get{Type}Annotation(name, annotationId, ...)` |
| **Create** | `PostPage{Type}Annotations(name, pageNumber, annotation, ...)` |
| **Update** | `Put{Type}Annotation(name, annotationId, annotation, ...)` |
| **Delete** | `DeleteAnnotation(name, annotationId, ...)` |
| **Flatten** | `PutAnnotationsFlatten(name, ...)` |

Supported annotation types: Caret, Circle, FileAttachment, FreeText, Highlight, Ink, Line, Link, Movie, Polygon, PolyLine, Popup, Redaction, Screen, Sound, Square, Squiggly, Stamp, StrikeOut, Text, Underline.

### 4.4 Form Fields (8 Types)

| Field Type | Operations |
|------------|------------|
| CheckBox, ComboBox, ListBox, RadioButton, TextBox, Signature | Get document fields, get page fields, get by name, create, update, delete |
| General | `GetFields`, `PutUpdateFields`, `PutFieldsFlatten`, `PostFlattenDocument` |
| Import/Export | XML, FDF, XFDF formats (GET and PUT for each) |

### 4.5 Bookmarks

| Method | Description |
|--------|-------------|
| `GetDocumentBookmarks` | Get bookmark tree |
| `GetBookmarks` | Get bookmarks at path |
| `GetBookmark` | Get single bookmark |
| `PostBookmark` | Add bookmark |
| `PutBookmark` | Update bookmark |
| `DeleteBookmark` | Delete bookmark |
| `DeleteDocumentBookmarks` | Delete all bookmarks |

### 4.6 Conversions

**PDF → Other formats:**
DOC, DOCX, EPUB, Excel (XLS/XLSX), HTML, MobiXML, PDF/A, PPTX, SVG, TEX, TIFF, XLS, XML, XPS, and more.

**Other formats → PDF:**
APS, BMP, EPUB, GIF, HTML, JPEG, Markdown, MHTML, PCL, PNG, PS, SVG, TeX, Web, XML, XPS, XSL FO, images.

**Pattern:** `Get{Format}InStorageToPdf` / `Put{Format}InStorageToPdf` for each source format.

### 4.7 Storage & File Management

| Method | Description |
|--------|-------------|
| `UploadFile` | Upload file to cloud storage |
| `DownloadFile` | Download file from cloud storage |
| `CopyFile` / `MoveFile` / `DeleteFile` | File operations |
| `CreateFolder` / `CopyFolder` / `MoveFolder` / `DeleteFolder` | Folder operations |
| `GetFilesList` | List files in folder |
| `GetDiscUsage` | Get storage usage |
| `ObjectExists` / `StorageExists` | Check existence |
| `GetFileVersions` | List file versions |

### 4.8 Other Features

| Feature | Key Methods |
|---------|-------------|
| **Text** | `GetText`, `GetPageText`, `GetPageTextItems`, `PutAddText`, `PostReplaceText` |
| **Images** | `GetImages`, `GetImage`, `DeleteImage`, `PostInsertImage` |
| **Links** | `GetPageLinkAnnotations`, `PostPageLinkAnnotations`, `PutLinkAnnotation`, `DeleteLinkAnnotation` |
| **Stamps** | `GetDocumentStamps`, `PostPageTextStamps`, `PostPageImageStamps`, `DeleteStamp` |
| **Tables** | `GetDocumentTables`, `PostPageTables`, `PutTable`, `DeleteTable` |
| **Watermarks** | Via image stamps |
| **Headers/Footers** | Via text/image stamps |
| **Encryption** | `PutEncryptDocument`, `PutDecryptDocument`, `PutChangePasswordDocument` |
| **Properties** | `GetDocumentProperties`, `PutSetProperty`, `DeleteProperty`, `PutSetProperties` |
| **XMP Metadata** | `GetXmpMetadataJson`, `GetXmpMetadataXml`, `PostXmpMetadata` |
| **Layers** | `GetDocumentLayers`, `DeleteDocumentLayer` |
| **Compare** | `PostCompareDocument` |
| **Privileges** | `PutPrivileges` |
| **OCR** | `PostDocumentOCR` |
| **Signatures** | `GetSignatureFields`, `PostSignatureField`, `PutSignatureField`, `PostSignDocument`, `PutSignDocument` |

---

## 5. Testing Infrastructure

### 5.1 Test Base (`TestBase.cs`)

- Abstract base class using NUnit's `[TestFixture]` pattern
- Reads credentials from `settings/credentials.json` (JSON format with `client_id`, `client_secret`, `self_host`, `api_url`)
- Supports both public cloud and self-hosted modes via `SelfHost` flag
- Configures TLS 1.2 protocol in `SetUp()`
- Provides `UploadFile(sourcePath, serverFileName)` helper
- Automatically discovers `testData/` directory by walking up from the current directory
- Sets `TempFolder = "TempPdfCloud"` for remote storage location

### 5.2 Credentials Format

```json
{
    "client_id": "YOUR_CLIENT_ID",
    "client_secret": "YOUR_CLIENT_SECRET",
    "self_host": false,
    "api_url": "https://api.aspose.cloud/v3.0"
}
```

### 5.3 Test Pattern

All tests follow a consistent pattern using NUnit:

```csharp
[TestFixture]
public class DocumentTests : TestsBase
{
    [Test]
    public void GetDocumentTest()
    {
        const string name = "4pages.pdf";
        UploadFile(name, name);

        var result = PdfApi.GetDocument(name, folder: TempFolder);
        Assert.That(result.Code, Is.EqualTo(200));
    }
}
```

### 5.4 Test Files

| Test File | Coverage |
|-----------|----------|
| `AnnotationsTests.cs` | General annotation CRUD |
| `CaretAnnotationsTests.cs` through `UnderlineAnnotationsTests.cs` | Per-type annotation tests (20+ files) |
| `BookmarksTests.cs` | Bookmark tree, CRUD |
| `ConvertTests.cs` / `ConvertToPdfTests.cs` | Format conversions |
| `DocumentTests.cs` | Document info, optimize, split, organize |
| `EncryptDecryptTests.cs` | Encryption, decryption, password change |
| `FieldsTests.cs` | Form field operations |
| `HeaderFooterTests.cs` | Header/footer stamps |
| `ImagesTests.cs` | Image extraction and insertion |
| `ImportExportTests.cs` | Form data import/export (FDF, XFDF, XML) |
| `LayersTests.cs` | Layer management |
| `LinkAnnotationsTests.cs` | Link annotations |
| `MergeTests.cs` / `OrganizeTests.cs` | Document merge/organize |
| `OcrTests.cs` | OCR operations |
| `PagesTests.cs` / `PageConvertToImageTests.cs` | Page operations |
| `PrivilegesTests.cs` | Document permissions |
| `PropertiesTests.cs` / `XmpMetadataTests.cs` | Metadata |
| `SignTests.cs` | Digital signatures |
| `StampsTests.cs` | Stamp operations |
| `StorageTests.cs` | File/folder management |
| `TablesTests.cs` | Table operations |
| `TextTests.cs` / `TextReplaceTests.cs` | Text operations |

---

## 6. Use Cases (`Uses-Cases/`)

The `Uses-Cases/` directory contains **domain-specific, runnable .NET console applications**.

### 6.1 Directory structure

Each domain is a standalone .NET console project:

```
Uses-Cases/{Domain}/
├── {Domain}.csproj              # Project file
├── {Domain}Helper.cs            # (optional) Shared utilities: PdfApi init, file upload/download
├── {Init}.cs                    # (optional) Data initialization: Not invoking of cloud methods
├── Program.cs                   # Entry point orchestrating operations
├── {Operation}.cs               # (optional) Individual domain operation that invokes cloud methods
└── {AnotherOperation}.cs        # (optional) Additional operations that invokes cloud methods
```

### 6.2 README.md Format

The `Uses-Cases/README.md` file serves as the **index and documentation** for all use case domains. It follows a strict format contains only sections:

#### Section Structure

Each domain is documented as a Markdown section with the following structure:

```markdown
#### {Domain}
- **[Program.cs](Program.cs)** – Description of file contains `Main()` entry point.
  ```bash
  dotnet run --project Uses-Cases/{Domain}/{ProjectFile}.csproj
  ```
- *[{Operation1}.cs]({Operation1}.cs)* – Description of the operation containing cloud method invocation.
- *[{Operation2}.cs]({Operation2}.cs)* – Description of the operation containing cloud method invocation.
```

#### Formatting Rules

| Element | Rule |
|---------|------|
| **Section header** | `#### {Domain}` — level-4 heading, PascalCase matching the domain name |
| **Main files** | Listed first, bold (`**`), includes `dotnet run --project Uses-Cases/{Domain}/{Domain}.csproj` command in a code block |
| **Operation files** | Listed after main files, italic (`*`), one per line |
| **File links** | Relative paths from `Uses-Cases/` directory, e.g., `[Bookmarks/BookmarksAdd.cs](Bookmarks/BookmarksAdd.cs)` (use actual file name) |
| **Descriptions** | Present tense, action-oriented (e.g., "Adds", "Retrieves", "Deletes") |
| **Blank lines** | One blank line between sections |

#### Example

```markdown
#### Bookmarks
- **[Bookmarks/Program.cs](Bookmarks/Program.cs)** – Orchestrates bookmark CRUD operations including extraction.
  ```bash
  dotnet run --project Uses-Cases/Bookmarks/Bookmarks.csproj
  ```
- *[Bookmarks/BookmarksAdd.cs](Bookmarks/BookmarksAdd.cs)* – Adds a new bookmark with specified properties to a PDF document.
- *[Bookmarks/BookmarksExtract.cs](Bookmarks/BookmarksExtract.cs)* – Extracts and displays all bookmarks present in a PDF document.
- *[Bookmarks/BookmarksDelete.cs](Bookmarks/BookmarksDelete.cs)* – Deletes a bookmark from a PDF document.
- *[Bookmarks/BookmarksReplace.cs](Bookmarks/BookmarksReplace.cs)* – Updates the properties of an existing bookmark in a PDF document.
```

### 6.3 File Inclusion/Exclusion Rules

When generating or updating `Uses-Cases/README.md`, the following rules determine which files are included:

#### Included Files

| File Pattern | Reason | Example |
|-------------|--------|---------|
| `Program.cs` (main files) | File containing `Main()` entry point | `Program.cs` |
| `{Operation}.cs` (operation files) | Individual domain operations containing cloud methods calls. (no `Main()` method) | `BookmarksAdd.cs`, `BookmarksExtract.cs` |

#### Excluded Files

| File Pattern | Reason | Example |
|-------------|--------|---------|
| **Non-`.cs` files** | Only C# source files are documented | `*.md`, `*.json`, `*.csproj`, `*.pdf` |
| `{Domain}Helper.cs` (helper files) | Shared utilities (API init, file upload/download) | `BookmarksHelper.cs` |
| `{Init}.cs` (data files) | Test data files (Initialization of complex data, no cloud methods calls) | `FieldsInit.cs` |
| **Files outside `Uses-Cases/`** | README only covers the `Uses-Cases/` directory | Root-level `*.cs` files |
| **Hidden files/directories** | Not user-facing | `.DS_Store`, `.gitkeep` |

#### Ordering Rules

1. **Domains** are listed in **alphabetical order** by directory name.
2. **Within a domain**, files are ordered as:
   - `Program.cs` (first, bold)
   - All remaining `*.cs` files in **alphabetical order** (italic)

---

## 7. Design Patterns & Conventions

### 7.1 Code Generation

The SDK is **auto-generated** from the OpenAPI specification. Evidence:
- `.swagger-codegen-ignore` file present
- Consistent, repetitive method structure across all 200+ API methods
- Flat file-per-model organization in `Model/` directory
- Uniform `{Model}.cs` → `{Model}Response.cs` → `{Model}sResponse.cs` pattern
- Both synchronous and asynchronous method pairs for every operation

### 7.2 Key Conventions

| Convention | Description |
|------------|-------------|
| **Namespace structure** | `Aspose.Pdf.Cloud.Sdk.{Api\|Client\|Model}` |
| **Interface-driven API** | `IPdfApi` interface separates contract from implementation |
| **Sync + Async methods** | Every API method has both sync (`GetDocument`) and async (`GetDocumentAsync`) variants |
| **Named parameters** | Optional parameters passed as named arguments (e.g., `folder: TempFolder`) |
| **MIT license header** | Every `.cs` file starts with the same license block |
| **DataContract serialization** | Models use `[DataContract]` / `[DataMember]` attributes for JSON serialization |
| **IValidatableObject** | Models implement validation via `IValidatableObject` |
| **Self-host support** | `SelfHost` flag skips OAuth2 authentication |
| **External dependencies** | Newtonsoft.Json (13.0.3), RestSharp (106.12.0) |

### 7.3 Error Handling

```csharp
// API errors throw ApiException with status code and response body
public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
{
    int status = (int) response.StatusCode;
    if (status >= 400)
        return new ApiException(status, 
            string.Format("Error calling {0}: {1}", methodName, response.Content), 
            response.Content);
    if (status == 0)
        return new ApiException(status, 
            string.Format("Error calling {0}: {1}", methodName, response.ErrorMessage), 
            response.ErrorMessage);
    return null;
};
```

### 7.4 API Method Variants

For each REST endpoint, `PdfApi` provides:
- **Synchronous**: `GetDocument(string name, ...)` — returns the model response type
- **Async**: `GetDocumentAsync(string name, ...)` — returns `Task<Model>`
- **With HTTP info**: `GetDocumentWithHttpInfo(string name, ...)` — returns `ApiResponse<Model>`

---

## 8. Dependencies & Build

### 8.1 Dependencies

| Package | Version |
|---------|---------|
| [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) | 13.0.3 |
| [RestSharp](https://www.nuget.org/packages/RestSharp) | 106.12.0 |
| .NET Standard 2.0 / .NET Framework 4.5.2 | — |

### 8.2 Installation

```bash
dotnet add package Aspose.Pdf-Cloud
```

Or via NuGet Package Manager:

```
Install-Package Aspose.Pdf-Cloud
```

### 8.3 Build

```bash
dotnet build Aspose.Pdf.Cloud.Sdk/Aspose.Pdf.Cloud.Sdk.csproj
```

### 8.4 Test

```bash
dotnet test src/Aspose.Pdf.Cloud.Sdk.Test/Aspose.Pdf.Cloud.Sdk.Test.csproj
```

---

## 9. Documentation

The `docs/` directory contains **Markdown files** documenting the API surface and models:

- `PdfApi.md` — Full API method reference
- `{Model}.md` — One file per model type (e.g., `Document.md`, `Annotation.md`, `Bookmark.md`)
- `{Response}.md` — One file per response type (e.g., `DocumentResponse.md`, `AnnotationsResponse.md`)

---

## 10. Quick Start

### 10.1 Setup Credentials

Create a `settings/credentials.json` file:

```json
{
    "client_id": "YOUR_CLIENT_ID",
    "client_secret": "YOUR_CLIENT_SECRET"
}
```

### 10.2 Basic Usage

```csharp
using Aspose.Pdf.Cloud.Sdk.Api;
using Aspose.Pdf.Cloud.Sdk.Client;

var config = new Configuration(
    selfHost: false,
    clientSecret: "YOUR_CLIENT_SECRET",
    clientId: "YOUR_CLIENT_ID"
);

var pdfApi = new PdfApi(config);

// Upload a PDF
using (var file = File.OpenRead("sample.pdf"))
{
    pdfApi.UploadFile("TempPdfCloud/sample.pdf", file);
}

// Get document info
var result = pdfApi.GetDocument("sample.pdf", folder: "TempPdfCloud");
Console.WriteLine($"Status: {result.Status}");
```
