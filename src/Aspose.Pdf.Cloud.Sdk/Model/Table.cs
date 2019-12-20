// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Table.cs">
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
    /// Represents a table that can be added to the page.
    /// </summary>
    [DataContract]
    public partial class Table : LinkElement,  IEquatable<Table>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Table() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="Alignment">Gets HorizontalAlignment of the table alignment.</param>
        /// <param name="HorizontalAlignment">Gets HorizontalAlignment of the table alignment.</param>
        /// <param name="VerticalAlignment">Gets VerticalAlignment of the annotation.</param>
        /// <param name="Top">Gets or sets the table top coordinate.</param>
        /// <param name="Left">Gets or sets the table left coordinate.</param>
        /// <param name="DefaultCellTextState">Gets or sets the default cell text state.</param>
        /// <param name="DefaultCellPadding">Gets or sets the default cell padding.</param>
        /// <param name="Border">Gets or sets the border.</param>
        /// <param name="Margin">Gets or sets a outer margin for paragraph (for pdf generation)</param>
        /// <param name="Rows">Sets the rows of the table. (required)</param>
        /// <param name="DefaultColumnWidth">Gets default cell border;</param>
        /// <param name="DefaultCellBorder">Gets default cell border;</param>
        /// <param name="Broken">Gets or sets table vertial broken;</param>
        /// <param name="ColumnWidths">Gets the column widths of the table.</param>
        /// <param name="RepeatingRowsCount">Gets the first rows count repeated for several pages</param>
        /// <param name="RepeatingColumnsCount">Gets or sets the maximum columns count for table</param>
        /// <param name="RepeatingRowsStyle">Gets the style for repeating rows</param>
        /// <param name="CornerStyle">Gets or sets the styles of the border corners</param>
        /// <param name="BreakText">Gets or sets break text for table</param>
        /// <param name="BackgroundColor">Gets or sets table background color</param>
        /// <param name="IsBordersIncluded">Gets or sets border included in column widhts.</param>
        /// <param name="ColumnAdjustment">Gets or sets the table column adjustment.</param>
        /// <param name="ZIndex">Gets ZIndex of the annotation.</param>
        public Table(List<Link> Links = default(List<Link>), HorizontalAlignment Alignment = default(HorizontalAlignment), HorizontalAlignment HorizontalAlignment = default(HorizontalAlignment), VerticalAlignment VerticalAlignment = default(VerticalAlignment), double? Top = default(double?), double? Left = default(double?), TextState DefaultCellTextState = default(TextState), MarginInfo DefaultCellPadding = default(MarginInfo), BorderInfo Border = default(BorderInfo), MarginInfo Margin = default(MarginInfo), List<Row> Rows = default(List<Row>), string DefaultColumnWidth = default(string), BorderInfo DefaultCellBorder = default(BorderInfo), TableBroken Broken = default(TableBroken), string ColumnWidths = default(string), int? RepeatingRowsCount = default(int?), int? RepeatingColumnsCount = default(int?), TextState RepeatingRowsStyle = default(TextState), BorderCornerStyle CornerStyle = default(BorderCornerStyle), TextRect BreakText = default(TextRect), Color BackgroundColor = default(Color), bool? IsBordersIncluded = default(bool?), ColumnAdjustment ColumnAdjustment = default(ColumnAdjustment), int? ZIndex = default(int?))
        {
            // to ensure "Rows" is required (not null)
            if (Rows == null)
            {
                throw new InvalidDataException("Rows is a required property for Table and cannot be null");
            }
            else
            {
                this.Rows = Rows;
            }
            this.Links = Links;
            this.Alignment = Alignment;
            this.HorizontalAlignment = HorizontalAlignment;
            this.VerticalAlignment = VerticalAlignment;
            this.Top = Top;
            this.Left = Left;
            this.DefaultCellTextState = DefaultCellTextState;
            this.DefaultCellPadding = DefaultCellPadding;
            this.Border = Border;
            this.Margin = Margin;
            this.DefaultColumnWidth = DefaultColumnWidth;
            this.DefaultCellBorder = DefaultCellBorder;
            this.Broken = Broken;
            this.ColumnWidths = ColumnWidths;
            this.RepeatingRowsCount = RepeatingRowsCount;
            this.RepeatingColumnsCount = RepeatingColumnsCount;
            this.RepeatingRowsStyle = RepeatingRowsStyle;
            this.CornerStyle = CornerStyle;
            this.BreakText = BreakText;
            this.BackgroundColor = BackgroundColor;
            this.IsBordersIncluded = IsBordersIncluded;
            this.ColumnAdjustment = ColumnAdjustment;
            this.ZIndex = ZIndex;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets HorizontalAlignment of the table alignment.
        /// </summary>
        /// <value>Gets HorizontalAlignment of the table alignment.</value>
        [DataMember(Name="Alignment", EmitDefaultValue=true)]
        public HorizontalAlignment Alignment { get; set; }

        /// <summary>
        /// Gets HorizontalAlignment of the table alignment.
        /// </summary>
        /// <value>Gets HorizontalAlignment of the table alignment.</value>
        [DataMember(Name="HorizontalAlignment", EmitDefaultValue=true)]
        public HorizontalAlignment HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets VerticalAlignment of the annotation.
        /// </summary>
        /// <value>Gets VerticalAlignment of the annotation.</value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=true)]
        public VerticalAlignment VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets the table top coordinate.
        /// </summary>
        /// <value>Gets or sets the table top coordinate.</value>
        [DataMember(Name="Top", EmitDefaultValue=false)]
        public double? Top { get; set; }

        /// <summary>
        /// Gets or sets the table left coordinate.
        /// </summary>
        /// <value>Gets or sets the table left coordinate.</value>
        [DataMember(Name="Left", EmitDefaultValue=false)]
        public double? Left { get; set; }

        /// <summary>
        /// Gets or sets the default cell text state.
        /// </summary>
        /// <value>Gets or sets the default cell text state.</value>
        [DataMember(Name="DefaultCellTextState", EmitDefaultValue=false)]
        public TextState DefaultCellTextState { get; set; }

        /// <summary>
        /// Gets or sets the default cell padding.
        /// </summary>
        /// <value>Gets or sets the default cell padding.</value>
        [DataMember(Name="DefaultCellPadding", EmitDefaultValue=false)]
        public MarginInfo DefaultCellPadding { get; set; }

        /// <summary>
        /// Gets or sets the border.
        /// </summary>
        /// <value>Gets or sets the border.</value>
        [DataMember(Name="Border", EmitDefaultValue=false)]
        public BorderInfo Border { get; set; }

        /// <summary>
        /// Gets or sets a outer margin for paragraph (for pdf generation)
        /// </summary>
        /// <value>Gets or sets a outer margin for paragraph (for pdf generation)</value>
        [DataMember(Name="Margin", EmitDefaultValue=false)]
        public MarginInfo Margin { get; set; }

        /// <summary>
        /// Sets the rows of the table.
        /// </summary>
        /// <value>Sets the rows of the table.</value>
        [DataMember(Name="Rows", EmitDefaultValue=false)]
        public List<Row> Rows { get; set; }

        /// <summary>
        /// Gets default cell border;
        /// </summary>
        /// <value>Gets default cell border;</value>
        [DataMember(Name="DefaultColumnWidth", EmitDefaultValue=false)]
        public string DefaultColumnWidth { get; set; }

        /// <summary>
        /// Gets default cell border;
        /// </summary>
        /// <value>Gets default cell border;</value>
        [DataMember(Name="DefaultCellBorder", EmitDefaultValue=false)]
        public BorderInfo DefaultCellBorder { get; set; }

        /// <summary>
        /// Gets or sets table vertial broken;
        /// </summary>
        /// <value>Gets or sets table vertial broken;</value>
        [DataMember(Name="Broken", EmitDefaultValue=true)]
        public TableBroken Broken { get; set; }

        /// <summary>
        /// Gets the column widths of the table.
        /// </summary>
        /// <value>Gets the column widths of the table.</value>
        [DataMember(Name="ColumnWidths", EmitDefaultValue=false)]
        public string ColumnWidths { get; set; }

        /// <summary>
        /// Gets the first rows count repeated for several pages
        /// </summary>
        /// <value>Gets the first rows count repeated for several pages</value>
        [DataMember(Name="RepeatingRowsCount", EmitDefaultValue=false)]
        public int? RepeatingRowsCount { get; set; }

        /// <summary>
        /// Gets or sets the maximum columns count for table
        /// </summary>
        /// <value>Gets or sets the maximum columns count for table</value>
        [DataMember(Name="RepeatingColumnsCount", EmitDefaultValue=false)]
        public int? RepeatingColumnsCount { get; set; }

        /// <summary>
        /// Gets the style for repeating rows
        /// </summary>
        /// <value>Gets the style for repeating rows</value>
        [DataMember(Name="RepeatingRowsStyle", EmitDefaultValue=false)]
        public TextState RepeatingRowsStyle { get; set; }

        /// <summary>
        /// Gets or sets the styles of the border corners
        /// </summary>
        /// <value>Gets or sets the styles of the border corners</value>
        [DataMember(Name="CornerStyle", EmitDefaultValue=true)]
        public BorderCornerStyle CornerStyle { get; set; }

        /// <summary>
        /// Gets or sets break text for table
        /// </summary>
        /// <value>Gets or sets break text for table</value>
        [DataMember(Name="BreakText", EmitDefaultValue=false)]
        public TextRect BreakText { get; set; }

        /// <summary>
        /// Gets or sets table background color
        /// </summary>
        /// <value>Gets or sets table background color</value>
        [DataMember(Name="BackgroundColor", EmitDefaultValue=false)]
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets border included in column widhts.
        /// </summary>
        /// <value>Gets or sets border included in column widhts.</value>
        [DataMember(Name="IsBordersIncluded", EmitDefaultValue=false)]
        public bool? IsBordersIncluded { get; set; }

        /// <summary>
        /// Gets or sets the table column adjustment.
        /// </summary>
        /// <value>Gets or sets the table column adjustment.</value>
        [DataMember(Name="ColumnAdjustment", EmitDefaultValue=true)]
        public ColumnAdjustment ColumnAdjustment { get; set; }

        /// <summary>
        /// Gets ZIndex of the annotation.
        /// </summary>
        /// <value>Gets ZIndex of the annotation.</value>
        [DataMember(Name="ZIndex", EmitDefaultValue=false)]
        public int? ZIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Table {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Alignment: ").Append(Alignment).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(HorizontalAlignment).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  DefaultCellTextState: ").Append(DefaultCellTextState).Append("\n");
            sb.Append("  DefaultCellPadding: ").Append(DefaultCellPadding).Append("\n");
            sb.Append("  Border: ").Append(Border).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  DefaultColumnWidth: ").Append(DefaultColumnWidth).Append("\n");
            sb.Append("  DefaultCellBorder: ").Append(DefaultCellBorder).Append("\n");
            sb.Append("  Broken: ").Append(Broken).Append("\n");
            sb.Append("  ColumnWidths: ").Append(ColumnWidths).Append("\n");
            sb.Append("  RepeatingRowsCount: ").Append(RepeatingRowsCount).Append("\n");
            sb.Append("  RepeatingColumnsCount: ").Append(RepeatingColumnsCount).Append("\n");
            sb.Append("  RepeatingRowsStyle: ").Append(RepeatingRowsStyle).Append("\n");
            sb.Append("  CornerStyle: ").Append(CornerStyle).Append("\n");
            sb.Append("  BreakText: ").Append(BreakText).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  IsBordersIncluded: ").Append(IsBordersIncluded).Append("\n");
            sb.Append("  ColumnAdjustment: ").Append(ColumnAdjustment).Append("\n");
            sb.Append("  ZIndex: ").Append(ZIndex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as Table);
        }

        /// <summary>
        /// Returns true if Table instances are equal
        /// </summary>
        /// <param name="other">Instance of Table to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Table other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(other.Links)
                ) && 
                (
                    this.Alignment == other.Alignment ||
                    this.Alignment != null &&
                    this.Alignment.Equals(other.Alignment)
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
                    this.Top == other.Top ||
                    this.Top != null &&
                    this.Top.Equals(other.Top)
                ) && 
                (
                    this.Left == other.Left ||
                    this.Left != null &&
                    this.Left.Equals(other.Left)
                ) && 
                (
                    this.DefaultCellTextState == other.DefaultCellTextState ||
                    this.DefaultCellTextState != null &&
                    this.DefaultCellTextState.Equals(other.DefaultCellTextState)
                ) && 
                (
                    this.DefaultCellPadding == other.DefaultCellPadding ||
                    this.DefaultCellPadding != null &&
                    this.DefaultCellPadding.Equals(other.DefaultCellPadding)
                ) && 
                (
                    this.Border == other.Border ||
                    this.Border != null &&
                    this.Border.Equals(other.Border)
                ) && 
                (
                    this.Margin == other.Margin ||
                    this.Margin != null &&
                    this.Margin.Equals(other.Margin)
                ) && 
                (
                    this.Rows == other.Rows ||
                    this.Rows != null &&
                    this.Rows.SequenceEqual(other.Rows)
                ) && 
                (
                    this.DefaultColumnWidth == other.DefaultColumnWidth ||
                    this.DefaultColumnWidth != null &&
                    this.DefaultColumnWidth.Equals(other.DefaultColumnWidth)
                ) && 
                (
                    this.DefaultCellBorder == other.DefaultCellBorder ||
                    this.DefaultCellBorder != null &&
                    this.DefaultCellBorder.Equals(other.DefaultCellBorder)
                ) && 
                (
                    this.Broken == other.Broken ||
                    this.Broken != null &&
                    this.Broken.Equals(other.Broken)
                ) && 
                (
                    this.ColumnWidths == other.ColumnWidths ||
                    this.ColumnWidths != null &&
                    this.ColumnWidths.Equals(other.ColumnWidths)
                ) && 
                (
                    this.RepeatingRowsCount == other.RepeatingRowsCount ||
                    this.RepeatingRowsCount != null &&
                    this.RepeatingRowsCount.Equals(other.RepeatingRowsCount)
                ) && 
                (
                    this.RepeatingColumnsCount == other.RepeatingColumnsCount ||
                    this.RepeatingColumnsCount != null &&
                    this.RepeatingColumnsCount.Equals(other.RepeatingColumnsCount)
                ) && 
                (
                    this.RepeatingRowsStyle == other.RepeatingRowsStyle ||
                    this.RepeatingRowsStyle != null &&
                    this.RepeatingRowsStyle.Equals(other.RepeatingRowsStyle)
                ) && 
                (
                    this.CornerStyle == other.CornerStyle ||
                    this.CornerStyle != null &&
                    this.CornerStyle.Equals(other.CornerStyle)
                ) && 
                (
                    this.BreakText == other.BreakText ||
                    this.BreakText != null &&
                    this.BreakText.Equals(other.BreakText)
                ) && 
                (
                    this.BackgroundColor == other.BackgroundColor ||
                    this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(other.BackgroundColor)
                ) && 
                (
                    this.IsBordersIncluded == other.IsBordersIncluded ||
                    this.IsBordersIncluded != null &&
                    this.IsBordersIncluded.Equals(other.IsBordersIncluded)
                ) && 
                (
                    this.ColumnAdjustment == other.ColumnAdjustment ||
                    this.ColumnAdjustment != null &&
                    this.ColumnAdjustment.Equals(other.ColumnAdjustment)
                ) && 
                (
                    this.ZIndex == other.ZIndex ||
                    this.ZIndex != null &&
                    this.ZIndex.Equals(other.ZIndex)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Alignment != null)
                    hash = hash * 59 + this.Alignment.GetHashCode();
                if (this.HorizontalAlignment != null)
                    hash = hash * 59 + this.HorizontalAlignment.GetHashCode();
                if (this.VerticalAlignment != null)
                    hash = hash * 59 + this.VerticalAlignment.GetHashCode();
                if (this.Top != null)
                    hash = hash * 59 + this.Top.GetHashCode();
                if (this.Left != null)
                    hash = hash * 59 + this.Left.GetHashCode();
                if (this.DefaultCellTextState != null)
                    hash = hash * 59 + this.DefaultCellTextState.GetHashCode();
                if (this.DefaultCellPadding != null)
                    hash = hash * 59 + this.DefaultCellPadding.GetHashCode();
                if (this.Border != null)
                    hash = hash * 59 + this.Border.GetHashCode();
                if (this.Margin != null)
                    hash = hash * 59 + this.Margin.GetHashCode();
                if (this.Rows != null)
                    hash = hash * 59 + this.Rows.GetHashCode();
                if (this.DefaultColumnWidth != null)
                    hash = hash * 59 + this.DefaultColumnWidth.GetHashCode();
                if (this.DefaultCellBorder != null)
                    hash = hash * 59 + this.DefaultCellBorder.GetHashCode();
                if (this.Broken != null)
                    hash = hash * 59 + this.Broken.GetHashCode();
                if (this.ColumnWidths != null)
                    hash = hash * 59 + this.ColumnWidths.GetHashCode();
                if (this.RepeatingRowsCount != null)
                    hash = hash * 59 + this.RepeatingRowsCount.GetHashCode();
                if (this.RepeatingColumnsCount != null)
                    hash = hash * 59 + this.RepeatingColumnsCount.GetHashCode();
                if (this.RepeatingRowsStyle != null)
                    hash = hash * 59 + this.RepeatingRowsStyle.GetHashCode();
                if (this.CornerStyle != null)
                    hash = hash * 59 + this.CornerStyle.GetHashCode();
                if (this.BreakText != null)
                    hash = hash * 59 + this.BreakText.GetHashCode();
                if (this.BackgroundColor != null)
                    hash = hash * 59 + this.BackgroundColor.GetHashCode();
                if (this.IsBordersIncluded != null)
                    hash = hash * 59 + this.IsBordersIncluded.GetHashCode();
                if (this.ColumnAdjustment != null)
                    hash = hash * 59 + this.ColumnAdjustment.GetHashCode();
                if (this.ZIndex != null)
                    hash = hash * 59 + this.ZIndex.GetHashCode();
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
