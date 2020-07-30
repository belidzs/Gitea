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
    /// EditTeamOption options for editing a team
    /// </summary>
    [DataContract]
    public partial class EditTeamOption :  IEquatable<EditTeamOption>
    {
        /// <summary>
        /// Defines Permission
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionEnum
        {
            /// <summary>
            /// Enum Read for value: read
            /// </summary>
            [EnumMember(Value = "read")]
            Read = 1,

            /// <summary>
            /// Enum Write for value: write
            /// </summary>
            [EnumMember(Value = "write")]
            Write = 2,

            /// <summary>
            /// Enum Admin for value: admin
            /// </summary>
            [EnumMember(Value = "admin")]
            Admin = 3

        }

        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public PermissionEnum? Permission { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EditTeamOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EditTeamOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EditTeamOption" /> class.
        /// </summary>
        /// <param name="canCreateOrgRepo">canCreateOrgRepo.</param>
        /// <param name="description">description.</param>
        /// <param name="includesAllRepositories">includesAllRepositories.</param>
        /// <param name="name">name (required).</param>
        /// <param name="permission">permission.</param>
        /// <param name="units">units.</param>
        public EditTeamOption(bool canCreateOrgRepo = default(bool), string description = default(string), bool includesAllRepositories = default(bool), string name = default(string), PermissionEnum? permission = default(PermissionEnum?), List<string> units = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EditTeamOption and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.CanCreateOrgRepo = canCreateOrgRepo;
            this.Description = description;
            this.IncludesAllRepositories = includesAllRepositories;
            this.Permission = permission;
            this.Units = units;
        }
        
        /// <summary>
        /// Gets or Sets CanCreateOrgRepo
        /// </summary>
        [DataMember(Name="can_create_org_repo", EmitDefaultValue=false)]
        public bool CanCreateOrgRepo { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IncludesAllRepositories
        /// </summary>
        [DataMember(Name="includes_all_repositories", EmitDefaultValue=false)]
        public bool IncludesAllRepositories { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public List<string> Units { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditTeamOption {\n");
            sb.Append("  CanCreateOrgRepo: ").Append(CanCreateOrgRepo).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IncludesAllRepositories: ").Append(IncludesAllRepositories).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
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
            return this.Equals(input as EditTeamOption);
        }

        /// <summary>
        /// Returns true if EditTeamOption instances are equal
        /// </summary>
        /// <param name="input">Instance of EditTeamOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EditTeamOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanCreateOrgRepo == input.CanCreateOrgRepo ||
                    (this.CanCreateOrgRepo != null &&
                    this.CanCreateOrgRepo.Equals(input.CanCreateOrgRepo))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IncludesAllRepositories == input.IncludesAllRepositories ||
                    (this.IncludesAllRepositories != null &&
                    this.IncludesAllRepositories.Equals(input.IncludesAllRepositories))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units != null &&
                    input.Units != null &&
                    this.Units.SequenceEqual(input.Units)
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
                if (this.CanCreateOrgRepo != null)
                    hashCode = hashCode * 59 + this.CanCreateOrgRepo.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IncludesAllRepositories != null)
                    hashCode = hashCode * 59 + this.IncludesAllRepositories.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                return hashCode;
            }
        }
    }

}
