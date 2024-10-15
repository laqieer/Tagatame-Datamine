// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BC6")]
  [MessagePackObject(true)]
  public class LeagueMatchRewardParam
  {
    [Token(Token = "0x4006A53")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006A54")]
    [FieldOffset(Offset = "0xC")]
    private LeagueMatchRewardItemParam[] mRewards;

    [Token(Token = "0x17000E18")]
    public string Iname
    {
      [Token(Token = "0x60072AB"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E19")]
    public LeagueMatchRewardItemParam[] Rewards
    {
      [Token(Token = "0x60072AC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (LeagueMatchRewardItemParam[]) null;
      }
    }

    [Token(Token = "0x60072AD")]
    [Address(RVA = "0x379BC0", Offset = "0x3789C0", VA = "0x10379BC0")]
    public bool Deserialize(JSON_LeagueMatchRewardParam json) => new bool();

    [Token(Token = "0x60072AE")]
    [Address(RVA = "0x379D10", Offset = "0x378B10", VA = "0x10379D10")]
    public static bool Deserialize(
      ref List<LeagueMatchRewardParam> paramList,
      JSON_LeagueMatchRewardParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x60072AF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchRewardParam()
    {
    }
  }
}
