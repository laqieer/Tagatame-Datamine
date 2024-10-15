// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRankingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010E3")]
  public class RaidRankingData
  {
    [Token(Token = "0x4003CFF")]
    [FieldOffset(Offset = "0x8")]
    private string mUID;
    [Token(Token = "0x4003D00")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4003D01")]
    [FieldOffset(Offset = "0x10")]
    private int mLv;
    [Token(Token = "0x4003D02")]
    [FieldOffset(Offset = "0x14")]
    private int mRank;
    [Token(Token = "0x4003D03")]
    [FieldOffset(Offset = "0x18")]
    private int mScore;
    [Token(Token = "0x4003D04")]
    [FieldOffset(Offset = "0x1C")]
    private UnitData mUnit;
    [Token(Token = "0x4003D05")]
    [FieldOffset(Offset = "0x20")]
    private string mSelectedAward;
    [Token(Token = "0x4003D06")]
    [FieldOffset(Offset = "0x24")]
    private ViewGuildData mViewGuild;

    [Token(Token = "0x17000732")]
    public string UID
    {
      [Token(Token = "0x6004763"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000733")]
    public string Name
    {
      [Token(Token = "0x6004764"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000734")]
    public int Lv
    {
      [Token(Token = "0x6004765"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000735")]
    public int Rank
    {
      [Token(Token = "0x6004766"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000736")]
    public int Score
    {
      [Token(Token = "0x6004767"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000737")]
    public UnitData Unit
    {
      [Token(Token = "0x6004768"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17000738")]
    public string SelectedAward
    {
      [Token(Token = "0x6004769"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000739")]
    public ViewGuildData ViewGuild
    {
      [Token(Token = "0x600476A"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (ViewGuildData) null;
      }
    }

    [Token(Token = "0x600476B")]
    [Address(RVA = "0x11E8810", Offset = "0x11E7610", VA = "0x111E8810")]
    public bool Deserialize(Json_RaidRankingData json) => new bool();

    [Token(Token = "0x600476C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidRankingData()
    {
    }
  }
}
