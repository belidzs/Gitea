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
    /// GeneralUISettings contains global ui settings exposed by API
    /// </summary>
    [DataContract]
    public partial class GeneralUISettings :  IEquatable<GeneralUISettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralUISettings" /> class.
        /// </summary>
        /// <param name="allowedReactions">allowedReactions.</param>
        public GeneralUISettings(List<string> allowedReactions = default(List<string>))
        {
            this.AllowedReactions = allowedReactions;
        }
        
        /// <summary>
        /// Gets or Sets AllowedReactions
        /// </summary>
        [DataMember(Name="allowed_reactions", EmitDefaultValue=false)]
        public List<string> AllowedReactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralUISettings {\n");
            sb.Append("  AllowedReactions: ").Append(AllowedReactions).Append("\n");
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
            return this.Equals(input as GeneralUISettings);
        }

        /// <summary>
        /// Returns true if GeneralUISettings instances are equal
        /// </summary>
        /// <param name="input">Instance of GeneralUISettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeneralUISettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowedReactions == input.AllowedReactions ||
                    this.AllowedReactions != null &&
                    input.AllowedReactions != null &&
                    this.AllowedReactions.SequenceEqual(input.AllowedReactions)
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
                if (this.AllowedReactions != null)
                    hashCode = hashCode * 59 + this.AllowedReactions.GetHashCode();
                return hashCode;
            }
        }
    }

}
