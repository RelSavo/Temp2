using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces
    using eRestaurantSystem.BLL;
#endregion

public partial class DemoPages_ClockPicker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LKB_MockLastBillingDateTime_Click(object sender, EventArgs e)
    {
        MessageUserControl.TryRun(SetMockLastBillingDateTime);
    }

    protected void SetMockLastBillingDateTime()
    {
        var controller = new eRestaurantController();
        var info = controller.GetLastBillDate();
        TB_SearchDate.Text = info.ToString("yyyy-MM-dd");
        TB_SearchTime.Text = info.ToString("HH:mm:ss");
    }
}