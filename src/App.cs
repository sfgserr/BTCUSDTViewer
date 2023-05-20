using BTUSDTViewer;
using BTUSDTViewer.BTCUSDTServices;

namespace BTCUSDTViewer
{
    class App
    {
        private readonly IBTCUSDTService _btcusdtService;
        private readonly Form1 _form1;

        public App(Form1 form1)
        {
            _form1 = form1;
            _btcusdtService = new BTCUSDTService();
        }

        public async Task StartAsync()
        {
            while (true)
            {
                _form1.BinancePrice.Text = await _btcusdtService.GetPriceFromBinance();
                _form1.KucoinPrice.Text = await _btcusdtService.GetPriceFromKucoin();
                _form1.BybitPrice.Text = await _btcusdtService.GetPriceFromBybit();
                _form1.MexcPrice.Text = await _btcusdtService.GetPriceFromMexc();
                Thread.Sleep(5000);
            }
        }
    }
}
