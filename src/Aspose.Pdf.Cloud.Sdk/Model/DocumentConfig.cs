// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentConfig.cs">
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
    /// Provides link to DocumentConfig.
    /// </summary>
    [DataContract]
    public partial class DocumentConfig :  IEquatable<DocumentConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConfig" /> class.
        /// </summary>
        /// <param name="DisplayProperties">Sets DisplayProperties of document</param>
        /// <param name="DocumentProperties">Sets DocumentProperties of document</param>
        /// <param name="PagesCount">Sets count of pages for new document. From 1 to 100 (required)</param>
        /// <param name="DefaultPageConfig">Sets default page config for new document</param>
        public DocumentConfig(DisplayProperties DisplayProperties = default(DisplayProperties), DocumentProperties DocumentProperties = default(DocumentProperties), int? PagesCount = default(int?), DefaultPageConfig DefaultPageConfig = default(DefaultPageConfig))
        {
            // to ensure "PagesCount" is required (not null)
            if (PagesCount == null)
            {
                throw new InvalidDataException("PagesCount is a required property for DocumentConfig and cannot be null");
            }
            else
            {
                this.PagesCount = PagesCount;
            }
            this.DisplayProperties = DisplayProperties;
            this.DocumentProperties = DocumentProperties;
            this.DefaultPageConfig = DefaultPageConfig;
        }
        
        /// <summary>
        /// Sets DisplayProperties of document
        /// </summary>
        /// <value>Sets DisplayProperties of document</value>
        [DataMember(Name="DisplayProperties", EmitDefaultValue=false)]
        public DisplayProperties DisplayProperties { get; set; }

        /// <summary>
        /// Sets DocumentProperties of document
        /// </summary>
        /// <value>Sets DocumentProperties of document</value>
        [DataMember(Name="DocumentProperties", EmitDefaultValue=false)]
        public DocumentProperties DocumentProperties { get; set; }

        /// <summary>
        /// Sets count of pages for new document. From 1 to 100
        /// </summary>
        /// <value>Sets count of pages for new document. From 1 to 100</value>
        [DataMember(Name="PagesCount", EmitDefaultValue=false)]
        public int? PagesCount { get; set; }

        /// <summary>
        /// Sets default page config for new document
        /// </summary>
        /// <value>Sets default page config for new document</value>
        [DataMember(Name="DefaultPageConfig", EmitDefaultValue=false)]
        public DefaultPageConfig DefaultPageConfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentConfig {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  DocumentProperties: ").Append(DocumentProperties).Append("\n");
            sb.Append("  PagesCount: ").Append(PagesCount).Append("\n");
            sb.Append("  DefaultPageConfig: ").Append(DefaultPageConfig).Append("\n");
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
            return this.Equals(obj as DocumentConfig);
        }

        /// <summary>
        /// Returns true if DocumentConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisplayProperties == other.DisplayProperties ||
                    this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(other.DisplayProperties)
                ) && 
                (
                    this.DocumentProperties == other.DocumentProperties ||
                    this.DocumentProperties != null &&
                    this.DocumentProperties.Equals(other.DocumentProperties)
                ) && 
                (
                    this.PagesCount == other.PagesCount ||
                    this.PagesCount != null &&
                    this.PagesCount.Equals(other.PagesCount)
                ) && 
                (
                    this.DefaultPageConfig == other.DefaultPageConfig ||
                    this.DefaultPageConfig != null &&
                    this.DefaultPageConfig.Equals(other.DefaultPageConfig)
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
                if (this.DisplayProperties != null)
                    hash = hash * 59 + this.DisplayProperties.GetHashCode();
                if (this.DocumentProperties != null)
                    hash = hash * 59 + this.DocumentProperties.GetHashCode();
                if (this.PagesCount != null)
                    hash = hash * 59 + this.PagesCount.GetHashCode();
                if (this.DefaultPageConfig != null)
                    hash = hash * 59 + this.DefaultPageConfig.GetHashCode();
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
