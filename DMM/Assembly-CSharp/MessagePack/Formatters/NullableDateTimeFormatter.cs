// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableDateTimeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004FE")]
  public sealed class NullableDateTimeFormatter : 
    IMessagePackFormatter<DateTime?>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F8D")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableDateTimeFormatter Instance;

    [Token(Token = "0x6001828")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableDateTimeFormatter()
    {
    }

    [Token(Token = "0x6001829")]
    [Address(RVA = "0x6A2D40", Offset = "0x6A1B40", VA = "0x106A2D40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DateTime? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600182A")]
    [Address(RVA = "0x6A2C70", Offset = "0x6A1A70", VA = "0x106A2C70", Slot = "5")]
    public DateTime? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new DateTime?();
    }

    [Token(Token = "0x600182B")]
    [Address(RVA = "0x6A2DF0", Offset = "0x6A1BF0", VA = "0x106A2DF0")]
    static NullableDateTimeFormatter()
    {
    }
  }
}
