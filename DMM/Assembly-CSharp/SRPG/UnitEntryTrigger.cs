// Decompiled with JetBrains decompiler
// Type: SRPG.UnitEntryTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C11")]
  [MessagePackObject(true)]
  [Serializable]
  public class UnitEntryTrigger
  {
    [Token(Token = "0x4001F49")]
    [FieldOffset(Offset = "0x8")]
    public int type;
    [Token(Token = "0x4001F4A")]
    [FieldOffset(Offset = "0xC")]
    public string unit;
    [Token(Token = "0x4001F4B")]
    [FieldOffset(Offset = "0x10")]
    public string skill;
    [Token(Token = "0x4001F4C")]
    [FieldOffset(Offset = "0x14")]
    public int value;
    [Token(Token = "0x4001F4D")]
    [FieldOffset(Offset = "0x18")]
    public int x;
    [Token(Token = "0x4001F4E")]
    [FieldOffset(Offset = "0x1C")]
    public int y;
    [Token(Token = "0x4001F4F")]
    [FieldOffset(Offset = "0x20")]
    [NonSerialized]
    public bool on;

    [Token(Token = "0x6003021")]
    [Address(RVA = "0xFEB990", Offset = "0xFEA790", VA = "0x10FEB990")]
    public void Clear()
    {
    }

    [Token(Token = "0x6003022")]
    [Address(RVA = "0xFEBA00", Offset = "0xFEA800", VA = "0x10FEBA00")]
    public UnitEntryTrigger()
    {
    }
  }
}
