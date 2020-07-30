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
    /// NotificationThread expose Notification on API
    /// </summary>
    [DataContract]
    public partial class NotificationThread :  IEquatable<NotificationThread>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationThread" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="pinned">pinned.</param>
        /// <param name="repository">repository.</param>
        /// <param name="subject">subject.</param>
        /// <param name="unread">unread.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="url">url.</param>
        public NotificationThread(long id = default(long), bool pinned = default(bool), Repository repository = default(Repository), NotificationSubject subject = default(NotificationSubject), bool unread = default(bool), DateTime updatedAt = default(DateTime), string url = default(string))
        {
            this.Id = id;
            this.Pinned = pinned;
            this.Repository = repository;
            this.Subject = subject;
            this.Unread = unread;
            this.UpdatedAt = updatedAt;
            this.Url = url;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Pinned
        /// </summary>
        [DataMember(Name="pinned", EmitDefaultValue=false)]
        public bool Pinned { get; set; }

        /// <summary>
        /// Gets or Sets Repository
        /// </summary>
        [DataMember(Name="repository", EmitDefaultValue=false)]
        public Repository Repository { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public NotificationSubject Subject { get; set; }

        /// <summary>
        /// Gets or Sets Unread
        /// </summary>
        [DataMember(Name="unread", EmitDefaultValue=false)]
        public bool Unread { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; set; }

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
            sb.Append("class NotificationThread {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  Repository: ").Append(Repository).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Unread: ").Append(Unread).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as NotificationThread);
        }

        /// <summary>
        /// Returns true if NotificationThread instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationThread to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationThread input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Pinned == input.Pinned ||
                    (this.Pinned != null &&
                    this.Pinned.Equals(input.Pinned))
                ) && 
                (
                    this.Repository == input.Repository ||
                    (this.Repository != null &&
                    this.Repository.Equals(input.Repository))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Unread == input.Unread ||
                    (this.Unread != null &&
                    this.Unread.Equals(input.Unread))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Pinned != null)
                    hashCode = hashCode * 59 + this.Pinned.GetHashCode();
                if (this.Repository != null)
                    hashCode = hashCode * 59 + this.Repository.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Unread != null)
                    hashCode = hashCode * 59 + this.Unread.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}