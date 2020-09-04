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
    /// FuturesInitialOrder
    /// </summary>
    [DataContract]
    public partial class FuturesInitialOrder :  IEquatable<FuturesInitialOrder>, IValidatableObject
    {
        /// <summary>
        /// Time in force. If using market price, only &#x60;ioc&#x60; is supported.  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled
        /// </summary>
        /// <value>Time in force. If using market price, only &#x60;ioc&#x60; is supported.  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TifEnum
        {
            /// <summary>
            /// Enum Gtc for value: gtc
            /// </summary>
            [EnumMember(Value = "gtc")]
            Gtc = 1,

            /// <summary>
            /// Enum Ioc for value: ioc
            /// </summary>
            [EnumMember(Value = "ioc")]
            Ioc = 2

        }

        /// <summary>
        /// Time in force. If using market price, only &#x60;ioc&#x60; is supported.  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled
        /// </summary>
        /// <value>Time in force. If using market price, only &#x60;ioc&#x60; is supported.  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled</value>
        [DataMember(Name="tif", EmitDefaultValue=false)]
        public TifEnum? Tif { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesInitialOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FuturesInitialOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FuturesInitialOrder" /> class.
        /// </summary>
        /// <param name="contract">Futures contract (required).</param>
        /// <param name="size">Order size. Positive size means to buy, while negative one means to sell. Set to 0 to close the position.</param>
        /// <param name="price">Order price. Set to 0 to use market price (required).</param>
        /// <param name="close">Set to true if trying to close the position (default to false).</param>
        /// <param name="tif">Time in force. If using market price, only &#x60;ioc&#x60; is supported.  - gtc: GoodTillCancelled - ioc: ImmediateOrCancelled (default to TifEnum.Gtc).</param>
        /// <param name="text">How the order is created. Possible values are: web, api and app.</param>
        /// <param name="reduceOnly">Set to true to create an reduce-only order (default to false).</param>
        public FuturesInitialOrder(string contract = default(string), long size = default(long), string price = default(string), bool close = false, TifEnum? tif = TifEnum.Gtc, string text = default(string), bool reduceOnly = false)
        {
            // to ensure "contract" is required (not null)
            this.Contract = contract ?? throw new ArgumentNullException("contract", "contract is a required property for FuturesInitialOrder and cannot be null");
            // to ensure "price" is required (not null)
            this.Price = price ?? throw new ArgumentNullException("price", "price is a required property for FuturesInitialOrder and cannot be null");
            this.Size = size;
            this.Close = close;
            this.Tif = tif;
            this.Text = text;
            this.ReduceOnly = reduceOnly;
        }

        /// <summary>
        /// Futures contract
        /// </summary>
        /// <value>Futures contract</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public string Contract { get; set; }

        /// <summary>
        /// Order size. Positive size means to buy, while negative one means to sell. Set to 0 to close the position
        /// </summary>
        /// <value>Order size. Positive size means to buy, while negative one means to sell. Set to 0 to close the position</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long Size { get; set; }

        /// <summary>
        /// Order price. Set to 0 to use market price
        /// </summary>
        /// <value>Order price. Set to 0 to use market price</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }

        /// <summary>
        /// Set to true if trying to close the position
        /// </summary>
        /// <value>Set to true if trying to close the position</value>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public bool Close { get; set; }

        /// <summary>
        /// How the order is created. Possible values are: web, api and app
        /// </summary>
        /// <value>How the order is created. Possible values are: web, api and app</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Set to true to create an reduce-only order
        /// </summary>
        /// <value>Set to true to create an reduce-only order</value>
        [DataMember(Name="reduce_only", EmitDefaultValue=false)]
        public bool ReduceOnly { get; set; }

        /// <summary>
        /// Is the order reduce-only
        /// </summary>
        /// <value>Is the order reduce-only</value>
        [DataMember(Name="is_reduce_only", EmitDefaultValue=false)]
        public bool IsReduceOnly { get; private set; }

        /// <summary>
        /// Is the order to close position
        /// </summary>
        /// <value>Is the order to close position</value>
        [DataMember(Name="is_close", EmitDefaultValue=false)]
        public bool IsClose { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuturesInitialOrder {\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  Tif: ").Append(Tif).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  ReduceOnly: ").Append(ReduceOnly).Append("\n");
            sb.Append("  IsReduceOnly: ").Append(IsReduceOnly).Append("\n");
            sb.Append("  IsClose: ").Append(IsClose).Append("\n");
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
            return this.Equals(input as FuturesInitialOrder);
        }

        /// <summary>
        /// Returns true if FuturesInitialOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of FuturesInitialOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FuturesInitialOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Close == input.Close ||
                    this.Close.Equals(input.Close)
                ) && 
                (
                    this.Tif == input.Tif ||
                    this.Tif.Equals(input.Tif)
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.ReduceOnly == input.ReduceOnly ||
                    this.ReduceOnly.Equals(input.ReduceOnly)
                ) && 
                (
                    this.IsReduceOnly == input.IsReduceOnly ||
                    this.IsReduceOnly.Equals(input.IsReduceOnly)
                ) && 
                (
                    this.IsClose == input.IsClose ||
                    this.IsClose.Equals(input.IsClose)
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
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.Close.GetHashCode();
                hashCode = hashCode * 59 + this.Tif.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                hashCode = hashCode * 59 + this.ReduceOnly.GetHashCode();
                hashCode = hashCode * 59 + this.IsReduceOnly.GetHashCode();
                hashCode = hashCode * 59 + this.IsClose.GetHashCode();
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