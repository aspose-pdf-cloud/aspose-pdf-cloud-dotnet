// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ColorDepth.cs">
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
    /// Used to specify the parameter value passed to a Tiff image device.
    /// </summary>
    /// <value>Used to specify the parameter value passed to a Tiff image device.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ColorDepth
    {
        
        /// <summary>
        /// Enum Default for "Default"
        /// </summary>
        [EnumMember(Value = "Default")]
        Default,
        
        /// <summary>
        /// Enum Format8bpp for "Format8bpp"
        /// </summary>
        [EnumMember(Value = "Format8bpp")]
        Format8bpp,
        
        /// <summary>
        /// Enum Format4bpp for "Format4bpp"
        /// </summary>
        [EnumMember(Value = "Format4bpp")]
        Format4bpp,
        
        /// <summary>
        /// Enum Format1bpp for "Format1bpp"
        /// </summary>
        [EnumMember(Value = "Format1bpp")]
        Format1bpp
    }

}
