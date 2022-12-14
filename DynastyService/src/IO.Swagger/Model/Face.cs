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
    /// represents a face information.
    /// </summary>
    [DataContract]
    public partial class Face :  IEquatable<Face>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Face" /> class.
        /// </summary>
        /// <param name="faceUuid">face unique identifier..</param>
        /// <param name="mediaUuid">media unique identifier..</param>
        /// <param name="x">x coordinate of the face bounding box center in pixels..</param>
        /// <param name="y">y coordinate of the face bounding box center in pixels..</param>
        /// <param name="width">width of the face bounding box center in pixels..</param>
        /// <param name="height">height of the face bounding box center in pixels..</param>
        /// <param name="angle">in-plane rotation (roll) of the face bounding box center in degrees..</param>
        /// <param name="detectionScore">confidence-like value of the face detection, low detection scores (lower than 0.5 for example) correspond to higher probability of false detection..</param>
        /// <param name="points">facial landmark points..</param>
        /// <param name="userPoints">user-defined facial landmark points..</param>
        /// <param name="tags">list of detected or labelled face tags - classifiers, attributes, measurements..</param>
        /// <param name="personId">assigned person id and namespace in format name@namespace..</param>
        /// <param name="appearanceId">reserved for future video processing.</param>
        /// <param name="start">reserved for future video processing.</param>
        /// <param name="duration">reserved for future video processing.</param>
        public Face(Guid? faceUuid = default(Guid?), Guid? mediaUuid = default(Guid?), double? x = default(double?), double? y = default(double?), double? width = default(double?), double? height = default(double?), double? angle = default(double?), double? detectionScore = default(double?), List<Point> points = default(List<Point>), List<Point> userPoints = default(List<Point>), List<Tag> tags = default(List<Tag>), string personId = default(string), int? appearanceId = default(int?), string start = default(string), string duration = default(string))
        {
            this.FaceUuid = faceUuid;
            this.MediaUuid = mediaUuid;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Angle = angle;
            this.DetectionScore = detectionScore;
            this.Points = points;
            this.UserPoints = userPoints;
            this.Tags = tags;
            this.PersonId = personId;
            this.AppearanceId = appearanceId;
            this.Start = start;
            this.Duration = duration;
        }
        
        /// <summary>
        /// face unique identifier.
        /// </summary>
        /// <value>face unique identifier.</value>
        [DataMember(Name="face_uuid", EmitDefaultValue=false)]
        public Guid? FaceUuid { get; set; }

        /// <summary>
        /// media unique identifier.
        /// </summary>
        /// <value>media unique identifier.</value>
        [DataMember(Name="media_uuid", EmitDefaultValue=false)]
        public Guid? MediaUuid { get; set; }

        /// <summary>
        /// x coordinate of the face bounding box center in pixels.
        /// </summary>
        /// <value>x coordinate of the face bounding box center in pixels.</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public double? X { get; set; }

        /// <summary>
        /// y coordinate of the face bounding box center in pixels.
        /// </summary>
        /// <value>y coordinate of the face bounding box center in pixels.</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public double? Y { get; set; }

        /// <summary>
        /// width of the face bounding box center in pixels.
        /// </summary>
        /// <value>width of the face bounding box center in pixels.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public double? Width { get; set; }

        /// <summary>
        /// height of the face bounding box center in pixels.
        /// </summary>
        /// <value>height of the face bounding box center in pixels.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public double? Height { get; set; }

        /// <summary>
        /// in-plane rotation (roll) of the face bounding box center in degrees.
        /// </summary>
        /// <value>in-plane rotation (roll) of the face bounding box center in degrees.</value>
        [DataMember(Name="angle", EmitDefaultValue=false)]
        public double? Angle { get; set; }

        /// <summary>
        /// confidence-like value of the face detection, low detection scores (lower than 0.5 for example) correspond to higher probability of false detection.
        /// </summary>
        /// <value>confidence-like value of the face detection, low detection scores (lower than 0.5 for example) correspond to higher probability of false detection.</value>
        [DataMember(Name="detection_score", EmitDefaultValue=false)]
        public double? DetectionScore { get; set; }

        /// <summary>
        /// facial landmark points.
        /// </summary>
        /// <value>facial landmark points.</value>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public List<Point> Points { get; set; }

        /// <summary>
        /// user-defined facial landmark points.
        /// </summary>
        /// <value>user-defined facial landmark points.</value>
        [DataMember(Name="user_points", EmitDefaultValue=false)]
        public List<Point> UserPoints { get; set; }

        /// <summary>
        /// list of detected or labelled face tags - classifiers, attributes, measurements.
        /// </summary>
        /// <value>list of detected or labelled face tags - classifiers, attributes, measurements.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// assigned person id and namespace in format name@namespace.
        /// </summary>
        /// <value>assigned person id and namespace in format name@namespace.</value>
        [DataMember(Name="person_id", EmitDefaultValue=false)]
        public string PersonId { get; set; }

        /// <summary>
        /// reserved for future video processing
        /// </summary>
        /// <value>reserved for future video processing</value>
        [DataMember(Name="appearance_id", EmitDefaultValue=false)]
        public int? AppearanceId { get; set; }

        /// <summary>
        /// reserved for future video processing
        /// </summary>
        /// <value>reserved for future video processing</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public string Start { get; set; }

        /// <summary>
        /// reserved for future video processing
        /// </summary>
        /// <value>reserved for future video processing</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Face {\n");
            sb.Append("  FaceUuid: ").Append(FaceUuid).Append("\n");
            sb.Append("  MediaUuid: ").Append(MediaUuid).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
            sb.Append("  DetectionScore: ").Append(DetectionScore).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  UserPoints: ").Append(UserPoints).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  PersonId: ").Append(PersonId).Append("\n");
            sb.Append("  AppearanceId: ").Append(AppearanceId).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            return this.Equals(input as Face);
        }

        /// <summary>
        /// Returns true if Face instances are equal
        /// </summary>
        /// <param name="input">Instance of Face to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Face input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FaceUuid == input.FaceUuid ||
                    (this.FaceUuid != null &&
                    this.FaceUuid.Equals(input.FaceUuid))
                ) && 
                (
                    this.MediaUuid == input.MediaUuid ||
                    (this.MediaUuid != null &&
                    this.MediaUuid.Equals(input.MediaUuid))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Angle == input.Angle ||
                    (this.Angle != null &&
                    this.Angle.Equals(input.Angle))
                ) && 
                (
                    this.DetectionScore == input.DetectionScore ||
                    (this.DetectionScore != null &&
                    this.DetectionScore.Equals(input.DetectionScore))
                ) && 
                (
                    this.Points == input.Points ||
                    this.Points != null &&
                    this.Points.SequenceEqual(input.Points)
                ) && 
                (
                    this.UserPoints == input.UserPoints ||
                    this.UserPoints != null &&
                    this.UserPoints.SequenceEqual(input.UserPoints)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.PersonId == input.PersonId ||
                    (this.PersonId != null &&
                    this.PersonId.Equals(input.PersonId))
                ) && 
                (
                    this.AppearanceId == input.AppearanceId ||
                    (this.AppearanceId != null &&
                    this.AppearanceId.Equals(input.AppearanceId))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                if (this.FaceUuid != null)
                    hashCode = hashCode * 59 + this.FaceUuid.GetHashCode();
                if (this.MediaUuid != null)
                    hashCode = hashCode * 59 + this.MediaUuid.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Angle != null)
                    hashCode = hashCode * 59 + this.Angle.GetHashCode();
                if (this.DetectionScore != null)
                    hashCode = hashCode * 59 + this.DetectionScore.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.UserPoints != null)
                    hashCode = hashCode * 59 + this.UserPoints.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.PersonId != null)
                    hashCode = hashCode * 59 + this.PersonId.GetHashCode();
                if (this.AppearanceId != null)
                    hashCode = hashCode * 59 + this.AppearanceId.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
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
