// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchRewardDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000859")]
  public sealed class JSON_LeagueMatchRewardDataFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchRewardData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001542")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001543")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002259")]
    [Address(RVA = "0xD8D2B0", Offset = "0xD8C0B0", VA = "0x10D8D2B0")]
    public JSON_LeagueMatchRewardDataFormatter()
    {
    }

    [Token(Token = "0x600225A")]
    [Address(RVA = "0xD8D150", Offset = "0xD8BF50", VA = "0x10D8D150", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchRewardData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600225B")]
    [Address(RVA = "0xD8CE00", Offset = "0xD8BC00", VA = "0x10D8CE00", Slot = "5")]
    public JSON_LeagueMatchRewardData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchRewardData) null;
    }
  }
}
