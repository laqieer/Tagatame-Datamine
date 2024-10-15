// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_QuestPartyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C5D")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_QuestPartyParam
  {
    [Token(Token = "0x4006F64")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006F65")]
    [FieldOffset(Offset = "0xC")]
    public int type_1;
    [Token(Token = "0x4006F66")]
    [FieldOffset(Offset = "0x10")]
    public int type_2;
    [Token(Token = "0x4006F67")]
    [FieldOffset(Offset = "0x14")]
    public int type_3;
    [Token(Token = "0x4006F68")]
    [FieldOffset(Offset = "0x18")]
    public int type_4;
    [Token(Token = "0x4006F69")]
    [FieldOffset(Offset = "0x1C")]
    public int support_type;
    [Token(Token = "0x4006F6A")]
    [FieldOffset(Offset = "0x20")]
    public int subtype_1;
    [Token(Token = "0x4006F6B")]
    [FieldOffset(Offset = "0x24")]
    public int subtype_2;
    [Token(Token = "0x4006F6C")]
    [FieldOffset(Offset = "0x28")]
    public string unit_1;
    [Token(Token = "0x4006F6D")]
    [FieldOffset(Offset = "0x2C")]
    public string unit_2;
    [Token(Token = "0x4006F6E")]
    [FieldOffset(Offset = "0x30")]
    public string unit_3;
    [Token(Token = "0x4006F6F")]
    [FieldOffset(Offset = "0x34")]
    public string unit_4;
    [Token(Token = "0x4006F70")]
    [FieldOffset(Offset = "0x38")]
    public string subunit_1;
    [Token(Token = "0x4006F71")]
    [FieldOffset(Offset = "0x3C")]
    public string subunit_2;
    [Token(Token = "0x4006F72")]
    [FieldOffset(Offset = "0x40")]
    public int l_npc_rare;

    [Token(Token = "0x600751B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_QuestPartyParam()
    {
    }
  }
}
