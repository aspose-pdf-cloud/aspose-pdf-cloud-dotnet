// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LinkAnnotation.cs">
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
    /// Provides link to linkAnnotation.
    /// </summary>
    [DataContract]
    public partial class LinkAnnotation : LinkElement,  IEquatable<LinkAnnotation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkAnnotation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkAnnotation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkAnnotation" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="ActionType">ActionType (required)</param>
        /// <param name="Action">Action (required)</param>
        /// <param name="Highlighting">Highlighting (required)</param>
        /// <param name="Color">Color</param>
        /// <param name="Rect">Rect (required)</param>
        /// <param name="Id">Id</param>
        public LinkAnnotation(List<Link> Links = default(List<Link>), LinkActionType ActionType = default(LinkActionType), string Action = default(string), LinkHighlightingMode Highlighting = default(LinkHighlightingMode), Color Color = default(Color), Rectangle Rect = default(Rectangle), string Id = default(string))
        {
            // to ensure "ActionType" is required (not null)
            if (ActionType == null)
            {
                throw new InvalidDataException("ActionType is a required property for LinkAnnotation and cannot be null");
            }
            else
            {
                this.ActionType = ActionType;
            }
            // to ensure "Action" is required (not null)
            if (Action == null)
            {
                throw new InvalidDataException("Action is a required property for LinkAnnotation and cannot be null");
            }
            else
            {
                this.Action = Action;
            }
            // to ensure "Highlighting" is required (not null)
            if (Highlighting == null)
            {
                throw new InvalidDataException("Highlighting is a required property for LinkAnnotation and cannot be null");
            }
            else
            {
                this.Highlighting = Highlighting;
            }
            // to ensure "Rect" is required (not null)
            if (Rect == null)
            {
                throw new InvalidDataException("Rect is a required property for LinkAnnotation and cannot be null");
            }
            else
            {
                this.Rect = Rect;
            }
            this.Links = Links;
            this.Color = Color;
            this.Id = Id;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [DataMember(Name="ActionType", EmitDefaultValue=true)]
        public LinkActionType ActionType { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="Action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Highlighting
        /// </summary>
        [DataMember(Name="Highlighting", EmitDefaultValue=true)]
        public LinkHighlightingMode Highlighting { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Gets or Sets Rect
        /// </summary>
        [DataMember(Name="Rect", EmitDefaultValue=false)]
        public Rectangle Rect { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkAnnotation {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Highlighting: ").Append(Highlighting).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Rect: ").Append(Rect).Append("\n");
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
            return this.Equals(obj as LinkAnnotation);
        }

        /// <summary>
        /// Returns true if LinkAnnotation instances are equal
        /// </summary>
        /// <param name="other">Instance of LinkAnnotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkAnnotation other)
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
                    this.ActionType == other.ActionType ||
                    this.ActionType != null &&
                    this.ActionType.Equals(other.ActionType)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.Highlighting == other.Highlighting ||
                    this.Highlighting != null &&
                    this.Highlighting.Equals(other.Highlighting)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Rect == other.Rect ||
                    this.Rect != null &&
                    this.Rect.Equals(other.Rect)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.ActionType != null)
                    hash = hash * 59 + this.ActionType.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.Highlighting != null)
                    hash = hash * 59 + this.Highlighting.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Rect != null)
                    hash = hash * 59 + this.Rect.GetHashCode();
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
            // Action (string) minLength
            if(this.Action != null && this.Action.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Action, length must be greater than 1.", new [] { "Action" });
            }

            yield break;
        }
    }

}
