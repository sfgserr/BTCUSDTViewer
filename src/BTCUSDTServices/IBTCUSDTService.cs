
namespace BTUSDTViewer.BTCUSDTServices
{
    interface IBTCUSDTService
    {
        Task<string> GetPriceFromBinance();

        Task<string> GetPriceFromKucoin();

        Task<string> GetPriceFromBybit();

        Task<string> GetPriceFromMexc();
    }
}
