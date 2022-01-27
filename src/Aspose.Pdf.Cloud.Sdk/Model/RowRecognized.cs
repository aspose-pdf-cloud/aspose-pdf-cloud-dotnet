// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RowRecognized.cs">
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
    /// RowRecognized
    /// </summary>
    [DataContract]
    public partial class RowRecognized :  IEquatable<RowRecognized>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RowRecognized" /> class.
        /// </summary>
        /// <param name="CellList">Gets readonly IList containing cells of the row</param>
        /// <param name="Rectangle">Gets rectangle that describes position of the row on page</param>
        public RowRecognized(List<CellRecognized> CellList = default(List<CellRecognized>), Rectangle Rectangle = default(Rectangle))
        {
            this.CellList = CellList;
            this.Rectangle = Rectangle;
        }
        
        /// <summary>
        /// Gets readonly IList containing cells of the row
        /// </summary>
        /// <value>Gets readonly IList containing cells of the row</value>
        [DataMember(Name="CellList", EmitDefaultValue=false)]
        public List<CellRecognized> CellList { get; set; }

        /// <summary>
        /// Gets rectangle that describes position of the row on page
        /// </summary>
        /// <value>Gets rectangle that describes position of the row on page</value>
        [DataMember(Name="Rectangle", EmitDefaultValue=false)]
        public Rectangle Rectangle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RowRecognized {\n");
            sb.Append("  CellList: ").Append(CellList).Append("\n");
            sb.Append("  Rectangle: ").Append(Rectangle).Append("\n");
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
            return this.Equals(obj as RowRecognized);
        }

        /// <summary>
        /// Returns true if RowRecognized instances are equal
        /// </summary>
        /// <param name="other">Instance of RowRecognized to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RowRecognized other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CellList == other.CellList ||
                    this.CellList != null &&
                    this.CellList.SequenceEqual(other.CellList)
                ) && 
                (
                    this.Rectangle == other.Rectangle ||
                    this.Rectangle != null &&
                    this.Rectangle.Equals(other.Rectangle)
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
                if (this.CellList != null)
                    hash = hash * 59 + this.CellList.GetHashCode();
                if (this.Rectangle != null)
                    hash = hash * 59 + this.Rectangle.GetHashCode();
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
