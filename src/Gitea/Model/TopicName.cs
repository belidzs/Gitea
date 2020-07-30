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
    /// TopicName a list of repo topic names
    /// </summary>
    [DataContract]
    public partial class TopicName :  IEquatable<TopicName>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicName" /> class.
        /// </summary>
        /// <param name="topics">topics.</param>
        public TopicName(List<string> topics = default(List<string>))
        {
            this.Topics = topics;
        }
        
        /// <summary>
        /// Gets or Sets Topics
        /// </summary>
        [DataMember(Name="topics", EmitDefaultValue=false)]
        public List<string> Topics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicName {\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
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
            return this.Equals(input as TopicName);
        }

        /// <summary>
        /// Returns true if TopicName instances are equal
        /// </summary>
        /// <param name="input">Instance of TopicName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopicName input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Topics == input.Topics ||
                    this.Topics != null &&
                    input.Topics != null &&
                    this.Topics.SequenceEqual(input.Topics)
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
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                return hashCode;
            }
        }
    }

}
