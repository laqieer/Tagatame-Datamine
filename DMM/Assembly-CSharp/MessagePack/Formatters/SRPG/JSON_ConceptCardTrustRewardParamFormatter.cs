// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptCardTrustRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000614")]
  public sealed class JSON_ConceptCardTrustRewardParamFormatter : 
    IMessagePackFormatter<JSON_ConceptCardTrustRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010C0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010C1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B8A")]
    [Address(RVA = "0xBBA5F0", Offset = "0xBB93F0", VA = "0x10BBA5F0")]
    public JSON_ConceptCardTrustRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001B8B")]
    [Address(RVA = "0xBBA410", Offset = "0xBB9210", VA = "0x10BBA410", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptCardTrustRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B8C")]
    [Address(RVA = "0xBBA0D0", Offset = "0xBB8ED0", VA = "0x10BBA0D0", Slot = "5")]
    public JSON_ConceptCardTrustRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptCardTrustRewardParam) null;
    }
  }
}
