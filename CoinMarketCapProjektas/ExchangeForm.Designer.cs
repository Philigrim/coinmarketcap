
namespace CoinMarketCapProjektas
{
    partial class ExchangeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ResultField = new System.Windows.Forms.Label();
            this.CurrenciesComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PrimaryCurrencyLabel";
            // 
            // ResultField
            // 
            this.ResultField.AutoSize = true;
            this.ResultField.Location = new System.Drawing.Point(12, 71);
            this.ResultField.Name = "ResultField";
            this.ResultField.Size = new System.Drawing.Size(67, 15);
            this.ResultField.TabIndex = 4;
            this.ResultField.Text = "ResultLabel";
            this.ResultField.Visible = false;
            // 
            // CurrenciesComboBox
            // 
            this.CurrenciesComboBox.FormattingEnabled = true;
            this.CurrenciesComboBox.Location = new System.Drawing.Point(410, 12);
            this.CurrenciesComboBox.Name = "CurrenciesComboBox";
            this.CurrenciesComboBox.Size = new System.Drawing.Size(217, 23);
            this.CurrenciesComboBox.TabIndex = 7;
            this.CurrenciesComboBox.Visible = false;
            this.CurrenciesComboBox.SelectionChangeCommitted += new System.EventHandler(this.SecondaryCurrencySelected);
            // 
            // CurrencyTypeComboBox
            // 
            this.CurrencyTypeComboBox.FormattingEnabled = true;
            this.CurrencyTypeComboBox.Items.AddRange(new object[] {
            "Fiat",
            "Cryptocurrency"});
            this.CurrencyTypeComboBox.Location = new System.Drawing.Point(298, 12);
            this.CurrencyTypeComboBox.Name = "CurrencyTypeComboBox";
            this.CurrencyTypeComboBox.Size = new System.Drawing.Size(106, 23);
            this.CurrencyTypeComboBox.TabIndex = 8;
            this.CurrencyTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.CurrencyTypeSelected);
            // 
            // Amount
            // 
            this.Amount.DecimalPlaces = 8;
            this.Amount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            this.Amount.Location = new System.Drawing.Point(12, 13);
            this.Amount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(99, 23);
            this.Amount.TabIndex = 9;
            this.Amount.ThousandsSeparator = true;
            this.Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amount.ValueChanged += new System.EventHandler(this.AmountIsBeingSet);
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 132);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.CurrencyTypeComboBox);
            this.Controls.Add(this.CurrenciesComboBox);
            this.Controls.Add(this.ResultField);
            this.Controls.Add(this.label1);
            this.Name = "ExchangeForm";
            this.Text = "ExchangeForm";
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultField;
        private System.Windows.Forms.ComboBox CurrenciesComboBox;
        private System.Windows.Forms.ComboBox CurrencyTypeComboBox;
        private System.Windows.Forms.NumericUpDown Amount;
    }
}