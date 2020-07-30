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
    /// Release represents a repository release
    /// </summary>
    [DataContract]
    public partial class Release :  IEquatable<Release>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Release" /> class.
        /// </summary>
        /// <param name="assets">assets.</param>
        /// <param name="author">author.</param>
        /// <param name="body">body.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="draft">draft.</param>
        /// <param name="htmlUrl">htmlUrl.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="prerelease">prerelease.</param>
        /// <param name="publishedAt">publishedAt.</param>
        /// <param name="tagName">tagName.</param>
        /// <param name="tarballUrl">tarballUrl.</param>
        /// <param name="targetCommitish">targetCommitish.</param>
        /// <param name="url">url.</param>
        /// <param name="zipballUrl">zipballUrl.</param>
        public Release(List<Attachment> assets = default(List<Attachment>), User author = default(User), string body = default(string), DateTime createdAt = default(DateTime), bool draft = default(bool), string htmlUrl = default(string), long id = default(long), string name = default(string), bool prerelease = default(bool), DateTime publishedAt = default(DateTime), string tagName = default(string), string tarballUrl = default(string), string targetCommitish = default(string), string url = default(string), string zipballUrl = default(string))
        {
            this.Assets = assets;
            this.Author = author;
            this.Body = body;
            this.CreatedAt = createdAt;
            this.Draft = draft;
            this.HtmlUrl = htmlUrl;
            this.Id = id;
            this.Name = name;
            this.Prerelease = prerelease;
            this.PublishedAt = publishedAt;
            this.TagName = tagName;
            this.TarballUrl = tarballUrl;
            this.TargetCommitish = targetCommitish;
            this.Url = url;
            this.ZipballUrl = zipballUrl;
        }
        
        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name="assets", EmitDefaultValue=false)]
        public List<Attachment> Assets { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public User Author { get; set; }

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
        /// Gets or Sets Draft
        /// </summary>
        [DataMember(Name="draft", EmitDefaultValue=false)]
        public bool Draft { get; set; }

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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Prerelease
        /// </summary>
        [DataMember(Name="prerelease", EmitDefaultValue=false)]
        public bool Prerelease { get; set; }

        /// <summary>
        /// Gets or Sets PublishedAt
        /// </summary>
        [DataMember(Name="published_at", EmitDefaultValue=false)]
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// Gets or Sets TagName
        /// </summary>
        [DataMember(Name="tag_name", EmitDefaultValue=false)]
        public string TagName { get; set; }

        /// <summary>
        /// Gets or Sets TarballUrl
        /// </summary>
        [DataMember(Name="tarball_url", EmitDefaultValue=false)]
        public string TarballUrl { get; set; }

        /// <summary>
        /// Gets or Sets TargetCommitish
        /// </summary>
        [DataMember(Name="target_commitish", EmitDefaultValue=false)]
        public string TargetCommitish { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets ZipballUrl
        /// </summary>
        [DataMember(Name="zipball_url", EmitDefaultValue=false)]
        public string ZipballUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Release {\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Draft: ").Append(Draft).Append("\n");
            sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Prerelease: ").Append(Prerelease).Append("\n");
            sb.Append("  PublishedAt: ").Append(PublishedAt).Append("\n");
            sb.Append("  TagName: ").Append(TagName).Append("\n");
            sb.Append("  TarballUrl: ").Append(TarballUrl).Append("\n");
            sb.Append("  TargetCommitish: ").Append(TargetCommitish).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ZipballUrl: ").Append(ZipballUrl).Append("\n");
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
            return this.Equals(input as Release);
        }

        /// <summary>
        /// Returns true if Release instances are equal
        /// </summary>
        /// <param name="input">Instance of Release to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Release input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Assets == input.Assets ||
                    this.Assets != null &&
                    input.Assets != null &&
                    this.Assets.SequenceEqual(input.Assets)
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
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
                    this.Draft == input.Draft ||
                    (this.Draft != null &&
                    this.Draft.Equals(input.Draft))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Prerelease == input.Prerelease ||
                    (this.Prerelease != null &&
                    this.Prerelease.Equals(input.Prerelease))
                ) && 
                (
                    this.PublishedAt == input.PublishedAt ||
                    (this.PublishedAt != null &&
                    this.PublishedAt.Equals(input.PublishedAt))
                ) && 
                (
                    this.TagName == input.TagName ||
                    (this.TagName != null &&
                    this.TagName.Equals(input.TagName))
                ) && 
                (
                    this.TarballUrl == input.TarballUrl ||
                    (this.TarballUrl != null &&
                    this.TarballUrl.Equals(input.TarballUrl))
                ) && 
                (
                    this.TargetCommitish == input.TargetCommitish ||
                    (this.TargetCommitish != null &&
                    this.TargetCommitish.Equals(input.TargetCommitish))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ZipballUrl == input.ZipballUrl ||
                    (this.ZipballUrl != null &&
                    this.ZipballUrl.Equals(input.ZipballUrl))
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
                if (this.Assets != null)
                    hashCode = hashCode * 59 + this.Assets.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Draft != null)
                    hashCode = hashCode * 59 + this.Draft.GetHashCode();
                if (this.HtmlUrl != null)
                    hashCode = hashCode * 59 + this.HtmlUrl.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Prerelease != null)
                    hashCode = hashCode * 59 + this.Prerelease.GetHashCode();
                if (this.PublishedAt != null)
                    hashCode = hashCode * 59 + this.PublishedAt.GetHashCode();
                if (this.TagName != null)
                    hashCode = hashCode * 59 + this.TagName.GetHashCode();
                if (this.TarballUrl != null)
                    hashCode = hashCode * 59 + this.TarballUrl.GetHashCode();
                if (this.TargetCommitish != null)
                    hashCode = hashCode * 59 + this.TargetCommitish.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ZipballUrl != null)
                    hashCode = hashCode * 59 + this.ZipballUrl.GetHashCode();
                return hashCode;
            }
        }
    }

}
