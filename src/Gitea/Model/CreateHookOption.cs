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
    /// CreateHookOption options when create a hook
    /// </summary>
    [DataContract]
    public partial class CreateHookOption :  IEquatable<CreateHookOption>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Dingtalk for value: dingtalk
            /// </summary>
            [EnumMember(Value = "dingtalk")]
            Dingtalk = 1,

            /// <summary>
            /// Enum Discord for value: discord
            /// </summary>
            [EnumMember(Value = "discord")]
            Discord = 2,

            /// <summary>
            /// Enum Gitea for value: gitea
            /// </summary>
            [EnumMember(Value = "gitea")]
            Gitea = 3,

            /// <summary>
            /// Enum Gogs for value: gogs
            /// </summary>
            [EnumMember(Value = "gogs")]
            Gogs = 4,

            /// <summary>
            /// Enum Msteams for value: msteams
            /// </summary>
            [EnumMember(Value = "msteams")]
            Msteams = 5,

            /// <summary>
            /// Enum Slack for value: slack
            /// </summary>
            [EnumMember(Value = "slack")]
            Slack = 6,

            /// <summary>
            /// Enum Telegram for value: telegram
            /// </summary>
            [EnumMember(Value = "telegram")]
            Telegram = 7,

            /// <summary>
            /// Enum Feishu for value: feishu
            /// </summary>
            [EnumMember(Value = "feishu")]
            Feishu = 8

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateHookOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateHookOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateHookOption" /> class.
        /// </summary>
        /// <param name="active">active (default to false).</param>
        /// <param name="branchFilter">branchFilter.</param>
        /// <param name="config">CreateHookOptionConfig has all config options in it required are \&quot;content_type\&quot; and \&quot;url\&quot; Required (required).</param>
        /// <param name="events">events.</param>
        /// <param name="type">type (required).</param>
        public CreateHookOption(bool active = false, string branchFilter = default(string), Dictionary<string, string> config = default(Dictionary<string, string>), List<string> events = default(List<string>), TypeEnum type = default(TypeEnum))
        {
            // to ensure "config" is required (not null)
            if (config == null)
            {
                throw new InvalidDataException("config is a required property for CreateHookOption and cannot be null");
            }
            else
            {
                this.Config = config;
            }
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CreateHookOption and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // use default value if no "active" provided
            if (active == null)
            {
                this.Active = false;
            }
            else
            {
                this.Active = active;
            }
            this.BranchFilter = branchFilter;
            this.Events = events;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets BranchFilter
        /// </summary>
        [DataMember(Name="branch_filter", EmitDefaultValue=false)]
        public string BranchFilter { get; set; }

        /// <summary>
        /// CreateHookOptionConfig has all config options in it required are \&quot;content_type\&quot; and \&quot;url\&quot; Required
        /// </summary>
        /// <value>CreateHookOptionConfig has all config options in it required are \&quot;content_type\&quot; and \&quot;url\&quot; Required</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public Dictionary<string, string> Config { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<string> Events { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateHookOption {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  BranchFilter: ").Append(BranchFilter).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CreateHookOption);
        }

        /// <summary>
        /// Returns true if CreateHookOption instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateHookOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateHookOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.BranchFilter == input.BranchFilter ||
                    (this.BranchFilter != null &&
                    this.BranchFilter.Equals(input.BranchFilter))
                ) && 
                (
                    this.Config == input.Config ||
                    this.Config != null &&
                    input.Config != null &&
                    this.Config.SequenceEqual(input.Config)
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.BranchFilter != null)
                    hashCode = hashCode * 59 + this.BranchFilter.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }

}