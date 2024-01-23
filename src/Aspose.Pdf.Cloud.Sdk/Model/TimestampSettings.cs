// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TimestampSettings.cs">
//   Copyright (c) 2024 Aspose.PDF Cloud
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
    /// Represents the ocsp settings using during signing process.
    /// </summary>
    [DataContract]
    public partial class TimestampSettings :  IEquatable<TimestampSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampSettings" /> class.
        /// </summary>
        /// <param name="ServerUrl">Gets/sets the timestamp server url.</param>
        /// <param name="BasicAuthCredentials">Gets/sets the basic authentication credentials, Username and password are combined into a string \&quot;username:password\&quot;.</param>
        public TimestampSettings(string ServerUrl = default(string), string BasicAuthCredentials = default(string))
        {
            this.ServerUrl = ServerUrl;
            this.BasicAuthCredentials = BasicAuthCredentials;
        }
        
        /// <summary>
        /// Gets/sets the timestamp server url.
        /// </summary>
        /// <value>Gets/sets the timestamp server url.</value>
        [DataMember(Name="ServerUrl", EmitDefaultValue=false)]
        public string ServerUrl { get; set; }

        /// <summary>
        /// Gets/sets the basic authentication credentials, Username and password are combined into a string \&quot;username:password\&quot;.
        /// </summary>
        /// <value>Gets/sets the basic authentication credentials, Username and password are combined into a string \&quot;username:password\&quot;.</value>
        [DataMember(Name="BasicAuthCredentials", EmitDefaultValue=false)]
        public string BasicAuthCredentials { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimestampSettings {\n");
            sb.Append("  ServerUrl: ").Append(ServerUrl).Append("\n");
            sb.Append("  BasicAuthCredentials: ").Append(BasicAuthCredentials).Append("\n");
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
            return this.Equals(obj as TimestampSettings);
        }

        /// <summary>
        /// Returns true if TimestampSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of TimestampSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimestampSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ServerUrl == other.ServerUrl ||
                    this.ServerUrl != null &&
                    this.ServerUrl.Equals(other.ServerUrl)
                ) && 
                (
                    this.BasicAuthCredentials == other.BasicAuthCredentials ||
                    this.BasicAuthCredentials != null &&
                    this.BasicAuthCredentials.Equals(other.BasicAuthCredentials)
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
                if (this.ServerUrl != null)
                    hash = hash * 59 + this.ServerUrl.GetHashCode();
                if (this.BasicAuthCredentials != null)
                    hash = hash * 59 + this.BasicAuthCredentials.GetHashCode();
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
