// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableCharFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004FB")]
  public sealed class NullableCharFormatter : IMessagePackFormatter<char?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F8A")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableCharFormatter Instance;

    [Token(Token = "0x600181C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableCharFormatter()
    {
    }

    [Token(Token = "0x600181D")]
    [Address(RVA = "0x6A2B40", Offset = "0x6A1940", VA = "0x106A2B40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      char? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600181E")]
    [Address(RVA = "0x6A2A50", Offset = "0x6A1850", VA = "0x106A2A50", Slot = "5")]
    public char? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new char?();
    }

    [Token(Token = "0x600181F")]
    [Address(RVA = "0x6A2C10", Offset = "0x6A1A10", VA = "0x106A2C10")]
    static NullableCharFormatter()
    {
    }
  }
}
