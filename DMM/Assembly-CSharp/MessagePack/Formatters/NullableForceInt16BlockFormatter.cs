// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableForceInt16BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004B8")]
  public sealed class NullableForceInt16BlockFormatter : 
    IMessagePackFormatter<short?>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F4B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableForceInt16BlockFormatter Instance;

    [Token(Token = "0x600171C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableForceInt16BlockFormatter()
    {
    }

    [Token(Token = "0x600171D")]
    [Address(RVA = "0x6A32D0", Offset = "0x6A20D0", VA = "0x106A32D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      short? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600171E")]
    [Address(RVA = "0x6A3210", Offset = "0x6A2010", VA = "0x106A3210", Slot = "5")]
    public short? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new short?();
    }

    [Token(Token = "0x600171F")]
    [Address(RVA = "0x6A3370", Offset = "0x6A2170", VA = "0x106A3370")]
    static NullableForceInt16BlockFormatter()
    {
    }
  }
}
