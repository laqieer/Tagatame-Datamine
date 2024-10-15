// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Bin8BytesSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003C6")]
  internal sealed class Bin8BytesSegment : IBytesSegmentDecoder
  {
    [Token(Token = "0x4000E24")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IBytesSegmentDecoder Instance;

    [Token(Token = "0x60013A5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Bin8BytesSegment()
    {
    }

    [Token(Token = "0x60013A6")]
    [Address(RVA = "0x5BCF20", Offset = "0x5BBD20", VA = "0x105BCF20", Slot = "4")]
    public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60013A7")]
    [Address(RVA = "0x5BCFA0", Offset = "0x5BBDA0", VA = "0x105BCFA0")]
    static Bin8BytesSegment()
    {
    }
  }
}
