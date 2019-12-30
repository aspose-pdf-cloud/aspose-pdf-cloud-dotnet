// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Color.cs">
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
    /// Represents color DTO.
    /// </summary>
    [DataContract]
    public partial class Color :  IEquatable<Color>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Color" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Color() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Color" /> class.
        /// </summary>
        /// <param name="A">Alpha component. (required)</param>
        /// <param name="R">Red component. (required)</param>
        /// <param name="G">Green component. (required)</param>
        /// <param name="B">Blue component. (required)</param>
        public Color(int? A = default(int?), int? R = default(int?), int? G = default(int?), int? B = default(int?))
        {
            // to ensure "A" is required (not null)
            if (A == null)
            {
                throw new InvalidDataException("A is a required property for Color and cannot be null");
            }
            else
            {
                this.A = A;
            }
            // to ensure "R" is required (not null)
            if (R == null)
            {
                throw new InvalidDataException("R is a required property for Color and cannot be null");
            }
            else
            {
                this.R = R;
            }
            // to ensure "G" is required (not null)
            if (G == null)
            {
                throw new InvalidDataException("G is a required property for Color and cannot be null");
            }
            else
            {
                this.G = G;
            }
            // to ensure "B" is required (not null)
            if (B == null)
            {
                throw new InvalidDataException("B is a required property for Color and cannot be null");
            }
            else
            {
                this.B = B;
            }
        }
        
        /// <summary>
        /// Alpha component.
        /// </summary>
        /// <value>Alpha component.</value>
        [DataMember(Name="A", EmitDefaultValue=false)]
        public int? A { get; set; }

        /// <summary>
        /// Red component.
        /// </summary>
        /// <value>Red component.</value>
        [DataMember(Name="R", EmitDefaultValue=false)]
        public int? R { get; set; }

        /// <summary>
        /// Green component.
        /// </summary>
        /// <value>Green component.</value>
        [DataMember(Name="G", EmitDefaultValue=false)]
        public int? G { get; set; }

        /// <summary>
        /// Blue component.
        /// </summary>
        /// <value>Blue component.</value>
        [DataMember(Name="B", EmitDefaultValue=false)]
        public int? B { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Color {\n");
            sb.Append("  A: ").Append(A).Append("\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  G: ").Append(G).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
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
            return this.Equals(obj as Color);
        }

        /// <summary>
        /// Returns true if Color instances are equal
        /// </summary>
        /// <param name="other">Instance of Color to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Color other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.A == other.A ||
                    this.A != null &&
                    this.A.Equals(other.A)
                ) && 
                (
                    this.R == other.R ||
                    this.R != null &&
                    this.R.Equals(other.R)
                ) && 
                (
                    this.G == other.G ||
                    this.G != null &&
                    this.G.Equals(other.G)
                ) && 
                (
                    this.B == other.B ||
                    this.B != null &&
                    this.B.Equals(other.B)
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
                if (this.A != null)
                    hash = hash * 59 + this.A.GetHashCode();
                if (this.R != null)
                    hash = hash * 59 + this.R.GetHashCode();
                if (this.G != null)
                    hash = hash * 59 + this.G.GetHashCode();
                if (this.B != null)
                    hash = hash * 59 + this.B.GetHashCode();
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
