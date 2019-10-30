﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RadioButtonOptionField.cs">
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
    /// Provides RadioButtonField.
    /// </summary>
    [DataContract]
    public partial class RadioButtonOptionField : FormField,  IEquatable<RadioButtonOptionField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButtonOptionField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RadioButtonOptionField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButtonOptionField" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="PartialName">Field name.</param>
        /// <param name="Rect">Field rectangle.</param>
        /// <param name="Value">Field value.</param>
        /// <param name="PageIndex">Page index. (required)</param>
        /// <param name="Height">Gets or sets height of the field.</param>
        /// <param name="Width">Gets or sets width of the field.</param>
        /// <param name="ZIndex">Z index.</param>
        /// <param name="IsGroup">Is group. (required)</param>
        /// <param name="Parent">Gets field parent.</param>
        /// <param name="IsSharedField">Property for Generator support. Used when field is added to header or footer. If true, this field will created once and it&#39;s appearance will be visible on all pages of the document. If false, separated field will be created for every document page.</param>
        /// <param name="Flags">Gets Flags of the field.</param>
        /// <param name="Color">Color of the annotation.</param>
        /// <param name="Contents">Get the field content.</param>
        /// <param name="Margin">Gets or sets a outer margin for paragraph (for pdf generation)</param>
        /// <param name="Highlighting">Field highlighting mode.</param>
        /// <param name="HorizontalAlignment">Gets HorizontalAlignment of the field.</param>
        /// <param name="VerticalAlignment">Gets VerticalAlignment of the field.</param>
        /// <param name="OptionName">Gets or sets name of the option.</param>
        /// <param name="Style">Style of field box.</param>
        public RadioButtonOptionField(List<Link> Links = default(List<Link>), string PartialName = default(string), Rectangle Rect = default(Rectangle), string Value = default(string), int? PageIndex = default(int?), double? Height = default(double?), double? Width = default(double?), int? ZIndex = default(int?), bool? IsGroup = default(bool?), FormField Parent = default(FormField), bool? IsSharedField = default(bool?), List<AnnotationFlags> Flags = default(List<AnnotationFlags>), Color Color = default(Color), string Contents = default(string), MarginInfo Margin = default(MarginInfo), LinkHighlightingMode Highlighting = default(LinkHighlightingMode), HorizontalAlignment HorizontalAlignment = default(HorizontalAlignment), VerticalAlignment VerticalAlignment = default(VerticalAlignment), string OptionName = default(string), BoxStyle Style = default(BoxStyle))
        {
            // to ensure "PageIndex" is required (not null)
            if (PageIndex == null)
            {
                throw new InvalidDataException("PageIndex is a required property for RadioButtonOptionField and cannot be null");
            }
            else
            {
                this.PageIndex = PageIndex;
            }
            // to ensure "IsGroup" is required (not null)
            if (IsGroup == null)
            {
                throw new InvalidDataException("IsGroup is a required property for RadioButtonOptionField and cannot be null");
            }
            else
            {
                this.IsGroup = IsGroup;
            }
            this.Links = Links;
            this.PartialName = PartialName;
            this.Rect = Rect;
            this.Value = Value;
            this.Height = Height;
            this.Width = Width;
            this.ZIndex = ZIndex;
            this.Parent = Parent;
            this.IsSharedField = IsSharedField;
            this.Flags = Flags;
            this.Color = Color;
            this.Contents = Contents;
            this.Margin = Margin;
            this.Highlighting = Highlighting;
            this.HorizontalAlignment = HorizontalAlignment;
            this.VerticalAlignment = VerticalAlignment;
            this.OptionName = OptionName;
            this.Style = Style;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Field name.
        /// </summary>
        /// <value>Field name.</value>
        [DataMember(Name="PartialName", EmitDefaultValue=false)]
        public string PartialName { get; set; }

        /// <summary>
        /// Field rectangle.
        /// </summary>
        /// <value>Field rectangle.</value>
        [DataMember(Name="Rect", EmitDefaultValue=false)]
        public Rectangle Rect { get; set; }

        /// <summary>
        /// Field value.
        /// </summary>
        /// <value>Field value.</value>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Page index.
        /// </summary>
        /// <value>Page index.</value>
        [DataMember(Name="PageIndex", EmitDefaultValue=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// Gets or sets height of the field.
        /// </summary>
        /// <value>Gets or sets height of the field.</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public double? Height { get; set; }

        /// <summary>
        /// Gets or sets width of the field.
        /// </summary>
        /// <value>Gets or sets width of the field.</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public double? Width { get; set; }

        /// <summary>
        /// Z index.
        /// </summary>
        /// <value>Z index.</value>
        [DataMember(Name="ZIndex", EmitDefaultValue=false)]
        public int? ZIndex { get; set; }

        /// <summary>
        /// Is group.
        /// </summary>
        /// <value>Is group.</value>
        [DataMember(Name="IsGroup", EmitDefaultValue=false)]
        public bool? IsGroup { get; set; }

        /// <summary>
        /// Gets field parent.
        /// </summary>
        /// <value>Gets field parent.</value>
        [DataMember(Name="Parent", EmitDefaultValue=false)]
        public FormField Parent { get; set; }

        /// <summary>
        /// Property for Generator support. Used when field is added to header or footer. If true, this field will created once and it&#39;s appearance will be visible on all pages of the document. If false, separated field will be created for every document page.
        /// </summary>
        /// <value>Property for Generator support. Used when field is added to header or footer. If true, this field will created once and it&#39;s appearance will be visible on all pages of the document. If false, separated field will be created for every document page.</value>
        [DataMember(Name="IsSharedField", EmitDefaultValue=false)]
        public bool? IsSharedField { get; set; }

        /// <summary>
        /// Gets Flags of the field.
        /// </summary>
        /// <value>Gets Flags of the field.</value>
        [DataMember(Name="Flags", EmitDefaultValue=false)]
        public List<AnnotationFlags> Flags { get; set; }

        /// <summary>
        /// Color of the annotation.
        /// </summary>
        /// <value>Color of the annotation.</value>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Get the field content.
        /// </summary>
        /// <value>Get the field content.</value>
        [DataMember(Name="Contents", EmitDefaultValue=false)]
        public string Contents { get; set; }

        /// <summary>
        /// Gets or sets a outer margin for paragraph (for pdf generation)
        /// </summary>
        /// <value>Gets or sets a outer margin for paragraph (for pdf generation)</value>
        [DataMember(Name="Margin", EmitDefaultValue=false)]
        public MarginInfo Margin { get; set; }

        /// <summary>
        /// Field highlighting mode.
        /// </summary>
        /// <value>Field highlighting mode.</value>
        [DataMember(Name="Highlighting", EmitDefaultValue=true)]
        public LinkHighlightingMode Highlighting { get; set; }

        /// <summary>
        /// Gets HorizontalAlignment of the field.
        /// </summary>
        /// <value>Gets HorizontalAlignment of the field.</value>
        [DataMember(Name="HorizontalAlignment", EmitDefaultValue=true)]
        public HorizontalAlignment HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets VerticalAlignment of the field.
        /// </summary>
        /// <value>Gets VerticalAlignment of the field.</value>
        [DataMember(Name="VerticalAlignment", EmitDefaultValue=true)]
        public VerticalAlignment VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets name of the option.
        /// </summary>
        /// <value>Gets or sets name of the option.</value>
        [DataMember(Name="OptionName", EmitDefaultValue=false)]
        public string OptionName { get; set; }

        /// <summary>
        /// Style of field box.
        /// </summary>
        /// <value>Style of field box.</value>
        [DataMember(Name="Style", EmitDefaultValue=true)]
        public BoxStyle Style { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadioButtonOptionField {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  PartialName: ").Append(PartialName).Append("\n");
            sb.Append("  Rect: ").Append(Rect).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  ZIndex: ").Append(ZIndex).Append("\n");
            sb.Append("  IsGroup: ").Append(IsGroup).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  IsSharedField: ").Append(IsSharedField).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
            sb.Append("  Highlighting: ").Append(Highlighting).Append("\n");
            sb.Append("  HorizontalAlignment: ").Append(HorizontalAlignment).Append("\n");
            sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
            sb.Append("  OptionName: ").Append(OptionName).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
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
            return this.Equals(obj as RadioButtonOptionField);
        }

        /// <summary>
        /// Returns true if RadioButtonOptionField instances are equal
        /// </summary>
        /// <param name="other">Instance of RadioButtonOptionField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadioButtonOptionField other)
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
                    this.PartialName == other.PartialName ||
                    this.PartialName != null &&
                    this.PartialName.Equals(other.PartialName)
                ) && 
                (
                    this.Rect == other.Rect ||
                    this.Rect != null &&
                    this.Rect.Equals(other.Rect)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.PageIndex == other.PageIndex ||
                    this.PageIndex != null &&
                    this.PageIndex.Equals(other.PageIndex)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.ZIndex == other.ZIndex ||
                    this.ZIndex != null &&
                    this.ZIndex.Equals(other.ZIndex)
                ) && 
                (
                    this.IsGroup == other.IsGroup ||
                    this.IsGroup != null &&
                    this.IsGroup.Equals(other.IsGroup)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this.IsSharedField == other.IsSharedField ||
                    this.IsSharedField != null &&
                    this.IsSharedField.Equals(other.IsSharedField)
                ) && 
                (
                    this.Flags == other.Flags ||
                    this.Flags != null &&
                    this.Flags.SequenceEqual(other.Flags)
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
                    this.Margin == other.Margin ||
                    this.Margin != null &&
                    this.Margin.Equals(other.Margin)
                ) && 
                (
                    this.Highlighting == other.Highlighting ||
                    this.Highlighting != null &&
                    this.Highlighting.Equals(other.Highlighting)
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
                    this.OptionName == other.OptionName ||
                    this.OptionName != null &&
                    this.OptionName.Equals(other.OptionName)
                ) && 
                (
                    this.Style == other.Style ||
                    this.Style != null &&
                    this.Style.Equals(other.Style)
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
                if (this.PartialName != null)
                    hash = hash * 59 + this.PartialName.GetHashCode();
                if (this.Rect != null)
                    hash = hash * 59 + this.Rect.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.PageIndex != null)
                    hash = hash * 59 + this.PageIndex.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.ZIndex != null)
                    hash = hash * 59 + this.ZIndex.GetHashCode();
                if (this.IsGroup != null)
                    hash = hash * 59 + this.IsGroup.GetHashCode();
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                if (this.IsSharedField != null)
                    hash = hash * 59 + this.IsSharedField.GetHashCode();
                if (this.Flags != null)
                    hash = hash * 59 + this.Flags.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Contents != null)
                    hash = hash * 59 + this.Contents.GetHashCode();
                if (this.Margin != null)
                    hash = hash * 59 + this.Margin.GetHashCode();
                if (this.Highlighting != null)
                    hash = hash * 59 + this.Highlighting.GetHashCode();
                if (this.HorizontalAlignment != null)
                    hash = hash * 59 + this.HorizontalAlignment.GetHashCode();
                if (this.VerticalAlignment != null)
                    hash = hash * 59 + this.VerticalAlignment.GetHashCode();
                if (this.OptionName != null)
                    hash = hash * 59 + this.OptionName.GetHashCode();
                if (this.Style != null)
                    hash = hash * 59 + this.Style.GetHashCode();
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