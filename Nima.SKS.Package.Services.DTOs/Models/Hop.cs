/*
 * Parcel Logistics Service
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.20.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Nima.SKS.Package.Services.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public abstract class Hop : JsonConverter
    { 
        /// <summary>
        /// Gets or Sets HopType
        /// </summary>
        [Required]

        [DataMember(Name="hopType")]
        public string HopType { get; set; }

        /// <summary>
        /// Unique CODE of the hop.
        /// </summary>
        /// <value>Unique CODE of the hop.</value>
        [Required]
        [RegularExpression("/^[A-Z]{4}\\d{1,4}$/")]
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Description of the hop.
        /// </summary>
        /// <value>Description of the hop.</value>
        [Required]

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Delay processing takes on the hop.
        /// </summary>
        /// <value>Delay processing takes on the hop.</value>
        [Required]

        [DataMember(Name="processingDelayMins")]
        public int? ProcessingDelayMins { get; set; }

        /// <summary>
        /// Name of the location (village, city, ..) of the hop.
        /// </summary>
        /// <value>Name of the location (village, city, ..) of the hop.</value>
        [Required]

        [DataMember(Name="locationName")]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or Sets LocationCoordinates
        /// </summary>
        [Required]

        [DataMember(Name="locationCoordinates")]
        public GeoCoordinate LocationCoordinates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Hop {\n");
            sb.Append("  HopType: ").Append(HopType).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProcessingDelayMins: ").Append(ProcessingDelayMins).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  LocationCoordinates: ").Append(LocationCoordinates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Hop)obj);
        }

        /// <summary>
        /// Returns true if Hop instances are equal
        /// </summary>
        /// <param name="other">Instance of Hop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Hop other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HopType == other.HopType ||
                    HopType != null &&
                    HopType.Equals(other.HopType)
                ) && 
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    ProcessingDelayMins == other.ProcessingDelayMins ||
                    ProcessingDelayMins != null &&
                    ProcessingDelayMins.Equals(other.ProcessingDelayMins)
                ) && 
                (
                    LocationName == other.LocationName ||
                    LocationName != null &&
                    LocationName.Equals(other.LocationName)
                ) && 
                (
                    LocationCoordinates == other.LocationCoordinates ||
                    LocationCoordinates != null &&
                    LocationCoordinates.Equals(other.LocationCoordinates)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (HopType != null)
                    hashCode = hashCode * 59 + HopType.GetHashCode();
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (ProcessingDelayMins != null)
                    hashCode = hashCode * 59 + ProcessingDelayMins.GetHashCode();
                    if (LocationName != null)
                    hashCode = hashCode * 59 + LocationName.GetHashCode();
                    if (LocationCoordinates != null)
                    hashCode = hashCode * 59 + LocationCoordinates.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Hop left, Hop right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Hop left, Hop right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
