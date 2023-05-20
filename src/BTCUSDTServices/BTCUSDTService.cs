using Binance.Net.Clients;
using Kucoin.Net.Clients;
using Bybit.Net.Clients;
using Mexc.Net.Clients.SpotApi;
using CryptoExchange.Net.Logging;

namespace BTUSDTViewer.BTCUSDTServices
{
    class BTCUSDTService : IBTCUSDTService
    {
        private readonly BinanceClient _binanceClient = new BinanceClient();
        private readonly KucoinClient _kucoinClient = new KucoinClient();
        private readonly BybitClient _bybitClient = new BybitClient();
        private readonly MexcClientSpotApi _mexcClient = new MexcClientSpotApi(new Log(nameof(_mexcClient)), new Mexc.Net.Objects.MexcClientOptions());

        public async Task<string> GetPriceFromBinance()
        {
            var price = await _binanceClient.SpotApi.ExchangeData.GetPriceAsync("BTCUSDT");
            return price.Data.Price.ToString();
        }

        public async Task<string> GetPriceFromKucoin()
        {
            var ticker = await _kucoinClient.SpotApi.ExchangeData.GetTickerAsync("BTC-USDT");
            return ticker.Data.LastPrice.ToString();
        }

        public async Task<string> GetPriceFromBybit()
        {
            var price = await _bybitClient.SpotApiV3.ExchangeData.GetPriceAsync("BTCUSDT");
            return price.Data.Price.ToString();
        }

        public async Task<string> GetPriceFromMexc()
        {
            var price = await _mexcClient.ExchangeData.GetPriceAsync("BTCUSDT");
            return price.Data.Price.ToString();
        }
    }
}
