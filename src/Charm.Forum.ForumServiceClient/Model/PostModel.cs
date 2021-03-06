/*
 * Forum
 *
 * An api for supporting forum posts and comments.
 *
 * The version of the OpenAPI document: 0.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Charm.Forum.ForumServiceClient.Client.OpenAPIDateConverter;

namespace Charm.Forum.ForumServiceClient.Model
{
    /// <summary>
    /// PostModel
    /// </summary>
    [DataContract(Name = "PostModel")]
    public partial class PostModel : IEquatable<PostModel>, IValidatableObject
    {
        /// <summary>
        /// Defines PostType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PostTypeEnum
        {
            /// <summary>
            /// Enum Information for value: information
            /// </summary>
            [EnumMember(Value = "information")]
            Information = 1,

            /// <summary>
            /// Enum Discussion for value: discussion
            /// </summary>
            [EnumMember(Value = "discussion")]
            Discussion = 2,

            /// <summary>
            /// Enum Alert for value: alert
            /// </summary>
            [EnumMember(Value = "alert")]
            Alert = 3,

            /// <summary>
            /// Enum Inquiry for value: inquiry
            /// </summary>
            [EnumMember(Value = "inquiry")]
            Inquiry = 4

        }


        /// <summary>
        /// Gets or Sets PostType
        /// </summary>
        [DataMember(Name = "postType", IsRequired = true, EmitDefaultValue = false)]
        public PostTypeEnum PostType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostModel" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="text">text (required).</param>
        /// <param name="username">username (required).</param>
        /// <param name="created">Datetime for when the post was created. (required).</param>
        /// <param name="postType">postType (required).</param>
        public PostModel(string title = default(string), string text = default(string), string username = default(string), string created = default(string), PostTypeEnum postType = default(PostTypeEnum))
        {
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for PostModel and cannot be null");
            // to ensure "text" is required (not null)
            this.Text = text ?? throw new ArgumentNullException("text is a required property for PostModel and cannot be null");
            // to ensure "username" is required (not null)
            this.Username = username ?? throw new ArgumentNullException("username is a required property for PostModel and cannot be null");
            // to ensure "created" is required (not null)
            this.Created = created ?? throw new ArgumentNullException("created is a required property for PostModel and cannot be null");
            this.PostType = postType;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", IsRequired = true, EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Datetime for when the post was created.
        /// </summary>
        /// <value>Datetime for when the post was created.</value>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = false)]
        public string Created { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostModel {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  PostType: ").Append(PostType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostModel);
        }

        /// <summary>
        /// Returns true if PostModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PostModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.PostType == input.PostType ||
                    this.PostType.Equals(input.PostType)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                hashCode = hashCode * 59 + this.PostType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
