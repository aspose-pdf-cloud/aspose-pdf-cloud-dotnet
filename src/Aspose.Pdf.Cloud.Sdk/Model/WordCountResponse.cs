// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WordCountResponse.cs">
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
    /// Number of words per document pages.
    /// </summary>
    [DataContract]
    public partial class WordCountResponse : AsposeResponse,  IEquatable<WordCountResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WordCountResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WordCountResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WordCountResponse" /> class.
        /// </summary>
        /// <param name="Code">Response status code. (required)</param>
        /// <param name="Status">Response status.</param>
        /// <param name="WordsPerPage">WordCount with words per page info.</param>
        public WordCountResponse(int? Code = default(int?), string Status = default(string), WordCount WordsPerPage = default(WordCount))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for WordCountResponse and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            this.Status = Status;
            this.WordsPerPage = WordsPerPage;
        }
        
        /// <summary>
        /// Response status code.
        /// </summary>
        /// <value>Response status code.</value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public int? Code { get; set; }

        /// <summary>
        /// Response status.
        /// </summary>
        /// <value>Response status.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// WordCount with words per page info.
        /// </summary>
        /// <value>WordCount with words per page info.</value>
        [DataMember(Name="WordsPerPage", EmitDefaultValue=false)]
        public WordCount WordsPerPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WordCountResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WordsPerPage: ").Append(WordsPerPage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WordCountResponse);
        }

        /// <summary>
        /// Returns true if WordCountResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WordCountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WordCountResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.WordsPerPage == other.WordsPerPage ||
                    this.WordsPerPage != null &&
                    this.WordsPerPage.Equals(other.WordsPerPage)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.WordsPerPage != null)
                    hash = hash * 59 + this.WordsPerPage.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
