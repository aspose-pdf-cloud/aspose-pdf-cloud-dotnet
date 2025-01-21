// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LineEnding.cs">
//   Copyright (c) 2025 Aspose.PDF Cloud
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
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
    /// Enumerates the line ending styles to be used in drawing the line.
    /// </summary>
    /// <value>Enumerates the line ending styles to be used in drawing the line.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LineEnding
    {
        
        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        
        /// <summary>
        /// Enum Square for "Square"
        /// </summary>
        [EnumMember(Value = "Square")]
        Square,
        
        /// <summary>
        /// Enum Circle for "Circle"
        /// </summary>
        [EnumMember(Value = "Circle")]
        Circle,
        
        /// <summary>
        /// Enum Diamond for "Diamond"
        /// </summary>
        [EnumMember(Value = "Diamond")]
        Diamond,
        
        /// <summary>
        /// Enum OpenArrow for "OpenArrow"
        /// </summary>
        [EnumMember(Value = "OpenArrow")]
        OpenArrow,
        
        /// <summary>
        /// Enum ClosedArrow for "ClosedArrow"
        /// </summary>
        [EnumMember(Value = "ClosedArrow")]
        ClosedArrow,
        
        /// <summary>
        /// Enum Butt for "Butt"
        /// </summary>
        [EnumMember(Value = "Butt")]
        Butt,
        
        /// <summary>
        /// Enum ROpenArrow for "ROpenArrow"
        /// </summary>
        [EnumMember(Value = "ROpenArrow")]
        ROpenArrow,
        
        /// <summary>
        /// Enum RClosedArrow for "RClosedArrow"
        /// </summary>
        [EnumMember(Value = "RClosedArrow")]
        RClosedArrow,
        
        /// <summary>
        /// Enum Slash for "Slash"
        /// </summary>
        [EnumMember(Value = "Slash")]
        Slash
    }

}
