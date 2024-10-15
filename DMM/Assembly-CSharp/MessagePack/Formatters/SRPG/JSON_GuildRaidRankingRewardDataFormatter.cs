// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRankingRewardDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A67")]
  public sealed class JSON_GuildRaidRankingRewardDataFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRankingRewardData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400195E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400195F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002883")]
    [Address(RVA = "0xEC93F0", Offset = "0xEC81F0", VA = "0x10EC93F0")]
    public JSON_GuildRaidRankingRewardDataFormatter()
    {
    }

    [Token(Token = "0x6002884")]
    [Address(RVA = "0xEC9280", Offset = "0xEC8080", VA = "0x10EC9280", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRankingRewardData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002885")]
    [Address(RVA = "0xEC8F10", Offset = "0xEC7D10", VA = "0x10EC8F10", Slot = "5")]
    public JSON_GuildRaidRankingRewardData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRankingRewardData) null;
    }
  }
}
