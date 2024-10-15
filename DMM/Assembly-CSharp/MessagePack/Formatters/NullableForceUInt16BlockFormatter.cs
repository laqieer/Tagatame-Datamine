// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableForceUInt16BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004C1")]
  public sealed class NullableForceUInt16BlockFormatter : 
    IMessagePackFormatter<ushort?>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F54")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableForceUInt16BlockFormatter Instance;

    [Token(Token = "0x6001740")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableForceUInt16BlockFormatter()
    {
    }

    [Token(Token = "0x6001741")]
    [Address(RVA = "0x6A3A10", Offset = "0x6A2810", VA = "0x106A3A10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ushort? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001742")]
    [Address(RVA = "0x6A3950", Offset = "0x6A2750", VA = "0x106A3950", Slot = "5")]
    public ushort? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ushort?();
    }

    [Token(Token = "0x6001743")]
    [Address(RVA = "0x6A3AB0", Offset = "0x6A28B0", VA = "0x106A3AB0")]
    static NullableForceUInt16BlockFormatter()
    {
    }
  }
}
