// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ConceptCardExtraRarityParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200097C")]
  public sealed class ConceptCardExtraRarityParamFormatter : 
    IMessagePackFormatter<ConceptCardExtraRarityParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001788")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001789")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025C2")]
    [Address(RVA = "0xE25E40", Offset = "0xE24C40", VA = "0x10E25E40")]
    public ConceptCardExtraRarityParamFormatter()
    {
    }

    [Token(Token = "0x60025C3")]
    [Address(RVA = "0xE25DD0", Offset = "0xE24BD0", VA = "0x10E25DD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ConceptCardExtraRarityParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025C4")]
    [Address(RVA = "0xE25B60", Offset = "0xE24960", VA = "0x10E25B60", Slot = "5")]
    public ConceptCardExtraRarityParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ConceptCardExtraRarityParam) null;
    }
  }
}
