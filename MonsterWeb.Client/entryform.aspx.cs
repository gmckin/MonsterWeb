using MonsterWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonsterWeb.Client
{
  public partial class entryform : System.Web.UI.Page
  {
    private DataService data = new DataService();
    protected void Page_Load(object sender, EventArgs e)
    {

      if (!IsPostBack)
      {
        LoadGenders();
      }
      
     /// Monster_submit.Click += new EventHandler(this.MonsterSubmit_Click);
    }

    private bool InsertValidated()
    {
      if (string.IsNullOrWhiteSpace(MonsterName_Text.Text) &&
        string.IsNullOrWhiteSpace(MonsterGender_List.SelectedItem.Text))
      {
        return false;
      }
      return data.InsertMonster(MonsterName_Text.Text, MonsterGender_List.SelectedItem.Text);
      
    }
    //private bool InsertGenderValidated()
    //{
    //  if (string.IsNullOrWhiteSpace(MonsterName_Text.Text))
    //  {
    //    return false;
    //  }
    //  return data.InsertGender(GenderName_Text.Text);

    //}

    //private bool InsertMTValidated()
    //{
    //  if (string.IsNullOrWhiteSpace(MonsterName_Text.Text))
    //  {
    //    return false;
    //  }
    //  return data.InsertMonsterType(MonsterTypeName_Text.Text);

    //}
    //private bool InsertTitleValidated()
    //{
    //  if (string.IsNullOrWhiteSpace(TitleName_Text.Text))
    //  {
    //    return false;
    //  }
    //  return data.InsertTitle(TitleName_Text.Text);

    //}
    protected void MonsterSubmit_Click(object sender, EventArgs e)
    {
      if (InsertValidated())
      {
        MonsterName_Text.Text = string.Empty;
        MonsterGender_List.SelectedIndex = 0;
      }
      //MonsterName_Text.Text = "found the server";
    }

    //protected void GenderSubmit_Click(object sender, EventArgs e)
    //{
    //  if (InsertGenderValidated())
    //  {
    //    GenderName_Text.Text = string.Empty;        
    //  }
    //  //MonsterName_Text.Text = "found the server";
    //}

    //protected void MonsterTypeSubmit_Click(object sender, EventArgs e)
    //{
    //  if (InsertMTValidated())
    //  {
    //    MonsterTypeName_Text.Text = string.Empty;
    //  }
    //  //MonsterName_Text.Text = "found the server";
    //}

    //protected void TitleSubmit_Click(object sender, EventArgs e)
    //{
    //  if (InsertTitleValidated())
    //  {
    //    TitleName_Text.Text = string.Empty;
    //  }
    //  //MonsterName_Text.Text = "found the server";
    //}
    private void LoadGenders()
    {
      MonsterGender_List.Items.Clear();
      foreach (var item in data.GetGender())
      {
        MonsterGender_List.Items.Add(new ListItem() { Text = item.Name, Value = item.Id.ToString() });
      }
    }
  }
}