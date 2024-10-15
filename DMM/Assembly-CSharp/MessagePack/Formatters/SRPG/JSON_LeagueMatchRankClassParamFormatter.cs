// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchRankClassParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006F4")]
  public sealed class JSON_LeagueMatchRankClassParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchRankClassParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001280")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001281")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E2A")]
    [Address(RVA = "0xC29FE0", Offset = "0xC28DE0", VA = "0x10C29FE0")]
    public JSON_LeagueMatchRankClassParamFormatter()
    {
    }

    [Token(Token = "0x6001E2B")]
    [Address(RVA = "0xC29CA0", Offset = "0xC28AA0", VA = "0x10C29CA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchRankClassParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E2C")]
    [Address(RVA = "0xC29780", Offset = "0xC28580", VA = "0x10C29780", Slot = "5")]
    public JSON_LeagueMatchRankClassParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchRankClassParam) null;
    }
  }
}
