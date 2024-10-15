// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidStringSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000426")]
  internal sealed class InvalidStringSegment : IStringSegmentDecoder
  {
    [Token(Token = "0x4000E79")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringSegmentDecoder Instance;

    [Token(Token = "0x60014AF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidStringSegment()
    {
    }

    [Token(Token = "0x60014B0")]
    [Address(RVA = "0x5C3CD0", Offset = "0x5C2AD0", VA = "0x105C3CD0", Slot = "4")]
    public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60014B1")]
    [Address(RVA = "0x5C3D90", Offset = "0x5C2B90", VA = "0x105C3D90")]
    static InvalidStringSegment()
    {
    }
  }
}
