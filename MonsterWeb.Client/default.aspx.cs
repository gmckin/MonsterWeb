using MonsterWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MonsterApp.DataClient;

namespace MonsterWeb.Client
{
  public partial class _default : System.Web.UI.Page
  {
        
    protected void Page_Load(object sender, EventArgs e)
    {
      GetGenders();
      GetMonsterTypes();
      GetTitles();

    }
    private void GetGenders()
    {
      var data = new DataService();
      genderlist.Items.Clear();

      foreach (var item in data.GetGender())
      {
        genderlist.Items.Add(item.Name);
      }
      
    }

    private void GetMonsterTypes()
    {
      var data = new DataService();
      monstertypelist.Items.Clear();

      foreach (var item in data.GetMonsterType())
      {
        monstertypelist.Items.Add(item.Name);
      }
    }
      private void GetTitles()
    {
      var data = new DataService();
      titlelist.Items.Clear();

      foreach (var item in data.GetTitles())
      {
        titlelist.Items.Add(item.Name);
      }
    }

    //private void GetMonsters()
    //{
    //  var data = new DataService();
    //  genderlist.Items.Clear();

    //  foreach (var item in data.GetMonsters())
    //  {
    //    genderlist.Items.Add(item.Name);
    //  }

    //}
  }
}