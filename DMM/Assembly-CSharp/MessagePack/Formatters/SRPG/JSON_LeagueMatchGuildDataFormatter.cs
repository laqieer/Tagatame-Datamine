// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchGuildDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000830")]
  public sealed class JSON_LeagueMatchGuildDataFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchGuildData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014F0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014F1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021DE")]
    [Address(RVA = "0xD6F030", Offset = "0xD6DE30", VA = "0x10D6F030")]
    public JSON_LeagueMatchGuildDataFormatter()
    {
    }

    [Token(Token = "0x60021DF")]
    [Address(RVA = "0xD6EF00", Offset = "0xD6DD00", VA = "0x10D6EF00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchGuildData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021E0")]
    [Address(RVA = "0xD6EBF0", Offset = "0xD6D9F0", VA = "0x10D6EBF0", Slot = "5")]
    public JSON_LeagueMatchGuildData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchGuildData) null;
    }
  }
}
