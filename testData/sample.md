```
---
title: Генерация PDF из XML
linktitle: Генерация PDF из XML
type: docs
weight: 10
url: /net/generate-pdf-from-xml
description: Aspose.PDF для .NET предоставляет несколько способов преобразования XML файла в PDF документ, требующего входной XML файл.
lastmod: "2022-02-17"
sitemap:
    changefreq: "weekly"
    priority: 0.7
aliases:
---
<script type="application/ld+json">
{
    "@context": "https://schema.org",
    "@type": "TechArticle",
    "headline": "Генерация PDF из XML",
    "alternativeHeadline": "Преобразование XML в PDF",
    "author": {
        "@type": "Person",
        "name":"Anastasiia Holub",
        "givenName": "Anastasiia",
        "familyName": "Holub",
        "url":"https://www.linkedin.com/in/anastasiia-holub-750430225/"
    },
    "genre": "генерация PDF документов",
    "keywords": "pdf, c#, генерация pdf из xml, преобразование xml в pdf",
    "wordcount": "302",
    "proficiencyLevel":"Beginner",
    "publisher": {
        "@type": "Organization",
        "name": "Aspose.PDF Doc Team",
        "url": "https://products.aspose.com/pdf",
        "logo": "https://www.aspose.cloud/templates/aspose/img/products/pdf/aspose_pdf-for-net.svg",
        "alternateName": "Aspose",
        "sameAs": [
            "https://facebook.com/aspose.pdf/",
            "https://twitter.com/asposepdf",
            "https://www.youtube.com/channel/UCmV9sEg_QWYPi6BJJs7ELOg/featured",
            "https://www.linkedin.com/company/aspose",
            "https://stackoverflow.com/questions/tagged/aspose",
            "https://aspose.quora.com/",
            "https://aspose.github.io/"
        ],
        "contactPoint": [
            {
                "@type": "ContactPoint",
                "telephone": "+1 903 306 1676",
                "contactType": "sales",
                "areaServed": "US",
                "availableLanguage": "en"
            },
            {
                "@type": "ContactPoint",
                "telephone": "+44 141 628 8900",
                "contactType": "sales",
                "areaServed": "GB",
                "availableLanguage": "en"
            },
            {
                "@type": "ContactPoint",
                "telephone": "+61 2 8006 6987",
                "contactType": "sales",
                "areaServed": "AU",
                "availableLanguage": "en"
            }
        ]
    },
    "url": "/net/generate-pdf-from-xml",
    "mainEntityOfPage": {
        "@type": "WebPage",
        "@id": "/net/generate-pdf-from-xml"
    },
    "dateModified": "2022-02-04",
    "description": "Aspose.PDF для .NET предоставляет несколько способов преобразования XML файла в PDF документ, требующего входной XML файл."
}
</script>
```
The following code snippet also work with [Aspose.PDF.Drawing](/pdf/net/drawing/) library.

Генерация PDF документа из XML документа не является тривиальной задачей, потому что XML документ может описывать различное содержимое. Aspose.PDF для .NET имеет несколько способов создания PDF на основе XML документа:

- с использованием XSLT преобразования
- с использованием XSL-FO (XSL Formatting Objects) разметки
- с использованием собственной XML схемы Aspose.PDF

## Генерация PDF документа с использованием XSLT преобразования

XSL (eXtensible Stylesheet Language) — это язык стилей для преобразования XML документов в другие XML документы или HTML. В нашем случае мы можем использовать преобразование XML в HTML, а затем создать PDF на основе данных HTML.

Предположим, у нас есть XML файл с простым каталогом CD (см. ниже).

