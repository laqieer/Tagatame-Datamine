﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int16Single
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003D2")]
  internal sealed class Int16Single : ISingleDecoder
  {
    [Token(Token = "0x4000E2E")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly ISingleDecoder Instance;

    [Token(Token = "0x60013C5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int16Single()
    {
    }

    [Token(Token = "0x60013C6")]
    [Address(RVA = "0x5C20D0", Offset = "0x5C0ED0", VA = "0x105C20D0", Slot = "4")]
    public float Read(byte[] bytes, int offset, out int readSize) => new float();

    [Token(Token = "0x60013C7")]
    [Address(RVA = "0x5C2150", Offset = "0x5C0F50", VA = "0x105C2150")]
    static Int16Single()
    {
    }
  }
}