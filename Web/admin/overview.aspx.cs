#region dashCommerce License
/*
The MIT License

Copyright (c) 2008 - 2010 Mettle Systems LLC, P.O. Box 181192 Cleveland Heights, Ohio 44118, United States

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
#endregion
using System;
using System.Web.UI;

using MettleSystems.dashCommerce.Localization;
using SubSonic.Utilities;

namespace MettleSystems.dashCommerce.Web.admin {
  public partial class overview : MettleSystems.dashCommerce.Store.Web.AdminPage {

    #region Member Variables

    private string view;
    private string title;
    #endregion

    #region Page Events

    protected void Page_Load(object sender, EventArgs e) {
      view = Utility.GetParameter("view");
      title = LocalizationUtility.GetText("titleOverview");
      switch(view) {
        case "si": //Site Settings
          siteSettingsOverview.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlSiteOverview"));
          break;
        case "sec": //Security
          security.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlSecurity"));
          break;
        case "s": //Sales
          sales.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlSales"));
          break;
        case "pm": //Product Management
          productmanagement.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlProductManagement"));
          break;
        case "pco": //Product Coupons
          productcoupons.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlProductCoupons"));
          break;
        case "c": //Configuration
          configuration.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlConfigurationOverview"));
          break;
        case "mc": //Mail Configuration
          mailConfiguration.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlMailConfiguration"));          
          break;
        case "pc": //Payment Configuration
          providers.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlPaymentConfiguration"));          
          break;
        case "tc": //Tax Configuration
          providers.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlTaxConfiguration"));          
          break;
        case "sc": //Shipping Configuration
          providers.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlShippingConfiguration"));          
          break;
        case "cs"://customer service
          customerService.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlCustomerServiceConfiguration"));
          break;
        case "help":
          help.Visible = true;
          Page.Title = string.Format(title, LocalizationUtility.GetText("pnlHelp"));
          break;
        default:
          lblNotDone.Visible = true;
          break;
      }
    }

    #endregion

  }
}