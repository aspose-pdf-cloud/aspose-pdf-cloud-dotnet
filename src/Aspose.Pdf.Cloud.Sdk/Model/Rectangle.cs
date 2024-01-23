// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Rectangle.cs">
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
    /// Represents rectangle DTO.
    /// </summary>
    [DataContract]
    public partial class Rectangle :  IEquatable<Rectangle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Rectangle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle" /> class.
        /// </summary>
        /// <param name="LLX">X-coordinate of lower - left corner. (required)</param>
        /// <param name="LLY">Y - coordinate of lower-left corner. (required)</param>
        /// <param name="URX">X - coordinate of upper-right corner. (required)</param>
        /// <param name="URY">Y - coordinate of upper-right corner. (required)</param>
        public Rectangle(double? LLX = default(double?), double? LLY = default(double?), double? URX = default(double?), double? URY = default(double?))
        {
            // to ensure "LLX" is required (not null)
            if (LLX == null)
            {
                throw new InvalidDataException("LLX is a required property for Rectangle and cannot be null");
            }
            else
            {
                this.LLX = LLX;
            }
            // to ensure "LLY" is required (not null)
            if (LLY == null)
            {
                throw new InvalidDataException("LLY is a required property for Rectangle and cannot be null");
            }
            else
            {
                this.LLY = LLY;
            }
            // to ensure "URX" is required (not null)
            if (URX == null)
            {
                throw new InvalidDataException("URX is a required property for Rectangle and cannot be null");
            }
            else
            {
                this.URX = URX;
            }
            // to ensure "URY" is required (not null)
            if (URY == null)
            {
                throw new InvalidDataException("URY is a required property for Rectangle and cannot be null");
            }
            else
            {
                this.URY = URY;
            }
        }
        
        /// <summary>
        /// X-coordinate of lower - left corner.
        /// </summary>
        /// <value>X-coordinate of lower - left corner.</value>
        [DataMember(Name="LLX", EmitDefaultValue=false)]
        public double? LLX { get; set; }

        /// <summary>
        /// Y - coordinate of lower-left corner.
        /// </summary>
        /// <value>Y - coordinate of lower-left corner.</value>
        [DataMember(Name="LLY", EmitDefaultValue=false)]
        public double? LLY { get; set; }

        /// <summary>
        /// X - coordinate of upper-right corner.
        /// </summary>
        /// <value>X - coordinate of upper-right corner.</value>
        [DataMember(Name="URX", EmitDefaultValue=false)]
        public double? URX { get; set; }

        /// <summary>
        /// Y - coordinate of upper-right corner.
        /// </summary>
        /// <value>Y - coordinate of upper-right corner.</value>
        [DataMember(Name="URY", EmitDefaultValue=false)]
        public double? URY { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rectangle {\n");
            sb.Append("  LLX: ").Append(LLX).Append("\n");
            sb.Append("  LLY: ").Append(LLY).Append("\n");
            sb.Append("  URX: ").Append(URX).Append("\n");
            sb.Append("  URY: ").Append(URY).Append("\n");
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
            return this.Equals(obj as Rectangle);
        }

        /// <summary>
        /// Returns true if Rectangle instances are equal
        /// </summary>
        /// <param name="other">Instance of Rectangle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rectangle other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LLX == other.LLX ||
                    this.LLX != null &&
                    this.LLX.Equals(other.LLX)
                ) && 
                (
                    this.LLY == other.LLY ||
                    this.LLY != null &&
                    this.LLY.Equals(other.LLY)
                ) && 
                (
                    this.URX == other.URX ||
                    this.URX != null &&
                    this.URX.Equals(other.URX)
                ) && 
                (
                    this.URY == other.URY ||
                    this.URY != null &&
                    this.URY.Equals(other.URY)
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
                if (this.LLX != null)
                    hash = hash * 59 + this.LLX.GetHashCode();
                if (this.LLY != null)
                    hash = hash * 59 + this.LLY.GetHashCode();
                if (this.URX != null)
                    hash = hash * 59 + this.URX.GetHashCode();
                if (this.URY != null)
                    hash = hash * 59 + this.URY.GetHashCode();
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
