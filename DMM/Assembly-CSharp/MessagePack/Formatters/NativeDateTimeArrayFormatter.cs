// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NativeDateTimeArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004D7")]
  public sealed class NativeDateTimeArrayFormatter : 
    IMessagePackFormatter<DateTime[]>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F66")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NativeDateTimeArrayFormatter Instance;

    [Token(Token = "0x600178C")]
    [Address(RVA = "0x6A1420", Offset = "0x6A0220", VA = "0x106A1420", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DateTime[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600178D")]
    [Address(RVA = "0x6A11F0", Offset = "0x69FFF0", VA = "0x106A11F0", Slot = "5")]
    public DateTime[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DateTime[]) null;
    }

    [Token(Token = "0x600178E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public NativeDateTimeArrayFormatter()
    {
    }

    [Token(Token = "0x600178F")]
    [Address(RVA = "0x6A1570", Offset = "0x6A0370", VA = "0x106A1570")]
    static NativeDateTimeArrayFormatter()
    {
    }
  }
}
