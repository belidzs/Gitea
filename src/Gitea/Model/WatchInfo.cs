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
    /// WatchInfo represents an API watch status of one repository
    /// </summary>
    [DataContract]
    public partial class WatchInfo :  IEquatable<WatchInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WatchInfo" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="ignored">ignored.</param>
        /// <param name="reason">reason.</param>
        /// <param name="repositoryUrl">repositoryUrl.</param>
        /// <param name="subscribed">subscribed.</param>
        /// <param name="url">url.</param>
        public WatchInfo(DateTime createdAt = default(DateTime), bool ignored = default(bool), Object reason = default(Object), string repositoryUrl = default(string), bool subscribed = default(bool), string url = default(string))
        {
            this.CreatedAt = createdAt;
            this.Ignored = ignored;
            this.Reason = reason;
            this.RepositoryUrl = repositoryUrl;
            this.Subscribed = subscribed;
            this.Url = url;
        }
        
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Ignored
        /// </summary>
        [DataMember(Name="ignored", EmitDefaultValue=false)]
        public bool Ignored { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public Object Reason { get; set; }

        /// <summary>
        /// Gets or Sets RepositoryUrl
        /// </summary>
        [DataMember(Name="repository_url", EmitDefaultValue=false)]
        public string RepositoryUrl { get; set; }

        /// <summary>
        /// Gets or Sets Subscribed
        /// </summary>
        [DataMember(Name="subscribed", EmitDefaultValue=false)]
        public bool Subscribed { get; set; }

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
            sb.Append("class WatchInfo {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Ignored: ").Append(Ignored).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  RepositoryUrl: ").Append(RepositoryUrl).Append("\n");
            sb.Append("  Subscribed: ").Append(Subscribed).Append("\n");
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
            return this.Equals(input as WatchInfo);
        }

        /// <summary>
        /// Returns true if WatchInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of WatchInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WatchInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Ignored == input.Ignored ||
                    (this.Ignored != null &&
                    this.Ignored.Equals(input.Ignored))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.RepositoryUrl == input.RepositoryUrl ||
                    (this.RepositoryUrl != null &&
                    this.RepositoryUrl.Equals(input.RepositoryUrl))
                ) && 
                (
                    this.Subscribed == input.Subscribed ||
                    (this.Subscribed != null &&
                    this.Subscribed.Equals(input.Subscribed))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Ignored != null)
                    hashCode = hashCode * 59 + this.Ignored.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.RepositoryUrl != null)
                    hashCode = hashCode * 59 + this.RepositoryUrl.GetHashCode();
                if (this.Subscribed != null)
                    hashCode = hashCode * 59 + this.Subscribed.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}
