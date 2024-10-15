// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchDefenseInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011A1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchDefenseInfo
  {
    [Token(Token = "0x4004008")]
    [FieldOffset(Offset = "0x8")]
    public int now_party_no;
    [Token(Token = "0x4004009")]
    [FieldOffset(Offset = "0xC")]
    public JSON_LeagueMatchDefenseParty[] parties;
    [Token(Token = "0x400400A")]
    [FieldOffset(Offset = "0x10")]
    public JSON_PartyOverWrite[] party_decks;
    [Token(Token = "0x400400B")]
    [FieldOffset(Offset = "0x14")]
    public Json_InvalidSkill[] invalid_units;

    [Token(Token = "0x6004B1B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchDefenseInfo()
    {
    }
  }
}
