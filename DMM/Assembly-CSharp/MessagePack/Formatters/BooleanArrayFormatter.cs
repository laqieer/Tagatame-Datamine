// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.BooleanArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004F4")]
  public sealed class BooleanArrayFormatter : IMessagePackFormatter<bool[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F83")]
    [FieldOffset(Offset = "0x0")]
    public static readonly BooleanArrayFormatter Instance;

    [Token(Token = "0x6001800")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private BooleanArrayFormatter()
    {
    }

    [Token(Token = "0x6001801")]
    [Address(RVA = "0x6946F0", Offset = "0x6934F0", VA = "0x106946F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      bool[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001802")]
    [Address(RVA = "0x694560", Offset = "0x693360", VA = "0x10694560", Slot = "5")]
    public bool[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (bool[]) null;
    }

    [Token(Token = "0x6001803")]
    [Address(RVA = "0x694860", Offset = "0x693660", VA = "0x10694860")]
    static BooleanArrayFormatter()
    {
    }
  }
}
