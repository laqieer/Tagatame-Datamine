// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchBattleUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011B4")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchBattleUnit
  {
    [Token(Token = "0x4004058")]
    [FieldOffset(Offset = "0x8")]
    public Json_Unit unit;
    [Token(Token = "0x4004059")]
    [FieldOffset(Offset = "0xC")]
    public int hp;
    [Token(Token = "0x400405A")]
    [FieldOffset(Offset = "0x10")]
    public int hp_max;
    [Token(Token = "0x400405B")]
    [FieldOffset(Offset = "0x14")]
    public JSON_LeagueMatchSet start_placement;

    [Token(Token = "0x6004B2E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchBattleUnit()
    {
    }
  }
}
