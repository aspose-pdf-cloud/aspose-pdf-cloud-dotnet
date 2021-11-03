// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Row.cs">
//   Copyright (c) 2021 Aspose.PDF Cloud
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
    /// Represents a row of the table.
    /// </summary>
    [DataContract]
    public partial class Row :  IEquatable<Row>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Row" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Row() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Row" /> class.
        /// </summary>
        /// <param name="BackgroundColor">Gets or sets the background color.</param>
        /// <param name="Border">Gets or sets the border.</param>
        /// <param name="Cells">Sets the cells of the row. (required)</param>
        /// <param name="DefaultCellBorder">Gets default cell border;</param>
        /// <param name="MinRowHeight">Gets height for row;</param>
        /// <param name="FixedRowHeight">Gets fixed row height - row may have fixed height;</param>
        /// <param name="IsInNewPage">Gets fixed row is in new page - page with this property should be printed to next page Default false;</param>
        /// <param name="IsRowBroken">Gets is row can be broken between two pages</param>
        /// <param name="DefaultCellTextState">Gets or sets default text state for row cells</param>
        /// <param name="DefaultCellPadding">Gets or sets default margin for row cells</param>
        /// <param name="VerticalAlignment">Gets or sets the vertical alignment.</param>
        public Row(Color BackgroundColor = default(Color), BorderInfo Border = default(BorderInfo), List<Cell> Cells = default(List<Cell>), BorderInfo DefaultCellBorder = default(BorderInfo), double? MinRowHeight = default(double?), double? FixedRowHeight = default(double?), bool? IsInNewPage = default(bool?), bool? IsRowBroken = default(bool?), TextState DefaultCellTextState = default(TextState), MarginInfo DefaultCellPadding = default(MarginInfo), VerticalAlignment VerticalAlignment = default(VerticalAlignment))
        {
            // to ensure "Cells" is required (not null)
            if (Cells == null)
            {
                throw new InvalidDataException("Cells is a required property for Row and cannot be null");
            }
            else
            {
                this.Cells = Cells;
            }
            this.BackgroundColor = BackgroundColor;
            this.Border = Border;
            this.DefaultCellBorder = DefaultCellBorder;
            this.MinRowHeight = MinRowHeight;
            this.FixedRowHeight = FixedRowHeight;
            this.IsInNewPage = IsInNewPage;
            this.IsRowBroken = IsRowBroken;
            this.DefaultCellTextState = DefaultCellTextState;
            this.DefaultCellPadding = DefaultCellPadding;
            this.VerticalAlignment = VerticalAlignment;
        }
        
        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        /// <value>Gets or sets the background color.</value>
        [DataMember(Name="BackgroundColor", EmitDefaultValue=false)]
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the border.
        /// </summary>
        /// <value>Gets or sets the border.</value>
        [DataMember(Name="Border", EmitDefaultValue=false)]
        public BorderInfo Border { get; set; }

        /// <summary>
        /// Sets the cells of the row.
        /// </summary>
        /// <value>Sets the cells of the row.</value>
        [DataMember(Name="Cells", EmitDefaultValue=false)]
        public List<Cell> Cells { get; set; }

        /// <summary>
        /// Gets default cell border;
        /// </summary>
        /// <value>Gets default cell border;</value>
        [DataMember(Name="DefaultCellBorder", EmitDefaultValue=false)]
        public BorderInfo DefaultCellBorder { get; set; }

        /// <summary>
        /// Gets height for row;
        /// </summary>
        /// <value>Gets height for row;</value>
        [DataMember(Name="MinRowHeight", EmitDefaultValue=false)]
        public double? MinRowHeight { get; set; }

        /// <summary>
        /// Gets fixed row height - row may have fixed height;
        /// </summary>
        /// <value>Gets fixed row height - row may have fixed height;</value>
        [DataMember(Name="FixedRowHeight", EmitDefaultValue=false)]
        public double? FixedRowHeight { get; set; }

        /// <summary>
        /// Gets fixed row is in new page - page with this property should be printed to next page Default false;
        /// </summary>
        /// <value>Gets fixed row is in new page - page with this property should be printed to next page Default false;</value>
        [DataMember(Name="IsInNewPage", EmitDefaultValue=false)]
        public bool? IsInNewPage { get; set; }

        /// <summary>
        /// Gets is row can be broken between two pages
        /// </summary>
        /// <value>Gets is row can be broken between two pages</value>
        [DataMember(Name="IsRowBroken", EmitDefaultValue=false)]
        public bool? IsRowBroken { get; set; }

        /// <summary>
        /// Gets or sets default text state for row cells
        /// </summary>
        /// <value>Gets or sets default text state for row cells</value>
        [DataMember(Name="DefaultCellTextState", EmitDefaultValue=false)]
        public TextState DefaultCellTextState { get; set; }

        /// <summary>
        /// Gets or sets default margin for row cells
        /// </summary>
        /// <value>Gets or sets default margin for row cells</value>
        [DataMember(Name="DefaultCellPadding", EmitDefaultValue=false)]
        public MarginInfo DefaultCellPadding { get; set; }

        /// <summary>
        /// Gets or sets the vertical alignment.
        /// </summary>
        /// <value>Gets or sets the vertical alignment.</value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=true)]
        public VerticalAlignment VerticalAlignment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Row {\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  Border: ").Append(Border).Append("\n");
            sb.Append("  Cells: ").Append(Cells).Append("\n");
            sb.Append("  DefaultCellBorder: ").Append(DefaultCellBorder).Append("\n");
            sb.Append("  MinRowHeight: ").Append(MinRowHeight).Append("\n");
            sb.Append("  FixedRowHeight: ").Append(FixedRowHeight).Append("\n");
            sb.Append("  IsInNewPage: ").Append(IsInNewPage).Append("\n");
            sb.Append("  IsRowBroken: ").Append(IsRowBroken).Append("\n");
            sb.Append("  DefaultCellTextState: ").Append(DefaultCellTextState).Append("\n");
            sb.Append("  DefaultCellPadding: ").Append(DefaultCellPadding).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
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
            return this.Equals(obj as Row);
        }

        /// <summary>
        /// Returns true if Row instances are equal
        /// </summary>
        /// <param name="other">Instance of Row to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Row other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BackgroundColor == other.BackgroundColor ||
                    this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(other.BackgroundColor)
                ) && 
                (
                    this.Border == other.Border ||
                    this.Border != null &&
                    this.Border.Equals(other.Border)
                ) && 
                (
                    this.Cells == other.Cells ||
                    this.Cells != null &&
                    this.Cells.SequenceEqual(other.Cells)
                ) && 
                (
                    this.DefaultCellBorder == other.DefaultCellBorder ||
                    this.DefaultCellBorder != null &&
                    this.DefaultCellBorder.Equals(other.DefaultCellBorder)
                ) && 
                (
                    this.MinRowHeight == other.MinRowHeight ||
                    this.MinRowHeight != null &&
                    this.MinRowHeight.Equals(other.MinRowHeight)
                ) && 
                (
                    this.FixedRowHeight == other.FixedRowHeight ||
                    this.FixedRowHeight != null &&
                    this.FixedRowHeight.Equals(other.FixedRowHeight)
                ) && 
                (
                    this.IsInNewPage == other.IsInNewPage ||
                    this.IsInNewPage != null &&
                    this.IsInNewPage.Equals(other.IsInNewPage)
                ) && 
                (
                    this.IsRowBroken == other.IsRowBroken ||
                    this.IsRowBroken != null &&
                    this.IsRowBroken.Equals(other.IsRowBroken)
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
                    this.VerticalAlignment == other.VerticalAlignment ||
                    this.VerticalAlignment != null &&
                    this.VerticalAlignment.Equals(other.VerticalAlignment)
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
                if (this.BackgroundColor != null)
                    hash = hash * 59 + this.BackgroundColor.GetHashCode();
                if (this.Border != null)
                    hash = hash * 59 + this.Border.GetHashCode();
                if (this.Cells != null)
                    hash = hash * 59 + this.Cells.GetHashCode();
                if (this.DefaultCellBorder != null)
                    hash = hash * 59 + this.DefaultCellBorder.GetHashCode();
                if (this.MinRowHeight != null)
                    hash = hash * 59 + this.MinRowHeight.GetHashCode();
                if (this.FixedRowHeight != null)
                    hash = hash * 59 + this.FixedRowHeight.GetHashCode();
                if (this.IsInNewPage != null)
                    hash = hash * 59 + this.IsInNewPage.GetHashCode();
                if (this.IsRowBroken != null)
                    hash = hash * 59 + this.IsRowBroken.GetHashCode();
                if (this.DefaultCellTextState != null)
                    hash = hash * 59 + this.DefaultCellTextState.GetHashCode();
                if (this.DefaultCellPadding != null)
                    hash = hash * 59 + this.DefaultCellPadding.GetHashCode();
                if (this.VerticalAlignment != null)
                    hash = hash * 59 + this.VerticalAlignment.GetHashCode();
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
