// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PageLayout.cs">
//   Copyright (c) 2021 Aspose.PDF Cloud
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
    /// Descibes page layout.
    /// </summary>
    /// <value>Descibes page layout.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PageLayout
    {
        
        /// <summary>
        /// Enum SinglePage for "SinglePage"
        /// </summary>
        [EnumMember(Value = "SinglePage")]
        SinglePage,
        
        /// <summary>
        /// Enum OneColumn for "OneColumn"
        /// </summary>
        [EnumMember(Value = "OneColumn")]
        OneColumn,
        
        /// <summary>
        /// Enum TwoColumnLeft for "TwoColumnLeft"
        /// </summary>
        [EnumMember(Value = "TwoColumnLeft")]
        TwoColumnLeft,
        
        /// <summary>
        /// Enum TwoColumnRight for "TwoColumnRight"
        /// </summary>
        [EnumMember(Value = "TwoColumnRight")]
        TwoColumnRight,
        
        /// <summary>
        /// Enum TwoPageLeft for "TwoPageLeft"
        /// </summary>
        [EnumMember(Value = "TwoPageLeft")]
        TwoPageLeft,
        
        /// <summary>
        /// Enum TwoPageRight for "TwoPageRight"
        /// </summary>
        [EnumMember(Value = "TwoPageRight")]
        TwoPageRight,
        
        /// <summary>
        /// Enum Default for "Default"
        /// </summary>
        [EnumMember(Value = "Default")]
        Default
    }

}
