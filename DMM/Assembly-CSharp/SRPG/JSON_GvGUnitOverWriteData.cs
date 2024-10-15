// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGUnitOverWriteData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025B6")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGUnitOverWriteData
  {
    [Token(Token = "0x400AF05")]
    [FieldOffset(Offset = "0x8")]
    public long unit_iid;
    [Token(Token = "0x400AF06")]
    [FieldOffset(Offset = "0x10")]
    public long job_iid;
    [Token(Token = "0x400AF07")]
    [FieldOffset(Offset = "0x18")]
    public long[] abils;
    [Token(Token = "0x400AF08")]
    [FieldOffset(Offset = "0x1C")]
    public long[] artifacts;
    [Token(Token = "0x400AF09")]
    [FieldOffset(Offset = "0x20")]
    public long[] runes;
    [Token(Token = "0x400AF0A")]
    [FieldOffset(Offset = "0x24")]
    public int[] concept_cards;
    [Token(Token = "0x400AF0B")]
    [FieldOffset(Offset = "0x28")]
    public int is_leaderskill;
    [Token(Token = "0x400AF0C")]
    [FieldOffset(Offset = "0x2C")]
    public Json_InvalidSkillApplyType[] invalid_skills;
    [Token(Token = "0x400AF0D")]
    [FieldOffset(Offset = "0x30")]
    public long[] crystals;

    [Token(Token = "0x600A75F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGUnitOverWriteData()
    {
    }
  }
}
