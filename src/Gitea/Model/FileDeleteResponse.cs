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
    /// FileDeleteResponse contains information about a repo&#39;s file that was deleted
    /// </summary>
    [DataContract]
    public partial class FileDeleteResponse :  IEquatable<FileDeleteResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDeleteResponse" /> class.
        /// </summary>
        /// <param name="commit">commit.</param>
        /// <param name="content">content.</param>
        /// <param name="verification">verification.</param>
        public FileDeleteResponse(FileCommitResponse commit = default(FileCommitResponse), Object content = default(Object), PayloadCommitVerification verification = default(PayloadCommitVerification))
        {
            this.Commit = commit;
            this.Content = content;
            this.Verification = verification;
        }
        
        /// <summary>
        /// Gets or Sets Commit
        /// </summary>
        [DataMember(Name="commit", EmitDefaultValue=false)]
        public FileCommitResponse Commit { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public Object Content { get; set; }

        /// <summary>
        /// Gets or Sets Verification
        /// </summary>
        [DataMember(Name="verification", EmitDefaultValue=false)]
        public PayloadCommitVerification Verification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileDeleteResponse {\n");
            sb.Append("  Commit: ").Append(Commit).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Verification: ").Append(Verification).Append("\n");
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
            return this.Equals(input as FileDeleteResponse);
        }

        /// <summary>
        /// Returns true if FileDeleteResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FileDeleteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDeleteResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Commit == input.Commit ||
                    (this.Commit != null &&
                    this.Commit.Equals(input.Commit))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Verification == input.Verification ||
                    (this.Verification != null &&
                    this.Verification.Equals(input.Verification))
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
                if (this.Commit != null)
                    hashCode = hashCode * 59 + this.Commit.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Verification != null)
                    hashCode = hashCode * 59 + this.Verification.GetHashCode();
                return hashCode;
            }
        }
    }

}