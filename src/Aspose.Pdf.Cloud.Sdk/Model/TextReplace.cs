// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextReplace.cs">
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
    /// Single text replacement setting.
    /// </summary>
    [DataContract]
    public partial class TextReplace :  IEquatable<TextReplace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextReplace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextReplace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextReplace" /> class.
        /// </summary>
        /// <param name="OldValue">Original text. (required).</param>
        /// <param name="NewValue">New text. (required).</param>
        /// <param name="Regex">Gets or sets a value indicating whether search text is regular expression. (required).</param>
        /// <param name="TextState">Text properties of a new text..</param>
        /// <param name="Rect">Rectangle area where searched original text..</param>
        public TextReplace(string OldValue = default(string), string NewValue = default(string), bool? Regex = default(bool?), TextState TextState = default(TextState), RectanglePdf Rect = default(RectanglePdf))
        {
            // to ensure "OldValue" is required (not null)
            if (OldValue == null)
            {
                throw new InvalidDataException("OldValue is a required property for TextReplace and cannot be null");
            }
            else
            {
                this.OldValue = OldValue;
            }
            // to ensure "NewValue" is required (not null)
            if (NewValue == null)
            {
                throw new InvalidDataException("NewValue is a required property for TextReplace and cannot be null");
            }
            else
            {
                this.NewValue = NewValue;
            }
            // to ensure "Regex" is required (not null)
            if (Regex == null)
            {
                throw new InvalidDataException("Regex is a required property for TextReplace and cannot be null");
            }
            else
            {
                this.Regex = Regex;
            }
            this.TextState = TextState;
            this.Rect = Rect;
        }
        
        /// <summary>
        /// Original text.
        /// </summary>
        /// <value>Original text.</value>
        [DataMember(Name="OldValue", EmitDefaultValue=false)]
        public string OldValue { get; set; }

        /// <summary>
        /// New text.
        /// </summary>
        /// <value>New text.</value>
        [DataMember(Name="NewValue", EmitDefaultValue=false)]
        public string NewValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether search text is regular expression.
        /// </summary>
        /// <value>Gets or sets a value indicating whether search text is regular expression.</value>
        [DataMember(Name="Regex", EmitDefaultValue=false)]
        public bool? Regex { get; set; }

        /// <summary>
        /// Text properties of a new text.
        /// </summary>
        /// <value>Text properties of a new text.</value>
        [DataMember(Name="TextState", EmitDefaultValue=false)]
        public TextState TextState { get; set; }

        /// <summary>
        /// Rectangle area where searched original text.
        /// </summary>
        /// <value>Rectangle area where searched original text.</value>
        [DataMember(Name="Rect", EmitDefaultValue=false)]
        public RectanglePdf Rect { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextReplace {\n");
            sb.Append("  OldValue: ").Append(OldValue).Append("\n");
            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
            sb.Append("  Regex: ").Append(Regex).Append("\n");
            sb.Append("  TextState: ").Append(TextState).Append("\n");
            sb.Append("  Rect: ").Append(Rect).Append("\n");
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
            return this.Equals(obj as TextReplace);
        }

        /// <summary>
        /// Returns true if TextReplace instances are equal
        /// </summary>
        /// <param name="other">Instance of TextReplace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextReplace other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OldValue == other.OldValue ||
                    this.OldValue != null &&
                    this.OldValue.Equals(other.OldValue)
                ) && 
                (
                    this.NewValue == other.NewValue ||
                    this.NewValue != null &&
                    this.NewValue.Equals(other.NewValue)
                ) && 
                (
                    this.Regex == other.Regex ||
                    this.Regex != null &&
                    this.Regex.Equals(other.Regex)
                ) && 
                (
                    this.TextState == other.TextState ||
                    this.TextState != null &&
                    this.TextState.Equals(other.TextState)
                ) && 
                (
                    this.Rect == other.Rect ||
                    this.Rect != null &&
                    this.Rect.Equals(other.Rect)
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
                if (this.OldValue != null)
                    hash = hash * 59 + this.OldValue.GetHashCode();
                if (this.NewValue != null)
                    hash = hash * 59 + this.NewValue.GetHashCode();
                if (this.Regex != null)
                    hash = hash * 59 + this.Regex.GetHashCode();
                if (this.TextState != null)
                    hash = hash * 59 + this.TextState.GetHashCode();
                if (this.Rect != null)
                    hash = hash * 59 + this.Rect.GetHashCode();
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
