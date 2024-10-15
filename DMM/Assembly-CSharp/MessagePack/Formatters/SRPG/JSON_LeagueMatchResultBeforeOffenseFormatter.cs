// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchResultBeforeOffenseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000815")]
  public sealed class JSON_LeagueMatchResultBeforeOffenseFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchResultBeforeOffense>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014BA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014BB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600218D")]
    [Address(RVA = "0xD48BF0", Offset = "0xD479F0", VA = "0x10D48BF0")]
    public JSON_LeagueMatchResultBeforeOffenseFormatter()
    {
    }

    [Token(Token = "0x600218E")]
    [Address(RVA = "0xD48AC0", Offset = "0xD478C0", VA = "0x10D48AC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchResultBeforeOffense value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600218F")]
    [Address(RVA = "0xD487B0", Offset = "0xD475B0", VA = "0x10D487B0", Slot = "5")]
    public JSON_LeagueMatchResultBeforeOffense Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchResultBeforeOffense) null;
    }
  }
}
