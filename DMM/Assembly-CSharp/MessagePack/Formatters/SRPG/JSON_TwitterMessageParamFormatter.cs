// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TwitterMessageParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000669")]
  public sealed class JSON_TwitterMessageParamFormatter : 
    IMessagePackFormatter<JSON_TwitterMessageParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400116A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400116B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C89")]
    [Address(RVA = "0xBF1860", Offset = "0xBF0660", VA = "0x10BF1860")]
    public JSON_TwitterMessageParamFormatter()
    {
    }

    [Token(Token = "0x6001C8A")]
    [Address(RVA = "0xBF16C0", Offset = "0xBF04C0", VA = "0x10BF16C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TwitterMessageParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C8B")]
    [Address(RVA = "0xBF13B0", Offset = "0xBF01B0", VA = "0x10BF13B0", Slot = "5")]
    public JSON_TwitterMessageParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TwitterMessageParam) null;
    }
  }
}
