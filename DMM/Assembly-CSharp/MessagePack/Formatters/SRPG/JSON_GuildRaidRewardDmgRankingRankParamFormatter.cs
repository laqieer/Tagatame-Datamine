// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRewardDmgRankingRankParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000980")]
  public sealed class JSON_GuildRaidRewardDmgRankingRankParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRewardDmgRankingRankParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001790")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001791")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025CE")]
    [Address(RVA = "0xE29DC0", Offset = "0xE28BC0", VA = "0x10E29DC0")]
    public JSON_GuildRaidRewardDmgRankingRankParamFormatter()
    {
    }

    [Token(Token = "0x60025CF")]
    [Address(RVA = "0xE29C60", Offset = "0xE28A60", VA = "0x10E29C60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRewardDmgRankingRankParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025D0")]
    [Address(RVA = "0xE29910", Offset = "0xE28710", VA = "0x10E29910", Slot = "5")]
    public JSON_GuildRaidRewardDmgRankingRankParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRewardDmgRankingRankParam) null;
    }
  }
}
