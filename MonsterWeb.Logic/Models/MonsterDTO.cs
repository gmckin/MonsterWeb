using MonsterWeb.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonsterWeb.Logic.Models
{
  public partial class MonsterDTO : MonsterThing
  {

    partial void IsNull(ref string data, string value);

    private string _Name = default(string);
    private string _GenderId = default(string);
    private string _TypeId = default(string);


    public new Guid Id { get; }
    public new string Name
    {
      get
      {
        return _Name;
      }
      private set
      {
        IsNull(ref _Name, value);
      }
    }

    public string GenderId {
      get
      {
        return _GenderId;
      }
      private set
      {
        IsNull(ref _GenderId, value);
      }
    }
    public string TypeId {
      get
      {
        return _TypeId;
      }
      private set
      {
        IsNull(ref _TypeId, value);
      }
    }

    public new DateTime Creation { get;}

    public MonsterDTO(string name, string genderId, string typeId) : base(genderId)
    {
      int tempGender;
      int tempType;

      //Name = name;
      int.TryParse(genderId, out tempGender);
      // GenderId = int.Parse(genderId);
      int.TryParse(typeId, out tempType);
      // TypeId = int.Parse(typeId);
      
      Name = name;
      GenderId = tempGender.ToString();
      TypeId = tempType.ToString();
    }


    ~MonsterDTO()
    {
      GC.Collect();
    }
  }
}
