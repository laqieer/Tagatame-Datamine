// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableDoubleFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004F0")]
  public sealed class NullableDoubleFormatter : IMessagePackFormatter<double?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F7F")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableDoubleFormatter Instance;

    [Token(Token = "0x60017F0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableDoubleFormatter()
    {
    }

    [Token(Token = "0x60017F1")]
    [Address(RVA = "0x6A2F30", Offset = "0x6A1D30", VA = "0x106A2F30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      double? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017F2")]
    [Address(RVA = "0x6A2E50", Offset = "0x6A1C50", VA = "0x106A2E50", Slot = "5")]
    public double? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new double?();
    }

    [Token(Token = "0x60017F3")]
    [Address(RVA = "0x6A2FE0", Offset = "0x6A1DE0", VA = "0x106A2FE0")]
    static NullableDoubleFormatter()
    {
    }
  }
}
