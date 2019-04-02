// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextStamp.cs">
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
    /// Represents Pdf stamps.
    /// </summary>
    [DataContract]
    public partial class TextStamp : StampBase,  IEquatable<TextStamp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextStamp" /> class.
        /// </summary>
        /// <param name="Links">Link to the document..</param>
        /// <param name="Background">Sets or gets a bool value that indicates the content is stamped as background. If the value is true, the stamp content is layed at the bottom. By defalt, the value is false, the stamp content is layed at the top..</param>
        /// <param name="BottomMargin">Gets or sets bottom margin of stamp..</param>
        /// <param name="HorizontalAlignment">Gets or sets Horizontal alignment of stamp on the page. .</param>
        /// <param name="LeftMargin">Gets or sets left margin of stamp..</param>
        /// <param name="Opacity">Gets or sets a value to indicate the stamp opacity. The value is from 0.0 to 1.0. By default the value is 1.0..</param>
        /// <param name="RightMargin">Gets or sets right margin of stamp..</param>
        /// <param name="Rotate">Sets or gets the rotation of stamp content according  values. Note. This property is for set angles which are multiples of 90 degrees (0, 90, 180, 270 degrees). To set arbitrary angle use RotateAngle property.  If angle set by ArbitraryAngle is not multiple of 90 then Rotate property returns Rotation.None..</param>
        /// <param name="RotateAngle">Gets or sets rotate angle of stamp in degrees. This property allows to set arbitrary rotate angle. .</param>
        /// <param name="TopMargin">Gets or sets top margin of stamp..</param>
        /// <param name="VerticalAlignment">Gets or sets vertical alignment of stamp on page..</param>
        /// <param name="XIndent">Horizontal stamp coordinate, starting from the left..</param>
        /// <param name="YIndent">Vertical stamp coordinate, starting from the bottom..</param>
        /// <param name="Zoom">Zooming factor of the stamp. Allows to scale stamp..</param>
        /// <param name="TextAlignment">Alignment of the text inside the stamp..</param>
        /// <param name="Value">Gets or sets string value which is used as stamp on the page..</param>
        /// <param name="TextState">Gets text properties of the stamp. See  for details..</param>
        public TextStamp(List<Link> Links = default(List<Link>), bool? Background = default(bool?), double? BottomMargin = default(double?), HorizontalAlignment HorizontalAlignment = default(HorizontalAlignment), double? LeftMargin = default(double?), double? Opacity = default(double?), double? RightMargin = default(double?), Rotation Rotate = default(Rotation), double? RotateAngle = default(double?), double? TopMargin = default(double?), VerticalAlignment VerticalAlignment = default(VerticalAlignment), double? XIndent = default(double?), double? YIndent = default(double?), double? Zoom = default(double?), HorizontalAlignment TextAlignment = default(HorizontalAlignment), string Value = default(string), TextState TextState = default(TextState))
        {
            this.Links = Links;
            this.Background = Background;
            this.BottomMargin = BottomMargin;
            this.HorizontalAlignment = HorizontalAlignment;
            this.LeftMargin = LeftMargin;
            this.Opacity = Opacity;
            this.RightMargin = RightMargin;
            this.Rotate = Rotate;
            this.RotateAngle = RotateAngle;
            this.TopMargin = TopMargin;
            this.VerticalAlignment = VerticalAlignment;
            this.XIndent = XIndent;
            this.YIndent = YIndent;
            this.Zoom = Zoom;
            this.TextAlignment = TextAlignment;
            this.Value = Value;
            this.TextState = TextState;
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
        /// Gets or sets bottom margin of stamp.
        /// </summary>
        /// <value>Gets or sets bottom margin of stamp.</value>
        [DataMember(Name="BottomMargin", EmitDefaultValue=false)]
        public double? BottomMargin { get; set; }

        /// <summary>
        /// Gets or sets Horizontal alignment of stamp on the page. 
        /// </summary>
        /// <value>Gets or sets Horizontal alignment of stamp on the page. </value>
        [DataMember(Name="HorizontalAlignment", EmitDefaultValue=true)]
        public HorizontalAlignment HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets left margin of stamp.
        /// </summary>
        /// <value>Gets or sets left margin of stamp.</value>
        [DataMember(Name="LeftMargin", EmitDefaultValue=false)]
        public double? LeftMargin { get; set; }

        /// <summary>
        /// Gets or sets a value to indicate the stamp opacity. The value is from 0.0 to 1.0. By default the value is 1.0.
        /// </summary>
        /// <value>Gets or sets a value to indicate the stamp opacity. The value is from 0.0 to 1.0. By default the value is 1.0.</value>
        [DataMember(Name="Opacity", EmitDefaultValue=false)]
        public double? Opacity { get; set; }

        /// <summary>
        /// Gets or sets right margin of stamp.
        /// </summary>
        /// <value>Gets or sets right margin of stamp.</value>
        [DataMember(Name="RightMargin", EmitDefaultValue=false)]
        public double? RightMargin { get; set; }

        /// <summary>
        /// Sets or gets the rotation of stamp content according  values. Note. This property is for set angles which are multiples of 90 degrees (0, 90, 180, 270 degrees). To set arbitrary angle use RotateAngle property.  If angle set by ArbitraryAngle is not multiple of 90 then Rotate property returns Rotation.None.
        /// </summary>
        /// <value>Sets or gets the rotation of stamp content according  values. Note. This property is for set angles which are multiples of 90 degrees (0, 90, 180, 270 degrees). To set arbitrary angle use RotateAngle property.  If angle set by ArbitraryAngle is not multiple of 90 then Rotate property returns Rotation.None.</value>
        [DataMember(Name="Rotate", EmitDefaultValue=true)]
        public Rotation Rotate { get; set; }

        /// <summary>
        /// Gets or sets rotate angle of stamp in degrees. This property allows to set arbitrary rotate angle. 
        /// </summary>
        /// <value>Gets or sets rotate angle of stamp in degrees. This property allows to set arbitrary rotate angle. </value>
        [DataMember(Name="RotateAngle", EmitDefaultValue=false)]
        public double? RotateAngle { get; set; }

        /// <summary>
        /// Gets or sets top margin of stamp.
        /// </summary>
        /// <value>Gets or sets top margin of stamp.</value>
        [DataMember(Name="TopMargin", EmitDefaultValue=false)]
        public double? TopMargin { get; set; }

        /// <summary>
        /// Gets or sets vertical alignment of stamp on page.
        /// </summary>
        /// <value>Gets or sets vertical alignment of stamp on page.</value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=true)]
        public VerticalAlignment VerticalAlignment { get; set; }

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
        /// Alignment of the text inside the stamp.
        /// </summary>
        /// <value>Alignment of the text inside the stamp.</value>
        [DataMember(Name="TextAlignment", EmitDefaultValue=true)]
        public HorizontalAlignment TextAlignment { get; set; }

        /// <summary>
        /// Gets or sets string value which is used as stamp on the page.
        /// </summary>
        /// <value>Gets or sets string value which is used as stamp on the page.</value>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets text properties of the stamp. See  for details.
        /// </summary>
        /// <value>Gets text properties of the stamp. See  for details.</value>
        [DataMember(Name="TextState", EmitDefaultValue=false)]
        public TextState TextState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextStamp {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Background: ").Append(Background).Append("\n");
            sb.Append("  BottomMargin: ").Append(BottomMargin).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(HorizontalAlignment).Append("\n");
            sb.Append("  LeftMargin: ").Append(LeftMargin).Append("\n");
            sb.Append("  Opacity: ").Append(Opacity).Append("\n");
            sb.Append("  RightMargin: ").Append(RightMargin).Append("\n");
            sb.Append("  Rotate: ").Append(Rotate).Append("\n");
            sb.Append("  RotateAngle: ").Append(RotateAngle).Append("\n");
            sb.Append("  TopMargin: ").Append(TopMargin).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  XIndent: ").Append(XIndent).Append("\n");
            sb.Append("  YIndent: ").Append(YIndent).Append("\n");
            sb.Append("  Zoom: ").Append(Zoom).Append("\n");
            sb.Append("  TextAlignment: ").Append(TextAlignment).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  TextState: ").Append(TextState).Append("\n");
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
            return this.Equals(obj as TextStamp);
        }

        /// <summary>
        /// Returns true if TextStamp instances are equal
        /// </summary>
        /// <param name="other">Instance of TextStamp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextStamp other)
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
                    this.BottomMargin == other.BottomMargin ||
                    this.BottomMargin != null &&
                    this.BottomMargin.Equals(other.BottomMargin)
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
                    this.Opacity == other.Opacity ||
                    this.Opacity != null &&
                    this.Opacity.Equals(other.Opacity)
                ) && 
                (
                    this.RightMargin == other.RightMargin ||
                    this.RightMargin != null &&
                    this.RightMargin.Equals(other.RightMargin)
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
                    this.TopMargin == other.TopMargin ||
                    this.TopMargin != null &&
                    this.TopMargin.Equals(other.TopMargin)
                ) && 
                (
                    this.VerticalAlignment == other.VerticalAlignment ||
                    this.VerticalAlignment != null &&
                    this.VerticalAlignment.Equals(other.VerticalAlignment)
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
                    this.TextAlignment == other.TextAlignment ||
                    this.TextAlignment != null &&
                    this.TextAlignment.Equals(other.TextAlignment)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Background != null)
                    hash = hash * 59 + this.Background.GetHashCode();
                if (this.BottomMargin != null)
                    hash = hash * 59 + this.BottomMargin.GetHashCode();
                if (this.HorizontalAlignment != null)
                    hash = hash * 59 + this.HorizontalAlignment.GetHashCode();
                if (this.LeftMargin != null)
                    hash = hash * 59 + this.LeftMargin.GetHashCode();
                if (this.Opacity != null)
                    hash = hash * 59 + this.Opacity.GetHashCode();
                if (this.RightMargin != null)
                    hash = hash * 59 + this.RightMargin.GetHashCode();
                if (this.Rotate != null)
                    hash = hash * 59 + this.Rotate.GetHashCode();
                if (this.RotateAngle != null)
                    hash = hash * 59 + this.RotateAngle.GetHashCode();
                if (this.TopMargin != null)
                    hash = hash * 59 + this.TopMargin.GetHashCode();
                if (this.VerticalAlignment != null)
                    hash = hash * 59 + this.VerticalAlignment.GetHashCode();
                if (this.XIndent != null)
                    hash = hash * 59 + this.XIndent.GetHashCode();
                if (this.YIndent != null)
                    hash = hash * 59 + this.YIndent.GetHashCode();
                if (this.Zoom != null)
                    hash = hash * 59 + this.Zoom.GetHashCode();
                if (this.TextAlignment != null)
                    hash = hash * 59 + this.TextAlignment.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
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
