using Homework.Currency.ExchangeInfoProvider;
using Homework.Currency.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CoinMarketCapProjektas
{
    public partial class ExchangeForm : Form
    {
        private CurrenciesListProvider rep;
        private string PrimaryCurrency;
        private string PrimaryCurrencySymbol;
        private string SecondaryCurrency;
        private string SecondaryCurrencySymbol;
        private bool SecondaryCurrencyIsSet;

        public ExchangeForm(string SelectedCurrency, string SelectedCurrencySymbol, CurrenciesListProvider repo)
        {
            InitializeComponent();
            PrimaryCurrency = SelectedCurrency;
            PrimaryCurrencySymbol = SelectedCurrencySymbol;
            this.Text = PrimaryCurrency;
            label1.Text = PrimaryCurrency + "(" + PrimaryCurrencySymbol + ") to";
            rep = repo;
        }

        private void CurrencyTypeSelected(object sender, EventArgs e)
        {
            CurrenciesComboBox.Items.Clear();
            CurrenciesComboBox.ResetText();
            var result = rep.GetCurrenciesList(CurrencyTypeComboBox.SelectedItem.ToString().ToLower());
            CurrenciesComboBox.Visible = true;
            foreach (var c in result.CurrenciesData)
            {
                String item = c.Name + "(" + c.Symbol + ")";
                CurrenciesComboBox.Items.Add(item);
            }
            SecondaryCurrencyIsSet = false;
            CheckIfResultsCanBeShown();
        }

        private void SecondaryCurrencySelected(object sender, EventArgs e)
        {
            SecondaryCurrencyIsSet = true;
            CheckIfResultsCanBeShown();
        }

        private void AmountIsBeingSet(object sender, EventArgs e)
        {
            CheckIfResultsCanBeShown();
        }
        private void CheckIfResultsCanBeShown()
        {
            if (SecondaryCurrencyIsSet)
            {
                var repoz = new ExchangeInfoProvider();
                string CurrencySelection = CurrenciesComboBox.SelectedItem.ToString();
                SecondaryCurrency = CurrencySelection.Substring(0, CurrencySelection.IndexOf('('));
                SecondaryCurrencySymbol = CurrencySelection.Substring(CurrencySelection.IndexOf('(') + 1, CurrencySelection.Length - CurrencySelection.IndexOf('(') - 2);
                String test = repoz.GetSecondaryAmount(Amount.Value.ToString(), PrimaryCurrencySymbol, SecondaryCurrencySymbol);
                ResultField.Text = Amount.Text + " " + PrimaryCurrency + "(" + PrimaryCurrencySymbol + ") = " + test + " " + SecondaryCurrency + "(" + SecondaryCurrencySymbol + ")";
                ResultField.Visible = true;
            }
            else
            {
                ResultField.Visible = false;
            }
        }
    }
}
