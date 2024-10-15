// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRankingGuildFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000918")]
  public sealed class JSON_GuildRaidRankingGuildFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRankingGuild>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016C0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016C1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002496")]
    [Address(RVA = "0xDFE3F0", Offset = "0xDFD1F0", VA = "0x10DFE3F0")]
    public JSON_GuildRaidRankingGuildFormatter()
    {
    }

    [Token(Token = "0x6002497")]
    [Address(RVA = "0xDFE0C0", Offset = "0xDFCEC0", VA = "0x10DFE0C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRankingGuild value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002498")]
    [Address(RVA = "0xDFDBA0", Offset = "0xDFC9A0", VA = "0x10DFDBA0", Slot = "5")]
    public JSON_GuildRaidRankingGuild Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRankingGuild) null;
    }
  }
}
