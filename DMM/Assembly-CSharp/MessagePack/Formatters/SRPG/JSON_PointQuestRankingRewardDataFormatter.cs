// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestRankingRewardDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A94")]
  public sealed class JSON_PointQuestRankingRewardDataFormatter : 
    IMessagePackFormatter<JSON_PointQuestRankingRewardData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019B8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019B9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600290A")]
    [Address(RVA = "0xEE59C0", Offset = "0xEE47C0", VA = "0x10EE59C0")]
    public JSON_PointQuestRankingRewardDataFormatter()
    {
    }

    [Token(Token = "0x600290B")]
    [Address(RVA = "0xEE5890", Offset = "0xEE4690", VA = "0x10EE5890", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestRankingRewardData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600290C")]
    [Address(RVA = "0xEE5580", Offset = "0xEE4380", VA = "0x10EE5580", Slot = "5")]
    public JSON_PointQuestRankingRewardData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestRankingRewardData) null;
    }
  }
}
