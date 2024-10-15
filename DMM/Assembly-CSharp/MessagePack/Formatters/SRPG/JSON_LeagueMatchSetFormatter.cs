// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchSetFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007D9")]
  public sealed class JSON_LeagueMatchSetFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchSet>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001442")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001443")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020D9")]
    [Address(RVA = "0xD19E80", Offset = "0xD18C80", VA = "0x10D19E80")]
    public JSON_LeagueMatchSetFormatter()
    {
    }

    [Token(Token = "0x60020DA")]
    [Address(RVA = "0xD19D80", Offset = "0xD18B80", VA = "0x10D19D80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchSet value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020DB")]
    [Address(RVA = "0xD19A80", Offset = "0xD18880", VA = "0x10D19A80", Slot = "5")]
    public JSON_LeagueMatchSet Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchSet) null;
    }
  }
}
