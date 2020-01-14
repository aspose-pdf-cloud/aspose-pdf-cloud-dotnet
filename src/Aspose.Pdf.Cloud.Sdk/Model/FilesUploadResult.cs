// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FilesUploadResult.cs">
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
    /// File upload result
    /// </summary>
    [DataContract]
    public partial class FilesUploadResult :  IEquatable<FilesUploadResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesUploadResult" /> class.
        /// </summary>
        /// <param name="Uploaded">List of uploaded file names</param>
        /// <param name="Errors">List of errors.</param>
        public FilesUploadResult(List<string> Uploaded = default(List<string>), List<Error> Errors = default(List<Error>))
        {
            this.Uploaded = Uploaded;
            this.Errors = Errors;
        }
        
        /// <summary>
        /// List of uploaded file names
        /// </summary>
        /// <value>List of uploaded file names</value>
        [DataMember(Name="Uploaded", EmitDefaultValue=false)]
        public List<string> Uploaded { get; set; }

        /// <summary>
        /// List of errors.
        /// </summary>
        /// <value>List of errors.</value>
        [DataMember(Name="Errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilesUploadResult {\n");
            sb.Append("  Uploaded: ").Append(Uploaded).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(obj as FilesUploadResult);
        }

        /// <summary>
        /// Returns true if FilesUploadResult instances are equal
        /// </summary>
        /// <param name="other">Instance of FilesUploadResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilesUploadResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Uploaded == other.Uploaded ||
                    this.Uploaded != null &&
                    this.Uploaded.SequenceEqual(other.Uploaded)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                if (this.Uploaded != null)
                    hash = hash * 59 + this.Uploaded.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
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
