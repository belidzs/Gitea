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
    /// CreateGPGKeyOption options create user GPG key
    /// </summary>
    [DataContract]
    public partial class CreateGPGKeyOption :  IEquatable<CreateGPGKeyOption>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGPGKeyOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateGPGKeyOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGPGKeyOption" /> class.
        /// </summary>
        /// <param name="armoredPublicKey">An armored GPG key to add (required).</param>
        public CreateGPGKeyOption(string armoredPublicKey = default(string))
        {
            // to ensure "armoredPublicKey" is required (not null)
            if (armoredPublicKey == null)
            {
                throw new InvalidDataException("armoredPublicKey is a required property for CreateGPGKeyOption and cannot be null");
            }
            else
            {
                this.ArmoredPublicKey = armoredPublicKey;
            }
            
        }
        
        /// <summary>
        /// An armored GPG key to add
        /// </summary>
        /// <value>An armored GPG key to add</value>
        [DataMember(Name="armored_public_key", EmitDefaultValue=false)]
        public string ArmoredPublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGPGKeyOption {\n");
            sb.Append("  ArmoredPublicKey: ").Append(ArmoredPublicKey).Append("\n");
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
            return this.Equals(input as CreateGPGKeyOption);
        }

        /// <summary>
        /// Returns true if CreateGPGKeyOption instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGPGKeyOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGPGKeyOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArmoredPublicKey == input.ArmoredPublicKey ||
                    (this.ArmoredPublicKey != null &&
                    this.ArmoredPublicKey.Equals(input.ArmoredPublicKey))
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
                if (this.ArmoredPublicKey != null)
                    hashCode = hashCode * 59 + this.ArmoredPublicKey.GetHashCode();
                return hashCode;
            }
        }
    }

}
