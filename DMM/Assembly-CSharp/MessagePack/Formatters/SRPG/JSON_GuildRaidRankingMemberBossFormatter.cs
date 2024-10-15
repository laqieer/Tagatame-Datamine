// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRankingMemberBossFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008B5")]
  public sealed class JSON_GuildRaidRankingMemberBossFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRankingMemberBoss>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015FA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015FB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600236D")]
    [Address(RVA = "0xDB2970", Offset = "0xDB1770", VA = "0x10DB2970")]
    public JSON_GuildRaidRankingMemberBossFormatter()
    {
    }

    [Token(Token = "0x600236E")]
    [Address(RVA = "0xDB2870", Offset = "0xDB1670", VA = "0x10DB2870", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRankingMemberBoss value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600236F")]
    [Address(RVA = "0xDB2590", Offset = "0xDB1390", VA = "0x10DB2590", Slot = "5")]
    public JSON_GuildRaidRankingMemberBoss Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRankingMemberBoss) null;
    }
  }
}
