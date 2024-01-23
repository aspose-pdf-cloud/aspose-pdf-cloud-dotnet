// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OrganizeDocumentData.cs">
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
    /// Data for document organizing.
    /// </summary>
    [DataContract]
    public partial class OrganizeDocumentData :  IEquatable<OrganizeDocumentData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizeDocumentData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizeDocumentData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizeDocumentData" /> class.
        /// </summary>
        /// <param name="Path">Full filename of the document for organizing. (required)</param>
        /// <param name="Pages">1-based page numbers of the document that make up the resulting document. (required)</param>
        public OrganizeDocumentData(string Path = default(string), string Pages = default(string))
        {
            // to ensure "Path" is required (not null)
            if (Path == null)
            {
                throw new InvalidDataException("Path is a required property for OrganizeDocumentData and cannot be null");
            }
            else
            {
                this.Path = Path;
            }
            // to ensure "Pages" is required (not null)
            if (Pages == null)
            {
                throw new InvalidDataException("Pages is a required property for OrganizeDocumentData and cannot be null");
            }
            else
            {
                this.Pages = Pages;
            }
        }
        
        /// <summary>
        /// Full filename of the document for organizing.
        /// </summary>
        /// <value>Full filename of the document for organizing.</value>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// 1-based page numbers of the document that make up the resulting document.
        /// </summary>
        /// <value>1-based page numbers of the document that make up the resulting document.</value>
        [DataMember(Name="Pages", EmitDefaultValue=false)]
        public string Pages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizeDocumentData {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(obj as OrganizeDocumentData);
        }

        /// <summary>
        /// Returns true if OrganizeDocumentData instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizeDocumentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizeDocumentData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Pages == other.Pages ||
                    this.Pages != null &&
                    this.Pages.Equals(other.Pages)
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
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Pages != null)
                    hash = hash * 59 + this.Pages.GetHashCode();
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
            // Path (string) minLength
            if(this.Path != null && this.Path.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Path, length must be greater than 1.", new [] { "Path" });
            }

            // Pages (string) minLength
            if(this.Pages != null && this.Pages.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Pages, length must be greater than 1.", new [] { "Pages" });
            }

            yield break;
        }
    }

}
