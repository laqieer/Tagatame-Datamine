﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.NilStringSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000421")]
  internal sealed class NilStringSegment : IStringSegmentDecoder
  {
    [Token(Token = "0x4000E74")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringSegmentDecoder Instance;

    [Token(Token = "0x60014A0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NilStringSegment()
    {
    }

    [Token(Token = "0x60014A1")]
    [Address(RVA = "0x5C8EE0", Offset = "0x5C7CE0", VA = "0x105C8EE0", Slot = "4")]
    public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60014A2")]
    [Address(RVA = "0x5C8F40", Offset = "0x5C7D40", VA = "0x105C8F40")]
    static NilStringSegment()
    {
    }
  }
}