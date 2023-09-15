using Huobi.Net.Converters;
using Huobi.Net.Enums;
using Newtonsoft.Json;
using System;

namespace Huobi.Net.Objects.Models
{
    /// <summary>
    /// Balance data
    /// </summary>
    public class HuobiCurrencyChain
    {
        /// <summary>
        /// The chain name
        /// </summary>
        [JsonProperty("chain")]
        public string Chain { get; set; } = string.Empty;
        /// <summary>
        /// The Chain display name
        /// </summary>
        [JsonProperty("displayName")]
        public string ChainDisplayName { get; set; } = string.Empty;
        /// <summary>
        /// The Base Chain name
        /// </summary>        
        public string BaseChain { get; set; } = string.Empty;
        /// <summary>
        /// The Base Chain protocol name
        /// </summary>        
        public string BaseChainProtocol { get; set; } = string.Empty;
        /// <summary>
        /// Is dynamic fee type or not (only applicable to withdrawFeeType = fixed)
        /// </summary>        
        public bool IsDynamic { get; set; }
        /// <summary>
        /// Number of confirmations required for deposit success (trading & withdrawal allowed once reached)
        /// </summary>
        [JsonProperty("numOfConfirmations")]
        public int NumOfConfirmations { get; set; }
        /// <summary>
        /// Number of confirmations required for quick success (trading allowed but withdrawal disallowed once reached)
        /// </summary>
        [JsonProperty("numOfFastConfirmations")]
        public int NumOfFastConfirmations { get; set; }
        /// <summary>
        /// Minimal deposit amount in each request
        /// </summary>
        [JsonProperty("minDepositAmt")]
        public string MinDepositAmt { get; set; } = string.Empty;
        /// <summary>
        /// The Deposit Status (allowed,prohibited)
        /// </summary>
        [JsonConverter(typeof(DepositStatus))]
        [JsonProperty("depositStatus")]
        public DepositStatus StatusOfDeposit { get; set; }
        /// <summary>
        /// Minimal Withdraw amount in each request
        /// </summary>
        [JsonProperty("minWithdrawAmt")]
        public string MinWithdrawAmt { get; set; } = string.Empty;
        /// <summary>
        /// Maximum withdraw amount in a day (Singapore timezone)
        /// </summary>
        [JsonProperty("withdrawQuotaPerDay")]
        public string WithdrawQuotaPerDay { get; set; } = string.Empty;
        /// <summary>
        /// Maximum withdraw amount in a year
        /// </summary>
        [JsonProperty("withdrawQuotaPerYear")]
        public string WithdrawQuotaPerYear { get; set; } = string.Empty;
        /// <summary>
        /// Maximum withdraw amount in total
        /// </summary>
        [JsonProperty("withdrawQuotaTotal")]
        public string WithdrawQuotaTotal { get; set; } = string.Empty;
        /// <summary>
        /// Withdraw amount precision
        /// </summary>
        [JsonProperty("withdrawPrecision")]
        public int WithdrawPrecision { get; set; }
        /// <summary>
        /// The type of the balance
        /// </summary>
        [JsonConverter(typeof(BalanceTypeConverter))]
        public BalanceType Type { get; set; }
        /// <summary>
        /// The balance
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// Sequence number of the update
        /// </summary>
        [JsonProperty("seq-num")]
        public string SequenceNumber { get; set; } = string.Empty;
    }
}
