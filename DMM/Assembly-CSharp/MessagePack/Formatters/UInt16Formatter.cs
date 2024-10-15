// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.UInt16Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004E3")]
  public sealed class UInt16Formatter : IMessagePackFormatter<ushort>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F72")]
    [FieldOffset(Offset = "0x0")]
    public static readonly UInt16Formatter Instance;

    [Token(Token = "0x60017BC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt16Formatter()
    {
    }

    [Token(Token = "0x60017BD")]
    [Address(RVA = "0x6AEBE0", Offset = "0x6AD9E0", VA = "0x106AEBE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ushort value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017BE")]
    [Address(RVA = "0x6AEB90", Offset = "0x6AD990", VA = "0x106AEB90", Slot = "5")]
    public ushort Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ushort();
    }

    [Token(Token = "0x60017BF")]
    [Address(RVA = "0x6AEC30", Offset = "0x6ADA30", VA = "0x106AEC30")]
    static UInt16Formatter()
    {
    }
  }
}
