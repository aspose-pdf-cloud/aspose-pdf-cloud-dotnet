// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CryptoAlgorithm.cs">
//   Copyright (c) 2023 Aspose.PDF Cloud
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
    /// Represent type of cryptographic algorithm that used in encryption/decryption routines.
    /// </summary>
    /// <value>Represent type of cryptographic algorithm that used in encryption/decryption routines.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CryptoAlgorithm
    {
        
        /// <summary>
        /// Enum RC4x40 for "RC4x40"
        /// </summary>
        [EnumMember(Value = "RC4x40")]
        RC4x40,
        
        /// <summary>
        /// Enum RC4x128 for "RC4x128"
        /// </summary>
        [EnumMember(Value = "RC4x128")]
        RC4x128,
        
        /// <summary>
        /// Enum AESx128 for "AESx128"
        /// </summary>
        [EnumMember(Value = "AESx128")]
        AESx128,
        
        /// <summary>
        /// Enum AESx256 for "AESx256"
        /// </summary>
        [EnumMember(Value = "AESx256")]
        AESx256
    }

}
