// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Signature.cs">
//   Copyright (c) 2018 Aspose.Pdf for Cloud
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
    /// The Signature
    /// </summary>
    [DataContract]
    public partial class Signature :  IEquatable<Signature>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Signature" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Signature() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Signature" /> class.
        /// </summary>
        /// <param name="SignaturePath">The SignaturePath.</param>
        /// <param name="SignatureType">The SignatureType.</param>
        /// <param name="Password">The Password.</param>
        /// <param name="Contact">The Contact.</param>
        /// <param name="Location">The Location.</param>
        /// <param name="Visible">The Visible (required).</param>
        /// <param name="Rectangle">The Rectangle.</param>
        /// <param name="FormFieldName">The FormFieldName.</param>
        /// <param name="Authority">The Authority.</param>
        /// <param name="Date">The Date.</param>
        public Signature(string SignaturePath = default(string), string SignatureType = default(string), string Password = default(string), string Contact = default(string), string Location = default(string), bool? Visible = default(bool?), Rectangle2 Rectangle = default(Rectangle2), string FormFieldName = default(string), string Authority = default(string), string Date = default(string))
        {
            // to ensure "Visible" is required (not null)
            if (Visible == null)
            {
                throw new InvalidDataException("Visible is a required property for Signature and cannot be null");
            }
            else
            {
                this.Visible = Visible;
            }
            this.SignaturePath = SignaturePath;
            this.SignatureType = SignatureType;
            this.Password = Password;
            this.Contact = Contact;
            this.Location = Location;
            this.Rectangle = Rectangle;
            this.FormFieldName = FormFieldName;
            this.Authority = Authority;
            this.Date = Date;
        }
        
        /// <summary>
        /// The SignaturePath
        /// </summary>
        /// <value>The SignaturePath</value>
        [DataMember(Name="SignaturePath", EmitDefaultValue=false)]
        public string SignaturePath { get; set; }

        /// <summary>
        /// The SignatureType
        /// </summary>
        /// <value>The SignatureType</value>
        [DataMember(Name="SignatureType", EmitDefaultValue=false)]
        public string SignatureType { get; set; }

        /// <summary>
        /// The Password
        /// </summary>
        /// <value>The Password</value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// The Contact
        /// </summary>
        /// <value>The Contact</value>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// The Location
        /// </summary>
        /// <value>The Location</value>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// The Visible
        /// </summary>
        /// <value>The Visible</value>
        [DataMember(Name="Visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// The Rectangle
        /// </summary>
        /// <value>The Rectangle</value>
        [DataMember(Name="Rectangle", EmitDefaultValue=false)]
        public Rectangle2 Rectangle { get; set; }

        /// <summary>
        /// The FormFieldName
        /// </summary>
        /// <value>The FormFieldName</value>
        [DataMember(Name="FormFieldName", EmitDefaultValue=false)]
        public string FormFieldName { get; set; }

        /// <summary>
        /// The Authority
        /// </summary>
        /// <value>The Authority</value>
        [DataMember(Name="Authority", EmitDefaultValue=false)]
        public string Authority { get; set; }

        /// <summary>
        /// The Date
        /// </summary>
        /// <value>The Date</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signature {\n");
            sb.Append("  SignaturePath: ").Append(SignaturePath).Append("\n");
            sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  Rectangle: ").Append(Rectangle).Append("\n");
            sb.Append("  FormFieldName: ").Append(FormFieldName).Append("\n");
            sb.Append("  Authority: ").Append(Authority).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(obj as Signature);
        }

        /// <summary>
        /// Returns true if Signature instances are equal
        /// </summary>
        /// <param name="other">Instance of Signature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signature other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SignaturePath == other.SignaturePath ||
                    this.SignaturePath != null &&
                    this.SignaturePath.Equals(other.SignaturePath)
                ) && 
                (
                    this.SignatureType == other.SignatureType ||
                    this.SignatureType != null &&
                    this.SignatureType.Equals(other.SignatureType)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Visible == other.Visible ||
                    this.Visible != null &&
                    this.Visible.Equals(other.Visible)
                ) && 
                (
                    this.Rectangle == other.Rectangle ||
                    this.Rectangle != null &&
                    this.Rectangle.Equals(other.Rectangle)
                ) && 
                (
                    this.FormFieldName == other.FormFieldName ||
                    this.FormFieldName != null &&
                    this.FormFieldName.Equals(other.FormFieldName)
                ) && 
                (
                    this.Authority == other.Authority ||
                    this.Authority != null &&
                    this.Authority.Equals(other.Authority)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
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
                if (this.SignaturePath != null)
                    hash = hash * 59 + this.SignaturePath.GetHashCode();
                if (this.SignatureType != null)
                    hash = hash * 59 + this.SignatureType.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.Visible != null)
                    hash = hash * 59 + this.Visible.GetHashCode();
                if (this.Rectangle != null)
                    hash = hash * 59 + this.Rectangle.GetHashCode();
                if (this.FormFieldName != null)
                    hash = hash * 59 + this.FormFieldName.GetHashCode();
                if (this.Authority != null)
                    hash = hash * 59 + this.Authority.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
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
