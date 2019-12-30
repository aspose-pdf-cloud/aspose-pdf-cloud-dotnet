// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GraphInfo.cs">
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
    /// Represents graphics info.
    /// </summary>
    [DataContract]
    public partial class GraphInfo :  IEquatable<GraphInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphInfo" /> class.
        /// </summary>
        /// <param name="LineWidth">Gets or sets a float value that indicates the line width of the graph.</param>
        /// <param name="Color">Gets or sets a Color object that indicates the color of the graph.</param>
        /// <param name="DashArray">Gets or sets a dash array.</param>
        /// <param name="DashPhase">Gets or sets a dash phase.</param>
        /// <param name="FillColor">Gets or sets a Color object that indicates the fill color of the graph.</param>
        /// <param name="IsDoubled">Gets or sets is border doubled.</param>
        /// <param name="SkewAngleX">Gets or sets a float value that indicates the skew angle of the x-coordinate when transforming a coordinate system.</param>
        /// <param name="SkewAngleY">Gets or sets a float value that indicates the skew angle of the y-coordinate when transforming a coordinate system.</param>
        /// <param name="ScalingRateX">Gets or sets a float value that indicates the scaling rate of the x-coordinate when transforming a coordinate system.</param>
        /// <param name="ScalingRateY">Gets or sets a float value that indicates the scaling rate of the y-coordinate when transforming a coordinate system.</param>
        /// <param name="RotationAngle">Gets or sets a float value that indicates the rotation angle of the coordinate system  when transforming a coordinate system.</param>
        public GraphInfo(double? LineWidth = default(double?), Color Color = default(Color), List<int?> DashArray = default(List<int?>), int? DashPhase = default(int?), Color FillColor = default(Color), bool? IsDoubled = default(bool?), double? SkewAngleX = default(double?), double? SkewAngleY = default(double?), double? ScalingRateX = default(double?), double? ScalingRateY = default(double?), double? RotationAngle = default(double?))
        {
            this.LineWidth = LineWidth;
            this.Color = Color;
            this.DashArray = DashArray;
            this.DashPhase = DashPhase;
            this.FillColor = FillColor;
            this.IsDoubled = IsDoubled;
            this.SkewAngleX = SkewAngleX;
            this.SkewAngleY = SkewAngleY;
            this.ScalingRateX = ScalingRateX;
            this.ScalingRateY = ScalingRateY;
            this.RotationAngle = RotationAngle;
        }
        
        /// <summary>
        /// Gets or sets a float value that indicates the line width of the graph.
        /// </summary>
        /// <value>Gets or sets a float value that indicates the line width of the graph.</value>
        [DataMember(Name="LineWidth", EmitDefaultValue=false)]
        public double? LineWidth { get; set; }

        /// <summary>
        /// Gets or sets a Color object that indicates the color of the graph.
        /// </summary>
        /// <value>Gets or sets a Color object that indicates the color of the graph.</value>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets a dash array.
        /// </summary>
        /// <value>Gets or sets a dash array.</value>
        [DataMember(Name="DashArray", EmitDefaultValue=false)]
        public List<int?> DashArray { get; set; }

        /// <summary>
        /// Gets or sets a dash phase.
        /// </summary>
        /// <value>Gets or sets a dash phase.</value>
        [DataMember(Name="DashPhase", EmitDefaultValue=false)]
        public int? DashPhase { get; set; }

        /// <summary>
        /// Gets or sets a Color object that indicates the fill color of the graph.
        /// </summary>
        /// <value>Gets or sets a Color object that indicates the fill color of the graph.</value>
        [DataMember(Name="FillColor", EmitDefaultValue=false)]
        public Color FillColor { get; set; }

        /// <summary>
        /// Gets or sets is border doubled.
        /// </summary>
        /// <value>Gets or sets is border doubled.</value>
        [DataMember(Name="IsDoubled", EmitDefaultValue=false)]
        public bool? IsDoubled { get; set; }

        /// <summary>
        /// Gets or sets a float value that indicates the skew angle of the x-coordinate when transforming a coordinate system.
        /// </summary>
        /// <value>Gets or sets a float value that indicates the skew angle of the x-coordinate when transforming a coordinate system.</value>
        [DataMember(Name="SkewAngleX", EmitDefaultValue=false)]
        public double? SkewAngleX { get; set; }

        /// <summary>
        /// Gets or sets a float value that indicates the skew angle of the y-coordinate when transforming a coordinate system.
        /// </summary>
        /// <value>Gets or sets a float value that indicates the skew angle of the y-coordinate when transforming a coordinate system.</value>
        [DataMember(Name="SkewAngleY", EmitDefaultValue=false)]
        public double? SkewAngleY { get; set; }

        /// <summary>
        /// Gets or sets a float value that indicates the scaling rate of the x-coordinate when transforming a coordinate system.
        /// </summary>
        /// <value>Gets or sets a float value that indicates the scaling rate of the x-coordinate when transforming a coordinate system.</value>
        [DataMember(Name="ScalingRateX", EmitDefaultValue=false)]
        public double? ScalingRateX { get; set; }

        /// <summary>
        /// Gets or sets a float value that indicates the scaling rate of the y-coordinate when transforming a coordinate system.
        /// </summary>
        /// <value>Gets or sets a float value that indicates the scaling rate of the y-coordinate when transforming a coordinate system.</value>
        [DataMember(Name="ScalingRateY", EmitDefaultValue=false)]
        public double? ScalingRateY { get; set; }

        /// <summary>
        /// Gets or sets a float value that indicates the rotation angle of the coordinate system  when transforming a coordinate system.
        /// </summary>
        /// <value>Gets or sets a float value that indicates the rotation angle of the coordinate system  when transforming a coordinate system.</value>
        [DataMember(Name="RotationAngle", EmitDefaultValue=false)]
        public double? RotationAngle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GraphInfo {\n");
            sb.Append("  LineWidth: ").Append(LineWidth).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  DashArray: ").Append(DashArray).Append("\n");
            sb.Append("  DashPhase: ").Append(DashPhase).Append("\n");
            sb.Append("  FillColor: ").Append(FillColor).Append("\n");
            sb.Append("  IsDoubled: ").Append(IsDoubled).Append("\n");
            sb.Append("  SkewAngleX: ").Append(SkewAngleX).Append("\n");
            sb.Append("  SkewAngleY: ").Append(SkewAngleY).Append("\n");
            sb.Append("  ScalingRateX: ").Append(ScalingRateX).Append("\n");
            sb.Append("  ScalingRateY: ").Append(ScalingRateY).Append("\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
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
            return this.Equals(obj as GraphInfo);
        }

        /// <summary>
        /// Returns true if GraphInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of GraphInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GraphInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LineWidth == other.LineWidth ||
                    this.LineWidth != null &&
                    this.LineWidth.Equals(other.LineWidth)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.DashArray == other.DashArray ||
                    this.DashArray != null &&
                    this.DashArray.SequenceEqual(other.DashArray)
                ) && 
                (
                    this.DashPhase == other.DashPhase ||
                    this.DashPhase != null &&
                    this.DashPhase.Equals(other.DashPhase)
                ) && 
                (
                    this.FillColor == other.FillColor ||
                    this.FillColor != null &&
                    this.FillColor.Equals(other.FillColor)
                ) && 
                (
                    this.IsDoubled == other.IsDoubled ||
                    this.IsDoubled != null &&
                    this.IsDoubled.Equals(other.IsDoubled)
                ) && 
                (
                    this.SkewAngleX == other.SkewAngleX ||
                    this.SkewAngleX != null &&
                    this.SkewAngleX.Equals(other.SkewAngleX)
                ) && 
                (
                    this.SkewAngleY == other.SkewAngleY ||
                    this.SkewAngleY != null &&
                    this.SkewAngleY.Equals(other.SkewAngleY)
                ) && 
                (
                    this.ScalingRateX == other.ScalingRateX ||
                    this.ScalingRateX != null &&
                    this.ScalingRateX.Equals(other.ScalingRateX)
                ) && 
                (
                    this.ScalingRateY == other.ScalingRateY ||
                    this.ScalingRateY != null &&
                    this.ScalingRateY.Equals(other.ScalingRateY)
                ) && 
                (
                    this.RotationAngle == other.RotationAngle ||
                    this.RotationAngle != null &&
                    this.RotationAngle.Equals(other.RotationAngle)
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
                if (this.LineWidth != null)
                    hash = hash * 59 + this.LineWidth.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.DashArray != null)
                    hash = hash * 59 + this.DashArray.GetHashCode();
                if (this.DashPhase != null)
                    hash = hash * 59 + this.DashPhase.GetHashCode();
                if (this.FillColor != null)
                    hash = hash * 59 + this.FillColor.GetHashCode();
                if (this.IsDoubled != null)
                    hash = hash * 59 + this.IsDoubled.GetHashCode();
                if (this.SkewAngleX != null)
                    hash = hash * 59 + this.SkewAngleX.GetHashCode();
                if (this.SkewAngleY != null)
                    hash = hash * 59 + this.SkewAngleY.GetHashCode();
                if (this.ScalingRateX != null)
                    hash = hash * 59 + this.ScalingRateX.GetHashCode();
                if (this.ScalingRateY != null)
                    hash = hash * 59 + this.ScalingRateY.GetHashCode();
                if (this.RotationAngle != null)
                    hash = hash * 59 + this.RotationAngle.GetHashCode();
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
