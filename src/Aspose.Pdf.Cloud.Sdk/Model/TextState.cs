// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextState.cs">
//   Copyright (c) 2025 Aspose.PDF Cloud
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
    /// Represents a text state of a text
    /// </summary>
    [DataContract]
    public partial class TextState :  IEquatable<TextState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextState() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextState" /> class.
        /// </summary>
        /// <param name="FontSize">Gets or sets font size of the text. (required)</param>
        /// <param name="Font">Gets or sets font name of the text.</param>
        /// <param name="ForegroundColor">Gets or sets foreground color of the text.</param>
        /// <param name="BackgroundColor">Sets background color of the text.</param>
        /// <param name="FontStyle">Sets font style of the text. (required)</param>
        /// <param name="FontFile">Sets path of font file in storage.</param>
        /// <param name="Underline">Gets or sets underline of the text.</param>
        /// <param name="StrikeOut">Gets or sets strikeout of the text.</param>
        /// <param name="Superscript">Gets or sets superscript mode of the text.</param>
        /// <param name="Subscript">Gets or sets subscript mode of the text.</param>
        public TextState(double? FontSize = default(double?), string Font = default(string), Color ForegroundColor = default(Color), Color BackgroundColor = default(Color), FontStyles FontStyle = default(FontStyles), string FontFile = default(string), bool? Underline = default(bool?), bool? StrikeOut = default(bool?), bool? Superscript = default(bool?), bool? Subscript = default(bool?))
        {
            // to ensure "FontSize" is required (not null)
            if (FontSize == null)
            {
                throw new InvalidDataException("FontSize is a required property for TextState and cannot be null");
            }
            else
            {
                this.FontSize = FontSize;
            }
            // to ensure "FontStyle" is required (not null)
            if (FontStyle == null)
            {
                throw new InvalidDataException("FontStyle is a required property for TextState and cannot be null");
            }
            else
            {
                this.FontStyle = FontStyle;
            }
            this.Font = Font;
            this.ForegroundColor = ForegroundColor;
            this.BackgroundColor = BackgroundColor;
            this.FontFile = FontFile;
            this.Underline = Underline;
            this.StrikeOut = StrikeOut;
            this.Superscript = Superscript;
            this.Subscript = Subscript;
        }
        
        /// <summary>
        /// Gets or sets font size of the text.
        /// </summary>
        /// <value>Gets or sets font size of the text.</value>
        [DataMember(Name="FontSize", EmitDefaultValue=false)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Gets or sets font name of the text.
        /// </summary>
        /// <value>Gets or sets font name of the text.</value>
        [DataMember(Name="Font", EmitDefaultValue=false)]
        public string Font { get; set; }

        /// <summary>
        /// Gets or sets foreground color of the text.
        /// </summary>
        /// <value>Gets or sets foreground color of the text.</value>
        [DataMember(Name="ForegroundColor", EmitDefaultValue=false)]
        public Color ForegroundColor { get; set; }

        /// <summary>
        /// Sets background color of the text.
        /// </summary>
        /// <value>Sets background color of the text.</value>
        [DataMember(Name="BackgroundColor", EmitDefaultValue=false)]
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Sets font style of the text.
        /// </summary>
        /// <value>Sets font style of the text.</value>
        [DataMember(Name="FontStyle", EmitDefaultValue=true)]
        public FontStyles FontStyle { get; set; }

        /// <summary>
        /// Sets path of font file in storage.
        /// </summary>
        /// <value>Sets path of font file in storage.</value>
        [DataMember(Name="FontFile", EmitDefaultValue=false)]
        public string FontFile { get; set; }

        /// <summary>
        /// Gets or sets underline of the text.
        /// </summary>
        /// <value>Gets or sets underline of the text.</value>
        [DataMember(Name="Underline", EmitDefaultValue=false)]
        public bool? Underline { get; set; }

        /// <summary>
        /// Gets or sets strikeout of the text.
        /// </summary>
        /// <value>Gets or sets strikeout of the text.</value>
        [DataMember(Name="StrikeOut", EmitDefaultValue=false)]
        public bool? StrikeOut { get; set; }

        /// <summary>
        /// Gets or sets superscript mode of the text.
        /// </summary>
        /// <value>Gets or sets superscript mode of the text.</value>
        [DataMember(Name="Superscript", EmitDefaultValue=false)]
        public bool? Superscript { get; set; }

        /// <summary>
        /// Gets or sets subscript mode of the text.
        /// </summary>
        /// <value>Gets or sets subscript mode of the text.</value>
        [DataMember(Name="Subscript", EmitDefaultValue=false)]
        public bool? Subscript { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextState {\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("  ForegroundColor: ").Append(ForegroundColor).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  FontStyle: ").Append(FontStyle).Append("\n");
            sb.Append("  FontFile: ").Append(FontFile).Append("\n");
            sb.Append("  Underline: ").Append(Underline).Append("\n");
            sb.Append("  StrikeOut: ").Append(StrikeOut).Append("\n");
            sb.Append("  Superscript: ").Append(Superscript).Append("\n");
            sb.Append("  Subscript: ").Append(Subscript).Append("\n");
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
            return this.Equals(obj as TextState);
        }

        /// <summary>
        /// Returns true if TextState instances are equal
        /// </summary>
        /// <param name="other">Instance of TextState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FontSize == other.FontSize ||
                    this.FontSize != null &&
                    this.FontSize.Equals(other.FontSize)
                ) && 
                (
                    this.Font == other.Font ||
                    this.Font != null &&
                    this.Font.Equals(other.Font)
                ) && 
                (
                    this.ForegroundColor == other.ForegroundColor ||
                    this.ForegroundColor != null &&
                    this.ForegroundColor.Equals(other.ForegroundColor)
                ) && 
                (
                    this.BackgroundColor == other.BackgroundColor ||
                    this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(other.BackgroundColor)
                ) && 
                (
                    this.FontStyle == other.FontStyle ||
                    this.FontStyle != null &&
                    this.FontStyle.Equals(other.FontStyle)
                ) && 
                (
                    this.FontFile == other.FontFile ||
                    this.FontFile != null &&
                    this.FontFile.Equals(other.FontFile)
                ) && 
                (
                    this.Underline == other.Underline ||
                    this.Underline != null &&
                    this.Underline.Equals(other.Underline)
                ) && 
                (
                    this.StrikeOut == other.StrikeOut ||
                    this.StrikeOut != null &&
                    this.StrikeOut.Equals(other.StrikeOut)
                ) && 
                (
                    this.Superscript == other.Superscript ||
                    this.Superscript != null &&
                    this.Superscript.Equals(other.Superscript)
                ) && 
                (
                    this.Subscript == other.Subscript ||
                    this.Subscript != null &&
                    this.Subscript.Equals(other.Subscript)
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
                if (this.FontSize != null)
                    hash = hash * 59 + this.FontSize.GetHashCode();
                if (this.Font != null)
                    hash = hash * 59 + this.Font.GetHashCode();
                if (this.ForegroundColor != null)
                    hash = hash * 59 + this.ForegroundColor.GetHashCode();
                if (this.BackgroundColor != null)
                    hash = hash * 59 + this.BackgroundColor.GetHashCode();
                if (this.FontStyle != null)
                    hash = hash * 59 + this.FontStyle.GetHashCode();
                if (this.FontFile != null)
                    hash = hash * 59 + this.FontFile.GetHashCode();
                if (this.Underline != null)
                    hash = hash * 59 + this.Underline.GetHashCode();
                if (this.StrikeOut != null)
                    hash = hash * 59 + this.StrikeOut.GetHashCode();
                if (this.Superscript != null)
                    hash = hash * 59 + this.Superscript.GetHashCode();
                if (this.Subscript != null)
                    hash = hash * 59 + this.Subscript.GetHashCode();
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
