// Decompiled with JetBrains decompiler
// Type: SRPG.Json_DifferenceUpdate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001033")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_DifferenceUpdate
  {
    [Token(Token = "0x400399C")]
    [FieldOffset(Offset = "0x8")]
    public Json_Item[] items;
    [Token(Token = "0x400399D")]
    [FieldOffset(Offset = "0xC")]
    public Json_Artifact[] artifacts;
    [Token(Token = "0x400399E")]
    [FieldOffset(Offset = "0x10")]
    public Json_Unit[] units;
    [Token(Token = "0x400399F")]
    [FieldOffset(Offset = "0x14")]
    public JSON_ConceptCard[] cards;
    [Token(Token = "0x40039A0")]
    [FieldOffset(Offset = "0x18")]
    public Json_RuneData[] runes;
    [Token(Token = "0x40039A1")]
    [FieldOffset(Offset = "0x1C")]
    public int rune_storage_used;
    [Token(Token = "0x40039A2")]
    [FieldOffset(Offset = "0x20")]
    public JSON_CrystalData[] crystals;

    [Token(Token = "0x6004299")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_DifferenceUpdate()
    {
    }
  }
}
