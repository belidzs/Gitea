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
    /// UpdateFileOptions options for updating files Note: &#x60;author&#x60; and &#x60;committer&#x60; are optional (if only one is given, it will be used for the other, otherwise the authenticated user will be used)
    /// </summary>
    [DataContract]
    public partial class UpdateFileOptions :  IEquatable<UpdateFileOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFileOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateFileOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFileOptions" /> class.
        /// </summary>
        /// <param name="author">author.</param>
        /// <param name="branch">branch (optional) to base this file from. if not given, the default branch is used.</param>
        /// <param name="committer">committer.</param>
        /// <param name="content">content must be base64 encoded (required).</param>
        /// <param name="dates">dates.</param>
        /// <param name="fromPath">from_path (optional) is the path of the original file which will be moved/renamed to the path in the URL.</param>
        /// <param name="message">message (optional) for the commit of this file. if not supplied, a default message will be used.</param>
        /// <param name="newBranch">new_branch (optional) will make a new branch from &#x60;branch&#x60; before creating the file.</param>
        /// <param name="sha">sha is the SHA for the file that already exists (required).</param>
        public UpdateFileOptions(Identity author = default(Identity), string branch = default(string), Identity committer = default(Identity), string content = default(string), CommitDateOptions dates = default(CommitDateOptions), string fromPath = default(string), string message = default(string), string newBranch = default(string), string sha = default(string))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for UpdateFileOptions and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            
            // to ensure "sha" is required (not null)
            if (sha == null)
            {
                throw new InvalidDataException("sha is a required property for UpdateFileOptions and cannot be null");
            }
            else
            {
                this.Sha = sha;
            }
            
            this.Author = author;
            this.Branch = branch;
            this.Committer = committer;
            this.Dates = dates;
            this.FromPath = fromPath;
            this.Message = message;
            this.NewBranch = newBranch;
        }
        
        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public Identity Author { get; set; }

        /// <summary>
        /// branch (optional) to base this file from. if not given, the default branch is used
        /// </summary>
        /// <value>branch (optional) to base this file from. if not given, the default branch is used</value>
        [DataMember(Name="branch", EmitDefaultValue=false)]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or Sets Committer
        /// </summary>
        [DataMember(Name="committer", EmitDefaultValue=false)]
        public Identity Committer { get; set; }

        /// <summary>
        /// content must be base64 encoded
        /// </summary>
        /// <value>content must be base64 encoded</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Dates
        /// </summary>
        [DataMember(Name="dates", EmitDefaultValue=false)]
        public CommitDateOptions Dates { get; set; }

        /// <summary>
        /// from_path (optional) is the path of the original file which will be moved/renamed to the path in the URL
        /// </summary>
        /// <value>from_path (optional) is the path of the original file which will be moved/renamed to the path in the URL</value>
        [DataMember(Name="from_path", EmitDefaultValue=false)]
        public string FromPath { get; set; }

        /// <summary>
        /// message (optional) for the commit of this file. if not supplied, a default message will be used
        /// </summary>
        /// <value>message (optional) for the commit of this file. if not supplied, a default message will be used</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// new_branch (optional) will make a new branch from &#x60;branch&#x60; before creating the file
        /// </summary>
        /// <value>new_branch (optional) will make a new branch from &#x60;branch&#x60; before creating the file</value>
        [DataMember(Name="new_branch", EmitDefaultValue=false)]
        public string NewBranch { get; set; }

        /// <summary>
        /// sha is the SHA for the file that already exists
        /// </summary>
        /// <value>sha is the SHA for the file that already exists</value>
        [DataMember(Name="sha", EmitDefaultValue=false)]
        public string Sha { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFileOptions {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  Committer: ").Append(Committer).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Dates: ").Append(Dates).Append("\n");
            sb.Append("  FromPath: ").Append(FromPath).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  NewBranch: ").Append(NewBranch).Append("\n");
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
            return this.Equals(input as UpdateFileOptions);
        }

        /// <summary>
        /// Returns true if UpdateFileOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateFileOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateFileOptions input)
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
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && 
                (
                    this.Committer == input.Committer ||
                    (this.Committer != null &&
                    this.Committer.Equals(input.Committer))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Dates == input.Dates ||
                    (this.Dates != null &&
                    this.Dates.Equals(input.Dates))
                ) && 
                (
                    this.FromPath == input.FromPath ||
                    (this.FromPath != null &&
                    this.FromPath.Equals(input.FromPath))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.NewBranch == input.NewBranch ||
                    (this.NewBranch != null &&
                    this.NewBranch.Equals(input.NewBranch))
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
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Committer != null)
                    hashCode = hashCode * 59 + this.Committer.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Dates != null)
                    hashCode = hashCode * 59 + this.Dates.GetHashCode();
                if (this.FromPath != null)
                    hashCode = hashCode * 59 + this.FromPath.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.NewBranch != null)
                    hashCode = hashCode * 59 + this.NewBranch.GetHashCode();
                if (this.Sha != null)
                    hashCode = hashCode * 59 + this.Sha.GetHashCode();
                return hashCode;
            }
        }
    }

}
