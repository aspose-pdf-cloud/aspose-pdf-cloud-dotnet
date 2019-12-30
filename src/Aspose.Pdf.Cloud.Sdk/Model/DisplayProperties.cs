// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DisplayProperties.cs">
//   Copyright (c) 2020 Aspose.PDF Cloud
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
    /// Provides link to DisplayProperties.
    /// </summary>
    [DataContract]
    public partial class DisplayProperties : LinkElement,  IEquatable<DisplayProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayProperties" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="CenterWindow">Gets or sets flag specifying whether position of the document&#39;s window will be centerd on the screen.</param>
        /// <param name="Direction">Gets or sets reading order of text: L2R (left to right) or R2L (right to left).</param>
        /// <param name="DisplayDocTitle">Gets or sets flag specifying whether document&#39;s window title bar should display document title.</param>
        /// <param name="HideMenuBar">Gets or sets flag specifying whether menu bar should be hidden when document is active.</param>
        /// <param name="HideToolBar">Gets or sets flag specifying whether toolbar should be hidden when document is active.</param>
        /// <param name="HideWindowUI">Gets or sets flag specifying whether user interface elements should be hidden when document is active.</param>
        /// <param name="NonFullScreenPageMode">Gets or sets page mode, specifying how to display the document on exiting full-screen mode.</param>
        /// <param name="PageLayout">Gets or sets page layout which shall be used when the document is opened.</param>
        /// <param name="PageMode">Gets or sets page mode, specifying how document should be displayed when opened.</param>
        public DisplayProperties(List<Link> Links = default(List<Link>), bool? CenterWindow = default(bool?), Direction Direction = default(Direction), bool? DisplayDocTitle = default(bool?), bool? HideMenuBar = default(bool?), bool? HideToolBar = default(bool?), bool? HideWindowUI = default(bool?), PageMode NonFullScreenPageMode = default(PageMode), PageLayout PageLayout = default(PageLayout), PageMode PageMode = default(PageMode))
        {
            this.Links = Links;
            this.CenterWindow = CenterWindow;
            this.Direction = Direction;
            this.DisplayDocTitle = DisplayDocTitle;
            this.HideMenuBar = HideMenuBar;
            this.HideToolBar = HideToolBar;
            this.HideWindowUI = HideWindowUI;
            this.NonFullScreenPageMode = NonFullScreenPageMode;
            this.PageLayout = PageLayout;
            this.PageMode = PageMode;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets flag specifying whether position of the document&#39;s window will be centerd on the screen.
        /// </summary>
        /// <value>Gets or sets flag specifying whether position of the document&#39;s window will be centerd on the screen.</value>
        [DataMember(Name="CenterWindow", EmitDefaultValue=false)]
        public bool? CenterWindow { get; set; }

        /// <summary>
        /// Gets or sets reading order of text: L2R (left to right) or R2L (right to left).
        /// </summary>
        /// <value>Gets or sets reading order of text: L2R (left to right) or R2L (right to left).</value>
        [DataMember(Name="Direction", EmitDefaultValue=true)]
        public Direction Direction { get; set; }

        /// <summary>
        /// Gets or sets flag specifying whether document&#39;s window title bar should display document title.
        /// </summary>
        /// <value>Gets or sets flag specifying whether document&#39;s window title bar should display document title.</value>
        [DataMember(Name="DisplayDocTitle", EmitDefaultValue=false)]
        public bool? DisplayDocTitle { get; set; }

        /// <summary>
        /// Gets or sets flag specifying whether menu bar should be hidden when document is active.
        /// </summary>
        /// <value>Gets or sets flag specifying whether menu bar should be hidden when document is active.</value>
        [DataMember(Name="HideMenuBar", EmitDefaultValue=false)]
        public bool? HideMenuBar { get; set; }

        /// <summary>
        /// Gets or sets flag specifying whether toolbar should be hidden when document is active.
        /// </summary>
        /// <value>Gets or sets flag specifying whether toolbar should be hidden when document is active.</value>
        [DataMember(Name="HideToolBar", EmitDefaultValue=false)]
        public bool? HideToolBar { get; set; }

        /// <summary>
        /// Gets or sets flag specifying whether user interface elements should be hidden when document is active.
        /// </summary>
        /// <value>Gets or sets flag specifying whether user interface elements should be hidden when document is active.</value>
        [DataMember(Name="HideWindowUI", EmitDefaultValue=false)]
        public bool? HideWindowUI { get; set; }

        /// <summary>
        /// Gets or sets page mode, specifying how to display the document on exiting full-screen mode.
        /// </summary>
        /// <value>Gets or sets page mode, specifying how to display the document on exiting full-screen mode.</value>
        [DataMember(Name="NonFullScreenPageMode", EmitDefaultValue=true)]
        public PageMode NonFullScreenPageMode { get; set; }

        /// <summary>
        /// Gets or sets page layout which shall be used when the document is opened.
        /// </summary>
        /// <value>Gets or sets page layout which shall be used when the document is opened.</value>
        [DataMember(Name="PageLayout", EmitDefaultValue=true)]
        public PageLayout PageLayout { get; set; }

        /// <summary>
        /// Gets or sets page mode, specifying how document should be displayed when opened.
        /// </summary>
        /// <value>Gets or sets page mode, specifying how document should be displayed when opened.</value>
        [DataMember(Name="PageMode", EmitDefaultValue=true)]
        public PageMode PageMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisplayProperties {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  CenterWindow: ").Append(CenterWindow).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  DisplayDocTitle: ").Append(DisplayDocTitle).Append("\n");
            sb.Append("  HideMenuBar: ").Append(HideMenuBar).Append("\n");
            sb.Append("  HideToolBar: ").Append(HideToolBar).Append("\n");
            sb.Append("  HideWindowUI: ").Append(HideWindowUI).Append("\n");
            sb.Append("  NonFullScreenPageMode: ").Append(NonFullScreenPageMode).Append("\n");
            sb.Append("  PageLayout: ").Append(PageLayout).Append("\n");
            sb.Append("  PageMode: ").Append(PageMode).Append("\n");
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
            return this.Equals(obj as DisplayProperties);
        }

        /// <summary>
        /// Returns true if DisplayProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of DisplayProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplayProperties other)
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
                    this.CenterWindow == other.CenterWindow ||
                    this.CenterWindow != null &&
                    this.CenterWindow.Equals(other.CenterWindow)
                ) && 
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) && 
                (
                    this.DisplayDocTitle == other.DisplayDocTitle ||
                    this.DisplayDocTitle != null &&
                    this.DisplayDocTitle.Equals(other.DisplayDocTitle)
                ) && 
                (
                    this.HideMenuBar == other.HideMenuBar ||
                    this.HideMenuBar != null &&
                    this.HideMenuBar.Equals(other.HideMenuBar)
                ) && 
                (
                    this.HideToolBar == other.HideToolBar ||
                    this.HideToolBar != null &&
                    this.HideToolBar.Equals(other.HideToolBar)
                ) && 
                (
                    this.HideWindowUI == other.HideWindowUI ||
                    this.HideWindowUI != null &&
                    this.HideWindowUI.Equals(other.HideWindowUI)
                ) && 
                (
                    this.NonFullScreenPageMode == other.NonFullScreenPageMode ||
                    this.NonFullScreenPageMode != null &&
                    this.NonFullScreenPageMode.Equals(other.NonFullScreenPageMode)
                ) && 
                (
                    this.PageLayout == other.PageLayout ||
                    this.PageLayout != null &&
                    this.PageLayout.Equals(other.PageLayout)
                ) && 
                (
                    this.PageMode == other.PageMode ||
                    this.PageMode != null &&
                    this.PageMode.Equals(other.PageMode)
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
                if (this.CenterWindow != null)
                    hash = hash * 59 + this.CenterWindow.GetHashCode();
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                if (this.DisplayDocTitle != null)
                    hash = hash * 59 + this.DisplayDocTitle.GetHashCode();
                if (this.HideMenuBar != null)
                    hash = hash * 59 + this.HideMenuBar.GetHashCode();
                if (this.HideToolBar != null)
                    hash = hash * 59 + this.HideToolBar.GetHashCode();
                if (this.HideWindowUI != null)
                    hash = hash * 59 + this.HideWindowUI.GetHashCode();
                if (this.NonFullScreenPageMode != null)
                    hash = hash * 59 + this.NonFullScreenPageMode.GetHashCode();
                if (this.PageLayout != null)
                    hash = hash * 59 + this.PageLayout.GetHashCode();
                if (this.PageMode != null)
                    hash = hash * 59 + this.PageMode.GetHashCode();
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
