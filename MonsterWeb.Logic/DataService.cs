using MonsterApp.DataClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterWeb.Logic.MonsterServiceReference;
using MonsterApp.DataClient.Models;
using MonsterWeb.Logic.Models;


namespace MonsterWeb.Logic
{
  public class DataService
  {

    private MonsterServiceClient msc = new MonsterServiceClient();
    private FactoryThing<GenderDTO> genderFactory = new FactoryThing<GenderDTO>();
    private FactoryThing<TypeDTO> typeFactory = new FactoryThing<TypeDTO>();
    private FactoryThing<TitleDTO> titleFactory = new FactoryThing<TitleDTO>();


    public List<GenderDTO> GetGender()
    {
      var genders = new List<GenderDTO>();
      foreach (var item in msc.GetGender())
      {
        var g = genderFactory.Create();
        g.AppId = item.Id;
        g.Name = item.Name;
        genders.Add(g);
      }
      return genders;
    }

    public List<TypeDTO> GetMonsterType()
    {
      var monstertype = new List<TypeDTO>();
      foreach(var item in msc.GetMonsterType())
      {
        var t = typeFactory.Create();
      }
      return monstertype;
    }

    public List<TitleDTO> GetTitles()
    {
      var title = new List<TitleDTO>();
      foreach (var item in msc.GetMonsterType())
      {
        var t = titleFactory.Create();
      }
      return title;
    }



    public bool InsertMonster(GenderDTO gender)//, string type)
    {
      var gen = msc.GetGender().FirstOrDefault(g => g.Id == gender.AppId);
     // var ty = msc.GetMonsterType().FirstOrDefault(t => t.Name == type);
      var mon = new MonsterDAO{ Name = gender.Name, Gender = gen, Type = new MonsterTypeDAO() { Id = 1 } };

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
