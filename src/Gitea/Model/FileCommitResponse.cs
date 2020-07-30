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
    /// FileCommitResponse
    /// </summary>
    [DataContract]
    public partial class FileCommitResponse :  IEquatable<FileCommitResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitResponse" /> class.
        /// </summary>
        /// <param name="author">author.</param>
        /// <param name="committer">committer.</param>
        /// <param name="htmlUrl">htmlUrl.</param>
        /// <param name="message">message.</param>
        /// <param name="parents">parents.</param>
        /// <param name="sha">sha.</param>
        /// <param name="tree">tree.</param>
        /// <param name="url">url.</param>
        public FileCommitResponse(CommitUser author = default(CommitUser), CommitUser committer = default(CommitUser), string htmlUrl = default(string), string message = default(string), List<CommitMeta> parents = default(List<CommitMeta>), string sha = default(string), CommitMeta tree = default(CommitMeta), string url = default(string))
        {
            this.Author = author;
            this.Committer = committer;
            this.HtmlUrl = htmlUrl;
            this.Message = message;
            this.Parents = parents;
            this.Sha = sha;
            this.Tree = tree;
            this.Url = url;
        }
        
        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public CommitUser Author { get; set; }

        /// <summary>
        /// Gets or Sets Committer
        /// </summary>
        [DataMember(Name="committer", EmitDefaultValue=false)]
        public CommitUser Committer { get; set; }

        /// <summary>
        /// Gets or Sets HtmlUrl
        /// </summary>
        [DataMember(Name="html_url", EmitDefaultValue=false)]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Parents
        /// </summary>
        [DataMember(Name="parents", EmitDefaultValue=false)]
        public List<CommitMeta> Parents { get; set; }

        /// <summary>
        /// Gets or Sets Sha
        /// </summary>
        [DataMember(Name="sha", EmitDefaultValue=false)]
        public string Sha { get; set; }

        /// <summary>
        /// Gets or Sets Tree
        /// </summary>
        [DataMember(Name="tree", EmitDefaultValue=false)]
        public CommitMeta Tree { get; set; }

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
            sb.Append("class FileCommitResponse {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Committer: ").Append(Committer).Append("\n");
            sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Parents: ").Append(Parents).Append("\n");
            sb.Append("  Sha: ").Append(Sha).Append("\n");
            sb.Append("  Tree: ").Append(Tree).Append("\n");
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
            return this.Equals(input as FileCommitResponse);
        }

        /// <summary>
        /// Returns true if FileCommitResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FileCommitResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileCommitResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Committer == input.Committer ||
                    (this.Committer != null &&
                    this.Committer.Equals(input.Committer))
                ) && 
                (
                    this.HtmlUrl == input.HtmlUrl ||
                    (this.HtmlUrl != null &&
                    this.HtmlUrl.Equals(input.HtmlUrl))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Parents == input.Parents ||
                    this.Parents != null &&
                    input.Parents != null &&
                    this.Parents.SequenceEqual(input.Parents)
                ) && 
                (
                    this.Sha == input.Sha ||
                    (this.Sha != null &&
                    this.Sha.Equals(input.Sha))
                ) && 
                (
                    this.Tree == input.Tree ||
                    (this.Tree != null &&
                    this.Tree.Equals(input.Tree))
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
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Committer != null)
                    hashCode = hashCode * 59 + this.Committer.GetHashCode();
                if (this.HtmlUrl != null)
                    hashCode = hashCode * 59 + this.HtmlUrl.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Parents != null)
                    hashCode = hashCode * 59 + this.Parents.GetHashCode();
                if (this.Sha != null)
                    hashCode = hashCode * 59 + this.Sha.GetHashCode();
                if (this.Tree != null)
                    hashCode = hashCode * 59 + this.Tree.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}