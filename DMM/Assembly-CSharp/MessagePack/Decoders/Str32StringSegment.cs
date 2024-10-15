// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Str32StringSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000425")]
  internal sealed class Str32StringSegment : IStringSegmentDecoder
  {
    [Token(Token = "0x4000E78")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringSegmentDecoder Instance;

    [Token(Token = "0x60014AC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Str32StringSegment()
    {
    }

    [Token(Token = "0x60014AD")]
    [Address(RVA = "0x5CA470", Offset = "0x5C9270", VA = "0x105CA470", Slot = "4")]
    public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60014AE")]
    [Address(RVA = "0x5CA540", Offset = "0x5C9340", VA = "0x105CA540")]
    static Str32StringSegment()
    {
    }
  }
}
