// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchRankParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BC2")]
  [MessagePackObject(true)]
  public class LeagueMatchRankParam
  {
    [Token(Token = "0x4006A42")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006A43")]
    [FieldOffset(Offset = "0xC")]
    private LeagueMatchRankClassParam[] mRanks;

    [Token(Token = "0x17000E0C")]
    public string Iname
    {
      [Token(Token = "0x6007298"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E0D")]
    public LeagueMatchRankClassParam[] Ranks
    {
      [Token(Token = "0x6007299"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (LeagueMatchRankClassParam[]) null;
      }
    }

    [Token(Token = "0x600729A")]
    [Address(RVA = "0x379A90", Offset = "0x378890", VA = "0x10379A90")]
    public bool Deserialize(JSON_LeagueMatchRankParam json) => new bool();

    [Token(Token = "0x600729B")]
    [Address(RVA = "0x379820", Offset = "0x378620", VA = "0x10379820")]
    public static bool Deserialize(
      ref List<LeagueMatchRankParam> paramList,
      JSON_LeagueMatchRankParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600729C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchRankParam()
    {
    }
  }
}
