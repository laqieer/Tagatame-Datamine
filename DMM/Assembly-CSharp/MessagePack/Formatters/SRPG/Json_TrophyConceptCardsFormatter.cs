// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_TrophyConceptCardsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200087C")]
  public sealed class Json_TrophyConceptCardsFormatter : 
    IMessagePackFormatter<Json_TrophyConceptCards>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001588")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001589")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022C2")]
    [Address(RVA = "0xDA7A80", Offset = "0xDA6880", VA = "0x10DA7A80")]
    public Json_TrophyConceptCardsFormatter()
    {
    }

    [Token(Token = "0x60022C3")]
    [Address(RVA = "0xDA7930", Offset = "0xDA6730", VA = "0x10DA7930", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_TrophyConceptCards value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022C4")]
    [Address(RVA = "0xDA7600", Offset = "0xDA6400", VA = "0x10DA7600", Slot = "5")]
    public Json_TrophyConceptCards Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_TrophyConceptCards) null;
    }
  }
}
