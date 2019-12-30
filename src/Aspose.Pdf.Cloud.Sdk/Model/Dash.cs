// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Dash.cs">
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
    /// Class representing line dash pattern.
    /// </summary>
    [DataContract]
    public partial class Dash :  IEquatable<Dash>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dash" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Dash() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dash" /> class.
        /// </summary>
        /// <param name="On">Gets or sets length of dash. (required)</param>
        /// <param name="Off">Gets or sets length of gap between dashes. (required)</param>
        public Dash(int? On = default(int?), int? Off = default(int?))
        {
            // to ensure "On" is required (not null)
            if (On == null)
            {
                throw new InvalidDataException("On is a required property for Dash and cannot be null");
            }
            else
            {
                this.On = On;
            }
            // to ensure "Off" is required (not null)
            if (Off == null)
            {
                throw new InvalidDataException("Off is a required property for Dash and cannot be null");
            }
            else
            {
                this.Off = Off;
            }
        }
        
        /// <summary>
        /// Gets or sets length of dash.
        /// </summary>
        /// <value>Gets or sets length of dash.</value>
        [DataMember(Name="On", EmitDefaultValue=false)]
        public int? On { get; set; }

        /// <summary>
        /// Gets or sets length of gap between dashes.
        /// </summary>
        /// <value>Gets or sets length of gap between dashes.</value>
        [DataMember(Name="Off", EmitDefaultValue=false)]
        public int? Off { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dash {\n");
            sb.Append("  On: ").Append(On).Append("\n");
            sb.Append("  Off: ").Append(Off).Append("\n");
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
            return this.Equals(obj as Dash);
        }

        /// <summary>
        /// Returns true if Dash instances are equal
        /// </summary>
        /// <param name="other">Instance of Dash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dash other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.On == other.On ||
                    this.On != null &&
                    this.On.Equals(other.On)
                ) && 
                (
                    this.Off == other.Off ||
                    this.Off != null &&
                    this.Off.Equals(other.Off)
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
                if (this.On != null)
                    hash = hash * 59 + this.On.GetHashCode();
                if (this.Off != null)
                    hash = hash * 59 + this.Off.GetHashCode();
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
