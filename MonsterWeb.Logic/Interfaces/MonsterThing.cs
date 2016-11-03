using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.Interfaces
{
  public abstract class MonsterThing : IThing
  {
    public Guid Id { get;}
    public virtual string Name
    { get; }
    public virtual DateTime Creation { get; }

    protected MonsterThing(string Name)
    {
      Id = Guid.NewGuid();
    }
  }
}
