// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_TrophyConceptCardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200087B")]
  public sealed class Json_TrophyConceptCardFormatter : 
    IMessagePackFormatter<Json_TrophyConceptCard>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001586")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001587")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022BF")]
    [Address(RVA = "0xDA7480", Offset = "0xDA6280", VA = "0x10DA7480")]
    public Json_TrophyConceptCardFormatter()
    {
    }

    [Token(Token = "0x60022C0")]
    [Address(RVA = "0xDA7330", Offset = "0xDA6130", VA = "0x10DA7330", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_TrophyConceptCard value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022C1")]
    [Address(RVA = "0xDA7000", Offset = "0xDA5E00", VA = "0x10DA7000", Slot = "5")]
    public Json_TrophyConceptCard Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_TrophyConceptCard) null;
    }
  }
}
