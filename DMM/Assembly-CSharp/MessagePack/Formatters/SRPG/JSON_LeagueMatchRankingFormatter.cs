// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchRankingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000831")]
  public sealed class JSON_LeagueMatchRankingFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchRanking>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014F2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014F3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021E1")]
    [Address(RVA = "0xD71230", Offset = "0xD70030", VA = "0x10D71230")]
    public JSON_LeagueMatchRankingFormatter()
    {
    }

    [Token(Token = "0x60021E2")]
    [Address(RVA = "0xD70E30", Offset = "0xD6FC30", VA = "0x10D70E30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchRanking value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021E3")]
    [Address(RVA = "0xD708E0", Offset = "0xD6F6E0", VA = "0x10D708E0", Slot = "5")]
    public JSON_LeagueMatchRanking Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchRanking) null;
    }
  }
}
