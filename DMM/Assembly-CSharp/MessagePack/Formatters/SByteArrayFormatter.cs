// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SByteArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004F9")]
  public sealed class SByteArrayFormatter : IMessagePackFormatter<sbyte[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F88")]
    [FieldOffset(Offset = "0x0")]
    public static readonly SByteArrayFormatter Instance;

    [Token(Token = "0x6001814")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private SByteArrayFormatter()
    {
    }

    [Token(Token = "0x6001815")]
    [Address(RVA = "0x6A9E00", Offset = "0x6A8C00", VA = "0x106A9E00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      sbyte[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001816")]
    [Address(RVA = "0x6A9C10", Offset = "0x6A8A10", VA = "0x106A9C10", Slot = "5")]
    public sbyte[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (sbyte[]) null;
    }

    [Token(Token = "0x6001817")]
    [Address(RVA = "0x6A9FF0", Offset = "0x6A8DF0", VA = "0x106A9FF0")]
    static SByteArrayFormatter()
    {
    }
  }
}
