// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageFragment.cs">
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
    /// Represents Image Fragment DTO.
    /// </summary>
    [DataContract]
    public partial class ImageFragment :  IEquatable<ImageFragment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFragment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageFragment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFragment" /> class.
        /// </summary>
        /// <param name="ImageFile">Gets or sets full storage path of image. (required)</param>
        /// <param name="FixWidth">Gets or sets fix width of the image.</param>
        /// <param name="FixHeight">Gets or sets fix height of the image.</param>
        /// <param name="HorizontalAlignment">Gets or sets horizontal alignment of the image.</param>
        /// <param name="VerticalAlignment">Gets or sets vertical alignment of the image.</param>
        /// <param name="ImageScale">Gets or sets ImageScale of the image.</param>
        /// <param name="Margin">Gets or sets Margin of the image.</param>
        public ImageFragment(string ImageFile = default(string), double? FixWidth = default(double?), double? FixHeight = default(double?), HorizontalAlignment HorizontalAlignment = default(HorizontalAlignment), VerticalAlignment VerticalAlignment = default(VerticalAlignment), double? ImageScale = default(double?), MarginInfo Margin = default(MarginInfo))
        {
            // to ensure "ImageFile" is required (not null)
            if (ImageFile == null)
            {
                throw new InvalidDataException("ImageFile is a required property for ImageFragment and cannot be null");
            }
            else
            {
                this.ImageFile = ImageFile;
            }
            this.FixWidth = FixWidth;
            this.FixHeight = FixHeight;
            this.HorizontalAlignment = HorizontalAlignment;
            this.VerticalAlignment = VerticalAlignment;
            this.ImageScale = ImageScale;
            this.Margin = Margin;
        }
        
        /// <summary>
        /// Gets or sets full storage path of image.
        /// </summary>
        /// <value>Gets or sets full storage path of image.</value>
        [DataMember(Name="ImageFile", EmitDefaultValue=false)]
        public string ImageFile { get; set; }

        /// <summary>
        /// Gets or sets fix width of the image.
        /// </summary>
        /// <value>Gets or sets fix width of the image.</value>
        [DataMember(Name="FixWidth", EmitDefaultValue=false)]
        public double? FixWidth { get; set; }

        /// <summary>
        /// Gets or sets fix height of the image.
        /// </summary>
        /// <value>Gets or sets fix height of the image.</value>
        [DataMember(Name="FixHeight", EmitDefaultValue=false)]
        public double? FixHeight { get; set; }

        /// <summary>
        /// Gets or sets horizontal alignment of the image.
        /// </summary>
        /// <value>Gets or sets horizontal alignment of the image.</value>
        [DataMember(Name="HorizontalAlignment", EmitDefaultValue=true)]
        public HorizontalAlignment HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets vertical alignment of the image.
        /// </summary>
        /// <value>Gets or sets vertical alignment of the image.</value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=true)]
        public VerticalAlignment VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets ImageScale of the image.
        /// </summary>
        /// <value>Gets or sets ImageScale of the image.</value>
        [DataMember(Name="ImageScale", EmitDefaultValue=false)]
        public double? ImageScale { get; set; }

        /// <summary>
        /// Gets or sets Margin of the image.
        /// </summary>
        /// <value>Gets or sets Margin of the image.</value>
        [DataMember(Name="Margin", EmitDefaultValue=false)]
        public MarginInfo Margin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageFragment {\n");
            sb.Append("  ImageFile: ").Append(ImageFile).Append("\n");
            sb.Append("  FixWidth: ").Append(FixWidth).Append("\n");
            sb.Append("  FixHeight: ").Append(FixHeight).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(HorizontalAlignment).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  ImageScale: ").Append(ImageScale).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
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
            return this.Equals(obj as ImageFragment);
        }

        /// <summary>
        /// Returns true if ImageFragment instances are equal
        /// </summary>
        /// <param name="other">Instance of ImageFragment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageFragment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ImageFile == other.ImageFile ||
                    this.ImageFile != null &&
                    this.ImageFile.Equals(other.ImageFile)
                ) && 
                (
                    this.FixWidth == other.FixWidth ||
                    this.FixWidth != null &&
                    this.FixWidth.Equals(other.FixWidth)
                ) && 
                (
                    this.FixHeight == other.FixHeight ||
                    this.FixHeight != null &&
                    this.FixHeight.Equals(other.FixHeight)
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
                    this.ImageScale == other.ImageScale ||
                    this.ImageScale != null &&
                    this.ImageScale.Equals(other.ImageScale)
                ) && 
                (
                    this.Margin == other.Margin ||
                    this.Margin != null &&
                    this.Margin.Equals(other.Margin)
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
                if (this.ImageFile != null)
                    hash = hash * 59 + this.ImageFile.GetHashCode();
                if (this.FixWidth != null)
                    hash = hash * 59 + this.FixWidth.GetHashCode();
                if (this.FixHeight != null)
                    hash = hash * 59 + this.FixHeight.GetHashCode();
                if (this.HorizontalAlignment != null)
                    hash = hash * 59 + this.HorizontalAlignment.GetHashCode();
                if (this.VerticalAlignment != null)
                    hash = hash * 59 + this.VerticalAlignment.GetHashCode();
                if (this.ImageScale != null)
                    hash = hash * 59 + this.ImageScale.GetHashCode();
                if (this.Margin != null)
                    hash = hash * 59 + this.Margin.GetHashCode();
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
            // ImageFile (string) minLength
            if(this.ImageFile != null && this.ImageFile.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageFile, length must be greater than 1.", new [] { "ImageFile" });
            }

            yield break;
        }
    }

}
