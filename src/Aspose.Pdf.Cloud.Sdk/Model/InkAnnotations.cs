// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="InkAnnotations.cs">
//   Copyright (c) 2025 Aspose.PDF Cloud
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
    /// Object representing a list of ink annotations.
    /// </summary>
    [DataContract]
    public partial class InkAnnotations : LinkElement,  IEquatable<InkAnnotations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InkAnnotations" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="List">List of ink annotations.</param>
        public InkAnnotations(List<Link> Links = default(List<Link>), List<InkAnnotation> List = default(List<InkAnnotation>))
        {
            this.Links = Links;
            this.List = List;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// List of ink annotations.
        /// </summary>
        /// <value>List of ink annotations.</value>
        [DataMember(Name="List", EmitDefaultValue=false)]
        public List<InkAnnotation> List { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InkAnnotations {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
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
            return this.Equals(obj as InkAnnotations);
        }

        /// <summary>
        /// Returns true if InkAnnotations instances are equal
        /// </summary>
        /// <param name="other">Instance of InkAnnotations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InkAnnotations other)
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
                    this.List == other.List ||
                    this.List != null &&
                    this.List.SequenceEqual(other.List)
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
                if (this.List != null)
                    hash = hash * 59 + this.List.GetHashCode();
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
