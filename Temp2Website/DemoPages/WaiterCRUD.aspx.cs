using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
#region Additional Namespaces
using eRestaurantSystem.BLL;
using eRestaurantSystem.Entities;
using EatIn.UI;
#endregion

public partial class DemoPages_WaiterCRUD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HiredDate.Text = DateTime.Today.ToShortDateString();
    }
    protected void HiredDateCalendarButton_Click(object sender, ImageClickEventArgs e)
    {
        HiredCalendar.Visible = true;
        HiredCalendar.SelectedDate = DateTime.Today;
    }
    protected void ReleaseDateCalendarButton_Click(object sender, ImageClickEventArgs e)
    {
        ReleaseCalendar.Visible = true;
        if (string.IsNullOrEmpty(ReleaseDate.Text))
        {
            ReleaseCalendar.SelectedDate = DateTime.Today;
        }
        else
        {
            ReleaseCalendar.SelectedDate = DateTime.Parse(ReleaseDate.Text);
        }
    }
    protected void HiredCalendar_SelectionChanged(object sender, EventArgs e)
    {
        HiredDate.Text = HiredCalendar.SelectedDate.ToShortDateString();
        HiredCalendar.Visible = false;
    }
    protected void ReleaseCalendar_SelectionChanged(object sender, EventArgs e)
    {
        ReleaseDate.Text = ReleaseCalendar.SelectedDate.ToShortDateString();
        ReleaseCalendar.Visible = false;
    }

    //INSERT CLICK
    protected void InsertWaiter_Click(object sender, EventArgs e)
    {
        MessageUserControl.TryRun((ProcessRequest)InsertWaiterInfo);
    }
    
    //INSERT
    public void InsertWaiterInfo()
    {
        //The code that exists within this method is a standard CRUD insert.
        //Similar to what was learned in APPDEV 1
        eRestaurantController controller = new eRestaurantController();

        //Load an instance of Waiter.
        Waiter insertWaiter = new Waiter();
        insertWaiter.WaiterID = 0;

        insertWaiter.FirstName = FirstName.Text;
        insertWaiter.LastName = LastName.Text;
        insertWaiter.Phone = Phone.Text;
        insertWaiter.Address = Address.Text;
        insertWaiter.HireDate = DateTime.Parse(HiredDate.Text);

        //Check if the release date is Null/Empty
        if (string.IsNullOrEmpty(ReleaseDate.Text))
        {
            insertWaiter.ReleaseDate = null;                                                        //This can be null becuase in the database it is set to "Nullable"
        }
        else
        {
            insertWaiter.ReleaseDate = DateTime.Parse(ReleaseDate.Text);
        }

        //Add waiter to the database.
        controller.Waiter_Add(insertWaiter);
        
        //Rebind the dropdown (WaiterList) so the new entry will appear in the list.
        WaiterList.DataBind();

        

    }

    //UPDATE CLICK
    protected void UpdateWaiter_Click(object sender, EventArgs e)
    {
        MessageUserControl.TryRun((ProcessRequest)UpdateWaiterInfo);       
    }

    //UPDATE
    public void UpdateWaiterInfo()
    {
        //The code that exists within this method is a standard CRUD update.
        //Similar to what was learned in APPDEV 1
        eRestaurantController controller = new eRestaurantController();

        //Load an instance of Waiter.
        Waiter updateWaiter = new Waiter();
        updateWaiter.WaiterID = int.Parse(WaiterList.SelectedValue);

        updateWaiter.FirstName = FirstName.Text;
        updateWaiter.LastName = LastName.Text;
        updateWaiter.Phone = Phone.Text;
        updateWaiter.Address = Address.Text;
        updateWaiter.HireDate = DateTime.Parse(HiredDate.Text);

        //Check if the release date is Null/Empty
        if (string.IsNullOrEmpty(ReleaseDate.Text))
        {
            updateWaiter.ReleaseDate = null;                                                        //This can be null becuase in the database it is set to "Nullable"
        }
        else
        {
            updateWaiter.ReleaseDate = DateTime.Parse(ReleaseDate.Text);
        }

        //Add waiter to the database.
        controller.Waiter_Update(updateWaiter);

        //Rebind the dropdown (WaiterList) so the new entry will appear in the list.
        WaiterList.DataBind();
    }

    //Fetch Waiter
    protected void FetchWaiter_Click(object sender, EventArgs e)
    {
        if (WaiterList.SelectedIndex == 0)
            MessageUserControl.ShowInfo("Please select a waiter before clicking Show Waiter.");
        else
            MessageUserControl.TryRun((ProcessRequest)GetWaiterInfo);
    }

    public void GetWaiterInfo()
    {
        eRestaurantController controller = new eRestaurantController();
        var waiter = controller.GetWaiter(int.Parse(WaiterList.SelectedValue));
      
        WaiterID.Text = waiter.WaiterID.ToString();
        FirstName.Text = waiter.FirstName;
        LastName.Text = waiter.LastName;
        Phone.Text = waiter.Phone;
        Address.Text = waiter.Address;
        HiredDate.Text = waiter.HireDate.ToShortDateString();
        
        
        if (waiter.ReleaseDate.HasValue)
        {
            ReleaseDate.Text = waiter.ReleaseDate.Value.ToShortDateString();
        }
    }
}
