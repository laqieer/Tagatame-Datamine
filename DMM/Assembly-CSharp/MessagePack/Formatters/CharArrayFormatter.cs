// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.CharArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004FC")]
  public sealed class CharArrayFormatter : IMessagePackFormatter<char[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F8B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly CharArrayFormatter Instance;

    [Token(Token = "0x6001820")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private CharArrayFormatter()
    {
    }

    [Token(Token = "0x6001821")]
    [Address(RVA = "0x696D30", Offset = "0x695B30", VA = "0x10696D30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      char[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001822")]
    [Address(RVA = "0x696BD0", Offset = "0x6959D0", VA = "0x10696BD0", Slot = "5")]
    public char[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (char[]) null;
    }

    [Token(Token = "0x6001823")]
    [Address(RVA = "0x696E90", Offset = "0x695C90", VA = "0x10696E90")]
    static CharArrayFormatter()
    {
    }
  }
}
