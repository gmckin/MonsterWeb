using MonsterWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterWeb.Tests
{
  public class ServiceTests
  {
    [Fact]
    public void Test_Genders()
    {
      var service = new DataService();
      var actual = service.GetGender();

      Assert.NotNull(actual);
    }

    [Fact]
    public void Test_MonsterTypes()
    {
      var service = new DataService();
      var actual = service.GetMonsterType();

      Assert.NotNull(actual);
    }

    [Fact]
    public void Test_Titles()
    {
      var service = new DataService();
      var actual = service.GetTitles();

      Assert.NotNull(actual);
    }
  }
}
