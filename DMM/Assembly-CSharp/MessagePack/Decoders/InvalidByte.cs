﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidByte
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003BD")]
  internal sealed class InvalidByte : IByteDecoder
  {
    [Token(Token = "0x4000E1D")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IByteDecoder Instance;

    [Token(Token = "0x600138E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidByte()
    {
    }

    [Token(Token = "0x600138F")]
    [Address(RVA = "0x5C2E30", Offset = "0x5C1C30", VA = "0x105C2E30", Slot = "4")]
    public byte Read(byte[] bytes, int offset, out int readSize) => new byte();

    [Token(Token = "0x6001390")]
    [Address(RVA = "0x5C2EF0", Offset = "0x5C1CF0", VA = "0x105C2EF0")]
    static InvalidByte()
    {
    }
  }
}