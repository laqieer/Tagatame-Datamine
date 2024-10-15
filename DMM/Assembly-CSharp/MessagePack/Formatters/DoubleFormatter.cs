// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.DoubleFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004EF")]
  public sealed class DoubleFormatter : IMessagePackFormatter<double>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F7E")]
    [FieldOffset(Offset = "0x0")]
    public static readonly DoubleFormatter Instance;

    [Token(Token = "0x60017EC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private DoubleFormatter()
    {
    }

    [Token(Token = "0x60017ED")]
    [Address(RVA = "0x698630", Offset = "0x697430", VA = "0x10698630", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      double value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017EE")]
    [Address(RVA = "0x6985E0", Offset = "0x6973E0", VA = "0x106985E0", Slot = "5")]
    public double Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new double();
    }

    [Token(Token = "0x60017EF")]
    [Address(RVA = "0x698690", Offset = "0x697490", VA = "0x10698690")]
    static DoubleFormatter()
    {
    }
  }
}
