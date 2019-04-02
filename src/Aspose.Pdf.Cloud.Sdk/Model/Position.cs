// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Position.cs">
//   Copyright (c) 2019 Aspose.PDF Cloud
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
    /// Represents a position object
    /// </summary>
    [DataContract]
    public partial class Position :  IEquatable<Position>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Position" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Position() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Position" /> class.
        /// </summary>
        /// <param name="XIndent">Gets the X coordinate of the object (required).</param>
        /// <param name="YIndent">Gets the Y coordinate of the object (required).</param>
        public Position(double? XIndent = default(double?), double? YIndent = default(double?))
        {
            // to ensure "XIndent" is required (not null)
            if (XIndent == null)
            {
                throw new InvalidDataException("XIndent is a required property for Position and cannot be null");
            }
            else
            {
                this.XIndent = XIndent;
            }
            // to ensure "YIndent" is required (not null)
            if (YIndent == null)
            {
                throw new InvalidDataException("YIndent is a required property for Position and cannot be null");
            }
            else
            {
                this.YIndent = YIndent;
            }
        }
        
        /// <summary>
        /// Gets the X coordinate of the object
        /// </summary>
        /// <value>Gets the X coordinate of the object</value>
        [DataMember(Name="XIndent", EmitDefaultValue=false)]
        public double? XIndent { get; set; }

        /// <summary>
        /// Gets the Y coordinate of the object
        /// </summary>
        /// <value>Gets the Y coordinate of the object</value>
        [DataMember(Name="YIndent", EmitDefaultValue=false)]
        public double? YIndent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Position {\n");
            sb.Append("  XIndent: ").Append(XIndent).Append("\n");
            sb.Append("  YIndent: ").Append(YIndent).Append("\n");
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
            return this.Equals(obj as Position);
        }

        /// <summary>
        /// Returns true if Position instances are equal
        /// </summary>
        /// <param name="other">Instance of Position to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Position other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.XIndent == other.XIndent ||
                    this.XIndent != null &&
                    this.XIndent.Equals(other.XIndent)
                ) && 
                (
                    this.YIndent == other.YIndent ||
                    this.YIndent != null &&
                    this.YIndent.Equals(other.YIndent)
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
                if (this.XIndent != null)
                    hash = hash * 59 + this.XIndent.GetHashCode();
                if (this.YIndent != null)
                    hash = hash * 59 + this.YIndent.GetHashCode();
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
