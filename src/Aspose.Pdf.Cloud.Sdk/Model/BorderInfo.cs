// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BorderInfo.cs">
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
    /// This class represents border for graphics elements.
    /// </summary>
    [DataContract]
    public partial class BorderInfo :  IEquatable<BorderInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BorderInfo" /> class.
        /// </summary>
        /// <param name="Left">Gets or sets a object that indicates left of the border..</param>
        /// <param name="Right">Gets or sets a object that indicates right of the border..</param>
        /// <param name="Top">Gets or sets a object that indicates the top border..</param>
        /// <param name="Bottom">Gets or sets a object that indicates bottom of the border..</param>
        /// <param name="RoundedBorderRadius">Gets or sets a rouded border radius.</param>
        public BorderInfo(GraphInfo Left = default(GraphInfo), GraphInfo Right = default(GraphInfo), GraphInfo Top = default(GraphInfo), GraphInfo Bottom = default(GraphInfo), double? RoundedBorderRadius = default(double?))
        {
            this.Left = Left;
            this.Right = Right;
            this.Top = Top;
            this.Bottom = Bottom;
            this.RoundedBorderRadius = RoundedBorderRadius;
        }
        
        /// <summary>
        /// Gets or sets a object that indicates left of the border.
        /// </summary>
        /// <value>Gets or sets a object that indicates left of the border.</value>
        [DataMember(Name="Left", EmitDefaultValue=false)]
        public GraphInfo Left { get; set; }

        /// <summary>
        /// Gets or sets a object that indicates right of the border.
        /// </summary>
        /// <value>Gets or sets a object that indicates right of the border.</value>
        [DataMember(Name="Right", EmitDefaultValue=false)]
        public GraphInfo Right { get; set; }

        /// <summary>
        /// Gets or sets a object that indicates the top border.
        /// </summary>
        /// <value>Gets or sets a object that indicates the top border.</value>
        [DataMember(Name="Top", EmitDefaultValue=false)]
        public GraphInfo Top { get; set; }

        /// <summary>
        /// Gets or sets a object that indicates bottom of the border.
        /// </summary>
        /// <value>Gets or sets a object that indicates bottom of the border.</value>
        [DataMember(Name="Bottom", EmitDefaultValue=false)]
        public GraphInfo Bottom { get; set; }

        /// <summary>
        /// Gets or sets a rouded border radius
        /// </summary>
        /// <value>Gets or sets a rouded border radius</value>
        [DataMember(Name="RoundedBorderRadius", EmitDefaultValue=false)]
        public double? RoundedBorderRadius { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BorderInfo {\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Bottom: ").Append(Bottom).Append("\n");
            sb.Append("  RoundedBorderRadius: ").Append(RoundedBorderRadius).Append("\n");
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
            return this.Equals(obj as BorderInfo);
        }

        /// <summary>
        /// Returns true if BorderInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of BorderInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BorderInfo other)
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
                ) && 
                (
                    this.RoundedBorderRadius == other.RoundedBorderRadius ||
                    this.RoundedBorderRadius != null &&
                    this.RoundedBorderRadius.Equals(other.RoundedBorderRadius)
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
                if (this.RoundedBorderRadius != null)
                    hash = hash * 59 + this.RoundedBorderRadius.GetHashCode();
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
