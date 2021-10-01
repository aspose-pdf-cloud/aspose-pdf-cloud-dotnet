// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AnnotationType.cs">
//   Copyright (c) 2021 Aspose.PDF Cloud
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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Net;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Aspose.Pdf.Cloud.Sdk.Client.SwaggerDateConverter;

namespace Aspose.Pdf.Cloud.Sdk.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AnnotationType
    {
        
        /// <summary>
        /// Enum Text for "Text"
        /// </summary>
        [EnumMember(Value = "Text")]
        Text,
        
        /// <summary>
        /// Enum Circle for "Circle"
        /// </summary>
        [EnumMember(Value = "Circle")]
        Circle,
        
        /// <summary>
        /// Enum Polygon for "Polygon"
        /// </summary>
        [EnumMember(Value = "Polygon")]
        Polygon,
        
        /// <summary>
        /// Enum PolyLine for "PolyLine"
        /// </summary>
        [EnumMember(Value = "PolyLine")]
        PolyLine,
        
        /// <summary>
        /// Enum Line for "Line"
        /// </summary>
        [EnumMember(Value = "Line")]
        Line,
        
        /// <summary>
        /// Enum Square for "Square"
        /// </summary>
        [EnumMember(Value = "Square")]
        Square,
        
        /// <summary>
        /// Enum FreeText for "FreeText"
        /// </summary>
        [EnumMember(Value = "FreeText")]
        FreeText,
        
        /// <summary>
        /// Enum Highlight for "Highlight"
        /// </summary>
        [EnumMember(Value = "Highlight")]
        Highlight,
        
        /// <summary>
        /// Enum Underline for "Underline"
        /// </summary>
        [EnumMember(Value = "Underline")]
        Underline,
        
        /// <summary>
        /// Enum Squiggly for "Squiggly"
        /// </summary>
        [EnumMember(Value = "Squiggly")]
        Squiggly,
        
        /// <summary>
        /// Enum StrikeOut for "StrikeOut"
        /// </summary>
        [EnumMember(Value = "StrikeOut")]
        StrikeOut,
        
        /// <summary>
        /// Enum Caret for "Caret"
        /// </summary>
        [EnumMember(Value = "Caret")]
        Caret,
        
        /// <summary>
        /// Enum Ink for "Ink"
        /// </summary>
        [EnumMember(Value = "Ink")]
        Ink,
        
        /// <summary>
        /// Enum Link for "Link"
        /// </summary>
        [EnumMember(Value = "Link")]
        Link,
        
        /// <summary>
        /// Enum Popup for "Popup"
        /// </summary>
        [EnumMember(Value = "Popup")]
        Popup,
        
        /// <summary>
        /// Enum FileAttachment for "FileAttachment"
        /// </summary>
        [EnumMember(Value = "FileAttachment")]
        FileAttachment,
        
        /// <summary>
        /// Enum Sound for "Sound"
        /// </summary>
        [EnumMember(Value = "Sound")]
        Sound,
        
        /// <summary>
        /// Enum Movie for "Movie"
        /// </summary>
        [EnumMember(Value = "Movie")]
        Movie,
        
        /// <summary>
        /// Enum Screen for "Screen"
        /// </summary>
        [EnumMember(Value = "Screen")]
        Screen,
        
        /// <summary>
        /// Enum Widget for "Widget"
        /// </summary>
        [EnumMember(Value = "Widget")]
        Widget,
        
        /// <summary>
        /// Enum Watermark for "Watermark"
        /// </summary>
        [EnumMember(Value = "Watermark")]
        Watermark,
        
        /// <summary>
        /// Enum TrapNet for "TrapNet"
        /// </summary>
        [EnumMember(Value = "TrapNet")]
        TrapNet,
        
        /// <summary>
        /// Enum PrinterMark for "PrinterMark"
        /// </summary>
        [EnumMember(Value = "PrinterMark")]
        PrinterMark,
        
        /// <summary>
        /// Enum Redaction for "Redaction"
        /// </summary>
        [EnumMember(Value = "Redaction")]
        Redaction,
        
        /// <summary>
        /// Enum Stamp for "Stamp"
        /// </summary>
        [EnumMember(Value = "Stamp")]
        Stamp,
        
        /// <summary>
        /// Enum RichMedia for "RichMedia"
        /// </summary>
        [EnumMember(Value = "RichMedia")]
        RichMedia,
        
        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,
        
        /// <summary>
        /// Enum PDF3D for "PDF3D"
        /// </summary>
        [EnumMember(Value = "PDF3D")]
        PDF3D
    }

}
