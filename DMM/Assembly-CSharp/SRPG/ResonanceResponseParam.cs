// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceResponseParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FFA")]
  [MessagePackObject(true)]
  [Serializable]
  public class ResonanceResponseParam
  {
    [Token(Token = "0x400EB3A")]
    [FieldOffset(Offset = "0x8")]
    public Json_DifferenceUpdate difference_update;
    [Token(Token = "0x400EB3B")]
    [FieldOffset(Offset = "0xC")]
    public Json_PlayerData player;
    [Token(Token = "0x400EB3C")]
    [FieldOffset(Offset = "0x10")]
    public JSON_PartyOverWrite[] party_decks;
    [Token(Token = "0x400EB3D")]
    [FieldOffset(Offset = "0x14")]
    public Json_InvalidSkill[] invalid_units;
    [Token(Token = "0x400EB3E")]
    [FieldOffset(Offset = "0x18")]
    public Json_BondData[] bonds;

    [Token(Token = "0x600DC50")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ResonanceResponseParam()
    {
    }
  }
}
