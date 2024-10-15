// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FilterConceptCardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200066B")]
  public sealed class JSON_FilterConceptCardParamFormatter : 
    IMessagePackFormatter<JSON_FilterConceptCardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400116E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400116F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C8F")]
    [Address(RVA = "0xBE4910", Offset = "0xBE3710", VA = "0x10BE4910")]
    public JSON_FilterConceptCardParamFormatter()
    {
    }

    [Token(Token = "0x6001C90")]
    [Address(RVA = "0xBE4640", Offset = "0xBE3440", VA = "0x10BE4640", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FilterConceptCardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C91")]
    [Address(RVA = "0xBE4230", Offset = "0xBE3030", VA = "0x10BE4230", Slot = "5")]
    public JSON_FilterConceptCardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FilterConceptCardParam) null;
    }
  }
}
