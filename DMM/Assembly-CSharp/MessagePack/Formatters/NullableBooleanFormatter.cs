// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableBooleanFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004F3")]
  public sealed class NullableBooleanFormatter : IMessagePackFormatter<bool?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F82")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableBooleanFormatter Instance;

    [Token(Token = "0x60017FC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableBooleanFormatter()
    {
    }

    [Token(Token = "0x60017FD")]
    [Address(RVA = "0x6A2770", Offset = "0x6A1570", VA = "0x106A2770", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      bool? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017FE")]
    [Address(RVA = "0x6A26B0", Offset = "0x6A14B0", VA = "0x106A26B0", Slot = "5")]
    public bool? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new bool?();
    }

    [Token(Token = "0x60017FF")]
    [Address(RVA = "0x6A2820", Offset = "0x6A1620", VA = "0x106A2820")]
    static NullableBooleanFormatter()
    {
    }
  }
}
