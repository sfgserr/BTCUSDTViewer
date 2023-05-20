using BinanceViewer.BTCUSDTServices;

namespace BinanceViewer;

public partial class Form1 : Form
{
    private readonly IBTCUSDTService _btcusdtService = new BTCUSDTService();

    public Form1()
    {
        InitializeComponent();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        binancePrice.Text = await _btcusdtService.GetPriceFromBinance();
        kucoinPrice.Text = await _btcusdtService.GetPriceFromKucoin();
        bybitPrice.Text = await _btcusdtService.GetPriceFromBybit();
        mexcPrice.Text = await _btcusdtService.GetPriceFromMexc();
    }
}
