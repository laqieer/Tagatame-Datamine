// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRewardDmgRankingParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000981")]
  public sealed class JSON_GuildRaidRewardDmgRankingParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRewardDmgRankingParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001792")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001793")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025D1")]
    [Address(RVA = "0xE29790", Offset = "0xE28590", VA = "0x10E29790")]
    public JSON_GuildRaidRewardDmgRankingParamFormatter()
    {
    }

    [Token(Token = "0x60025D2")]
    [Address(RVA = "0xE295B0", Offset = "0xE283B0", VA = "0x10E295B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRewardDmgRankingParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025D3")]
    [Address(RVA = "0xE29270", Offset = "0xE28070", VA = "0x10E29270", Slot = "5")]
    public JSON_GuildRaidRewardDmgRankingParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRewardDmgRankingParam) null;
    }
  }
}
