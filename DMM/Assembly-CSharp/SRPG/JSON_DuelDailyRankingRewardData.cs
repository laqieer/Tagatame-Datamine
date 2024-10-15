// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DuelDailyRankingRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002309")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DuelDailyRankingRewardData
  {
    [Token(Token = "0x4009C57")]
    [FieldOffset(Offset = "0x8")]
    public long date;
    [Token(Token = "0x4009C58")]
    [FieldOffset(Offset = "0x10")]
    public int my_rank;
    [Token(Token = "0x4009C59")]
    [FieldOffset(Offset = "0x14")]
    public string my_rank_point;
    [Token(Token = "0x4009C5A")]
    [FieldOffset(Offset = "0x18")]
    public JSON_DuelRewardData[] reward;

    [Token(Token = "0x60096CB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DuelDailyRankingRewardData()
    {
    }
  }
}
