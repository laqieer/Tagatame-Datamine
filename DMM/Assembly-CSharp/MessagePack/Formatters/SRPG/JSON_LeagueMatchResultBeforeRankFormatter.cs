// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchResultBeforeRankFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000817")]
  public sealed class JSON_LeagueMatchResultBeforeRankFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchResultBeforeRank>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014BE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014BF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002193")]
    [Address(RVA = "0xD49160", Offset = "0xD47F60", VA = "0x10D49160")]
    public JSON_LeagueMatchResultBeforeRankFormatter()
    {
    }

    [Token(Token = "0x6002194")]
    [Address(RVA = "0xD49060", Offset = "0xD47E60", VA = "0x10D49060", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchResultBeforeRank value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002195")]
    [Address(RVA = "0xD48D80", Offset = "0xD47B80", VA = "0x10D48D80", Slot = "5")]
    public JSON_LeagueMatchResultBeforeRank Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchResultBeforeRank) null;
    }
  }
}
