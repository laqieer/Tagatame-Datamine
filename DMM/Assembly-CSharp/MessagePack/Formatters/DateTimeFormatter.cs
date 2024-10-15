// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.DateTimeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004FD")]
  public sealed class DateTimeFormatter : IMessagePackFormatter<DateTime>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F8C")]
    [FieldOffset(Offset = "0x0")]
    public static readonly DateTimeFormatter Instance;

    [Token(Token = "0x6001824")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private DateTimeFormatter()
    {
    }

    [Token(Token = "0x6001825")]
    [Address(RVA = "0x697A60", Offset = "0x696860", VA = "0x10697A60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DateTime value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001826")]
    [Address(RVA = "0x697A10", Offset = "0x696810", VA = "0x10697A10", Slot = "5")]
    public DateTime Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new DateTime();
    }

    [Token(Token = "0x6001827")]
    [Address(RVA = "0x697AB0", Offset = "0x6968B0", VA = "0x10697AB0")]
    static DateTimeFormatter()
    {
    }
  }
}
