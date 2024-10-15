// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt8DateTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200043D")]
  internal sealed class FixExt8DateTime : IDateTimeDecoder
  {
    [Token(Token = "0x4000E8D")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDateTimeDecoder Instance;

    [Token(Token = "0x60014EE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt8DateTime()
    {
    }

    [Token(Token = "0x60014EF")]
    [Address(RVA = "0x5BF940", Offset = "0x5BE740", VA = "0x105BF940", Slot = "4")]
    public DateTime Read(byte[] bytes, int offset, out int readSize) => new DateTime();

    [Token(Token = "0x60014F0")]
    [Address(RVA = "0x5BFBA0", Offset = "0x5BE9A0", VA = "0x105BFBA0")]
    static FixExt8DateTime()
    {
    }
  }
}
