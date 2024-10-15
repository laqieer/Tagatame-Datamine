// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchPresetPartyUnitsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000825")]
  public sealed class JSON_LeagueMatchPresetPartyUnitsFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchPresetPartyUnits>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014DA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014DB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021BD")]
    [Address(RVA = "0xD477B0", Offset = "0xD465B0", VA = "0x10D477B0")]
    public JSON_LeagueMatchPresetPartyUnitsFormatter()
    {
    }

    [Token(Token = "0x60021BE")]
    [Address(RVA = "0xD47610", Offset = "0xD46410", VA = "0x10D47610", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchPresetPartyUnits value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021BF")]
    [Address(RVA = "0xD47290", Offset = "0xD46090", VA = "0x10D47290", Slot = "5")]
    public JSON_LeagueMatchPresetPartyUnits Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchPresetPartyUnits) null;
    }
  }
}
