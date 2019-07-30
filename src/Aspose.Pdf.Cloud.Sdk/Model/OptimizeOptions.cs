// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OptimizeOptions.cs">
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
    /// Represents Pdf optimize options.
    /// </summary>
    [DataContract]
    public partial class OptimizeOptions :  IEquatable<OptimizeOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizeOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OptimizeOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizeOptions" /> class.
        /// </summary>
        /// <param name="AllowReusePageContent">If true page contents will be reused when document is optimized for equal pages. (required)</param>
        /// <param name="CompressImages">If this flag is set to true images will be compressed in the document. compression level is specfied with ImageQuality property. (required)</param>
        /// <param name="ImageQuality">Specifie slevel of image compression when CompressIamges flag is used. (required)</param>
        /// <param name="LinkDuplcateStreams">If this flag is set to true, Resource streams will be analyzed. If duplicate streams are found (i.e. if stream contents is equal), then thes streams will be stored as one object.  This allows to decrease document size in some cases (for example, when same document was concatenedted multiple times). (required)</param>
        /// <param name="RemoveUnusedObjects">If this flag is set to true, all document objects will be checked and unused objects (i.e. objects which does not have any reference) are removed from document. (required)</param>
        /// <param name="RemoveUnusedStreams">If this flag set to true, every resource is checked on it&#39;s usage. If resource is never used, then resources is removed. This may decrease document size for example when pages were extracted from document.  (required)</param>
        /// <param name="UnembedFonts">Make fonts not embedded if set to true.  (required)</param>
        public OptimizeOptions(bool? AllowReusePageContent = default(bool?), bool? CompressImages = default(bool?), int? ImageQuality = default(int?), bool? LinkDuplcateStreams = default(bool?), bool? RemoveUnusedObjects = default(bool?), bool? RemoveUnusedStreams = default(bool?), bool? UnembedFonts = default(bool?))
        {
            // to ensure "AllowReusePageContent" is required (not null)
            if (AllowReusePageContent == null)
            {
                throw new InvalidDataException("AllowReusePageContent is a required property for OptimizeOptions and cannot be null");
            }
            else
            {
                this.AllowReusePageContent = AllowReusePageContent;
            }
            // to ensure "CompressImages" is required (not null)
            if (CompressImages == null)
            {
                throw new InvalidDataException("CompressImages is a required property for OptimizeOptions and cannot be null");
            }
            else
            {
                this.CompressImages = CompressImages;
            }
            // to ensure "ImageQuality" is required (not null)
            if (ImageQuality == null)
            {
                throw new InvalidDataException("ImageQuality is a required property for OptimizeOptions and cannot be null");
            }
            else
            {
                this.ImageQuality = ImageQuality;
            }
            // to ensure "LinkDuplcateStreams" is required (not null)
            if (LinkDuplcateStreams == null)
            {
                throw new InvalidDataException("LinkDuplcateStreams is a required property for OptimizeOptions and cannot be null");
            }
            else
            {
                this.LinkDuplcateStreams = LinkDuplcateStreams;
            }
            // to ensure "RemoveUnusedObjects" is required (not null)
            if (RemoveUnusedObjects == null)
            {
                throw new InvalidDataException("RemoveUnusedObjects is a required property for OptimizeOptions and cannot be null");
            }
            else
            {
                this.RemoveUnusedObjects = RemoveUnusedObjects;
            }
            // to ensure "RemoveUnusedStreams" is required (not null)
            if (RemoveUnusedStreams == null)
            {
                throw new InvalidDataException("RemoveUnusedStreams is a required property for OptimizeOptions and cannot be null");
            }
            else
            {
                this.RemoveUnusedStreams = RemoveUnusedStreams;
            }
            // to ensure "UnembedFonts" is required (not null)
            if (UnembedFonts == null)
            {
                throw new InvalidDataException("UnembedFonts is a required property for OptimizeOptions and cannot be null");
            }
            else
            {
                this.UnembedFonts = UnembedFonts;
            }
        }
        
        /// <summary>
        /// If true page contents will be reused when document is optimized for equal pages.
        /// </summary>
        /// <value>If true page contents will be reused when document is optimized for equal pages.</value>
        [DataMember(Name="AllowReusePageContent", EmitDefaultValue=false)]
        public bool? AllowReusePageContent { get; set; }

        /// <summary>
        /// If this flag is set to true images will be compressed in the document. compression level is specfied with ImageQuality property.
        /// </summary>
        /// <value>If this flag is set to true images will be compressed in the document. compression level is specfied with ImageQuality property.</value>
        [DataMember(Name="CompressImages", EmitDefaultValue=false)]
        public bool? CompressImages { get; set; }

        /// <summary>
        /// Specifie slevel of image compression when CompressIamges flag is used.
        /// </summary>
        /// <value>Specifie slevel of image compression when CompressIamges flag is used.</value>
        [DataMember(Name="ImageQuality", EmitDefaultValue=false)]
        public int? ImageQuality { get; set; }

        /// <summary>
        /// If this flag is set to true, Resource streams will be analyzed. If duplicate streams are found (i.e. if stream contents is equal), then thes streams will be stored as one object.  This allows to decrease document size in some cases (for example, when same document was concatenedted multiple times).
        /// </summary>
        /// <value>If this flag is set to true, Resource streams will be analyzed. If duplicate streams are found (i.e. if stream contents is equal), then thes streams will be stored as one object.  This allows to decrease document size in some cases (for example, when same document was concatenedted multiple times).</value>
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
        /// Make fonts not embedded if set to true. 
        /// </summary>
        /// <value>Make fonts not embedded if set to true. </value>
        [DataMember(Name="UnembedFonts", EmitDefaultValue=false)]
        public bool? UnembedFonts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptimizeOptions {\n");
            sb.Append("  AllowReusePageContent: ").Append(AllowReusePageContent).Append("\n");
            sb.Append("  CompressImages: ").Append(CompressImages).Append("\n");
            sb.Append("  ImageQuality: ").Append(ImageQuality).Append("\n");
            sb.Append("  LinkDuplcateStreams: ").Append(LinkDuplcateStreams).Append("\n");
            sb.Append("  RemoveUnusedObjects: ").Append(RemoveUnusedObjects).Append("\n");
            sb.Append("  RemoveUnusedStreams: ").Append(RemoveUnusedStreams).Append("\n");
            sb.Append("  UnembedFonts: ").Append(UnembedFonts).Append("\n");
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
