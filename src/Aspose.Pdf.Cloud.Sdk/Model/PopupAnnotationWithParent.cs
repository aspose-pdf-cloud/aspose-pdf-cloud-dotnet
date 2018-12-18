// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PopupAnnotationWithParent.cs">
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
    /// Provides PopupAnnotation.
    /// </summary>
    [DataContract]
    public partial class PopupAnnotationWithParent : PopupAnnotation,  IEquatable<PopupAnnotationWithParent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopupAnnotationWithParent" /> class.
        /// </summary>
        /// <param name="Links">Link to the document..</param>
        /// <param name="Contents">Get the annotation content..</param>
        /// <param name="Modified">The date and time when the annotation was last modified..</param>
        /// <param name="Id">Gets ID of the annotation..</param>
        /// <param name="Flags">Gets Flags of the annotation..</param>
        /// <param name="Name">Gets Name of the annotation..</param>
        /// <param name="Rect">Gets Rect of the annotation..</param>
        /// <param name="PageIndex">Gets PageIndex of the annotation..</param>
        /// <param name="ZIndex">Gets ZIndex of the annotation..</param>
        /// <param name="HorizontalAlignment">Gets HorizontalAlignment of the annotation..</param>
        /// <param name="VerticalAlignment">Gets VerticalAlignment of the annotation..</param>
        /// <param name="Color">Color of the annotation..</param>
        /// <param name="Open">Gets or sets a flag specifying whether the pop-up annotation should initially be displayed open..</param>
        /// <param name="Parent">Parent of annotation..</param>
        public PopupAnnotationWithParent(List<Link> Links = default(List<Link>), string Contents = default(string), string Modified = default(string), string Id = default(string), List<AnnotationFlags> Flags = default(List<AnnotationFlags>), string Name = default(string), RectanglePdf Rect = default(RectanglePdf), int? PageIndex = default(int?), int? ZIndex = default(int?), HorizontalAlignment HorizontalAlignment = default(HorizontalAlignment), VerticalAlignment VerticalAlignment = default(VerticalAlignment), Color Color = default(Color), bool? Open = default(bool?), AnnotationInfo Parent = default(AnnotationInfo))
        {
            this.Links = Links;
            this.Contents = Contents;
            this.Modified = Modified;
            this.Id = Id;
            this.Flags = Flags;
            this.Name = Name;
            this.Rect = Rect;
            this.PageIndex = PageIndex;
            this.ZIndex = ZIndex;
            this.HorizontalAlignment = HorizontalAlignment;
            this.VerticalAlignment = VerticalAlignment;
            this.Color = Color;
            this.Open = Open;
            this.Parent = Parent;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Get the annotation content.
        /// </summary>
        /// <value>Get the annotation content.</value>
        [DataMember(Name="Contents", EmitDefaultValue=false)]
        public string Contents { get; set; }

        /// <summary>
        /// The date and time when the annotation was last modified.
        /// </summary>
        /// <value>The date and time when the annotation was last modified.</value>
        [DataMember(Name="Modified", EmitDefaultValue=false)]
        public string Modified { get; set; }

        /// <summary>
        /// Gets ID of the annotation.
        /// </summary>
        /// <value>Gets ID of the annotation.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets Flags of the annotation.
        /// </summary>
        /// <value>Gets Flags of the annotation.</value>
        [DataMember(Name="Flags", EmitDefaultValue=false)]
        public List<AnnotationFlags> Flags { get; set; }

        /// <summary>
        /// Gets Name of the annotation.
        /// </summary>
        /// <value>Gets Name of the annotation.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets Rect of the annotation.
        /// </summary>
        /// <value>Gets Rect of the annotation.</value>
        [DataMember(Name="Rect", EmitDefaultValue=false)]
        public RectanglePdf Rect { get; set; }

        /// <summary>
        /// Gets PageIndex of the annotation.
        /// </summary>
        /// <value>Gets PageIndex of the annotation.</value>
        [DataMember(Name="PageIndex", EmitDefaultValue=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// Gets ZIndex of the annotation.
        /// </summary>
        /// <value>Gets ZIndex of the annotation.</value>
        [DataMember(Name="ZIndex", EmitDefaultValue=false)]
        public int? ZIndex { get; set; }

        /// <summary>
        /// Gets HorizontalAlignment of the annotation.
        /// </summary>
        /// <value>Gets HorizontalAlignment of the annotation.</value>
        [DataMember(Name="HorizontalAlignment", EmitDefaultValue=true)]
        public HorizontalAlignment HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets VerticalAlignment of the annotation.
        /// </summary>
        /// <value>Gets VerticalAlignment of the annotation.</value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=true)]
        public VerticalAlignment VerticalAlignment { get; set; }

        /// <summary>
        /// Color of the annotation.
        /// </summary>
        /// <value>Color of the annotation.</value>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets a flag specifying whether the pop-up annotation should initially be displayed open.
        /// </summary>
        /// <value>Gets or sets a flag specifying whether the pop-up annotation should initially be displayed open.</value>
        [DataMember(Name="Open", EmitDefaultValue=false)]
        public bool? Open { get; set; }

        /// <summary>
        /// Parent of annotation.
        /// </summary>
        /// <value>Parent of annotation.</value>
        [DataMember(Name="Parent", EmitDefaultValue=false)]
        public AnnotationInfo Parent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PopupAnnotationWithParent {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rect: ").Append(Rect).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  ZIndex: ").Append(ZIndex).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(HorizontalAlignment).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
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
            return this.Equals(obj as PopupAnnotationWithParent);
        }

        /// <summary>
        /// Returns true if PopupAnnotationWithParent instances are equal
        /// </summary>
        /// <param name="other">Instance of PopupAnnotationWithParent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PopupAnnotationWithParent other)
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
                    this.Contents == other.Contents ||
                    this.Contents != null &&
                    this.Contents.Equals(other.Contents)
                ) && 
                (
                    this.Modified == other.Modified ||
                    this.Modified != null &&
                    this.Modified.Equals(other.Modified)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Flags == other.Flags ||
                    this.Flags != null &&
                    this.Flags.SequenceEqual(other.Flags)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Rect == other.Rect ||
                    this.Rect != null &&
                    this.Rect.Equals(other.Rect)
                ) && 
                (
                    this.PageIndex == other.PageIndex ||
                    this.PageIndex != null &&
                    this.PageIndex.Equals(other.PageIndex)
                ) && 
                (
                    this.ZIndex == other.ZIndex ||
                    this.ZIndex != null &&
                    this.ZIndex.Equals(other.ZIndex)
                ) && 
                (
                    this.HorizontalAlignment == other.HorizontalAlignment ||
                    this.HorizontalAlignment != null &&
                    this.HorizontalAlignment.Equals(other.HorizontalAlignment)
                ) && 
                (
                    this.VerticalAlignment == other.VerticalAlignment ||
                    this.VerticalAlignment != null &&
                    this.VerticalAlignment.Equals(other.VerticalAlignment)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Open == other.Open ||
                    this.Open != null &&
                    this.Open.Equals(other.Open)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
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
                if (this.Contents != null)
                    hash = hash * 59 + this.Contents.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Flags != null)
                    hash = hash * 59 + this.Flags.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Rect != null)
                    hash = hash * 59 + this.Rect.GetHashCode();
                if (this.PageIndex != null)
                    hash = hash * 59 + this.PageIndex.GetHashCode();
                if (this.ZIndex != null)
                    hash = hash * 59 + this.ZIndex.GetHashCode();
                if (this.HorizontalAlignment != null)
                    hash = hash * 59 + this.HorizontalAlignment.GetHashCode();
                if (this.VerticalAlignment != null)
                    hash = hash * 59 + this.VerticalAlignment.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Open != null)
                    hash = hash * 59 + this.Open.GetHashCode();
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
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
