// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AppendDocument.cs">
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
    /// Class for appendDocument service request building.
    /// </summary>
    [DataContract]
    public partial class AppendDocument :  IEquatable<AppendDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppendDocument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppendDocument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppendDocument" /> class.
        /// </summary>
        /// <param name="Document">Document to append (server path). (required).</param>
        /// <param name="StartPage">Appending start page. (required).</param>
        /// <param name="EndPage">Appending end page. (required).</param>
        public AppendDocument(string Document = default(string), int? StartPage = default(int?), int? EndPage = default(int?))
        {
            // to ensure "Document" is required (not null)
            if (Document == null)
            {
                throw new InvalidDataException("Document is a required property for AppendDocument and cannot be null");
            }
            else
            {
                this.Document = Document;
            }
            // to ensure "StartPage" is required (not null)
            if (StartPage == null)
            {
                throw new InvalidDataException("StartPage is a required property for AppendDocument and cannot be null");
            }
            else
            {
                this.StartPage = StartPage;
            }
            // to ensure "EndPage" is required (not null)
            if (EndPage == null)
            {
                throw new InvalidDataException("EndPage is a required property for AppendDocument and cannot be null");
            }
            else
            {
                this.EndPage = EndPage;
            }
        }
        
        /// <summary>
        /// Document to append (server path).
        /// </summary>
        /// <value>Document to append (server path).</value>
        [DataMember(Name="Document", EmitDefaultValue=false)]
        public string Document { get; set; }

        /// <summary>
        /// Appending start page.
        /// </summary>
        /// <value>Appending start page.</value>
        [DataMember(Name="StartPage", EmitDefaultValue=false)]
        public int? StartPage { get; set; }

        /// <summary>
        /// Appending end page.
        /// </summary>
        /// <value>Appending end page.</value>
        [DataMember(Name="EndPage", EmitDefaultValue=false)]
        public int? EndPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppendDocument {\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  StartPage: ").Append(StartPage).Append("\n");
            sb.Append("  EndPage: ").Append(EndPage).Append("\n");
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
            return this.Equals(obj as AppendDocument);
        }

        /// <summary>
        /// Returns true if AppendDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of AppendDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppendDocument other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Document == other.Document ||
                    this.Document != null &&
                    this.Document.Equals(other.Document)
                ) && 
                (
                    this.StartPage == other.StartPage ||
                    this.StartPage != null &&
                    this.StartPage.Equals(other.StartPage)
                ) && 
                (
                    this.EndPage == other.EndPage ||
                    this.EndPage != null &&
                    this.EndPage.Equals(other.EndPage)
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
                if (this.Document != null)
                    hash = hash * 59 + this.Document.GetHashCode();
                if (this.StartPage != null)
                    hash = hash * 59 + this.StartPage.GetHashCode();
                if (this.EndPage != null)
                    hash = hash * 59 + this.EndPage.GetHashCode();
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
