// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableInt32Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004DE")]
  public sealed class NullableInt32Formatter : IMessagePackFormatter<int?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F6D")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableInt32Formatter Instance;

    [Token(Token = "0x60017A8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableInt32Formatter()
    {
    }

    [Token(Token = "0x60017A9")]
    [Address(RVA = "0x6A4150", Offset = "0x6A2F50", VA = "0x106A4150", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      int? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017AA")]
    [Address(RVA = "0x6A4080", Offset = "0x6A2E80", VA = "0x106A4080", Slot = "5")]
    public int? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new int?();
    }

    [Token(Token = "0x60017AB")]
    [Address(RVA = "0x6A41F0", Offset = "0x6A2FF0", VA = "0x106A41F0")]
    static NullableInt32Formatter()
    {
    }
  }
}
