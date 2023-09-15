using System.Collections.Generic;
using CryptoExchange.Net.Converters;
using Huobi.Net.Enums;

namespace Huobi.Net.Converters
{
    internal class DepositStatusConverter : BaseConverter<DepositStatus>
    {
        public DepositStatusConverter() : this(true) { }
        public DepositStatusConverter(bool useQuotes) : base(useQuotes) { }

        protected override List<KeyValuePair<DepositStatus, string>> Mapping => new List<KeyValuePair<DepositStatus, string>>
        {
            new KeyValuePair<DepositStatus, string>(DepositStatus.Allowed, "allowed"),
            new KeyValuePair<DepositStatus, string>(DepositStatus.Prohibited, "prohibited")
        };
    }
}
