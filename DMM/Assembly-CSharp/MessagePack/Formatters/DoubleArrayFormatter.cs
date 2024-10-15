// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.DoubleArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004F1")]
  public sealed class DoubleArrayFormatter : IMessagePackFormatter<double[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F80")]
    [FieldOffset(Offset = "0x0")]
    public static readonly DoubleArrayFormatter Instance;

    [Token(Token = "0x60017F4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private DoubleArrayFormatter()
    {
    }

    [Token(Token = "0x60017F5")]
    [Address(RVA = "0x698450", Offset = "0x697250", VA = "0x10698450", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      double[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017F6")]
    [Address(RVA = "0x698240", Offset = "0x697040", VA = "0x10698240", Slot = "5")]
    public double[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (double[]) null;
    }

    [Token(Token = "0x60017F7")]
    [Address(RVA = "0x698580", Offset = "0x697380", VA = "0x10698580")]
    static DoubleArrayFormatter()
    {
    }
  }
}
