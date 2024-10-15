// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.Int32Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004DD")]
  public sealed class Int32Formatter : IMessagePackFormatter<int>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F6C")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Int32Formatter Instance;

    [Token(Token = "0x60017A4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int32Formatter()
    {
    }

    [Token(Token = "0x60017A5")]
    [Address(RVA = "0x69F640", Offset = "0x69E440", VA = "0x1069F640", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      int value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017A6")]
    [Address(RVA = "0x69F5F0", Offset = "0x69E3F0", VA = "0x1069F5F0", Slot = "5")]
    public int Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new int();
    }

    [Token(Token = "0x60017A7")]
    [Address(RVA = "0x69F690", Offset = "0x69E490", VA = "0x1069F690")]
    static Int32Formatter()
    {
    }
  }
}
