// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="XmpMetadataProperty.cs">
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
    /// Xmp Metadata Property.
    /// </summary>
    [DataContract]
    public partial class XmpMetadataProperty :  IEquatable<XmpMetadataProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmpMetadataProperty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XmpMetadataProperty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XmpMetadataProperty" /> class.
        /// </summary>
        /// <param name="Key">Xmp Metadata Property Key. Can take the form for default keys: xmp:DefaultKeyName or DefaultKeyName. Form for user defined properties: customNamespace:UserPropertyName. (required)</param>
        /// <param name="Value">Xmp Metadata Property Value. Null for delete property.</param>
        /// <param name="NamespaceUri">Namespace Uri. For user defined properties only.</param>
        public XmpMetadataProperty(string Key = default(string), string Value = default(string), string NamespaceUri = default(string))
        {
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for XmpMetadataProperty and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            this.Value = Value;
            this.NamespaceUri = NamespaceUri;
        }
        
        /// <summary>
        /// Xmp Metadata Property Key. Can take the form for default keys: xmp:DefaultKeyName or DefaultKeyName. Form for user defined properties: customNamespace:UserPropertyName.
        /// </summary>
        /// <value>Xmp Metadata Property Key. Can take the form for default keys: xmp:DefaultKeyName or DefaultKeyName. Form for user defined properties: customNamespace:UserPropertyName.</value>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Xmp Metadata Property Value. Null for delete property.
        /// </summary>
        /// <value>Xmp Metadata Property Value. Null for delete property.</value>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Namespace Uri. For user defined properties only.
        /// </summary>
        /// <value>Namespace Uri. For user defined properties only.</value>
        [DataMember(Name="NamespaceUri", EmitDefaultValue=false)]
        public string NamespaceUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XmpMetadataProperty {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  NamespaceUri: ").Append(NamespaceUri).Append("\n");
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
            return this.Equals(obj as XmpMetadataProperty);
        }

        /// <summary>
        /// Returns true if XmpMetadataProperty instances are equal
        /// </summary>
        /// <param name="other">Instance of XmpMetadataProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XmpMetadataProperty other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.NamespaceUri == other.NamespaceUri ||
                    this.NamespaceUri != null &&
                    this.NamespaceUri.Equals(other.NamespaceUri)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.NamespaceUri != null)
                    hash = hash * 59 + this.NamespaceUri.GetHashCode();
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
            // Key (string) minLength
            if(this.Key != null && this.Key.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be greater than 1.", new [] { "Key" });
            }

            yield break;
        }
    }

}
