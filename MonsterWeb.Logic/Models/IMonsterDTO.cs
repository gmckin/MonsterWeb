using System;

namespace MonsterWeb.Logic.Models
{
  public interface IMonsterDTO
  {
    DateTime Creation { get; }
    GenderDTO Gender { get; set; }
    Guid Id { get; }
    string Name { get; }
    TitleDTO Title { get; set; }
    TypeDTO Type { get; set; }
  }
}