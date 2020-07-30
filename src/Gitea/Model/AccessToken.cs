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
    /// AccessToken
    /// </summary>
    [DataContract]
    public partial class AccessToken :  IEquatable<AccessToken>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessToken" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="sha1">sha1.</param>
        /// <param name="tokenLastEight">tokenLastEight.</param>
        public AccessToken(long id = default(long), string name = default(string), string sha1 = default(string), string tokenLastEight = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Sha1 = sha1;
            this.TokenLastEight = tokenLastEight;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Sha1
        /// </summary>
        [DataMember(Name="sha1", EmitDefaultValue=false)]
        public string Sha1 { get; set; }

        /// <summary>
        /// Gets or Sets TokenLastEight
        /// </summary>
        [DataMember(Name="token_last_eight", EmitDefaultValue=false)]
        public string TokenLastEight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessToken {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sha1: ").Append(Sha1).Append("\n");
            sb.Append("  TokenLastEight: ").Append(TokenLastEight).Append("\n");
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
            return this.Equals(input as AccessToken);
        }

        /// <summary>
        /// Returns true if AccessToken instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Sha1 == input.Sha1 ||
                    (this.Sha1 != null &&
                    this.Sha1.Equals(input.Sha1))
                ) && 
                (
                    this.TokenLastEight == input.TokenLastEight ||
                    (this.TokenLastEight != null &&
                    this.TokenLastEight.Equals(input.TokenLastEight))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Sha1 != null)
                    hashCode = hashCode * 59 + this.Sha1.GetHashCode();
                if (this.TokenLastEight != null)
                    hashCode = hashCode * 59 + this.TokenLastEight.GetHashCode();
                return hashCode;
            }
        }
    }

}
