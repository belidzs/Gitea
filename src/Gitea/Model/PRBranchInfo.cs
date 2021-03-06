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
    /// PRBranchInfo information about a branch
    /// </summary>
    [DataContract]
    public partial class PRBranchInfo :  IEquatable<PRBranchInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PRBranchInfo" /> class.
        /// </summary>
        /// <param name="label">label.</param>
        /// <param name="_ref">_ref.</param>
        /// <param name="repo">repo.</param>
        /// <param name="repoId">repoId.</param>
        /// <param name="sha">sha.</param>
        public PRBranchInfo(string label = default(string), string _ref = default(string), Repository repo = default(Repository), long repoId = default(long), string sha = default(string))
        {
            this.Label = label;
            this.Ref = _ref;
            this.Repo = repo;
            this.RepoId = repoId;
            this.Sha = sha;
        }
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name="ref", EmitDefaultValue=false)]
        public string Ref { get; set; }

        /// <summary>
        /// Gets or Sets Repo
        /// </summary>
        [DataMember(Name="repo", EmitDefaultValue=false)]
        public Repository Repo { get; set; }

        /// <summary>
        /// Gets or Sets RepoId
        /// </summary>
        [DataMember(Name="repo_id", EmitDefaultValue=false)]
        public long RepoId { get; set; }

        /// <summary>
        /// Gets or Sets Sha
        /// </summary>
        [DataMember(Name="sha", EmitDefaultValue=false)]
        public string Sha { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PRBranchInfo {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  Repo: ").Append(Repo).Append("\n");
            sb.Append("  RepoId: ").Append(RepoId).Append("\n");
            sb.Append("  Sha: ").Append(Sha).Append("\n");
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
            return this.Equals(input as PRBranchInfo);
        }

        /// <summary>
        /// Returns true if PRBranchInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PRBranchInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PRBranchInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Ref == input.Ref ||
                    (this.Ref != null &&
                    this.Ref.Equals(input.Ref))
                ) && 
                (
                    this.Repo == input.Repo ||
                    (this.Repo != null &&
                    this.Repo.Equals(input.Repo))
                ) && 
                (
                    this.RepoId == input.RepoId ||
                    (this.RepoId != null &&
                    this.RepoId.Equals(input.RepoId))
                ) && 
                (
                    this.Sha == input.Sha ||
                    (this.Sha != null &&
                    this.Sha.Equals(input.Sha))
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Ref != null)
                    hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.Repo != null)
                    hashCode = hashCode * 59 + this.Repo.GetHashCode();
                if (this.RepoId != null)
                    hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.Sha != null)
                    hashCode = hashCode * 59 + this.Sha.GetHashCode();
                return hashCode;
            }
        }
    }

}
