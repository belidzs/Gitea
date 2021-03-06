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
    /// CreatePullReviewOptions are options to create a pull review
    /// </summary>
    [DataContract]
    public partial class CreatePullReviewOptions :  IEquatable<CreatePullReviewOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePullReviewOptions" /> class.
        /// </summary>
        /// <param name="body">body.</param>
        /// <param name="comments">comments.</param>
        /// <param name="commitId">commitId.</param>
        /// <param name="_event">ReviewStateType review state type.</param>
        public CreatePullReviewOptions(string body = default(string), List<CreatePullReviewComment> comments = default(List<CreatePullReviewComment>), string commitId = default(string), string _event = default(string))
        {
            this.Body = body;
            this.Comments = comments;
            this.CommitId = commitId;
            this.Event = _event;
        }
        
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public List<CreatePullReviewComment> Comments { get; set; }

        /// <summary>
        /// Gets or Sets CommitId
        /// </summary>
        [DataMember(Name="commit_id", EmitDefaultValue=false)]
        public string CommitId { get; set; }

        /// <summary>
        /// ReviewStateType review state type
        /// </summary>
        /// <value>ReviewStateType review state type</value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public string Event { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePullReviewOptions {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CommitId: ").Append(CommitId).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
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
            return this.Equals(input as CreatePullReviewOptions);
        }

        /// <summary>
        /// Returns true if CreatePullReviewOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePullReviewOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePullReviewOptions input)
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
                    this.Comments == input.Comments ||
                    this.Comments != null &&
                    input.Comments != null &&
                    this.Comments.SequenceEqual(input.Comments)
                ) && 
                (
                    this.CommitId == input.CommitId ||
                    (this.CommitId != null &&
                    this.CommitId.Equals(input.CommitId))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
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
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CommitId != null)
                    hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                return hashCode;
            }
        }
    }

}
