// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TiffExportOptions.cs">
//   Copyright (c) 2018 Aspose.Pdf for Cloud
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
    /// Used for tiff export options setting.
    /// </summary>
    [DataContract]
    public partial class TiffExportOptions :  IEquatable<TiffExportOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TiffExportOptions" /> class.
        /// </summary>
        /// <param name="Brightness">Image brightness..</param>
        /// <param name="Compression">Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None..</param>
        /// <param name="ColorDepth">Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp..</param>
        /// <param name="LeftMargin">Left image margin..</param>
        /// <param name="RightMargin">Right image margin..</param>
        /// <param name="TopMargin">Top image margin..</param>
        /// <param name="BottomMargin">Bottom image margin..</param>
        /// <param name="Orientation">Image orientation. Possible values are: None, Landscape, Portait..</param>
        /// <param name="SkipBlankPages">Skip blank pages flag..</param>
        /// <param name="Width">Image width..</param>
        /// <param name="Height">Image height..</param>
        /// <param name="XResolution">Horizontal resolution..</param>
        /// <param name="YResolution">Vertical resolution..</param>
        /// <param name="PageIndex">Start page to export..</param>
        /// <param name="PageCount">Number of pages to export..</param>
        /// <param name="ResultFile">Resulting image file..</param>
        public TiffExportOptions(double? Brightness = default(double?), CompressionType Compression = default(CompressionType), ColorDepth ColorDepth = default(ColorDepth), int? LeftMargin = default(int?), int? RightMargin = default(int?), int? TopMargin = default(int?), int? BottomMargin = default(int?), ShapeType Orientation = default(ShapeType), bool? SkipBlankPages = default(bool?), int? Width = default(int?), int? Height = default(int?), int? XResolution = default(int?), int? YResolution = default(int?), int? PageIndex = default(int?), int? PageCount = default(int?), string ResultFile = default(string))
        {
            this.Brightness = Brightness;
            this.Compression = Compression;
            this.ColorDepth = ColorDepth;
            this.LeftMargin = LeftMargin;
            this.RightMargin = RightMargin;
            this.TopMargin = TopMargin;
            this.BottomMargin = BottomMargin;
            this.Orientation = Orientation;
            this.SkipBlankPages = SkipBlankPages;
            this.Width = Width;
            this.Height = Height;
            this.XResolution = XResolution;
            this.YResolution = YResolution;
            this.PageIndex = PageIndex;
            this.PageCount = PageCount;
            this.ResultFile = ResultFile;
        }
        
        /// <summary>
        /// Image brightness.
        /// </summary>
        /// <value>Image brightness.</value>
        [DataMember(Name="Brightness", EmitDefaultValue=false)]
        public double? Brightness { get; set; }

        /// <summary>
        /// Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None.
        /// </summary>
        /// <value>Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None.</value>
        [DataMember(Name="Compression", EmitDefaultValue=false)]
        public CompressionType Compression { get; set; }

        /// <summary>
        /// Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp.
        /// </summary>
        /// <value>Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp.</value>
        [DataMember(Name="ColorDepth", EmitDefaultValue=false)]
        public ColorDepth ColorDepth { get; set; }

        /// <summary>
        /// Left image margin.
        /// </summary>
        /// <value>Left image margin.</value>
        [DataMember(Name="LeftMargin", EmitDefaultValue=false)]
        public int? LeftMargin { get; set; }

        /// <summary>
        /// Right image margin.
        /// </summary>
        /// <value>Right image margin.</value>
        [DataMember(Name="RightMargin", EmitDefaultValue=false)]
        public int? RightMargin { get; set; }

        /// <summary>
        /// Top image margin.
        /// </summary>
        /// <value>Top image margin.</value>
        [DataMember(Name="TopMargin", EmitDefaultValue=false)]
        public int? TopMargin { get; set; }

        /// <summary>
        /// Bottom image margin.
        /// </summary>
        /// <value>Bottom image margin.</value>
        [DataMember(Name="BottomMargin", EmitDefaultValue=false)]
        public int? BottomMargin { get; set; }

        /// <summary>
        /// Image orientation. Possible values are: None, Landscape, Portait.
        /// </summary>
        /// <value>Image orientation. Possible values are: None, Landscape, Portait.</value>
        [DataMember(Name="Orientation", EmitDefaultValue=false)]
        public ShapeType Orientation { get; set; }

        /// <summary>
        /// Skip blank pages flag.
        /// </summary>
        /// <value>Skip blank pages flag.</value>
        [DataMember(Name="SkipBlankPages", EmitDefaultValue=false)]
        public bool? SkipBlankPages { get; set; }

        /// <summary>
        /// Image width.
        /// </summary>
        /// <value>Image width.</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Image height.
        /// </summary>
        /// <value>Image height.</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Horizontal resolution.
        /// </summary>
        /// <value>Horizontal resolution.</value>
        [DataMember(Name="XResolution", EmitDefaultValue=false)]
        public int? XResolution { get; set; }

        /// <summary>
        /// Vertical resolution.
        /// </summary>
        /// <value>Vertical resolution.</value>
        [DataMember(Name="YResolution", EmitDefaultValue=false)]
        public int? YResolution { get; set; }

        /// <summary>
        /// Start page to export.
        /// </summary>
        /// <value>Start page to export.</value>
        [DataMember(Name="PageIndex", EmitDefaultValue=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// Number of pages to export.
        /// </summary>
        /// <value>Number of pages to export.</value>
        [DataMember(Name="PageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// Resulting image file.
        /// </summary>
        /// <value>Resulting image file.</value>
        [DataMember(Name="ResultFile", EmitDefaultValue=false)]
        public string ResultFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TiffExportOptions {\n");
            sb.Append("  Brightness: ").Append(Brightness).Append("\n");
            sb.Append("  Compression: ").Append(Compression).Append("\n");
            sb.Append("  ColorDepth: ").Append(ColorDepth).Append("\n");
            sb.Append("  LeftMargin: ").Append(LeftMargin).Append("\n");
            sb.Append("  RightMargin: ").Append(RightMargin).Append("\n");
            sb.Append("  TopMargin: ").Append(TopMargin).Append("\n");
            sb.Append("  BottomMargin: ").Append(BottomMargin).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  SkipBlankPages: ").Append(SkipBlankPages).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  XResolution: ").Append(XResolution).Append("\n");
            sb.Append("  YResolution: ").Append(YResolution).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  ResultFile: ").Append(ResultFile).Append("\n");
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
            return this.Equals(obj as TiffExportOptions);
        }

        /// <summary>
        /// Returns true if TiffExportOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of TiffExportOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TiffExportOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Brightness == other.Brightness ||
                    this.Brightness != null &&
                    this.Brightness.Equals(other.Brightness)
                ) && 
                (
                    this.Compression == other.Compression ||
                    this.Compression != null &&
                    this.Compression.Equals(other.Compression)
                ) && 
                (
                    this.ColorDepth == other.ColorDepth ||
                    this.ColorDepth != null &&
                    this.ColorDepth.Equals(other.ColorDepth)
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
                    this.Orientation == other.Orientation ||
                    this.Orientation != null &&
                    this.Orientation.Equals(other.Orientation)
                ) && 
                (
                    this.SkipBlankPages == other.SkipBlankPages ||
                    this.SkipBlankPages != null &&
                    this.SkipBlankPages.Equals(other.SkipBlankPages)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.XResolution == other.XResolution ||
                    this.XResolution != null &&
                    this.XResolution.Equals(other.XResolution)
                ) && 
                (
                    this.YResolution == other.YResolution ||
                    this.YResolution != null &&
                    this.YResolution.Equals(other.YResolution)
                ) && 
                (
                    this.PageIndex == other.PageIndex ||
                    this.PageIndex != null &&
                    this.PageIndex.Equals(other.PageIndex)
                ) && 
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) && 
                (
                    this.ResultFile == other.ResultFile ||
                    this.ResultFile != null &&
                    this.ResultFile.Equals(other.ResultFile)
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
                if (this.Brightness != null)
                    hash = hash * 59 + this.Brightness.GetHashCode();
                if (this.Compression != null)
                    hash = hash * 59 + this.Compression.GetHashCode();
                if (this.ColorDepth != null)
                    hash = hash * 59 + this.ColorDepth.GetHashCode();
                if (this.LeftMargin != null)
                    hash = hash * 59 + this.LeftMargin.GetHashCode();
                if (this.RightMargin != null)
                    hash = hash * 59 + this.RightMargin.GetHashCode();
                if (this.TopMargin != null)
                    hash = hash * 59 + this.TopMargin.GetHashCode();
                if (this.BottomMargin != null)
                    hash = hash * 59 + this.BottomMargin.GetHashCode();
                if (this.Orientation != null)
                    hash = hash * 59 + this.Orientation.GetHashCode();
                if (this.SkipBlankPages != null)
                    hash = hash * 59 + this.SkipBlankPages.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                if (this.XResolution != null)
                    hash = hash * 59 + this.XResolution.GetHashCode();
                if (this.YResolution != null)
                    hash = hash * 59 + this.YResolution.GetHashCode();
                if (this.PageIndex != null)
                    hash = hash * 59 + this.PageIndex.GetHashCode();
                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();
                if (this.ResultFile != null)
                    hash = hash * 59 + this.ResultFile.GetHashCode();
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
