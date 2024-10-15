// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRewardRankingParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009BE")]
  public sealed class JSON_GuildRaidRewardRankingParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRewardRankingParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400180C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400180D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002688")]
    [Address(RVA = "0xE705F0", Offset = "0xE6F3F0", VA = "0x10E705F0")]
    public JSON_GuildRaidRewardRankingParamFormatter()
    {
    }

    [Token(Token = "0x6002689")]
    [Address(RVA = "0xE70410", Offset = "0xE6F210", VA = "0x10E70410", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRewardRankingParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600268A")]
    [Address(RVA = "0xE700D0", Offset = "0xE6EED0", VA = "0x10E700D0", Slot = "5")]
    public JSON_GuildRaidRewardRankingParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRewardRankingParam) null;
    }
  }
}
