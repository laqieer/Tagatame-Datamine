// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidBytesSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003C9")]
  internal sealed class InvalidBytesSegment : IBytesSegmentDecoder
  {
    [Token(Token = "0x4000E27")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IBytesSegmentDecoder Instance;

    [Token(Token = "0x60013AE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidBytesSegment()
    {
    }

    [Token(Token = "0x60013AF")]
    [Address(RVA = "0x5C2F50", Offset = "0x5C1D50", VA = "0x105C2F50", Slot = "4")]
    public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60013B0")]
    [Address(RVA = "0x5C3010", Offset = "0x5C1E10", VA = "0x105C3010")]
    static InvalidBytesSegment()
    {
    }
  }
}
