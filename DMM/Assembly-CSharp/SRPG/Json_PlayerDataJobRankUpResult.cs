// Decompiled with JetBrains decompiler
// Type: SRPG.Json_PlayerDataJobRankUpResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FEF")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_PlayerDataJobRankUpResult
  {
    [Token(Token = "0x400387B")]
    [FieldOffset(Offset = "0x8")]
    public Json_PlayerData player;
    [Token(Token = "0x400387C")]
    [FieldOffset(Offset = "0xC")]
    public Json_Unit[] units;
    [Token(Token = "0x400387D")]
    [FieldOffset(Offset = "0x10")]
    public Json_Item[] items;
    [Token(Token = "0x400387E")]
    [FieldOffset(Offset = "0x14")]
    public JSON_PartyOverWrite[] party_decks;
    [Token(Token = "0x400387F")]
    [FieldOffset(Offset = "0x18")]
    public Json_InvalidSkill[] invalid_units;

    [Token(Token = "0x6004253")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_PlayerDataJobRankUpResult()
    {
    }
  }
}
