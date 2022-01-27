// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Field.cs">
//   Copyright (c) 2022 Aspose.PDF Cloud
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
    /// Represents form field.
    /// </summary>
    [DataContract]
    public partial class Field : LinkElement,  IEquatable<Field>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Field" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Field() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Field" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="Name">Field name.</param>
        /// <param name="SelectedItems">Selected items.</param>
        /// <param name="Type">Field type.</param>
        /// <param name="Rect">Field rectangle.</param>
        /// <param name="Values">Field values. (required)</param>
        public Field(List<Link> Links = default(List<Link>), string Name = default(string), List<int?> SelectedItems = default(List<int?>), FieldType Type = default(FieldType), Rectangle Rect = default(Rectangle), List<string> Values = default(List<string>))
        {
            // to ensure "Values" is required (not null)
            if (Values == null)
            {
                throw new InvalidDataException("Values is a required property for Field and cannot be null");
            }
            else
            {
                this.Values = Values;
            }
            this.Links = Links;
            this.Name = Name;
            this.SelectedItems = SelectedItems;
            this.Type = Type;
            this.Rect = Rect;
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
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Selected items.
        /// </summary>
        /// <value>Selected items.</value>
        [DataMember(Name="SelectedItems", EmitDefaultValue=false)]
        public List<int?> SelectedItems { get; set; }

        /// <summary>
        /// Field type.
        /// </summary>
        /// <value>Field type.</value>
        [DataMember(Name="Type", EmitDefaultValue=true)]
        public FieldType Type { get; set; }

        /// <summary>
        /// Field rectangle.
        /// </summary>
        /// <value>Field rectangle.</value>
        [DataMember(Name="Rect", EmitDefaultValue=false)]
        public Rectangle Rect { get; set; }

        /// <summary>
        /// Field values.
        /// </summary>
        /// <value>Field values.</value>
        [DataMember(Name="Values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Field {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SelectedItems: ").Append(SelectedItems).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Rect: ").Append(Rect).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as Field);
        }

        /// <summary>
        /// Returns true if Field instances are equal
        /// </summary>
        /// <param name="other">Instance of Field to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Field other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SelectedItems == other.SelectedItems ||
                    this.SelectedItems != null &&
                    this.SelectedItems.SequenceEqual(other.SelectedItems)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Rect == other.Rect ||
                    this.Rect != null &&
                    this.Rect.Equals(other.Rect)
                ) && 
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SelectedItems != null)
                    hash = hash * 59 + this.SelectedItems.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Rect != null)
                    hash = hash * 59 + this.Rect.GetHashCode();
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
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
