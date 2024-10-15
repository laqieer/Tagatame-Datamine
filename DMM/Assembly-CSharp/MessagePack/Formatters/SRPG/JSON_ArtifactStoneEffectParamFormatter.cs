// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ArtifactStoneEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000700")]
  public sealed class JSON_ArtifactStoneEffectParamFormatter : 
    IMessagePackFormatter<JSON_ArtifactStoneEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001298")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001299")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E4E")]
    [Address(RVA = "0xC23B90", Offset = "0xC22990", VA = "0x10C23B90")]
    public JSON_ArtifactStoneEffectParamFormatter()
    {
    }

    [Token(Token = "0x6001E4F")]
    [Address(RVA = "0xC23880", Offset = "0xC22680", VA = "0x10C23880", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ArtifactStoneEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E50")]
    [Address(RVA = "0xC233C0", Offset = "0xC221C0", VA = "0x10C233C0", Slot = "5")]
    public JSON_ArtifactStoneEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ArtifactStoneEffectParam) null;
    }
  }
}
