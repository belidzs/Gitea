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
    /// AddTimeOption options for adding time to an issue
    /// </summary>
    [DataContract]
    public partial class AddTimeOption :  IEquatable<AddTimeOption>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTimeOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddTimeOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTimeOption" /> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="time">time in seconds (required).</param>
        /// <param name="userName">User who spent the time (optional).</param>
        public AddTimeOption(DateTime created = default(DateTime), long time = default(long), string userName = default(string))
        {
            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new InvalidDataException("time is a required property for AddTimeOption and cannot be null");
            }
            else
            {
                this.Time = time;
            }
            
            this.Created = created;
            this.UserName = userName;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// time in seconds
        /// </summary>
        /// <value>time in seconds</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public long Time { get; set; }

        /// <summary>
        /// User who spent the time (optional)
        /// </summary>
        /// <value>User who spent the time (optional)</value>
        [DataMember(Name="user_name", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddTimeOption {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as AddTimeOption);
        }

        /// <summary>
        /// Returns true if AddTimeOption instances are equal
        /// </summary>
        /// <param name="input">Instance of AddTimeOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddTimeOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                return hashCode;
            }
        }
    }

}
