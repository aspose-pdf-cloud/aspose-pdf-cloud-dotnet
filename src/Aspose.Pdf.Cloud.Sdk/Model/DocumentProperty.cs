// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentProperty.cs">
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
    /// Pdf document property.
    /// </summary>
    [DataContract]
    public partial class DocumentProperty : LinkElement,  IEquatable<DocumentProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentProperty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentProperty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentProperty" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="Name">Name of the property.</param>
        /// <param name="Value">Property value.</param>
        /// <param name="BuiltIn">Value indicating whether it is a built-in property. (required)</param>
        public DocumentProperty(List<Link> Links = default(List<Link>), string Name = default(string), string Value = default(string), bool? BuiltIn = default(bool?))
        {
            // to ensure "BuiltIn" is required (not null)
            if (BuiltIn == null)
            {
                throw new InvalidDataException("BuiltIn is a required property for DocumentProperty and cannot be null");
            }
            else
            {
                this.BuiltIn = BuiltIn;
            }
            this.Links = Links;
            this.Name = Name;
            this.Value = Value;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Name of the property.
        /// </summary>
        /// <value>Name of the property.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Property value.
        /// </summary>
        /// <value>Property value.</value>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Value indicating whether it is a built-in property.
        /// </summary>
        /// <value>Value indicating whether it is a built-in property.</value>
        [DataMember(Name="BuiltIn", EmitDefaultValue=false)]
        public bool? BuiltIn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentProperty {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  BuiltIn: ").Append(BuiltIn).Append("\n");
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
            return this.Equals(obj as DocumentProperty);
        }

        /// <summary>
        /// Returns true if DocumentProperty instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentProperty other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(other.Links)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.BuiltIn == other.BuiltIn ||
                    this.BuiltIn != null &&
                    this.BuiltIn.Equals(other.BuiltIn)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.BuiltIn != null)
                    hash = hash * 59 + this.BuiltIn.GetHashCode();
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
