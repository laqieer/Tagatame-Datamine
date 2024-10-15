// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchEntryBuffsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000856")]
  public sealed class JSON_LeagueMatchEntryBuffsFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchEntryBuffs>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400153C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400153D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002250")]
    [Address(RVA = "0xD8CC70", Offset = "0xD8BA70", VA = "0x10D8CC70")]
    public JSON_LeagueMatchEntryBuffsFormatter()
    {
    }

    [Token(Token = "0x6002251")]
    [Address(RVA = "0xD8CB40", Offset = "0xD8B940", VA = "0x10D8CB40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchEntryBuffs value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002252")]
    [Address(RVA = "0xD8C830", Offset = "0xD8B630", VA = "0x10D8C830", Slot = "5")]
    public JSON_LeagueMatchEntryBuffs Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchEntryBuffs) null;
    }
  }
}
