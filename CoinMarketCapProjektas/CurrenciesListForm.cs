using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework.Currency.Provider;
using static Homework.Currency.Provider.Provider;
namespace CoinMarketCapProjektas
{
	public partial class CurrenciesListForm : Form
    {
        private CurrenciesListProvider repo = new CashingProvider(new Provider());
        private bool CryptocurrenciesIsFiltered = true;
        private bool FiatsIsFiltered = false;
        public CurrenciesListForm()
		{
			InitializeComponent();
            LoadCurrencies();
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshButton.Enabled = false;
            repo = new CashingProvider(new Provider());
            LoadCurrencies();
            for(int i=30; i>0; i--)
            {
                RefreshButton.Text = i.ToString()+"..";
                await Task.Delay(1000);
            }
            RefreshButton.Text = "Refresh data";
            RefreshButton.Enabled = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            String searchInput = SearchField.Text.ToLower();
            String currencyType = FormTitle.Text.ToLower();
            var result = repo.GetCurrenciesList(currencyType);

            if (currencyType.Equals("fiat"))
            {
                FiatsIsFiltered = true;
                FiatsListView.Items.Clear();
            }
            else //(currencyType.Equals("cryptocurrency"))
            {
                CryptocurrenciesIsFiltered = true;
                CryptoCurrenciesListView.Items.Clear();
            }

            if (searchInput != "")
            {
                foreach (var c in result.CurrenciesData)
                {
                    if (currencyType.Equals("fiat") && (c.Id.ToString().Contains(searchInput) || c.Name.ToLower().Contains(searchInput) || c.Symbol.ToLower().Contains(searchInput)))
                    {
                        var item = new ListViewItem(new[] { c.Id.ToString(), c.Name, c.Symbol });
                        item.Tag = c;
                        FiatsListView.Items.Add(item);
                    }
                    else if (c.Id.ToString().Contains(searchInput) || c.Rank.ToString().Contains(searchInput) || c.Name.ToLower().Contains(searchInput) || c.Symbol.ToLower().Contains(searchInput)) //(currencyType.Equals("cryptocurrency"))
                    {
                        var item = new ListViewItem(new[] { c.Id.ToString(), c.Rank.ToString(), c.Name, c.Symbol });
                        item.Tag = c;
                        CryptoCurrenciesListView.Items.Add(item);
                    }
                }
            }
        }

        private void LoadCurrencies()
        {
            String currencyType = FormTitle.Text.ToLower();
            var result = repo.GetCurrenciesList(currencyType);

            foreach (var c in result.CurrenciesData)
            {
                if (currencyType.Equals("fiat"))
                {
                    var item = new ListViewItem(new[] { c.Id.ToString(), c.Name, c.Symbol });
                    item.Tag = c;
                    FiatsListView.Items.Add(item);
                }
                else //(currencyType.Equals("cryptocurrency"))
                {
                    var item = new ListViewItem(new[] { c.Id.ToString(), c.Rank.ToString(), c.Name, c.Symbol });
                    item.Tag = c;
                    CryptoCurrenciesListView.Items.Add(item);
                }
            }

            if (currencyType.Equals("fiat"))
            {
                FiatsIsFiltered = false;
            }
            else //(currencyType.Equals("cryptocurrency"))
            {
                CryptocurrenciesIsFiltered = false;
            }
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            SearchField.Text = "";
            if (FormTitle.Text == "Cryptocurrencies")
            {
                CryptoCurrenciesListView.Visible = false;
                FormTitle.Text = "Fiat";
                SwitchButton.Text = "Switch list to cryptocurrencies";
                if(FiatsIsFiltered)
                {
                    LoadCurrencies();
                }
                FiatsListView.Visible = true;
            }
            else if (FormTitle.Text == "Fiat")
            {
                FiatsListView.Visible = false;
                FormTitle.Text = "Cryptocurrencies";
                SwitchButton.Text = "Switch list to fiat";
                if (CryptocurrenciesIsFiltered)
                {
                    LoadCurrencies();
                }
                CryptoCurrenciesListView.Visible = true;
            }

        }

        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String ItemName;
            String ItemSymbol;
            if (FormTitle.Text == "Fiat")
            {
                ItemName = FiatsListView.SelectedItems[0].SubItems[1].Text;
                ItemSymbol = FiatsListView.SelectedItems[0].SubItems[2].Text;
            }
            else //(label1.Text == "Cryptocurrencies")
            {
                ItemName = CryptoCurrenciesListView.SelectedItems[0].SubItems[2].Text;
                ItemSymbol = CryptoCurrenciesListView.SelectedItems[0].SubItems[3].Text;
            }
            new ExchangeForm(ItemName, ItemSymbol, repo).Show();
        }
    }
}