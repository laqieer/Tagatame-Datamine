// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.DateTimeOffsetFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000506")]
  public sealed class DateTimeOffsetFormatter : 
    IMessagePackFormatter<DateTimeOffset>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F96")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<DateTimeOffset> Instance;

    [Token(Token = "0x6001849")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private DateTimeOffsetFormatter()
    {
    }

    [Token(Token = "0x600184A")]
    [Address(RVA = "0x697C80", Offset = "0x696A80", VA = "0x10697C80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DateTimeOffset value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600184B")]
    [Address(RVA = "0x697B10", Offset = "0x696910", VA = "0x10697B10", Slot = "5")]
    public DateTimeOffset Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new DateTimeOffset();
    }

    [Token(Token = "0x600184C")]
    [Address(RVA = "0x697E20", Offset = "0x696C20", VA = "0x10697E20")]
    static DateTimeOffsetFormatter()
    {
    }
  }
}
