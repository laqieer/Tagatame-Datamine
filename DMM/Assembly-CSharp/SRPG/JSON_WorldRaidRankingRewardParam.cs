// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidRankingRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F17")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidRankingRewardParam
  {
    [Token(Token = "0x40082E8")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40082E9")]
    [FieldOffset(Offset = "0xC")]
    public JSON_WorldRaidRankingRewardParam.Reward[] rewards;

    [Token(Token = "0x6007F35")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidRankingRewardParam()
    {
    }

    [Token(Token = "0x2001F18")]
    [MessagePackObject(true)]
    [Serializable]
    public class Reward
    {
      [Token(Token = "0x40082EA")]
      [FieldOffset(Offset = "0x8")]
      public int rank_begin;
      [Token(Token = "0x40082EB")]
      [FieldOffset(Offset = "0xC")]
      public int rank_end;
      [Token(Token = "0x40082EC")]
      [FieldOffset(Offset = "0x10")]
      public string reward_id;

      [Token(Token = "0x6007F36")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Reward()
      {
      }
    }
  }
}
