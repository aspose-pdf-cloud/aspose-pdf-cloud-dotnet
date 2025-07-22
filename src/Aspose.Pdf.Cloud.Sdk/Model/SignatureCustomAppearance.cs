// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SignatureCustomAppearance.cs">
//   Copyright (c) 2025 Aspose.PDF Cloud
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
    /// An abstract class which represents signature custom appearance object.
    /// </summary>
    [DataContract]
    public partial class SignatureCustomAppearance :  IEquatable<SignatureCustomAppearance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureCustomAppearance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureCustomAppearance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureCustomAppearance" /> class.
        /// </summary>
        /// <param name="FontFamilyName">Gets/sets font family name. It should be existed in the document. Default value: Arial.</param>
        /// <param name="FontSize">Gets/sets font size. Default value: 10.</param>
        /// <param name="Rotation">Gets or sets signature rotation. (required)</param>
        /// <param name="ShowContactInfo">Gets/sets contact info visibility. Default value: true. (required)</param>
        /// <param name="ShowReason">Gets/sets reason visibility. Default value: true. (required)</param>
        /// <param name="ShowLocation">Gets/sets location visibility. Default value: true. (required)</param>
        /// <param name="ContactInfoLabel">Gets/sets contact info label. Default value: \&quot;Contact\&quot;.</param>
        /// <param name="ReasonLabel">Gets/sets reason label. Default value: \&quot;Reason\&quot;.</param>
        /// <param name="LocationLabel">Gets/sets location label. Default value: \&quot;Location\&quot;.</param>
        /// <param name="DigitalSignedLabel">Gets/sets digital signed label. Default value: \&quot;Digitally signed by\&quot;.</param>
        /// <param name="DateSignedAtLabel">Gets/sets date signed label. Default value: \&quot;Date\&quot;.</param>
        /// <param name="DateTimeLocalFormat">Gets/sets datetime local format. Default value: \&quot;yyyy.MM.dd HH:mm:ss zzz\&quot;.</param>
        /// <param name="DateTimeFormat">Gets/sets datetime format. Default value: \&quot;yyyy.MM.dd HH:mm:ss\&quot;.</param>
        /// <param name="BackgroundColor">Gets/sets background color.</param>
        /// <param name="ForegroundColor">Gets/sets foreground color.</param>
        /// <param name="UseDigitalSubjectFormat">Gets/sets subject format usage. (required)</param>
        /// <param name="DigitalSubjectFormat">Gets/sets subject format.</param>
        public SignatureCustomAppearance(string FontFamilyName = default(string), double? FontSize = default(double?), Rotation Rotation = default(Rotation), bool? ShowContactInfo = default(bool?), bool? ShowReason = default(bool?), bool? ShowLocation = default(bool?), string ContactInfoLabel = default(string), string ReasonLabel = default(string), string LocationLabel = default(string), string DigitalSignedLabel = default(string), string DateSignedAtLabel = default(string), string DateTimeLocalFormat = default(string), string DateTimeFormat = default(string), Color BackgroundColor = default(Color), Color ForegroundColor = default(Color), bool? UseDigitalSubjectFormat = default(bool?), List<SignatureSubjectNameElements> DigitalSubjectFormat = default(List<SignatureSubjectNameElements>))
        {
            // to ensure "Rotation" is required (not null)
            if (Rotation == null)
            {
                throw new InvalidDataException("Rotation is a required property for SignatureCustomAppearance and cannot be null");
            }
            else
            {
                this.Rotation = Rotation;
            }
            // to ensure "ShowContactInfo" is required (not null)
            if (ShowContactInfo == null)
            {
                throw new InvalidDataException("ShowContactInfo is a required property for SignatureCustomAppearance and cannot be null");
            }
            else
            {
                this.ShowContactInfo = ShowContactInfo;
            }
            // to ensure "ShowReason" is required (not null)
            if (ShowReason == null)
            {
                throw new InvalidDataException("ShowReason is a required property for SignatureCustomAppearance and cannot be null");
            }
            else
            {
                this.ShowReason = ShowReason;
            }
            // to ensure "ShowLocation" is required (not null)
            if (ShowLocation == null)
            {
                throw new InvalidDataException("ShowLocation is a required property for SignatureCustomAppearance and cannot be null");
            }
            else
            {
                this.ShowLocation = ShowLocation;
            }
            // to ensure "UseDigitalSubjectFormat" is required (not null)
            if (UseDigitalSubjectFormat == null)
            {
                throw new InvalidDataException("UseDigitalSubjectFormat is a required property for SignatureCustomAppearance and cannot be null");
            }
            else
            {
                this.UseDigitalSubjectFormat = UseDigitalSubjectFormat;
            }
            this.FontFamilyName = FontFamilyName;
            this.FontSize = FontSize;
            this.ContactInfoLabel = ContactInfoLabel;
            this.ReasonLabel = ReasonLabel;
            this.LocationLabel = LocationLabel;
            this.DigitalSignedLabel = DigitalSignedLabel;
            this.DateSignedAtLabel = DateSignedAtLabel;
            this.DateTimeLocalFormat = DateTimeLocalFormat;
            this.DateTimeFormat = DateTimeFormat;
            this.BackgroundColor = BackgroundColor;
            this.ForegroundColor = ForegroundColor;
            this.DigitalSubjectFormat = DigitalSubjectFormat;
        }
        
        /// <summary>
        /// Gets/sets font family name. It should be existed in the document. Default value: Arial.
        /// </summary>
        /// <value>Gets/sets font family name. It should be existed in the document. Default value: Arial.</value>
        [DataMember(Name="FontFamilyName", EmitDefaultValue=false)]
        public string FontFamilyName { get; set; }

        /// <summary>
        /// Gets/sets font size. Default value: 10.
        /// </summary>
        /// <value>Gets/sets font size. Default value: 10.</value>
        [DataMember(Name="FontSize", EmitDefaultValue=false)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Gets or sets signature rotation.
        /// </summary>
        /// <value>Gets or sets signature rotation.</value>
        [DataMember(Name="Rotation", EmitDefaultValue=true)]
        public Rotation Rotation { get; set; }

        /// <summary>
        /// Gets/sets contact info visibility. Default value: true.
        /// </summary>
        /// <value>Gets/sets contact info visibility. Default value: true.</value>
        [DataMember(Name="ShowContactInfo", EmitDefaultValue=false)]
        public bool? ShowContactInfo { get; set; }

        /// <summary>
        /// Gets/sets reason visibility. Default value: true.
        /// </summary>
        /// <value>Gets/sets reason visibility. Default value: true.</value>
        [DataMember(Name="ShowReason", EmitDefaultValue=false)]
        public bool? ShowReason { get; set; }

        /// <summary>
        /// Gets/sets location visibility. Default value: true.
        /// </summary>
        /// <value>Gets/sets location visibility. Default value: true.</value>
        [DataMember(Name="ShowLocation", EmitDefaultValue=false)]
        public bool? ShowLocation { get; set; }

        /// <summary>
        /// Gets/sets contact info label. Default value: \&quot;Contact\&quot;.
        /// </summary>
        /// <value>Gets/sets contact info label. Default value: \&quot;Contact\&quot;.</value>
        [DataMember(Name="ContactInfoLabel", EmitDefaultValue=false)]
        public string ContactInfoLabel { get; set; }

        /// <summary>
        /// Gets/sets reason label. Default value: \&quot;Reason\&quot;.
        /// </summary>
        /// <value>Gets/sets reason label. Default value: \&quot;Reason\&quot;.</value>
        [DataMember(Name="ReasonLabel", EmitDefaultValue=false)]
        public string ReasonLabel { get; set; }

        /// <summary>
        /// Gets/sets location label. Default value: \&quot;Location\&quot;.
        /// </summary>
        /// <value>Gets/sets location label. Default value: \&quot;Location\&quot;.</value>
        [DataMember(Name="LocationLabel", EmitDefaultValue=false)]
        public string LocationLabel { get; set; }

        /// <summary>
        /// Gets/sets digital signed label. Default value: \&quot;Digitally signed by\&quot;.
        /// </summary>
        /// <value>Gets/sets digital signed label. Default value: \&quot;Digitally signed by\&quot;.</value>
        [DataMember(Name="DigitalSignedLabel", EmitDefaultValue=false)]
        public string DigitalSignedLabel { get; set; }

        /// <summary>
        /// Gets/sets date signed label. Default value: \&quot;Date\&quot;.
        /// </summary>
        /// <value>Gets/sets date signed label. Default value: \&quot;Date\&quot;.</value>
        [DataMember(Name="DateSignedAtLabel", EmitDefaultValue=false)]
        public string DateSignedAtLabel { get; set; }

        /// <summary>
        /// Gets/sets datetime local format. Default value: \&quot;yyyy.MM.dd HH:mm:ss zzz\&quot;.
        /// </summary>
        /// <value>Gets/sets datetime local format. Default value: \&quot;yyyy.MM.dd HH:mm:ss zzz\&quot;.</value>
        [DataMember(Name="DateTimeLocalFormat", EmitDefaultValue=false)]
        public string DateTimeLocalFormat { get; set; }

        /// <summary>
        /// Gets/sets datetime format. Default value: \&quot;yyyy.MM.dd HH:mm:ss\&quot;.
        /// </summary>
        /// <value>Gets/sets datetime format. Default value: \&quot;yyyy.MM.dd HH:mm:ss\&quot;.</value>
        [DataMember(Name="DateTimeFormat", EmitDefaultValue=false)]
        public string DateTimeFormat { get; set; }

        /// <summary>
        /// Gets/sets background color.
        /// </summary>
        /// <value>Gets/sets background color.</value>
        [DataMember(Name="BackgroundColor", EmitDefaultValue=false)]
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets/sets foreground color.
        /// </summary>
        /// <value>Gets/sets foreground color.</value>
        [DataMember(Name="ForegroundColor", EmitDefaultValue=false)]
        public Color ForegroundColor { get; set; }

        /// <summary>
        /// Gets/sets subject format usage.
        /// </summary>
        /// <value>Gets/sets subject format usage.</value>
        [DataMember(Name="UseDigitalSubjectFormat", EmitDefaultValue=false)]
        public bool? UseDigitalSubjectFormat { get; set; }

        /// <summary>
        /// Gets/sets subject format.
        /// </summary>
        /// <value>Gets/sets subject format.</value>
        [DataMember(Name="DigitalSubjectFormat", EmitDefaultValue=false)]
        public List<SignatureSubjectNameElements> DigitalSubjectFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignatureCustomAppearance {\n");
            sb.Append("  FontFamilyName: ").Append(FontFamilyName).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  ShowContactInfo: ").Append(ShowContactInfo).Append("\n");
            sb.Append("  ShowReason: ").Append(ShowReason).Append("\n");
            sb.Append("  ShowLocation: ").Append(ShowLocation).Append("\n");
            sb.Append("  ContactInfoLabel: ").Append(ContactInfoLabel).Append("\n");
            sb.Append("  ReasonLabel: ").Append(ReasonLabel).Append("\n");
            sb.Append("  LocationLabel: ").Append(LocationLabel).Append("\n");
            sb.Append("  DigitalSignedLabel: ").Append(DigitalSignedLabel).Append("\n");
            sb.Append("  DateSignedAtLabel: ").Append(DateSignedAtLabel).Append("\n");
            sb.Append("  DateTimeLocalFormat: ").Append(DateTimeLocalFormat).Append("\n");
            sb.Append("  DateTimeFormat: ").Append(DateTimeFormat).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  ForegroundColor: ").Append(ForegroundColor).Append("\n");
            sb.Append("  UseDigitalSubjectFormat: ").Append(UseDigitalSubjectFormat).Append("\n");
            sb.Append("  DigitalSubjectFormat: ").Append(DigitalSubjectFormat).Append("\n");
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
            return this.Equals(obj as SignatureCustomAppearance);
        }

        /// <summary>
        /// Returns true if SignatureCustomAppearance instances are equal
        /// </summary>
        /// <param name="other">Instance of SignatureCustomAppearance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureCustomAppearance other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FontFamilyName == other.FontFamilyName ||
                    this.FontFamilyName != null &&
                    this.FontFamilyName.Equals(other.FontFamilyName)
                ) && 
                (
                    this.FontSize == other.FontSize ||
                    this.FontSize != null &&
                    this.FontSize.Equals(other.FontSize)
                ) && 
                (
                    this.Rotation == other.Rotation ||
                    this.Rotation != null &&
                    this.Rotation.Equals(other.Rotation)
                ) && 
                (
                    this.ShowContactInfo == other.ShowContactInfo ||
                    this.ShowContactInfo != null &&
                    this.ShowContactInfo.Equals(other.ShowContactInfo)
                ) && 
                (
                    this.ShowReason == other.ShowReason ||
                    this.ShowReason != null &&
                    this.ShowReason.Equals(other.ShowReason)
                ) && 
                (
                    this.ShowLocation == other.ShowLocation ||
                    this.ShowLocation != null &&
                    this.ShowLocation.Equals(other.ShowLocation)
                ) && 
                (
                    this.ContactInfoLabel == other.ContactInfoLabel ||
                    this.ContactInfoLabel != null &&
                    this.ContactInfoLabel.Equals(other.ContactInfoLabel)
                ) && 
                (
                    this.ReasonLabel == other.ReasonLabel ||
                    this.ReasonLabel != null &&
                    this.ReasonLabel.Equals(other.ReasonLabel)
                ) && 
                (
                    this.LocationLabel == other.LocationLabel ||
                    this.LocationLabel != null &&
                    this.LocationLabel.Equals(other.LocationLabel)
                ) && 
                (
                    this.DigitalSignedLabel == other.DigitalSignedLabel ||
                    this.DigitalSignedLabel != null &&
                    this.DigitalSignedLabel.Equals(other.DigitalSignedLabel)
                ) && 
                (
                    this.DateSignedAtLabel == other.DateSignedAtLabel ||
                    this.DateSignedAtLabel != null &&
                    this.DateSignedAtLabel.Equals(other.DateSignedAtLabel)
                ) && 
                (
                    this.DateTimeLocalFormat == other.DateTimeLocalFormat ||
                    this.DateTimeLocalFormat != null &&
                    this.DateTimeLocalFormat.Equals(other.DateTimeLocalFormat)
                ) && 
                (
                    this.DateTimeFormat == other.DateTimeFormat ||
                    this.DateTimeFormat != null &&
                    this.DateTimeFormat.Equals(other.DateTimeFormat)
                ) && 
                (
                    this.BackgroundColor == other.BackgroundColor ||
                    this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(other.BackgroundColor)
                ) && 
                (
                    this.ForegroundColor == other.ForegroundColor ||
                    this.ForegroundColor != null &&
                    this.ForegroundColor.Equals(other.ForegroundColor)
                ) && 
                (
                    this.UseDigitalSubjectFormat == other.UseDigitalSubjectFormat ||
                    this.UseDigitalSubjectFormat != null &&
                    this.UseDigitalSubjectFormat.Equals(other.UseDigitalSubjectFormat)
                ) && 
                (
                    this.DigitalSubjectFormat == other.DigitalSubjectFormat ||
                    this.DigitalSubjectFormat != null &&
                    this.DigitalSubjectFormat.SequenceEqual(other.DigitalSubjectFormat)
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
                if (this.FontFamilyName != null)
                    hash = hash * 59 + this.FontFamilyName.GetHashCode();
                if (this.FontSize != null)
                    hash = hash * 59 + this.FontSize.GetHashCode();
                if (this.Rotation != null)
                    hash = hash * 59 + this.Rotation.GetHashCode();
                if (this.ShowContactInfo != null)
                    hash = hash * 59 + this.ShowContactInfo.GetHashCode();
                if (this.ShowReason != null)
                    hash = hash * 59 + this.ShowReason.GetHashCode();
                if (this.ShowLocation != null)
                    hash = hash * 59 + this.ShowLocation.GetHashCode();
                if (this.ContactInfoLabel != null)
                    hash = hash * 59 + this.ContactInfoLabel.GetHashCode();
                if (this.ReasonLabel != null)
                    hash = hash * 59 + this.ReasonLabel.GetHashCode();
                if (this.LocationLabel != null)
                    hash = hash * 59 + this.LocationLabel.GetHashCode();
                if (this.DigitalSignedLabel != null)
                    hash = hash * 59 + this.DigitalSignedLabel.GetHashCode();
                if (this.DateSignedAtLabel != null)
                    hash = hash * 59 + this.DateSignedAtLabel.GetHashCode();
                if (this.DateTimeLocalFormat != null)
                    hash = hash * 59 + this.DateTimeLocalFormat.GetHashCode();
                if (this.DateTimeFormat != null)
                    hash = hash * 59 + this.DateTimeFormat.GetHashCode();
                if (this.BackgroundColor != null)
                    hash = hash * 59 + this.BackgroundColor.GetHashCode();
                if (this.ForegroundColor != null)
                    hash = hash * 59 + this.ForegroundColor.GetHashCode();
                if (this.UseDigitalSubjectFormat != null)
                    hash = hash * 59 + this.UseDigitalSubjectFormat.GetHashCode();
                if (this.DigitalSubjectFormat != null)
                    hash = hash * 59 + this.DigitalSubjectFormat.GetHashCode();
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
