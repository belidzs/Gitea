/* 
 * Gitea API.
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 1.1.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Gitea.Client.OpenAPIDateConverter;

namespace Gitea.Model
{
    /// <summary>
    /// NotificationSubject contains the notification subject (Issue/Pull/Commit)
    /// </summary>
    [DataContract]
    public partial class NotificationSubject :  IEquatable<NotificationSubject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationSubject" /> class.
        /// </summary>
        /// <param name="latestCommentUrl">latestCommentUrl.</param>
        /// <param name="title">title.</param>
        /// <param name="type">type.</param>
        /// <param name="url">url.</param>
        public NotificationSubject(string latestCommentUrl = default(string), string title = default(string), string type = default(string), string url = default(string))
        {
            this.LatestCommentUrl = latestCommentUrl;
            this.Title = title;
            this.Type = type;
            this.Url = url;
        }
        
        /// <summary>
        /// Gets or Sets LatestCommentUrl
        /// </summary>
        [DataMember(Name="latest_comment_url", EmitDefaultValue=false)]
        public string LatestCommentUrl { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationSubject {\n");
            sb.Append("  LatestCommentUrl: ").Append(LatestCommentUrl).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotificationSubject);
        }

        /// <summary>
        /// Returns true if NotificationSubject instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationSubject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationSubject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LatestCommentUrl == input.LatestCommentUrl ||
                    (this.LatestCommentUrl != null &&
                    this.LatestCommentUrl.Equals(input.LatestCommentUrl))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LatestCommentUrl != null)
                    hashCode = hashCode * 59 + this.LatestCommentUrl.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}
