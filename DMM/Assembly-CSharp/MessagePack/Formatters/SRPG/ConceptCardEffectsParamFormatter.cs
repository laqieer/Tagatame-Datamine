// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ConceptCardEffectsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000778")]
  public sealed class ConceptCardEffectsParamFormatter : 
    IMessagePackFormatter<ConceptCardEffectsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001388")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001389")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FB6")]
    [Address(RVA = "0xCC8580", Offset = "0xCC7380", VA = "0x10CC8580")]
    public ConceptCardEffectsParamFormatter()
    {
    }

    [Token(Token = "0x6001FB7")]
    [Address(RVA = "0xCC81C0", Offset = "0xCC6FC0", VA = "0x10CC81C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ConceptCardEffectsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FB8")]
    [Address(RVA = "0xCC7C70", Offset = "0xCC6A70", VA = "0x10CC7C70", Slot = "5")]
    public ConceptCardEffectsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ConceptCardEffectsParam) null;
    }
  }
}
