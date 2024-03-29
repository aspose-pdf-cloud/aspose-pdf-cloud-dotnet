﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextStyle.cs">
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
    /// Represents a text style of a text
    /// </summary>
    [DataContract]
    public partial class TextStyle :  IEquatable<TextStyle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextStyle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextStyle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextStyle" /> class.
        /// </summary>
        /// <param name="FontSize">Gets or sets font size of the text. (required)</param>
        /// <param name="Font">Gets or sets font of the text.</param>
        /// <param name="ForegroundColor">Gets or sets foreground color of the text.</param>
        /// <param name="BackgroundColor">Sets background color of the text.</param>
        /// <param name="FontFile">Sets path of font file in storage.</param>
        public TextStyle(double? FontSize = default(double?), string Font = default(string), Color ForegroundColor = default(Color), Color BackgroundColor = default(Color), string FontFile = default(string))
        {
            // to ensure "FontSize" is required (not null)
            if (FontSize == null)
            {
                throw new InvalidDataException("FontSize is a required property for TextStyle and cannot be null");
            }
            else
            {
                this.FontSize = FontSize;
            }
            this.Font = Font;
            this.ForegroundColor = ForegroundColor;
            this.BackgroundColor = BackgroundColor;
            this.FontFile = FontFile;
        }
        
        /// <summary>
        /// Gets or sets font size of the text.
        /// </summary>
        /// <value>Gets or sets font size of the text.</value>
        [DataMember(Name="FontSize", EmitDefaultValue=false)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Gets or sets font of the text.
        /// </summary>
        /// <value>Gets or sets font of the text.</value>
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
        /// Sets path of font file in storage.
        /// </summary>
        /// <value>Sets path of font file in storage.</value>
        [DataMember(Name="FontFile", EmitDefaultValue=false)]
        public string FontFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextStyle {\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("  ForegroundColor: ").Append(ForegroundColor).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  FontFile: ").Append(FontFile).Append("\n");
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
            return this.Equals(obj as TextStyle);
        }

        /// <summary>
        /// Returns true if TextStyle instances are equal
        /// </summary>
        /// <param name="other">Instance of TextStyle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextStyle other)
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
                    this.FontFile == other.FontFile ||
                    this.FontFile != null &&
                    this.FontFile.Equals(other.FontFile)
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
                if (this.FontFile != null)
                    hash = hash * 59 + this.FontFile.GetHashCode();
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
