// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRankingList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010E2")]
  public class RaidRankingList
  {
    [Token(Token = "0x4003CFD")]
    [FieldOffset(Offset = "0x8")]
    private RaidRankingData mMyInfo;
    [Token(Token = "0x4003CFE")]
    [FieldOffset(Offset = "0xC")]
    private List<RaidRankingData> mRanking;

    [Token(Token = "0x17000730")]
    public RaidRankingData MyInfo
    {
      [Token(Token = "0x600475F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (RaidRankingData) null;
      }
    }

    [Token(Token = "0x17000731")]
    public List<RaidRankingData> Ranking
    {
      [Token(Token = "0x6004760"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RaidRankingData>) null;
      }
    }

    [Token(Token = "0x6004761")]
    [Address(RVA = "0x11E8BC0", Offset = "0x11E79C0", VA = "0x111E8BC0")]
    public bool Deserialize(Json_RaidRankingList json) => new bool();

    [Token(Token = "0x6004762")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidRankingList()
    {
    }
  }
}
