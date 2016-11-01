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
    }
  }
