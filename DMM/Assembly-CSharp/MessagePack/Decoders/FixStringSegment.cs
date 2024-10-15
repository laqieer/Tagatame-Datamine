// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixStringSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000422")]
  internal sealed class FixStringSegment : IStringSegmentDecoder
  {
    [Token(Token = "0x4000E75")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringSegmentDecoder Instance;

    [Token(Token = "0x60014A3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixStringSegment()
    {
    }

    [Token(Token = "0x60014A4")]
    [Address(RVA = "0x5C0520", Offset = "0x5BF320", VA = "0x105C0520", Slot = "4")]
    public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60014A5")]
    [Address(RVA = "0x5C05A0", Offset = "0x5BF3A0", VA = "0x105C05A0")]
    static FixStringSegment()
    {
    }
  }
}
