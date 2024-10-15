// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableUInt16Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004E4")]
  public sealed class NullableUInt16Formatter : IMessagePackFormatter<ushort?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F73")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableUInt16Formatter Instance;

    [Token(Token = "0x60017C0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableUInt16Formatter()
    {
    }

    [Token(Token = "0x60017C1")]
    [Address(RVA = "0x6A4EA0", Offset = "0x6A3CA0", VA = "0x106A4EA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ushort? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017C2")]
    [Address(RVA = "0x6A4DE0", Offset = "0x6A3BE0", VA = "0x106A4DE0", Slot = "5")]
    public ushort? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ushort?();
    }

    [Token(Token = "0x60017C3")]
    [Address(RVA = "0x6A4F40", Offset = "0x6A3D40", VA = "0x106A4F40")]
    static NullableUInt16Formatter()
    {
    }
  }
}
