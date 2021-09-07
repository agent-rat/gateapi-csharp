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
    /// Margin loan details
    /// </summary>
    [DataContract]
    public partial class Loan :  IEquatable<Loan>, IValidatableObject
    {
        /// <summary>
        /// Loan status  open - not fully loaned loaned - all loaned out for lending loan; loaned in for borrowing side finished - loan is finished, either being all repaid or cancelled by the lender auto_repaid - automatically repaid by the system
        /// </summary>
        /// <value>Loan status  open - not fully loaned loaned - all loaned out for lending loan; loaned in for borrowing side finished - loan is finished, either being all repaid or cancelled by the lender auto_repaid - automatically repaid by the system</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,

            /// <summary>
            /// Enum Loaned for value: loaned
            /// </summary>
            [EnumMember(Value = "loaned")]
            Loaned = 2,

            /// <summary>
            /// Enum Finished for value: finished
            /// </summary>
            [EnumMember(Value = "finished")]
            Finished = 3,

            /// <summary>
            /// Enum Autorepaid for value: auto_repaid
            /// </summary>
            [EnumMember(Value = "auto_repaid")]
            Autorepaid = 4

        }

        /// <summary>
        /// Loan status  open - not fully loaned loaned - all loaned out for lending loan; loaned in for borrowing side finished - loan is finished, either being all repaid or cancelled by the lender auto_repaid - automatically repaid by the system
        /// </summary>
        /// <value>Loan status  open - not fully loaned loaned - all loaned out for lending loan; loaned in for borrowing side finished - loan is finished, either being all repaid or cancelled by the lender auto_repaid - automatically repaid by the system</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Loan side
        /// </summary>
        /// <value>Loan side</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SideEnum
        {
            /// <summary>
            /// Enum Lend for value: lend
            /// </summary>
            [EnumMember(Value = "lend")]
            Lend = 1,

            /// <summary>
            /// Enum Borrow for value: borrow
            /// </summary>
            [EnumMember(Value = "borrow")]
            Borrow = 2

        }

        /// <summary>
        /// Loan side
        /// </summary>
        /// <value>Loan side</value>
        [DataMember(Name="side", EmitDefaultValue=false)]
        public SideEnum Side { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Loan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Loan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Loan" /> class.
        /// </summary>
        /// <param name="side">Loan side (required).</param>
        /// <param name="currency">Loan currency (required).</param>
        /// <param name="rate">Loan rate. Only rates in [0.0002, 0.002] are supported.  Not required in lending. Market rate calculated from recent rates will be used if not set.</param>
        /// <param name="amount">Loan amount (required).</param>
        /// <param name="days">Loan days. Only 10 is supported for now.</param>
        /// <param name="autoRenew">Whether to auto renew the loan upon expiration (default to false).</param>
        /// <param name="currencyPair">Currency pair. Required if borrowing.</param>
        /// <param name="feeRate">Loan fee rate.</param>
        /// <param name="origId">Original loan ID of the loan if auto-renewed, otherwise equals to id.</param>
        /// <param name="text">User defined custom ID.</param>
        public Loan(SideEnum side = default(SideEnum), string currency = default(string), string rate = default(string), string amount = default(string), int days = default(int), bool autoRenew = false, string currencyPair = default(string), string feeRate = default(string), string origId = default(string), string text = default(string))
        {
            this.Side = side;
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency", "currency is a required property for Loan and cannot be null");
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount", "amount is a required property for Loan and cannot be null");
            this.Rate = rate;
            this.Days = days;
            this.AutoRenew = autoRenew;
            this.CurrencyPair = currencyPair;
            this.FeeRate = feeRate;
            this.OrigId = origId;
            this.Text = text;
        }

        /// <summary>
        /// Loan ID
        /// </summary>
        /// <value>Loan ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Creation time
        /// </summary>
        /// <value>Creation time</value>
        [DataMember(Name="create_time", EmitDefaultValue=false)]
        public string CreateTime { get; private set; }

        /// <summary>
        /// Repay time of the loan. No value will be returned for lending loan
        /// </summary>
        /// <value>Repay time of the loan. No value will be returned for lending loan</value>
        [DataMember(Name="expire_time", EmitDefaultValue=false)]
        public string ExpireTime { get; private set; }

        /// <summary>
        /// Loan currency
        /// </summary>
        /// <value>Loan currency</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Loan rate. Only rates in [0.0002, 0.002] are supported.  Not required in lending. Market rate calculated from recent rates will be used if not set
        /// </summary>
        /// <value>Loan rate. Only rates in [0.0002, 0.002] are supported.  Not required in lending. Market rate calculated from recent rates will be used if not set</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public string Rate { get; set; }

        /// <summary>
        /// Loan amount
        /// </summary>
        /// <value>Loan amount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Loan days. Only 10 is supported for now
        /// </summary>
        /// <value>Loan days. Only 10 is supported for now</value>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public int Days { get; set; }

        /// <summary>
        /// Whether to auto renew the loan upon expiration
        /// </summary>
        /// <value>Whether to auto renew the loan upon expiration</value>
        [DataMember(Name="auto_renew", EmitDefaultValue=false)]
        public bool AutoRenew { get; set; }

        /// <summary>
        /// Currency pair. Required if borrowing
        /// </summary>
        /// <value>Currency pair. Required if borrowing</value>
        [DataMember(Name="currency_pair", EmitDefaultValue=false)]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// Amount not lent out yet
        /// </summary>
        /// <value>Amount not lent out yet</value>
        [DataMember(Name="left", EmitDefaultValue=false)]
        public string Left { get; private set; }

        /// <summary>
        /// Repaid amount
        /// </summary>
        /// <value>Repaid amount</value>
        [DataMember(Name="repaid", EmitDefaultValue=false)]
        public string Repaid { get; private set; }

        /// <summary>
        /// Repaid interest
        /// </summary>
        /// <value>Repaid interest</value>
        [DataMember(Name="paid_interest", EmitDefaultValue=false)]
        public string PaidInterest { get; private set; }

        /// <summary>
        /// Outstanding interest yet to be paid
        /// </summary>
        /// <value>Outstanding interest yet to be paid</value>
        [DataMember(Name="unpaid_interest", EmitDefaultValue=false)]
        public string UnpaidInterest { get; private set; }

        /// <summary>
        /// Loan fee rate
        /// </summary>
        /// <value>Loan fee rate</value>
        [DataMember(Name="fee_rate", EmitDefaultValue=false)]
        public string FeeRate { get; set; }

        /// <summary>
        /// Original loan ID of the loan if auto-renewed, otherwise equals to id
        /// </summary>
        /// <value>Original loan ID of the loan if auto-renewed, otherwise equals to id</value>
        [DataMember(Name="orig_id", EmitDefaultValue=false)]
        public string OrigId { get; set; }

        /// <summary>
        /// User defined custom ID
        /// </summary>
        /// <value>User defined custom ID</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Loan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  ExpireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
            sb.Append("  CurrencyPair: ").Append(CurrencyPair).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Repaid: ").Append(Repaid).Append("\n");
            sb.Append("  PaidInterest: ").Append(PaidInterest).Append("\n");
            sb.Append("  UnpaidInterest: ").Append(UnpaidInterest).Append("\n");
            sb.Append("  FeeRate: ").Append(FeeRate).Append("\n");
            sb.Append("  OrigId: ").Append(OrigId).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as Loan);
        }

        /// <summary>
        /// Returns true if Loan instances are equal
        /// </summary>
        /// <param name="input">Instance of Loan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Loan input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.ExpireTime == input.ExpireTime ||
                    (this.ExpireTime != null &&
                    this.ExpireTime.Equals(input.ExpireTime))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Side == input.Side ||
                    this.Side.Equals(input.Side)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Days == input.Days ||
                    this.Days.Equals(input.Days)
                ) && 
                (
                    this.AutoRenew == input.AutoRenew ||
                    this.AutoRenew.Equals(input.AutoRenew)
                ) && 
                (
                    this.CurrencyPair == input.CurrencyPair ||
                    (this.CurrencyPair != null &&
                    this.CurrencyPair.Equals(input.CurrencyPair))
                ) && 
                (
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Repaid == input.Repaid ||
                    (this.Repaid != null &&
                    this.Repaid.Equals(input.Repaid))
                ) && 
                (
                    this.PaidInterest == input.PaidInterest ||
                    (this.PaidInterest != null &&
                    this.PaidInterest.Equals(input.PaidInterest))
                ) && 
                (
                    this.UnpaidInterest == input.UnpaidInterest ||
                    (this.UnpaidInterest != null &&
                    this.UnpaidInterest.Equals(input.UnpaidInterest))
                ) && 
                (
                    this.FeeRate == input.FeeRate ||
                    (this.FeeRate != null &&
                    this.FeeRate.Equals(input.FeeRate))
                ) && 
                (
                    this.OrigId == input.OrigId ||
                    (this.OrigId != null &&
                    this.OrigId.Equals(input.OrigId))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ExpireTime != null)
                    hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.Days.GetHashCode();
                hashCode = hashCode * 59 + this.AutoRenew.GetHashCode();
                if (this.CurrencyPair != null)
                    hashCode = hashCode * 59 + this.CurrencyPair.GetHashCode();
                if (this.Left != null)
                    hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Repaid != null)
                    hashCode = hashCode * 59 + this.Repaid.GetHashCode();
                if (this.PaidInterest != null)
                    hashCode = hashCode * 59 + this.PaidInterest.GetHashCode();
                if (this.UnpaidInterest != null)
                    hashCode = hashCode * 59 + this.UnpaidInterest.GetHashCode();
                if (this.FeeRate != null)
                    hashCode = hashCode * 59 + this.FeeRate.GetHashCode();
                if (this.OrigId != null)
                    hashCode = hashCode * 59 + this.OrigId.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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
