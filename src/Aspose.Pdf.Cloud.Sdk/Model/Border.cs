// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Border.cs">
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
    /// Class representing characteristics of annotation border.
    /// </summary>
    [DataContract]
    public partial class Border :  IEquatable<Border>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Border" /> class.
        /// </summary>
        /// <param name="Width">Gets or sets border width.</param>
        /// <param name="EffectIntensity">Gets or sets effect intencity. Valid range of value is [0..2].</param>
        /// <param name="Style">Gets or sets border style.</param>
        /// <param name="Effect">Gets or sets border effect.</param>
        /// <param name="Dash">Gets or sets dash pattern.</param>
        /// <param name="Color">Gets or sets border color.</param>
        public Border(int? Width = default(int?), int? EffectIntensity = default(int?), BorderStyle Style = default(BorderStyle), BorderEffect Effect = default(BorderEffect), Dash Dash = default(Dash), Color Color = default(Color))
        {
            this.Width = Width;
            this.EffectIntensity = EffectIntensity;
            this.Style = Style;
            this.Effect = Effect;
            this.Dash = Dash;
            this.Color = Color;
        }
        
        /// <summary>
        /// Gets or sets border width.
        /// </summary>
        /// <value>Gets or sets border width.</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets effect intencity. Valid range of value is [0..2].
        /// </summary>
        /// <value>Gets or sets effect intencity. Valid range of value is [0..2].</value>
        [DataMember(Name="EffectIntensity", EmitDefaultValue=false)]
        public int? EffectIntensity { get; set; }

        /// <summary>
        /// Gets or sets border style.
        /// </summary>
        /// <value>Gets or sets border style.</value>
        [DataMember(Name="Style", EmitDefaultValue=true)]
        public BorderStyle Style { get; set; }

        /// <summary>
        /// Gets or sets border effect.
        /// </summary>
        /// <value>Gets or sets border effect.</value>
        [DataMember(Name="Effect", EmitDefaultValue=true)]
        public BorderEffect Effect { get; set; }

        /// <summary>
        /// Gets or sets dash pattern.
        /// </summary>
        /// <value>Gets or sets dash pattern.</value>
        [DataMember(Name="Dash", EmitDefaultValue=false)]
        public Dash Dash { get; set; }

        /// <summary>
        /// Gets or sets border color.
        /// </summary>
        /// <value>Gets or sets border color.</value>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Border {\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  EffectIntensity: ").Append(EffectIntensity).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
            sb.Append("  Effect: ").Append(Effect).Append("\n");
            sb.Append("  Dash: ").Append(Dash).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
            return this.Equals(obj as Border);
        }

        /// <summary>
        /// Returns true if Border instances are equal
        /// </summary>
        /// <param name="other">Instance of Border to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Border other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.EffectIntensity == other.EffectIntensity ||
                    this.EffectIntensity != null &&
                    this.EffectIntensity.Equals(other.EffectIntensity)
                ) && 
                (
                    this.Style == other.Style ||
                    this.Style != null &&
                    this.Style.Equals(other.Style)
                ) && 
                (
                    this.Effect == other.Effect ||
                    this.Effect != null &&
                    this.Effect.Equals(other.Effect)
                ) && 
                (
                    this.Dash == other.Dash ||
                    this.Dash != null &&
                    this.Dash.Equals(other.Dash)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
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
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.EffectIntensity != null)
                    hash = hash * 59 + this.EffectIntensity.GetHashCode();
                if (this.Style != null)
                    hash = hash * 59 + this.Style.GetHashCode();
                if (this.Effect != null)
                    hash = hash * 59 + this.Effect.GetHashCode();
                if (this.Dash != null)
                    hash = hash * 59 + this.Dash.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
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
