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
    /// MultiChainAddressItem
    /// </summary>
    [DataContract]
    public partial class MultiChainAddressItem :  IEquatable<MultiChainAddressItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiChainAddressItem" /> class.
        /// </summary>
        /// <param name="chain">Name of the chain.</param>
        /// <param name="address">Deposit address.</param>
        /// <param name="paymentId">Notes that some currencies required(e.g., Tag, Memo) when depositing.</param>
        /// <param name="paymentName">Note type, &#x60;Tag&#x60; or &#x60;Memo&#x60;.</param>
        /// <param name="obtainFailed">The obtain failed status- 0: address successfully obtained- 1: failed to obtain address.</param>
        public MultiChainAddressItem(string chain = default(string), string address = default(string), string paymentId = default(string), string paymentName = default(string), int obtainFailed = default(int))
        {
            this.Chain = chain;
            this.Address = address;
            this.PaymentId = paymentId;
            this.PaymentName = paymentName;
            this.ObtainFailed = obtainFailed;
        }

        /// <summary>
        /// Name of the chain
        /// </summary>
        /// <value>Name of the chain</value>
        [DataMember(Name="chain", EmitDefaultValue=false)]
        public string Chain { get; set; }

        /// <summary>
        /// Deposit address
        /// </summary>
        /// <value>Deposit address</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Notes that some currencies required(e.g., Tag, Memo) when depositing
        /// </summary>
        /// <value>Notes that some currencies required(e.g., Tag, Memo) when depositing</value>
        [DataMember(Name="payment_id", EmitDefaultValue=false)]
        public string PaymentId { get; set; }

        /// <summary>
        /// Note type, &#x60;Tag&#x60; or &#x60;Memo&#x60;
        /// </summary>
        /// <value>Note type, &#x60;Tag&#x60; or &#x60;Memo&#x60;</value>
        [DataMember(Name="payment_name", EmitDefaultValue=false)]
        public string PaymentName { get; set; }

        /// <summary>
        /// The obtain failed status- 0: address successfully obtained- 1: failed to obtain address
        /// </summary>
        /// <value>The obtain failed status- 0: address successfully obtained- 1: failed to obtain address</value>
        [DataMember(Name="obtain_failed", EmitDefaultValue=false)]
        public int ObtainFailed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiChainAddressItem {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  PaymentName: ").Append(PaymentName).Append("\n");
            sb.Append("  ObtainFailed: ").Append(ObtainFailed).Append("\n");
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
            return this.Equals(input as MultiChainAddressItem);
        }

        /// <summary>
        /// Returns true if MultiChainAddressItem instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiChainAddressItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiChainAddressItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
                ) && 
                (
                    this.PaymentName == input.PaymentName ||
                    (this.PaymentName != null &&
                    this.PaymentName.Equals(input.PaymentName))
                ) && 
                (
                    this.ObtainFailed == input.ObtainFailed ||
                    this.ObtainFailed.Equals(input.ObtainFailed)
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
                if (this.Chain != null)
                    hashCode = hashCode * 59 + this.Chain.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.PaymentId != null)
                    hashCode = hashCode * 59 + this.PaymentId.GetHashCode();
                if (this.PaymentName != null)
                    hashCode = hashCode * 59 + this.PaymentName.GetHashCode();
                hashCode = hashCode * 59 + this.ObtainFailed.GetHashCode();
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
