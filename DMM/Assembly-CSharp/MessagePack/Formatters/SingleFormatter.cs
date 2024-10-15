// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SingleFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004EC")]
  public sealed class SingleFormatter : IMessagePackFormatter<float>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F7B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly SingleFormatter Instance;

    [Token(Token = "0x60017E0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private SingleFormatter()
    {
    }

    [Token(Token = "0x60017E1")]
    [Address(RVA = "0x6AA980", Offset = "0x6A9780", VA = "0x106AA980", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      float value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017E2")]
    [Address(RVA = "0x6AA930", Offset = "0x6A9730", VA = "0x106AA930", Slot = "5")]
    public float Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new float();
    }

    [Token(Token = "0x60017E3")]
    [Address(RVA = "0x6AA9E0", Offset = "0x6A97E0", VA = "0x106AA9E0")]
    static SingleFormatter()
    {
    }
  }
}
