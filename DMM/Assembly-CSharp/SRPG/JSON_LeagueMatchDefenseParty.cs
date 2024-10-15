// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchDefenseParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011A2")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchDefenseParty
  {
    [Token(Token = "0x400400C")]
    [FieldOffset(Offset = "0x8")]
    public int party_no;
    [Token(Token = "0x400400D")]
    [FieldOffset(Offset = "0xC")]
    public long[] units;
    [Token(Token = "0x400400E")]
    [FieldOffset(Offset = "0x10")]
    public string map;
    [Token(Token = "0x400400F")]
    [FieldOffset(Offset = "0x14")]
    public JSON_LeagueMatchSet[] placement;
    [Token(Token = "0x4004010")]
    [FieldOffset(Offset = "0x18")]
    public JSON_LeagueMatchBuffs[] buffs;

    [Token(Token = "0x6004B1C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchDefenseParty()
    {
    }
  }
}
