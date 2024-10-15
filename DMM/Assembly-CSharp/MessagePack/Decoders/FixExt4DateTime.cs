// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixExt4DateTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200043C")]
  internal sealed class FixExt4DateTime : IDateTimeDecoder
  {
    [Token(Token = "0x4000E8C")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDateTimeDecoder Instance;

    [Token(Token = "0x60014EB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixExt4DateTime()
    {
    }

    [Token(Token = "0x60014EC")]
    [Address(RVA = "0x5BF540", Offset = "0x5BE340", VA = "0x105BF540", Slot = "4")]
    public DateTime Read(byte[] bytes, int offset, out int readSize) => new DateTime();

    [Token(Token = "0x60014ED")]
    [Address(RVA = "0x5BF6D0", Offset = "0x5BE4D0", VA = "0x105BF6D0")]
    static FixExt4DateTime()
    {
    }
  }
}
