// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchDefenseRewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000834")]
  public sealed class JSON_LeagueMatchDefenseRewardFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchDefenseReward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014F8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014F9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021EA")]
    [Address(RVA = "0xD6EAD0", Offset = "0xD6D8D0", VA = "0x10D6EAD0")]
    public JSON_LeagueMatchDefenseRewardFormatter()
    {
    }

    [Token(Token = "0x60021EB")]
    [Address(RVA = "0xD6E9D0", Offset = "0xD6D7D0", VA = "0x10D6E9D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchDefenseReward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021EC")]
    [Address(RVA = "0xD6E700", Offset = "0xD6D500", VA = "0x10D6E700", Slot = "5")]
    public JSON_LeagueMatchDefenseReward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchDefenseReward) null;
    }
  }
}
