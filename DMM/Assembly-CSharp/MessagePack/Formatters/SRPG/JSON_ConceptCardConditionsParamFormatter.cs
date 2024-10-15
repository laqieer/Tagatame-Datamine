// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptCardConditionsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000612")]
  public sealed class JSON_ConceptCardConditionsParamFormatter : 
    IMessagePackFormatter<JSON_ConceptCardConditionsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010BC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010BD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B84")]
    [Address(RVA = "0xBB57C0", Offset = "0xBB45C0", VA = "0x10BB57C0")]
    public JSON_ConceptCardConditionsParamFormatter()
    {
    }

    [Token(Token = "0x6001B85")]
    [Address(RVA = "0xBB53B0", Offset = "0xBB41B0", VA = "0x10BB53B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptCardConditionsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B86")]
    [Address(RVA = "0xBB4DC0", Offset = "0xBB3BC0", VA = "0x10BB4DC0", Slot = "5")]
    public JSON_ConceptCardConditionsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptCardConditionsParam) null;
    }
  }
}
