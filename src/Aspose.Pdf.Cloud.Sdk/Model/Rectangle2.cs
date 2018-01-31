// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Rectangle2.cs">
//   Copyright (c) 2018 Aspose.Pdf for Cloud
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
    /// The Rectangle
    /// </summary>
    [DataContract]
    public partial class Rectangle2 :  IEquatable<Rectangle2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Rectangle2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle2" /> class.
        /// </summary>
        /// <param name="X">The x coord (required).</param>
        /// <param name="Y">The y coord (required).</param>
        /// <param name="Width">The width (required).</param>
        /// <param name="Height">The height (required).</param>
        public Rectangle2(int? X = default(int?), int? Y = default(int?), int? Width = default(int?), int? Height = default(int?))
        {
            // to ensure "X" is required (not null)
            if (X == null)
            {
                throw new InvalidDataException("X is a required property for Rectangle2 and cannot be null");
            }
            else
            {
                this.X = X;
            }
            // to ensure "Y" is required (not null)
            if (Y == null)
            {
                throw new InvalidDataException("Y is a required property for Rectangle2 and cannot be null");
            }
            else
            {
                this.Y = Y;
            }
            // to ensure "Width" is required (not null)
            if (Width == null)
            {
                throw new InvalidDataException("Width is a required property for Rectangle2 and cannot be null");
            }
            else
            {
                this.Width = Width;
            }
            // to ensure "Height" is required (not null)
            if (Height == null)
            {
                throw new InvalidDataException("Height is a required property for Rectangle2 and cannot be null");
            }
            else
            {
                this.Height = Height;
            }
        }
        
        /// <summary>
        /// The x coord
        /// </summary>
        /// <value>The x coord</value>
        [DataMember(Name="X", EmitDefaultValue=false)]
        public int? X { get; set; }

        /// <summary>
        /// The y coord
        /// </summary>
        /// <value>The y coord</value>
        [DataMember(Name="Y", EmitDefaultValue=false)]
        public int? Y { get; set; }

        /// <summary>
        /// The width
        /// </summary>
        /// <value>The width</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// The height
        /// </summary>
        /// <value>The height</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rectangle2 {\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return this.Equals(obj as Rectangle2);
        }

        /// <summary>
        /// Returns true if Rectangle2 instances are equal
        /// </summary>
        /// <param name="other">Instance of Rectangle2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rectangle2 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.X == other.X ||
                    this.X != null &&
                    this.X.Equals(other.X)
                ) && 
                (
                    this.Y == other.Y ||
                    this.Y != null &&
                    this.Y.Equals(other.Y)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
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
                if (this.X != null)
                    hash = hash * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hash = hash * 59 + this.Y.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
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
