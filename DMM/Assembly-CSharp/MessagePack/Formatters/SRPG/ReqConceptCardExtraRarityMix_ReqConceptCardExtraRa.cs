// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqConceptCardExtraRarityMix_ReqConceptCardExtraRarityMixResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009FB")]
  public sealed class ReqConceptCardExtraRarityMix_ReqConceptCardExtraRarityMixResponseFormatter : 
    IMessagePackFormatter<ReqConceptCardExtraRarityMix.ReqConceptCardExtraRarityMixResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001886")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001887")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600273F")]
    [Address(RVA = "0xE8B470", Offset = "0xE8A270", VA = "0x10E8B470")]
    public ReqConceptCardExtraRarityMix_ReqConceptCardExtraRarityMixResponseFormatter()
    {
    }

    [Token(Token = "0x6002740")]
    [Address(RVA = "0xE8B180", Offset = "0xE89F80", VA = "0x10E8B180", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqConceptCardExtraRarityMix.ReqConceptCardExtraRarityMixResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002741")]
    [Address(RVA = "0xE8AD50", Offset = "0xE89B50", VA = "0x10E8AD50", Slot = "5")]
    public ReqConceptCardExtraRarityMix.ReqConceptCardExtraRarityMixResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqConceptCardExtraRarityMix.ReqConceptCardExtraRarityMixResponse) null;
    }
  }
}
