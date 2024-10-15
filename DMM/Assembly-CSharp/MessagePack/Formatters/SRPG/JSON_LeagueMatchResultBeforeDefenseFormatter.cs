// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchResultBeforeDefenseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000816")]
  public sealed class JSON_LeagueMatchResultBeforeDefenseFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchResultBeforeDefense>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014BC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014BD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002190")]
    [Address(RVA = "0xD47D80", Offset = "0xD46B80", VA = "0x10D47D80")]
    public JSON_LeagueMatchResultBeforeDefenseFormatter()
    {
    }

    [Token(Token = "0x6002191")]
    [Address(RVA = "0xD47C80", Offset = "0xD46A80", VA = "0x10D47C80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchResultBeforeDefense value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002192")]
    [Address(RVA = "0xD479A0", Offset = "0xD467A0", VA = "0x10D479A0", Slot = "5")]
    public JSON_LeagueMatchResultBeforeDefense Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchResultBeforeDefense) null;
    }
  }
}
