using MonsterApp.DataClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterWeb.Logic.MonsterServiceReference;
using MonsterApp.DataClient.Models;

namespace MonsterWeb.Logic
{
  public class DataService
  {

    private MonsterServiceClient msc = new MonsterServiceClient();


    public List<GenderDAO> GetGender()
    {
      return msc.GetGender().ToList();
    }

    public List<MonsterTypeDAO> GetMonsterType()
    {
      return msc.GetMonsterType().ToList();
    }

    public List<TitleDAO> GetTitles()
    {
      return msc.GetTitles().ToList();
    }



    public bool InsertMonster(string name, string gender)//, string type)
    {
      var gen = msc.GetGender().FirstOrDefault(g => g.Name == gender);
     // var ty = msc.GetMonsterType().FirstOrDefault(t => t.Name == type);
      var mon = new MonsterDAO{ Name = name, Gender = gen, Type = new MonsterTypeDAO() { Id = 1 } };

      return msc.InsertMonster(mon);
      //return false;
    }

    public bool InsertGender(string name)//, string type)
    {
      //var gen = msc.GetGender().FirstOrDefault(g => g.Name == name);
      // var ty = msc.GetMonsterType().FirstOrDefault(t => t.Name == type);
      var der = new GenderDAO { Name = name};

      return msc.InsertGender(der);
      //return false;
    }

    public bool InsertMonsterType(string name)//, string type)
    {
      //var gen = msc.GetGender().FirstOrDefault(g => g.Name == name);
      // var ty = msc.GetMonsterType().FirstOrDefault(t => t.Name == type);
      var mt = new MonsterTypeDAO { Name = name };

      return msc.InsertMonsterType(mt);
      //return false;
    }

    public bool InsertTitle(string name)//, string type)
    {
      //var gen = msc.GetGender().FirstOrDefault(g => g.Name == name);
      // var ty = msc.GetMonsterType().FirstOrDefault(t => t.Name == type);
      var t = new TitleDAO { Name = name };

      return msc.InsertTitle(t);
      //return false;
    }

  }
}
