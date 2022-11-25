/* 
 * Betaface API 2.0
 *
 * Betaface face recognition API.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// represents a cropped face information.
    /// </summary>
    [DataContract]
    public partial class CroppedFace :  IEquatable<CroppedFace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CroppedFace" /> class.
        /// </summary>
        /// <param name="imageBase64">base64 encoded cropped face image file (jpg or png)..</param>
        /// <param name="face">face information with pixel related properties in cropped image pixel space..</param>
        public CroppedFace(string imageBase64 = default(string), Face face = default(Face))
        {
            this.ImageBase64 = imageBase64;
            this.Face = face;
        }
        
        /// <summary>
        /// base64 encoded cropped face image file (jpg or png).
        /// </summary>
        /// <value>base64 encoded cropped face image file (jpg or png).</value>
        [DataMember(Name="image_base64", EmitDefaultValue=false)]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// face information with pixel related properties in cropped image pixel space.
        /// </summary>
        /// <value>face information with pixel related properties in cropped image pixel space.</value>
        [DataMember(Name="face", EmitDefaultValue=false)]
        public Face Face { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CroppedFace {\n");
            sb.Append("  ImageBase64: ").Append(ImageBase64).Append("\n");
            sb.Append("  Face: ").Append(Face).Append("\n");
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
            return this.Equals(input as CroppedFace);
        }

        /// <summary>
        /// Returns true if CroppedFace instances are equal
        /// </summary>
        /// <param name="input">Instance of CroppedFace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CroppedFace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageBase64 == input.ImageBase64 ||
                    (this.ImageBase64 != null &&
                    this.ImageBase64.Equals(input.ImageBase64))
                ) && 
                (
                    this.Face == input.Face ||
                    (this.Face != null &&
                    this.Face.Equals(input.Face))
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
                if (this.ImageBase64 != null)
                    hashCode = hashCode * 59 + this.ImageBase64.GetHashCode();
                if (this.Face != null)
                    hashCode = hashCode * 59 + this.Face.GetHashCode();
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
