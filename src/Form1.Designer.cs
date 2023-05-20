namespace BTUSDTViewer;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.binancePrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kucoinPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bybitPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mexcPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binance:";
            // 
            // binancePrice
            // 
            this.binancePrice.AutoSize = true;
            this.binancePrice.Location = new System.Drawing.Point(236, 137);
            this.binancePrice.Name = "binancePrice";
            this.binancePrice.Size = new System.Drawing.Size(0, 15);
            this.binancePrice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kucoin:";
            // 
            // kucoinPrice
            // 
            this.kucoinPrice.AutoSize = true;
            this.kucoinPrice.Location = new System.Drawing.Point(230, 176);
            this.kucoinPrice.Name = "kucoinPrice";
            this.kucoinPrice.Size = new System.Drawing.Size(0, 15);
            this.kucoinPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bybit:";
            // 
            // bybitPrice
            // 
            this.bybitPrice.AutoSize = true;
            this.bybitPrice.Location = new System.Drawing.Point(221, 214);
            this.bybitPrice.Name = "bybitPrice";
            this.bybitPrice.Size = new System.Drawing.Size(0, 15);
            this.bybitPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mexc:";
            // 
            // mexcPrice
            // 
            this.mexcPrice.AutoSize = true;
            this.mexcPrice.Location = new System.Drawing.Point(223, 253);
            this.mexcPrice.Name = "mexcPrice";
            this.mexcPrice.Size = new System.Drawing.Size(0, 15);
            this.mexcPrice.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mexcPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bybitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kucoinPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.binancePrice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label binancePrice;
    private Label label2;
    private Label kucoinPrice;
    private Label label3;
    private Label bybitPrice;
    private Label label4;
    private Label mexcPrice;

    public Label BinancePrice
    {
        get => binancePrice;
        private set => binancePrice = value;
    }

    public Label KucoinPrice
    {
        get => kucoinPrice;
        private set => kucoinPrice = value;
    }

    public Label BybitPrice
    {
        get => bybitPrice;
        private set => bybitPrice = value;
    }

    public Label MexcPrice
    {
        get => mexcPrice;
        private set => mexcPrice = value;
    }
}
