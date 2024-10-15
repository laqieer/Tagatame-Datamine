// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchRewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000833")]
  public sealed class JSON_LeagueMatchRewardFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchReward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014F6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014F7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021E7")]
    [Address(RVA = "0xD71B60", Offset = "0xD70960", VA = "0x10D71B60")]
    public JSON_LeagueMatchRewardFormatter()
    {
    }

    [Token(Token = "0x60021E8")]
    [Address(RVA = "0xD71A00", Offset = "0xD70800", VA = "0x10D71A00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchReward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021E9")]
    [Address(RVA = "0xD716B0", Offset = "0xD704B0", VA = "0x10D716B0", Slot = "5")]
    public JSON_LeagueMatchReward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchReward) null;
    }
  }
}