```xml
<?xml version="1.0" encoding="utf-8" ?>
<catalog>
  <cd>
    <title>Empire Burlesque</title>
    <artist>Bob Dylan</artist>
    <country>USA</country>
    <company>Columbia</company>
    <price>10.90</price>
    <year>1985</year>
  </cd>
  <cd>
    <title>Hide your heart</title>
    <artist>Bonnie Tyler</artist>
    <country>UK</country>
    <company>CBS Records</company>
    <price>9.90</price>
    <year>1988</year>
  </cd>
  <cd>
    <title>Greatest Hits</title>
    <artist>Dolly Parton</artist>
    <country>USA</country>
    <company>RCA</company>
    <price>9.90</price>
    <year>1982</year>
  </cd>
  <cd>
    <title>Still got the blues</title>
    <artist>Gary Moore</artist>
    <country>UK</country>
    <company>Virgin records</company>
    <price>10.20</price>
    <year>1990</year>
  </cd>
  <cd>
    <title>Eros</title>
    <artist>Eros Ramazzotti</artist>
    <country>EU</country>
    <company>BMG</company>
    <price>9.90</price>
    <year>1997</year>
  </cd>
  <cd>
    <title>One night only</title>
    <artist>Bee Gees</artist>
    <country>UK</country>
    <company>Polydor</company>
    <price>10.90</price>
    <year>1998</year>
  </cd>
  <cd>
    <title>Sylvias Mother</title>
    <artist>Dr.Hook</artist>
    <country>UK</country>
    <company>CBS</company>
    <price>8.10</price>
    <year>1973</year>
  </cd>
  <cd>
    <title>Maggie May</title>
    <artist>Rod Stewart</artist>
    <country>UK</country>
    <company>Pickwick</company>
    <price>8.50</price>
    <year>1990</year>
  </cd>
  <cd>
    <title>Romanza</title>
    <artist>Andrea Bocelli</artist>
    <country>EU</country>
    <company>Polydor</company>
    <price>10.80</price>
    <year>1996</year>
  </cd>
  <cd>
    <title>When a man loves a woman</title>
    <artist>Percy Sledge</artist>
    <country>USA</country>
    <company>Atlantic</company>
    <price>8.70</price>
    <year>1987</year>
  </cd>
  <cd>
    <title>Black angel</title>
    <artist>Savage Rose</artist>
    <country>EU</country>
    <company>Mega</company>
    <price>10.90</price>
    <year>1995</year>
  </cd>
  <cd>
    <title>1999 Grammy Nominees</title>
    <artist>Many</artist>
    <country>USA</country>
    <company>Grammy</company>
    <price>10.20</price>
    <year>1999</year>
  </cd>
  <cd>
    <title>For the good times</title>
    <artist>Kenny Rogers</artist>
    <country>UK</country>
    <company>Mucik Master</company>
    <price>8.70</price>
    <year>1995</year>
  </cd>
  <cd>
    <title>Big Willie style</title>
    <artist>Will Smith</artist>
    <country>USA</country>
    <company>Columbia</company>
    <price>9.90</price>
    <year>1997</year>
  </cd>
  <cd>
    <title>Tupelo Honey</title>
    <artist>Van Morrison</artist>
    <country>UK</country>
    <company>Polydor</company>
    <price>8.20</price>
    <year>1971</year>
  </cd>
  <cd>
    <title>Soulsville</title>
    <artist>Jorn Hoel</artist>
    <country>Norway</country>
    <company>WEA</company>
    <price>7.90</price>
    <year>1996</year>
  </cd>
  <cd>
    <title>The very best of</title>
    <artist>Cat Stevens</artist>
    <country>UK</country>
    <company>Island</company>
    <price>8.90</price>
    <year>1990</year>
  </cd>
  <cd>
    <title>Stop</title>
    <artist>Sam Brown</artist>
    <country>UK</country>
    <company>A and M</company>
    <price>8.90</price>
    <year>1988</year>
  </cd>
  <cd>
    <title>Bridge of Spies</title>
    <artist>T`Pau</artist>
    <country>UK</country>
    <company>Siren</company>
    <price>7.90</price>
    <year>1987</year>
  </cd>
  <cd>
    <title>Private Dancer</title>
    <artist>Tina Turner</artist>
    <country>UK</country>
    <company>Capitol</company>
    <price>8.90</price>
    <year>1983</year>
  </cd>
  <cd>
    <title>Midt om natten</title>
    <artist>Kim Larsen</artist>
    <country>EU</country>
    <company>Medley</company>
    <price>7.80</price>
    <year>1983</year>
  </cd>
  <cd>
    <title>Pavarotti Gala Concert</title>
    <artist>Luciano Pavarotti</artist>
    <country>UK</country>
    <company>DECCA</company>
    <price>9.90</price>
    <year>1991</year>
  </cd>
  <cd>
    <title>The dock of the bay</title>
    <artist>Otis Redding</artist>
    <country>USA</country>
    <company>Stax Records</company>
    <price>7.90</price>
    <year>1968</year>
  </cd>
  <cd>
    <title>Picture book</title>
    <artist>Simply Red</artist>
    <country>EU</country>
    <company>Elektra</company>
    <price>7.20</price>
    <year>1985</year>
  </cd>
  <cd>
    <title>Red</title>
    <artist>The Communards</artist>
    <country>UK</country>
    <company>London</company>
    <price>7.80</price>
    <year>1987</year>
  </cd>
  <cd>
    <title>Unchain my heart</title>
    <artist>Joe Cocker</artist>
    <country>USA</country>
    <company>EMI</company>
    <price>8.20</price>
    <year>1987</year>
  </cd>
