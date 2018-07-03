// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageTemplatesRequest.cs">
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
    /// Create document from images request.
    /// </summary>
    [DataContract]
    public partial class ImageTemplatesRequest :  IEquatable<ImageTemplatesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTemplatesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageTemplatesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTemplatesRequest" /> class.
        /// </summary>
        /// <param name="IsOCR">Using OCR function. (required).</param>
        /// <param name="OCRLangs">Language for recognition possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra      or thier combination e.g. eng+rus.</param>
        /// <param name="ImagesList">A List of objects describing images to be added. (required).</param>
        public ImageTemplatesRequest(bool? IsOCR = default(bool?), string OCRLangs = default(string), List<ImageTemplate> ImagesList = default(List<ImageTemplate>))
        {
            // to ensure "IsOCR" is required (not null)
            if (IsOCR == null)
            {
                throw new InvalidDataException("IsOCR is a required property for ImageTemplatesRequest and cannot be null");
            }
            else
            {
                this.IsOCR = IsOCR;
            }
            // to ensure "ImagesList" is required (not null)
            if (ImagesList == null)
            {
                throw new InvalidDataException("ImagesList is a required property for ImageTemplatesRequest and cannot be null");
            }
            else
            {
                this.ImagesList = ImagesList;
            }
            this.OCRLangs = OCRLangs;
        }
        
        /// <summary>
        /// Using OCR function.
        /// </summary>
        /// <value>Using OCR function.</value>
        [DataMember(Name="IsOCR", EmitDefaultValue=false)]
        public bool? IsOCR { get; set; }

        /// <summary>
        /// Language for recognition possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra      or thier combination e.g. eng+rus
        /// </summary>
        /// <value>Language for recognition possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra      or thier combination e.g. eng+rus</value>
        [DataMember(Name="OCRLangs", EmitDefaultValue=false)]
        public string OCRLangs { get; set; }

        /// <summary>
        /// A List of objects describing images to be added.
        /// </summary>
        /// <value>A List of objects describing images to be added.</value>
        [DataMember(Name="ImagesList", EmitDefaultValue=false)]
        public List<ImageTemplate> ImagesList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageTemplatesRequest {\n");
            sb.Append("  IsOCR: ").Append(IsOCR).Append("\n");
            sb.Append("  OCRLangs: ").Append(OCRLangs).Append("\n");
            sb.Append("  ImagesList: ").Append(ImagesList).Append("\n");
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
            return this.Equals(obj as ImageTemplatesRequest);
        }

        /// <summary>
        /// Returns true if ImageTemplatesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ImageTemplatesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageTemplatesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsOCR == other.IsOCR ||
                    this.IsOCR != null &&
                    this.IsOCR.Equals(other.IsOCR)
                ) && 
                (
                    this.OCRLangs == other.OCRLangs ||
                    this.OCRLangs != null &&
                    this.OCRLangs.Equals(other.OCRLangs)
                ) && 
                (
                    this.ImagesList == other.ImagesList ||
                    this.ImagesList != null &&
                    this.ImagesList.SequenceEqual(other.ImagesList)
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
                if (this.IsOCR != null)
                    hash = hash * 59 + this.IsOCR.GetHashCode();
                if (this.OCRLangs != null)
                    hash = hash * 59 + this.OCRLangs.GetHashCode();
                if (this.ImagesList != null)
                    hash = hash * 59 + this.ImagesList.GetHashCode();
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
