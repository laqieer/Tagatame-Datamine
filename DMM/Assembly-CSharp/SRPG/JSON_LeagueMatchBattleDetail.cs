// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchBattleDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011B3")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchBattleDetail
  {
    [Token(Token = "0x4004054")]
    [FieldOffset(Offset = "0x8")]
    public JSON_LeagueMatchBattleUnit[] offense_units;
    [Token(Token = "0x4004055")]
    [FieldOffset(Offset = "0xC")]
    public JSON_PlayerBuff offense_player_buff;
    [Token(Token = "0x4004056")]
    [FieldOffset(Offset = "0x10")]
    public JSON_LeagueMatchBattleUnit[] defense_units;
    [Token(Token = "0x4004057")]
    [FieldOffset(Offset = "0x14")]
    public JSON_PlayerBuff defense_player_buff;

    [Token(Token = "0x6004B2D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchBattleDetail()
    {
    }
  }
}
