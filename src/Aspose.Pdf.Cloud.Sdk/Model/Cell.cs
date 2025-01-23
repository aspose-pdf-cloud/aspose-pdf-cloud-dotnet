// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Cell.cs">
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
    /// Represents a cell of the table&#39;s row.
    /// </summary>
    [DataContract]
    public partial class Cell :  IEquatable<Cell>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cell" /> class.
        /// </summary>
        /// <param name="IsNoBorder">Gets or sets the cell have border.</param>
        /// <param name="Margin">Gets or sets the padding.</param>
        /// <param name="Border">Gets or sets the border.</param>
        /// <param name="BackgroundColor">Gets or sets the background color.</param>
        /// <param name="BackgroundImageFile">Gets or sets the background image file.</param>
        /// <param name="BackgroundImageStorageFile">Gets or sets path of the background image file from storage.</param>
        /// <param name="Alignment">Gets or sets the alignment.</param>
        /// <param name="DefaultCellTextState">Gets or sets the default cell text state.</param>
        /// <param name="Paragraphs">Gets or sets the cell&#39;s formatted text.</param>
        /// <param name="IsWordWrapped">Gets or sets the cell&#39;s text word wrapped.</param>
        /// <param name="VerticalAlignment">Gets or sets the vertical alignment.</param>
        /// <param name="ColSpan">Gets or sets the column span.</param>
        /// <param name="RowSpan">Gets or sets the row span.</param>
        /// <param name="Width">Gets or sets the column width.</param>
        /// <param name="HtmlFragment">Gets or sets Html fragment.</param>
        /// <param name="Images">Gets or sets ImageFragment list.</param>
        public Cell(bool? IsNoBorder = default(bool?), MarginInfo Margin = default(MarginInfo), BorderInfo Border = default(BorderInfo), Color BackgroundColor = default(Color), string BackgroundImageFile = default(string), string BackgroundImageStorageFile = default(string), HorizontalAlignment Alignment = default(HorizontalAlignment), TextState DefaultCellTextState = default(TextState), List<TextRect> Paragraphs = default(List<TextRect>), bool? IsWordWrapped = default(bool?), VerticalAlignment VerticalAlignment = default(VerticalAlignment), int? ColSpan = default(int?), int? RowSpan = default(int?), double? Width = default(double?), string HtmlFragment = default(string), List<ImageFragment> Images = default(List<ImageFragment>))
        {
            this.IsNoBorder = IsNoBorder;
            this.Margin = Margin;
            this.Border = Border;
            this.BackgroundColor = BackgroundColor;
            this.BackgroundImageFile = BackgroundImageFile;
            this.BackgroundImageStorageFile = BackgroundImageStorageFile;
            this.Alignment = Alignment;
            this.DefaultCellTextState = DefaultCellTextState;
            this.Paragraphs = Paragraphs;
            this.IsWordWrapped = IsWordWrapped;
            this.VerticalAlignment = VerticalAlignment;
            this.ColSpan = ColSpan;
            this.RowSpan = RowSpan;
            this.Width = Width;
            this.HtmlFragment = HtmlFragment;
            this.Images = Images;
        }
        
        /// <summary>
        /// Gets or sets the cell have border.
        /// </summary>
        /// <value>Gets or sets the cell have border.</value>
        [DataMember(Name="IsNoBorder", EmitDefaultValue=false)]
        public bool? IsNoBorder { get; set; }

        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        /// <value>Gets or sets the padding.</value>
        [DataMember(Name="Margin", EmitDefaultValue=false)]
        public MarginInfo Margin { get; set; }

        /// <summary>
        /// Gets or sets the border.
        /// </summary>
        /// <value>Gets or sets the border.</value>
        [DataMember(Name="Border", EmitDefaultValue=false)]
        public BorderInfo Border { get; set; }

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        /// <value>Gets or sets the background color.</value>
        [DataMember(Name="BackgroundColor", EmitDefaultValue=false)]
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the background image file.
        /// </summary>
        /// <value>Gets or sets the background image file.</value>
        [DataMember(Name="BackgroundImageFile", EmitDefaultValue=false)]
        public string BackgroundImageFile { get; set; }

        /// <summary>
        /// Gets or sets path of the background image file from storage.
        /// </summary>
        /// <value>Gets or sets path of the background image file from storage.</value>
        [DataMember(Name="BackgroundImageStorageFile", EmitDefaultValue=false)]
        public string BackgroundImageStorageFile { get; set; }

        /// <summary>
        /// Gets or sets the alignment.
        /// </summary>
        /// <value>Gets or sets the alignment.</value>
        [DataMember(Name="Alignment", EmitDefaultValue=true)]
        public HorizontalAlignment Alignment { get; set; }

        /// <summary>
        /// Gets or sets the default cell text state.
        /// </summary>
        /// <value>Gets or sets the default cell text state.</value>
        [DataMember(Name="DefaultCellTextState", EmitDefaultValue=false)]
        public TextState DefaultCellTextState { get; set; }

        /// <summary>
        /// Gets or sets the cell&#39;s formatted text.
        /// </summary>
        /// <value>Gets or sets the cell&#39;s formatted text.</value>
        [DataMember(Name="Paragraphs", EmitDefaultValue=false)]
        public List<TextRect> Paragraphs { get; set; }

        /// <summary>
        /// Gets or sets the cell&#39;s text word wrapped.
        /// </summary>
        /// <value>Gets or sets the cell&#39;s text word wrapped.</value>
        [DataMember(Name="IsWordWrapped", EmitDefaultValue=false)]
        public bool? IsWordWrapped { get; set; }

        /// <summary>
        /// Gets or sets the vertical alignment.
        /// </summary>
        /// <value>Gets or sets the vertical alignment.</value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=true)]
        public VerticalAlignment VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets the column span.
        /// </summary>
        /// <value>Gets or sets the column span.</value>
        [DataMember(Name="ColSpan", EmitDefaultValue=false)]
        public int? ColSpan { get; set; }

        /// <summary>
        /// Gets or sets the row span.
        /// </summary>
        /// <value>Gets or sets the row span.</value>
        [DataMember(Name="RowSpan", EmitDefaultValue=false)]
        public int? RowSpan { get; set; }

        /// <summary>
        /// Gets or sets the column width.
        /// </summary>
        /// <value>Gets or sets the column width.</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public double? Width { get; set; }

        /// <summary>
        /// Gets or sets Html fragment.
        /// </summary>
        /// <value>Gets or sets Html fragment.</value>
        [DataMember(Name="HtmlFragment", EmitDefaultValue=false)]
        public string HtmlFragment { get; set; }

        /// <summary>
        /// Gets or sets ImageFragment list.
        /// </summary>
        /// <value>Gets or sets ImageFragment list.</value>
        [DataMember(Name="Images", EmitDefaultValue=false)]
        public List<ImageFragment> Images { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cell {\n");
            sb.Append("  IsNoBorder: ").Append(IsNoBorder).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
            sb.Append("  Border: ").Append(Border).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  BackgroundImageFile: ").Append(BackgroundImageFile).Append("\n");
            sb.Append("  BackgroundImageStorageFile: ").Append(BackgroundImageStorageFile).Append("\n");
            sb.Append("  Alignment: ").Append(Alignment).Append("\n");
            sb.Append("  DefaultCellTextState: ").Append(DefaultCellTextState).Append("\n");
            sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
            sb.Append("  IsWordWrapped: ").Append(IsWordWrapped).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  ColSpan: ").Append(ColSpan).Append("\n");
            sb.Append("  RowSpan: ").Append(RowSpan).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  HtmlFragment: ").Append(HtmlFragment).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
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
            return this.Equals(obj as Cell);
        }

        /// <summary>
        /// Returns true if Cell instances are equal
        /// </summary>
        /// <param name="other">Instance of Cell to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cell other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsNoBorder == other.IsNoBorder ||
                    this.IsNoBorder != null &&
                    this.IsNoBorder.Equals(other.IsNoBorder)
                ) && 
                (
                    this.Margin == other.Margin ||
                    this.Margin != null &&
                    this.Margin.Equals(other.Margin)
                ) && 
                (
                    this.Border == other.Border ||
                    this.Border != null &&
                    this.Border.Equals(other.Border)
                ) && 
                (
                    this.BackgroundColor == other.BackgroundColor ||
                    this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(other.BackgroundColor)
                ) && 
                (
                    this.BackgroundImageFile == other.BackgroundImageFile ||
                    this.BackgroundImageFile != null &&
                    this.BackgroundImageFile.Equals(other.BackgroundImageFile)
                ) && 
                (
                    this.BackgroundImageStorageFile == other.BackgroundImageStorageFile ||
                    this.BackgroundImageStorageFile != null &&
                    this.BackgroundImageStorageFile.Equals(other.BackgroundImageStorageFile)
                ) && 
                (
                    this.Alignment == other.Alignment ||
                    this.Alignment != null &&
                    this.Alignment.Equals(other.Alignment)
                ) && 
                (
                    this.DefaultCellTextState == other.DefaultCellTextState ||
                    this.DefaultCellTextState != null &&
                    this.DefaultCellTextState.Equals(other.DefaultCellTextState)
                ) && 
                (
                    this.Paragraphs == other.Paragraphs ||
                    this.Paragraphs != null &&
                    this.Paragraphs.SequenceEqual(other.Paragraphs)
                ) && 
                (
                    this.IsWordWrapped == other.IsWordWrapped ||
                    this.IsWordWrapped != null &&
                    this.IsWordWrapped.Equals(other.IsWordWrapped)
                ) && 
                (
                    this.VerticalAlignment == other.VerticalAlignment ||
                    this.VerticalAlignment != null &&
                    this.VerticalAlignment.Equals(other.VerticalAlignment)
                ) && 
                (
                    this.ColSpan == other.ColSpan ||
                    this.ColSpan != null &&
                    this.ColSpan.Equals(other.ColSpan)
                ) && 
                (
                    this.RowSpan == other.RowSpan ||
                    this.RowSpan != null &&
                    this.RowSpan.Equals(other.RowSpan)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.HtmlFragment == other.HtmlFragment ||
                    this.HtmlFragment != null &&
                    this.HtmlFragment.Equals(other.HtmlFragment)
                ) && 
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(other.Images)
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
                if (this.IsNoBorder != null)
                    hash = hash * 59 + this.IsNoBorder.GetHashCode();
                if (this.Margin != null)
                    hash = hash * 59 + this.Margin.GetHashCode();
                if (this.Border != null)
                    hash = hash * 59 + this.Border.GetHashCode();
                if (this.BackgroundColor != null)
                    hash = hash * 59 + this.BackgroundColor.GetHashCode();
                if (this.BackgroundImageFile != null)
                    hash = hash * 59 + this.BackgroundImageFile.GetHashCode();
                if (this.BackgroundImageStorageFile != null)
                    hash = hash * 59 + this.BackgroundImageStorageFile.GetHashCode();
                if (this.Alignment != null)
                    hash = hash * 59 + this.Alignment.GetHashCode();
                if (this.DefaultCellTextState != null)
                    hash = hash * 59 + this.DefaultCellTextState.GetHashCode();
                if (this.Paragraphs != null)
                    hash = hash * 59 + this.Paragraphs.GetHashCode();
                if (this.IsWordWrapped != null)
                    hash = hash * 59 + this.IsWordWrapped.GetHashCode();
                if (this.VerticalAlignment != null)
                    hash = hash * 59 + this.VerticalAlignment.GetHashCode();
                if (this.ColSpan != null)
                    hash = hash * 59 + this.ColSpan.GetHashCode();
                if (this.RowSpan != null)
                    hash = hash * 59 + this.RowSpan.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.HtmlFragment != null)
                    hash = hash * 59 + this.HtmlFragment.GetHashCode();
                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();
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