</catalog>
```
 
 
Чтобы преобразовать этот файл в PDF, мы должны создать XSL с HTML-разметкой. Давайте отобразим наши данные в таблице. Файл XSL, который поможет нам это сделать, может выглядеть следующим образом:

```xml
<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h2>Моя коллекция CD</h2>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th style="text-align:left">Название</th>
            <th style="text-align:left">Исполнитель</th>
          </tr>
          <xsl:for-each select="catalog/cd">
            <tr>
              <td>
                <xsl:value-of select="title"/>
              </td>
              <td>
                <xsl:value-of select="artist"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
```

Итак, нам нужно преобразовать XML и загрузить его в PDF-документ.
 
Итак, нам нужно преобразовать XML и загрузить его в PDF-документ.

```csharp
private static void ExampleXSLTtoPDF()
{
    var _dataDir = @"C:\tmp\";
    var XmlContent = File.ReadAllText(@"XMLFile1.xml");
    var XsltContent = File.ReadAllText(@"XSLTFile1.xslt");
    var options = new Aspose.Pdf.HtmlLoadOptions();
    // задаем размер страницы A5
    options.PageInfo.Height = 595;
    options.PageInfo.Width = 420;
    var pdfDocument = new Aspose.Pdf.Document(TransformXmltoHtml(XmlContent, XsltContent), options);
    pdfDocument.Save(_dataDir + "data_xml.pdf");
}

public static MemoryStream TransformXmltoHtml(string inputXml, string xsltString)
{
    var transform = new XslCompiledTransform();
    using (var reader = XmlReader.Create(new StringReader(xsltString)))
    {
        transform.Load(reader);
    }
    var memoryStream = new MemoryStream();
    var results = new StreamWriter(memoryStream);
    using (var reader = XmlReader.Create(new StringReader(inputXml)))
    {
        transform.Transform(reader, null, results);
    }
    memoryStream.Position = 0;
    return memoryStream;
}
```
## Генерация PDF документа с использованием XSL-FO разметки

XSL-FO - это основанный на XML язык разметки, описывающий форматирование данных XML для вывода на экран, бумагу или другие носители. Aspose.PDF имеет специальный класс, который позволяет применять XSL-FO разметку и получать PDF документ.

Рассмотрим пример. Вот XML файл с примерными данными о сотрудниках.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<employees>
    <companyname>ABC Inc.</companyname>
    <employee>
        <id>101</id>
        <name>Andrew</name>
        <designation>Manager</designation>
    </employee>

    <employee>
        <id>102</id>
        <name>Eduard</name>
        <designation>Executive</designation>
    </employee>

    <employee>
        <id>103</id>
        <name>Peter</name>
        <designation>Executive</designation>
    </employee>
</employees>
```

Создадим еще один файл - файл XSL-FO разметки для преобразования данных о сотрудниках в таблицу.

