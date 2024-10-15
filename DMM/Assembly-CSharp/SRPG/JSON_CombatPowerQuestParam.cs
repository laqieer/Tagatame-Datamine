// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CombatPowerQuestParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A5B")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CombatPowerQuestParam
  {
    [Token(Token = "0x4006137")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006138")]
    [FieldOffset(Offset = "0xC")]
    public int quest_iname_type;
    [Token(Token = "0x4006139")]
    [FieldOffset(Offset = "0x10")]
    public string quest_iname;
    [Token(Token = "0x400613A")]
    [FieldOffset(Offset = "0x14")]
    public int type;
    [Token(Token = "0x400613B")]
    [FieldOffset(Offset = "0x18")]
    public int num;
    [Token(Token = "0x400613C")]
    [FieldOffset(Offset = "0x1C")]
    public string unit_group_id;
    [Token(Token = "0x400613D")]
    [FieldOffset(Offset = "0x20")]
    public string unit_id;

    [Token(Token = "0x6006C5F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CombatPowerQuestParam()
    {
    }
  }
}
