// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.TimeSpanFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000505")]
  public sealed class TimeSpanFormatter : IMessagePackFormatter<TimeSpan>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F95")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<TimeSpan> Instance;

    [Token(Token = "0x6001845")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private TimeSpanFormatter()
    {
    }

    [Token(Token = "0x6001846")]
    [Address(RVA = "0x6AB510", Offset = "0x6AA310", VA = "0x106AB510", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TimeSpan value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001847")]
    [Address(RVA = "0x6AB4C0", Offset = "0x6AA2C0", VA = "0x106AB4C0", Slot = "5")]
    public TimeSpan Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new TimeSpan();
    }

    [Token(Token = "0x6001848")]
    [Address(RVA = "0x6AB580", Offset = "0x6AA380", VA = "0x106AB580")]
    static TimeSpanFormatter()
    {
    }
  }
}
