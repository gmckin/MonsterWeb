using MonsterWeb.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.Models
{
  public partial class TitleDTO : MonsterThing
  {
    private string _Name = default(string);

    public override string Name
    {
      get
      {
        return _Name;
      }
      set
      {
        IsNull(ref _Name, value);
      }
    }
    private void IsNull(ref string data, string value)
    {
      if (string.IsNullOrWhiteSpace(value))
      {
        return;
      }
      data = value;
    }

    internal override TitleDTO Create<TitleDTO>()
    {
      return new TitleDTO();
    }
        
    public TitleDTO() : base()
    {

    }
  }
}
