﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt16Double
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003E3")]
  internal sealed class UInt16Double : IDoubleDecoder
  {
    [Token(Token = "0x4000E3E")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x60013F6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt16Double()
    {
    }

    [Token(Token = "0x60013F7")]
    [Address(RVA = "0x5CB850", Offset = "0x5CA650", VA = "0x105CB850", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x60013F8")]
    [Address(RVA = "0x5CB8E0", Offset = "0x5CA6E0", VA = "0x105CB8E0")]
    static UInt16Double()
    {
    }
  }
}