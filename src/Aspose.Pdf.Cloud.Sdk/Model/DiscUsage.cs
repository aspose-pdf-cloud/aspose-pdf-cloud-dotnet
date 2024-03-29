﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DiscUsage.cs">
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
    /// Class for disc space information.
    /// </summary>
    [DataContract]
    public partial class DiscUsage :  IEquatable<DiscUsage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DiscUsage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscUsage" /> class.
        /// </summary>
        /// <param name="UsedSize">Application used disc space. (required)</param>
        /// <param name="TotalSize">Total disc space. (required)</param>
        public DiscUsage(long? UsedSize = default(long?), long? TotalSize = default(long?))
        {
            // to ensure "UsedSize" is required (not null)
            if (UsedSize == null)
            {
                throw new InvalidDataException("UsedSize is a required property for DiscUsage and cannot be null");
            }
            else
            {
                this.UsedSize = UsedSize;
            }
            // to ensure "TotalSize" is required (not null)
            if (TotalSize == null)
            {
                throw new InvalidDataException("TotalSize is a required property for DiscUsage and cannot be null");
            }
            else
            {
                this.TotalSize = TotalSize;
            }
        }
        
        /// <summary>
        /// Application used disc space.
        /// </summary>
        /// <value>Application used disc space.</value>
        [DataMember(Name="UsedSize", EmitDefaultValue=false)]
        public long? UsedSize { get; set; }

        /// <summary>
        /// Total disc space.
        /// </summary>
        /// <value>Total disc space.</value>
        [DataMember(Name="TotalSize", EmitDefaultValue=false)]
        public long? TotalSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscUsage {\n");
            sb.Append("  UsedSize: ").Append(UsedSize).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
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
            return this.Equals(obj as DiscUsage);
        }

        /// <summary>
        /// Returns true if DiscUsage instances are equal
        /// </summary>
        /// <param name="other">Instance of DiscUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscUsage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UsedSize == other.UsedSize ||
                    this.UsedSize != null &&
                    this.UsedSize.Equals(other.UsedSize)
                ) && 
                (
                    this.TotalSize == other.TotalSize ||
                    this.TotalSize != null &&
                    this.TotalSize.Equals(other.TotalSize)
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
                if (this.UsedSize != null)
                    hash = hash * 59 + this.UsedSize.GetHashCode();
                if (this.TotalSize != null)
                    hash = hash * 59 + this.TotalSize.GetHashCode();
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
