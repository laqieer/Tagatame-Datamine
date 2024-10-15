// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchSeasonRewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000835")]
  public sealed class JSON_LeagueMatchSeasonRewardFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchSeasonReward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014FA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014FB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021ED")]
    [Address(RVA = "0xD72200", Offset = "0xD71000", VA = "0x10D72200")]
    public JSON_LeagueMatchSeasonRewardFormatter()
    {
    }

    [Token(Token = "0x60021EE")]
    [Address(RVA = "0xD720A0", Offset = "0xD70EA0", VA = "0x10D720A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchSeasonReward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021EF")]
    [Address(RVA = "0xD71D50", Offset = "0xD70B50", VA = "0x10D71D50", Slot = "5")]
    public JSON_LeagueMatchSeasonReward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchSeasonReward) null;
    }
  }
}
