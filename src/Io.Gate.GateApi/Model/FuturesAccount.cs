/*
 * Gate API v4
 *
 * APIv4 provides spot, margin and futures trading operations. There are public APIs to retrieve the real-time market statistics, and private APIs which needs authentication to trade on user's behalf.
 *
 * Contact: support@mail.gate.io
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
using OpenAPIDateConverter = Io.Gate.GateApi.Client.OpenAPIDateConverter;

namespace Io.Gate.GateApi.Model
{
    /// <summary>
    /// FuturesAccount
    /// </summary>
    [DataContract]
    public partial class FuturesAccount :  IEquatable<FuturesAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesAccount" /> class.
        /// </summary>
        /// <param name="total">Total assets, total &#x3D; position_margin + order_margin + available.</param>
        /// <param name="unrealisedPnl">Unrealized PNL.</param>
        /// <param name="positionMargin">Position margin.</param>
        /// <param name="orderMargin">Order margin of unfinished orders.</param>
        /// <param name="available">Available balance to transfer out or trade.</param>
        /// <param name="point">POINT amount.</param>
        /// <param name="currency">Settle currency.</param>
        public FuturesAccount(string total = default(string), string unrealisedPnl = default(string), string positionMargin = default(string), string orderMargin = default(string), string available = default(string), string point = default(string), string currency = default(string))
        {
            this.Total = total;
            this.UnrealisedPnl = unrealisedPnl;
            this.PositionMargin = positionMargin;
            this.OrderMargin = orderMargin;
            this.Available = available;
            this.Point = point;
            this.Currency = currency;
        }

        /// <summary>
        /// Total assets, total &#x3D; position_margin + order_margin + available
        /// </summary>
        /// <value>Total assets, total &#x3D; position_margin + order_margin + available</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public string Total { get; set; }

        /// <summary>
        /// Unrealized PNL
        /// </summary>
        /// <value>Unrealized PNL</value>
        [DataMember(Name="unrealised_pnl", EmitDefaultValue=false)]
        public string UnrealisedPnl { get; set; }

        /// <summary>
        /// Position margin
        /// </summary>
        /// <value>Position margin</value>
        [DataMember(Name="position_margin", EmitDefaultValue=false)]
        public string PositionMargin { get; set; }

        /// <summary>
        /// Order margin of unfinished orders
        /// </summary>
        /// <value>Order margin of unfinished orders</value>
        [DataMember(Name="order_margin", EmitDefaultValue=false)]
        public string OrderMargin { get; set; }

        /// <summary>
        /// Available balance to transfer out or trade
        /// </summary>
        /// <value>Available balance to transfer out or trade</value>
        [DataMember(Name="available", EmitDefaultValue=false)]
        public string Available { get; set; }

        /// <summary>
        /// POINT amount
        /// </summary>
        /// <value>POINT amount</value>
        [DataMember(Name="point", EmitDefaultValue=false)]
        public string Point { get; set; }

        /// <summary>
        /// Settle currency
        /// </summary>
        /// <value>Settle currency</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuturesAccount {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  UnrealisedPnl: ").Append(UnrealisedPnl).Append("\n");
            sb.Append("  PositionMargin: ").Append(PositionMargin).Append("\n");
            sb.Append("  OrderMargin: ").Append(OrderMargin).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Point: ").Append(Point).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as FuturesAccount);
        }

        /// <summary>
        /// Returns true if FuturesAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of FuturesAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FuturesAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.UnrealisedPnl == input.UnrealisedPnl ||
                    (this.UnrealisedPnl != null &&
                    this.UnrealisedPnl.Equals(input.UnrealisedPnl))
                ) && 
                (
                    this.PositionMargin == input.PositionMargin ||
                    (this.PositionMargin != null &&
                    this.PositionMargin.Equals(input.PositionMargin))
                ) && 
                (
                    this.OrderMargin == input.OrderMargin ||
                    (this.OrderMargin != null &&
                    this.OrderMargin.Equals(input.OrderMargin))
                ) && 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && 
                (
                    this.Point == input.Point ||
                    (this.Point != null &&
                    this.Point.Equals(input.Point))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.UnrealisedPnl != null)
                    hashCode = hashCode * 59 + this.UnrealisedPnl.GetHashCode();
                if (this.PositionMargin != null)
                    hashCode = hashCode * 59 + this.PositionMargin.GetHashCode();
                if (this.OrderMargin != null)
                    hashCode = hashCode * 59 + this.OrderMargin.GetHashCode();
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.Point != null)
                    hashCode = hashCode * 59 + this.Point.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
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