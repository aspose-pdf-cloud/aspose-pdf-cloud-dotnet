// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextRect.cs">
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
    /// Represents text occurrence.
    /// </summary>
    [DataContract]
    public partial class TextRect :  IEquatable<TextRect>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextRect" /> class.
        /// </summary>
        /// <param name="Text">Text of the occurrence.</param>
        /// <param name="Page">Page on which the occurrence is found.</param>
        /// <param name="Rect">Rectangle of the occurrence.</param>
        /// <param name="HorizontalAlignment">Gets or sets a horizontal alignment of text fragment. </param>
        /// <param name="VerticalAlignment">Gets or sets a vertical alignment of text fragment. </param>
        /// <param name="Position">Gets or sets text position for text, represented with TextRect object.</param>
        /// <param name="BaselinePosition">Gets text position for text, represented with TextRect object. The YIndent of the Position structure represents baseline coordinate of the text fragment.</param>
        /// <param name="TextState">Gets or sets text state for the text that TextRect object represents.</param>
        public TextRect(string Text = default(string), int? Page = default(int?), Rectangle Rect = default(Rectangle), HorizontalAlignment HorizontalAlignment = default(HorizontalAlignment), VerticalAlignment VerticalAlignment = default(VerticalAlignment), Position Position = default(Position), Position BaselinePosition = default(Position), TextState TextState = default(TextState))
        {
            this.Text = Text;
            this.Page = Page;
            this.Rect = Rect;
            this.HorizontalAlignment = HorizontalAlignment;
            this.VerticalAlignment = VerticalAlignment;
            this.Position = Position;
            this.BaselinePosition = BaselinePosition;
            this.TextState = TextState;
        }
        
        /// <summary>
        /// Text of the occurrence.
        /// </summary>
        /// <value>Text of the occurrence.</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Page on which the occurrence is found.
        /// </summary>
        /// <value>Page on which the occurrence is found.</value>
        [DataMember(Name="Page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// Rectangle of the occurrence.
        /// </summary>
        /// <value>Rectangle of the occurrence.</value>
        [DataMember(Name="Rect", EmitDefaultValue=false)]
        public Rectangle Rect { get; set; }

        /// <summary>
        /// Gets or sets a horizontal alignment of text fragment. 
        /// </summary>
        /// <value>Gets or sets a horizontal alignment of text fragment. </value>
        [DataMember(Name="HorizontalAlignment", EmitDefaultValue=true)]
        public HorizontalAlignment HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets a vertical alignment of text fragment. 
        /// </summary>
        /// <value>Gets or sets a vertical alignment of text fragment. </value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=true)]
        public VerticalAlignment VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets text position for text, represented with TextRect object.
        /// </summary>
        /// <value>Gets or sets text position for text, represented with TextRect object.</value>
        [DataMember(Name="Position", EmitDefaultValue=false)]
        public Position Position { get; set; }

        /// <summary>
        /// Gets text position for text, represented with TextRect object. The YIndent of the Position structure represents baseline coordinate of the text fragment.
        /// </summary>
        /// <value>Gets text position for text, represented with TextRect object. The YIndent of the Position structure represents baseline coordinate of the text fragment.</value>
        [DataMember(Name="BaselinePosition", EmitDefaultValue=false)]
        public Position BaselinePosition { get; set; }

        /// <summary>
        /// Gets or sets text state for the text that TextRect object represents.
        /// </summary>
        /// <value>Gets or sets text state for the text that TextRect object represents.</value>
        [DataMember(Name="TextState", EmitDefaultValue=false)]
        public TextState TextState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextRect {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Rect: ").Append(Rect).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(HorizontalAlignment).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  BaselinePosition: ").Append(BaselinePosition).Append("\n");
            sb.Append("  TextState: ").Append(TextState).Append("\n");
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
            return this.Equals(obj as TextRect);
        }

        /// <summary>
        /// Returns true if TextRect instances are equal
        /// </summary>
        /// <param name="other">Instance of TextRect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextRect other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.Rect == other.Rect ||
                    this.Rect != null &&
                    this.Rect.Equals(other.Rect)
                ) && 
                (
                    this.HorizontalAlignment == other.HorizontalAlignment ||
                    this.HorizontalAlignment != null &&
                    this.HorizontalAlignment.Equals(other.HorizontalAlignment)
                ) && 
                (
                    this.VerticalAlignment == other.VerticalAlignment ||
                    this.VerticalAlignment != null &&
                    this.VerticalAlignment.Equals(other.VerticalAlignment)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.BaselinePosition == other.BaselinePosition ||
                    this.BaselinePosition != null &&
                    this.BaselinePosition.Equals(other.BaselinePosition)
                ) && 
                (
                    this.TextState == other.TextState ||
                    this.TextState != null &&
                    this.TextState.Equals(other.TextState)
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
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.Rect != null)
                    hash = hash * 59 + this.Rect.GetHashCode();
                if (this.HorizontalAlignment != null)
                    hash = hash * 59 + this.HorizontalAlignment.GetHashCode();
                if (this.VerticalAlignment != null)
                    hash = hash * 59 + this.VerticalAlignment.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.BaselinePosition != null)
                    hash = hash * 59 + this.BaselinePosition.GetHashCode();
                if (this.TextState != null)
                    hash = hash * 59 + this.TextState.GetHashCode();
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
