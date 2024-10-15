// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.NilBytesSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003C5")]
  internal sealed class NilBytesSegment : IBytesSegmentDecoder
  {
    [Token(Token = "0x4000E23")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IBytesSegmentDecoder Instance;

    [Token(Token = "0x60013A2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NilBytesSegment()
    {
    }

    [Token(Token = "0x60013A3")]
    [Address(RVA = "0x5C8DF0", Offset = "0x5C7BF0", VA = "0x105C8DF0", Slot = "4")]
    public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60013A4")]
    [Address(RVA = "0x5C8E10", Offset = "0x5C7C10", VA = "0x105C8E10")]
    static NilBytesSegment()
    {
    }
  }
}
