// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ByteFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004F5")]
  public sealed class ByteFormatter : IMessagePackFormatter<byte>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F84")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ByteFormatter Instance;

    [Token(Token = "0x6001804")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ByteFormatter()
    {
    }

    [Token(Token = "0x6001805")]
    [Address(RVA = "0x696A80", Offset = "0x695880", VA = "0x10696A80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      byte value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001806")]
    [Address(RVA = "0x696A30", Offset = "0x695830", VA = "0x10696A30", Slot = "5")]
    public byte Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new byte();
    }

    [Token(Token = "0x6001807")]
    [Address(RVA = "0x696AD0", Offset = "0x6958D0", VA = "0x10696AD0")]
    static ByteFormatter()
    {
    }
  }
}
