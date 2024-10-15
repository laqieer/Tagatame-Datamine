// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.CharFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004FA")]
  public sealed class CharFormatter : IMessagePackFormatter<char>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F89")]
    [FieldOffset(Offset = "0x0")]
    public static readonly CharFormatter Instance;

    [Token(Token = "0x6001818")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private CharFormatter()
    {
    }

    [Token(Token = "0x6001819")]
    [Address(RVA = "0x696F70", Offset = "0x695D70", VA = "0x10696F70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      char value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600181A")]
    [Address(RVA = "0x696EF0", Offset = "0x695CF0", VA = "0x10696EF0", Slot = "5")]
    public char Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new char();
    }

    [Token(Token = "0x600181B")]
    [Address(RVA = "0x696FF0", Offset = "0x695DF0", VA = "0x10696FF0")]
    static CharFormatter()
    {
    }
  }
}
