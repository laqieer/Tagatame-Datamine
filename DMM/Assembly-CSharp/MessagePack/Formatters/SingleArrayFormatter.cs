// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SingleArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004EE")]
  public sealed class SingleArrayFormatter : IMessagePackFormatter<float[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F7D")]
    [FieldOffset(Offset = "0x0")]
    public static readonly SingleArrayFormatter Instance;

    [Token(Token = "0x60017E8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private SingleArrayFormatter()
    {
    }

    [Token(Token = "0x60017E9")]
    [Address(RVA = "0x6AA620", Offset = "0x6A9420", VA = "0x106AA620", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      float[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017EA")]
    [Address(RVA = "0x6AA410", Offset = "0x6A9210", VA = "0x106AA410", Slot = "5")]
    public float[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (float[]) null;
    }

    [Token(Token = "0x60017EB")]
    [Address(RVA = "0x6AA8D0", Offset = "0x6A96D0", VA = "0x106AA8D0")]
    static SingleArrayFormatter()
    {
    }
  }
}
