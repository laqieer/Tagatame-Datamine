// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchDefenseEntryFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000857")]
  public sealed class JSON_LeagueMatchDefenseEntryFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchDefenseEntry>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400153E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400153F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002253")]
    [Address(RVA = "0xD8C560", Offset = "0xD8B360", VA = "0x10D8C560")]
    public JSON_LeagueMatchDefenseEntryFormatter()
    {
    }

    [Token(Token = "0x6002254")]
    [Address(RVA = "0xD8C1F0", Offset = "0xD8AFF0", VA = "0x10D8C1F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchDefenseEntry value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002255")]
    [Address(RVA = "0xD8BDB0", Offset = "0xD8ABB0", VA = "0x10D8BDB0", Slot = "5")]
    public JSON_LeagueMatchDefenseEntry Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchDefenseEntry) null;
    }
  }
}
