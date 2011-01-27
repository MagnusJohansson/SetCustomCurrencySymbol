using System;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;
using SetCustomCurrencySymbol.Properties;

namespace SetCustomCurrencySymbol
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void Form1Load(object sender, EventArgs e)
    {
      // Populate the combo box with known Cultures
      cboCultures.DataSource = CultureInfo.GetCultures(CultureTypes.SpecificCultures).ToList().OrderBy(name => name.DisplayName).ToList();
      cboCultures.DisplayMember = "DisplayName";
      cboCultures.ValueMember = "Name";
    }

    private void CboCulturesSelectedIndexChanged(object sender, EventArgs e)
    {
      var ci = cboCultures.SelectedItem as CultureInfo;
      if (ci == null) return;
      var cultureAndRegionInfoBuilder = new CultureAndRegionInfoBuilder(ci.Name, CultureAndRegionModifiers.Replacement);
      txtISOCurrencySymbol.Text = cultureAndRegionInfoBuilder.ISOCurrencySymbol;
      txtSymbol.Text = ci.NumberFormat.CurrencySymbol;
    }

    private void BtnRegisterClick(object sender, EventArgs e)
    {
      try
      {
        var cultureInfo = cboCultures.SelectedItem as CultureInfo;
        if (cultureInfo != null)
        {
          var cultureAndRegionInfoBbuilder = new CultureAndRegionInfoBuilder(cultureInfo.Name, CultureAndRegionModifiers.Replacement);

          // load the culture info into the builder
          cultureAndRegionInfoBbuilder.LoadDataFromCultureInfo(cultureInfo);
          
          // load the regional info into the builder
          var regionInfo = new RegionInfo(cultureInfo.Name);
          cultureAndRegionInfoBbuilder.LoadDataFromRegionInfo(regionInfo);

          // set the currency symbols
          cultureAndRegionInfoBbuilder.ISOCurrencySymbol = txtISOCurrencySymbol.Text;
          cultureAndRegionInfoBbuilder.NumberFormat.CurrencySymbol = txtSymbol.Text;
          cultureAndRegionInfoBbuilder.Register();

          MessageBox.Show(Resources.FormMain_BtnRegisterClick_Symbols_registered, Resources.FormMain_BtnRegisterClick_Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(Resources.FormMain_BtnRegisterClick_Error__ + ex.Message);
      }
    }

    private void BtnUnregisterClick(object sender, EventArgs e)
    {
      try
      {
        var cultureInfo = cboCultures.SelectedItem as CultureInfo;
        if (cultureInfo != null)
        {
          CultureAndRegionInfoBuilder.Unregister(cultureInfo.Name);
          MessageBox.Show(Resources.FormMain_BtnUnregisterClick_Symbols_unregistered, Resources.FormMain_BtnRegisterClick_Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(Resources.FormMain_BtnRegisterClick_Error__ + ex.Message);
      }
    }
  }
}
