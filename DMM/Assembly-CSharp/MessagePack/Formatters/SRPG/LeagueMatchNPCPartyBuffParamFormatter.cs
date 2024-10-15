// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchNPCPartyBuffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B24")]
  public sealed class LeagueMatchNPCPartyBuffParamFormatter : 
    IMessagePackFormatter<LeagueMatchNPCPartyBuffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AD8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AD9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002ABA")]
    [Address(RVA = "0xF3DFD0", Offset = "0xF3CDD0", VA = "0x10F3DFD0")]
    public LeagueMatchNPCPartyBuffParamFormatter()
    {
    }

    [Token(Token = "0x6002ABB")]
    [Address(RVA = "0xF3DED0", Offset = "0xF3CCD0", VA = "0x10F3DED0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchNPCPartyBuffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002ABC")]
    [Address(RVA = "0xF3DC10", Offset = "0xF3CA10", VA = "0x10F3DC10", Slot = "5")]
    public LeagueMatchNPCPartyBuffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchNPCPartyBuffParam) null;
    }
  }
}
