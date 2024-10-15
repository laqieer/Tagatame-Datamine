// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Bin16BytesSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003C7")]
  internal sealed class Bin16BytesSegment : IBytesSegmentDecoder
  {
    [Token(Token = "0x4000E25")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IBytesSegmentDecoder Instance;

    [Token(Token = "0x60013A8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Bin16BytesSegment()
    {
    }

    [Token(Token = "0x60013A9")]
    [Address(RVA = "0x5BCAD0", Offset = "0x5BB8D0", VA = "0x105BCAD0", Slot = "4")]
    public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60013AA")]
    [Address(RVA = "0x5BCB70", Offset = "0x5BB970", VA = "0x105BCB70")]
    static Bin16BytesSegment()
    {
    }
  }
}
