// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestRankingDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200070E")]
  public sealed class JSON_PointQuestRankingDataFormatter : 
    IMessagePackFormatter<JSON_PointQuestRankingData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012B4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012B5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E78")]
    [Address(RVA = "0xC58890", Offset = "0xC57690", VA = "0x10C58890")]
    public JSON_PointQuestRankingDataFormatter()
    {
    }

    [Token(Token = "0x6001E79")]
    [Address(RVA = "0xC584E0", Offset = "0xC572E0", VA = "0x10C584E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestRankingData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E7A")]
    [Address(RVA = "0xC57FF0", Offset = "0xC56DF0", VA = "0x10C57FF0", Slot = "5")]
    public JSON_PointQuestRankingData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestRankingData) null;
    }
  }
}
