// Decompiled with JetBrains decompiler
// Type: rapidjson.Array
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace rapidjson
{
  [Token(Token = "0x2003515")]
  public class Array : IEnumerable<Value>, IEnumerable
  {
    [Token(Token = "0x400FC04")]
    [FieldOffset(Offset = "0x8")]
    private readonly Document doc;
    [Token(Token = "0x400FC05")]
    [FieldOffset(Offset = "0x10")]
    private readonly ulong begin;
    [Token(Token = "0x400FC06")]
    [FieldOffset(Offset = "0x18")]
    private readonly uint elementSize;
    [Token(Token = "0x400FC07")]
    [FieldOffset(Offset = "0x1C")]
    private readonly uint size;

    [Token(Token = "0x17002173")]
    public int Length
    {
      [Token(Token = "0x600EABF"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600EAC0")]
    [Address(RVA = "0xAE71B0", Offset = "0xAE5FB0", VA = "0x10AE71B0")]
    public Array(Document doc, ref IntPtr ptr)
    {
    }

    [Token(Token = "0x600EAC1")]
    [Address(RVA = "0xAE7140", Offset = "0xAE5F40", VA = "0x10AE7140", Slot = "4")]
    public IEnumerator<Value> GetEnumerator() => (IEnumerator<Value>) null;

    [Token(Token = "0x600EAC2")]
    [Address(RVA = "0xAE7140", Offset = "0xAE5F40", VA = "0x10AE7140", Slot = "5")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x17002174")]
    public Value this[int index]
    {
      [Token(Token = "0x600EAC3"), Address(RVA = "0xAE72F0", Offset = "0xAE60F0", VA = "0x10AE72F0")] get
      {
        return new Value();
      }
    }
  }
}
