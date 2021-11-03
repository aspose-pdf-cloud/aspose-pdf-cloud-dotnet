// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfPageStamp.cs">
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
    /// Represents Pdf stamps.
    /// </summary>
    [DataContract]
    public partial class PdfPageStamp : StampBase,  IEquatable<PdfPageStamp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfPageStamp" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="Background">Sets or gets a bool value that indicates the content is stamped as background. If the value is true, the stamp content is layed at the bottom. By defalt, the value is false, the stamp content is layed at the top.</param>
        /// <param name="HorizontalAlignment">Gets or sets Horizontal alignment of stamp on the page. </param>
        /// <param name="Opacity">Gets or sets a value to indicate the stamp opacity. The value is from 0.0 to 1.0. By default the value is 1.0.</param>
        /// <param name="Rotate">Sets or gets the rotation of stamp content according Rotation values. Note. This property is for set angles which are multiples of 90 degrees (0, 90, 180, 270 degrees). To set arbitrary angle use RotateAngle property.  If angle set by ArbitraryAngle is not multiple of 90 then Rotate property returns Rotation.None.</param>
        /// <param name="RotateAngle">Gets or sets rotate angle of stamp in degrees. This property allows to set arbitrary rotate angle. </param>
        /// <param name="XIndent">Horizontal stamp coordinate, starting from the left.</param>
        /// <param name="YIndent">Vertical stamp coordinate, starting from the bottom.</param>
        /// <param name="Zoom">Zooming factor of the stamp. Allows to scale stamp.</param>
        /// <param name="FileName">Gets or sets the file name.</param>
        /// <param name="PageIndex">Gets or sets the index of the page.</param>
        /// <param name="VerticalAlignment">Gets or sets vertical alignment of stamp on page.</param>
        /// <param name="BottomMargin">Gets or sets bottom margin of stamp.</param>
        /// <param name="LeftMargin">Gets or sets left margin of stamp.</param>
        /// <param name="TopMargin">Gets or sets top margin of stamp.</param>
        /// <param name="RightMargin">Gets or sets right margin of stamp.</param>
        public PdfPageStamp(List<Link> Links = default(List<Link>), bool? Background = default(bool?), HorizontalAlignment HorizontalAlignment = default(HorizontalAlignment), double? Opacity = default(double?), Rotation Rotate = default(Rotation), double? RotateAngle = default(double?), double? XIndent = default(double?), double? YIndent = default(double?), double? Zoom = default(double?), string FileName = default(string), int? PageIndex = default(int?), VerticalAlignment VerticalAlignment = default(VerticalAlignment), double? BottomMargin = default(double?), double? LeftMargin = default(double?), double? TopMargin = default(double?), double? RightMargin = default(double?))
        {
            this.Links = Links;
            this.Background = Background;
            this.HorizontalAlignment = HorizontalAlignment;
            this.Opacity = Opacity;
            this.Rotate = Rotate;
            this.RotateAngle = RotateAngle;
            this.XIndent = XIndent;
            this.YIndent = YIndent;
            this.Zoom = Zoom;
            this.FileName = FileName;
            this.PageIndex = PageIndex;
            this.VerticalAlignment = VerticalAlignment;
            this.BottomMargin = BottomMargin;
            this.LeftMargin = LeftMargin;
            this.TopMargin = TopMargin;
            this.RightMargin = RightMargin;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Sets or gets a bool value that indicates the content is stamped as background. If the value is true, the stamp content is layed at the bottom. By defalt, the value is false, the stamp content is layed at the top.
        /// </summary>
        /// <value>Sets or gets a bool value that indicates the content is stamped as background. If the value is true, the stamp content is layed at the bottom. By defalt, the value is false, the stamp content is layed at the top.</value>
        [DataMember(Name="Background", EmitDefaultValue=false)]
        public bool? Background { get; set; }

        /// <summary>
        /// Gets or sets Horizontal alignment of stamp on the page. 
        /// </summary>
        /// <value>Gets or sets Horizontal alignment of stamp on the page. </value>
        [DataMember(Name="HorizontalAlignment", EmitDefaultValue=true)]
        public HorizontalAlignment HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets a value to indicate the stamp opacity. The value is from 0.0 to 1.0. By default the value is 1.0.
        /// </summary>
        /// <value>Gets or sets a value to indicate the stamp opacity. The value is from 0.0 to 1.0. By default the value is 1.0.</value>
        [DataMember(Name="Opacity", EmitDefaultValue=false)]
        public double? Opacity { get; set; }

        /// <summary>
        /// Sets or gets the rotation of stamp content according Rotation values. Note. This property is for set angles which are multiples of 90 degrees (0, 90, 180, 270 degrees). To set arbitrary angle use RotateAngle property.  If angle set by ArbitraryAngle is not multiple of 90 then Rotate property returns Rotation.None.
        /// </summary>
        /// <value>Sets or gets the rotation of stamp content according Rotation values. Note. This property is for set angles which are multiples of 90 degrees (0, 90, 180, 270 degrees). To set arbitrary angle use RotateAngle property.  If angle set by ArbitraryAngle is not multiple of 90 then Rotate property returns Rotation.None.</value>
        [DataMember(Name="Rotate", EmitDefaultValue=true)]
        public Rotation Rotate { get; set; }

        /// <summary>
        /// Gets or sets rotate angle of stamp in degrees. This property allows to set arbitrary rotate angle. 
        /// </summary>
        /// <value>Gets or sets rotate angle of stamp in degrees. This property allows to set arbitrary rotate angle. </value>
        [DataMember(Name="RotateAngle", EmitDefaultValue=false)]
        public double? RotateAngle { get; set; }

        /// <summary>
        /// Horizontal stamp coordinate, starting from the left.
        /// </summary>
        /// <value>Horizontal stamp coordinate, starting from the left.</value>
        [DataMember(Name="XIndent", EmitDefaultValue=false)]
        public double? XIndent { get; set; }

        /// <summary>
        /// Vertical stamp coordinate, starting from the bottom.
        /// </summary>
        /// <value>Vertical stamp coordinate, starting from the bottom.</value>
        [DataMember(Name="YIndent", EmitDefaultValue=false)]
        public double? YIndent { get; set; }

        /// <summary>
        /// Zooming factor of the stamp. Allows to scale stamp.
        /// </summary>
        /// <value>Zooming factor of the stamp. Allows to scale stamp.</value>
        [DataMember(Name="Zoom", EmitDefaultValue=false)]
        public double? Zoom { get; set; }

        /// <summary>
        /// Gets or sets the file name.
        /// </summary>
        /// <value>Gets or sets the file name.</value>
        [DataMember(Name="FileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the index of the page.
        /// </summary>
        /// <value>Gets or sets the index of the page.</value>
        [DataMember(Name="PageIndex", EmitDefaultValue=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// Gets or sets vertical alignment of stamp on page.
        /// </summary>
        /// <value>Gets or sets vertical alignment of stamp on page.</value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=true)]
        public VerticalAlignment VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets bottom margin of stamp.
        /// </summary>
        /// <value>Gets or sets bottom margin of stamp.</value>
        [DataMember(Name="BottomMargin", EmitDefaultValue=false)]
        public double? BottomMargin { get; set; }

        /// <summary>
        /// Gets or sets left margin of stamp.
        /// </summary>
        /// <value>Gets or sets left margin of stamp.</value>
        [DataMember(Name="LeftMargin", EmitDefaultValue=false)]
        public double? LeftMargin { get; set; }

        /// <summary>
        /// Gets or sets top margin of stamp.
        /// </summary>
        /// <value>Gets or sets top margin of stamp.</value>
        [DataMember(Name="TopMargin", EmitDefaultValue=false)]
        public double? TopMargin { get; set; }

        /// <summary>
        /// Gets or sets right margin of stamp.
        /// </summary>
        /// <value>Gets or sets right margin of stamp.</value>
        [DataMember(Name="RightMargin", EmitDefaultValue=false)]
        public double? RightMargin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfPageStamp {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Background: ").Append(Background).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(HorizontalAlignment).Append("\n");
            sb.Append("  Opacity: ").Append(Opacity).Append("\n");
            sb.Append("  Rotate: ").Append(Rotate).Append("\n");
            sb.Append("  RotateAngle: ").Append(RotateAngle).Append("\n");
            sb.Append("  XIndent: ").Append(XIndent).Append("\n");
            sb.Append("  YIndent: ").Append(YIndent).Append("\n");
            sb.Append("  Zoom: ").Append(Zoom).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  BottomMargin: ").Append(BottomMargin).Append("\n");
            sb.Append("  LeftMargin: ").Append(LeftMargin).Append("\n");
            sb.Append("  TopMargin: ").Append(TopMargin).Append("\n");
            sb.Append("  RightMargin: ").Append(RightMargin).Append("\n");
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
            return this.Equals(obj as PdfPageStamp);
        }

        /// <summary>
        /// Returns true if PdfPageStamp instances are equal
        /// </summary>
        /// <param name="other">Instance of PdfPageStamp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfPageStamp other)
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
                    this.Background == other.Background ||
                    this.Background != null &&
                    this.Background.Equals(other.Background)
                ) && 
                (
                    this.HorizontalAlignment == other.HorizontalAlignment ||
                    this.HorizontalAlignment != null &&
                    this.HorizontalAlignment.Equals(other.HorizontalAlignment)
                ) && 
                (
                    this.Opacity == other.Opacity ||
                    this.Opacity != null &&
                    this.Opacity.Equals(other.Opacity)
                ) && 
                (
                    this.Rotate == other.Rotate ||
                    this.Rotate != null &&
                    this.Rotate.Equals(other.Rotate)
                ) && 
                (
                    this.RotateAngle == other.RotateAngle ||
                    this.RotateAngle != null &&
                    this.RotateAngle.Equals(other.RotateAngle)
                ) && 
                (
                    this.XIndent == other.XIndent ||
                    this.XIndent != null &&
                    this.XIndent.Equals(other.XIndent)
                ) && 
                (
                    this.YIndent == other.YIndent ||
                    this.YIndent != null &&
                    this.YIndent.Equals(other.YIndent)
                ) && 
                (
                    this.Zoom == other.Zoom ||
                    this.Zoom != null &&
                    this.Zoom.Equals(other.Zoom)
                ) && 
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) && 
                (
                    this.PageIndex == other.PageIndex ||
                    this.PageIndex != null &&
                    this.PageIndex.Equals(other.PageIndex)
                ) && 
                (
                    this.VerticalAlignment == other.VerticalAlignment ||
                    this.VerticalAlignment != null &&
                    this.VerticalAlignment.Equals(other.VerticalAlignment)
                ) && 
                (
                    this.BottomMargin == other.BottomMargin ||
                    this.BottomMargin != null &&
                    this.BottomMargin.Equals(other.BottomMargin)
                ) && 
                (
                    this.LeftMargin == other.LeftMargin ||
                    this.LeftMargin != null &&
                    this.LeftMargin.Equals(other.LeftMargin)
                ) && 
                (
                    this.TopMargin == other.TopMargin ||
                    this.TopMargin != null &&
                    this.TopMargin.Equals(other.TopMargin)
                ) && 
                (
                    this.RightMargin == other.RightMargin ||
                    this.RightMargin != null &&
                    this.RightMargin.Equals(other.RightMargin)
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
                if (this.Background != null)
                    hash = hash * 59 + this.Background.GetHashCode();
                if (this.HorizontalAlignment != null)
                    hash = hash * 59 + this.HorizontalAlignment.GetHashCode();
                if (this.Opacity != null)
                    hash = hash * 59 + this.Opacity.GetHashCode();
                if (this.Rotate != null)
                    hash = hash * 59 + this.Rotate.GetHashCode();
                if (this.RotateAngle != null)
                    hash = hash * 59 + this.RotateAngle.GetHashCode();
                if (this.XIndent != null)
                    hash = hash * 59 + this.XIndent.GetHashCode();
                if (this.YIndent != null)
                    hash = hash * 59 + this.YIndent.GetHashCode();
                if (this.Zoom != null)
                    hash = hash * 59 + this.Zoom.GetHashCode();
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();
                if (this.PageIndex != null)
                    hash = hash * 59 + this.PageIndex.GetHashCode();
                if (this.VerticalAlignment != null)
                    hash = hash * 59 + this.VerticalAlignment.GetHashCode();
                if (this.BottomMargin != null)
                    hash = hash * 59 + this.BottomMargin.GetHashCode();
                if (this.LeftMargin != null)
                    hash = hash * 59 + this.LeftMargin.GetHashCode();
                if (this.TopMargin != null)
                    hash = hash * 59 + this.TopMargin.GetHashCode();
                if (this.RightMargin != null)
                    hash = hash * 59 + this.RightMargin.GetHashCode();
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
