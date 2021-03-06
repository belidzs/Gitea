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
    /// GitTreeResponse returns a git tree
    /// </summary>
    [DataContract]
    public partial class GitTreeResponse :  IEquatable<GitTreeResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitTreeResponse" /> class.
        /// </summary>
        /// <param name="page">page.</param>
        /// <param name="sha">sha.</param>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="tree">tree.</param>
        /// <param name="truncated">truncated.</param>
        /// <param name="url">url.</param>
        public GitTreeResponse(long page = default(long), string sha = default(string), long totalCount = default(long), List<GitEntry> tree = default(List<GitEntry>), bool truncated = default(bool), string url = default(string))
        {
            this.Page = page;
            this.Sha = sha;
            this.TotalCount = totalCount;
            this.Tree = tree;
            this.Truncated = truncated;
            this.Url = url;
        }
        
        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public long Page { get; set; }

        /// <summary>
        /// Gets or Sets Sha
        /// </summary>
        [DataMember(Name="sha", EmitDefaultValue=false)]
        public string Sha { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets Tree
        /// </summary>
        [DataMember(Name="tree", EmitDefaultValue=false)]
        public List<GitEntry> Tree { get; set; }

        /// <summary>
        /// Gets or Sets Truncated
        /// </summary>
        [DataMember(Name="truncated", EmitDefaultValue=false)]
        public bool Truncated { get; set; }

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
            sb.Append("class GitTreeResponse {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Sha: ").Append(Sha).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Tree: ").Append(Tree).Append("\n");
            sb.Append("  Truncated: ").Append(Truncated).Append("\n");
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
            return this.Equals(input as GitTreeResponse);
        }

        /// <summary>
        /// Returns true if GitTreeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GitTreeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GitTreeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.Sha == input.Sha ||
                    (this.Sha != null &&
                    this.Sha.Equals(input.Sha))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.Tree == input.Tree ||
                    this.Tree != null &&
                    input.Tree != null &&
                    this.Tree.SequenceEqual(input.Tree)
                ) && 
                (
                    this.Truncated == input.Truncated ||
                    (this.Truncated != null &&
                    this.Truncated.Equals(input.Truncated))
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
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Sha != null)
                    hashCode = hashCode * 59 + this.Sha.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Tree != null)
                    hashCode = hashCode * 59 + this.Tree.GetHashCode();
                if (this.Truncated != null)
                    hashCode = hashCode * 59 + this.Truncated.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}
