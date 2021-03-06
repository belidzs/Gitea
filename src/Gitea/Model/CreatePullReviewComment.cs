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
    /// CreatePullReviewComment represent a review comment for creation api
    /// </summary>
    [DataContract]
    public partial class CreatePullReviewComment :  IEquatable<CreatePullReviewComment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePullReviewComment" /> class.
        /// </summary>
        /// <param name="body">body.</param>
        /// <param name="newPosition">if comment to new file line or 0.</param>
        /// <param name="oldPosition">if comment to old file line or 0.</param>
        /// <param name="path">the tree path.</param>
        public CreatePullReviewComment(string body = default(string), long newPosition = default(long), long oldPosition = default(long), string path = default(string))
        {
            this.Body = body;
            this.NewPosition = newPosition;
            this.OldPosition = oldPosition;
            this.Path = path;
        }
        
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// if comment to new file line or 0
        /// </summary>
        /// <value>if comment to new file line or 0</value>
        [DataMember(Name="new_position", EmitDefaultValue=false)]
        public long NewPosition { get; set; }

        /// <summary>
        /// if comment to old file line or 0
        /// </summary>
        /// <value>if comment to old file line or 0</value>
        [DataMember(Name="old_position", EmitDefaultValue=false)]
        public long OldPosition { get; set; }

        /// <summary>
        /// the tree path
        /// </summary>
        /// <value>the tree path</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePullReviewComment {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  NewPosition: ").Append(NewPosition).Append("\n");
            sb.Append("  OldPosition: ").Append(OldPosition).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(input as CreatePullReviewComment);
        }

        /// <summary>
        /// Returns true if CreatePullReviewComment instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePullReviewComment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePullReviewComment input)
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
                    this.NewPosition == input.NewPosition ||
                    (this.NewPosition != null &&
                    this.NewPosition.Equals(input.NewPosition))
                ) && 
                (
                    this.OldPosition == input.OldPosition ||
                    (this.OldPosition != null &&
                    this.OldPosition.Equals(input.OldPosition))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.NewPosition != null)
                    hashCode = hashCode * 59 + this.NewPosition.GetHashCode();
                if (this.OldPosition != null)
                    hashCode = hashCode * 59 + this.OldPosition.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }
    }

}
