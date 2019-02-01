// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentPrivilege.cs">
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
    /// Represents the privileges for accessing Pdf file./&gt;.
    /// </summary>
    [DataContract]
    public partial class DocumentPrivilege :  IEquatable<DocumentPrivilege>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentPrivilege" /> class.
        /// </summary>
        /// <param name="AllowPrint">Sets the permission which allow print or not.  true is allow and false or not set is forbidden..</param>
        /// <param name="AllowDegradedPrinting">Sets the permission which allow degraded printing or not.  true is allow and false or not set is forbidden..</param>
        /// <param name="AllowModifyContents">Sets the permission which allow modify contents or not.  true is allow and false or not set is forbidden..</param>
        /// <param name="AllowCopy">Sets the permission which allow copy or not.  true is allow and false or not set is forbidden..</param>
        /// <param name="AllowModifyAnnotations">Sets the permission which allow modify annotations or not.  true is allow and false or not set is forbidden..</param>
        /// <param name="AllowFillIn">Sets the permission which allow fill in forms or not.  true is allow and false or not set is forbidden..</param>
        /// <param name="AllowScreenReaders">Sets the permission which allow screen readers or not.  true is allow and false or not set is forbidden..</param>
        /// <param name="AllowAssembly">Sets the permission which allow assembly or not.  true is allow and false or not set is forbidden..</param>
        /// <param name="PrintAllowLevel">Sets the print level of  document&#39;s privilege. Just as the Adobe Professional&#39;s Printing Allowed settings. 0: None. 1: Low Resolution (150 dpi). 2: High Resolution..</param>
        /// <param name="ChangeAllowLevel">Sets the change level of  document&#39;s privilege. Just as the Adobe Professional&#39;s Changes Allowed settings. 0: None. 1: Inserting, Deleting and Rotating pages. 2: Filling in form fields and signing existing signature fields. 3: Commenting, filling in form fields, and signing existing signature fields. 4: Any except extracting pages..</param>
        /// <param name="CopyAllowLevel">Sets the copy level of  document&#39;s privilege. Just as the Adobe Professional&#39;s permission settings. 0: None. 1: Enable text access for screen reader devices for the visually impaired. 2: Enable copying of text, images and other content..</param>
        public DocumentPrivilege(bool? AllowPrint = default(bool?), bool? AllowDegradedPrinting = default(bool?), bool? AllowModifyContents = default(bool?), bool? AllowCopy = default(bool?), bool? AllowModifyAnnotations = default(bool?), bool? AllowFillIn = default(bool?), bool? AllowScreenReaders = default(bool?), bool? AllowAssembly = default(bool?), int? PrintAllowLevel = default(int?), int? ChangeAllowLevel = default(int?), int? CopyAllowLevel = default(int?))
        {
            this.AllowPrint = AllowPrint;
            this.AllowDegradedPrinting = AllowDegradedPrinting;
            this.AllowModifyContents = AllowModifyContents;
            this.AllowCopy = AllowCopy;
            this.AllowModifyAnnotations = AllowModifyAnnotations;
            this.AllowFillIn = AllowFillIn;
            this.AllowScreenReaders = AllowScreenReaders;
            this.AllowAssembly = AllowAssembly;
            this.PrintAllowLevel = PrintAllowLevel;
            this.ChangeAllowLevel = ChangeAllowLevel;
            this.CopyAllowLevel = CopyAllowLevel;
        }
        
        /// <summary>
        /// Sets the permission which allow print or not.  true is allow and false or not set is forbidden.
        /// </summary>
        /// <value>Sets the permission which allow print or not.  true is allow and false or not set is forbidden.</value>
        [DataMember(Name="AllowPrint", EmitDefaultValue=false)]
        public bool? AllowPrint { get; set; }

        /// <summary>
        /// Sets the permission which allow degraded printing or not.  true is allow and false or not set is forbidden.
        /// </summary>
        /// <value>Sets the permission which allow degraded printing or not.  true is allow and false or not set is forbidden.</value>
        [DataMember(Name="AllowDegradedPrinting", EmitDefaultValue=false)]
        public bool? AllowDegradedPrinting { get; set; }

        /// <summary>
        /// Sets the permission which allow modify contents or not.  true is allow and false or not set is forbidden.
        /// </summary>
        /// <value>Sets the permission which allow modify contents or not.  true is allow and false or not set is forbidden.</value>
        [DataMember(Name="AllowModifyContents", EmitDefaultValue=false)]
        public bool? AllowModifyContents { get; set; }

        /// <summary>
        /// Sets the permission which allow copy or not.  true is allow and false or not set is forbidden.
        /// </summary>
        /// <value>Sets the permission which allow copy or not.  true is allow and false or not set is forbidden.</value>
        [DataMember(Name="AllowCopy", EmitDefaultValue=false)]
        public bool? AllowCopy { get; set; }

        /// <summary>
        /// Sets the permission which allow modify annotations or not.  true is allow and false or not set is forbidden.
        /// </summary>
        /// <value>Sets the permission which allow modify annotations or not.  true is allow and false or not set is forbidden.</value>
        [DataMember(Name="AllowModifyAnnotations", EmitDefaultValue=false)]
        public bool? AllowModifyAnnotations { get; set; }

        /// <summary>
        /// Sets the permission which allow fill in forms or not.  true is allow and false or not set is forbidden.
        /// </summary>
        /// <value>Sets the permission which allow fill in forms or not.  true is allow and false or not set is forbidden.</value>
        [DataMember(Name="AllowFillIn", EmitDefaultValue=false)]
        public bool? AllowFillIn { get; set; }

        /// <summary>
        /// Sets the permission which allow screen readers or not.  true is allow and false or not set is forbidden.
        /// </summary>
        /// <value>Sets the permission which allow screen readers or not.  true is allow and false or not set is forbidden.</value>
        [DataMember(Name="AllowScreenReaders", EmitDefaultValue=false)]
        public bool? AllowScreenReaders { get; set; }

        /// <summary>
        /// Sets the permission which allow assembly or not.  true is allow and false or not set is forbidden.
        /// </summary>
        /// <value>Sets the permission which allow assembly or not.  true is allow and false or not set is forbidden.</value>
        [DataMember(Name="AllowAssembly", EmitDefaultValue=false)]
        public bool? AllowAssembly { get; set; }

        /// <summary>
        /// Sets the print level of  document&#39;s privilege. Just as the Adobe Professional&#39;s Printing Allowed settings. 0: None. 1: Low Resolution (150 dpi). 2: High Resolution.
        /// </summary>
        /// <value>Sets the print level of  document&#39;s privilege. Just as the Adobe Professional&#39;s Printing Allowed settings. 0: None. 1: Low Resolution (150 dpi). 2: High Resolution.</value>
        [DataMember(Name="PrintAllowLevel", EmitDefaultValue=false)]
        public int? PrintAllowLevel { get; set; }

        /// <summary>
        /// Sets the change level of  document&#39;s privilege. Just as the Adobe Professional&#39;s Changes Allowed settings. 0: None. 1: Inserting, Deleting and Rotating pages. 2: Filling in form fields and signing existing signature fields. 3: Commenting, filling in form fields, and signing existing signature fields. 4: Any except extracting pages.
        /// </summary>
        /// <value>Sets the change level of  document&#39;s privilege. Just as the Adobe Professional&#39;s Changes Allowed settings. 0: None. 1: Inserting, Deleting and Rotating pages. 2: Filling in form fields and signing existing signature fields. 3: Commenting, filling in form fields, and signing existing signature fields. 4: Any except extracting pages.</value>
        [DataMember(Name="ChangeAllowLevel", EmitDefaultValue=false)]
        public int? ChangeAllowLevel { get; set; }

        /// <summary>
        /// Sets the copy level of  document&#39;s privilege. Just as the Adobe Professional&#39;s permission settings. 0: None. 1: Enable text access for screen reader devices for the visually impaired. 2: Enable copying of text, images and other content.
        /// </summary>
        /// <value>Sets the copy level of  document&#39;s privilege. Just as the Adobe Professional&#39;s permission settings. 0: None. 1: Enable text access for screen reader devices for the visually impaired. 2: Enable copying of text, images and other content.</value>
        [DataMember(Name="CopyAllowLevel", EmitDefaultValue=false)]
        public int? CopyAllowLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentPrivilege {\n");
            sb.Append("  AllowPrint: ").Append(AllowPrint).Append("\n");
            sb.Append("  AllowDegradedPrinting: ").Append(AllowDegradedPrinting).Append("\n");
            sb.Append("  AllowModifyContents: ").Append(AllowModifyContents).Append("\n");
            sb.Append("  AllowCopy: ").Append(AllowCopy).Append("\n");
            sb.Append("  AllowModifyAnnotations: ").Append(AllowModifyAnnotations).Append("\n");
            sb.Append("  AllowFillIn: ").Append(AllowFillIn).Append("\n");
            sb.Append("  AllowScreenReaders: ").Append(AllowScreenReaders).Append("\n");
            sb.Append("  AllowAssembly: ").Append(AllowAssembly).Append("\n");
            sb.Append("  PrintAllowLevel: ").Append(PrintAllowLevel).Append("\n");
            sb.Append("  ChangeAllowLevel: ").Append(ChangeAllowLevel).Append("\n");
            sb.Append("  CopyAllowLevel: ").Append(CopyAllowLevel).Append("\n");
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
            return this.Equals(obj as DocumentPrivilege);
        }

        /// <summary>
        /// Returns true if DocumentPrivilege instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentPrivilege to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentPrivilege other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowPrint == other.AllowPrint ||
                    this.AllowPrint != null &&
                    this.AllowPrint.Equals(other.AllowPrint)
                ) && 
                (
                    this.AllowDegradedPrinting == other.AllowDegradedPrinting ||
                    this.AllowDegradedPrinting != null &&
                    this.AllowDegradedPrinting.Equals(other.AllowDegradedPrinting)
                ) && 
                (
                    this.AllowModifyContents == other.AllowModifyContents ||
                    this.AllowModifyContents != null &&
                    this.AllowModifyContents.Equals(other.AllowModifyContents)
                ) && 
                (
                    this.AllowCopy == other.AllowCopy ||
                    this.AllowCopy != null &&
                    this.AllowCopy.Equals(other.AllowCopy)
                ) && 
                (
                    this.AllowModifyAnnotations == other.AllowModifyAnnotations ||
                    this.AllowModifyAnnotations != null &&
                    this.AllowModifyAnnotations.Equals(other.AllowModifyAnnotations)
                ) && 
                (
                    this.AllowFillIn == other.AllowFillIn ||
                    this.AllowFillIn != null &&
                    this.AllowFillIn.Equals(other.AllowFillIn)
                ) && 
                (
                    this.AllowScreenReaders == other.AllowScreenReaders ||
                    this.AllowScreenReaders != null &&
                    this.AllowScreenReaders.Equals(other.AllowScreenReaders)
                ) && 
                (
                    this.AllowAssembly == other.AllowAssembly ||
                    this.AllowAssembly != null &&
                    this.AllowAssembly.Equals(other.AllowAssembly)
                ) && 
                (
                    this.PrintAllowLevel == other.PrintAllowLevel ||
                    this.PrintAllowLevel != null &&
                    this.PrintAllowLevel.Equals(other.PrintAllowLevel)
                ) && 
                (
                    this.ChangeAllowLevel == other.ChangeAllowLevel ||
                    this.ChangeAllowLevel != null &&
                    this.ChangeAllowLevel.Equals(other.ChangeAllowLevel)
                ) && 
                (
                    this.CopyAllowLevel == other.CopyAllowLevel ||
                    this.CopyAllowLevel != null &&
                    this.CopyAllowLevel.Equals(other.CopyAllowLevel)
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
                if (this.AllowPrint != null)
                    hash = hash * 59 + this.AllowPrint.GetHashCode();
                if (this.AllowDegradedPrinting != null)
                    hash = hash * 59 + this.AllowDegradedPrinting.GetHashCode();
                if (this.AllowModifyContents != null)
                    hash = hash * 59 + this.AllowModifyContents.GetHashCode();
                if (this.AllowCopy != null)
                    hash = hash * 59 + this.AllowCopy.GetHashCode();
                if (this.AllowModifyAnnotations != null)
                    hash = hash * 59 + this.AllowModifyAnnotations.GetHashCode();
                if (this.AllowFillIn != null)
                    hash = hash * 59 + this.AllowFillIn.GetHashCode();
                if (this.AllowScreenReaders != null)
                    hash = hash * 59 + this.AllowScreenReaders.GetHashCode();
                if (this.AllowAssembly != null)
                    hash = hash * 59 + this.AllowAssembly.GetHashCode();
                if (this.PrintAllowLevel != null)
                    hash = hash * 59 + this.PrintAllowLevel.GetHashCode();
                if (this.ChangeAllowLevel != null)
                    hash = hash * 59 + this.ChangeAllowLevel.GetHashCode();
                if (this.CopyAllowLevel != null)
                    hash = hash * 59 + this.CopyAllowLevel.GetHashCode();
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
