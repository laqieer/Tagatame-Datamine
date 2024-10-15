// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ByteArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000501")]
  public sealed class ByteArrayFormatter : IMessagePackFormatter<byte[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F91")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ByteArrayFormatter Instance;

    [Token(Token = "0x6001835")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ByteArrayFormatter()
    {
    }

    [Token(Token = "0x6001836")]
    [Address(RVA = "0x6966F0", Offset = "0x6954F0", VA = "0x106966F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      byte[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001837")]
    [Address(RVA = "0x6966A0", Offset = "0x6954A0", VA = "0x106966A0", Slot = "5")]
    public byte[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x6001838")]
    [Address(RVA = "0x6967A0", Offset = "0x6955A0", VA = "0x106967A0")]
    static ByteArrayFormatter()
    {
    }
  }
}
