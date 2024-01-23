// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ObjectExist.cs">
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
    /// Object exists
    /// </summary>
    [DataContract]
    public partial class ObjectExist :  IEquatable<ObjectExist>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectExist" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObjectExist() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectExist" /> class.
        /// </summary>
        /// <param name="Exists">Indicates that the file or folder exists. (required)</param>
        /// <param name="IsFolder">True if it is a folder, false if it is a file. (required)</param>
        public ObjectExist(bool? Exists = default(bool?), bool? IsFolder = default(bool?))
        {
            // to ensure "Exists" is required (not null)
            if (Exists == null)
            {
                throw new InvalidDataException("Exists is a required property for ObjectExist and cannot be null");
            }
            else
            {
                this.Exists = Exists;
            }
            // to ensure "IsFolder" is required (not null)
            if (IsFolder == null)
            {
                throw new InvalidDataException("IsFolder is a required property for ObjectExist and cannot be null");
            }
            else
            {
                this.IsFolder = IsFolder;
            }
        }
        
        /// <summary>
        /// Indicates that the file or folder exists.
        /// </summary>
        /// <value>Indicates that the file or folder exists.</value>
        [DataMember(Name="Exists", EmitDefaultValue=false)]
        public bool? Exists { get; set; }

        /// <summary>
        /// True if it is a folder, false if it is a file.
        /// </summary>
        /// <value>True if it is a folder, false if it is a file.</value>
        [DataMember(Name="IsFolder", EmitDefaultValue=false)]
        public bool? IsFolder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectExist {\n");
            sb.Append("  Exists: ").Append(Exists).Append("\n");
            sb.Append("  IsFolder: ").Append(IsFolder).Append("\n");
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
            return this.Equals(obj as ObjectExist);
        }

        /// <summary>
        /// Returns true if ObjectExist instances are equal
        /// </summary>
        /// <param name="other">Instance of ObjectExist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectExist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Exists == other.Exists ||
                    this.Exists != null &&
                    this.Exists.Equals(other.Exists)
                ) && 
                (
                    this.IsFolder == other.IsFolder ||
                    this.IsFolder != null &&
                    this.IsFolder.Equals(other.IsFolder)
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
                if (this.Exists != null)
                    hash = hash * 59 + this.Exists.GetHashCode();
                if (this.IsFolder != null)
                    hash = hash * 59 + this.IsFolder.GetHashCode();
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
