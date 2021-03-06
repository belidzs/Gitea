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
    /// Comment represents a comment on a commit or issue
    /// </summary>
    [DataContract]
    public partial class Comment :  IEquatable<Comment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        /// <param name="body">body.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="htmlUrl">htmlUrl.</param>
        /// <param name="id">id.</param>
        /// <param name="issueUrl">issueUrl.</param>
        /// <param name="originalAuthor">originalAuthor.</param>
        /// <param name="originalAuthorId">originalAuthorId.</param>
        /// <param name="pullRequestUrl">pullRequestUrl.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="user">user.</param>
        public Comment(string body = default(string), DateTime createdAt = default(DateTime), string htmlUrl = default(string), long id = default(long), string issueUrl = default(string), string originalAuthor = default(string), long originalAuthorId = default(long), string pullRequestUrl = default(string), DateTime updatedAt = default(DateTime), User user = default(User))
        {
            this.Body = body;
            this.CreatedAt = createdAt;
            this.HtmlUrl = htmlUrl;
            this.Id = id;
            this.IssueUrl = issueUrl;
            this.OriginalAuthor = originalAuthor;
            this.OriginalAuthorId = originalAuthorId;
            this.PullRequestUrl = pullRequestUrl;
            this.UpdatedAt = updatedAt;
            this.User = user;
        }
        
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets HtmlUrl
        /// </summary>
        [DataMember(Name="html_url", EmitDefaultValue=false)]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets IssueUrl
        /// </summary>
        [DataMember(Name="issue_url", EmitDefaultValue=false)]
        public string IssueUrl { get; set; }

        /// <summary>
        /// Gets or Sets OriginalAuthor
        /// </summary>
        [DataMember(Name="original_author", EmitDefaultValue=false)]
        public string OriginalAuthor { get; set; }

        /// <summary>
        /// Gets or Sets OriginalAuthorId
        /// </summary>
        [DataMember(Name="original_author_id", EmitDefaultValue=false)]
        public long OriginalAuthorId { get; set; }

        /// <summary>
        /// Gets or Sets PullRequestUrl
        /// </summary>
        [DataMember(Name="pull_request_url", EmitDefaultValue=false)]
        public string PullRequestUrl { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Comment {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssueUrl: ").Append(IssueUrl).Append("\n");
            sb.Append("  OriginalAuthor: ").Append(OriginalAuthor).Append("\n");
            sb.Append("  OriginalAuthorId: ").Append(OriginalAuthorId).Append("\n");
            sb.Append("  PullRequestUrl: ").Append(PullRequestUrl).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as Comment);
        }

        /// <summary>
        /// Returns true if Comment instances are equal
        /// </summary>
        /// <param name="input">Instance of Comment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Comment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.HtmlUrl == input.HtmlUrl ||
                    (this.HtmlUrl != null &&
                    this.HtmlUrl.Equals(input.HtmlUrl))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IssueUrl == input.IssueUrl ||
                    (this.IssueUrl != null &&
                    this.IssueUrl.Equals(input.IssueUrl))
                ) && 
                (
                    this.OriginalAuthor == input.OriginalAuthor ||
                    (this.OriginalAuthor != null &&
                    this.OriginalAuthor.Equals(input.OriginalAuthor))
                ) && 
                (
                    this.OriginalAuthorId == input.OriginalAuthorId ||
                    (this.OriginalAuthorId != null &&
                    this.OriginalAuthorId.Equals(input.OriginalAuthorId))
                ) && 
                (
                    this.PullRequestUrl == input.PullRequestUrl ||
                    (this.PullRequestUrl != null &&
                    this.PullRequestUrl.Equals(input.PullRequestUrl))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.HtmlUrl != null)
                    hashCode = hashCode * 59 + this.HtmlUrl.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IssueUrl != null)
                    hashCode = hashCode * 59 + this.IssueUrl.GetHashCode();
                if (this.OriginalAuthor != null)
                    hashCode = hashCode * 59 + this.OriginalAuthor.GetHashCode();
                if (this.OriginalAuthorId != null)
                    hashCode = hashCode * 59 + this.OriginalAuthorId.GetHashCode();
                if (this.PullRequestUrl != null)
                    hashCode = hashCode * 59 + this.PullRequestUrl.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                return hashCode;
            }
        }
    }

}
