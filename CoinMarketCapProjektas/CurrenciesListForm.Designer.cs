
namespace CoinMarketCapProjektas
{
	partial class CurrenciesListForm
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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CryptoCurrenciesListView = new System.Windows.Forms.ListView();
            this.ColRank = new System.Windows.Forms.ColumnHeader();
            this.ColId = new System.Windows.Forms.ColumnHeader();
            this.ColName = new System.Windows.Forms.ColumnHeader();
            this.ColSymbol = new System.Windows.Forms.ColumnHeader();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FormTitle = new System.Windows.Forms.Label();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.FiatsListView = new System.Windows.Forms.ListView();
            this.ColFiatId = new System.Windows.Forms.ColumnHeader();
            this.ColFiatName = new System.Windows.Forms.ColumnHeader();
            this.ColFiatSymbol = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.RefreshButton.Location = new System.Drawing.Point(13, 391);
            this.RefreshButton.Name = "button1";
            this.RefreshButton.Size = new System.Drawing.Size(143, 47);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Refresh data";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // listView1
            // 
            this.CryptoCurrenciesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColRank,
            this.ColId,
            this.ColName,
            this.ColSymbol});
            this.CryptoCurrenciesListView.FullRowSelect = true;
            this.CryptoCurrenciesListView.HideSelection = false;
            this.CryptoCurrenciesListView.Location = new System.Drawing.Point(13, 68);
            this.CryptoCurrenciesListView.MultiSelect = false;
            this.CryptoCurrenciesListView.Name = "listView1";
            this.CryptoCurrenciesListView.Size = new System.Drawing.Size(300, 317);
            this.CryptoCurrenciesListView.TabIndex = 1;
            this.CryptoCurrenciesListView.UseCompatibleStateImageBehavior = false;
            this.CryptoCurrenciesListView.View = System.Windows.Forms.View.Details;
            this.CryptoCurrenciesListView.Visible = false;
            this.CryptoCurrenciesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
            // 
            // ColRank
            // 
            this.ColRank.Text = "Rank";
            this.ColRank.Width = 40;
            // 
            // ColId
            // 
            this.ColId.Text = "Id";
            this.ColId.Width = 40;
            // 
            // ColName
            // 
            this.ColName.Text = "Name";
            this.ColName.Width = 120;
            // 
            // ColSymbol
            // 
            this.ColSymbol.Text = "Symbol";
            // 
            // textBox1
            // 
            this.SearchField.Location = new System.Drawing.Point(13, 39);
            this.SearchField.Name = "textBox1";
            this.SearchField.Size = new System.Drawing.Size(218, 23);
            this.SearchField.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormTitle.Location = new System.Drawing.Point(13, 6);
            this.FormTitle.Name = "label1";
            this.FormTitle.Size = new System.Drawing.Size(49, 30);
            this.FormTitle.TabIndex = 4;
            this.FormTitle.Text = "Fiat";
            // 
            // button3
            // 
            this.SwitchButton.Location = new System.Drawing.Point(169, 391);
            this.SwitchButton.Name = "button3";
            this.SwitchButton.Size = new System.Drawing.Size(143, 47);
            this.SwitchButton.TabIndex = 5;
            this.SwitchButton.Text = "Switch list to cryptocurrencies";
            this.SwitchButton.UseVisualStyleBackColor = true;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // listView2
            // 
            this.FiatsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColFiatId,
            this.ColFiatName,
            this.ColFiatSymbol});
            this.FiatsListView.FullRowSelect = true;
            this.FiatsListView.HideSelection = false;
            this.FiatsListView.Location = new System.Drawing.Point(12, 67);
            this.FiatsListView.MultiSelect = false;
            this.FiatsListView.Name = "listView2";
            this.FiatsListView.Size = new System.Drawing.Size(300, 317);
            this.FiatsListView.TabIndex = 6;
            this.FiatsListView.UseCompatibleStateImageBehavior = false;
            this.FiatsListView.View = System.Windows.Forms.View.Details;
            this.FiatsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
            // 
            // ColFiatId
            // 
            this.ColFiatId.Text = "Id";
            this.ColFiatId.Width = 40;
            // 
            // ColFiatName
            // 
            this.ColFiatName.Text = "Name";
            this.ColFiatName.Width = 120;
            // 
            // ColFiatSymbol
            // 
            this.ColFiatSymbol.Text = "Symbol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.SwitchButton);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchField);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.FiatsListView);
            this.Controls.Add(this.CryptoCurrenciesListView);
            this.Name = "Form1";
            this.Text = "Coin Market Cap";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ListView CryptoCurrenciesListView;
        private System.Windows.Forms.ColumnHeader ColId;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader ColSymbol;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.ColumnHeader ColRank;
        private System.Windows.Forms.ListView FiatsListView;
        private System.Windows.Forms.ColumnHeader ColFiatId;
        private System.Windows.Forms.ColumnHeader ColFiatName;
        private System.Windows.Forms.ColumnHeader ColFiatSymbol;
    }
}

