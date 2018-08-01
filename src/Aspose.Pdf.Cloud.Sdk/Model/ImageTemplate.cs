// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageTemplate.cs">
//   Copyright (c) 2018 Aspose.PDF Cloud
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
    /// Template of image.
    /// </summary>
    [DataContract]
    public partial class ImageTemplate :  IEquatable<ImageTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTemplate" /> class.
        /// </summary>
        /// <param name="ImagePath">A path for image. (required).</param>
        /// <param name="ImageSrcType">Image type. (required).</param>
        /// <param name="LeftMargin">LeftMargin.</param>
        /// <param name="RightMargin">RightMargin.</param>
        /// <param name="TopMargin">TopMargin.</param>
        /// <param name="BottomMargin">BottomMargin.</param>
        /// <param name="PageWidth">PageWidth.</param>
        /// <param name="PageHeight">PageHeight.</param>
        /// <param name="MarginInfo">MarginInfo.</param>
        public ImageTemplate(string ImagePath = default(string), ImageSrcType ImageSrcType = default(ImageSrcType), double? LeftMargin = default(double?), double? RightMargin = default(double?), double? TopMargin = default(double?), double? BottomMargin = default(double?), double? PageWidth = default(double?), double? PageHeight = default(double?), MarginInfo MarginInfo = default(MarginInfo))
        {
            // to ensure "ImagePath" is required (not null)
            if (ImagePath == null)
            {
                throw new InvalidDataException("ImagePath is a required property for ImageTemplate and cannot be null");
            }
            else
            {
                this.ImagePath = ImagePath;
            }
            // to ensure "ImageSrcType" is required (not null)
            if (ImageSrcType == null)
            {
                throw new InvalidDataException("ImageSrcType is a required property for ImageTemplate and cannot be null");
            }
            else
            {
                this.ImageSrcType = ImageSrcType;
            }
            this.LeftMargin = LeftMargin;
            this.RightMargin = RightMargin;
            this.TopMargin = TopMargin;
            this.BottomMargin = BottomMargin;
            this.PageWidth = PageWidth;
            this.PageHeight = PageHeight;
            this.MarginInfo = MarginInfo;
        }
        
        /// <summary>
        /// A path for image.
        /// </summary>
        /// <value>A path for image.</value>
        [DataMember(Name="ImagePath", EmitDefaultValue=false)]
        public string ImagePath { get; set; }

        /// <summary>
        /// Image type.
        /// </summary>
        /// <value>Image type.</value>
        [DataMember(Name="ImageSrcType", EmitDefaultValue=false)]
        public ImageSrcType ImageSrcType { get; set; }

        /// <summary>
        /// Gets or Sets LeftMargin
        /// </summary>
        [DataMember(Name="LeftMargin", EmitDefaultValue=false)]
        public double? LeftMargin { get; set; }

        /// <summary>
        /// Gets or Sets RightMargin
        /// </summary>
        [DataMember(Name="RightMargin", EmitDefaultValue=false)]
        public double? RightMargin { get; set; }

        /// <summary>
        /// Gets or Sets TopMargin
        /// </summary>
        [DataMember(Name="TopMargin", EmitDefaultValue=false)]
        public double? TopMargin { get; set; }

        /// <summary>
        /// Gets or Sets BottomMargin
        /// </summary>
        [DataMember(Name="BottomMargin", EmitDefaultValue=false)]
        public double? BottomMargin { get; set; }

        /// <summary>
        /// Gets or Sets PageWidth
        /// </summary>
        [DataMember(Name="PageWidth", EmitDefaultValue=false)]
        public double? PageWidth { get; set; }

        /// <summary>
        /// Gets or Sets PageHeight
        /// </summary>
        [DataMember(Name="PageHeight", EmitDefaultValue=false)]
        public double? PageHeight { get; set; }

        /// <summary>
        /// Gets or Sets MarginInfo
        /// </summary>
        [DataMember(Name="MarginInfo", EmitDefaultValue=false)]
        public MarginInfo MarginInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageTemplate {\n");
            sb.Append("  ImagePath: ").Append(ImagePath).Append("\n");
            sb.Append("  ImageSrcType: ").Append(ImageSrcType).Append("\n");
            sb.Append("  LeftMargin: ").Append(LeftMargin).Append("\n");
            sb.Append("  RightMargin: ").Append(RightMargin).Append("\n");
            sb.Append("  TopMargin: ").Append(TopMargin).Append("\n");
            sb.Append("  BottomMargin: ").Append(BottomMargin).Append("\n");
            sb.Append("  PageWidth: ").Append(PageWidth).Append("\n");
            sb.Append("  PageHeight: ").Append(PageHeight).Append("\n");
            sb.Append("  MarginInfo: ").Append(MarginInfo).Append("\n");
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
            return this.Equals(obj as ImageTemplate);
        }

        /// <summary>
        /// Returns true if ImageTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of ImageTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ImagePath == other.ImagePath ||
                    this.ImagePath != null &&
                    this.ImagePath.Equals(other.ImagePath)
                ) && 
                (
                    this.ImageSrcType == other.ImageSrcType ||
                    this.ImageSrcType != null &&
                    this.ImageSrcType.Equals(other.ImageSrcType)
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
                    this.PageWidth == other.PageWidth ||
                    this.PageWidth != null &&
                    this.PageWidth.Equals(other.PageWidth)
                ) && 
                (
                    this.PageHeight == other.PageHeight ||
                    this.PageHeight != null &&
                    this.PageHeight.Equals(other.PageHeight)
                ) && 
                (
                    this.MarginInfo == other.MarginInfo ||
                    this.MarginInfo != null &&
                    this.MarginInfo.Equals(other.MarginInfo)
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
                if (this.ImagePath != null)
                    hash = hash * 59 + this.ImagePath.GetHashCode();
                if (this.ImageSrcType != null)
                    hash = hash * 59 + this.ImageSrcType.GetHashCode();
                if (this.LeftMargin != null)
                    hash = hash * 59 + this.LeftMargin.GetHashCode();
                if (this.RightMargin != null)
                    hash = hash * 59 + this.RightMargin.GetHashCode();
                if (this.TopMargin != null)
                    hash = hash * 59 + this.TopMargin.GetHashCode();
                if (this.BottomMargin != null)
                    hash = hash * 59 + this.BottomMargin.GetHashCode();
                if (this.PageWidth != null)
                    hash = hash * 59 + this.PageWidth.GetHashCode();
                if (this.PageHeight != null)
                    hash = hash * 59 + this.PageHeight.GetHashCode();
                if (this.MarginInfo != null)
                    hash = hash * 59 + this.MarginInfo.GetHashCode();
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
