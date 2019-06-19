/* 
 * Golem unlimited low level hub API
 *
 * API description in Markdown.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = gu_rest_api.Client.OpenAPIDateConverter;

namespace gu_rest_api.Model
{
    /// <summary>
    /// VolumeDefBindRw
    /// </summary>
    [DataContract]
    public partial class VolumeDefBindRw :  IEquatable<VolumeDefBindRw>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeDefBindRw" /> class.
        /// </summary>
        /// <param name="src">src.</param>
        /// <param name="target">target.</param>
        public VolumeDefBindRw(string src = default(string), string target = default(string))
        {
            this.Src = src;
            this.Target = target;
        }
        
        /// <summary>
        /// Gets or Sets Src
        /// </summary>
        [DataMember(Name="src", EmitDefaultValue=false)]
        public string Src { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeDefBindRw {\n");
            sb.Append("  Src: ").Append(Src).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(input as VolumeDefBindRw);
        }

        /// <summary>
        /// Returns true if VolumeDefBindRw instances are equal
        /// </summary>
        /// <param name="input">Instance of VolumeDefBindRw to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VolumeDefBindRw input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Src == input.Src ||
                    (this.Src != null &&
                    this.Src.Equals(input.Src))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
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
                if (this.Src != null)
                    hashCode = hashCode * 59 + this.Src.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
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