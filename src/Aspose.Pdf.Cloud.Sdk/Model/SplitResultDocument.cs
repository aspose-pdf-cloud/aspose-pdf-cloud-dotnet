// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SplitResultDocument.cs">
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
    /// Represents split result document,
    /// </summary>
    [DataContract]
    public partial class SplitResultDocument : Link,  IEquatable<SplitResultDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitResultDocument" /> class.
        /// </summary>
        /// <param name="Href">The \&quot;href\&quot; attribute contains the link&#39;s IRI. atom:link elements MUST have an href attribute, whose value MUST be a IRI reference.</param>
        /// <param name="Rel">atom:link elements MAY have a \&quot;rel\&quot; attribute that indicates the link relation type.  If the \&quot;rel\&quot; attribute is not present, the link element MUST be interpreted as if the link relation type is \&quot;alternate\&quot;..</param>
        /// <param name="Type">On the link element, the \&quot;type\&quot; attribute&#39;s value is an advisory media type: it is a hint about the type of the representation that is expected to be returned when the value of the href attribute is dereferenced.  Note that the type attribute does not override the actual media type returned with the representation..</param>
        /// <param name="Title">The \&quot;title\&quot; attribute conveys human-readable information about the link.  The content of the \&quot;title\&quot; attribute is Language-Sensitive..</param>
        /// <param name="Id">Gets or sets the page number..</param>
        public SplitResultDocument(string Href = default(string), string Rel = default(string), string Type = default(string), string Title = default(string), int? Id = default(int?))
        {
            this.Href = Href;
            this.Rel = Rel;
            this.Type = Type;
            this.Title = Title;
            this.Id = Id;
        }
        
        /// <summary>
        /// The \&quot;href\&quot; attribute contains the link&#39;s IRI. atom:link elements MUST have an href attribute, whose value MUST be a IRI reference
        /// </summary>
        /// <value>The \&quot;href\&quot; attribute contains the link&#39;s IRI. atom:link elements MUST have an href attribute, whose value MUST be a IRI reference</value>
        [DataMember(Name="Href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// atom:link elements MAY have a \&quot;rel\&quot; attribute that indicates the link relation type.  If the \&quot;rel\&quot; attribute is not present, the link element MUST be interpreted as if the link relation type is \&quot;alternate\&quot;.
        /// </summary>
        /// <value>atom:link elements MAY have a \&quot;rel\&quot; attribute that indicates the link relation type.  If the \&quot;rel\&quot; attribute is not present, the link element MUST be interpreted as if the link relation type is \&quot;alternate\&quot;.</value>
        [DataMember(Name="Rel", EmitDefaultValue=false)]
        public string Rel { get; set; }

        /// <summary>
        /// On the link element, the \&quot;type\&quot; attribute&#39;s value is an advisory media type: it is a hint about the type of the representation that is expected to be returned when the value of the href attribute is dereferenced.  Note that the type attribute does not override the actual media type returned with the representation.
        /// </summary>
        /// <value>On the link element, the \&quot;type\&quot; attribute&#39;s value is an advisory media type: it is a hint about the type of the representation that is expected to be returned when the value of the href attribute is dereferenced.  Note that the type attribute does not override the actual media type returned with the representation.</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The \&quot;title\&quot; attribute conveys human-readable information about the link.  The content of the \&quot;title\&quot; attribute is Language-Sensitive.
        /// </summary>
        /// <value>The \&quot;title\&quot; attribute conveys human-readable information about the link.  The content of the \&quot;title\&quot; attribute is Language-Sensitive.</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>
        /// <value>Gets or sets the page number.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SplitResultDocument {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Rel: ").Append(Rel).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as SplitResultDocument);
        }

        /// <summary>
        /// Returns true if SplitResultDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of SplitResultDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitResultDocument other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                ) && 
                (
                    this.Rel == other.Rel ||
                    this.Rel != null &&
                    this.Rel.Equals(other.Rel)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
                if (this.Rel != null)
                    hash = hash * 59 + this.Rel.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
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
