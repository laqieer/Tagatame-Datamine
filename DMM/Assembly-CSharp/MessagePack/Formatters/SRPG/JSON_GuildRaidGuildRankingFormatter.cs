// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidGuildRankingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A68")]
  public sealed class JSON_GuildRaidGuildRankingFormatter : 
    IMessagePackFormatter<JSON_GuildRaidGuildRanking>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001960")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001961")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002886")]
    [Address(RVA = "0xEC8110", Offset = "0xEC6F10", VA = "0x10EC8110")]
    public JSON_GuildRaidGuildRankingFormatter()
    {
    }

    [Token(Token = "0x6002887")]
    [Address(RVA = "0xEC7EE0", Offset = "0xEC6CE0", VA = "0x10EC7EE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidGuildRanking value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002888")]
    [Address(RVA = "0xEC7BA0", Offset = "0xEC69A0", VA = "0x10EC7BA0", Slot = "5")]
    public JSON_GuildRaidGuildRanking Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidGuildRanking) null;
    }
  }
}