```xml
<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.1" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:fo="http://www.w3.org/1999/XSL/Format" exclude-result-prefixes="fo">
    <xsl:template match="employees">
        <fo:root xmlns:fo="http://www.w3.org/1999/XSL/Format">
            <fo:layout-master-set>
                <fo:simple-page-master master-name="simpleA4" page-height="29.7cm" page-width="21cm" margin-top="2cm" margin-bottom="2cm" margin-left="2cm" margin-right="2cm">
                    <fo:region-body/>
                </fo:simple-page-master>
            </fo:layout-master-set>
            <fo:page-sequence master-reference="simpleA4">
                <fo:flow flow-name="xsl-region-body">
                    <fo:block font-size="16pt" font-weight="bold" space-after="5mm">
                        Company Name: <xsl:value-of select="companyname"/>
                    </fo:block>
                    <fo:block font-size="10pt">
                        <fo:table table-layout="fixed" width="100%" border-collapse="separate">
                            <fo:table-column column-width="4cm"/>
                            <fo:table-column column-width="4cm"/>
                            <fo:table-column column-width="5cm"/>
                            <fo:table-body>
                                <xsl:apply-templates select="employee"/>
                            </fo:table-body>
                        </fo:table>
                    </fo:block>
                </fo:flow>
            </fo:page-sequence>
        </fo:root>
    </xsl:template>
    <xsl:template match="employee">
        <fo:table-row>
            <xsl:if test="designation = 'Manager'">
                <xsl:attribute name="font-weight">bold</xsl:attribute>
            </xsl:if>
            <fo:table-cell>
                <fo:block>
                    <xsl:value-of select="id"/>
                </fo:block>
            </fo:table-cell>

            <fo:table-cell>
                <fo:block>
                    <xsl:value-of select="name"/>
                </fo:block>
            </fo:table-cell>
            <fo:table-cell>
                <fo:block>
                    <xsl:value-of select="designation"/>
                </fo:block>
            </fo:table-cell>
        </fo:table-row>
    </xsl:template>
</xsl:stylesheet>
```
Aspose.PDF имеет специальный класс [XslFoLoadOptions](https://reference.aspose.com/pdf/net/aspose.pdf/xslfoloadoptions), который позволяет применять преобразование XSL-FO.
Следующий фрагмент показывает, как использовать этот класс с описанными выше примерами файлов.

```csharp
public static void Example_XSLFO_to_PDF()
{
    var _dataDir = @"C:\tmp\";
    // Instantiate XslFoLoadOption object
    var options = new Pdf.XslFoLoadOptions("employees.xslt");
    // Create Document object
    var pdfDocument = new Aspose.Pdf.Document("employees.xml", options);
    pdfDocument.Save(_dataDir + "data_xml.pdf");
}
```

### Создание PDF документа с использованием разметки XSL-FO и параметров XSL

Иногда нам нужно использовать [XSL:param](https://developer.mozilla.org/en-US/docs/Web/XSLT/Element/param). Элемент `<xsl:param>` устанавливает параметр по имени и, при необходимости, значению по умолчанию для этого параметра.

Возьмем тот же пример, что и в предыдущем случае, но с небольшими изменениями (добавление параметров). Файл XML с примерами данных остается нетронутым, ...
```xml
<?xml version="1.0" encoding="utf-8" ?>
<employees>
    <companyname>ABC Inc.</companyname>
    <employee>
        <id>101</id>
        <name>Андрей</name>
        <designation>Менеджер</designation>
    </employee>

    <employee>
        <id>102</id>
        <name>Эдуард</name>
        <designation>Исполнительный директор</designation>
    </employee>

    <employee>
        <id>103</id>
        <name>Петр</name>
        <designation>Исполнительный директор</designation>
    </employee>
</employees>
```

```xml
<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.1" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:fo="http://www.w3.org/1999/XSL/Format" exclude-result-prefixes="fo">

 <xsl:param name="isBoldName"></xsl:param>

 <xsl:template match="employees">
  <fo:root xmlns:fo="http://www.w3.org/1999/XSL/Format">
   <fo:layout-master-set>
    <fo:simple-page-master master-name="simpleA4" page-height="29.7cm" page-width="21cm" margin-top="2cm" margin-bottom="2cm" margin-left="2cm" margin-right="2cm">
     <fo:region-body/>
    </fo:simple-page-master>
   </fo:layout-master-set>
   <fo:page-sequence master-reference="simpleA4">
    <fo:flow flow-name="xsl-region-body">
     <fo:block font-size="16pt" font-weight="bold" space-after="5mm">
      Название компании: <xsl:value-of select="companyname"/>
     </fo:block>
     <fo:block font-size="10pt">
      <fo:table table-layout="fixed" width="100%" border-collapse="separate">
              <fo:table-column column-width="4cm"/>
       <fo:table-column column-width="4cm"/>
       <fo:table-column column-width="5cm"/>
       <fo:table-body>
        <xsl:apply-templates select="employee"/>
       </fo:table-body>
      </fo:table>
     </fo:block>
    </fo:flow>
   </fo:page-sequence>
  </fo:root>
 </xsl:template>
 <xsl:template match="employee">
  <fo:table-row>
   <xsl:if test="designation = 'Менеджер'">
    <xsl:attribute name="font-weight">bold</xsl:attribute>
   </xsl:if>
   <fo:table-cell>
    <fo:block>
     <xsl:value-of select="id"/>
    </fo:block>
   </fo:table-cell>

   <fo:table-cell>
    <xsl:if test="$isBoldName='yes'">
     <xsl:attribute name="font-weight">bold</xsl:attribute>
    </xsl:if>
    <fo:block>
     <xsl:value-of select="name"/>
    </fo:block>
   </fo:table-cell>
   <fo:table-cell>
    <fo:block>
     <xsl:value-of select="designation"/>
    </fo:block>
   </fo:table-cell>
  </fo:table-row>
 </xsl:template>
</xsl:stylesheet>
```

Чтобы добавить параметры XSL, нам нужно создать собственный [XsltArgumentList](https://docs.microsoft.com/en-us/dotnet/api/system.xml.xsl.xsltargumentlist?view=net-5.0) и
установить его как свойство в [XslFoLoadOptions](https://reference.aspose.com/pdf/net/aspose.pdf/xslfoloadoptions).
Следующий фрагмент показывает, как использовать этот класс с описанными выше примерами файлов.

```csharp
public static void Example_XSLFO_to_PDF_Param_21_7()
{
  string xmlInputFile = Path.Combine(_dataDir, "employees.xml");
  string xsltInputFile = Path.Combine(_dataDir, "employees.xslt");
  string outputFile = Path.Combine(_dataDir, "out.pdf");

  XslFoLoadOptions options = new XslFoLoadOptions(xsltInputFile);

  options.XsltArgumentList = new XsltArgumentList();
  options.XsltArgumentList.AddParam("isBoldName", "", "yes");

  Document document = new Document(xmlInputFile, options);
  document.Save(outputFile);
}
```

Если вы используете версию ранее 21.7, пожалуйста, используйте следующий метод:

```csharp
  public static void Example_XSLFO_to_PDF_Param_21_6()
  {
      var XmlContent = File.ReadAllText(_dataDir + "employees.xml");
      var XsltContent = File.ReadAllText(_dataDir + "employees.xslt");

      var options = new Aspose.Pdf.XslFoLoadOptions();
      var pdfDocument = new Aspose.Pdf.Document(TransformXSL(XmlContent, XsltContent), options);
      pdfDocument.Save(_dataDir + "data_xml.pdf");
  }

  public static MemoryStream TransformXSL(string inputXml, string xsltString)
  {
      var transform = new XslCompiledTransform();

      //Create own XsltArgumentList
      XsltArgumentList argsList = new XsltArgumentList();
      argsList.AddParam("isBoldName", "", "no");
      //---------------------

      using (var reader = XmlReader.Create(new StringReader(xsltString)))
      {
          transform.Load(reader);
      }
      var memoryStream = new MemoryStream();

      var results = new StreamWriter(memoryStream);
      using (var reader = XmlReader.Create(new StringReader(inputXml)))
      {
          transform.Transform(reader, argsList, results);
      }

      memoryStream.Position = 0;
      return memoryStream;
  }
}
```

## Generating PDF document based on Aspose.PDF XML Schema

Другой способ создания PDF документа из XML - использование Aspose.PDF XML Schema. Используя эту схему, вы можете описать макет страницы так же, как если бы вы использовали табличный макет в HTML. Давайте рассмотрим работу этого метода более подробно.

### Defining page

Давайте определим страницу с параметрами по умолчанию. Наша страница будет иметь размер A4 и содержать только один текстовый фрагмент.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Document xmlns="Aspose.Pdf">
  <Page>
    <TextFragment>
      <TextSegment>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla odio lorem, luctus in lorem vitae, accumsan semper lectus. Cras a auctor leo, et tincidunt lacus.</TextSegment>
    </TextFragment>
  </Page>
</Document>
```

Для генерации PDF документа мы будем использовать метод [BindXml](https://reference.aspose.com/pdf/net/aspose.pdf/document/methods/bindxml/index).

```csharp
private static void Example_XML_to_PDF()
{
    var _dataDir = @"C:\tmp\";
    var pdfDocument = new Aspose.Pdf.Document();
    pdfDocument.BindXml(_dataDir + "aspose_pdf_demo.xml");
    pdfDocument.Save(_dataDir + "data_xml.pdf");
}
```
To define a new page size we should add a `PageInfo` element. In the following example, we were set A5 page size and margins 25mm and 10mm.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Document xmlns="Aspose.Pdf">
  <Page>
    <PageInfo IsLandscape="true" Height="595" Width="420">
      <Margin Top="70.8661" Bottom="70.8661" Left="28.3465" Right="28.3465" />
    </PageInfo>
    <TextFragment>
      <TextSegment>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla odio lorem, luctus in lorem vitae, accumsan semper lectus. Cras a auctor leo, et tincidunt lacus.</TextSegment>
    </TextFragment>
  </Page>
</Document>
```

### Добавление элемента HtmlFragment в XML файл

Так как HTML содержит теги, подобные XML, то при написании HTML внутри любого XML тега парсер рассматривает его как XML разметку, и они просто не могут быть распознаны как XML теги.
 
Так как HTML содержит теги, аналогичные XML, когда вы пишете HTML внутри любого XML тега, парсер воспринимает его как XML разметку, и они просто не могут быть распознаны как XML теги.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Document xmlns="Aspose.Pdf">
  <Page id="mainSection">
    <HtmlFragment>
      <![CDATA[
        <font style="font-family:Tahoma; font-size:40px;">This is Html String.</font>
        ]]>
    </HtmlFragment>
  </Page>
</Document>
```

### Добавление элемента Table в XML файл

Элементы `Table`, `Row`, `Cell` используются для описания таблиц. Следующий фрагмент показывает использование простой таблицы. В этом примере некоторые ячейки имеют атрибут `Alignment`, и этот атрибут имеет числовое значение:

1. Левое выравнивание
1. Центрированное выравнивание
1. Правое выравнивание
1. Выравнивание по ширине. Текст будет выровнен по левому и правому краям.
1.
```xml
<?xml version="1.0" encoding="utf-8" ?>
<Document xmlns="Aspose.Pdf">
  <Page>
    <PageInfo IsLandscape="false" Height="595" Width="420">
      <Margin Top="71" Bottom="71" Left="28" Right="28" />
    </PageInfo>
    <HtmlFragment>
      <![CDATA[
        <h1 style="font-family:Tahoma; font-size:16pt;">РАСПИСАНИЕ НА МАРШРУТЕ ГРИНТАУН-БЛЮБЕРГ</h1>
        ]]>
    </HtmlFragment>
    <TextFragment>
      <TextSegment>4.1.-28.3.2021 | ГРИНТАУН → БЛЮБЕРГ</TextSegment>
    </TextFragment>
    <Table ColumnAdjustment="AutoFitToWindow" ColumnWidths ="10 10 10 10">
      <DefaultCellPadding Top="5" Left="0" Right="0" Bottom="5" />
      <Border>
        <Top Color="Black"></Top>
        <Bottom Color="Black"></Bottom>
        <Left Color="Black"></Left>
        <Right Color="Black"></Right>
      </Border>
      <Margin Top="15" />
      <Row BackgroundColor="LightGray" MinRowHeight="20">
        <Border>
          <Bottom Color="Black"></Bottom>
        </Border>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>Отправление</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Прибытие</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>День недели</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Корабль</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>07.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>09.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Пн-Сб</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Star</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>10.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>12.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>каждый день</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Megastar</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>13.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>15.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>каждый день</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Star</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>16.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>18.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>каждый день</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Megastar</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>19.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>21.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>каждый день</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Star</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>22.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>00.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Пн-Пт, Вс</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Megastar</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
    </Table>
  </Page>
</Document>
```
Таблицы используются для размещения документов. Например, мы можем настроить заголовок страницы. В этом случае таблица используется для разделения заголовка на 2 колонки.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Document xmlns="Aspose.Pdf">
  <Page>
    <PageInfo IsLandscape="false" Height="595" Width="420">
      <Margin Top="71" Bottom="71" Left="28" Right="28" />
    </PageInfo>
    <Header>
        <Margin Top="20" />
        <Table ColumnAdjustment="AutoFitToWindow">
            <Row>
                <Cell Alignment="1">
                    <TextFragment>
                        <TextSegment>Дата: 01/01/2021</TextSegment>
                    </TextFragment>
                </Cell>
                <Cell Alignment="3">
                    <TextFragment>
                        <TextSegment>Страница $p / $P</TextSegment>
                    </TextFragment>
                </Cell>
            </Row>
        </Table>
    </Header>
    <HtmlFragment>
      <![CDATA[
        <h1 style="font-family:Tahoma; font-size:16pt;">РАСПИСАНИЯ НА МАРШРУТЕ ГРИНТАУН-БЛЮБЕРГ</h1>
        ]]>
    </HtmlFragment>
    <TextFragment>
      <TextSegment>4.1.-28.3.2021 | ГРИНТАУН → БЛЮБЕРГ</TextSegment>
    </TextFragment>
    <Table ColumnAdjustment="AutoFitToWindow" ColumnWidths ="10 10 10 10">
      <DefaultCellPadding Top="5" Left="0" Right="0" Bottom="5" />
      <Border>
        <Top Color="Black"></Top>
        <Bottom Color="Black"></Bottom>
        <Left Color="Black"></Left>
        <Right Color="Black"></Right>
      </Border>
      <Margin Top="15" />
      <Row BackgroundColor="LightGray" MinRowHeight="20">
        <Border>
          <Bottom Color="Black"></Bottom>
        </Border>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>Отправление</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Прибытие</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Будний день</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Корабль</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>07.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>09.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Пн-Сб</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Звезда</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>10.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>12.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>каждый день</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Мегазвезда</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>13.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>15.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>каждый день</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Звезда</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>16.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>18.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>каждый день</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Мегазвезда</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>19.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>21.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>каждый день</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Звезда</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
      <Row>
        <Cell Alignment="2">
          <TextFragment>
            <TextSegment>22.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>00.30</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Пн-Пт, Вс</TextSegment>
          </TextFragment>
        </Cell>
        <Cell>
          <TextFragment>
            <TextSegment>Мегазвезда</TextSegment>
          </TextFragment>
        </Cell>
      </Row>
    </Table>
  </Page>
</Document>
```
### Обновление контента динамически

Метод BindXML() предлагает возможность загрузки содержимого XML файла, а метод Document.save() может быть использован для сохранения вывода в формате PDF. Однако, во время конверсии, мы также можем получить доступ к отдельным элементам внутри XML и использовать XML как шаблон. Следующий фрагмент кода показывает шаги для доступа к TextSegments из XML файла.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Document xmlns="Aspose.Pdf">
  <Page id="mainSection">
    <TextFragment>
      <TextSegment id="boldHtml">segment1</TextSegment>
    </TextFragment>
    <TextFragment>
      <TextSegment id="strongHtml">segment2</TextSegment>
    </TextFragment>
  </Page>
</Document>
```

```csharp
// Для полных примеров и файлов данных, пожалуйста, перейдите на https://github.com/aspose-pdf/Aspose.PDF-for-.NET
// Путь к директории документов.
string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

// Создание экземпляра объекта Document
Document doc = new Document();
// Привязка исходного XML файла
doc.BindXml(dataDir + "log.xml");
// Получение ссылки на объект страницы из XML
Page page = (Page)doc.GetObjectById("mainSection");
// Получение ссылки на первый TextSegment с ID boldHtml
TextSegment segment = (TextSegment)doc.GetObjectById("boldHtml");
// Получение ссылки на второй TextSegment с ID strongHtml
segment = (TextSegment)doc.GetObjectById("strongHtml");
// Сохранение результирующего PDF файла
doc.Save(dataDir + "XMLToPDF_out.pdf");
```
### Добавление графических элементов на страницу

Мы можем добавить другие дополнительные элементы в XML документ: объекты Image или Graph. Следующий фрагмент показывает, как добавить эти элементы в документ

```xml
<Graph Width="20" Height="20">
  <Circle PosX="30" PosY="30" Radius="10">
    <GraphInfo Color="Red" FillColor="Blue"></GraphInfo>
  </Circle>
</Graph>

<Image File="logo.png" Id = "testImg"></Image>
```

### Установить путь к изображению при преобразовании XML в PDF

Следующий XML шаблон содержит тег `<Image>` с идентификатором "testImg". В случае, если вы хотите установить путь к изображению из вашего кода, вы можете получить доступ к элементу Image из XML шаблона в процессе преобразования и установить путь к желаемому адресу для изображения.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Document xmlns="Aspose.Pdf">
 <Page id="mainSection">
    <PageInfo IsLandscape="true">
        <Margin Left="20" Right="20" Top="10" Bottom="30" />
    </PageInfo>
    <Header>
        <Margin Top="20" />
        <Table ColumnAdjustment="AutoFitToWindow">
            <Row>
                <Cell Alignment="1">
                    <Image File="logo.png" Id = "testImg"></Image>
                </Cell>
                <Cell Alignment="3">
                    <TextFragment>
                        <TextSegment>Page $p / $P</TextSegment>
                    </TextFragment>
                </Cell>
            </Row>
        </Table>
    </Header>
    <Table ColumnAdjustment="AutoFitToWindow" ColumnWidths="8 10">
    <DefaultCellPadding Top="0" Left="0" Right="0" Bottom="0" />
    <Margin Top="15" />
    <Row>
        <Cell Alignment="1">
        <!--Logo-->
            <TextFragment>
                <TextSegment> Request ID</TextSegment>
                <TextState FontSize="14" ForegroundColor="#0e4f9c" FontStyle="1" />
            </TextFragment>
            <TextFragment>
                <TextSegment></TextSegment>
            </TextFragment>
            <TextFragment>
                <TextSegment id="boldtext">Some Bold Text</TextSegment>
                <TextState FontSize="14" FontStyle="1"></TextState>
            </TextFragment>
        </Cell>
    </Row>
    </Table>
 </Page>
</Document>
```
Код для установки пути к изображению в шаблоне XML выглядит следующим образом:

```csharp
// Путь к каталогу с документами.
string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
string inXml = dataDir + "input.xml";
string inFile = dataDir + "aspose-logo.jpg";
string outFile = dataDir + "output_out.pdf";
Document doc = new Document();
doc.BindXml(inXml);
Image image = (Image)doc.GetObjectById("testImg");
image.File = inFile;
doc.Save(outFile);
```

<script type="application/ld+json">
{
    "@context": "http://schema.org",
    "@type": "SoftwareApplication",
    "name": "Aspose.PDF for .NET Library",
    "image": "https://www.aspose.cloud/templates/aspose/img/products/pdf/aspose_pdf-for-net.svg",
    "url": "https://www.aspose.com/",
    "publisher": {
        "@type": "Organization",
        "name": "Aspose.PDF",
        "url": "https://products.aspose.com/pdf",
        "logo": "https://www.aspose.cloud/templates/aspose/img/products/pdf/aspose_pdf-for-net.svg",
        "alternateName": "Aspose",
        "sameAs": [
            "https://facebook.com/aspose.pdf/",
            "https://twitter.com/asposepdf",
            "https://www.youtube.com/channel/UCmV9sEg_QWYPi6BJJs7ELOg/featured",
            "https://www.linkedin.com/company/aspose",
            "https://stackoverflow.com/questions/tagged/aspose",
            "https://aspose.quora.com/",
            "https://aspose.github.io/"
        ],
        "contactPoint": [
            {
                "@type": "ContactPoint",
                "telephone": "+1 903 306 1676",
                "contactType": "sales",
                "areaServed": "US",
                "availableLanguage": "en"
            },
            {
                "@type": "ContactPoint",
                "telephone": "+44 141 628 8900",
                "contactType": "sales",
                "areaServed": "GB",
                "availableLanguage": "en"
            },
            {
                "@type": "ContactPoint",
                "telephone": "+61 2 8006 6987",
                "contactType": "sales",
                "areaServed": "AU",
                "availableLanguage": "en"
            }
        ]
    },
    "offers": {
        "@type": "Offer",
        "price": "1199",
        "priceCurrency": "USD"
    },
    "applicationCategory": "PDF Manipulation Library for .NET",
    "downloadUrl": "https://www.nuget.org/packages/Aspose.PDF/",
    "operatingSystem": "Windows, MacOS, Linux",
    "screenshot": "https://docs.aspose.com/pdf/net/create-pdf-document/screenshot.png",
    "softwareVersion": "2022.1",
    "aggregateRating": {
        "@type": "AggregateRating",
        "ratingValue": "5",
        "ratingCount": "16"
    }
}
</script>
```
---
description: Collection of the most useful resources for learning Django Framework
sidebar_position: 100
slug: /resources
tags:
  - django
  - resources
  - learning
  - education
  - web development
  - python
  - framework
keywords:
  - django resources
  - django learning
  - django education
  - django framework
  - python web development
  - web development resources
---

# Лучшие ресурсы для изучения Django

## Введение

Добро пожаловать в наш сборник лучших ресурсов для изучения Django Framework. Здесь вы найдете тщательно отобранные материалы, которые помогут вам стать мастером Django.

## Онлайн курсы

### Coursera

- **Django for Everybody** - Курс от университета Мичигана, который охватывает основы Django.
- **Web Application Technologies and Django** - Этот курс предлагает глубокое погружение в технологии веб-приложений с использованием Django.

### Udemy

- **Python and Django Full Stack Web Developer Bootcamp** - В этом курсе вы научитесь создавать полноценные веб-приложения с использованием Python и Django.

## Книги

### Django for Beginners

Эта книга предназначена для тех, кто только начинает свое путешествие с Django. Она проведет вас через создание вашего первого проекта и объяснит основные концепции.

### Django Unleashed

Более продвинутая книга, которая углубляется в детали Django и помогает вам освоить фреймворк на профессиональном уровне.

## Документация

### Официальная документация Django

Официальная документация Django - это ваш главный источник информации. Она включает в себя все, от установки до развертывания и масштабирования приложений.

## Сообщества

### Stack Overflow

Stack Overflow - отличное место для поиска ответов на ваши вопросы о Django. Здесь вы найдете множество профессионалов, готовых помочь.

### Reddit

Subreddit r/django - это активное сообщество разработчиков, где можно задать вопросы, поделиться опытом и найти полезные ресурсы.

## Видео уроки

### YouTube

- **Traversy Media** - Канал с множеством уроков по разработке на Django.
- **Corey Schafer** - Один из лучших преподавателей на YouTube, который делает отличные уроки по Django.

```

