// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Option.cs">
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
    /// Provides form option.
    /// </summary>
    [DataContract]
    public partial class Option :  IEquatable<Option>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Option" /> class.
        /// </summary>
        /// <param name="Value">Gets or sets option export value.</param>
        /// <param name="Name">Gets or sets name of option.</param>
        /// <param name="Selected">Gets or sets selected status of option. Returns true if option is selected.</param>
        /// <param name="Index">Gets index of the option. </param>
        public Option(string Value = default(string), string Name = default(string), bool? Selected = default(bool?), int? Index = default(int?))
        {
            this.Value = Value;
            this.Name = Name;
            this.Selected = Selected;
            this.Index = Index;
        }
        
        /// <summary>
        /// Gets or sets option export value.
        /// </summary>
        /// <value>Gets or sets option export value.</value>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets name of option.
        /// </summary>
        /// <value>Gets or sets name of option.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets selected status of option. Returns true if option is selected.
        /// </summary>
        /// <value>Gets or sets selected status of option. Returns true if option is selected.</value>
        [DataMember(Name="Selected", EmitDefaultValue=false)]
        public bool? Selected { get; set; }

        /// <summary>
        /// Gets index of the option. 
        /// </summary>
        /// <value>Gets index of the option. </value>
        [DataMember(Name="Index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Option {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
            return this.Equals(obj as Option);
        }

        /// <summary>
        /// Returns true if Option instances are equal
        /// </summary>
        /// <param name="other">Instance of Option to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Option other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Selected == other.Selected ||
                    this.Selected != null &&
                    this.Selected.Equals(other.Selected)
                ) && 
                (
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Selected != null)
                    hash = hash * 59 + this.Selected.GetHashCode();
                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();
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
