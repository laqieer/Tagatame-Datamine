// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptCardExtraRarityParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000703")]
  public sealed class JSON_ConceptCardExtraRarityParamFormatter : 
    IMessagePackFormatter<JSON_ConceptCardExtraRarityParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400129E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400129F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E57")]
    [Address(RVA = "0xC24B80", Offset = "0xC23980", VA = "0x10C24B80")]
    public JSON_ConceptCardExtraRarityParamFormatter()
    {
    }

    [Token(Token = "0x6001E58")]
    [Address(RVA = "0xC249A0", Offset = "0xC237A0", VA = "0x10C249A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptCardExtraRarityParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E59")]
    [Address(RVA = "0xC24660", Offset = "0xC23460", VA = "0x10C24660", Slot = "5")]
    public JSON_ConceptCardExtraRarityParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptCardExtraRarityParam) null;
    }
  }
}
