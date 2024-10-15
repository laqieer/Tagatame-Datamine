// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FilterConceptCardConditionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200066A")]
  public sealed class JSON_FilterConceptCardConditionParamFormatter : 
    IMessagePackFormatter<JSON_FilterConceptCardConditionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400116C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400116D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C8C")]
    [Address(RVA = "0xBE3F00", Offset = "0xBE2D00", VA = "0x10BE3F00")]
    public JSON_FilterConceptCardConditionParamFormatter()
    {
    }

    [Token(Token = "0x6001C8D")]
    [Address(RVA = "0xBE3CB0", Offset = "0xBE2AB0", VA = "0x10BE3CB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FilterConceptCardConditionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C8E")]
    [Address(RVA = "0xBE3890", Offset = "0xBE2690", VA = "0x10BE3890", Slot = "5")]
    public JSON_FilterConceptCardConditionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FilterConceptCardConditionParam) null;
    }
  }
}
