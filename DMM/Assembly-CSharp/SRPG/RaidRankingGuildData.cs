// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRankingGuildData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010E5")]
  public class RaidRankingGuildData
  {
    [Token(Token = "0x4003D09")]
    [FieldOffset(Offset = "0x8")]
    private int mRank;
    [Token(Token = "0x4003D0A")]
    [FieldOffset(Offset = "0xC")]
    private int mScore;
    [Token(Token = "0x4003D0B")]
    [FieldOffset(Offset = "0x10")]
    private ViewGuildData mViewGuild;

    [Token(Token = "0x1700073C")]
    public int Rank
    {
      [Token(Token = "0x6004771"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700073D")]
    public int Score
    {
      [Token(Token = "0x6004772"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700073E")]
    public ViewGuildData ViewGuild
    {
      [Token(Token = "0x6004773"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ViewGuildData) null;
      }
    }

    [Token(Token = "0x6004774")]
    [Address(RVA = "0x11E8930", Offset = "0x11E7730", VA = "0x111E8930")]
    public bool Deserialize(Json_RaidRankingGuildData json) => new bool();

    [Token(Token = "0x6004775")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidRankingGuildData()
    {
    }
  }
}
