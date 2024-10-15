// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchHistoryFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200082E")]
  public sealed class JSON_LeagueMatchHistoryFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchHistory>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014EC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014ED")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021D8")]
    [Address(RVA = "0xD6FDD0", Offset = "0xD6EBD0", VA = "0x10D6FDD0")]
    public JSON_LeagueMatchHistoryFormatter()
    {
    }

    [Token(Token = "0x60021D9")]
    [Address(RVA = "0xD6F850", Offset = "0xD6E650", VA = "0x10D6F850", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchHistory value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021DA")]
    [Address(RVA = "0xD6F1B0", Offset = "0xD6DFB0", VA = "0x10D6F1B0", Slot = "5")]
    public JSON_LeagueMatchHistory Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchHistory) null;
    }
  }
}
