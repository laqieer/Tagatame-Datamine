// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchDefensePartyFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007DB")]
  public sealed class JSON_LeagueMatchDefensePartyFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchDefenseParty>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001446")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001447")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020DF")]
    [Address(RVA = "0xD197B0", Offset = "0xD185B0", VA = "0x10D197B0")]
    public JSON_LeagueMatchDefensePartyFormatter()
    {
    }

    [Token(Token = "0x60020E0")]
    [Address(RVA = "0xD19400", Offset = "0xD18200", VA = "0x10D19400", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchDefenseParty value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020E1")]
    [Address(RVA = "0xD18FC0", Offset = "0xD17DC0", VA = "0x10D18FC0", Slot = "5")]
    public JSON_LeagueMatchDefenseParty Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchDefenseParty) null;
    }
  }
}
