// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OptimizeOptions.cs">
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
    /// Represents Pdf optimize options.
    /// </summary>
    [DataContract]
    public partial class OptimizeOptions :  IEquatable<OptimizeOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizeOptions" /> class.
        /// </summary>
        /// <param name="Password">Specifies document password (if any) encoded with base-64.</param>
        /// <param name="AllowReusePageContent">If true page contents will be reused when document is optimized for equal pages. LinkDuplcateStreams option must be set to true.</param>
        /// <param name="CompressImages">If this flag is set to true images will be compressed in the document. Compression level is specified with ImageQuality property.</param>
        /// <param name="ImageQuality">Specifies level of image compression when CompressImages flag is used.</param>
        /// <param name="LinkDuplcateStreams">If this flag is set to true, Resource streams will be analyzed. If duplicate streams are found (i.e. if stream contents is equal), then thees streams will be stored as one object.  This allows to decrease document size in some cases (for example, when same document was concatenated multiple times).</param>
        /// <param name="RemoveUnusedObjects">If this flag is set to true, all document objects will be checked and unused objects (i.e. objects which does not have any reference) are removed from document.</param>
        /// <param name="RemoveUnusedStreams">If this flag set to true, every resource is checked on it&#39;s usage. If resource is never used, then resources is removed. This may decrease document size for example when pages were extracted from document. </param>
        /// <param name="UnembedFonts">Make fonts not embedded if set to true. Unembedding a font means removing the embedded byte stream data of the font included in a PDF document.</param>
        /// <param name="ResizeImages">If this flag set to true and CompressImages is true images will be resized if image resolution is greater then specified MaxResolution parameter.</param>
        /// <param name="MaxResolution">Specifies maximum resolution of images. If image has higher resolution it will be scaled.</param>
        /// <param name="SubsetFonts">Fonts will be converted into subsets if set to true. Only those characters that are actually used in the layout are stored in the PDF. </param>
        /// <param name="RemovePrivateInfo">Remove private information (page piece info).</param>
        /// <param name="ImageEncoding">Image encode which will be used.</param>
        /// <param name="ImageCompressionVersion">Version of compression algorithm. Possible values are: \&quot;Standard\&quot; - standard compression, \&quot;Fast\&quot; - fast (improved compression which is faster then standard but may be applicable not for all images), \&quot;Mixed\&quot; - mixed (standard compression is applied to images which can not be compressed by  faster algorithm, this may give best compression but more slow then \&quot;Fast\&quot; algorithm. Version \&quot;Fast\&quot; is not applicable for resizing images (standard method will be used). Default is \&quot;Standard\&quot;.</param>
        public OptimizeOptions(string Password = default(string), bool? AllowReusePageContent = default(bool?), bool? CompressImages = default(bool?), int? ImageQuality = default(int?), bool? LinkDuplcateStreams = default(bool?), bool? RemoveUnusedObjects = default(bool?), bool? RemoveUnusedStreams = default(bool?), bool? UnembedFonts = default(bool?), bool? ResizeImages = default(bool?), int? MaxResolution = default(int?), bool? SubsetFonts = default(bool?), bool? RemovePrivateInfo = default(bool?), ImageEncoding ImageEncoding = default(ImageEncoding), ImageCompressionVersion ImageCompressionVersion = default(ImageCompressionVersion))
        {
            this.Password = Password;
            this.AllowReusePageContent = AllowReusePageContent;
            this.CompressImages = CompressImages;
            this.ImageQuality = ImageQuality;
            this.LinkDuplcateStreams = LinkDuplcateStreams;
            this.RemoveUnusedObjects = RemoveUnusedObjects;
            this.RemoveUnusedStreams = RemoveUnusedStreams;
            this.UnembedFonts = UnembedFonts;
            this.ResizeImages = ResizeImages;
            this.MaxResolution = MaxResolution;
            this.SubsetFonts = SubsetFonts;
            this.RemovePrivateInfo = RemovePrivateInfo;
            this.ImageEncoding = ImageEncoding;
            this.ImageCompressionVersion = ImageCompressionVersion;
        }
        
        /// <summary>
        /// Specifies document password (if any) encoded with base-64.
        /// </summary>
        /// <value>Specifies document password (if any) encoded with base-64.</value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// If true page contents will be reused when document is optimized for equal pages. LinkDuplcateStreams option must be set to true.
        /// </summary>
        /// <value>If true page contents will be reused when document is optimized for equal pages. LinkDuplcateStreams option must be set to true.</value>
        [DataMember(Name="AllowReusePageContent", EmitDefaultValue=false)]
        public bool? AllowReusePageContent { get; set; }

        /// <summary>
        /// If this flag is set to true images will be compressed in the document. Compression level is specified with ImageQuality property.
        /// </summary>
        /// <value>If this flag is set to true images will be compressed in the document. Compression level is specified with ImageQuality property.</value>
        [DataMember(Name="CompressImages", EmitDefaultValue=false)]
        public bool? CompressImages { get; set; }

        /// <summary>
        /// Specifies level of image compression when CompressImages flag is used.
        /// </summary>
        /// <value>Specifies level of image compression when CompressImages flag is used.</value>
        [DataMember(Name="ImageQuality", EmitDefaultValue=false)]
        public int? ImageQuality { get; set; }

        /// <summary>
        /// If this flag is set to true, Resource streams will be analyzed. If duplicate streams are found (i.e. if stream contents is equal), then thees streams will be stored as one object.  This allows to decrease document size in some cases (for example, when same document was concatenated multiple times).
        /// </summary>
        /// <value>If this flag is set to true, Resource streams will be analyzed. If duplicate streams are found (i.e. if stream contents is equal), then thees streams will be stored as one object.  This allows to decrease document size in some cases (for example, when same document was concatenated multiple times).</value>
        [DataMember(Name="LinkDuplcateStreams", EmitDefaultValue=false)]
        public bool? LinkDuplcateStreams { get; set; }

        /// <summary>
        /// If this flag is set to true, all document objects will be checked and unused objects (i.e. objects which does not have any reference) are removed from document.
        /// </summary>
        /// <value>If this flag is set to true, all document objects will be checked and unused objects (i.e. objects which does not have any reference) are removed from document.</value>
        [DataMember(Name="RemoveUnusedObjects", EmitDefaultValue=false)]
        public bool? RemoveUnusedObjects { get; set; }

        /// <summary>
        /// If this flag set to true, every resource is checked on it&#39;s usage. If resource is never used, then resources is removed. This may decrease document size for example when pages were extracted from document. 
        /// </summary>
        /// <value>If this flag set to true, every resource is checked on it&#39;s usage. If resource is never used, then resources is removed. This may decrease document size for example when pages were extracted from document. </value>
        [DataMember(Name="RemoveUnusedStreams", EmitDefaultValue=false)]
        public bool? RemoveUnusedStreams { get; set; }

        /// <summary>
        /// Make fonts not embedded if set to true. Unembedding a font means removing the embedded byte stream data of the font included in a PDF document.
        /// </summary>
        /// <value>Make fonts not embedded if set to true. Unembedding a font means removing the embedded byte stream data of the font included in a PDF document.</value>
        [DataMember(Name="UnembedFonts", EmitDefaultValue=false)]
        public bool? UnembedFonts { get; set; }

        /// <summary>
        /// If this flag set to true and CompressImages is true images will be resized if image resolution is greater then specified MaxResolution parameter.
        /// </summary>
        /// <value>If this flag set to true and CompressImages is true images will be resized if image resolution is greater then specified MaxResolution parameter.</value>
        [DataMember(Name="ResizeImages", EmitDefaultValue=false)]
        public bool? ResizeImages { get; set; }

        /// <summary>
        /// Specifies maximum resolution of images. If image has higher resolution it will be scaled.
        /// </summary>
        /// <value>Specifies maximum resolution of images. If image has higher resolution it will be scaled.</value>
        [DataMember(Name="MaxResolution", EmitDefaultValue=false)]
        public int? MaxResolution { get; set; }

        /// <summary>
        /// Fonts will be converted into subsets if set to true. Only those characters that are actually used in the layout are stored in the PDF. 
        /// </summary>
        /// <value>Fonts will be converted into subsets if set to true. Only those characters that are actually used in the layout are stored in the PDF. </value>
        [DataMember(Name="SubsetFonts", EmitDefaultValue=false)]
        public bool? SubsetFonts { get; set; }

        /// <summary>
        /// Remove private information (page piece info).
        /// </summary>
        /// <value>Remove private information (page piece info).</value>
        [DataMember(Name="RemovePrivateInfo", EmitDefaultValue=false)]
        public bool? RemovePrivateInfo { get; set; }

        /// <summary>
        /// Image encode which will be used.
        /// </summary>
        /// <value>Image encode which will be used.</value>
        [DataMember(Name="ImageEncoding", EmitDefaultValue=true)]
        public ImageEncoding ImageEncoding { get; set; }

        /// <summary>
        /// Version of compression algorithm. Possible values are: \&quot;Standard\&quot; - standard compression, \&quot;Fast\&quot; - fast (improved compression which is faster then standard but may be applicable not for all images), \&quot;Mixed\&quot; - mixed (standard compression is applied to images which can not be compressed by  faster algorithm, this may give best compression but more slow then \&quot;Fast\&quot; algorithm. Version \&quot;Fast\&quot; is not applicable for resizing images (standard method will be used). Default is \&quot;Standard\&quot;.
        /// </summary>
        /// <value>Version of compression algorithm. Possible values are: \&quot;Standard\&quot; - standard compression, \&quot;Fast\&quot; - fast (improved compression which is faster then standard but may be applicable not for all images), \&quot;Mixed\&quot; - mixed (standard compression is applied to images which can not be compressed by  faster algorithm, this may give best compression but more slow then \&quot;Fast\&quot; algorithm. Version \&quot;Fast\&quot; is not applicable for resizing images (standard method will be used). Default is \&quot;Standard\&quot;.</value>
        [DataMember(Name="ImageCompressionVersion", EmitDefaultValue=true)]
        public ImageCompressionVersion ImageCompressionVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptimizeOptions {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  AllowReusePageContent: ").Append(AllowReusePageContent).Append("\n");
            sb.Append("  CompressImages: ").Append(CompressImages).Append("\n");
            sb.Append("  ImageQuality: ").Append(ImageQuality).Append("\n");
            sb.Append("  LinkDuplcateStreams: ").Append(LinkDuplcateStreams).Append("\n");
            sb.Append("  RemoveUnusedObjects: ").Append(RemoveUnusedObjects).Append("\n");
            sb.Append("  RemoveUnusedStreams: ").Append(RemoveUnusedStreams).Append("\n");
            sb.Append("  UnembedFonts: ").Append(UnembedFonts).Append("\n");
            sb.Append("  ResizeImages: ").Append(ResizeImages).Append("\n");
            sb.Append("  MaxResolution: ").Append(MaxResolution).Append("\n");
            sb.Append("  SubsetFonts: ").Append(SubsetFonts).Append("\n");
            sb.Append("  RemovePrivateInfo: ").Append(RemovePrivateInfo).Append("\n");
            sb.Append("  ImageEncoding: ").Append(ImageEncoding).Append("\n");
            sb.Append("  ImageCompressionVersion: ").Append(ImageCompressionVersion).Append("\n");
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
            return this.Equals(obj as OptimizeOptions);
        }

        /// <summary>
        /// Returns true if OptimizeOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of OptimizeOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptimizeOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.AllowReusePageContent == other.AllowReusePageContent ||
                    this.AllowReusePageContent != null &&
                    this.AllowReusePageContent.Equals(other.AllowReusePageContent)
                ) && 
                (
                    this.CompressImages == other.CompressImages ||
                    this.CompressImages != null &&
                    this.CompressImages.Equals(other.CompressImages)
                ) && 
                (
                    this.ImageQuality == other.ImageQuality ||
                    this.ImageQuality != null &&
                    this.ImageQuality.Equals(other.ImageQuality)
                ) && 
                (
                    this.LinkDuplcateStreams == other.LinkDuplcateStreams ||
                    this.LinkDuplcateStreams != null &&
                    this.LinkDuplcateStreams.Equals(other.LinkDuplcateStreams)
                ) && 
                (
                    this.RemoveUnusedObjects == other.RemoveUnusedObjects ||
                    this.RemoveUnusedObjects != null &&
                    this.RemoveUnusedObjects.Equals(other.RemoveUnusedObjects)
                ) && 
                (
                    this.RemoveUnusedStreams == other.RemoveUnusedStreams ||
                    this.RemoveUnusedStreams != null &&
                    this.RemoveUnusedStreams.Equals(other.RemoveUnusedStreams)
                ) && 
                (
                    this.UnembedFonts == other.UnembedFonts ||
                    this.UnembedFonts != null &&
                    this.UnembedFonts.Equals(other.UnembedFonts)
                ) && 
                (
                    this.ResizeImages == other.ResizeImages ||
                    this.ResizeImages != null &&
                    this.ResizeImages.Equals(other.ResizeImages)
                ) && 
                (
                    this.MaxResolution == other.MaxResolution ||
                    this.MaxResolution != null &&
                    this.MaxResolution.Equals(other.MaxResolution)
                ) && 
                (
                    this.SubsetFonts == other.SubsetFonts ||
                    this.SubsetFonts != null &&
                    this.SubsetFonts.Equals(other.SubsetFonts)
                ) && 
                (
                    this.RemovePrivateInfo == other.RemovePrivateInfo ||
                    this.RemovePrivateInfo != null &&
                    this.RemovePrivateInfo.Equals(other.RemovePrivateInfo)
                ) && 
                (
                    this.ImageEncoding == other.ImageEncoding ||
                    this.ImageEncoding != null &&
                    this.ImageEncoding.Equals(other.ImageEncoding)
                ) && 
                (
                    this.ImageCompressionVersion == other.ImageCompressionVersion ||
                    this.ImageCompressionVersion != null &&
                    this.ImageCompressionVersion.Equals(other.ImageCompressionVersion)
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
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.AllowReusePageContent != null)
                    hash = hash * 59 + this.AllowReusePageContent.GetHashCode();
                if (this.CompressImages != null)
                    hash = hash * 59 + this.CompressImages.GetHashCode();
                if (this.ImageQuality != null)
                    hash = hash * 59 + this.ImageQuality.GetHashCode();
                if (this.LinkDuplcateStreams != null)
                    hash = hash * 59 + this.LinkDuplcateStreams.GetHashCode();
                if (this.RemoveUnusedObjects != null)
                    hash = hash * 59 + this.RemoveUnusedObjects.GetHashCode();
                if (this.RemoveUnusedStreams != null)
                    hash = hash * 59 + this.RemoveUnusedStreams.GetHashCode();
                if (this.UnembedFonts != null)
                    hash = hash * 59 + this.UnembedFonts.GetHashCode();
                if (this.ResizeImages != null)
                    hash = hash * 59 + this.ResizeImages.GetHashCode();
                if (this.MaxResolution != null)
                    hash = hash * 59 + this.MaxResolution.GetHashCode();
                if (this.SubsetFonts != null)
                    hash = hash * 59 + this.SubsetFonts.GetHashCode();
                if (this.RemovePrivateInfo != null)
                    hash = hash * 59 + this.RemovePrivateInfo.GetHashCode();
                if (this.ImageEncoding != null)
                    hash = hash * 59 + this.ImageEncoding.GetHashCode();
                if (this.ImageCompressionVersion != null)
                    hash = hash * 59 + this.ImageCompressionVersion.GetHashCode();
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
