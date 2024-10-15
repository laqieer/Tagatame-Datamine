// Decompiled with JetBrains decompiler
// Type: SRPG.Json_InspirationSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FC5")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_InspirationSkill
  {
    [Token(Token = "0x40037B0")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x40037B1")]
    [FieldOffset(Offset = "0x10")]
    public int slot;
    [Token(Token = "0x40037B2")]
    [FieldOffset(Offset = "0x14")]
    public string iname;
    [Token(Token = "0x40037B3")]
    [FieldOffset(Offset = "0x18")]
    public int level;
    [Token(Token = "0x40037B4")]
    [FieldOffset(Offset = "0x1C")]
    public int is_set;

    [Token(Token = "0x60041A1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_InspirationSkill()
    {
    }
  }
}
