// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_UnitOverWriteData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E20")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_UnitOverWriteData
  {
    [Token(Token = "0x400E5F1")]
    [FieldOffset(Offset = "0x8")]
    public long unit_iid;
    [Token(Token = "0x400E5F2")]
    [FieldOffset(Offset = "0x10")]
    public long job_iid;
    [Token(Token = "0x400E5F3")]
    [FieldOffset(Offset = "0x18")]
    public long[] abils;
    [Token(Token = "0x400E5F4")]
    [FieldOffset(Offset = "0x1C")]
    public long[] artifacts;
    [Token(Token = "0x400E5F5")]
    [FieldOffset(Offset = "0x20")]
    public JSON_ConceptCard[] concept_cards;
    [Token(Token = "0x400E5F6")]
    [FieldOffset(Offset = "0x24")]
    public long[] runes;
    [Token(Token = "0x400E5F7")]
    [FieldOffset(Offset = "0x28")]
    public Json_InvalidSkillApplyType[] invalid_skills;
    [Token(Token = "0x400E5F8")]
    [FieldOffset(Offset = "0x2C")]
    public JSON_UnitOverWriteCrystalData[] crystals;

    [Token(Token = "0x600D998")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_UnitOverWriteData()
    {
    }
  }
}
