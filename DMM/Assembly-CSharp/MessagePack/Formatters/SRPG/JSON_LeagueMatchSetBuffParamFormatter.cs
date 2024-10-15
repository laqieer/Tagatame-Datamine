// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchSetBuffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006F0")]
  public sealed class JSON_LeagueMatchSetBuffParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchSetBuffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001278")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001279")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E1E")]
    [Address(RVA = "0xC2D100", Offset = "0xC2BF00", VA = "0x10C2D100")]
    public JSON_LeagueMatchSetBuffParamFormatter()
    {
    }

    [Token(Token = "0x6001E1F")]
    [Address(RVA = "0xC2CE50", Offset = "0xC2BC50", VA = "0x10C2CE50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchSetBuffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E20")]
    [Address(RVA = "0xC2C9E0", Offset = "0xC2B7E0", VA = "0x10C2C9E0", Slot = "5")]
    public JSON_LeagueMatchSetBuffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchSetBuffParam) null;
    }
  }
}
