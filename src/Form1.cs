using BTCUSDTViewer;

namespace BTUSDTViewer;

public partial class Form1 : Form
{
    private readonly App _app;

    public Form1()
    {
        InitializeComponent();
        _app = new App(this);
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        await _app.StartAsync();
    }
}
