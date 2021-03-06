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
    /// MergePullRequestForm form for merging Pull Request
    /// </summary>
    [DataContract]
    public partial class MergePullRequestOption :  IEquatable<MergePullRequestOption>
    {
        /// <summary>
        /// Defines Do
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DoEnum
        {
            /// <summary>
            /// Enum Merge for value: merge
            /// </summary>
            [EnumMember(Value = "merge")]
            Merge = 1,

            /// <summary>
            /// Enum Rebase for value: rebase
            /// </summary>
            [EnumMember(Value = "rebase")]
            Rebase = 2,

            /// <summary>
            /// Enum RebaseMerge for value: rebase-merge
            /// </summary>
            [EnumMember(Value = "rebase-merge")]
            RebaseMerge = 3,

            /// <summary>
            /// Enum Squash for value: squash
            /// </summary>
            [EnumMember(Value = "squash")]
            Squash = 4

        }

        /// <summary>
        /// Gets or Sets Do
        /// </summary>
        [DataMember(Name="Do", EmitDefaultValue=false)]
        public DoEnum Do { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergePullRequestOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MergePullRequestOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergePullRequestOption" /> class.
        /// </summary>
        /// <param name="_do">_do (required).</param>
        /// <param name="mergeMessageField">mergeMessageField.</param>
        /// <param name="mergeTitleField">mergeTitleField.</param>
        /// <param name="forceMerge">forceMerge.</param>
        public MergePullRequestOption(DoEnum _do = default(DoEnum), string mergeMessageField = default(string), string mergeTitleField = default(string), bool forceMerge = default(bool))
        {
            // to ensure "_do" is required (not null)
            if (_do == null)
            {
                throw new InvalidDataException("_do is a required property for MergePullRequestOption and cannot be null");
            }
            else
            {
                this.Do = _do;
            }
            
            this.MergeMessageField = mergeMessageField;
            this.MergeTitleField = mergeTitleField;
            this.ForceMerge = forceMerge;
        }
        

        /// <summary>
        /// Gets or Sets MergeMessageField
        /// </summary>
        [DataMember(Name="MergeMessageField", EmitDefaultValue=false)]
        public string MergeMessageField { get; set; }

        /// <summary>
        /// Gets or Sets MergeTitleField
        /// </summary>
        [DataMember(Name="MergeTitleField", EmitDefaultValue=false)]
        public string MergeTitleField { get; set; }

        /// <summary>
        /// Gets or Sets ForceMerge
        /// </summary>
        [DataMember(Name="force_merge", EmitDefaultValue=false)]
        public bool ForceMerge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergePullRequestOption {\n");
            sb.Append("  Do: ").Append(Do).Append("\n");
            sb.Append("  MergeMessageField: ").Append(MergeMessageField).Append("\n");
            sb.Append("  MergeTitleField: ").Append(MergeTitleField).Append("\n");
            sb.Append("  ForceMerge: ").Append(ForceMerge).Append("\n");
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
            return this.Equals(input as MergePullRequestOption);
        }

        /// <summary>
        /// Returns true if MergePullRequestOption instances are equal
        /// </summary>
        /// <param name="input">Instance of MergePullRequestOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergePullRequestOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Do == input.Do ||
                    (this.Do != null &&
                    this.Do.Equals(input.Do))
                ) && 
                (
                    this.MergeMessageField == input.MergeMessageField ||
                    (this.MergeMessageField != null &&
                    this.MergeMessageField.Equals(input.MergeMessageField))
                ) && 
                (
                    this.MergeTitleField == input.MergeTitleField ||
                    (this.MergeTitleField != null &&
                    this.MergeTitleField.Equals(input.MergeTitleField))
                ) && 
                (
                    this.ForceMerge == input.ForceMerge ||
                    (this.ForceMerge != null &&
                    this.ForceMerge.Equals(input.ForceMerge))
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
                if (this.Do != null)
                    hashCode = hashCode * 59 + this.Do.GetHashCode();
                if (this.MergeMessageField != null)
                    hashCode = hashCode * 59 + this.MergeMessageField.GetHashCode();
                if (this.MergeTitleField != null)
                    hashCode = hashCode * 59 + this.MergeTitleField.GetHashCode();
                if (this.ForceMerge != null)
                    hashCode = hashCode * 59 + this.ForceMerge.GetHashCode();
                return hashCode;
            }
        }
    }

}
