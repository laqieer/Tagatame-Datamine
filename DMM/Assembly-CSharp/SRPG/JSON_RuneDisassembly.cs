// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RuneDisassembly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CDC")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RuneDisassembly
  {
    [Token(Token = "0x400711C")]
    [FieldOffset(Offset = "0x8")]
    public string success_item;
    [Token(Token = "0x400711D")]
    [FieldOffset(Offset = "0xC")]
    public int success_num;
    [Token(Token = "0x400711E")]
    [FieldOffset(Offset = "0x10")]
    public string great_item;
    [Token(Token = "0x400711F")]
    [FieldOffset(Offset = "0x14")]
    public int great_num;
    [Token(Token = "0x4007120")]
    [FieldOffset(Offset = "0x18")]
    public string super_item;
    [Token(Token = "0x4007121")]
    [FieldOffset(Offset = "0x1C")]
    public int super_num;

    [Token(Token = "0x600769F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RuneDisassembly()
    {
    }
  }
}
