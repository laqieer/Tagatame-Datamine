// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchShamInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011B6")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchShamInfo
  {
    [Token(Token = "0x400405F")]
    [FieldOffset(Offset = "0x8")]
    public long[] units;
    [Token(Token = "0x4004060")]
    [FieldOffset(Offset = "0xC")]
    public string map;
    [Token(Token = "0x4004061")]
    [FieldOffset(Offset = "0x10")]
    public JSON_LeagueMatchSet[] placement;
    [Token(Token = "0x4004062")]
    [FieldOffset(Offset = "0x14")]
    public JSON_LeagueMatchBuffs[] buffs;
    [Token(Token = "0x4004063")]
    [FieldOffset(Offset = "0x18")]
    public JSON_PartyOverWrite[] party_decks;
    [Token(Token = "0x4004064")]
    [FieldOffset(Offset = "0x1C")]
    public Json_InvalidSkill[] invalid_units;

    [Token(Token = "0x6004B30")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchShamInfo()
    {
    }
  }
}
