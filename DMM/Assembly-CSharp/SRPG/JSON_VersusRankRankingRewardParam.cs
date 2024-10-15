// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusRankRankingRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ED5")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusRankRankingRewardParam
  {
    [Token(Token = "0x40081AA")]
    [FieldOffset(Offset = "0x8")]
    public int schedule_id;
    [Token(Token = "0x40081AB")]
    [FieldOffset(Offset = "0xC")]
    public int rank_begin;
    [Token(Token = "0x40081AC")]
    [FieldOffset(Offset = "0x10")]
    public int rank_end;
    [Token(Token = "0x40081AD")]
    [FieldOffset(Offset = "0x14")]
    public string reward_id;

    [Token(Token = "0x6007E2D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusRankRankingRewardParam()
    {
    }
  }
}
