// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidDateTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200043F")]
  internal sealed class InvalidDateTime : IDateTimeDecoder
  {
    [Token(Token = "0x4000E8F")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDateTimeDecoder Instance;

    [Token(Token = "0x60014F4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidDateTime()
    {
    }

    [Token(Token = "0x60014F5")]
    [Address(RVA = "0x5C3190", Offset = "0x5C1F90", VA = "0x105C3190", Slot = "4")]
    public DateTime Read(byte[] bytes, int offset, out int readSize) => new DateTime();

    [Token(Token = "0x60014F6")]
    [Address(RVA = "0x5C3250", Offset = "0x5C2050", VA = "0x105C3250")]
    static InvalidDateTime()
    {
    }
  }
}
