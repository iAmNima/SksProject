/*
 * Parcel Logistics Service
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.20.0
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
    public partial class WebhookMessage : TrackingInformation
    { 
        /// <summary>
        /// Gets or Sets TrackingId
        /// </summary>
        [RegularExpression("/^[A-Z0-9]{9}$/")]
        [DataMember(Name="trackingId")]
        public string TrackingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookMessage {\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return obj.GetType() == GetType() && Equals((WebhookMessage)obj);
        }

        /// <summary>
        /// Returns true if WebhookMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookMessage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TrackingId == other.TrackingId ||
                    TrackingId != null &&
                    TrackingId.Equals(other.TrackingId)
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
                    if (TrackingId != null)
                    hashCode = hashCode * 59 + TrackingId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(WebhookMessage left, WebhookMessage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WebhookMessage left, WebhookMessage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
