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
    /// CreateKeyOption options when creating a key
    /// </summary>
    [DataContract]
    public partial class CreateKeyOption :  IEquatable<CreateKeyOption>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeyOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateKeyOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeyOption" /> class.
        /// </summary>
        /// <param name="key">An armored SSH key to add (required).</param>
        /// <param name="readOnly">Describe if the key has only read access or read/write.</param>
        /// <param name="title">Title of the key to add (required).</param>
        public CreateKeyOption(string key = default(string), bool readOnly = default(bool), string title = default(string))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for CreateKeyOption and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for CreateKeyOption and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            
            this.ReadOnly = readOnly;
        }
        
        /// <summary>
        /// An armored SSH key to add
        /// </summary>
        /// <value>An armored SSH key to add</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Describe if the key has only read access or read/write
        /// </summary>
        /// <value>Describe if the key has only read access or read/write</value>
        [DataMember(Name="read_only", EmitDefaultValue=false)]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Title of the key to add
        /// </summary>
        /// <value>Title of the key to add</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKeyOption {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
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
            return this.Equals(input as CreateKeyOption);
        }

        /// <summary>
        /// Returns true if CreateKeyOption instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateKeyOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateKeyOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }
    }

}
