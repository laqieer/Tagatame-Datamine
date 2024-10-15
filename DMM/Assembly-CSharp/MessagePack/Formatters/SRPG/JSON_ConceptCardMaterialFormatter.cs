// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptCardMaterialFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ABB")]
  public sealed class JSON_ConceptCardMaterialFormatter : 
    IMessagePackFormatter<JSON_ConceptCardMaterial>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A06")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A07")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600297F")]
    [Address(RVA = "0xF0DDD0", Offset = "0xF0CBD0", VA = "0x10F0DDD0")]
    public JSON_ConceptCardMaterialFormatter()
    {
    }

    [Token(Token = "0x6002980")]
    [Address(RVA = "0xF0DC60", Offset = "0xF0CA60", VA = "0x10F0DC60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptCardMaterial value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002981")]
    [Address(RVA = "0xF0D8F0", Offset = "0xF0C6F0", VA = "0x10F0D8F0", Slot = "5")]
    public JSON_ConceptCardMaterial Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptCardMaterial) null;
    }
  }
}
