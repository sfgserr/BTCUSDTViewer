
namespace BinanceViewer.BTCUSDTServices
{
    interface IBTCUSDTService
    {
        Task<string> GetPriceFromBinance();
        Task<string> GetPriceFromKucoin();
    }
}
