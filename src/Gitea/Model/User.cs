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
    /// User represents a user
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="avatarUrl">URL to the user&#39;s avatar.</param>
        /// <param name="created">created.</param>
        /// <param name="email">email.</param>
        /// <param name="fullName">the user&#39;s full name.</param>
        /// <param name="id">the user&#39;s id.</param>
        /// <param name="isAdmin">Is the user an administrator.</param>
        /// <param name="language">User locale.</param>
        /// <param name="lastLogin">lastLogin.</param>
        /// <param name="login">the user&#39;s username.</param>
        public User(string avatarUrl = default(string), DateTime created = default(DateTime), string email = default(string), string fullName = default(string), long id = default(long), bool isAdmin = default(bool), string language = default(string), DateTime lastLogin = default(DateTime), string login = default(string))
        {
            this.AvatarUrl = avatarUrl;
            this.Created = created;
            this.Email = email;
            this.FullName = fullName;
            this.Id = id;
            this.IsAdmin = isAdmin;
            this.Language = language;
            this.LastLogin = lastLogin;
            this.Login = login;
        }
        
        /// <summary>
        /// URL to the user&#39;s avatar
        /// </summary>
        /// <value>URL to the user&#39;s avatar</value>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// the user&#39;s full name
        /// </summary>
        /// <value>the user&#39;s full name</value>
        [DataMember(Name="full_name", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// the user&#39;s id
        /// </summary>
        /// <value>the user&#39;s id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Is the user an administrator
        /// </summary>
        /// <value>Is the user an administrator</value>
        [DataMember(Name="is_admin", EmitDefaultValue=false)]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// User locale
        /// </summary>
        /// <value>User locale</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name="last_login", EmitDefaultValue=false)]
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// the user&#39;s username
        /// </summary>
        /// <value>the user&#39;s username</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvatarUrl == input.AvatarUrl ||
                    (this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(input.AvatarUrl))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsAdmin == input.IsAdmin ||
                    (this.IsAdmin != null &&
                    this.IsAdmin.Equals(input.IsAdmin))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
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
                if (this.AvatarUrl != null)
                    hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsAdmin != null)
                    hashCode = hashCode * 59 + this.IsAdmin.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LastLogin != null)
                    hashCode = hashCode * 59 + this.LastLogin.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                return hashCode;
            }
        }
    }

}
