/*
 * Gate API v4
 *
 * Welcome to Gate.io API  APIv4 provides spot, margin and futures trading operations. There are public APIs to retrieve the real-time market statistics, and private APIs which needs authentication to trade on user's behalf.
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
    /// Currency
    /// </summary>
    [DataContract]
    public partial class Currency :  IEquatable<Currency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        /// <param name="currency">Currency name.</param>
        /// <param name="delisted">Whether currency is de-listed.</param>
        /// <param name="withdrawDisabled">Whether currency&#39;s withdrawal is disabled.</param>
        /// <param name="withdrawDelayed">Whether currency&#39;s withdrawal is delayed.</param>
        /// <param name="depositDisabled">Whether currency&#39;s deposit is disabled.</param>
        /// <param name="tradeDisabled">Whether currency&#39;s trading is disabled.</param>
        /// <param name="fixedRate">Fixed fee rate. Only for fixed rate currencies, not valid for normal currencies.</param>
        /// <param name="chain">Chain of currency.</param>
        public Currency(string currency = default(string), bool delisted = default(bool), bool withdrawDisabled = default(bool), bool withdrawDelayed = default(bool), bool depositDisabled = default(bool), bool tradeDisabled = default(bool), string fixedRate = default(string), string chain = default(string))
        {
            this._Currency = currency;
            this.Delisted = delisted;
            this.WithdrawDisabled = withdrawDisabled;
            this.WithdrawDelayed = withdrawDelayed;
            this.DepositDisabled = depositDisabled;
            this.TradeDisabled = tradeDisabled;
            this.FixedRate = fixedRate;
            this.Chain = chain;
        }

        /// <summary>
        /// Currency name
        /// </summary>
        /// <value>Currency name</value>
        [DataMember(Name="currency")]
        public string _Currency { get; set; }

        /// <summary>
        /// Whether currency is de-listed
        /// </summary>
        /// <value>Whether currency is de-listed</value>
        [DataMember(Name="delisted")]
        public bool Delisted { get; set; }

        /// <summary>
        /// Whether currency&#39;s withdrawal is disabled
        /// </summary>
        /// <value>Whether currency&#39;s withdrawal is disabled</value>
        [DataMember(Name="withdraw_disabled")]
        public bool WithdrawDisabled { get; set; }

        /// <summary>
        /// Whether currency&#39;s withdrawal is delayed
        /// </summary>
        /// <value>Whether currency&#39;s withdrawal is delayed</value>
        [DataMember(Name="withdraw_delayed")]
        public bool WithdrawDelayed { get; set; }

        /// <summary>
        /// Whether currency&#39;s deposit is disabled
        /// </summary>
        /// <value>Whether currency&#39;s deposit is disabled</value>
        [DataMember(Name="deposit_disabled")]
        public bool DepositDisabled { get; set; }

        /// <summary>
        /// Whether currency&#39;s trading is disabled
        /// </summary>
        /// <value>Whether currency&#39;s trading is disabled</value>
        [DataMember(Name="trade_disabled")]
        public bool TradeDisabled { get; set; }

        /// <summary>
        /// Fixed fee rate. Only for fixed rate currencies, not valid for normal currencies
        /// </summary>
        /// <value>Fixed fee rate. Only for fixed rate currencies, not valid for normal currencies</value>
        [DataMember(Name="fixed_rate")]
        public string FixedRate { get; set; }

        /// <summary>
        /// Chain of currency
        /// </summary>
        /// <value>Chain of currency</value>
        [DataMember(Name="chain")]
        public string Chain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Currency {\n");
            sb.Append("  _Currency: ").Append(_Currency).Append("\n");
            sb.Append("  Delisted: ").Append(Delisted).Append("\n");
            sb.Append("  WithdrawDisabled: ").Append(WithdrawDisabled).Append("\n");
            sb.Append("  WithdrawDelayed: ").Append(WithdrawDelayed).Append("\n");
            sb.Append("  DepositDisabled: ").Append(DepositDisabled).Append("\n");
            sb.Append("  TradeDisabled: ").Append(TradeDisabled).Append("\n");
            sb.Append("  FixedRate: ").Append(FixedRate).Append("\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
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
            return this.Equals(input as Currency);
        }

        /// <summary>
        /// Returns true if Currency instances are equal
        /// </summary>
        /// <param name="input">Instance of Currency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Currency input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Currency == input._Currency ||
                    (this._Currency != null &&
                    this._Currency.Equals(input._Currency))
                ) && 
                (
                    this.Delisted == input.Delisted ||
                    this.Delisted.Equals(input.Delisted)
                ) && 
                (
                    this.WithdrawDisabled == input.WithdrawDisabled ||
                    this.WithdrawDisabled.Equals(input.WithdrawDisabled)
                ) && 
                (
                    this.WithdrawDelayed == input.WithdrawDelayed ||
                    this.WithdrawDelayed.Equals(input.WithdrawDelayed)
                ) && 
                (
                    this.DepositDisabled == input.DepositDisabled ||
                    this.DepositDisabled.Equals(input.DepositDisabled)
                ) && 
                (
                    this.TradeDisabled == input.TradeDisabled ||
                    this.TradeDisabled.Equals(input.TradeDisabled)
                ) && 
                (
                    this.FixedRate == input.FixedRate ||
                    (this.FixedRate != null &&
                    this.FixedRate.Equals(input.FixedRate))
                ) && 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
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
                if (this._Currency != null)
                    hashCode = hashCode * 59 + this._Currency.GetHashCode();
                hashCode = hashCode * 59 + this.Delisted.GetHashCode();
                hashCode = hashCode * 59 + this.WithdrawDisabled.GetHashCode();
                hashCode = hashCode * 59 + this.WithdrawDelayed.GetHashCode();
                hashCode = hashCode * 59 + this.DepositDisabled.GetHashCode();
                hashCode = hashCode * 59 + this.TradeDisabled.GetHashCode();
                if (this.FixedRate != null)
                    hashCode = hashCode * 59 + this.FixedRate.GetHashCode();
                if (this.Chain != null)
                    hashCode = hashCode * 59 + this.Chain.GetHashCode();
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
