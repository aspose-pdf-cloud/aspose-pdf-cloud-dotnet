// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StorageFile.cs">
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
    /// File or folder information
    /// </summary>
    [DataContract]
    public partial class StorageFile :  IEquatable<StorageFile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StorageFile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFile" /> class.
        /// </summary>
        /// <param name="Name">File or folder name.</param>
        /// <param name="IsFolder">True if it is a folder. (required)</param>
        /// <param name="ModifiedDate">File or folder last modified DateTime.</param>
        /// <param name="Size">File or folder size. (required)</param>
        /// <param name="Path">File or folder path.</param>
        public StorageFile(string Name = default(string), bool? IsFolder = default(bool?), DateTime? ModifiedDate = default(DateTime?), long? Size = default(long?), string Path = default(string))
        {
            // to ensure "IsFolder" is required (not null)
            if (IsFolder == null)
            {
                throw new InvalidDataException("IsFolder is a required property for StorageFile and cannot be null");
            }
            else
            {
                this.IsFolder = IsFolder;
            }
            // to ensure "Size" is required (not null)
            if (Size == null)
            {
                throw new InvalidDataException("Size is a required property for StorageFile and cannot be null");
            }
            else
            {
                this.Size = Size;
            }
            this.Name = Name;
            this.ModifiedDate = ModifiedDate;
            this.Path = Path;
        }
        
        /// <summary>
        /// File or folder name.
        /// </summary>
        /// <value>File or folder name.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// True if it is a folder.
        /// </summary>
        /// <value>True if it is a folder.</value>
        [DataMember(Name="IsFolder", EmitDefaultValue=false)]
        public bool? IsFolder { get; set; }

        /// <summary>
        /// File or folder last modified DateTime.
        /// </summary>
        /// <value>File or folder last modified DateTime.</value>
        [DataMember(Name="ModifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// File or folder size.
        /// </summary>
        /// <value>File or folder size.</value>
        [DataMember(Name="Size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// File or folder path.
        /// </summary>
        /// <value>File or folder path.</value>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageFile {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsFolder: ").Append(IsFolder).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(obj as StorageFile);
        }

        /// <summary>
        /// Returns true if StorageFile instances are equal
        /// </summary>
        /// <param name="other">Instance of StorageFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageFile other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.IsFolder == other.IsFolder ||
                    this.IsFolder != null &&
                    this.IsFolder.Equals(other.IsFolder)
                ) && 
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.IsFolder != null)
                    hash = hash * 59 + this.IsFolder.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
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
