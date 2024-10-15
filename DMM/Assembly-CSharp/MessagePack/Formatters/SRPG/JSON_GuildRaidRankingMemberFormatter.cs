// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRankingMemberFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008B6")]
  public sealed class JSON_GuildRaidRankingMemberFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRankingMember>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015FC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015FD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002370")]
    [Address(RVA = "0xDB3300", Offset = "0xDB2100", VA = "0x10DB3300")]
    public JSON_GuildRaidRankingMemberFormatter()
    {
    }

    [Token(Token = "0x6002371")]
    [Address(RVA = "0xDB2FB0", Offset = "0xDB1DB0", VA = "0x10DB2FB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRankingMember value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002372")]
    [Address(RVA = "0xDB2AF0", Offset = "0xDB18F0", VA = "0x10DB2AF0", Slot = "5")]
    public JSON_GuildRaidRankingMember Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRankingMember) null;
    }
  }
}
