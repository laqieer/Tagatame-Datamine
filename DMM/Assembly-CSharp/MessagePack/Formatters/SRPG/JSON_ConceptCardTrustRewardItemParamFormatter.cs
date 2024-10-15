// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptCardTrustRewardItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000613")]
  public sealed class JSON_ConceptCardTrustRewardItemParamFormatter : 
    IMessagePackFormatter<JSON_ConceptCardTrustRewardItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010BE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010BF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B87")]
    [Address(RVA = "0xBB9EE0", Offset = "0xBB8CE0", VA = "0x10BB9EE0")]
    public JSON_ConceptCardTrustRewardItemParamFormatter()
    {
    }

    [Token(Token = "0x6001B88")]
    [Address(RVA = "0xBB9D80", Offset = "0xBB8B80", VA = "0x10BB9D80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptCardTrustRewardItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B89")]
    [Address(RVA = "0xBB9A30", Offset = "0xBB8830", VA = "0x10BB9A30", Slot = "5")]
    public JSON_ConceptCardTrustRewardItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptCardTrustRewardItemParam) null;
    }
  }
}
