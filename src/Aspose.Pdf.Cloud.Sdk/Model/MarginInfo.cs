// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MarginInfo.cs">
//   Copyright (c) 2023 Aspose.PDF Cloud
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
    /// This class represents a margin for different objects.
    /// </summary>
    [DataContract]
    public partial class MarginInfo :  IEquatable<MarginInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarginInfo" /> class.
        /// </summary>
        /// <param name="Left">Gets or sets a float value that indicates the left margin.</param>
        /// <param name="Right">Gets or sets a float value that indicates the right margin.</param>
        /// <param name="Top">Gets or sets a float value that indicates the top margin.</param>
        /// <param name="Bottom">Gets or sets a float value that indicates the bottom margin.</param>
        public MarginInfo(double? Left = default(double?), double? Right = default(double?), double? Top = default(double?), double? Bottom = default(double?))
        {
            this.Left = Left;
            this.Right = Right;
            this.Top = Top;
            this.Bottom = Bottom;
        }
        
        /// <summary>
        /// Gets or sets a float value that indicates the left margin.
        /// </summary>
        /// <value>Gets or sets a float value that indicates the left margin.</value>
        [DataMember(Name="Left", EmitDefaultValue=false)]
        public double? Left { get; set; }

        /// <summary>
        /// Gets or sets a float value that indicates the right margin.
        /// </summary>
        /// <value>Gets or sets a float value that indicates the right margin.</value>
        [DataMember(Name="Right", EmitDefaultValue=false)]
        public double? Right { get; set; }

        /// <summary>
        /// Gets or sets a float value that indicates the top margin.
        /// </summary>
        /// <value>Gets or sets a float value that indicates the top margin.</value>
        [DataMember(Name="Top", EmitDefaultValue=false)]
        public double? Top { get; set; }

        /// <summary>
        /// Gets or sets a float value that indicates the bottom margin.
        /// </summary>
        /// <value>Gets or sets a float value that indicates the bottom margin.</value>
        [DataMember(Name="Bottom", EmitDefaultValue=false)]
        public double? Bottom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarginInfo {\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Bottom: ").Append(Bottom).Append("\n");
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
            return this.Equals(obj as MarginInfo);
        }

        /// <summary>
        /// Returns true if MarginInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of MarginInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarginInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Left == other.Left ||
                    this.Left != null &&
                    this.Left.Equals(other.Left)
                ) && 
                (
                    this.Right == other.Right ||
                    this.Right != null &&
                    this.Right.Equals(other.Right)
                ) && 
                (
                    this.Top == other.Top ||
                    this.Top != null &&
                    this.Top.Equals(other.Top)
                ) && 
                (
                    this.Bottom == other.Bottom ||
                    this.Bottom != null &&
                    this.Bottom.Equals(other.Bottom)
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
                if (this.Left != null)
                    hash = hash * 59 + this.Left.GetHashCode();
                if (this.Right != null)
                    hash = hash * 59 + this.Right.GetHashCode();
                if (this.Top != null)
                    hash = hash * 59 + this.Top.GetHashCode();
                if (this.Bottom != null)
                    hash = hash * 59 + this.Bottom.GetHashCode();
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
