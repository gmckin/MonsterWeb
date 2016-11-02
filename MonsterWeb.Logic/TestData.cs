using MonsterApp.DataClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic
{
  public class TestData
  {
    public MonsterService data = new MonsterService();

    public void GetGenders()
    {
      data.GetGender();
    }

    public void GetMonsterTypes()
    {
      data.GetMonsterType();
    }

    public void GetTitles()
    {
      data.GetTitles();
    }
  }  
}
