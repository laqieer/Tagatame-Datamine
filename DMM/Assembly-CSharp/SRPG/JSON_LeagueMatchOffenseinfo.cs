// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchOffenseinfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011A7")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchOffenseinfo
  {
    [Token(Token = "0x400401D")]
    [FieldOffset(Offset = "0x8")]
    public JSON_LeagueMatchParties[] parties;
    [Token(Token = "0x400401E")]
    [FieldOffset(Offset = "0xC")]
    public JSON_PartyOverWrite[] party_decks;
    [Token(Token = "0x400401F")]
    [FieldOffset(Offset = "0x10")]
    public Json_InvalidSkill[] invalid_units;

    [Token(Token = "0x6004B21")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchOffenseinfo()
    {
    }
  }
}
