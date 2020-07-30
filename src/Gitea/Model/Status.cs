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
    /// Status holds a single Status of a single Commit
    /// </summary>
    [DataContract]
    public partial class Status :  IEquatable<Status>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Status" /> class.
        /// </summary>
        /// <param name="context">context.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="creator">creator.</param>
        /// <param name="description">description.</param>
        /// <param name="id">id.</param>
        /// <param name="status">StatusState holds the state of a Status It can be \&quot;pending\&quot;, \&quot;success\&quot;, \&quot;error\&quot;, \&quot;failure\&quot;, and \&quot;warning\&quot;.</param>
        /// <param name="targetUrl">targetUrl.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="url">url.</param>
        public Status(string context = default(string), DateTime createdAt = default(DateTime), User creator = default(User), string description = default(string), long id = default(long), string status = default(string), string targetUrl = default(string), DateTime updatedAt = default(DateTime), string url = default(string))
        {
            this.Context = context;
            this.CreatedAt = createdAt;
            this.Creator = creator;
            this.Description = description;
            this.Id = id;
            this._Status = status;
            this.TargetUrl = targetUrl;
            this.UpdatedAt = updatedAt;
            this.Url = url;
        }
        
        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public User Creator { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// StatusState holds the state of a Status It can be \&quot;pending\&quot;, \&quot;success\&quot;, \&quot;error\&quot;, \&quot;failure\&quot;, and \&quot;warning\&quot;
        /// </summary>
        /// <value>StatusState holds the state of a Status It can be \&quot;pending\&quot;, \&quot;success\&quot;, \&quot;error\&quot;, \&quot;failure\&quot;, and \&quot;warning\&quot;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string _Status { get; set; }

        /// <summary>
        /// Gets or Sets TargetUrl
        /// </summary>
        [DataMember(Name="target_url", EmitDefaultValue=false)]
        public string TargetUrl { get; set; }

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
            sb.Append("class Status {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Status: ").Append(_Status).Append("\n");
            sb.Append("  TargetUrl: ").Append(TargetUrl).Append("\n");
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
            return this.Equals(input as Status);
        }

        /// <summary>
        /// Returns true if Status instances are equal
        /// </summary>
        /// <param name="input">Instance of Status to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Status input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this._Status == input._Status ||
                    (this._Status != null &&
                    this._Status.Equals(input._Status))
                ) && 
                (
                    this.TargetUrl == input.TargetUrl ||
                    (this.TargetUrl != null &&
                    this.TargetUrl.Equals(input.TargetUrl))
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
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this._Status != null)
                    hashCode = hashCode * 59 + this._Status.GetHashCode();
                if (this.TargetUrl != null)
                    hashCode = hashCode * 59 + this.TargetUrl.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}