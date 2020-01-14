// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Bookmark.cs">
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
    /// Provides link to bookmark.
    /// </summary>
    [DataContract]
    public partial class Bookmark : LinkElement,  IEquatable<Bookmark>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bookmark" /> class.
        /// </summary>
        /// <param name="Links">Link to the document.</param>
        /// <param name="Title">Get the Title;</param>
        /// <param name="Italic">Is bookmark italic.</param>
        /// <param name="Bold">Is bookmark bold.</param>
        /// <param name="Color">Get the color</param>
        /// <param name="Action">Gets or sets the action bound with the bookmark. If PageNumber is presented the action can not be specified. The action type includes: \&quot;GoTo\&quot;, \&quot;GoToR\&quot;, \&quot;Launch\&quot;, \&quot;Named\&quot;.</param>
        /// <param name="Level">Gets or sets bookmark&#39;s hierarchy level.</param>
        /// <param name="Destination">Gets or sets bookmark&#39;s destination page. Required if action is set as string.Empty.</param>
        /// <param name="PageDisplay">Gets or sets the type of display bookmark&#39;s destination page.</param>
        /// <param name="PageDisplayBottom">Gets or sets the bottom coordinate of page display.</param>
        /// <param name="PageDisplayLeft">Gets or sets the left coordinate of page display.</param>
        /// <param name="PageDisplayRight">Gets or sets the right coordinate of page display.</param>
        /// <param name="PageDisplayTop">Gets or sets the top coordinate of page display.</param>
        /// <param name="PageDisplayZoom">Gets or sets the zoom factor of page display.</param>
        /// <param name="PageNumber">Gets or sets the number of bookmark&#39;s destination page. </param>
        /// <param name="RemoteFile">Gets or sets the file (path) which is required for \&quot;GoToR\&quot; action of bookmark.</param>
        /// <param name="Bookmarks">The children bookmarks.</param>
        public Bookmark(List<Link> Links = default(List<Link>), string Title = default(string), bool? Italic = default(bool?), bool? Bold = default(bool?), Color Color = default(Color), string Action = default(string), int? Level = default(int?), string Destination = default(string), string PageDisplay = default(string), int? PageDisplayBottom = default(int?), int? PageDisplayLeft = default(int?), int? PageDisplayRight = default(int?), int? PageDisplayTop = default(int?), int? PageDisplayZoom = default(int?), int? PageNumber = default(int?), string RemoteFile = default(string), Bookmarks Bookmarks = default(Bookmarks))
        {
            this.Links = Links;
            this.Title = Title;
            this.Italic = Italic;
            this.Bold = Bold;
            this.Color = Color;
            this.Action = Action;
            this.Level = Level;
            this.Destination = Destination;
            this.PageDisplay = PageDisplay;
            this.PageDisplayBottom = PageDisplayBottom;
            this.PageDisplayLeft = PageDisplayLeft;
            this.PageDisplayRight = PageDisplayRight;
            this.PageDisplayTop = PageDisplayTop;
            this.PageDisplayZoom = PageDisplayZoom;
            this.PageNumber = PageNumber;
            this.RemoteFile = RemoteFile;
            this.Bookmarks = Bookmarks;
        }
        
        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Get the Title;
        /// </summary>
        /// <value>Get the Title;</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Is bookmark italic.
        /// </summary>
        /// <value>Is bookmark italic.</value>
        [DataMember(Name="Italic", EmitDefaultValue=false)]
        public bool? Italic { get; set; }

        /// <summary>
        /// Is bookmark bold.
        /// </summary>
        /// <value>Is bookmark bold.</value>
        [DataMember(Name="Bold", EmitDefaultValue=false)]
        public bool? Bold { get; set; }

        /// <summary>
        /// Get the color
        /// </summary>
        /// <value>Get the color</value>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets the action bound with the bookmark. If PageNumber is presented the action can not be specified. The action type includes: \&quot;GoTo\&quot;, \&quot;GoToR\&quot;, \&quot;Launch\&quot;, \&quot;Named\&quot;.
        /// </summary>
        /// <value>Gets or sets the action bound with the bookmark. If PageNumber is presented the action can not be specified. The action type includes: \&quot;GoTo\&quot;, \&quot;GoToR\&quot;, \&quot;Launch\&quot;, \&quot;Named\&quot;.</value>
        [DataMember(Name="Action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets bookmark&#39;s hierarchy level.
        /// </summary>
        /// <value>Gets or sets bookmark&#39;s hierarchy level.</value>
        [DataMember(Name="Level", EmitDefaultValue=false)]
        public int? Level { get; set; }

        /// <summary>
        /// Gets or sets bookmark&#39;s destination page. Required if action is set as string.Empty.
        /// </summary>
        /// <value>Gets or sets bookmark&#39;s destination page. Required if action is set as string.Empty.</value>
        [DataMember(Name="Destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or sets the type of display bookmark&#39;s destination page.
        /// </summary>
        /// <value>Gets or sets the type of display bookmark&#39;s destination page.</value>
        [DataMember(Name="PageDisplay", EmitDefaultValue=false)]
        public string PageDisplay { get; set; }

        /// <summary>
        /// Gets or sets the bottom coordinate of page display.
        /// </summary>
        /// <value>Gets or sets the bottom coordinate of page display.</value>
        [DataMember(Name="PageDisplay_Bottom", EmitDefaultValue=false)]
        public int? PageDisplayBottom { get; set; }

        /// <summary>
        /// Gets or sets the left coordinate of page display.
        /// </summary>
        /// <value>Gets or sets the left coordinate of page display.</value>
        [DataMember(Name="PageDisplay_Left", EmitDefaultValue=false)]
        public int? PageDisplayLeft { get; set; }

        /// <summary>
        /// Gets or sets the right coordinate of page display.
        /// </summary>
        /// <value>Gets or sets the right coordinate of page display.</value>
        [DataMember(Name="PageDisplay_Right", EmitDefaultValue=false)]
        public int? PageDisplayRight { get; set; }

        /// <summary>
        /// Gets or sets the top coordinate of page display.
        /// </summary>
        /// <value>Gets or sets the top coordinate of page display.</value>
        [DataMember(Name="PageDisplay_Top", EmitDefaultValue=false)]
        public int? PageDisplayTop { get; set; }

        /// <summary>
        /// Gets or sets the zoom factor of page display.
        /// </summary>
        /// <value>Gets or sets the zoom factor of page display.</value>
        [DataMember(Name="PageDisplay_Zoom", EmitDefaultValue=false)]
        public int? PageDisplayZoom { get; set; }

        /// <summary>
        /// Gets or sets the number of bookmark&#39;s destination page. 
        /// </summary>
        /// <value>Gets or sets the number of bookmark&#39;s destination page. </value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the file (path) which is required for \&quot;GoToR\&quot; action of bookmark.
        /// </summary>
        /// <value>Gets or sets the file (path) which is required for \&quot;GoToR\&quot; action of bookmark.</value>
        [DataMember(Name="RemoteFile", EmitDefaultValue=false)]
        public string RemoteFile { get; set; }

        /// <summary>
        /// The children bookmarks.
        /// </summary>
        /// <value>The children bookmarks.</value>
        [DataMember(Name="Bookmarks", EmitDefaultValue=false)]
        public Bookmarks Bookmarks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bookmark {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Italic: ").Append(Italic).Append("\n");
            sb.Append("  Bold: ").Append(Bold).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  PageDisplay: ").Append(PageDisplay).Append("\n");
            sb.Append("  PageDisplayBottom: ").Append(PageDisplayBottom).Append("\n");
            sb.Append("  PageDisplayLeft: ").Append(PageDisplayLeft).Append("\n");
            sb.Append("  PageDisplayRight: ").Append(PageDisplayRight).Append("\n");
            sb.Append("  PageDisplayTop: ").Append(PageDisplayTop).Append("\n");
            sb.Append("  PageDisplayZoom: ").Append(PageDisplayZoom).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  RemoteFile: ").Append(RemoteFile).Append("\n");
            sb.Append("  Bookmarks: ").Append(Bookmarks).Append("\n");
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
            return this.Equals(obj as Bookmark);
        }

        /// <summary>
        /// Returns true if Bookmark instances are equal
        /// </summary>
        /// <param name="other">Instance of Bookmark to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bookmark other)
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
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Italic == other.Italic ||
                    this.Italic != null &&
                    this.Italic.Equals(other.Italic)
                ) && 
                (
                    this.Bold == other.Bold ||
                    this.Bold != null &&
                    this.Bold.Equals(other.Bold)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) && 
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) && 
                (
                    this.PageDisplay == other.PageDisplay ||
                    this.PageDisplay != null &&
                    this.PageDisplay.Equals(other.PageDisplay)
                ) && 
                (
                    this.PageDisplayBottom == other.PageDisplayBottom ||
                    this.PageDisplayBottom != null &&
                    this.PageDisplayBottom.Equals(other.PageDisplayBottom)
                ) && 
                (
                    this.PageDisplayLeft == other.PageDisplayLeft ||
                    this.PageDisplayLeft != null &&
                    this.PageDisplayLeft.Equals(other.PageDisplayLeft)
                ) && 
                (
                    this.PageDisplayRight == other.PageDisplayRight ||
                    this.PageDisplayRight != null &&
                    this.PageDisplayRight.Equals(other.PageDisplayRight)
                ) && 
                (
                    this.PageDisplayTop == other.PageDisplayTop ||
                    this.PageDisplayTop != null &&
                    this.PageDisplayTop.Equals(other.PageDisplayTop)
                ) && 
                (
                    this.PageDisplayZoom == other.PageDisplayZoom ||
                    this.PageDisplayZoom != null &&
                    this.PageDisplayZoom.Equals(other.PageDisplayZoom)
                ) && 
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) && 
                (
                    this.RemoteFile == other.RemoteFile ||
                    this.RemoteFile != null &&
                    this.RemoteFile.Equals(other.RemoteFile)
                ) && 
                (
                    this.Bookmarks == other.Bookmarks ||
                    this.Bookmarks != null &&
                    this.Bookmarks.Equals(other.Bookmarks)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Italic != null)
                    hash = hash * 59 + this.Italic.GetHashCode();
                if (this.Bold != null)
                    hash = hash * 59 + this.Bold.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
                if (this.PageDisplay != null)
                    hash = hash * 59 + this.PageDisplay.GetHashCode();
                if (this.PageDisplayBottom != null)
                    hash = hash * 59 + this.PageDisplayBottom.GetHashCode();
                if (this.PageDisplayLeft != null)
                    hash = hash * 59 + this.PageDisplayLeft.GetHashCode();
                if (this.PageDisplayRight != null)
                    hash = hash * 59 + this.PageDisplayRight.GetHashCode();
                if (this.PageDisplayTop != null)
                    hash = hash * 59 + this.PageDisplayTop.GetHashCode();
                if (this.PageDisplayZoom != null)
                    hash = hash * 59 + this.PageDisplayZoom.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.RemoteFile != null)
                    hash = hash * 59 + this.RemoteFile.GetHashCode();
                if (this.Bookmarks != null)
                    hash = hash * 59 + this.Bookmarks.GetHashCode();
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
