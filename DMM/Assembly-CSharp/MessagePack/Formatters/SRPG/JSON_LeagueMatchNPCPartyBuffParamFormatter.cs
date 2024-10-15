// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchNPCPartyBuffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A96")]
  public sealed class JSON_LeagueMatchNPCPartyBuffParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchNPCPartyBuffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019BC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019BD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002910")]
    [Address(RVA = "0xEE2430", Offset = "0xEE1230", VA = "0x10EE2430")]
    public JSON_LeagueMatchNPCPartyBuffParamFormatter()
    {
    }

    [Token(Token = "0x6002911")]
    [Address(RVA = "0xEE2330", Offset = "0xEE1130", VA = "0x10EE2330", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchNPCPartyBuffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002912")]
    [Address(RVA = "0xEE2060", Offset = "0xEE0E60", VA = "0x10EE2060", Slot = "5")]
    public JSON_LeagueMatchNPCPartyBuffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchNPCPartyBuffParam) null;
    }
  }
}
