﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000428")]
  internal sealed class FixExt1 : IExtDecoder
  {
    [Token(Token = "0x4000E7A")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtDecoder Instance;

    [Token(Token = "0x60014B3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt1()
    {
    }

    [Token(Token = "0x60014B4")]
    [Address(RVA = "0x5BF250", Offset = "0x5BE050", VA = "0x105BF250", Slot = "4")]
    public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionResult();
    }

    [Token(Token = "0x60014B5")]
    [Address(RVA = "0x5BF300", Offset = "0x5BE100", VA = "0x105BF300")]
    static FixExt1()
    {
    }
  }
}