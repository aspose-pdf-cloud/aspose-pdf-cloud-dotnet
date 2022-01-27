// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StampIcon.cs">
//   Copyright (c) 2022 Aspose.PDF Cloud
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
    /// Enumerates the icons to be used in displaying the annotation.
    /// </summary>
    /// <value>Enumerates the icons to be used in displaying the annotation.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StampIcon
    {
        
        /// <summary>
        /// Enum Draft for "Draft"
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft,
        
        /// <summary>
        /// Enum Approved for "Approved"
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved,
        
        /// <summary>
        /// Enum Experimental for "Experimental"
        /// </summary>
        [EnumMember(Value = "Experimental")]
        Experimental,
        
        /// <summary>
        /// Enum NotApproved for "NotApproved"
        /// </summary>
        [EnumMember(Value = "NotApproved")]
        NotApproved,
        
        /// <summary>
        /// Enum AsIs for "AsIs"
        /// </summary>
        [EnumMember(Value = "AsIs")]
        AsIs,
        
        /// <summary>
        /// Enum Expired for "Expired"
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired,
        
        /// <summary>
        /// Enum NotForPublicRelease for "NotForPublicRelease"
        /// </summary>
        [EnumMember(Value = "NotForPublicRelease")]
        NotForPublicRelease,
        
        /// <summary>
        /// Enum Confidential for "Confidential"
        /// </summary>
        [EnumMember(Value = "Confidential")]
        Confidential,
        
        /// <summary>
        /// Enum Final for "Final"
        /// </summary>
        [EnumMember(Value = "Final")]
        Final,
        
        /// <summary>
        /// Enum Sold for "Sold"
        /// </summary>
        [EnumMember(Value = "Sold")]
        Sold,
        
        /// <summary>
        /// Enum Departmental for "Departmental"
        /// </summary>
        [EnumMember(Value = "Departmental")]
        Departmental,
        
        /// <summary>
        /// Enum ForComment for "ForComment"
        /// </summary>
        [EnumMember(Value = "ForComment")]
        ForComment,
        
        /// <summary>
        /// Enum ForPublicRelease for "ForPublicRelease"
        /// </summary>
        [EnumMember(Value = "ForPublicRelease")]
        ForPublicRelease,
        
        /// <summary>
        /// Enum TopSecret for "TopSecret"
        /// </summary>
        [EnumMember(Value = "TopSecret")]
        TopSecret
    }

}
