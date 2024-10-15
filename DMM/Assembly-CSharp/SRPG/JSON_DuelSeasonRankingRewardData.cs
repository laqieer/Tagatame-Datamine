// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DuelSeasonRankingRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200230A")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DuelSeasonRankingRewardData
  {
    [Token(Token = "0x4009C5B")]
    [FieldOffset(Offset = "0x8")]
    public int season_id;
    [Token(Token = "0x4009C5C")]
    [FieldOffset(Offset = "0xC")]
    public int my_rank;
    [Token(Token = "0x4009C5D")]
    [FieldOffset(Offset = "0x10")]
    public string my_rank_point;
    [Token(Token = "0x4009C5E")]
    [FieldOffset(Offset = "0x14")]
    public JSON_DuelRewardData[] reward;

    [Token(Token = "0x60096CC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DuelSeasonRankingRewardData()
    {
    }
  }
}
