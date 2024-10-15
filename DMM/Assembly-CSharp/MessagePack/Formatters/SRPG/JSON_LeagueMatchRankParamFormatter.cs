// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchRankParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006F5")]
  public sealed class JSON_LeagueMatchRankParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchRankParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001282")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001283")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E2D")]
    [Address(RVA = "0xC2A9E0", Offset = "0xC297E0", VA = "0x10C2A9E0")]
    public JSON_LeagueMatchRankParamFormatter()
    {
    }

    [Token(Token = "0x6001E2E")]
    [Address(RVA = "0xC2A800", Offset = "0xC29600", VA = "0x10C2A800", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchRankParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E2F")]
    [Address(RVA = "0xC2A4C0", Offset = "0xC292C0", VA = "0x10C2A4C0", Slot = "5")]
    public JSON_LeagueMatchRankParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchRankParam) null;
    }
  }
}
