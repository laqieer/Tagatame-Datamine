// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ConceptCardExtraRarityEffectFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200097B")]
  public sealed class ConceptCardExtraRarityEffectFormatter : 
    IMessagePackFormatter<ConceptCardExtraRarityEffect>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001786")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001787")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025BF")]
    [Address(RVA = "0xE25AD0", Offset = "0xE248D0", VA = "0x10E25AD0")]
    public ConceptCardExtraRarityEffectFormatter()
    {
    }

    [Token(Token = "0x60025C0")]
    [Address(RVA = "0xE25A60", Offset = "0xE24860", VA = "0x10E25A60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ConceptCardExtraRarityEffect value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025C1")]
    [Address(RVA = "0xE257F0", Offset = "0xE245F0", VA = "0x10E257F0", Slot = "5")]
    public ConceptCardExtraRarityEffect Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ConceptCardExtraRarityEffect) null;
    }
  }
}
