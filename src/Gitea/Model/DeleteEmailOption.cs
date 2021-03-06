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
    /// DeleteEmailOption options when deleting email addresses
    /// </summary>
    [DataContract]
    public partial class DeleteEmailOption :  IEquatable<DeleteEmailOption>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEmailOption" /> class.
        /// </summary>
        /// <param name="emails">email addresses to delete.</param>
        public DeleteEmailOption(List<string> emails = default(List<string>))
        {
            this.Emails = emails;
        }
        
        /// <summary>
        /// email addresses to delete
        /// </summary>
        /// <value>email addresses to delete</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteEmailOption {\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
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
            return this.Equals(input as DeleteEmailOption);
        }

        /// <summary>
        /// Returns true if DeleteEmailOption instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteEmailOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteEmailOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
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
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                return hashCode;
            }
        }
    }

}
