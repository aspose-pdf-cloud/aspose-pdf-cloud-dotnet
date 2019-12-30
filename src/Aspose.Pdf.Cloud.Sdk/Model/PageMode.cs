// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageMode.cs">
//   Copyright (c) 2020 Aspose.PDF Cloud
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
    /// Class descibes used components of the document page.
    /// </summary>
    /// <value>Class descibes used components of the document page.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PageMode
    {
        
        /// <summary>
        /// Enum UseNone for "UseNone"
        /// </summary>
        [EnumMember(Value = "UseNone")]
        UseNone,
        
        /// <summary>
        /// Enum UseOutlines for "UseOutlines"
        /// </summary>
        [EnumMember(Value = "UseOutlines")]
        UseOutlines,
        
        /// <summary>
        /// Enum UseThumbs for "UseThumbs"
        /// </summary>
        [EnumMember(Value = "UseThumbs")]
        UseThumbs,
        
        /// <summary>
        /// Enum FullScreen for "FullScreen"
        /// </summary>
        [EnumMember(Value = "FullScreen")]
        FullScreen,
        
        /// <summary>
        /// Enum UseOC for "UseOC"
        /// </summary>
        [EnumMember(Value = "UseOC")]
        UseOC,
        
        /// <summary>
        /// Enum UseAttachments for "UseAttachments"
        /// </summary>
        [EnumMember(Value = "UseAttachments")]
        UseAttachments
    }

}
