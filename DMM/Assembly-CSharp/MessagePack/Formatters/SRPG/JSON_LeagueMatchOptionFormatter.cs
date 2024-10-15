// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchOptionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200083B")]
  public sealed class JSON_LeagueMatchOptionFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchOption>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001506")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001507")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021FF")]
    [Address(RVA = "0xD707C0", Offset = "0xD6F5C0", VA = "0x10D707C0")]
    public JSON_LeagueMatchOptionFormatter()
    {
    }

    [Token(Token = "0x6002200")]
    [Address(RVA = "0xD70700", Offset = "0xD6F500", VA = "0x10D70700", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchOption value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002201")]
    [Address(RVA = "0xD70460", Offset = "0xD6F260", VA = "0x10D70460", Slot = "5")]
    public JSON_LeagueMatchOption Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchOption) null;
    }
  }
}
