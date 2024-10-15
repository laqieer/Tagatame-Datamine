// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchShamMatchUpModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003366")]
  public class LeagueMatchShamMatchUpModel
  {
    [Token(Token = "0x400F2DF")]
    [FieldOffset(Offset = "0x8")]
    private bool _isShamBattleResult;
    [Token(Token = "0x400F2E0")]
    [FieldOffset(Offset = "0xC")]
    private List<Unit> _offenseUnits;
    [Token(Token = "0x400F2E1")]
    [FieldOffset(Offset = "0x10")]
    private List<Unit> _defenseUnits;
    [Token(Token = "0x400F2E2")]
    [FieldOffset(Offset = "0x14")]
    private int _offenseTotalCombatPower;
    [Token(Token = "0x400F2E3")]
    [FieldOffset(Offset = "0x18")]
    private int _defenseTotalCombatPower;
    [Token(Token = "0x400F2E4")]
    [FieldOffset(Offset = "0x1C")]
    private bool _isAutoEnable;
    [Token(Token = "0x400F2E5")]
    [FieldOffset(Offset = "0x1D")]
    private bool _isOffenseWin;

    [Token(Token = "0x17001EF8")]
    public bool IsShamBattleResult
    {
      [Token(Token = "0x600E3EE"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EF9")]
    public List<Unit> OffenseUnits
    {
      [Token(Token = "0x600E3EF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x17001EFA")]
    public int OffenseTotalCombatPower
    {
      [Token(Token = "0x600E3F0"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EFB")]
    public List<Unit> DefenseUnits
    {
      [Token(Token = "0x600E3F1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<Unit>) null;
      }
    }

    [Token(Token = "0x17001EFC")]
    public int DefenseTotalCombatPower
    {
      [Token(Token = "0x600E3F2"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EFD")]
    public bool IsOffenseWin
    {
      [Token(Token = "0x600E3F3"), Address(RVA = "0x5EDE50", Offset = "0x5ECC50", VA = "0x105EDE50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001EFE")]
    public bool IsAutoEnable
    {
      [Token(Token = "0x600E3F4"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E3F5")]
    [Address(RVA = "0xAB91B0", Offset = "0xAB7FB0", VA = "0x10AB91B0")]
    public void Initialize(
      List<Unit> offense_units,
      List<Unit> defense_units,
      bool is_battle_result,
      bool is_win)
    {
    }

    [Token(Token = "0x600E3F6")]
    [Address(RVA = "0xAB9060", Offset = "0xAB7E60", VA = "0x10AB9060")]
    private void InitializeData(List<Unit> units, ref int combatpower)
    {
    }

    [Token(Token = "0x600E3F7")]
    [Address(RVA = "0xAB9260", Offset = "0xAB8060", VA = "0x10AB9260")]
    public void UpdateAutoSetting()
    {
    }

    [Token(Token = "0x600E3F8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchShamMatchUpModel()
    {
    }
  }
}
