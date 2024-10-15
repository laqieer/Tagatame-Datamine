// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchOffenseinfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000811")]
  public sealed class JSON_LeagueMatchOffenseinfoFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchOffenseinfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014B2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014B3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002181")]
    [Address(RVA = "0xD46AD0", Offset = "0xD458D0", VA = "0x10D46AD0")]
    public JSON_LeagueMatchOffenseinfoFormatter()
    {
    }

    [Token(Token = "0x6002182")]
    [Address(RVA = "0xD46900", Offset = "0xD45700", VA = "0x10D46900", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchOffenseinfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002183")]
    [Address(RVA = "0xD46550", Offset = "0xD45350", VA = "0x10D46550", Slot = "5")]
    public JSON_LeagueMatchOffenseinfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchOffenseinfo) null;
    }
  }
}
