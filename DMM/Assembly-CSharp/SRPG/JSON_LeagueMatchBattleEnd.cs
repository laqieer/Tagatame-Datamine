// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011B1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchBattleEnd
  {
    [Token(Token = "0x400404A")]
    [FieldOffset(Offset = "0x8")]
    public JSON_LeagueMatchBattleResult btl_result;
    [Token(Token = "0x400404B")]
    [FieldOffset(Offset = "0xC")]
    public JSON_LeagueMatchMyInfo my_info;
    [Token(Token = "0x400404C")]
    [FieldOffset(Offset = "0x10")]
    public JSON_LeagueMatchRewardData[] rewards;
    [Token(Token = "0x400404D")]
    [FieldOffset(Offset = "0x14")]
    public Json_DifferenceUpdatePlayer difference_update;
    [Token(Token = "0x400404E")]
    [FieldOffset(Offset = "0x18")]
    public JSON_TrophyProgress[] trophyprogs;
    [Token(Token = "0x400404F")]
    [FieldOffset(Offset = "0x1C")]
    public JSON_TrophyProgress[] bingoprogs;
    [Token(Token = "0x4004050")]
    [FieldOffset(Offset = "0x20")]
    public JSON_TrophyProgress[] guild_trophies;
    [Token(Token = "0x4004051")]
    [FieldOffset(Offset = "0x24")]
    public Json_HotDealInfo[] hot_deals;

    [Token(Token = "0x6004B2B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchBattleEnd()
    {
    }
  }
}
