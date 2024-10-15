// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptCardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000611")]
  public sealed class JSON_ConceptCardParamFormatter : 
    IMessagePackFormatter<JSON_ConceptCardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010BA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010BB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B81")]
    [Address(RVA = "0xBB8D70", Offset = "0xBB7B70", VA = "0x10BB8D70")]
    public JSON_ConceptCardParamFormatter()
    {
    }

    [Token(Token = "0x6001B82")]
    [Address(RVA = "0xBB83C0", Offset = "0xBB71C0", VA = "0x10BB83C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptCardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B83")]
    [Address(RVA = "0xBB7950", Offset = "0xBB6750", VA = "0x10BB7950", Slot = "5")]
    public JSON_ConceptCardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptCardParam) null;
    }
  }
}
