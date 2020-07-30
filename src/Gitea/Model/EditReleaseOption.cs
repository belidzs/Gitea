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
    /// EditReleaseOption options when editing a release
    /// </summary>
    [DataContract]
    public partial class EditReleaseOption :  IEquatable<EditReleaseOption>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditReleaseOption" /> class.
        /// </summary>
        /// <param name="body">body.</param>
        /// <param name="draft">draft.</param>
        /// <param name="name">name.</param>
        /// <param name="prerelease">prerelease.</param>
        /// <param name="tagName">tagName.</param>
        /// <param name="targetCommitish">targetCommitish.</param>
        public EditReleaseOption(string body = default(string), bool draft = default(bool), string name = default(string), bool prerelease = default(bool), string tagName = default(string), string targetCommitish = default(string))
        {
            this.Body = body;
            this.Draft = draft;
            this.Name = name;
            this.Prerelease = prerelease;
            this.TagName = tagName;
            this.TargetCommitish = targetCommitish;
        }
        
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets Draft
        /// </summary>
        [DataMember(Name="draft", EmitDefaultValue=false)]
        public bool Draft { get; set; }

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
        /// Gets or Sets TagName
        /// </summary>
        [DataMember(Name="tag_name", EmitDefaultValue=false)]
        public string TagName { get; set; }

        /// <summary>
        /// Gets or Sets TargetCommitish
        /// </summary>
        [DataMember(Name="target_commitish", EmitDefaultValue=false)]
        public string TargetCommitish { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditReleaseOption {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Draft: ").Append(Draft).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Prerelease: ").Append(Prerelease).Append("\n");
            sb.Append("  TagName: ").Append(TagName).Append("\n");
            sb.Append("  TargetCommitish: ").Append(TargetCommitish).Append("\n");
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
            return this.Equals(input as EditReleaseOption);
        }

        /// <summary>
        /// Returns true if EditReleaseOption instances are equal
        /// </summary>
        /// <param name="input">Instance of EditReleaseOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EditReleaseOption input)
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
                    this.Draft == input.Draft ||
                    (this.Draft != null &&
                    this.Draft.Equals(input.Draft))
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
                    this.TagName == input.TagName ||
                    (this.TagName != null &&
                    this.TagName.Equals(input.TagName))
                ) && 
                (
                    this.TargetCommitish == input.TargetCommitish ||
                    (this.TargetCommitish != null &&
                    this.TargetCommitish.Equals(input.TargetCommitish))
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
                if (this.Draft != null)
                    hashCode = hashCode * 59 + this.Draft.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Prerelease != null)
                    hashCode = hashCode * 59 + this.Prerelease.GetHashCode();
                if (this.TagName != null)
                    hashCode = hashCode * 59 + this.TagName.GetHashCode();
                if (this.TargetCommitish != null)
                    hashCode = hashCode * 59 + this.TargetCommitish.GetHashCode();
                return hashCode;
            }
        }
    }

}
