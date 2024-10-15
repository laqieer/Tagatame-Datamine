// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchReadyModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003365")]
  public class LeagueMatchReadyModel
  {
    [Token(Token = "0x17001EED")]
    public List<UnitModel> PlayerUnitModels
    {
      [Token(Token = "0x600E3D5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<UnitModel>) null;
      }
      [Token(Token = "0x600E3D6"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001EEE")]
    public string PlayerName
    {
      [Token(Token = "0x600E3D7"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E3D8"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001EEF")]
    public int PlayerTotalCombatPower
    {
      [Token(Token = "0x600E3D9"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E3DA"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17001EF0")]
    public string PlayerRank
    {
      [Token(Token = "0x600E3DB"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E3DC"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17001EF1")]
    public int PlayerPoint
    {
      [Token(Token = "0x600E3DD"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
      [Token(Token = "0x600E3DE"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x17001EF2")]
    public List<UnitModel> EnemyUnitModels
    {
      [Token(Token = "0x600E3DF"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<UnitModel>) null;
      }
      [Token(Token = "0x600E3E0"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
      {
      }
    }

    [Token(Token = "0x17001EF3")]
    public string EnamyName
    {
      [Token(Token = "0x600E3E1"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E3E2"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x17001EF4")]
    public int EnamyTotalCombatPower
    {
      [Token(Token = "0x600E3E3"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x600E3E4"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x17001EF5")]
    public string EnamyRank
    {
      [Token(Token = "0x600E3E5"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E3E6"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] private set
      {
      }
    }

    [Token(Token = "0x17001EF6")]
    public int EnamyPoint
    {
      [Token(Token = "0x600E3E7"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E3E8"), Address(RVA = "0x2A09E0", Offset = "0x29F7E0", VA = "0x102A09E0")] private set
      {
      }
    }

    [Token(Token = "0x17001EF7")]
    public bool IsAutoEnable
    {
      [Token(Token = "0x600E3E9"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E3EA"), Address(RVA = "0x3A1250", Offset = "0x3A0050", VA = "0x103A1250")] private set
      {
      }
    }

    [Token(Token = "0x600E3EB")]
    [Address(RVA = "0xAB8BE0", Offset = "0xAB79E0", VA = "0x10AB8BE0")]
    public void Initialize(
      JSON_LeagueMatchMyInfo my_info,
      LeagueMatchBattleEditPlayerModel _palyerEditModel,
      LeagueMatchBattleEditEnemyModel _enumyEditModel)
    {
    }

    [Token(Token = "0x600E3EC")]
    [Address(RVA = "0xAB8DA0", Offset = "0xAB7BA0", VA = "0x10AB8DA0")]
    public void UpdateAutoSetting()
    {
    }

    [Token(Token = "0x600E3ED")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchReadyModel()
    {
    }
  }
}
