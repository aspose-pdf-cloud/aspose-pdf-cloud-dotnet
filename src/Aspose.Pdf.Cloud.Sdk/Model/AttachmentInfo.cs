// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AttachmentInfo.cs">
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
    /// Attachment Info.
    /// </summary>
    [DataContract]
    public partial class AttachmentInfo :  IEquatable<AttachmentInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttachmentInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentInfo" /> class.
        /// </summary>
        /// <param name="Path">Attachment file path. (required)</param>
        /// <param name="Description">Attachment file description.</param>
        /// <param name="Name">Attachment file name.</param>
        /// <param name="MimeType">Attachment file MIME type.</param>
        public AttachmentInfo(string Path = default(string), string Description = default(string), string Name = default(string), string MimeType = default(string))
        {
            // to ensure "Path" is required (not null)
            if (Path == null)
            {
                throw new InvalidDataException("Path is a required property for AttachmentInfo and cannot be null");
            }
            else
            {
                this.Path = Path;
            }
            this.Description = Description;
            this.Name = Name;
            this.MimeType = MimeType;
        }
        
        /// <summary>
        /// Attachment file path.
        /// </summary>
        /// <value>Attachment file path.</value>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Attachment file description.
        /// </summary>
        /// <value>Attachment file description.</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Attachment file name.
        /// </summary>
        /// <value>Attachment file name.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Attachment file MIME type.
        /// </summary>
        /// <value>Attachment file MIME type.</value>
        [DataMember(Name="MimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentInfo {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
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
            return this.Equals(obj as AttachmentInfo);
        }

        /// <summary>
        /// Returns true if AttachmentInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AttachmentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentInfo other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.MimeType == other.MimeType ||
                    this.MimeType != null &&
                    this.MimeType.Equals(other.MimeType)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.MimeType != null)
                    hash = hash * 59 + this.MimeType.GetHashCode();
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

            yield break;
        }
    }

}
