// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRewardRankingDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009BD")]
  public sealed class JSON_GuildRaidRewardRankingDataParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRewardRankingDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400180A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400180B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002685")]
    [Address(RVA = "0xE6FEE0", Offset = "0xE6ECE0", VA = "0x10E6FEE0")]
    public JSON_GuildRaidRewardRankingDataParamFormatter()
    {
    }

    [Token(Token = "0x6002686")]
    [Address(RVA = "0xE6FD80", Offset = "0xE6EB80", VA = "0x10E6FD80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRewardRankingDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002687")]
    [Address(RVA = "0xE6FA30", Offset = "0xE6E830", VA = "0x10E6FA30", Slot = "5")]
    public JSON_GuildRaidRewardRankingDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRewardRankingDataParam) null;
    }
  }
}
