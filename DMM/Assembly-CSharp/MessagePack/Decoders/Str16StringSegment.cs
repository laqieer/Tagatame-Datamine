// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Str16StringSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000424")]
  internal sealed class Str16StringSegment : IStringSegmentDecoder
  {
    [Token(Token = "0x4000E77")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringSegmentDecoder Instance;

    [Token(Token = "0x60014A9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Str16StringSegment()
    {
    }

    [Token(Token = "0x60014AA")]
    [Address(RVA = "0x5CA260", Offset = "0x5C9060", VA = "0x105CA260", Slot = "4")]
    public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60014AB")]
    [Address(RVA = "0x5CA300", Offset = "0x5C9100", VA = "0x105CA300")]
    static Str16StringSegment()
    {
    }
  }
}
