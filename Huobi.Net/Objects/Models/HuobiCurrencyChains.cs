using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.Net.Objects.Models
{
    /// <summary>
    /// Account and balance info
    /// </summary>
    public class HuobiCurrencyChains : HuobiAccount
    {
        /// <summary>
        /// The list of balances
        /// </summary>
        [JsonProperty("chains")]
        public IEnumerable<HuobiCurrencyChain> Data { get; set; } = Array.Empty<HuobiBalance>();
    }
}