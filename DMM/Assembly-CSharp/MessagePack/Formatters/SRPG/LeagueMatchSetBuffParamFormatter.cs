// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchSetBuffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200092E")]
  public sealed class LeagueMatchSetBuffParamFormatter : 
    IMessagePackFormatter<LeagueMatchSetBuffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016EC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016ED")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024D8")]
    [Address(RVA = "0xE02B50", Offset = "0xE01950", VA = "0x10E02B50")]
    public LeagueMatchSetBuffParamFormatter()
    {
    }

    [Token(Token = "0x60024D9")]
    [Address(RVA = "0xE027D0", Offset = "0xE015D0", VA = "0x10E027D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchSetBuffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024DA")]
    [Address(RVA = "0xE023F0", Offset = "0xE011F0", VA = "0x10E023F0", Slot = "5")]
    public LeagueMatchSetBuffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchSetBuffParam) null;
    }
  }
}
