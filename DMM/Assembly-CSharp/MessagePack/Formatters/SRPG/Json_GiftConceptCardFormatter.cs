// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_GiftConceptCardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000897")]
  public sealed class Json_GiftConceptCardFormatter : 
    IMessagePackFormatter<Json_GiftConceptCard>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015BE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015BF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002313")]
    [Address(RVA = "0xDA48E0", Offset = "0xDA36E0", VA = "0x10DA48E0")]
    public Json_GiftConceptCardFormatter()
    {
    }

    [Token(Token = "0x6002314")]
    [Address(RVA = "0xDA4720", Offset = "0xDA3520", VA = "0x10DA4720", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_GiftConceptCard value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002315")]
    [Address(RVA = "0xDA4390", Offset = "0xDA3190", VA = "0x10DA4390", Slot = "5")]
    public Json_GiftConceptCard Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_GiftConceptCard) null;
    }
  }
}
