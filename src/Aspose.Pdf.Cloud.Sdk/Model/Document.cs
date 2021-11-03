// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Document.cs">
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
    /// Represents document DTO.
    /// </summary>
    [DataContract]
    public partial class Document : LinkElement,  IEquatable<Document>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="DocumentProperties">Document properties.</param>
        /// <param name="DisplayProperties">Document display properties.</param>
        /// <param name="Pages">Document pages.</param>
        public Document(List<Link> Links = default(List<Link>), DocumentProperties DocumentProperties = default(DocumentProperties), DisplayProperties DisplayProperties = default(DisplayProperties), Pages Pages = default(Pages))
        {
            this.Links = Links;
            this.DocumentProperties = DocumentProperties;
            this.DisplayProperties = DisplayProperties;
            this.Pages = Pages;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Document properties.
        /// </summary>
        /// <value>Document properties.</value>
        [DataMember(Name="DocumentProperties", EmitDefaultValue=false)]
        public DocumentProperties DocumentProperties { get; set; }

        /// <summary>
        /// Document display properties.
        /// </summary>
        /// <value>Document display properties.</value>
        [DataMember(Name="DisplayProperties", EmitDefaultValue=false)]
        public DisplayProperties DisplayProperties { get; set; }

        /// <summary>
        /// Document pages.
        /// </summary>
        /// <value>Document pages.</value>
        [DataMember(Name="Pages", EmitDefaultValue=false)]
        public Pages Pages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  DocumentProperties: ").Append(DocumentProperties).Append("\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
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
            return this.Equals(obj as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="other">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document other)
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
                    this.DocumentProperties == other.DocumentProperties ||
                    this.DocumentProperties != null &&
                    this.DocumentProperties.Equals(other.DocumentProperties)
                ) && 
                (
                    this.DisplayProperties == other.DisplayProperties ||
                    this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(other.DisplayProperties)
                ) && 
                (
                    this.Pages == other.Pages ||
                    this.Pages != null &&
                    this.Pages.Equals(other.Pages)
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
                if (this.DocumentProperties != null)
                    hash = hash * 59 + this.DocumentProperties.GetHashCode();
                if (this.DisplayProperties != null)
                    hash = hash * 59 + this.DisplayProperties.GetHashCode();
                if (this.Pages != null)
                    hash = hash * 59 + this.Pages.GetHashCode();
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
