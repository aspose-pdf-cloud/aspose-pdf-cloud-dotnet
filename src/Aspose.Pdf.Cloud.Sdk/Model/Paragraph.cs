// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Paragraph.cs">
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
    /// Represents text paragraphs as multiline text object.
    /// </summary>
    [DataContract]
    public partial class Paragraph :  IEquatable<Paragraph>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Paragraph" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Paragraph() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Paragraph" /> class.
        /// </summary>
        /// <param name="LineSpacing">Line spacing mode.</param>
        /// <param name="WrapMode">Word wrap mode.</param>
        /// <param name="HorizontalAlignment">Horizontal alignment for the text inside paragraph&#39;s rectangle.</param>
        /// <param name="LeftMargin">Left margin.</param>
        /// <param name="RightMargin">Right margin.</param>
        /// <param name="TopMargin">Top margin.</param>
        /// <param name="BottomMargin">Bottom margin.</param>
        /// <param name="Rectangle">Rectangle of the paragraph.</param>
        /// <param name="Rotation">Rotation angle in degrees.</param>
        /// <param name="SubsequentLinesIndent">Subsequent lines indent value.</param>
        /// <param name="VerticalAlignment">Vertical alignment for the text inside paragraph&#39;s rectangle</param>
        /// <param name="Lines">An array of text lines. (required)</param>
        public Paragraph(LineSpacing LineSpacing = default(LineSpacing), WrapMode WrapMode = default(WrapMode), TextHorizontalAlignment HorizontalAlignment = default(TextHorizontalAlignment), double? LeftMargin = default(double?), double? RightMargin = default(double?), double? TopMargin = default(double?), double? BottomMargin = default(double?), Rectangle Rectangle = default(Rectangle), double? Rotation = default(double?), double? SubsequentLinesIndent = default(double?), VerticalAlignment VerticalAlignment = default(VerticalAlignment), List<TextLine> Lines = default(List<TextLine>))
        {
            // to ensure "Lines" is required (not null)
            if (Lines == null)
            {
                throw new InvalidDataException("Lines is a required property for Paragraph and cannot be null");
            }
            else
            {
                this.Lines = Lines;
            }
            this.LineSpacing = LineSpacing;
            this.WrapMode = WrapMode;
            this.HorizontalAlignment = HorizontalAlignment;
            this.LeftMargin = LeftMargin;
            this.RightMargin = RightMargin;
            this.TopMargin = TopMargin;
            this.BottomMargin = BottomMargin;
            this.Rectangle = Rectangle;
            this.Rotation = Rotation;
            this.SubsequentLinesIndent = SubsequentLinesIndent;
            this.VerticalAlignment = VerticalAlignment;
        }
        
        /// <summary>
        /// Line spacing mode.
        /// </summary>
        /// <value>Line spacing mode.</value>
        [DataMember(Name="LineSpacing", EmitDefaultValue=true)]
        public LineSpacing LineSpacing { get; set; }

        /// <summary>
        /// Word wrap mode.
        /// </summary>
        /// <value>Word wrap mode.</value>
        [DataMember(Name="WrapMode", EmitDefaultValue=true)]
        public WrapMode WrapMode { get; set; }

        /// <summary>
        /// Horizontal alignment for the text inside paragraph&#39;s rectangle.
        /// </summary>
        /// <value>Horizontal alignment for the text inside paragraph&#39;s rectangle.</value>
        [DataMember(Name="HorizontalAlignment", EmitDefaultValue=true)]
        public TextHorizontalAlignment HorizontalAlignment { get; set; }

        /// <summary>
        /// Left margin.
        /// </summary>
        /// <value>Left margin.</value>
        [DataMember(Name="LeftMargin", EmitDefaultValue=false)]
        public double? LeftMargin { get; set; }

        /// <summary>
        /// Right margin.
        /// </summary>
        /// <value>Right margin.</value>
        [DataMember(Name="RightMargin", EmitDefaultValue=false)]
        public double? RightMargin { get; set; }

        /// <summary>
        /// Top margin.
        /// </summary>
        /// <value>Top margin.</value>
        [DataMember(Name="TopMargin", EmitDefaultValue=false)]
        public double? TopMargin { get; set; }

        /// <summary>
        /// Bottom margin.
        /// </summary>
        /// <value>Bottom margin.</value>
        [DataMember(Name="BottomMargin", EmitDefaultValue=false)]
        public double? BottomMargin { get; set; }

        /// <summary>
        /// Rectangle of the paragraph.
        /// </summary>
        /// <value>Rectangle of the paragraph.</value>
        [DataMember(Name="Rectangle", EmitDefaultValue=false)]
        public Rectangle Rectangle { get; set; }

        /// <summary>
        /// Rotation angle in degrees.
        /// </summary>
        /// <value>Rotation angle in degrees.</value>
        [DataMember(Name="Rotation", EmitDefaultValue=false)]
        public double? Rotation { get; set; }

        /// <summary>
        /// Subsequent lines indent value.
        /// </summary>
        /// <value>Subsequent lines indent value.</value>
        [DataMember(Name="SubsequentLinesIndent", EmitDefaultValue=false)]
        public double? SubsequentLinesIndent { get; set; }

        /// <summary>
        /// Vertical alignment for the text inside paragraph&#39;s rectangle
        /// </summary>
        /// <value>Vertical alignment for the text inside paragraph&#39;s rectangle</value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=true)]
        public VerticalAlignment VerticalAlignment { get; set; }

        /// <summary>
        /// An array of text lines.
        /// </summary>
        /// <value>An array of text lines.</value>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public List<TextLine> Lines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Paragraph {\n");
            sb.Append("  LineSpacing: ").Append(LineSpacing).Append("\n");
            sb.Append("  WrapMode: ").Append(WrapMode).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(HorizontalAlignment).Append("\n");
            sb.Append("  LeftMargin: ").Append(LeftMargin).Append("\n");
            sb.Append("  RightMargin: ").Append(RightMargin).Append("\n");
            sb.Append("  TopMargin: ").Append(TopMargin).Append("\n");
            sb.Append("  BottomMargin: ").Append(BottomMargin).Append("\n");
            sb.Append("  Rectangle: ").Append(Rectangle).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  SubsequentLinesIndent: ").Append(SubsequentLinesIndent).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
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
            return this.Equals(obj as Paragraph);
        }

        /// <summary>
        /// Returns true if Paragraph instances are equal
        /// </summary>
        /// <param name="other">Instance of Paragraph to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Paragraph other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LineSpacing == other.LineSpacing ||
                    this.LineSpacing != null &&
                    this.LineSpacing.Equals(other.LineSpacing)
                ) && 
                (
                    this.WrapMode == other.WrapMode ||
                    this.WrapMode != null &&
                    this.WrapMode.Equals(other.WrapMode)
                ) && 
                (
                    this.HorizontalAlignment == other.HorizontalAlignment ||
                    this.HorizontalAlignment != null &&
                    this.HorizontalAlignment.Equals(other.HorizontalAlignment)
                ) && 
                (
                    this.LeftMargin == other.LeftMargin ||
                    this.LeftMargin != null &&
                    this.LeftMargin.Equals(other.LeftMargin)
                ) && 
                (
                    this.RightMargin == other.RightMargin ||
                    this.RightMargin != null &&
                    this.RightMargin.Equals(other.RightMargin)
                ) && 
                (
                    this.TopMargin == other.TopMargin ||
                    this.TopMargin != null &&
                    this.TopMargin.Equals(other.TopMargin)
                ) && 
                (
                    this.BottomMargin == other.BottomMargin ||
                    this.BottomMargin != null &&
                    this.BottomMargin.Equals(other.BottomMargin)
                ) && 
                (
                    this.Rectangle == other.Rectangle ||
                    this.Rectangle != null &&
                    this.Rectangle.Equals(other.Rectangle)
                ) && 
                (
                    this.Rotation == other.Rotation ||
                    this.Rotation != null &&
                    this.Rotation.Equals(other.Rotation)
                ) && 
                (
                    this.SubsequentLinesIndent == other.SubsequentLinesIndent ||
                    this.SubsequentLinesIndent != null &&
                    this.SubsequentLinesIndent.Equals(other.SubsequentLinesIndent)
                ) && 
                (
                    this.VerticalAlignment == other.VerticalAlignment ||
                    this.VerticalAlignment != null &&
                    this.VerticalAlignment.Equals(other.VerticalAlignment)
                ) && 
                (
                    this.Lines == other.Lines ||
                    this.Lines != null &&
                    this.Lines.SequenceEqual(other.Lines)
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
                if (this.LineSpacing != null)
                    hash = hash * 59 + this.LineSpacing.GetHashCode();
                if (this.WrapMode != null)
                    hash = hash * 59 + this.WrapMode.GetHashCode();
                if (this.HorizontalAlignment != null)
                    hash = hash * 59 + this.HorizontalAlignment.GetHashCode();
                if (this.LeftMargin != null)
                    hash = hash * 59 + this.LeftMargin.GetHashCode();
                if (this.RightMargin != null)
                    hash = hash * 59 + this.RightMargin.GetHashCode();
                if (this.TopMargin != null)
                    hash = hash * 59 + this.TopMargin.GetHashCode();
                if (this.BottomMargin != null)
                    hash = hash * 59 + this.BottomMargin.GetHashCode();
                if (this.Rectangle != null)
                    hash = hash * 59 + this.Rectangle.GetHashCode();
                if (this.Rotation != null)
                    hash = hash * 59 + this.Rotation.GetHashCode();
                if (this.SubsequentLinesIndent != null)
                    hash = hash * 59 + this.SubsequentLinesIndent.GetHashCode();
                if (this.VerticalAlignment != null)
                    hash = hash * 59 + this.VerticalAlignment.GetHashCode();
                if (this.Lines != null)
                    hash = hash * 59 + this.Lines.GetHashCode();
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
