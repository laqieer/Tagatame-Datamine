// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.DateTimeArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004FF")]
  public sealed class DateTimeArrayFormatter : 
    IMessagePackFormatter<DateTime[]>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F8E")]
    [FieldOffset(Offset = "0x0")]
    public static readonly DateTimeArrayFormatter Instance;

    [Token(Token = "0x600182C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private DateTimeArrayFormatter()
    {
    }

    [Token(Token = "0x600182D")]
    [Address(RVA = "0x697810", Offset = "0x696610", VA = "0x10697810", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DateTime[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600182E")]
    [Address(RVA = "0x697610", Offset = "0x696410", VA = "0x10697610", Slot = "5")]
    public DateTime[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DateTime[]) null;
    }

    [Token(Token = "0x600182F")]
    [Address(RVA = "0x697940", Offset = "0x696740", VA = "0x10697940")]
    static DateTimeArrayFormatter()
    {
    }
  }
}
