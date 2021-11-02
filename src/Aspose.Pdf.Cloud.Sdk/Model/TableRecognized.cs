// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableRecognized.cs">
//   Copyright (c) 2021 Aspose.PDF Cloud
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
    /// TableRecognized
    /// </summary>
    [DataContract]
    public partial class TableRecognized : LinkElement,  IEquatable<TableRecognized>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableRecognized" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="RowList">Gets readonly IList containing rows of the table</param>
        /// <param name="Rectangle">Gets rectangle that describes position of the table on page</param>
        /// <param name="PageNum">Gets number of the page containing this table</param>
        /// <param name="Id">Gets ID of the table.</param>
        public TableRecognized(List<Link> Links = default(List<Link>), List<RowRecognized> RowList = default(List<RowRecognized>), Rectangle Rectangle = default(Rectangle), int? PageNum = default(int?), string Id = default(string))
        {
            this.Links = Links;
            this.RowList = RowList;
            this.Rectangle = Rectangle;
            this.PageNum = PageNum;
            this.Id = Id;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets readonly IList containing rows of the table
        /// </summary>
        /// <value>Gets readonly IList containing rows of the table</value>
        [DataMember(Name="RowList", EmitDefaultValue=false)]
        public List<RowRecognized> RowList { get; set; }

        /// <summary>
        /// Gets rectangle that describes position of the table on page
        /// </summary>
        /// <value>Gets rectangle that describes position of the table on page</value>
        [DataMember(Name="Rectangle", EmitDefaultValue=false)]
        public Rectangle Rectangle { get; set; }

        /// <summary>
        /// Gets number of the page containing this table
        /// </summary>
        /// <value>Gets number of the page containing this table</value>
        [DataMember(Name="PageNum", EmitDefaultValue=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// Gets ID of the table.
        /// </summary>
        /// <value>Gets ID of the table.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableRecognized {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  RowList: ").Append(RowList).Append("\n");
            sb.Append("  Rectangle: ").Append(Rectangle).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
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
            return this.Equals(obj as TableRecognized);
        }

        /// <summary>
        /// Returns true if TableRecognized instances are equal
        /// </summary>
        /// <param name="other">Instance of TableRecognized to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableRecognized other)
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
                    this.RowList == other.RowList ||
                    this.RowList != null &&
                    this.RowList.SequenceEqual(other.RowList)
                ) && 
                (
                    this.Rectangle == other.Rectangle ||
                    this.Rectangle != null &&
                    this.Rectangle.Equals(other.Rectangle)
                ) && 
                (
                    this.PageNum == other.PageNum ||
                    this.PageNum != null &&
                    this.PageNum.Equals(other.PageNum)
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
                if (this.RowList != null)
                    hash = hash * 59 + this.RowList.GetHashCode();
                if (this.Rectangle != null)
                    hash = hash * 59 + this.Rectangle.GetHashCode();
                if (this.PageNum != null)
                    hash = hash * 59 + this.PageNum.GetHashCode();
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
            yield break;
        }
    }

}
