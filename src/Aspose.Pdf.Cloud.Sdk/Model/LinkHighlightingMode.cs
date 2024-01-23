// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LinkHighlightingMode.cs">
//   Copyright (c) 2024 Aspose.PDF Cloud
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
    /// Enumerates the annotation’s highlighting mode, the visual effect to be used when the mouse button is pressed or held down inside its active area.
    /// </summary>
    /// <value>Enumerates the annotation’s highlighting mode, the visual effect to be used when the mouse button is pressed or held down inside its active area.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LinkHighlightingMode
    {
        
        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        
        /// <summary>
        /// Enum Invert for "Invert"
        /// </summary>
        [EnumMember(Value = "Invert")]
        Invert,
        
        /// <summary>
        /// Enum Outline for "Outline"
        /// </summary>
        [EnumMember(Value = "Outline")]
        Outline,
        
        /// <summary>
        /// Enum Push for "Push"
        /// </summary>
        [EnumMember(Value = "Push")]
        Push,
        
        /// <summary>
        /// Enum Toggle for "Toggle"
        /// </summary>
        [EnumMember(Value = "Toggle")]
        Toggle
    }

}
