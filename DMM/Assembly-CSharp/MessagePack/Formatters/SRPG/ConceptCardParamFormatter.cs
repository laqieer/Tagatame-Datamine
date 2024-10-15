// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ConceptCardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200077A")]
  public sealed class ConceptCardParamFormatter : 
    IMessagePackFormatter<ConceptCardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400138C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400138D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FBC")]
    [Address(RVA = "0xCCAB70", Offset = "0xCC9970", VA = "0x10CCAB70")]
    public ConceptCardParamFormatter()
    {
    }

    [Token(Token = "0x6001FBD")]
    [Address(RVA = "0xCCA110", Offset = "0xCC8F10", VA = "0x10CCA110", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ConceptCardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FBE")]
    [Address(RVA = "0xCC96E0", Offset = "0xCC84E0", VA = "0x10CC96E0", Slot = "5")]
    public ConceptCardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ConceptCardParam) null;
    }
  }
}
