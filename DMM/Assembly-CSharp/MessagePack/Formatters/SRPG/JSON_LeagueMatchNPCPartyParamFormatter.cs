// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchNPCPartyParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A97")]
  public sealed class JSON_LeagueMatchNPCPartyParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchNPCPartyParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019BE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019BF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002913")]
    [Address(RVA = "0xEE2EF0", Offset = "0xEE1CF0", VA = "0x10EE2EF0")]
    public JSON_LeagueMatchNPCPartyParamFormatter()
    {
    }

    [Token(Token = "0x6002914")]
    [Address(RVA = "0xEE2AC0", Offset = "0xEE18C0", VA = "0x10EE2AC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchNPCPartyParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002915")]
    [Address(RVA = "0xEE2550", Offset = "0xEE1350", VA = "0x10EE2550", Slot = "5")]
    public JSON_LeagueMatchNPCPartyParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchNPCPartyParam) null;
    }
  }
}
