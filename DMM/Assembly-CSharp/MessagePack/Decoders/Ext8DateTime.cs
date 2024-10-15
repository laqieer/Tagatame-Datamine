// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Ext8DateTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200043E")]
  internal sealed class Ext8DateTime : IDateTimeDecoder
  {
    [Token(Token = "0x4000E8E")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDateTimeDecoder Instance;

    [Token(Token = "0x60014F1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Ext8DateTime()
    {
    }

    [Token(Token = "0x60014F2")]
    [Address(RVA = "0x5BE370", Offset = "0x5BD170", VA = "0x105BE370", Slot = "4")]
    public DateTime Read(byte[] bytes, int offset, out int readSize) => new DateTime();

    [Token(Token = "0x60014F3")]
    [Address(RVA = "0x5BE660", Offset = "0x5BD460", VA = "0x105BE660")]
    static Ext8DateTime()
    {
    }
  }
}
