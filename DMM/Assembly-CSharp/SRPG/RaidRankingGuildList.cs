// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRankingGuildList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010E4")]
  public class RaidRankingGuildList
  {
    [Token(Token = "0x4003D07")]
    [FieldOffset(Offset = "0x8")]
    private RaidRankingGuildData mMyGuildInfo;
    [Token(Token = "0x4003D08")]
    [FieldOffset(Offset = "0xC")]
    private List<RaidRankingGuildData> mRanking;

    [Token(Token = "0x1700073A")]
    public RaidRankingGuildData MyGuildInfo
    {
      [Token(Token = "0x600476D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (RaidRankingGuildData) null;
      }
    }

    [Token(Token = "0x1700073B")]
    public List<RaidRankingGuildData> Ranking
    {
      [Token(Token = "0x600476E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RaidRankingGuildData>) null;
      }
    }

    [Token(Token = "0x600476F")]
    [Address(RVA = "0x11E89C0", Offset = "0x11E77C0", VA = "0x111E89C0")]
    public bool Deserialize(Json_RaidRankingGuildList json) => new bool();

    [Token(Token = "0x6004770")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidRankingGuildList()
    {
    }
  }
}
