// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchSeasonParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006F9")]
  public sealed class JSON_LeagueMatchSeasonParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchSeasonParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400128A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400128B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E39")]
    [Address(RVA = "0xC2C420", Offset = "0xC2B220", VA = "0x10C2C420")]
    public JSON_LeagueMatchSeasonParamFormatter()
    {
    }

    [Token(Token = "0x6001E3A")]
    [Address(RVA = "0xC2BEE0", Offset = "0xC2ACE0", VA = "0x10C2BEE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchSeasonParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E3B")]
    [Address(RVA = "0xC2B8A0", Offset = "0xC2A6A0", VA = "0x10C2B8A0", Slot = "5")]
    public JSON_LeagueMatchSeasonParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchSeasonParam) null;
    }
  }
}
