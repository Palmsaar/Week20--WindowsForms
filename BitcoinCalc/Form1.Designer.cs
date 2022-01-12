
namespace BitcoinCalc
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencybox = new System.Windows.Forms.ComboBox();
            this.GetRatesBtc = new System.Windows.Forms.Button();
            this.amountOfBtc = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencybox
            // 
            this.currencybox.FormattingEnabled = true;
            this.currencybox.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencybox.Location = new System.Drawing.Point(24, 45);
            this.currencybox.Name = "currencybox";
            this.currencybox.Size = new System.Drawing.Size(182, 33);
            this.currencybox.TabIndex = 0;
            this.currencybox.Tag = "";
            this.currencybox.Text = "Select currency";
            // 
            // GetRatesBtc
            // 
            this.GetRatesBtc.Location = new System.Drawing.Point(249, 108);
            this.GetRatesBtc.Name = "GetRatesBtc";
            this.GetRatesBtc.Size = new System.Drawing.Size(112, 34);
            this.GetRatesBtc.TabIndex = 1;
            this.GetRatesBtc.Text = "Get Rates";
            this.GetRatesBtc.UseVisualStyleBackColor = true;
            this.GetRatesBtc.Click += new System.EventHandler(this.GetRatesBtc_Click);
            // 
            // amountOfBtc
            // 
            this.amountOfBtc.Location = new System.Drawing.Point(24, 111);
            this.amountOfBtc.Name = "amountOfBtc";
            this.amountOfBtc.PlaceholderText = "Amount of Bitcoin";
            this.amountOfBtc.Size = new System.Drawing.Size(182, 31);
            this.amountOfBtc.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(24, 259);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(182, 31);
            this.result.TabIndex = 3;
            this.result.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(24, 214);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(59, 25);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            this.resultLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 500);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amountOfBtc);
            this.Controls.Add(this.GetRatesBtc);
            this.Controls.Add(this.currencybox);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencybox;
        private System.Windows.Forms.Button GetRatesBtc;
        private System.Windows.Forms.TextBox amountOfBtc;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultLabel;
    }
}

