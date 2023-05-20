using Binance.Net.Clients;
using Kucoin.Net.Clients;
using Bybit.Net.Clients;

namespace BinanceViewer.BTCUSDTServices
{
    class BTCUSDTService : IBTCUSDTService
    {
        private readonly BinanceClient _binanceClient = new BinanceClient();
        private readonly KucoinClient _kucoinClient = new KucoinClient();
        private readonly BybitClient _bybitClient = new BybitClient();

        public async Task<string> GetPriceFromBinance()
        {
            var price = await _binanceClient.SpotApi.ExchangeData.GetPriceAsync("BTCUSDT");
            return price.Data.Price.ToString();
        }

        public async Task<string> GetPriceFromKucoin()
        {
            var ticker = await _kucoinClient.SpotApi.ExchangeData.GetTickerAsync("BTC-USDT");
            return ticker.Data.BestAskPrice.ToString();
        }

        public async Task<string> GetPriceFromBybit()
        {
            var price = await _bybitClient.SpotApiV3.ExchangeData.GetPriceAsync("BTCUSDT");
            return price.Data.Price.ToString();
        }
    }
}
