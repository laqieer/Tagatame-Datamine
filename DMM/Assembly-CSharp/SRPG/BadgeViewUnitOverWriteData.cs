// Decompiled with JetBrains decompiler
// Type: SRPG.BadgeViewUnitOverWriteData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200296D")]
  public class BadgeViewUnitOverWriteData
  {
    [Token(Token = "0x400C79A")]
    [FieldOffset(Offset = "0x8")]
    private List<BadgeViewUnitData> _questUnits;
    [Token(Token = "0x400C79B")]
    [FieldOffset(Offset = "0xC")]
    private List<BadgeViewUnitData> _arenaUnits;
    [Token(Token = "0x400C79C")]
    [FieldOffset(Offset = "0x10")]
    private List<BadgeViewUnitData> _arenaDefUnits;
    [Token(Token = "0x400C79D")]
    [FieldOffset(Offset = "0x14")]
    private List<BadgeViewUnitData> _supportUnits;
    [Token(Token = "0x400C79E")]
    [FieldOffset(Offset = "0x18")]
    private List<BadgeViewUnitData> _gvgUnits;
    [Token(Token = "0x400C79F")]
    [FieldOffset(Offset = "0x1C")]
    private List<BadgeViewUnitData> _leagueMatchAtkUnits;
    [Token(Token = "0x400C7A0")]
    [FieldOffset(Offset = "0x20")]
    private List<BadgeViewUnitData> _leagueMatchAtkSetUnits;
    [Token(Token = "0x400C7A1")]
    [FieldOffset(Offset = "0x24")]
    private List<BadgeViewUnitData> _leagueMatchDefUnits;
    [Token(Token = "0x400C7A2")]
    [FieldOffset(Offset = "0x28")]
    private List<BadgeViewUnitData> _leagueMatchShamUnits;

    [Token(Token = "0x17001973")]
    public List<BadgeViewUnitData> QuestUnits
    {
      [Token(Token = "0x600BB68"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<BadgeViewUnitData>) null;
      }
    }

    [Token(Token = "0x17001974")]
    public List<BadgeViewUnitData> ArenaUnits
    {
      [Token(Token = "0x600BB69"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<BadgeViewUnitData>) null;
      }
    }

    [Token(Token = "0x17001975")]
    public List<BadgeViewUnitData> ArenaDefUnits
    {
      [Token(Token = "0x600BB6A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<BadgeViewUnitData>) null;
      }
    }

    [Token(Token = "0x17001976")]
    public List<BadgeViewUnitData> SupportUnits
    {
      [Token(Token = "0x600BB6B"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<BadgeViewUnitData>) null;
      }
    }

    [Token(Token = "0x17001977")]
    public List<BadgeViewUnitData> GvGUnits
    {
      [Token(Token = "0x600BB6C"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<BadgeViewUnitData>) null;
      }
    }

    [Token(Token = "0x17001978")]
    public List<BadgeViewUnitData> LeagueMatchAtkUnits
    {
      [Token(Token = "0x600BB6D"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<BadgeViewUnitData>) null;
      }
    }

    [Token(Token = "0x17001979")]
    public List<BadgeViewUnitData> LeagueMatchAtkSetUnits
    {
      [Token(Token = "0x600BB6E"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<BadgeViewUnitData>) null;
      }
    }

    [Token(Token = "0x1700197A")]
    public List<BadgeViewUnitData> LeagueMatchDefUnits
    {
      [Token(Token = "0x600BB6F"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<BadgeViewUnitData>) null;
      }
    }

    [Token(Token = "0x1700197B")]
    public List<BadgeViewUnitData> LeagueMatchShamUnits
    {
      [Token(Token = "0x600BB70"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (List<BadgeViewUnitData>) null;
      }
    }

    [Token(Token = "0x600BB71")]
    [Address(RVA = "0x82AED0", Offset = "0x829CD0", VA = "0x1082AED0")]
    public List<BadgeViewUnitData> GetQuestList(eOverWritePartyType party_type)
    {
      return (List<BadgeViewUnitData>) null;
    }

    [Token(Token = "0x600BB72")]
    [Address(RVA = "0x82AF70", Offset = "0x829D70", VA = "0x1082AF70")]
    public void Load(EnumBitArray<eOverWritePartyType> dirty_party)
    {
    }

    [Token(Token = "0x600BB73")]
    [Address(RVA = "0x82ACD0", Offset = "0x829AD0", VA = "0x1082ACD0")]
    private void Convert(List<UnitData> units, ref List<BadgeViewUnitData> targets)
    {
    }

    [Token(Token = "0x600BB74")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BadgeViewUnitOverWriteData()
    {
    }
  }
}
