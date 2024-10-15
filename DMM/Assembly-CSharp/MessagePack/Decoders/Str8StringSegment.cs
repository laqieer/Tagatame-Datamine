// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Str8StringSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000423")]
  internal sealed class Str8StringSegment : IStringSegmentDecoder
  {
    [Token(Token = "0x4000E76")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringSegmentDecoder Instance;

    [Token(Token = "0x60014A6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Str8StringSegment()
    {
    }

    [Token(Token = "0x60014A7")]
    [Address(RVA = "0x5CA6E0", Offset = "0x5C94E0", VA = "0x105CA6E0", Slot = "4")]
    public ArraySegment<byte> Read(byte[] bytes, int offset, out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x60014A8")]
    [Address(RVA = "0x5CA760", Offset = "0x5C9560", VA = "0x105CA760")]
    static Str8StringSegment()
    {
    }
  }
}
