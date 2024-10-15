// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Bin32BytesSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003C8")]
  internal sealed class Bin32BytesSegment : IBytesSegmentDecoder
  {
    [Token(Token = "0x4000E26")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IBytesSegmentDecoder Instance;

    [Token(Token = "0x60013AB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Bin32BytesSegment()
    {
    }

    [Token(Token = "0x60013AC")]
    [Address(RVA = "0x5BCCC0", Offset = "0x5BBAC0", VA = "0x105BCCC0", Slot = "4")]
    public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60013AD")]
    [Address(RVA = "0x5BCD90", Offset = "0x5BBB90", VA = "0x105BCD90")]
    static Bin32BytesSegment()
    {
    }
  }
}
