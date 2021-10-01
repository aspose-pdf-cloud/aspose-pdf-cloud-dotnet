// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextIcon.cs">
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
    /// Enumerates the icons to be used in displaying the annotation.
    /// </summary>
    /// <value>Enumerates the icons to be used in displaying the annotation.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextIcon
    {
        
        /// <summary>
        /// Enum Note for "Note"
        /// </summary>
        [EnumMember(Value = "Note")]
        Note,
        
        /// <summary>
        /// Enum Comment for "Comment"
        /// </summary>
        [EnumMember(Value = "Comment")]
        Comment,
        
        /// <summary>
        /// Enum Key for "Key"
        /// </summary>
        [EnumMember(Value = "Key")]
        Key,
        
        /// <summary>
        /// Enum Help for "Help"
        /// </summary>
        [EnumMember(Value = "Help")]
        Help,
        
        /// <summary>
        /// Enum NewParagraph for "NewParagraph"
        /// </summary>
        [EnumMember(Value = "NewParagraph")]
        NewParagraph,
        
        /// <summary>
        /// Enum Paragraph for "Paragraph"
        /// </summary>
        [EnumMember(Value = "Paragraph")]
        Paragraph,
        
        /// <summary>
        /// Enum Insert for "Insert"
        /// </summary>
        [EnumMember(Value = "Insert")]
        Insert,
        
        /// <summary>
        /// Enum Check for "Check"
        /// </summary>
        [EnumMember(Value = "Check")]
        Check,
        
        /// <summary>
        /// Enum Cross for "Cross"
        /// </summary>
        [EnumMember(Value = "Cross")]
        Cross,
        
        /// <summary>
        /// Enum Circle for "Circle"
        /// </summary>
        [EnumMember(Value = "Circle")]
        Circle,
        
        /// <summary>
        /// Enum Star for "Star"
        /// </summary>
        [EnumMember(Value = "Star")]
        Star
    }

}
