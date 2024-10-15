// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestGuildRankingDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200070F")]
  public sealed class JSON_PointQuestGuildRankingDataFormatter : 
    IMessagePackFormatter<JSON_PointQuestGuildRankingData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012B6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012B7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E7B")]
    [Address(RVA = "0xC56490", Offset = "0xC55290", VA = "0x10C56490")]
    public JSON_PointQuestGuildRankingDataFormatter()
    {
    }

    [Token(Token = "0x6001E7C")]
    [Address(RVA = "0xC56200", Offset = "0xC55000", VA = "0x10C56200", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestGuildRankingData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E7D")]
    [Address(RVA = "0xC55DA0", Offset = "0xC54BA0", VA = "0x10C55DA0", Slot = "5")]
    public JSON_PointQuestGuildRankingData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestGuildRankingData) null;
    }
  }
}
