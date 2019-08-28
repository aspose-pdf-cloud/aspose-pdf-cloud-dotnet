// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Signature.cs">
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
    /// Represents signature.
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
        /// <param name="SignaturePath">Gets or sets the signature path. (required)</param>
        /// <param name="SignatureType">Gets or sets the type of the signature. (required)</param>
        /// <param name="Password">Gets or sets the signature password.</param>
        /// <param name="Appearance">Sets or gets a graphic appearance for the signature. Property value represents an image file name.</param>
        /// <param name="Reason">Gets or sets the reason of the signature.</param>
        /// <param name="Contact">Gets or sets the contact of the signature.</param>
        /// <param name="Location">Gets or sets the location of the signature.</param>
        /// <param name="Visible">Gets or sets a value indicating whether this Signature is visible. Supports only when signing particular page. (required)</param>
        /// <param name="Rectangle">Gets or sets the visible rectangle of the signature. Supports only when signing particular page.</param>
        /// <param name="FormFieldName">Gets or sets the name of the signature field. Supports only when signing document with particular form field.</param>
        /// <param name="Authority">Gets or sets the name of the person or authority signing the document..</param>
        /// <param name="Date">Gets or sets the time of signing.</param>
        /// <param name="ShowProperties">Gets or sets the showproperties in signature field (required)</param>
        /// <param name="TimestampSettings">Gets/sets timestamp settings.</param>
        /// <param name="IsValid">Verify the document regarding this signature and return true if document is valid or otherwise false.</param>
        /// <param name="CustomAppearance">Gets/sets the custom appearance.</param>
        public Signature(string SignaturePath = default(string), SignatureType SignatureType = default(SignatureType), string Password = default(string), string Appearance = default(string), string Reason = default(string), string Contact = default(string), string Location = default(string), bool? Visible = default(bool?), Rectangle Rectangle = default(Rectangle), string FormFieldName = default(string), string Authority = default(string), string Date = default(string), bool? ShowProperties = default(bool?), TimestampSettings TimestampSettings = default(TimestampSettings), bool? IsValid = default(bool?), SignatureCustomAppearance CustomAppearance = default(SignatureCustomAppearance))
        {
            // to ensure "SignaturePath" is required (not null)
            if (SignaturePath == null)
            {
                throw new InvalidDataException("SignaturePath is a required property for Signature and cannot be null");
            }
            else
            {
                this.SignaturePath = SignaturePath;
            }
            // to ensure "SignatureType" is required (not null)
            if (SignatureType == null)
            {
                throw new InvalidDataException("SignatureType is a required property for Signature and cannot be null");
            }
            else
            {
                this.SignatureType = SignatureType;
            }
            // to ensure "Visible" is required (not null)
            if (Visible == null)
            {
                throw new InvalidDataException("Visible is a required property for Signature and cannot be null");
            }
            else
            {
                this.Visible = Visible;
            }
            // to ensure "ShowProperties" is required (not null)
            if (ShowProperties == null)
            {
                throw new InvalidDataException("ShowProperties is a required property for Signature and cannot be null");
            }
            else
            {
                this.ShowProperties = ShowProperties;
            }
            this.Password = Password;
            this.Appearance = Appearance;
            this.Reason = Reason;
            this.Contact = Contact;
            this.Location = Location;
            this.Rectangle = Rectangle;
            this.FormFieldName = FormFieldName;
            this.Authority = Authority;
            this.Date = Date;
            this.TimestampSettings = TimestampSettings;
            this.IsValid = IsValid;
            this.CustomAppearance = CustomAppearance;
        }
        
        /// <summary>
        /// Gets or sets the signature path.
        /// </summary>
        /// <value>Gets or sets the signature path.</value>
        [DataMember(Name="SignaturePath", EmitDefaultValue=false)]
        public string SignaturePath { get; set; }

        /// <summary>
        /// Gets or sets the type of the signature.
        /// </summary>
        /// <value>Gets or sets the type of the signature.</value>
        [DataMember(Name="SignatureType", EmitDefaultValue=true)]
        public SignatureType SignatureType { get; set; }

        /// <summary>
        /// Gets or sets the signature password.
        /// </summary>
        /// <value>Gets or sets the signature password.</value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Sets or gets a graphic appearance for the signature. Property value represents an image file name.
        /// </summary>
        /// <value>Sets or gets a graphic appearance for the signature. Property value represents an image file name.</value>
        [DataMember(Name="Appearance", EmitDefaultValue=false)]
        public string Appearance { get; set; }

        /// <summary>
        /// Gets or sets the reason of the signature.
        /// </summary>
        /// <value>Gets or sets the reason of the signature.</value>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the contact of the signature.
        /// </summary>
        /// <value>Gets or sets the contact of the signature.</value>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// Gets or sets the location of the signature.
        /// </summary>
        /// <value>Gets or sets the location of the signature.</value>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this Signature is visible. Supports only when signing particular page.
        /// </summary>
        /// <value>Gets or sets a value indicating whether this Signature is visible. Supports only when signing particular page.</value>
        [DataMember(Name="Visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Gets or sets the visible rectangle of the signature. Supports only when signing particular page.
        /// </summary>
        /// <value>Gets or sets the visible rectangle of the signature. Supports only when signing particular page.</value>
        [DataMember(Name="Rectangle", EmitDefaultValue=false)]
        public Rectangle Rectangle { get; set; }

        /// <summary>
        /// Gets or sets the name of the signature field. Supports only when signing document with particular form field.
        /// </summary>
        /// <value>Gets or sets the name of the signature field. Supports only when signing document with particular form field.</value>
        [DataMember(Name="FormFieldName", EmitDefaultValue=false)]
        public string FormFieldName { get; set; }

        /// <summary>
        /// Gets or sets the name of the person or authority signing the document..
        /// </summary>
        /// <value>Gets or sets the name of the person or authority signing the document..</value>
        [DataMember(Name="Authority", EmitDefaultValue=false)]
        public string Authority { get; set; }

        /// <summary>
        /// Gets or sets the time of signing.
        /// </summary>
        /// <value>Gets or sets the time of signing.</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the showproperties in signature field
        /// </summary>
        /// <value>Gets or sets the showproperties in signature field</value>
        [DataMember(Name="ShowProperties", EmitDefaultValue=false)]
        public bool? ShowProperties { get; set; }

        /// <summary>
        /// Gets/sets timestamp settings.
        /// </summary>
        /// <value>Gets/sets timestamp settings.</value>
        [DataMember(Name="TimestampSettings", EmitDefaultValue=false)]
        public TimestampSettings TimestampSettings { get; set; }

        /// <summary>
        /// Verify the document regarding this signature and return true if document is valid or otherwise false.
        /// </summary>
        /// <value>Verify the document regarding this signature and return true if document is valid or otherwise false.</value>
        [DataMember(Name="IsValid", EmitDefaultValue=false)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Gets/sets the custom appearance.
        /// </summary>
        /// <value>Gets/sets the custom appearance.</value>
        [DataMember(Name="CustomAppearance", EmitDefaultValue=false)]
        public SignatureCustomAppearance CustomAppearance { get; set; }

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
            sb.Append("  Appearance: ").Append(Appearance).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  Rectangle: ").Append(Rectangle).Append("\n");
            sb.Append("  FormFieldName: ").Append(FormFieldName).Append("\n");
            sb.Append("  Authority: ").Append(Authority).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  ShowProperties: ").Append(ShowProperties).Append("\n");
            sb.Append("  TimestampSettings: ").Append(TimestampSettings).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  CustomAppearance: ").Append(CustomAppearance).Append("\n");
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
                    this.Appearance == other.Appearance ||
                    this.Appearance != null &&
                    this.Appearance.Equals(other.Appearance)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                ) && 
                (
                    this.ShowProperties == other.ShowProperties ||
                    this.ShowProperties != null &&
                    this.ShowProperties.Equals(other.ShowProperties)
                ) && 
                (
                    this.TimestampSettings == other.TimestampSettings ||
                    this.TimestampSettings != null &&
                    this.TimestampSettings.Equals(other.TimestampSettings)
                ) && 
                (
                    this.IsValid == other.IsValid ||
                    this.IsValid != null &&
                    this.IsValid.Equals(other.IsValid)
                ) && 
                (
                    this.CustomAppearance == other.CustomAppearance ||
                    this.CustomAppearance != null &&
                    this.CustomAppearance.Equals(other.CustomAppearance)
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
                if (this.Appearance != null)
                    hash = hash * 59 + this.Appearance.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
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
                if (this.ShowProperties != null)
                    hash = hash * 59 + this.ShowProperties.GetHashCode();
                if (this.TimestampSettings != null)
                    hash = hash * 59 + this.TimestampSettings.GetHashCode();
                if (this.IsValid != null)
                    hash = hash * 59 + this.IsValid.GetHashCode();
                if (this.CustomAppearance != null)
                    hash = hash * 59 + this.CustomAppearance.GetHashCode();
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
            // SignaturePath (string) minLength
            if(this.SignaturePath != null && this.SignaturePath.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignaturePath, length must be greater than 1.", new [] { "SignaturePath" });
            }

            yield break;
        }
    }

}
