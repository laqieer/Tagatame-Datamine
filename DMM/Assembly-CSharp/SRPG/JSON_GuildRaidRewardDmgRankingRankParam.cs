// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidRewardDmgRankingRankParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B50")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidRewardDmgRankingRankParam
  {
    [Token(Token = "0x4006844")]
    [FieldOffset(Offset = "0x8")]
    public int rank_start;
    [Token(Token = "0x4006845")]
    [FieldOffset(Offset = "0xC")]
    public int rank_end;
    [Token(Token = "0x4006846")]
    [FieldOffset(Offset = "0x10")]
    public string reward_round_id;

    [Token(Token = "0x60070C0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidRewardDmgRankingRankParam()
    {
    }
  }
}
