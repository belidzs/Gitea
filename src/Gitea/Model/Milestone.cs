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
    /// Milestone milestone is a collection of issues on one repository
    /// </summary>
    [DataContract]
    public partial class Milestone :  IEquatable<Milestone>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Milestone" /> class.
        /// </summary>
        /// <param name="closedAt">closedAt.</param>
        /// <param name="closedIssues">closedIssues.</param>
        /// <param name="description">description.</param>
        /// <param name="dueOn">dueOn.</param>
        /// <param name="id">id.</param>
        /// <param name="openIssues">openIssues.</param>
        /// <param name="state">StateType issue state type.</param>
        /// <param name="title">title.</param>
        public Milestone(DateTime closedAt = default(DateTime), long closedIssues = default(long), string description = default(string), DateTime dueOn = default(DateTime), long id = default(long), long openIssues = default(long), string state = default(string), string title = default(string))
        {
            this.ClosedAt = closedAt;
            this.ClosedIssues = closedIssues;
            this.Description = description;
            this.DueOn = dueOn;
            this.Id = id;
            this.OpenIssues = openIssues;
            this.State = state;
            this.Title = title;
        }
        
        /// <summary>
        /// Gets or Sets ClosedAt
        /// </summary>
        [DataMember(Name="closed_at", EmitDefaultValue=false)]
        public DateTime? ClosedAt { get; set; }

        /// <summary>
        /// Gets or Sets ClosedIssues
        /// </summary>
        [DataMember(Name="closed_issues", EmitDefaultValue=false)]
        public long ClosedIssues { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DueOn
        /// </summary>
        [DataMember(Name="due_on", EmitDefaultValue=false)]
        public DateTime? DueOn { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets OpenIssues
        /// </summary>
        [DataMember(Name="open_issues", EmitDefaultValue=false)]
        public long OpenIssues { get; set; }

        /// <summary>
        /// StateType issue state type
        /// </summary>
        /// <value>StateType issue state type</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Milestone {\n");
            sb.Append("  ClosedAt: ").Append(ClosedAt).Append("\n");
            sb.Append("  ClosedIssues: ").Append(ClosedIssues).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OpenIssues: ").Append(OpenIssues).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as Milestone);
        }

        /// <summary>
        /// Returns true if Milestone instances are equal
        /// </summary>
        /// <param name="input">Instance of Milestone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Milestone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClosedAt == input.ClosedAt ||
                    (this.ClosedAt != null &&
                    this.ClosedAt.Equals(input.ClosedAt))
                ) && 
                (
                    this.ClosedIssues == input.ClosedIssues ||
                    (this.ClosedIssues != null &&
                    this.ClosedIssues.Equals(input.ClosedIssues))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DueOn == input.DueOn ||
                    (this.DueOn != null &&
                    this.DueOn.Equals(input.DueOn))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OpenIssues == input.OpenIssues ||
                    (this.OpenIssues != null &&
                    this.OpenIssues.Equals(input.OpenIssues))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.ClosedAt != null)
                    hashCode = hashCode * 59 + this.ClosedAt.GetHashCode();
                if (this.ClosedIssues != null)
                    hashCode = hashCode * 59 + this.ClosedIssues.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DueOn != null)
                    hashCode = hashCode * 59 + this.DueOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OpenIssues != null)
                    hashCode = hashCode * 59 + this.OpenIssues.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }
    }

}
