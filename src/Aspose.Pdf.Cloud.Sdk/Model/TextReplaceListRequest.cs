// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextReplaceListRequest.cs">
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
    /// Multiple text replacements request.
    /// </summary>
    [DataContract]
    public partial class TextReplaceListRequest :  IEquatable<TextReplaceListRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextReplaceListRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextReplaceListRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextReplaceListRequest" /> class.
        /// </summary>
        /// <param name="TextReplaces">A list of text replacement settings. (required).</param>
        /// <param name="DefaultFont">DefaultFont.</param>
        /// <param name="StartIndex">The index of first match to be replaced..</param>
        /// <param name="CountReplace">The number of matches to be replaced..</param>
        public TextReplaceListRequest(List<TextReplace> TextReplaces = default(List<TextReplace>), string DefaultFont = default(string), int? StartIndex = default(int?), int? CountReplace = default(int?))
        {
            // to ensure "TextReplaces" is required (not null)
            if (TextReplaces == null)
            {
                throw new InvalidDataException("TextReplaces is a required property for TextReplaceListRequest and cannot be null");
            }
            else
            {
                this.TextReplaces = TextReplaces;
            }
            this.DefaultFont = DefaultFont;
            this.StartIndex = StartIndex;
            this.CountReplace = CountReplace;
        }
        
        /// <summary>
        /// A list of text replacement settings.
        /// </summary>
        /// <value>A list of text replacement settings.</value>
        [DataMember(Name="TextReplaces", EmitDefaultValue=false)]
        public List<TextReplace> TextReplaces { get; set; }

        /// <summary>
        /// Gets or Sets DefaultFont
        /// </summary>
        [DataMember(Name="DefaultFont", EmitDefaultValue=false)]
        public string DefaultFont { get; set; }

        /// <summary>
        /// The index of first match to be replaced.
        /// </summary>
        /// <value>The index of first match to be replaced.</value>
        [DataMember(Name="StartIndex", EmitDefaultValue=false)]
        public int? StartIndex { get; set; }

        /// <summary>
        /// The number of matches to be replaced.
        /// </summary>
        /// <value>The number of matches to be replaced.</value>
        [DataMember(Name="CountReplace", EmitDefaultValue=false)]
        public int? CountReplace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextReplaceListRequest {\n");
            sb.Append("  TextReplaces: ").Append(TextReplaces).Append("\n");
            sb.Append("  DefaultFont: ").Append(DefaultFont).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  CountReplace: ").Append(CountReplace).Append("\n");
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
            return this.Equals(obj as TextReplaceListRequest);
        }

        /// <summary>
        /// Returns true if TextReplaceListRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TextReplaceListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextReplaceListRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TextReplaces == other.TextReplaces ||
                    this.TextReplaces != null &&
                    this.TextReplaces.SequenceEqual(other.TextReplaces)
                ) && 
                (
                    this.DefaultFont == other.DefaultFont ||
                    this.DefaultFont != null &&
                    this.DefaultFont.Equals(other.DefaultFont)
                ) && 
                (
                    this.StartIndex == other.StartIndex ||
                    this.StartIndex != null &&
                    this.StartIndex.Equals(other.StartIndex)
                ) && 
                (
                    this.CountReplace == other.CountReplace ||
                    this.CountReplace != null &&
                    this.CountReplace.Equals(other.CountReplace)
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
                if (this.TextReplaces != null)
                    hash = hash * 59 + this.TextReplaces.GetHashCode();
                if (this.DefaultFont != null)
                    hash = hash * 59 + this.DefaultFont.GetHashCode();
                if (this.StartIndex != null)
                    hash = hash * 59 + this.StartIndex.GetHashCode();
                if (this.CountReplace != null)
                    hash = hash * 59 + this.CountReplace.GetHashCode();
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
