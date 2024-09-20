// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LayerInfo.cs">
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
    /// LayerInfo
    /// </summary>
    [DataContract]
    public partial class LayerInfo :  IEquatable<LayerInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayerInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LayerInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LayerInfo" /> class.
        /// </summary>
        /// <param name="PageNumber">Layer Page Number. (required)</param>
        /// <param name="Id">Layer Id.</param>
        /// <param name="Name">Layer Name.</param>
        /// <param name="Locked">Gets a value indicating whether the layer is locked. (required)</param>
        public LayerInfo(int? PageNumber = default(int?), string Id = default(string), string Name = default(string), bool? Locked = default(bool?))
        {
            // to ensure "PageNumber" is required (not null)
            if (PageNumber == null)
            {
                throw new InvalidDataException("PageNumber is a required property for LayerInfo and cannot be null");
            }
            else
            {
                this.PageNumber = PageNumber;
            }
            // to ensure "Locked" is required (not null)
            if (Locked == null)
            {
                throw new InvalidDataException("Locked is a required property for LayerInfo and cannot be null");
            }
            else
            {
                this.Locked = Locked;
            }
            this.Id = Id;
            this.Name = Name;
        }
        
        /// <summary>
        /// Layer Page Number.
        /// </summary>
        /// <value>Layer Page Number.</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Layer Id.
        /// </summary>
        /// <value>Layer Id.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Layer Name.
        /// </summary>
        /// <value>Layer Name.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets a value indicating whether the layer is locked.
        /// </summary>
        /// <value>Gets a value indicating whether the layer is locked.</value>
        [DataMember(Name="Locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayerInfo {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
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
            return this.Equals(obj as LayerInfo);
        }

        /// <summary>
        /// Returns true if LayerInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of LayerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LayerInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
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
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
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
