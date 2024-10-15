// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptCardExtraRarityEffectFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000702")]
  public sealed class JSON_ConceptCardExtraRarityEffectFormatter : 
    IMessagePackFormatter<JSON_ConceptCardExtraRarityEffect>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400129C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400129D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E54")]
    [Address(RVA = "0xC24470", Offset = "0xC23270", VA = "0x10C24470")]
    public JSON_ConceptCardExtraRarityEffectFormatter()
    {
    }

    [Token(Token = "0x6001E55")]
    [Address(RVA = "0xC242C0", Offset = "0xC230C0", VA = "0x10C242C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptCardExtraRarityEffect value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E56")]
    [Address(RVA = "0xC23F30", Offset = "0xC22D30", VA = "0x10C23F30", Slot = "5")]
    public JSON_ConceptCardExtraRarityEffect Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptCardExtraRarityEffect) null;
    }
  }
}
