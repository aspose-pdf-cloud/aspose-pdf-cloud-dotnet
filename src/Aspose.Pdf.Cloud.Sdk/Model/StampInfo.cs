// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StampInfo.cs">
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
    /// Provides stamp info.
    /// </summary>
    [DataContract]
    public partial class StampInfo : LinkElement,  IEquatable<StampInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StampInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StampInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StampInfo" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="Id">Gets ID of the stamp.</param>
        /// <param name="IndexOnPage">Gets index on page of the stamp.</param>
        /// <param name="PageIndex">Gets PageIndex of the annotation.</param>
        /// <param name="Rect">Gets Rect of the annotation.</param>
        /// <param name="Text">Get the text content.</param>
        /// <param name="Visible">Gets the stamp is visible.</param>
        /// <param name="StampType">Gets stamp type. (required)</param>
        public StampInfo(List<Link> Links = default(List<Link>), string Id = default(string), int? IndexOnPage = default(int?), int? PageIndex = default(int?), Rectangle Rect = default(Rectangle), string Text = default(string), bool? Visible = default(bool?), StampType StampType = default(StampType))
        {
            // to ensure "StampType" is required (not null)
            if (StampType == null)
            {
                throw new InvalidDataException("StampType is a required property for StampInfo and cannot be null");
            }
            else
            {
                this.StampType = StampType;
            }
            this.Links = Links;
            this.Id = Id;
            this.IndexOnPage = IndexOnPage;
            this.PageIndex = PageIndex;
            this.Rect = Rect;
            this.Text = Text;
            this.Visible = Visible;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets ID of the stamp.
        /// </summary>
        /// <value>Gets ID of the stamp.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets index on page of the stamp.
        /// </summary>
        /// <value>Gets index on page of the stamp.</value>
        [DataMember(Name="IndexOnPage", EmitDefaultValue=false)]
        public int? IndexOnPage { get; set; }

        /// <summary>
        /// Gets PageIndex of the annotation.
        /// </summary>
        /// <value>Gets PageIndex of the annotation.</value>
        [DataMember(Name="PageIndex", EmitDefaultValue=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// Gets Rect of the annotation.
        /// </summary>
        /// <value>Gets Rect of the annotation.</value>
        [DataMember(Name="Rect", EmitDefaultValue=false)]
        public Rectangle Rect { get; set; }

        /// <summary>
        /// Get the text content.
        /// </summary>
        /// <value>Get the text content.</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets the stamp is visible.
        /// </summary>
        /// <value>Gets the stamp is visible.</value>
        [DataMember(Name="Visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Gets stamp type.
        /// </summary>
        /// <value>Gets stamp type.</value>
        [DataMember(Name="StampType", EmitDefaultValue=true)]
        public StampType StampType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StampInfo {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IndexOnPage: ").Append(IndexOnPage).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  Rect: ").Append(Rect).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  StampType: ").Append(StampType).Append("\n");
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
            return this.Equals(obj as StampInfo);
        }

        /// <summary>
        /// Returns true if StampInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of StampInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StampInfo other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IndexOnPage == other.IndexOnPage ||
                    this.IndexOnPage != null &&
                    this.IndexOnPage.Equals(other.IndexOnPage)
                ) && 
                (
                    this.PageIndex == other.PageIndex ||
                    this.PageIndex != null &&
                    this.PageIndex.Equals(other.PageIndex)
                ) && 
                (
                    this.Rect == other.Rect ||
                    this.Rect != null &&
                    this.Rect.Equals(other.Rect)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.Visible == other.Visible ||
                    this.Visible != null &&
                    this.Visible.Equals(other.Visible)
                ) && 
                (
                    this.StampType == other.StampType ||
                    this.StampType != null &&
                    this.StampType.Equals(other.StampType)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.IndexOnPage != null)
                    hash = hash * 59 + this.IndexOnPage.GetHashCode();
                if (this.PageIndex != null)
                    hash = hash * 59 + this.PageIndex.GetHashCode();
                if (this.Rect != null)
                    hash = hash * 59 + this.Rect.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.Visible != null)
                    hash = hash * 59 + this.Visible.GetHashCode();
                if (this.StampType != null)
                    hash = hash * 59 + this.StampType.GetHashCode();
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
