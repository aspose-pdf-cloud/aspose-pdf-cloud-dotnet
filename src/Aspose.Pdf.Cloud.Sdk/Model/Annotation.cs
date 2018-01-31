// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Annotation.cs">
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
    /// Provides annotation.
    /// </summary>
    [DataContract]
    public partial class Annotation : LinkElement,  IEquatable<Annotation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        /// <param name="Links">Link to the document..</param>
        /// <param name="Color">Get the annotation color..</param>
        /// <param name="Contents">Get the annotation content..</param>
        /// <param name="CreationDate">The date and time when the annotation was created..</param>
        /// <param name="Subject">Get the annotation subject..</param>
        /// <param name="Title">Get the annotation title..</param>
        /// <param name="Modified">The date and time when the annotation was last modified..</param>
        public Annotation(List<Link> Links = default(List<Link>), Color Color = default(Color), string Contents = default(string), string CreationDate = default(string), string Subject = default(string), string Title = default(string), string Modified = default(string))
        {
            this.Links = Links;
            this.Color = Color;
            this.Contents = Contents;
            this.CreationDate = CreationDate;
            this.Subject = Subject;
            this.Title = Title;
            this.Modified = Modified;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Get the annotation color.
        /// </summary>
        /// <value>Get the annotation color.</value>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Get the annotation content.
        /// </summary>
        /// <value>Get the annotation content.</value>
        [DataMember(Name="Contents", EmitDefaultValue=false)]
        public string Contents { get; set; }

        /// <summary>
        /// The date and time when the annotation was created.
        /// </summary>
        /// <value>The date and time when the annotation was created.</value>
        [DataMember(Name="CreationDate", EmitDefaultValue=false)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Get the annotation subject.
        /// </summary>
        /// <value>Get the annotation subject.</value>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Get the annotation title.
        /// </summary>
        /// <value>Get the annotation title.</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The date and time when the annotation was last modified.
        /// </summary>
        /// <value>The date and time when the annotation was last modified.</value>
        [DataMember(Name="Modified", EmitDefaultValue=false)]
        public string Modified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Annotation {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
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
            return this.Equals(obj as Annotation);
        }

        /// <summary>
        /// Returns true if Annotation instances are equal
        /// </summary>
        /// <param name="other">Instance of Annotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Annotation other)
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
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Contents == other.Contents ||
                    this.Contents != null &&
                    this.Contents.Equals(other.Contents)
                ) && 
                (
                    this.CreationDate == other.CreationDate ||
                    this.CreationDate != null &&
                    this.CreationDate.Equals(other.CreationDate)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Modified == other.Modified ||
                    this.Modified != null &&
                    this.Modified.Equals(other.Modified)
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
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Contents != null)
                    hash = hash * 59 + this.Contents.GetHashCode();
                if (this.CreationDate != null)
                    hash = hash * 59 + this.CreationDate.GetHashCode();
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
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
