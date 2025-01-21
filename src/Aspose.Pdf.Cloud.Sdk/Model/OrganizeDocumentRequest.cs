// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OrganizeDocumentRequest.cs">
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
    /// Documents data for organizing.
    /// </summary>
    [DataContract]
    public partial class OrganizeDocumentRequest :  IEquatable<OrganizeDocumentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizeDocumentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizeDocumentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizeDocumentRequest" /> class.
        /// </summary>
        /// <param name="List">List of document data for organizing. (required)</param>
        public OrganizeDocumentRequest(List<OrganizeDocumentData> List = default(List<OrganizeDocumentData>))
        {
            // to ensure "List" is required (not null)
            if (List == null)
            {
                throw new InvalidDataException("List is a required property for OrganizeDocumentRequest and cannot be null");
            }
            else
            {
                this.List = List;
            }
        }
        
        /// <summary>
        /// List of document data for organizing.
        /// </summary>
        /// <value>List of document data for organizing.</value>
        [DataMember(Name="List", EmitDefaultValue=false)]
        public List<OrganizeDocumentData> List { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizeDocumentRequest {\n");
            sb.Append("  List: ").Append(List).Append("\n");
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
            return this.Equals(obj as OrganizeDocumentRequest);
        }

        /// <summary>
        /// Returns true if OrganizeDocumentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizeDocumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizeDocumentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.List == other.List ||
                    this.List != null &&
                    this.List.SequenceEqual(other.List)
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
                if (this.List != null)
                    hash = hash * 59 + this.List.GetHashCode();
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
