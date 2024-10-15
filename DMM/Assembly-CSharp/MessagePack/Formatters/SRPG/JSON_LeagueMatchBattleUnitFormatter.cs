// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchBattleUnitFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200082C")]
  public sealed class JSON_LeagueMatchBattleUnitFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchBattleUnit>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014E8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014E9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021D2")]
    [Address(RVA = "0xD6E4A0", Offset = "0xD6D2A0", VA = "0x10D6E4A0")]
    public JSON_LeagueMatchBattleUnitFormatter()
    {
    }

    [Token(Token = "0x60021D3")]
    [Address(RVA = "0xD6E250", Offset = "0xD6D050", VA = "0x10D6E250", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchBattleUnit value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021D4")]
    [Address(RVA = "0xD6DEB0", Offset = "0xD6CCB0", VA = "0x10D6DEB0", Slot = "5")]
    public JSON_LeagueMatchBattleUnit Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchBattleUnit) null;
    }
  }
}
