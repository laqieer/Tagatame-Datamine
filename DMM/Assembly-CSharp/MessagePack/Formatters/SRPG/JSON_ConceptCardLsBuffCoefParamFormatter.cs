// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptCardLsBuffCoefParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000615")]
  public sealed class JSON_ConceptCardLsBuffCoefParamFormatter : 
    IMessagePackFormatter<JSON_ConceptCardLsBuffCoefParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010C2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010C3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B8D")]
    [Address(RVA = "0xBB7760", Offset = "0xBB6560", VA = "0x10BB7760")]
    public JSON_ConceptCardLsBuffCoefParamFormatter()
    {
    }

    [Token(Token = "0x6001B8E")]
    [Address(RVA = "0xBB75D0", Offset = "0xBB63D0", VA = "0x10BB75D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptCardLsBuffCoefParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B8F")]
    [Address(RVA = "0xBB7260", Offset = "0xBB6060", VA = "0x10BB7260", Slot = "5")]
    public JSON_ConceptCardLsBuffCoefParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptCardLsBuffCoefParam) null;
    }
  }
}
