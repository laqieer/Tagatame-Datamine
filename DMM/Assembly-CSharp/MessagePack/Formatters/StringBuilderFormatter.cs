// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.StringBuilderFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200050B")]
  public sealed class StringBuilderFormatter : 
    IMessagePackFormatter<StringBuilder>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F9A")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<StringBuilder> Instance;

    [Token(Token = "0x600185C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private StringBuilderFormatter()
    {
    }

    [Token(Token = "0x600185D")]
    [Address(RVA = "0x6AB140", Offset = "0x6A9F40", VA = "0x106AB140", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      StringBuilder value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600185E")]
    [Address(RVA = "0x6AB080", Offset = "0x6A9E80", VA = "0x106AB080", Slot = "5")]
    public StringBuilder Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (StringBuilder) null;
    }

    [Token(Token = "0x600185F")]
    [Address(RVA = "0x6AB1D0", Offset = "0x6A9FD0", VA = "0x106AB1D0")]
    static StringBuilderFormatter()
    {
    }
  }
}
