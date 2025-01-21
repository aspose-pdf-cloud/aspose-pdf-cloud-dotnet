// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AnnotationFlags.cs">
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
    /// A set of flags specifying various characteristics of the annotation.
    /// </summary>
    /// <value>A set of flags specifying various characteristics of the annotation.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AnnotationFlags
    {
        
        /// <summary>
        /// Enum Default for "Default"
        /// </summary>
        [EnumMember(Value = "Default")]
        Default,
        
        /// <summary>
        /// Enum Invisible for "Invisible"
        /// </summary>
        [EnumMember(Value = "Invisible")]
        Invisible,
        
        /// <summary>
        /// Enum Hidden for "Hidden"
        /// </summary>
        [EnumMember(Value = "Hidden")]
        Hidden,
        
        /// <summary>
        /// Enum Print for "Print"
        /// </summary>
        [EnumMember(Value = "Print")]
        Print,
        
        /// <summary>
        /// Enum NoZoom for "NoZoom"
        /// </summary>
        [EnumMember(Value = "NoZoom")]
        NoZoom,
        
        /// <summary>
        /// Enum NoRotate for "NoRotate"
        /// </summary>
        [EnumMember(Value = "NoRotate")]
        NoRotate,
        
        /// <summary>
        /// Enum NoView for "NoView"
        /// </summary>
        [EnumMember(Value = "NoView")]
        NoView,
        
        /// <summary>
        /// Enum ReadOnly for "ReadOnly"
        /// </summary>
        [EnumMember(Value = "ReadOnly")]
        ReadOnly,
        
        /// <summary>
        /// Enum Locked for "Locked"
        /// </summary>
        [EnumMember(Value = "Locked")]
        Locked,
        
        /// <summary>
        /// Enum ToggleNoView for "ToggleNoView"
        /// </summary>
        [EnumMember(Value = "ToggleNoView")]
        ToggleNoView,
        
        /// <summary>
        /// Enum LockedContents for "LockedContents"
        /// </summary>
        [EnumMember(Value = "LockedContents")]
        LockedContents
    }

}
