// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DuelBattleResultData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002313")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DuelBattleResultData
  {
    [Token(Token = "0x4009C79")]
    [FieldOffset(Offset = "0x8")]
    public int before_my_rank;
    [Token(Token = "0x4009C7A")]
    [FieldOffset(Offset = "0xC")]
    public int after_my_rank;
    [Token(Token = "0x4009C7B")]
    [FieldOffset(Offset = "0x10")]
    public string my_rank_point;
    [Token(Token = "0x4009C7C")]
    [FieldOffset(Offset = "0x14")]
    public int win_streak;
    [Token(Token = "0x4009C7D")]
    [FieldOffset(Offset = "0x18")]
    public int win_total;
    [Token(Token = "0x4009C7E")]
    [FieldOffset(Offset = "0x1C")]
    public int got_pexp;
    [Token(Token = "0x4009C7F")]
    [FieldOffset(Offset = "0x20")]
    public int got_gold;
    [Token(Token = "0x4009C80")]
    [FieldOffset(Offset = "0x24")]
    public JSON_DuelResultRankPointData rank_point_breakdown;

    [Token(Token = "0x60096D5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DuelBattleResultData()
    {
    }
  }
}
